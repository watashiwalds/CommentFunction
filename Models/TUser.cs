using System.ComponentModel.DataAnnotations;

namespace CommentFunction.Models
{
    public partial class TUser
    {
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Email không hợp lệ")]
        public string Email { get; set; } = null!;

        public string Password { get; set; } = null!;

        public string? LoaiUser { get; set; }
        public string? Salt { get; set; } = null!;
    }

}
