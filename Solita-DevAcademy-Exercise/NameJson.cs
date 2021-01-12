using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Solita_DevAcademy_Exercise {
    public class NameJson {
        [JsonPropertyName("names")]
        public List<NameObject> Names { get; set; }
    }
}