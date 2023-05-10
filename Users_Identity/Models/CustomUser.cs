using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Users_Identity.Models
{
    public class CustomUser : IdentityUser
    {
        [Display(Name ="Ad Soyad")]
        public string FullName { get; set; }

        [Display(Name = "Adres")]
        public string Adress { get; set; }

        [Display(Name = "Cinsiyet")]
        public string Gender { get; set; }

        [Display(Name = "Doğum Tarihi")]
        [DataType(DataType.DateTime)]
        public DateTime DateOfBirth { get; set; }

    }
}
