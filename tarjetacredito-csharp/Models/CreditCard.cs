using System.ComponentModel.DataAnnotations;

namespace tarjetacredito_csharp.Models
{
    public class CreditCard
    {
        public int Id { get; set; }

        [Required]
        public string NameHolder { get; set; }

        [Required]
        public string NumberCardCredit { get; set; }

        [Required]
        public string MonthExpiration { get; set; }

        [Required]
        public string YearExpiration { get; set; }

        [Required]
        public string CVV { get; set; }
    }
}
