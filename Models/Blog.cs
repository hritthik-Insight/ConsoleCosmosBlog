using System;
using System.Collections.Generic;

namespace SimpleCosmos.Models
{
    public class Blog
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Post> Posts { get; set; } = new List<Post>();
    }
}
