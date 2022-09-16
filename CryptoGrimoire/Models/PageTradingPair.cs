using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CryptoGrimoire.Models
{
    public class PageTradingPair
    {
        [Key]
        [MaxLength(21)]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
    }
}
