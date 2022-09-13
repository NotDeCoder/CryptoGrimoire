using System.ComponentModel.DataAnnotations;

namespace CryptoGrimoire.Models
{
    public class ExchangeTradingPair
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal SellPrice { get; set; }
        public decimal BuyPrice { get; set; }
        public decimal LastPrice { get; set; }
        public float Volume { get; set; }
        public decimal High { get; set; }
        public decimal Low { get; set; }
        public DateTime UpdatedDateTime { get; set; }
        public int ExchangeId { get; set; }
        //public Exchange Exchange { get; set; }
    }
}
