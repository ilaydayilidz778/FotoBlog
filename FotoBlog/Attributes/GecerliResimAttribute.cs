using System.ComponentModel.DataAnnotations;

namespace FotoBlog.Attributes
{
    public class GecerliResimAttribute : ValidationAttribute
    {
        public double MaxDosyaBoyutuMB { get; set; } = 1;

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value == null)
                return ValidationResult.Success;
            var dosya = (IFormFile?)value;
            if (!dosya.ContentType.StartsWith("image/"))
            {
                return new ValidationResult("Geçersiz resim dosyası.");
            }
            else if(dosya.Length > MaxDosyaBoyutuMB * 1024 * 1024 )
            {
                return new ValidationResult($"Maksimum dosya boyutu : {MaxDosyaBoyutuMB} MB");
            }

           return ValidationResult.Success;
        }
    }
}
