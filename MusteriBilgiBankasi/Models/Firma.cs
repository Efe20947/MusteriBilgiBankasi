using System.ComponentModel.DataAnnotations;

namespace MusteriTakip.Models
{
    public class Firma
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Firma Adı")]
        public string FirmaAdi{ get; set; }

        public string Yetkili { get; set; }

        public string Telefon { get; set; }

        public string Adres { get; set; }
    }
}