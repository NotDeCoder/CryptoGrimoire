using System.ComponentModel.DataAnnotations;

namespace CryptoGrimoire.Models
{
    public class Exchange
    {
        public string Name { get; set; }

        public string ShortDesc { get; set; }

        public string LongDesc { get; set; }
        
        public string Url { get; set; }
        
        public string LogoPath { get; set; }
        
        public string ApiUrl { get; set; }
        
        public string WebSocketUrl { get; set; }
        
        public List<PageTradingPair>? PageTradingPairs { get; set; }

    }
}
