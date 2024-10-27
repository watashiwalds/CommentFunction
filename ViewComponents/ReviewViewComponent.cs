using CommentFunction.Data;
using CommentFunction.Models;
using Microsoft.AspNetCore.Mvc;

namespace CommentFunction.ViewComponents
{
    public class ReviewViewComponent : ViewComponent
    {
        QLBanDoThoiTrangContext db;
        List<TDanhGia> dgs;

        public ReviewViewComponent(QLBanDoThoiTrangContext _context) 
        {
            db = _context;
            dgs = db.TDanhGias.ToList();
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("ProductReview", dgs);
        }
    }
}
