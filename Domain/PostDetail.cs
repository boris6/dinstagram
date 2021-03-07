using System;

namespace Domain
{
    public class PostDetail
    {
        public Guid PostDetailId { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; }
        public Guid PostId { get; set; }
        public Post Post { get; set; }
    }
}