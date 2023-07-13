using System;
using BlogApp.Data;
using BlogApp.Model;
using Microsoft.Extensions.Logging;

namespace BlogApp
{
	public class UserService
	{
		readonly BlogAppDbContext _context;
		readonly ILogger _logger;

		public UserService(BlogAppDbContext context, ILoggerFactory factory)
		{
			_context = context;
			_logger = factory.CreateLogger<UserService>();
		}

		public async Task<int> CreateUser(CreateUserCommand cmd) {
			var user = cmd.ToUser();
			_context.Add(user);
			await _context.SaveChangesAsync();
			return user.Id;
		}
	}
}

