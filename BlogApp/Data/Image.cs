using System;
namespace BlogApp.Data
{
	public class Image
	{
		public int Id { get; set; }
        public string? ImageUrl { get; set; }

		public int PostId { get; set; }

		public Post? Post;
    }
}

