using System;
using System.Net;
using Mobius.Entities;
using System.Linq;
using System.IO;

namespace Mobius.Services.Helper
{
	public class UrlHelper
	{

		public static readonly string BaseUrl = "https://staging-sso.mobiusbookingengine.com/oauth";

		public static readonly string LoginUrl = $"{BaseUrl}/login";
		public static readonly string SignUpUrl = $"{BaseUrl}/register";

		public static readonly string ForgotPasswordUrl = $"{BaseUrl}/password";
		public static readonly string LoadUserProfileUrl = $"{BaseUrl}/";
		public static readonly string EditUserProfileUrl = $"{BaseUrl}/";

	}
}