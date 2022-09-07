namespace CryptoGrimoire.Models
{
    public class Exchange
    {
        public int Id { get; set; }
        public string ExchangeName { get; set; }
        public string ExchangeUrl { get; set; }
        public string ExchangeLogoPath { get; set; }
        public string ExchangeDescription { get; set; }
        public string ExchangeApiUrl { get; set; }
        public string ExchangeWebSocketUrl { get; set; }
        public List<PageTradingPair>? PageTradingPairs { get; set; }

    }
}
