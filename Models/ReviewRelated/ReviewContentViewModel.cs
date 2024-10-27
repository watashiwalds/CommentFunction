namespace CommentFunction.Models.ReviewRelated
{
    public class ReviewContentViewModel
    {
        public int _reviewID { get; set; }
        public int _productID { get; set; }
        public int _userID { get; set; }
        public int? _emplID { get; set; }
        public string CsName { get; set; }
        public DateTime DatePosted { get; set; }
        public int StarRated { get; set; }
        public string? RvMessage { get; set; }
        public string? EpName { get; set; }
        public string? RpMessage { get; set; }
        public List<TPhanHoi> VotesCasted { get; set; } = new List<TPhanHoi>();
    }
}
