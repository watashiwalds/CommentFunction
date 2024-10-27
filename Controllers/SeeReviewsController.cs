using CommentFunction.Data;
using CommentFunction.Models;
using Microsoft.AspNetCore.Mvc;

namespace CommentFunction.Controllers
{
    public class SeeReviewsController : Controller
    {
        private QLBanDoThoiTrangContext db;

        public SeeReviewsController(QLBanDoThoiTrangContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            return View(db.TDanhGias.ToList());
        }

        public IActionResult MakeReview() {
            return PartialView("MakeReview");
        }

        public IActionResult RefreshReview(int hmm)
        {
            int ok = hmm;
            return PartialView("Reviews", db.TDanhGias.ToList());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Diem,BinhLuan")] TDanhGia dg)
        {
            dg.MaKhachHang = 2;
            dg.MaSP = 1;
            dg.NgayTao = DateTime.Now;
            if (ModelState.IsValid)
            {
                db.TDanhGias.Add(dg);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirm(int id)
        {
            var review = db.TDanhGias.Find(id);
            db.TDanhGias.Remove(review);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
