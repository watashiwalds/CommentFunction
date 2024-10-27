using Microsoft.Identity.Client;

namespace CommentFunction.Models
{
    public class TDanhGia
    {
        public int MaDanhGia { get; set; }
        public int MaKhachHang { get; set; }
        public int MaSP { get; set; }
        public DateTime NgayTao { get; set; }
        public int Diem { get; set; }
        public string? BinhLuan { get; set; }
        public int? Thich { get; set; }
        public int? KhongThich { get; set; }
        public int? MaNhanVien { get; set; }
        public string? TraLoi { get; set; }
        public int? HuuIch { get; set; }
    }
}
