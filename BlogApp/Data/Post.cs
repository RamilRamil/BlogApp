using System;
namespace BlogApp.Data
{
	public class Post
	{
		public int Id { get; set; }
        public required string Title { get; set; }
		public required string Content { get; set; }
		public int? Like { get; set; }
		public int? Dislike { get; set; }

		public int UserId { get; set; }
		public required User User { get; set; }

		public ICollection<Image>? Images { get; set; }
    }
}

