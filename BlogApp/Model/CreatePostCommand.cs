using System;
using BlogApp.Data;

namespace BlogApp.Model
{
	public class CreatePostCommand
	{
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string Content { get; set; }
        public int? Like { get; set; }
        public int? Dislike { get; set; }

        public int UserId { get; set; }
        public required User User { get; set; }

        public ICollection<Image>? Images { get; set; }

        public Post ToPost() {
            return new Post
            {
                UserId = UserId,
                User = User,
                Title = Title,
                Content = Content
            };
        }
    }
}

