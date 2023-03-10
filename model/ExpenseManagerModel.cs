using System.Text.Json.Serialization;
using System.Text.Json;
using System.IO;
using MongoDB.Driver;
using MongoDB.Bson;

namespace life_assistant.model;

/// <summary>
/// Provides methods and properties to manipulate and access Entries,
/// methods for saving and loading data, validation and more.
/// </summary>
public class ExpenseManagerModel
{
    #region Fields
    public readonly string DefaultDataFilePath = @"./Data/Spending-Manager-Data.json";
    private string _workingDataFilePath;
    private List<EntrySchema> _entries = new();
    private Dictionary<Guid, string> _categories = new()
        {
            {Guid.Empty, "No category"},
        };
    private string _currencySign = "$";
    #endregion

    #region Properties
    /// <summary>
    /// Provides a copy of the Entries stored in this object.
    /// </summary>
    [JsonInclude]
    public List<EntrySchema> Entries { get => new(_entries); }
    /// <summary>
    /// Provides a copy of the Categories stored in the Expense Manager object.
    /// </summary>
    [JsonInclude]
    public Dictionary<Guid, string> Categories { get => new(_categories); }
    [JsonInclude]
    public string CurrencySign
    {
        get => _currencySign;
        set
        {
            if (string.IsNullOrEmpty(value))
                return;
            _currencySign = value;
        }
    }

    [JsonIgnore]
    public string WorkingDataFilePath { get => _workingDataFilePath; }
    #endregion

    #region Constructors
    public ExpenseManagerModel()
    {
        _workingDataFilePath = DefaultDataFilePath;
    }
    #endregion

    #region Methods

    public bool CategoryExists(Guid id)
    {
        return _categories.ContainsKey(id);
    }

    public bool CategoryNameExists(string categoryName)
    {
        foreach (var c in _categories)
        {
            if (c.Value == categoryName)
            {
                return true;
            }
        }
        return false;
    }

    public bool TryGetCategoryId(string categoryName, out Guid id)
    {
        foreach (var c in _categories)
        {
            if (c.Value == categoryName)
            {
                id = c.Key;
                return true;
            }
        }
        id = Guid.Empty;
        return false;
    }

    public bool TryGetCategoryName(Guid id, out string? categoryName)
    {
        return _categories.TryGetValue(id, out categoryName);
    }
    public void SaveDataToMongoDB(ExpenseManagerModel model)
    {
        // Replace "mongodb://localhost" with the connection string for your MongoDB server
        var mongoClient = new MongoClient("mongodb://localhost:27017");
        var database = mongoClient.GetDatabase("expense_manager");
        var collection = database.GetCollection<BsonDocument>("expenses");
        string data = JsonSerializer.Serialize<ExpenseManagerModel>(this,
            new JsonSerializerOptions { WriteIndented = true }
            );
        var filter = new BsonDocument();
        collection.DeleteMany(filter);
        BsonDocument document = BsonDocument.Parse(data);
        collection.InsertOne(document);
    }
    public void SaveData()
    {
        string data = JsonSerializer.Serialize<ExpenseManagerModel>(this,
            new JsonSerializerOptions { WriteIndented = true }
            );
        
        if (!Directory.Exists(Path.GetDirectoryName(_workingDataFilePath)))
            Directory.CreateDirectory(Path.GetDirectoryName(_workingDataFilePath));
        
        StreamWriter sw = new StreamWriter(_workingDataFilePath);
        sw.Write(data);
        sw.Close();
        SaveDataToMongoDB(this);
    }

    public void SaveDataTo(string path)
    {
        string data = JsonSerializer.Serialize<ExpenseManagerModel>(this,
            new JsonSerializerOptions { WriteIndented = true }
            );
        using StreamWriter sw = new(path);
        sw.Write(data);
        sw.Close();
    }
    public ExpenseManagerSchema LoadDataFromMongoDB(MongoClient mongoClient)
    {
        // Replace "mongodb://localhost" with the connection string for your MongoDB server
        // var mongoClient = new MongoClient("mongodb://localhost:27017");
        var database = mongoClient.GetDatabase("expense_manager");
        var collection = database.GetCollection<BsonDocument>("expenses");
        var filter = new BsonDocument();
        string _id = "_id";
        var document = collection.Find(filter).FirstOrDefault();
        document.Remove(_id);
        ExpenseManagerSchema? ret = JsonSerializer.Deserialize<ExpenseManagerSchema>(document.ToJson());
        return ret;
    }
    public bool LoadData()
    {
        if (!File.Exists(_workingDataFilePath))
            return false;
        using StreamReader sr = new(_workingDataFilePath);
        string json = sr.ReadToEnd();

        ExpenseManagerSchema? data = JsonSerializer.Deserialize<ExpenseManagerSchema>(json);
        if (data == null || data.Entries == null || data.Categories == null || data.CurrencySign == null)
        {
            return false;
        }
        _entries = new List<EntrySchema>(data.Entries);
        _categories = new Dictionary<Guid, string>(data.Categories);
        CurrencySign = data.CurrencySign;
        return true;
    }

    public bool LoadDataFrom(string path)
    {
        if (!File.Exists(path))
            return false;
        _workingDataFilePath = path;
        using StreamReader sr = new(path);
        string json = sr.ReadToEnd();

        ExpenseManagerSchema? data = JsonSerializer.Deserialize<ExpenseManagerSchema>(json);
        if (data == null || data.Entries == null || data.Categories == null || data.CurrencySign == null)
        {
            return false;
        }
        _entries = new List<EntrySchema>(data.Entries);
        _categories = new Dictionary<Guid, string>(data.Categories);
        CurrencySign = data.CurrencySign;
        return true;
    }

    public void AddEntry(EntrySchema e)
    {
        if (!_categories.ContainsKey(e.CategoryId))
            throw new ArgumentException("Category ID is not registered within the Expense Manager instance.");
        _entries.Add(e);
    }

    public Guid AddNewEntry(string title, string description, decimal value)
    {
        EntrySchema e = new(title, description, value);
        AddEntry(e);
        return e.Id;
    }

    public Guid AddCategory(string categoryName)
    {
        if (CategoryNameExists(categoryName))
            throw new ArgumentException("Category name is already registered within the Expense Manager instance.");
        Guid categoryId = Guid.NewGuid();
        _categories.Add(categoryId, categoryName);
        return categoryId;
    }

    public bool TryFindEntry(Guid id, out EntrySchema e)
    {
        e = null;
        foreach (var entry in _entries)
        {
            if (entry.Id == id)
            {
                e = entry;
                return true;
            }
        }
        return false;
    }

    public bool RemoveEntry(Guid id)
    {
        TryFindEntry(id, out EntrySchema e);
        return _entries.Remove(e);
    }

    public bool RenameCategory(Guid categoryId, string newName)
    {
        if (!_categories.ContainsKey(categoryId))
            return false;

        if (categoryId == Guid.Empty)
            return false;

        _categories[categoryId] = newName;
        return true;
    }

    public bool RemoveCategory(Guid categoryId)
    {
        if (!_categories.ContainsKey(categoryId))
            return false;
        foreach (var entry in _entries)
        {
            if (entry.CategoryId == categoryId)
            {
                entry.CategoryId = Guid.Empty;
            }
        }
        _categories.Remove(categoryId);
        return true;
    }
    #endregion
}