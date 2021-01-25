using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.ViewModel
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Не указан Email")]
        public string email { get; set; }
        [Required(ErrorMessage = "Не указан Password")]
        public string password { get; set; }
    }
}
