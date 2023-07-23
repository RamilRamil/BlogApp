using System;
using Microsoft.EntityFrameworkCore;

namespace BlogApp.Data
{
	public class BlogAppDbContext : DbContext
	{
		public BlogAppDbContext(DbContextOptions<BlogAppDbContext> options) : base(options) 
		{
		}

		public DbSet<User> Users { get; set; }
		public DbSet<Post> Posts { get; set; }
        public DbSet<Image> Images { get; set; }
    }
}


