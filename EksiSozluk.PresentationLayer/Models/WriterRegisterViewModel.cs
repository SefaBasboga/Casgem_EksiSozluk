using EksiSozluk.EntityLayer.Concrete;
using System.ComponentModel.DataAnnotations;

namespace EksiSozluk.PresentationLayer.Models
{
    public class WriterRegisterViewModel
    {

        [Required(ErrorMessage = "Yazar adı alanı boş geçilemez")]
        public string WriterName { get; set; }

        [Required(ErrorMessage = "Yazar soyadı alanı boş geçilemez")]
        public string WriterSurname { get; set; }

        [Required(ErrorMessage = "Doğum tarihi alanı boş geçilemez")]
        public DateTime DateofBirth { get; set; }
        public string? WriterImageUrl { get; set; }
        public string WriterAbout { get; set; }

        [Required(ErrorMessage = "Email alanı boş geçilemez")]
        public string WriterEmail { get; set; }

        [Required(ErrorMessage = "Yazar başlığı alanı boş geçilemez")]
        public string WriterTitle { get; set; }

        [Required(ErrorMessage = "Yazar durumu alanı boş geçilemez")]
        public bool WriterStatus { get; set; }

        [Required(ErrorMessage = "Onay kodu alanı boş geçilemez")]
        public int? ConfirmCode { get; set; }

        [Required(ErrorMessage = "Şifre boş geçilmez.")]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Şifreler Uyuşmuyor")]
        public string ConfirmPassword { get; set; }
    }
}
