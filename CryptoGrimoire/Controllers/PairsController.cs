using CryptoGrimoire.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CryptoGrimoire.Controllers
{
    public class PairsController : Controller
    {
        ApplicationDbContext db;
        public PairsController(ApplicationDbContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View(db.PageTradingPairs);
        }
        public IActionResult Details(string pairName)
        {
            PageTradingPair pageTradingPair = db.PageTradingPairs.FirstOrDefault(x => x.Name == pairName);

            if (pageTradingPair == null)
                return NotFound();

            ViewBag.ExchangeTradingPairs = db.ExchangeTradingPairs.Where(x => x.Name == pairName).ToList();

            string[] splitedName = pairName.Split('_', 2);
            
            string leftElementOfPair = splitedName[0];
            string rightElementOfPair = splitedName[1];

            ViewBag.OthersPairsWithLeftElementOfPair =
                db.PageTradingPairs.Where(x =>
                    x.Name != pairName &&
                    x.Name.Contains(leftElementOfPair + '_'))
                .ToList();

            ViewBag.OthersPairsWithRightElementOfPair =
                db.PageTradingPairs.Where(x =>
                    x.Name != pairName &&
                    x.Name.Contains('_' + rightElementOfPair))
                .ToList();

            return View(pageTradingPair);
        }
    }
}
