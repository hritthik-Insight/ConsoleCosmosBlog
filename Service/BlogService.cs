using SimpleCosmos.Data;
using SimpleCosmos.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SimpleCosmos.Service
{
    public class BlogService
    {
        private readonly BlogContext _context;

        public BlogService(BlogContext context)
        {
            _context = context;
        }

        public async Task AddBlogWithPostsAsync(string blogName, string blogDescription, string postTitle, List<(Guid carId, string carName)> cars)
        {
            var carEntities = new List<Car>();
            foreach (var car in cars)
            {
                carEntities.Add(new Car
                {
                    carId = car.carId,
                    carName = car.carName
                });
            }

            var post = new Post
            {
                Title = postTitle,
                Cars = carEntities
            };

            var blog = new Blog
            {
                Name = blogName,
                Description = blogDescription,
                Posts = new List<Post> { post }
            };

            _context.Blogs.Add(blog);
            await _context.SaveChangesAsync();
        }
    }
}
