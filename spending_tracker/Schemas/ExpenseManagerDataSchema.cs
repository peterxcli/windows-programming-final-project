using System.Text.Json.Serialization;
using spending_tracker.Classes;

namespace spending_tracker.Schemas
{
    /// <summary>
    /// Defines the ExpenseManager data schema.
    /// </summary>
    public class ExpenseManagerDataSchema
    {
        public List<Entry>? Entries { get; set; }
        public Dictionary<Guid, string>? Categories { get; set; }
        public string? CurrencySign { get; set; }
    }
}
