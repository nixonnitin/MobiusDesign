using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Mobius.Entities;
using Mobius.Data;

using Mobius.Services;


namespace Mobius.Core.ViewModels
{
	public class AccountViewModel : BaseViewModel
	{
		
		private readonly IAccountService accountService;

		private readonly IHttpService httpService;

		//This object is use to store configuration read from .xml file
		public SignUpAttributes SignUpAttributesObj;

		private string email;

		/// <summary>
		/// Initializes a new instance of the <see cref="T:Mobius.Core.ViewModels.AccountViewModel"/> class.
		/// </summary>
		/// <param name="platformService">Platform service.</param>
		/// <param name="accountService">Account service.</param>
		/// <param name="httpService">Http service.</param>
		public AccountViewModel(IPlatformService platformService, IAccountService accountService,
		                        IHttpService httpService) : base(platformService)
		{
			
			this.accountService = accountService;
			this.httpService = httpService;

            //get details from config file.
            this.SignUpAttributesObj = ReadConfiguration.GetResourceAttributes<Data.SignUpAttributes>("SignUpAttributes");
		}


		/// <summary>
		/// Signs up.
		/// </summary>
		/// <returns>The up.</returns>
		/// <param name="email">Email.</param>
		/// <param name="password">Password.</param>
		/// <param name="firstName">First name.</param>
		/// <param name="lastName">Last name.</param>
		/// <param name="jobTitle">Job title.</param>
		/// <param name="company">Company.</param>
		public async Task<bool> SignUp(string email, string password, string firstName, string lastName, string dateOfBirth,
									    bool fromFB = false, bool fromGoogle = false, bool fromTwitter = false)
		{
			if (!IsNetworkConnected)
			{
				platformService.NotifyConnectionLost();
				return false;
			}

			IsLoading = true;
			email = email.Trim();
			var message = ValidateAllFields(string.Empty, email, password, firstName, lastName);

			if (string.IsNullOrWhiteSpace(message))
			{
				message = ValidateEmail(email);
				if (string.IsNullOrWhiteSpace(message))
				{
					message = ValidatePassword(password, message);
				}
			}

			if (!string.IsNullOrEmpty(message))
			{
				IsLoading = false;
				await NotifyAsync("Error", message);
				return false;
			}

			firstName = firstName?.Trim();
			lastName = lastName?.Trim();

			var userProfile = new UserProfile
			{
				Email = email,
				Password = password,
				FirstName = firstName,
				LastName = lastName
			};

			UserProfile response = new UserProfile();
			try
			{
				response = await accountService.SignUp(userProfile);
			}
			catch (Exception ex)
			{
				if (ex.Message == "!CrossConnectivity.Current.IsConnected" || ex is System.Net.WebException)
				{
					platformService.NotifyConnectionLost();
				}
			}
			if (response.Success)
			{

				this.email = email;

				IsLoading = false;
				return true;
			}

			IsLoading = false;
			await NotifyAsync("Error","Registration Fail!");
			return false;
		}

		/// <summary>
		/// Logout the specified action.
		/// </summary>
		/// <returns>The logout.</returns>
		/// <param name="action">Action.</param>
		public async Task<bool> Logout(Action action)
		{
			//IsLoading = true;
			return await platformService.ConfirmAsync("Logout",
													  "Do you want to logout",
													  "Logout",
													  "Cancel", confirmed =>
			{
				if (!confirmed)
				{
				//IsLoading = false;
				return;
				}

				try
				{


					action.Invoke();
				//IsLoading = false;
			}
				catch (WebException)
				{
					platformService.NotifyConnectionLost();
				}
			});
		}


		/// <summary>
		/// Validates the email.
		/// </summary>
		/// <returns>The email.</returns>
		/// <param name="mail">Mail.</param>
		public string ValidateEmail(string mail)
		{
			var message = string.Empty;
			if (string.IsNullOrEmpty(mail)) return message;

			var regex = new Regex(@"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|([-a-z0-9!#$%&'*+\/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$");
			if (!regex.IsMatch(mail.ToLower().Trim()))
			{
				message ="Enter valid email";
			}

			return message;
		}

		/// <summary>
		/// Validates all fields.
		/// </summary>
		/// <returns>The all fields.</returns>
		/// <param name="message">Message.</param>
		/// <param name="mail">Mail.</param>
		/// <param name="password">Password.</param>
		/// <param name="firstName">First name.</param>
		/// <param name="lastName">Last name.</param>
		private string ValidateAllFields(string message, string mail, string password, string firstName, string lastName)
		{
			if (string.IsNullOrWhiteSpace(mail)
				|| password == string.Empty
				|| string.IsNullOrWhiteSpace(firstName)
			    || string.IsNullOrWhiteSpace(lastName))
			{

				if (!string.IsNullOrWhiteSpace(message))
				{
					message += " ";
				}

				message += "Enter all the fields";
			}
			return message;
		}

		/// <summary>
		/// Login the specified email and password.
		/// </summary>
		/// <returns>The login.</returns>
		/// <param name="email">Email.</param>
		/// <param name="password">Password.</param>
		public async Task<ResultType> Login(string email, string password)
		{

			if (!IsNetworkConnected)
			{
				platformService.NotifyConnectionLost();
				return ResultType.Error;
			}

			IsLoading = true;
			email = email.Trim();
			var message = string.Empty;
			if (string.IsNullOrEmpty(email))
			{
				message = "Enter email id";
			}
			else
			{
				message = ValidateEmail(email);
			}

			if (string.IsNullOrEmpty(password))
			{
				if (!string.IsNullOrWhiteSpace(message))
				{
					message += " ";
				}

				message += "Enter password";
			}

			if (!string.IsNullOrEmpty(message))
			{
				IsLoading = false;
				await NotifyAsync("Alert", message);
				return ResultType.Error;
			}

			try
			{
				var response = await this.accountService.Login(email, password);
				if (!response.Success)
				{
					await platformService.NotifyAsync("Alert",
													  response.Term,
													  "Ok");
					IsLoading = false;
					return ResultType.Error;
				}



				SaveUserData(email, response);



				return ResultType.Success;

			}
			catch (Exception ex)
			{
				IsLoading = false;
				return ResultType.Error;
			}

		}


		/// <summary>
		/// Saves the user data.
		/// </summary>
		/// <param name="pEmail">P email.</param>
		/// <param name="response">Response.</param>
		private void SaveUserData(string pEmail, AuthResponse response)
		{
			//SettingsStorage.LoggedIn = true;
			//SettingsStorage.LoggedInEmail = pEmail;

			if (response.Success)
			{
				if (response.Profile != null)
				{
					//SettingsStorage.LoggedInUsername = $"{response.Profile.FirstName} {response.Profile.LastName}";


				}
			}
		}

		/// <summary>
		/// Changes the password.
		/// </summary>
		/// <returns>The password.</returns>
		/// <param name="oldPassword">Old password.</param>
		/// <param name="newPassword">New password.</param>
		/// <param name="isMigration">If set to <c>true</c> is migration.</param>
		public async Task<bool> ChangePassword(string oldPassword, string newPassword, bool isMigration = false)
		{
			IsLoading = true;
			var message = string.Empty;
			if (string.IsNullOrWhiteSpace(oldPassword))
			{
				//message = ResourceManager.GetString("Alert_change_password_old_password_missing");
			}
			else if (string.IsNullOrWhiteSpace(newPassword))
			{
				//message += string.IsNullOrWhiteSpace(message)
				//				 ? ResourceManager.GetString("Alert_change_password_new_password_missing")
				//				 : $". {ResourceManager.GetString("Alert_change_password_new_password_missing")}.";
			}

			if (string.IsNullOrWhiteSpace(message))
			{
				message += ValidatePassword(newPassword, message);
			}

			if (!string.IsNullOrWhiteSpace(message))
			{
				IsLoading = false;
				//await NotifyAsync(ResourceManager.GetString("Alert_error_title"), message);
				return false;
			}

			//var response = await this.accountService.ChangePassword("EMAIL", oldPassword, newPassword, isMigration);
			//if (response.Success)
			//{
			//	IsLoading = false;
			//	return true;
			//}

			//IsLoading = false;
			//await NotifyAsync(ResourceManager.GetString("Alert_error_title"),
			//				  ResourceManager.GetString(response.Term));
			return false;
		}



		//public async Task<UserProfile> LoadUserProfile()
		//{
		//	if (!IsNetworkConnected)
		//	{
		//		platformService.NotifyConnectionLost();
		//		return null;
		//	}

		//	IsLoading = true;
		//	if (!string.IsNullOrEmpty(SettingsStorage.LoggedInEmail))
		//	{
		//		try
		//		{
		//			var response = await this.accountService.LoadUserProfile(SettingsStorage.LoggedInEmail);
		//			if (!string.IsNullOrWhiteSpace(response.Country))
		//			{
		//				response.Country = GetCountries().FirstOrDefault(t => t.Code.ToLower() == response.Country.ToLower())?.DisplayName;
		//			}

		//			IsLoading = false;
		//			return response;
		//		}
		//		catch (Exception ex)
		//		{
		//			if (ex.Message == "!CrossConnectivity.Current.IsConnected" || ex is WebException)
		//			{
		//				platformService.NotifyConnectionLost();
		//			}
		//		}
		//	}
		//	IsLoading = false;
		//	return null;
		//}

		/// <summary>
		/// Edits the user profile.
		/// </summary>
		/// <returns>The user profile.</returns>
		/// <param name="userProfile">User profile.</param>
		/// <param name="firstName">First name.</param>
		/// <param name="lastName">Last name.</param>
		/// <param name="jobTitle">Job title.</param>
		/// <param name="company">Company.</param>
		/// <param name="industry">Industry.</param>
		/// <param name="city">City.</param>
		/// <param name="country">Country.</param>
		public async Task<bool> EditUserProfile(UserProfile userProfile,
												string firstName,
												string lastName,
												string city,
												string country)
		{

			if (!IsNetworkConnected)
			{
				platformService.NotifyConnectionLost();
				return false;
			}

			IsLoading = true;
			var message = string.Empty;
			message = ValidateAllFields(message, userProfile.Email, userProfile.Email, firstName, lastName);
			if (!string.IsNullOrEmpty(message))
			{
				IsLoading = false;
				//await NotifyAsync(ResourceManager.GetString("Alert_error_title"), message);
				return false;
			}

			firstName = firstName?.Trim();
			lastName = lastName?.Trim();

			userProfile.FirstName = firstName;
			userProfile.LastName = lastName;


			BaseResponse response = null;

			try
			{
				response = await accountService.EditUserProfile(userProfile);

				if (response.Success)
				{

					this.email = userProfile.Email;

					//SettingsStorage.LoggedIn = true;
					//SettingsStorage.LoggedInEmail = email;
					//SettingsStorage.LoggedInUsername = $"{firstName} {lastName}";


				}
				else
				{
					await NotifyAsync("Alert", response.Term);
				}
			}
			catch (Exception ex)
			{
				if (ex.Message == "!CrossConnectivity.Current.IsConnected" || ex is System.Net.WebException)
				{
					platformService.NotifyConnectionLost();
				}
				else
				{
					await NotifyAsync("Alert", "Internal server error");
				}
			}
			finally
			{
				IsLoading = false;

			}

			return response != null && response.Success;
		}

		public void CancelChangePasswordProcess()
		{
			IsLoading = false;
		}


		/// <summary>
		/// Validates the password
		/// </summary>
		/// <returns>The password.</returns>
		/// <param name="password">Password.</param>
		/// <param name="message">Message.</param>
		private string ValidatePassword(string password, string message)
		{
			if (!string.IsNullOrWhiteSpace(message)) message += " ";



			return message;
		}

		#region Google

		//public void SignUpWithGoogle(Action success, Action error)
		//{
		//	//IsLoading = true;
		//	googleService.Authenticate((s) =>
		//	{
		//	//IsLoading = false;
		//	success();
		//	}, (s) =>
		//	{
		//	//IsLoading = false;
		//	error();
		//	});
		//}

		//public void GetGoogleProfile(Action<UserProfile> success, Action<string> error)
		//{
		//	IsLoading = true;
		//	googleService.GetUserProfile((s) =>
		//	{
		//	//IsLoading = false;
		//	success(s);
		//	}, (s) =>
		//	{
		//	//IsLoading = false;
		//	error(s);
		//	});
		//}

		#endregion

	}
}