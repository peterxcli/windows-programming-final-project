using System.Text.Json.Serialization;

namespace life_assistant.model;

/// <summary>
/// Defines the ExpenseManager data schema.
/// </summary>
public class ExpenseManagerSchema
{
    public List<EntrySchema>? Entries { get; set; }
    public Dictionary<Guid, string>? Categories { get; set; }
    public string? CurrencySign { get; set; }
}

