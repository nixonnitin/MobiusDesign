using System.Threading.Tasks;
using Mobius.Entities;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using System;
using Mobius.Services.Helper;

namespace Mobius.Services
{
	public class AccountService : IAccountService
	{
		private readonly IHttpService httpService;
		private readonly IPlatformService platformService;

		public AccountService(IHttpService httpService, IPlatformService platformService)
		{
			this.httpService = httpService;
			this.platformService = platformService;
		}

		/// <summary>
		/// Signs up.
		/// </summary>
		/// <returns>The up.</returns>
		/// <param name="userProfile">User profile.</param>
		public Task<UserProfile> SignUp(UserProfile userProfile)
		{
			JObject oJsonObject = new JObject();
			oJsonObject.Add("Title", "NA");
			oJsonObject.Add("FirstName", userProfile.FirstName);
			oJsonObject.Add("LastName", userProfile.LastName);
			oJsonObject.Add("Country", "NA");
			oJsonObject.Add("Email", userProfile.Email);
			oJsonObject.Add("ConfirmEmail", userProfile.Email);
			oJsonObject.Add("Password", userProfile.Password);
			oJsonObject.Add("ConfirmPassword", userProfile.Password);
			oJsonObject.Add("Gender", "NA");
			oJsonObject.Add("tc", true);
			oJsonObject.Add("privacy", true);
			        

			return httpService.PostAsync<UserProfile>(oJsonObject, "https://staging-sso.mobiusbookingengine.com/oauth/register");
		}

		//public async Task<ValidationResponse> SendVerificationCode(string email)
		//{
		//	var data = new { email };
		//	return await httpService.PostAsync<ValidationResponse>(data, UrlHelper.VerifyEmailUrl);
		//}

		//public async Task<ValidationResponse> VerifyAccount(string email, string code)
		//{
		//	var data = new { email, code };
		//	var response = await httpService.PostAsync<ValidationResponse>(data, UrlHelper.VerifyAccountUrl);
		//	return response;
		//}

		/// <summary>
		/// Login the specified email and password.
		/// </summary>
		/// <returns>The login.</returns>
		/// <param name="email">Email.</param>
		/// <param name="password">Password.</param>
		public async Task<AuthResponse> Login(string email, string password)
		{
			JObject oJsonObject = new JObject();
			oJsonObject.Add("Email", email);
			oJsonObject.Add("Password", password);
            oJsonObject.Add("StaySignedIn", "false");
			var response = await httpService.PostAsync(oJsonObject, UrlHelper.LoginUrl);

			return response;
		}

		/// <summary>
		/// Forgots the password.
		/// </summary>
		/// <returns>The password.</returns>
		/// <param name="email">Email.</param>
		public async Task<BaseResponse> ForgotPassword(string email)
		{
			var data = new { email };
			var resetPasswordUrl = $"{UrlHelper.ForgotPasswordUrl}";
			var response = await httpService.PostAsync<BaseResponse>(data, resetPasswordUrl);
			return response;
		}

		/// <summary>
		/// Loads the user profile.
		/// </summary>
		/// <returns>The user profile.</returns>
		/// <param name="email">Email.</param>
		public async Task<UserProfile> LoadUserProfile(string email)
		{
			var profile = await httpService.GetAsync<UserProfile>($"{UrlHelper.LoadUserProfileUrl}?email={email}");

			return profile;
		}

		/// <summary>
		/// Edits the user profile.
		/// </summary>
		/// <returns>The user profile.</returns>
		/// <param name="userProfile">User profile.</param>
		public async Task<BaseResponse> EditUserProfile(UserProfile userProfile)
		{
			return await httpService.PostAsync<BaseResponse>(userProfile, UrlHelper.EditUserProfileUrl);
		}


	}
}