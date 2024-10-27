using CommentFunction.Data;
using CommentFunction.Models;

namespace CommentFunction.Controllers
{
    public static class StaticCookie
    {
        public static string _ckEmail { get; set; }
        public static string _ckRole { get; set; }
        public static int _webPID { get; set; }

    }
}
