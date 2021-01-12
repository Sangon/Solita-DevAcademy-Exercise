using System.Text.Json.Serialization;

namespace Solita_DevAcademy_Exercise {
    public class NameObject {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("amount")]
        public int Amount { get; set; }
    }
}