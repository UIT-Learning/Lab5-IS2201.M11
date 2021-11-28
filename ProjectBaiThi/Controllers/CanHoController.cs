using Microsoft.AspNetCore.Mvc;
using Lab5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab5.Controllers
{
    public class CanHoController : Controller
    {
        public IActionResult ThemCanHo()
        {
            return View();
        }
        [HttpPost]
        public string AddCanHo(CanHoModel canho)
        {
            int count;
            DataContext context = HttpContext.RequestServices.GetService(typeof(Lab5.Models.DataContext)) as DataContext;
            count = context.sqlInsertCanHo(canho);
            if (count == 1)
            {
                return "Thêm thành công";
            }
            return "Thêm thất bại";
        }
    }
}
