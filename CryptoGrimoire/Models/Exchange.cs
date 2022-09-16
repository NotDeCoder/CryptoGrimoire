using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace CryptoGrimoire.Models
{
    public class Exchange
    {
        [Key]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(150)]
        public string ShortDesc { get; set; }
        [Required]
        public string LongDesc { get; set; }
        [Url]
        [Required]
        [MaxLength(50)]
        public string Url { get; set; }
        [Url]
        [MaxLength(150)]
        public string? LogoUrl { get; set; }
        [Url]
        [MaxLength(50)]
        public string? ApiUrl { get; set; }
        [Url]
        [MaxLength(50)]
        public string? WebSocketUrl { get; set; }
        [Url]
        [MaxLength(50)]
        public string? FeesUrl { get; set; }
        [Url]
        [MaxLength(50)]
        public string? BlogUrl { get; set; }
        [Url]
        [MaxLength(50)]
        public string? ChatUrl { get; set; }
        [Url]
        [MaxLength(50)]
        public string? TwitterAccountUrl { get; set; }
        //public List<PageTradingPair>? PageTradingPairs { get; set; }
    }
}
