using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Text.Json;
using System.IO;

namespace Solita_DevAcademy_Exercise.Controllers {

    [ApiController]
    [Produces("application/json")]
    [Route("[controller]")]
    public class NamesController : Controller {

        private static readonly NameJson NameList;

        static NamesController() {
            using (StreamReader sr = new StreamReader("names.json")) {
                string jsonString = sr.ReadToEnd();
                // Could also use Newtonsoft json.NET but would require importing a 3rd party library.
                NameList = JsonSerializer.Deserialize<NameJson>(jsonString);
            }
        }

        [Route("ByPopularity")]
        public NameObject[] ByPopularity() {

            var NameListByPopularity = NameList.Names
                .OrderByDescending(name => name.Amount)
                .ToArray();

            return NameListByPopularity;
        }

        [Route("AlphabeticalOrder")]
        public string[] AlphabeticalOrder() {

            var NameListAlphabetical = NameList.Names
                .Select(name => name.Name)
                .OrderBy(name => name)
                .ToArray();

            return NameListAlphabetical;
        }

        [Route("TotalAmount")]
        public int TotalAmount() {
            var NameListTotalAmount = NameList.Names
                 .Aggregate(0, (total, name) => total + name.Amount);

            // This returns just the number but that should be valid json as well. Could wrap it inside an object to format it like {"amount": 123123}
            return NameListTotalAmount;
        }

        [Route("NameAmount/{nameParameter}")]
        public int NameAmount(string nameParameter) {
            NameObject FoundName = NameList.Names
                .Find(name => name.Name == nameParameter);

            // Name was not found in the list so return the correct amount :).
            if (FoundName == null) {
                return 0;
            }

            // This returns just the number but that should be valid json as well. Could wrap it inside an object to format it like {"amount": 123123}
            return FoundName.Amount;
        }
    }
}
