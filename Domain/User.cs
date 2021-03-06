using System;
using System.Collections.Generic;

namespace Domain
{
    public class User
    {
        public Guid UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public List<Post> Posts { get; set; }
    }
}