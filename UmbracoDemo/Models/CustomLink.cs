using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace UmbracoDemo.Models
{
    public class CustomLink
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("target")]
        public string Target { get; set; }

        public CustomLink Deserialize(string json)
        {
            // Validate the JSON
            if (json == null || !json.StartsWith("{") || !json.EndsWith("}"))
            {
                return null;
            }

            // Deserialize the JSON
            var jobj = (JObject)JsonConvert.DeserializeObject(json);

            return new CustomLink
            {
                Id = (int)jobj["id"],
                Name = (string)jobj["name"],
                Url = (string)jobj["url"],
                Target = (string)jobj["target"]
            };
        }
    }
}