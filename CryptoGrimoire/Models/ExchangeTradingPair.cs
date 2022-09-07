using System.ComponentModel.DataAnnotations;

namespace CryptoGrimoire.Models
{
    public class ExchangeTradingPair
    {
        public int Id { get; set; }
        public string PairName { get; set; }
        public decimal PairSellPrice { get; set; }
        public decimal PairBuyPrice { get; set; }
        public decimal PairLastPrice { get; set; }
        public decimal PairVolume { get; set; }
        public decimal PairHigh { get; set; }
        public decimal PairLow { get; set; }
        public DateTime UpdatedDateTime { get; set; }
        public int ExchangeId { get; set; }
        public Exchange Exchange { get; set; }
    }
}
