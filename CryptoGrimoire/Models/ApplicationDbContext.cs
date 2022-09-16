using Microsoft.EntityFrameworkCore;

namespace CryptoGrimoire.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Exchange> Exchanges { get; set; }
        public DbSet<PageTradingPair> PageTradingPairs { get; set; }
        public DbSet<ExchangeTradingPair> ExchangeTradingPairs { get; set; }
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public ApplicationDbContext() { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Exchange>().HasData(
                new Exchange[]
                {
                    new Exchange { Name = "Binance", ShortDesc = "SBinD", LongDesc = "Long Binance Description", Url = "binance.com"},
                    new Exchange { Name = "Bittrex", ShortDesc = "SBitD", LongDesc = "Long Bittrex Description", Url = "bittrex.com"},
                    new Exchange { Name = "Poloniex", ShortDesc = "SPolD", LongDesc = "Long Poloniex Description", Url = "poloniex.com"},
                    new Exchange { Name = "Bitfinex", ShortDesc = "SBitfD", LongDesc = "Long Bitfinex Description", Url = "bitfinex.com"},
                    new Exchange { Name = "HitBTC", ShortDesc = "SHitD", LongDesc = "Long HitBTC Description", Url = "hitbtc.com"},
                    new Exchange { Name = "Exmo", ShortDesc = "SExmD", LongDesc = "Long Exmo Description", Url = "exmo.com"}

                });
            modelBuilder.Entity<PageTradingPair>().HasData(
                new PageTradingPair[]
                {
                    new PageTradingPair {Name = "btc_usdt", Description = "btc to usdt"},
                    new PageTradingPair {Name = "eth_usdt", Description = "eth to usdt"},
                    new PageTradingPair {Name = "xrp_usdt", Description = "xrp to usdt"},
                    new PageTradingPair {Name = "bch_usdt", Description = "bch to usdt"},
                    new PageTradingPair {Name = "ltc_usdt", Description = "ltc to usdt"},
                    new PageTradingPair {Name = "usdt_usd", Description = "usdt to usd"},
                });
            modelBuilder.Entity<ExchangeTradingPair>().HasData(
                new ExchangeTradingPair[]
                {
                    new ExchangeTradingPair { Id = 1, Name = "btc_usdt", ExchangeName = "Binance", SellPrice = 42500m, BuyPrice = 41599m, LastPrice = 42252m, High = 44153m, Low = 41111m, UpdatedDateTime = DateTime.Now, Volume = 13546213m},
                    new ExchangeTradingPair { Id = 2, Name = "eth_usdt", ExchangeName = "Binance", SellPrice = 1350m, BuyPrice = 1349m, LastPrice = 1350m, High = 1400m, Low = 1300m, UpdatedDateTime = DateTime.Now, Volume = 646133m},
                    new ExchangeTradingPair { Id = 3, Name = "xrp_usdt", ExchangeName = "Binance", SellPrice = 0.35m, BuyPrice = 0.34m, LastPrice = 0.35m, High = 0.36m, Low = 0.33m, UpdatedDateTime = DateTime.Now, Volume = 354513m},
                    new ExchangeTradingPair { Id = 4, Name = "bch_usdt", ExchangeName = "Binance", SellPrice = 250m, BuyPrice = 249m, LastPrice = 250m, High = 260m, Low = 240m, UpdatedDateTime = DateTime.Now, Volume = 121351m},
                    new ExchangeTradingPair { Id = 5, Name = "ltc_usdt", ExchangeName = "Binance", SellPrice = 120m, BuyPrice = 119m, LastPrice = 120m, High = 130m, Low = 110m, UpdatedDateTime = DateTime.Now, Volume = 354513m},

                    new ExchangeTradingPair { Id = 6, Name = "btc_usdt", ExchangeName = "Bittrex", SellPrice = 42500m, BuyPrice = 41599m, LastPrice = 42252m, High = 44153m, Low = 41111m, UpdatedDateTime = DateTime.Now, Volume = 13546213m},
                    new ExchangeTradingPair { Id = 7, Name = "eth_usdt", ExchangeName = "Bittrex", SellPrice = 1350m, BuyPrice = 1349m, LastPrice = 1350m, High = 1400m, Low = 1300m, UpdatedDateTime = DateTime.Now, Volume = 646133m},
                    new ExchangeTradingPair { Id = 8, Name = "xrp_usdt", ExchangeName = "Bittrex", SellPrice = 0.35m, BuyPrice = 0.34m, LastPrice = 0.35m, High = 0.36m, Low = 0.33m, UpdatedDateTime = DateTime.Now, Volume = 354513m},
                    new ExchangeTradingPair { Id = 9, Name = "ltc_usdt", ExchangeName = "Bittrex", SellPrice = 120m, BuyPrice = 119m, LastPrice = 120m, High = 130m, Low = 110m, UpdatedDateTime = DateTime.Now, Volume = 354513m},

                    new ExchangeTradingPair { Id = 10, Name = "btc_usdt", ExchangeName = "Poloniex", SellPrice = 42500m, BuyPrice = 41599m, LastPrice = 42252m, High = 44153m, Low = 41111m, UpdatedDateTime = DateTime.Now, Volume = 13546213m},
                    new ExchangeTradingPair { Id = 11, Name = "eth_usdt", ExchangeName = "Poloniex", SellPrice = 1350m, BuyPrice = 1349m, LastPrice = 1350m, High = 1400m, Low = 1300m, UpdatedDateTime = DateTime.Now, Volume = 646133m},
                    new ExchangeTradingPair { Id = 12, Name = "xrp_usdt", ExchangeName = "Poloniex", SellPrice = 0.35m, BuyPrice = 0.34m, LastPrice = 0.35m, High = 0.36m, Low = 0.33m, UpdatedDateTime = DateTime.Now, Volume = 354513m},

                    new ExchangeTradingPair { Id = 13, Name = "btc_usdt", ExchangeName = "Bitfinex", SellPrice = 42500m, BuyPrice = 41599m, LastPrice = 42252m, High = 44153m, Low = 41111m, UpdatedDateTime = DateTime.Now, Volume = 13546213m},
                    new ExchangeTradingPair { Id = 14, Name = "eth_usdt", ExchangeName = "Bitfinex", SellPrice = 1350m, BuyPrice = 1349m, LastPrice = 1350m, High = 1400m, Low = 1300m, UpdatedDateTime = DateTime.Now, Volume = 646133m},
                    new ExchangeTradingPair { Id = 15, Name = "xrp_usdt", ExchangeName = "Bitfinex", SellPrice = 0.35m, BuyPrice = 0.34m, LastPrice = 0.35m, High = 0.36m, Low = 0.33m, UpdatedDateTime = DateTime.Now, Volume = 354513m},
                    new ExchangeTradingPair { Id = 16, Name = "bch_usdt", ExchangeName = "Bitfinex", SellPrice = 250m, BuyPrice = 249m, LastPrice = 250m, High = 260m, Low = 240m, UpdatedDateTime = DateTime.Now, Volume = 121351m},

                    new ExchangeTradingPair { Id = 17, Name = "btc_usdt", ExchangeName = "HitBTC", SellPrice = 42500m, BuyPrice = 41599m, LastPrice = 42252m, High = 44153m, Low = 41111m, UpdatedDateTime = DateTime.Now, Volume = 13546213m},
                    new ExchangeTradingPair { Id = 18, Name = "eth_usdt", ExchangeName = "HitBTC", SellPrice = 1350m, BuyPrice = 1349m, LastPrice = 1350m, High = 1400m, Low = 1300m, UpdatedDateTime = DateTime.Now, Volume = 646133m},
                    new ExchangeTradingPair { Id = 19, Name = "xrp_usdt", ExchangeName = "HitBTC", SellPrice = 0.35m, BuyPrice = 0.34m, LastPrice = 0.35m, High = 0.36m, Low = 0.33m, UpdatedDateTime = DateTime.Now, Volume = 354513m},
                    new ExchangeTradingPair { Id = 20, Name = "bch_usdt", ExchangeName = "HitBTC", SellPrice = 250m, BuyPrice = 249m, LastPrice = 250m, High = 260m, Low = 240m, UpdatedDateTime = DateTime.Now, Volume = 121351m},
                    new ExchangeTradingPair { Id = 21, Name = "ltc_usdt", ExchangeName = "HitBTC", SellPrice = 120m, BuyPrice = 119m, LastPrice = 120m, High = 130m, Low = 110m, UpdatedDateTime = DateTime.Now, Volume = 354513m},

                    new ExchangeTradingPair { Id = 22, Name = "btc_usdt", ExchangeName = "Exmo", SellPrice = 42500m, BuyPrice = 41599m, LastPrice = 42252m, High = 44153m, Low = 41111m, UpdatedDateTime = DateTime.Now, Volume = 13546213m},
                    new ExchangeTradingPair { Id = 23, Name = "eth_usdt", ExchangeName = "Exmo", SellPrice = 1350m, BuyPrice = 1349m, LastPrice = 1350m, High = 1400m, Low = 1300m, UpdatedDateTime = DateTime.Now, Volume = 646133m},
                    new ExchangeTradingPair { Id = 24, Name = "xrp_usdt", ExchangeName = "Exmo", SellPrice = 0.35m, BuyPrice = 0.34m, LastPrice = 0.35m, High = 0.36m, Low = 0.33m, UpdatedDateTime = DateTime.Now, Volume = 354513m},
                    new ExchangeTradingPair { Id = 25, Name = "usdt_usd", ExchangeName = "Exmo", SellPrice = 1.02m, BuyPrice = 1.01m, LastPrice = 1.015m, High = 1.03m, Low = 1m, UpdatedDateTime = DateTime.Now, Volume = 45442445m},

                });
        }
    }
}
