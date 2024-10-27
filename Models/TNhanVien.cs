using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CommentFunction.Models;

public partial class TNhanVien
{
    public int MaNhanVien { get; set; }

    public string Email { get; set; } = null!;

    public string? TenNhanVien { get; set; }

    public DateOnly? NgaySinh { get; set; }

    public string? ChucVu { get; set; }

    public string? GhiChu { get; set; }
}
