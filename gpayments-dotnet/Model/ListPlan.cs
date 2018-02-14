using Newtonsoft.Json;

namespace gpayments.Model
{
    public class ListPlan
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("information")]
        public Plan Plan { get; set; }
    }
}
