using System.Diagnostics;
using System.IO;
using System.Text.Json;
using MaterialSkin.Controls;
using MaterialSkin;
using life_assistant.model;
using life_assistant.controller.spending_tracker;

namespace life_assistant.controller;

public partial class SpendingTrackerMainForm : MaterialForm
{
    #region Fields
    private readonly ExpenseManagerModel expenseManagerModel = new ();
    private readonly List<Predicate<EntrySchema>> _filters;
    private (decimal Income, decimal Expense) _total;
    private (decimal Income, decimal Expense) _visibleTotal;
    #endregion

    #region Constructor
    //private MaterialSkin.Controls.MaterialDateTimePicker datePicker;
    readonly MaterialSkin.MaterialSkinManager materialSkinManager;
    public SpendingTrackerMainForm()
    {
        expenseManagerModel.LoadData();
        InitializeComponent();
        materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
        materialSkinManager.EnforceBackcolorOnAllComponents = true;
        materialSkinManager.AddFormToManage(this);
        MaterialThemeManager materialThemeManager = new();
        materialThemeManager.setDefaultTheme(materialSkinManager);

        _filters = new()
            {
                DateRangeFilter,
                TypeFilter,
                CategoryFilter,
            };
    }
    #endregion

    #region Methods
    private (decimal Income, decimal Expense) CalculateTotal(List<EntrySchema> entries)
    {
        decimal income = 0, expense = 0;
        foreach (var e in entries)
        {
            if (e.IsIncome)
            {
                income += e.Value;
            }
            if (!e.IsIncome)
            {
                expense += e.Value;
            }
        }
        return (income, expense);
    }

    #region Filter Methods
    private List<EntrySchema> ApplyFilters()
    {
        List<EntrySchema> output = new();
        foreach (var entry in expenseManagerModel.Entries)
        {
            bool pass = true;
            foreach (var filter in _filters)
            {
                pass = pass && filter(entry);
            }
            if (pass)
                output.Add(entry);
        }
        _visibleTotal = CalculateTotal(output);
        UpdateVisibleSummary();
        return output;
    }

    private bool DateRangeFilter(EntrySchema e)
    {
        if (!checkBoxFilterDateTime.Checked)
            return true;
        if (e.CreatedAt >= filterFromDateTime.Value && e.CreatedAt <= filterToDateTime.Value)
            return true;
        return false;
    }

    private bool TypeFilter(EntrySchema e)
    {
        if (radioButtonAll.Checked)
            return true;
        if (radioButtonExpenses.Checked)
            return !e.IsIncome;
        if (radioButtonIncome.Checked)
            return e.IsIncome;
        return false;
    }

    private bool CategoryFilter(EntrySchema e)
    {
        if (comboBoxCategories.SelectedIndex == 0) // Show all categories
            return true;
        string categoryName = comboBoxCategories.SelectedItem.ToString()!;
        expenseManagerModel.TryGetCategoryId(categoryName, out Guid id);
        if (e.CategoryId == id)
            return true;
        return false;
    }
    #endregion

    #region UI Utilities
    private void UpdateTitle()
    {
        if (expenseManagerModel.DefaultDataFilePath != expenseManagerModel.WorkingDataFilePath)
        {
            Text = $"Spending Manager @ {expenseManagerModel.WorkingDataFilePath}";
            return;
        }
        Text = "Spending Manager";
    }

    private void PopulateListViewEntries()
    {
        List<EntrySchema> entries = ApplyFilters();

        // Sort by date of creation
        entries.Sort((e1, e2) => e1.CreatedAt.CompareTo(e2.CreatedAt));

        listViewEntries.Items.Clear();
        for (int i = entries.Count - 1; i >= 0; i--)
        {
            EntrySchema? entry = entries[i];
            var item = new ListViewItem(entry.Title);
            item.SubItems.Add($"{entry.Value} {expenseManagerModel.CurrencySign}");
            item.SubItems.Add(entry.CreatedAt.ToString());
            expenseManagerModel.TryGetCategoryName(entry.CategoryId, out string categoryName);
            item.SubItems.Add(categoryName);
            item.Tag = entry.Id;
            item.SubItems.Add((entry.IsIncome ? "income" : "expense"));
            listViewEntries.Items.Add(item);
        }
    }

    private void PopulateComboBoxCategories()
    {
        comboBoxCategories.Items.Clear();
        comboBoxCategories.Items.Add("Show all");
        comboBoxCategories.SelectedIndex = 0;
        comboBoxCategories.Items.AddRange(expenseManagerModel.Categories.Values.ToArray());
    }

    private void UpdateSummary()
    {
        labelSummary.Text = $"Summary: " +
            $"\u25bc {_total.Expense}{expenseManagerModel.CurrencySign}   " +
            $"\u25b2 {_total.Income}{expenseManagerModel.CurrencySign}   " +
            $"\u03a3 {_total.Income - _total.Expense}{expenseManagerModel.CurrencySign}";
    }

    private void UpdateVisibleSummary()
    {
        labelVisibleSummary.Text = $"Filtered summary: " +
            $"\u25bc {_visibleTotal.Expense}{expenseManagerModel.CurrencySign}   " +
            $"\u25b2{_visibleTotal.Income}{expenseManagerModel.CurrencySign}   " +
            $"\u03a3 {_visibleTotal.Income - _visibleTotal.Expense}{expenseManagerModel.CurrencySign}";
    }

    private void UpdateListViewAndSummary()
    {
        PopulateListViewEntries();
        _total = CalculateTotal(expenseManagerModel.Entries);
        UpdateSummary();
    }
    #endregion

    #region Events
    private void MainForm_Load(object sender, EventArgs e)
    {
        PopulateComboBoxCategories();
        // Init DateTime pickers
        filterFromDateTime.Value = new DateTime(DateTime.UtcNow.AddMonths(-1).Ticks);
        filterToDateTime.Value = new DateTime(DateTime.UtcNow.Ticks);
        UpdateListViewAndSummary();
    }

    private void checkBoxFilterDateTime_CheckedChanged(object sender, EventArgs e)
    {
        labelFilterFrom.Enabled = checkBoxFilterDateTime.Checked;
        labelFilterTo.Enabled = checkBoxFilterDateTime.Checked;
        filterFromDateTime.Enabled = checkBoxFilterDateTime.Checked;
        filterToDateTime.Enabled = checkBoxFilterDateTime.Checked;

        PopulateListViewEntries();
    }
    private void btnAddRecord_Click(object sender, EventArgs e)
    {
        var addNewEntryForm = new AddNewEntryForm(expenseManagerModel);
        addNewEntryForm.ShowDialog();
        UpdateListViewAndSummary();
        expenseManagerModel.SaveData();
    }

    private void comboBoxCategories_SelectedIndexChanged(object sender, EventArgs e)
    {
        PopulateListViewEntries();
    }

    private void radioButtonAll_CheckedChanged(object sender, EventArgs e)
    {
        PopulateListViewEntries();
    }

    private void radioButtonIncome_CheckedChanged(object sender, EventArgs e)
    {
        PopulateListViewEntries();
    }

    private void radioButtonExpenses_CheckedChanged(object sender, EventArgs e)
    {
        PopulateListViewEntries();
    }

    private void filterFromDateTime_ValueChanged(object sender, EventArgs e)
    {
        PopulateListViewEntries();
    }

    private void filterToDateTime_ValueChanged(object sender, EventArgs e)
    {
        PopulateListViewEntries();
    }

    private void contextMenuStripEntry_Opening(object sender, System.ComponentModel.CancelEventArgs e)
    {
        if (listViewEntries.SelectedItems.Count < 1)
        {
            e.Cancel = true;
            return;
        }
    }

    private void editToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Guid id = (Guid)listViewEntries.SelectedItems[0].Tag;

        EditExistingEntryForm editExistingEntryForm = new(expenseManagerModel, id);
        editExistingEntryForm.ShowDialog();
        UpdateListViewAndSummary();
        expenseManagerModel.SaveData();
    }

    private void showDescriptionMenuItem_Click(object sender, EventArgs e)
    {
        Guid id = (Guid)listViewEntries.SelectedItems[0].Tag;
        ShowDescriptionForm showDescriptionForm = new(expenseManagerModel, id);
        showDescriptionForm.ShowDialog();
    }

    private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
    {
        DialogResult result = MessageBox.Show("Do you really want to delete this entry?",
            "Warning",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);

        if (result == DialogResult.No)
        {
            return;
        }

        expenseManagerModel.RemoveEntry((Guid)listViewEntries.SelectedItems[0].Tag);
        UpdateListViewAndSummary();
        expenseManagerModel.SaveData();
    }

    private void saveAsFileMenuItem_Click(object sender, EventArgs e)
    {
        SaveFileDialog saveFileDialog = new()
        {
            InitialDirectory = Environment.CurrentDirectory,
            Filter = "json files (*.json) | *.json",
            FileName = "spending-manager-data.json",
            OverwritePrompt = true,
            AddExtension = true,
            DefaultExt = ".json",
            Title = "Save file"
        };
        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        {
            expenseManagerModel.SaveDataTo(saveFileDialog.FileName);
            MessageBox.Show($"Successfully saved file to: {saveFileDialog.FileName}.",
            "Success",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
            );
        }
        UpdateListViewAndSummary();
        UpdateTitle();
    }

    private void openMenuItem_Click(object sender, EventArgs e)
    {
        OpenFileDialog openFileDialog = new()
        {
            InitialDirectory = Environment.CurrentDirectory,
            Filter = "json files (*.json) | *.json",
            FileName = "expense-manager-data.json",
            AddExtension = true,
            DefaultExt = ".json",
            Title = "Open file"
        };
        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            expenseManagerModel.LoadDataFrom(openFileDialog.FileName);
            MessageBox.Show($"Successfully loaded data from: {openFileDialog.FileName}.",
            "Success",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
            );
        }
        UpdateListViewAndSummary();
        UpdateTitle();
    }

    private void manageCategoriesMenuItem_Click(object sender, EventArgs e)
    {
        ManageCategoriesForm manageCategoriesForm = new(expenseManagerModel);
        manageCategoriesForm.ShowDialog();
        PopulateComboBoxCategories();
        UpdateListViewAndSummary();
        expenseManagerModel.SaveData();
    }
    #endregion

    #endregion

    private void exportAsCsvMoreMenuItem_Click(object sender, EventArgs e)
    {
        SaveFileDialog saveFileDialog = new()
        {
            InitialDirectory = Environment.CurrentDirectory,
            Filter = "csv files (*.csv) | *.csv",
            FileName = "Spending-Manager-Export.csv",
            OverwritePrompt = true,
            AddExtension = true,
            DefaultExt = ".csv",
            Title = "Export data",
        };

        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        {
            expenseManagerModel.SaveDataTo(saveFileDialog.FileName);
            MessageBox.Show($"Successfully saved file to: {saveFileDialog.FileName}.",
            "Success",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
            );

            string data = "Title, Description, Value, Category name, Created at\n";
            foreach (var entry in expenseManagerModel.Entries)
            {
                expenseManagerModel.TryGetCategoryName(entry.CategoryId, out string categoryName);
                data += ($"{entry.Title}," +
                    $"{(string.IsNullOrWhiteSpace(entry.Description) ? "No description" : entry.Description)}," +
                    $"{entry.Value}," +
                    $"{categoryName}," +
                    $"{entry.CreatedAt}" +
                    $"\n");
            }
            using StreamWriter sw = new(saveFileDialog.FileName);
            sw.Write(data);
        }
    }

    private void optionsMoreMenuItem_Click(object sender, EventArgs e)
    {
        OptionsForm optionsForm = new(expenseManagerModel);
        optionsForm.ShowDialog();
        UpdateListViewAndSummary();
        expenseManagerModel.SaveData();
    }

    private void aboutMenu_Click(object sender, EventArgs e)
    {
        if (DialogResult.Yes == MessageBox.Show("This action will open the application GitHub repository in a web browser.\n" +
            "Do you want to continue?",
            "Confirmation",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question))
        {
            try
            {
                ProcessStartInfo processStartInfo = new()
                {
                    FileName = "https://github.com/peterxcli/windows-programming-final-project/tree/feature/spending-tracker",
                    UseShellExecute = true,
                };
                Process.Start(processStartInfo);
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot open a browser instance.\n" +
                    "You can open the link manually:\n" +
                    "https://github.com/peterxcli/windows-programming-final-project",
            "Warning",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning);
            }
        }
    }
    private void MainForm_FormClosed(object sender, FormClosedEventArgs e) {
        life_assistant.MainForm main = new life_assistant.MainForm();
        this.Hide();
        main.ShowDialog();
        this.Close();
    }
}