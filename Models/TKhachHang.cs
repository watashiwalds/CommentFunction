using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;

namespace CommentFunction.Models;

public partial class TKhachHang
{
    public int MaKhachHang { get; set; }

    public string Email { get; set; } = null!;

    public string? TenKhachHang { get; set; }

    public DateOnly? NgaySinh { get; set; }

    public string? SoDienThoai { get; set; }

    public string? DiaChi { get; set; }

    public string? GhiChu { get; set; }
}
