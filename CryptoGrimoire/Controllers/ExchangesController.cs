using CryptoGrimoire.Models;
using Microsoft.AspNetCore.Mvc;

namespace CryptoGrimoire.Controllers
{
    public class ExchangesController : Controller
    {
        List<Exchange> exchanges = new List<Exchange>() 
        {
            new Exchange()
                {
                    Name = "Exmo",
                    Url = "https://exmo.com",
                    LogoPath = "https://searchvectorlogo.com/wp-content/uploads/2019/10/exmo-logo-vector.png",
                    ShortDesc = "Exmo is a cryptocurrency exchange that offers a wide range of trading pairs and a high level of security.",
                    LongDesc = "Exmo is a cryptocurrency exchange that offers a wide range of trading pairs and a high level of security. The exchange is based in the UK and was founded in 2013. Exmo is a cryptocurrency exchange that offers a wide range of trading pairs and a high level of security. The exchange is based in the UK and was founded in 2013. Exmo is a cryptocurrency exchange that offers a wide range of trading pairs and a high level of security. The exchange is based in the UK and was founded in 2013. Exmo is a cryptocurrency exchange that offers a wide range of trading pairs and a high level of security. The exchange is based in the UK and was founded in 2013. Exmo is a cryptocurrency exchange that offers a wide range of trading pairs and a high level of security. The exchange is based in the UK and was founded in 2013. Exmo is a cryptocurrency exchange that offers a wide range of trading pairs and a high level of security. The exchange is based in the UK and was founded in 2013. Exmo is a cryptocurrency exchange that offers a wide range of trading pairs and a high level of security. The exchange is based in the UK and was founded in 2013. Exmo is a cryptocurrency exchange that offers a wide range of trading pairs and a high level of security. The exchange is based in the UK and was founded in 2013. Exmo is a cryptocurrency exchange that offers a wide range of trading pairs and a high level of security. The exchange is based in the UK and was founded in 2013. Exmo is a cryptocurrency exchange that offers a wide range of trading pairs and a high level of security. The exchange is based in the UK and was founded in 2013. Exmo is a cryptocurrency exchange that offers a wide range of trading pairs and a high level of security. The exchange is based in the UK and was founded in 2013. Exmo is a cryptocurrency exchange that offers a wide range of trading pairs and a high level of security. The exchange is based in the UK and was founded in 2013. Exmo is a cryptocurrency exchange that offers a wide range of trading pairs",
                    ApiUrl = "https://api.exmo.com/v1.1/",
                    WebSocketUrl = "https://ws-api.exmo.com/",
                },
            new Exchange()
                {
                    Name = "Binance",
                    Url = "https://www.binance.com/",
                    LogoPath = "https://public.bnbstatic.com/image/cms/blog/20220316/9a8927a3-4375-4804-b73d-99fdd4fa0951.png",
                    ShortDesc = "Binance short desk",
                    LongDesc = "Binance long desk",
                    ApiUrl = "https://api.binance.com",
                    WebSocketUrl = "wss://stream.binance.com:9443/",
                }
        };
        public IActionResult Index()
        {
            return View(exchanges);
        }
        public IActionResult Details(string exchangeName)
        {
            Exchange exchange = exchanges.FirstOrDefault(x => x.Name == exchangeName);
           
            if (exchange == null)
                return NotFound();
            
            return View(exchange);
        }
    }
}
