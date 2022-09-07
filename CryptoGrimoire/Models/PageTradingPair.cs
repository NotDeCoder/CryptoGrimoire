namespace CryptoGrimoire.Models
{
    public class PageTradingPair
    {
        public int Id { get; set; }
        public string PairName { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public bool IsFavourite { get; set; }

        //pairs from diferent exchanges
        public List<ExchangeTradingPair>? ExchangeTradingPairs { get; set; }
        
    }
}
