using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.ViewModel
{
    public class RegistrationViewModel
    {
        [Required(ErrorMessage = "Не указан Name")]
        public string Name { get; set; }
        [EmailAddress]

        [Required(ErrorMessage = "Не указан Email")]
        public string email { get; set; }
        [Required(ErrorMessage = "Не указан Password")]
        public string password { get; set; }

        [Required(ErrorMessage = "Пароль не совпадает")]
        public string ConfirmPassword { get; set; }
    }
}
