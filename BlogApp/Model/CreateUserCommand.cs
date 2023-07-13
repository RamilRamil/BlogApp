using System;
using BlogApp.Data;

namespace BlogApp.Model
{
	public class CreateUserCommand : EditUserBase
	{
        public User ToUser() {
            return new User
            {
                UserName = UserName,
                Email = Email,
                Password = Password
            };
        }
    }
}

