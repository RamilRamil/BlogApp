using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogApp.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BlogApp.Pages.Users
{
	public class CreateModel : PageModel
    {
        [BindProperty]
        public CreateUserCommand Input { get; set; }
        private readonly UserService _service;

        public CreateModel(UserService service)
        {
            _service = service;
        }

        public void OnGet()
        {
            Input = new CreateUserCommand();
        }
    }
}
