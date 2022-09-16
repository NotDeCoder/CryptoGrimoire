using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CryptoGrimoire.Models
{
    public class ExchangeTradingPair
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(21)]
        [ForeignKey("PageTradingPair")]
        public string Name { get; set; }
        [Required]
        [Column(TypeName = "decimal(20, 10)")]
        public decimal SellPrice { get; set; }
        [Required]
        [Column(TypeName = "decimal(20, 10)")]
        public decimal BuyPrice { get; set; }
        [Required]
        [Column(TypeName = "decimal(20, 10)")]
        public decimal LastPrice { get; set; }
        [Column(TypeName = "decimal(20, 10)")]
        public decimal Volume { get; set; }
        [Column(TypeName = "decimal(20, 10)")]
        public decimal High { get; set; }
        [Column(TypeName = "decimal(20, 10)")]
        public decimal Low { get; set; }
        public DateTime UpdatedDateTime { get; set; }
        [Required]
        [ForeignKey("Exchange")]
        public string ExchangeName { get; set; }
        //public Exchange Exchange { get; set; }
    }
}
