﻿using SchoolProject.Data.Helpers;

namespace SchoolProject.Core.Features.Authentication.Commands.Models
{
	public class SignInCommand : IRequest<Response<SignInResponse>>
	{
		public string UserName { get; set; }
		public string Password { get; set; }
	}
}
