using Newtonsoft.Json;

namespace gpayments.Model
{
    public class Card
    {
        public string CardNumber { get; set; }
        public string Last4 { get; set; }
        [JsonProperty("Exp_Year")]
        public int ExpirationYear { get; set; }

        [JsonProperty("Exp_Month")]
        public int ExpirationMonth { get; set; }
        public string Brand { get; set; }
        public string CVC { get; set; }
    }
}
