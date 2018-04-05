using System;
using System.Threading.Tasks;
using Mobius.Entities;
using System.Collections.Generic;

namespace Mobius.Services
{
	public interface IAccountService
	{
		Task<UserProfile> SignUp(UserProfile userProfile);
		Task<AuthResponse> Login(string username, string password);
		Task<BaseResponse> ForgotPassword(string email);
		Task<UserProfile>  LoadUserProfile(string email);
		Task<BaseResponse> EditUserProfile(UserProfile userProfile);
	}
}