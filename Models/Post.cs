using System;
using System.Collections.Generic;

namespace SimpleCosmos.Models
{
    public class Post
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime Created { get; set; } = DateTime.Now.Date;
        public List<Car> Cars { get; set; }
    }
}
