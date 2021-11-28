using Microsoft.AspNetCore.Mvc;
using Lab5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab5.Controllers
{
    public class NhanVienController : Controller
    {
        public IActionResult LietKeNhanVien()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ListNhanVienByTime(int SoLanSua)
        {
            DataContext context = HttpContext.RequestServices.GetService(typeof(Lab5.Models.DataContext)) as DataContext;
            return View(context.sqlListByTimeNhanVien(SoLanSua));
        }
        public IActionResult QuanLyNhanVien()
        {
            DataContext context = HttpContext.RequestServices.GetService(typeof(Lab5.Models.DataContext)) as DataContext;
            return View(context.sqlListNhanVien());
        }
        [HttpPost]
        public IActionResult ListSelectedOfNhanVien(string MaNhanVien)
        {
            //@ViewBag.Ma = MaNhanVien;
            DataContext context = HttpContext.RequestServices.GetService(typeof(Lab5.Models.DataContext)) as DataContext;
            return View(context.sqlListNV_BTByNhanVien(MaNhanVien));
        }

        //[HttpPost]
        public IActionResult Delete(string manhanvien, string mathietbi, string macanho, string lanthu)
        {
            DataContext context = HttpContext.RequestServices.GetService(typeof(Lab5.Models.DataContext)) as DataContext;
            //Models.NV_BTModel.Remove(nv_bt);
            context.sqlDeleteNV_BT(manhanvien, mathietbi, macanho, lanthu);
            return RedirectToAction(nameof(QuanLyNhanVien)); 
        }
        public IActionResult ViewDetail(string manhanvien, string mathietbi, string macanho, string lanthu)
        {
            DataContext context = HttpContext.RequestServices.GetService(typeof(Lab5.Models.DataContext)) as DataContext;
            return View(context.sqlGetNV_BT(manhanvien, mathietbi, macanho, lanthu));
        }
        public IActionResult UpdateNV_BT(NV_BTModel nv_bt)
        {
            DataContext context = HttpContext.RequestServices.GetService(typeof(Lab5.Models.DataContext)) as DataContext;
            context.sqlUpdateNV_BT(nv_bt);
            return RedirectToAction(nameof(QuanLyNhanVien));
        }
    }
}
