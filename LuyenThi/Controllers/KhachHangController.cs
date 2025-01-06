using LuyenThi.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace LuyenThi.Controllers
{
    public class KhachHangController : Controller
    {
        private readonly AppDbContext _db;
        public KhachHangController(AppDbContext db) {_db = db;}
        public AppDbContext Db => _db;
        public IActionResult Index()
        {
            var listKhachHang = _db.KhachHangs.ToList();
            return View(listKhachHang);
        }
        public IActionResult Details(Guid Id)
        {
            var kh = _db.KhachHangs.Find(Id);
            return View(kh);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(KhachHang kh)
        {
            _db.KhachHangs.Add(kh);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(Guid Id)
        {
            var kh = _db.KhachHangs.Find(Id);
            var jsonData = JsonConvert.SerializeObject(kh);
            HttpContext.Session.SetString("edited",jsonData);
            return View(kh);
        }
        [HttpPost]
        public IActionResult Edit(KhachHang kh)
        {
            _db.KhachHangs.Update(kh);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(Guid Id)
        {
            var kh = _db.KhachHangs.Find(Id);
            var jsonData = JsonConvert.SerializeObject(kh);
            HttpContext.Session.SetString("deleted", jsonData);
            _db.KhachHangs.Remove(kh);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult RollBack()
        {
            if (HttpContext.Session.Keys.Contains("edited"))
            {
                var jsonData = HttpContext.Session.GetString("edited");
                var editKH = JsonConvert.DeserializeObject<KhachHang>(jsonData);
                _db.KhachHangs.Update(editKH);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return Content("khong co data");
            }
        }
    }
}
