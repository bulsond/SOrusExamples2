using Newtonsoft.Json;

namespace BelTamojService.Models
{
    public class Page
    {
        public Result[] result { get; set; } = new Result[0];

        [JsonIgnore]
        public string StatusCode { get; set; }
    }
}
