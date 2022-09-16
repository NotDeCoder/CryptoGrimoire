using CryptoGrimoire.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CryptoGrimoire.Controllers
{
    public class ExchangesController : Controller
    {
        ApplicationDbContext db;
        public ExchangesController(ApplicationDbContext context)
        {
            db = context;
        }

        public IActionResult Index()
        {
            return View(db.Exchanges);
        }
        public IActionResult Details(string exchangeName)
        {
            Exchange exchange = db.Exchanges.FirstOrDefault(x => x.Name == exchangeName);
           
            if (exchange == null)
                return NotFound();

            ViewBag.TradingPairs = 
                db.ExchangeTradingPairs.Where(x => x.ExchangeName == exchangeName)
                .Select(x => db.PageTradingPairs.FirstOrDefault(y => y.Name == x.Name)).ToList();
            
            return View(exchange);
        }
    }
}
