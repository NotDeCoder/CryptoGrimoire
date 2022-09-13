using CryptoGrimoire.Models;
using Microsoft.AspNetCore.Mvc;

namespace CryptoGrimoire.Controllers
{
    public class PairsController : Controller
    {
        /*
         [Key]
        public int Id { get; set; }
        
        [Required]
        public string PairName { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public bool IsFavourite { get; set; }

        //pairs from diferent exchanges
        public List<ExchangeTradingPair>? ExchangeTradingPairs { get; set; }
         */
        List<PageTradingPair> pageTradingPairs = new List<PageTradingPair>()
        {
            new PageTradingPair()
            {
                Name = "BTC/USDT",
                Description = "Bitcoin to USDT",
                ImagePath = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/46/Bitcoin.svg/1200px-Bitcoin.svg.png",
                IsFavourite = false,
            },
            new PageTradingPair()
            {
                Name = "ETH/USDT",
                Description = "Etherium to USDT",
                ImagePath = "https://statics.ambcrypto.com/wp-content/uploads/2022/05/ethereum-6278326_1280-1000x600.png",
                IsFavourite = true,
            },
        };
        public IActionResult Index()
        {
            return View(pageTradingPairs);
        }
        public IActionResult Details(string pairName)
        {
            PageTradingPair pageTradingPair = pageTradingPairs.FirstOrDefault(x => x.Name == pairName);

            if (pageTradingPair == null)
                return NotFound();

            return View(pageTradingPair);
        }
    }
}
