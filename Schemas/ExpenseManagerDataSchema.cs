using System.Text.Json.Serialization;
using final_project.Classes;

namespace final_project.Schemas;

/// <summary>
/// Defines the ExpenseManager data schema.
/// </summary>
public class ExpenseManagerDataSchema
{
    public List<Entry>? Entries { get; set; }
    public Dictionary<Guid, string>? Categories { get; set; }
    public string? CurrencySign { get; set; }
}

