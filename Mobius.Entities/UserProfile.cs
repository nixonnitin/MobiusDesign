using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Mobius.Entities
{
	public class UserProfile : BaseResponse
	{
		public UserProfile()
		{
			// AcceptedTermsAndConditions = new List<string>();
		}

		[JsonProperty("password")]
		public string Password { get; set; }
		[JsonProperty("email")]
		public string Email { get; set; }
		[JsonProperty("firstName")]
		public string FirstName { get; set; }
		[JsonProperty("lastName")]
		public string LastName { get; set; }
	}
}