using Microsoft.EntityFrameworkCore;
using SimpleCosmos.Models;
using Microsoft.Extensions.Configuration;
using System.Configuration;

namespace SimpleCosmos.Data
{
    public class BlogContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public BlogContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public DbSet<Blog> Blogs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var endpoint = _configuration["cosmosdb:endpoint"];
            var key = _configuration["cosmosdb:key"];
            var database = _configuration["cosmosdb:database"];

            optionsBuilder.UseCosmos(
                endpoint!, 
                key!, 
                database!
                );
            base.OnConfiguring(optionsBuilder);
        }
    }
}

