using CryptoGrimoire.Models;
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

            string leftElementOfPair = pairName.Split('_', StringSplitOptions.None)[0];
            string rightElementOfPair = pairName.Split('_', StringSplitOptions.None)[1];

            ViewBag.OthersPairsWithLeftElementOfPair =
                db.PageTradingPairs.ToList().Where(x =>
                    x.Name != pairName && (
                    leftElementOfPair == x.Name.Split('_', StringSplitOptions.None)[0] ||
                    leftElementOfPair == x.Name.Split('_', StringSplitOptions.None)[1]))
                .ToList();

            ViewBag.OthersPairsWithRightElementOfPair =
                db.PageTradingPairs.ToList().Where(x =>
                    x.Name != pairName && (
                    rightElementOfPair == x.Name.Split('_', StringSplitOptions.None)[0] ||
                    rightElementOfPair == x.Name.Split('_', StringSplitOptions.None)[1]))
                .ToList();

            return View(pageTradingPair);
        }
    }
}
