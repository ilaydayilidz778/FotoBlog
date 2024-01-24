using System.ComponentModel.DataAnnotations;

namespace FotoBlog.Data
{
    public class Gonderi
    {
        public int Id { get; set; }

        [Display(Name ="Başlık")]
        [Required(ErrorMessage ="{0} alanı zorunludur!")]
        public string Baslik { get; set; } = null!;

        [Display(Name = "Resim")]
        [Required(ErrorMessage = "{0} Koyulması Zorunludur")]
        [MaxLength(255)]
        public string ResimYolu { get; set; } = null!;

        // Not: string değerler nullable olmadığından dolayı zetan required olacaktır.
        // Eğer ki ViewModel kullanmayacaksak attribut'lar classta eklenir.
    }
}
