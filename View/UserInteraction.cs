using SimpleCosmos.Service;
using System;
using System.Collections.Generic;

namespace SimpleCosmos.View
{
    public class UserInteraction
    {
        private readonly BlogService _blogService;

        public UserInteraction(BlogService blogService)
        {
            _blogService = blogService;
        }

        public async Task RunAsync()
        {
            while (true)
            {
                Console.WriteLine("Enter blog name (or type 'exit' to quit):");
                string blogName = Console.ReadLine();
                if (blogName.ToLower() == "exit") break;

                Console.WriteLine("Enter blog description:");
                string blogDescription = Console.ReadLine();

                Console.WriteLine("Enter post title:");
                string postTitle = Console.ReadLine();

                var cars = new List<(Guid carId, string carName)>();
                while (true)
                {
                    Console.WriteLine("Enter car name (or type 'done' to finish adding cars):");
                    string carName = Console.ReadLine();
                    if (carName.ToLower() == "done") break;

                    cars.Add((Guid.NewGuid(), carName));
                }

                await _blogService.AddBlogWithPostsAsync(blogName, blogDescription, postTitle, cars);
                Console.WriteLine("Blog added successfully!\n");
            }
        }
    }
}

