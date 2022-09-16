using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CryptoGrimoire.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Exchanges",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ShortDesc = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    LongDesc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LogoUrl = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    ApiUrl = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    WebSocketUrl = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FeesUrl = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BlogUrl = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ChatUrl = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TwitterAccountUrl = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exchanges", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "ExchangeTradingPairs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(21)", maxLength: 21, nullable: false),
                    SellPrice = table.Column<decimal>(type: "decimal(20,10)", nullable: false),
                    BuyPrice = table.Column<decimal>(type: "decimal(20,10)", nullable: false),
                    LastPrice = table.Column<decimal>(type: "decimal(20,10)", nullable: false),
                    Volume = table.Column<decimal>(type: "decimal(20,10)", nullable: false),
                    High = table.Column<decimal>(type: "decimal(20,10)", nullable: false),
                    Low = table.Column<decimal>(type: "decimal(20,10)", nullable: false),
                    UpdatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExchangeName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExchangeTradingPairs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PageTradingPairs",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(21)", maxLength: 21, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PageTradingPairs", x => x.Name);
                });

            migrationBuilder.InsertData(
                table: "ExchangeTradingPairs",
                columns: new[] { "Id", "BuyPrice", "ExchangeName", "High", "LastPrice", "Low", "Name", "SellPrice", "UpdatedDateTime", "Volume" },
                values: new object[,]
                {
                    { 1, 41599m, "Binance", 44153m, 42252m, 41111m, "btc_usdt", 42500m, new DateTime(2022, 9, 16, 14, 46, 31, 154, DateTimeKind.Local).AddTicks(7821), 13546213m },
                    { 2, 1349m, "Binance", 1400m, 1350m, 1300m, "eth_usdt", 1350m, new DateTime(2022, 9, 16, 14, 46, 31, 154, DateTimeKind.Local).AddTicks(7857), 646133m },
                    { 3, 0.34m, "Binance", 0.36m, 0.35m, 0.33m, "xrp_usdt", 0.35m, new DateTime(2022, 9, 16, 14, 46, 31, 154, DateTimeKind.Local).AddTicks(7862), 354513m },
                    { 4, 249m, "Binance", 260m, 250m, 240m, "bch_usdt", 250m, new DateTime(2022, 9, 16, 14, 46, 31, 154, DateTimeKind.Local).AddTicks(7865), 121351m },
                    { 5, 119m, "Binance", 130m, 120m, 110m, "ltc_usdt", 120m, new DateTime(2022, 9, 16, 14, 46, 31, 154, DateTimeKind.Local).AddTicks(7894), 354513m },
                    { 6, 41599m, "Bittrex", 44153m, 42252m, 41111m, "btc_usdt", 42500m, new DateTime(2022, 9, 16, 14, 46, 31, 154, DateTimeKind.Local).AddTicks(7897), 13546213m },
                    { 7, 1349m, "Bittrex", 1400m, 1350m, 1300m, "eth_usdt", 1350m, new DateTime(2022, 9, 16, 14, 46, 31, 154, DateTimeKind.Local).AddTicks(7899), 646133m },
                    { 8, 0.34m, "Bittrex", 0.36m, 0.35m, 0.33m, "xrp_usdt", 0.35m, new DateTime(2022, 9, 16, 14, 46, 31, 154, DateTimeKind.Local).AddTicks(7902), 354513m },
                    { 9, 119m, "Bittrex", 130m, 120m, 110m, "ltc_usdt", 120m, new DateTime(2022, 9, 16, 14, 46, 31, 154, DateTimeKind.Local).AddTicks(7904), 354513m },
                    { 10, 41599m, "Poloniex", 44153m, 42252m, 41111m, "btc_usdt", 42500m, new DateTime(2022, 9, 16, 14, 46, 31, 154, DateTimeKind.Local).AddTicks(7907), 13546213m },
                    { 11, 1349m, "Poloniex", 1400m, 1350m, 1300m, "eth_usdt", 1350m, new DateTime(2022, 9, 16, 14, 46, 31, 154, DateTimeKind.Local).AddTicks(7909), 646133m },
                    { 12, 0.34m, "Poloniex", 0.36m, 0.35m, 0.33m, "xrp_usdt", 0.35m, new DateTime(2022, 9, 16, 14, 46, 31, 154, DateTimeKind.Local).AddTicks(7912), 354513m },
                    { 13, 41599m, "Bitfinex", 44153m, 42252m, 41111m, "btc_usdt", 42500m, new DateTime(2022, 9, 16, 14, 46, 31, 154, DateTimeKind.Local).AddTicks(7914), 13546213m },
                    { 14, 1349m, "Bitfinex", 1400m, 1350m, 1300m, "eth_usdt", 1350m, new DateTime(2022, 9, 16, 14, 46, 31, 154, DateTimeKind.Local).AddTicks(7917), 646133m },
                    { 15, 0.34m, "Bitfinex", 0.36m, 0.35m, 0.33m, "xrp_usdt", 0.35m, new DateTime(2022, 9, 16, 14, 46, 31, 154, DateTimeKind.Local).AddTicks(7919), 354513m },
                    { 16, 249m, "Bitfinex", 260m, 250m, 240m, "bch_usdt", 250m, new DateTime(2022, 9, 16, 14, 46, 31, 154, DateTimeKind.Local).AddTicks(7921), 121351m },
                    { 17, 41599m, "HitBTC", 44153m, 42252m, 41111m, "btc_usdt", 42500m, new DateTime(2022, 9, 16, 14, 46, 31, 154, DateTimeKind.Local).AddTicks(7924), 13546213m },
                    { 18, 1349m, "HitBTC", 1400m, 1350m, 1300m, "eth_usdt", 1350m, new DateTime(2022, 9, 16, 14, 46, 31, 154, DateTimeKind.Local).AddTicks(7926), 646133m },
                    { 19, 0.34m, "HitBTC", 0.36m, 0.35m, 0.33m, "xrp_usdt", 0.35m, new DateTime(2022, 9, 16, 14, 46, 31, 154, DateTimeKind.Local).AddTicks(7928), 354513m },
                    { 20, 249m, "HitBTC", 260m, 250m, 240m, "bch_usdt", 250m, new DateTime(2022, 9, 16, 14, 46, 31, 154, DateTimeKind.Local).AddTicks(7931), 121351m },
                    { 21, 119m, "HitBTC", 130m, 120m, 110m, "ltc_usdt", 120m, new DateTime(2022, 9, 16, 14, 46, 31, 154, DateTimeKind.Local).AddTicks(7933), 354513m },
                    { 22, 41599m, "Exmo", 44153m, 42252m, 41111m, "btc_usdt", 42500m, new DateTime(2022, 9, 16, 14, 46, 31, 154, DateTimeKind.Local).AddTicks(7935), 13546213m },
                    { 23, 1349m, "Exmo", 1400m, 1350m, 1300m, "eth_usdt", 1350m, new DateTime(2022, 9, 16, 14, 46, 31, 154, DateTimeKind.Local).AddTicks(7938), 646133m },
                    { 24, 0.34m, "Exmo", 0.36m, 0.35m, 0.33m, "xrp_usdt", 0.35m, new DateTime(2022, 9, 16, 14, 46, 31, 154, DateTimeKind.Local).AddTicks(7940), 354513m },
                    { 25, 1.01m, "Exmo", 1.03m, 1.015m, 1m, "usdt_usd", 1.02m, new DateTime(2022, 9, 16, 14, 46, 31, 154, DateTimeKind.Local).AddTicks(7943), 45442445m }
                });

            migrationBuilder.InsertData(
                table: "Exchanges",
                columns: new[] { "Name", "ApiUrl", "BlogUrl", "ChatUrl", "FeesUrl", "LogoUrl", "LongDesc", "ShortDesc", "TwitterAccountUrl", "Url", "WebSocketUrl" },
                values: new object[,]
                {
                    { "Binance", null, null, null, null, null, "Long Binance Description", "SBinD", null, "binance.com", null },
                    { "Bitfinex", null, null, null, null, null, "Long Bitfinex Description", "SBitfD", null, "bitfinex.com", null },
                    { "Bittrex", null, null, null, null, null, "Long Bittrex Description", "SBitD", null, "bittrex.com", null },
                    { "Exmo", null, null, null, null, null, "Long Exmo Description", "SExmD", null, "exmo.com", null },
                    { "HitBTC", null, null, null, null, null, "Long HitBTC Description", "SHitD", null, "hitbtc.com", null },
                    { "Poloniex", null, null, null, null, null, "Long Poloniex Description", "SPolD", null, "poloniex.com", null }
                });

            migrationBuilder.InsertData(
                table: "PageTradingPairs",
                columns: new[] { "Name", "Description" },
                values: new object[,]
                {
                    { "bch_usdt", "bch to usdt" },
                    { "btc_usdt", "btc to usdt" },
                    { "eth_usdt", "eth to usdt" },
                    { "ltc_usdt", "ltc to usdt" },
                    { "usdt_usd", "usdt to usd" },
                    { "xrp_usdt", "xrp to usdt" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Exchanges");

            migrationBuilder.DropTable(
                name: "ExchangeTradingPairs");

            migrationBuilder.DropTable(
                name: "PageTradingPairs");
        }
    }
}
