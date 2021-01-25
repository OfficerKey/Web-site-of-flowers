using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Interfaces
{
    interface IAdminPanel
    {
        
        IActionResult Insert();
       
        IActionResult Update();
        IActionResult Delete(int id);
    }
}
