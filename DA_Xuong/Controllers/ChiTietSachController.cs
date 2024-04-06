using DA_Xuong.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DA_Xuong.Controllers
{
    public class ChiTietSachController : Controller
    {
        private readonly ApplicationDBContext _db;
        public ChiTietSachController(ApplicationDBContext db)
        {
            _db = db;
        }
        [Route("/ChiTiet/Index/{id}")]
        public IActionResult Index(int id)
        {
            var item = _db.SACH.Find(id);
            //var project = _db.SACH.FirstOrDefault(p => p.IDSACH == id);
            var project = _db.SACH.Include(p => p.TACGIA);
            return View(item);
        }
    }
}
