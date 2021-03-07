using System;
using System.Collections.Generic;

namespace Domain
{
    public class Post
    {
        public Guid PostId { get; set; }
        public string Description { get; set; }
        public DateTime Timestamp { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public List<PostDetail> PostDetails { get; set; }
    }
}