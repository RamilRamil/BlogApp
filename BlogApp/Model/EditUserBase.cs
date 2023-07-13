using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using BlogApp.Data;

namespace BlogApp.Model
{
	public class EditUserBase
	{
        [Required, StringLength(100), DisplayName("Username")]
        public string UserName { get; set; }
        [Required, StringLength(100), DisplayName("Email")]
        public string Email { get; set; }
        [Required, StringLength(100), DisplayName("Password")]
        public string Password { get; set; }
        public ICollection<Post>? Posts { get; set; }
	}
}

