using System;
using ModernHttpClient;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using Plugin.Connectivity;
using System.Text;
using System.Net.Http.Headers;
using Mobius.Entities;
using System.Linq;
using System.Threading;
using Newtonsoft.Json.Linq;
using System.Reflection;
using System.Collections.Generic;
using System.ComponentModel;

namespace Mobius.Services
{
	public class HttpService : IHttpService
	{
		private static string cookie;
		private static string locale;

		/// <summary>
		/// Sets the cookie.
		/// </summary>
		/// <param name="userCookie">User cookie.</param>
		public void SetCookie(string userCookie)
		{
			cookie = userCookie;
		}

		/// <summary>
		/// Sets the locale.
		/// </summary>
		/// <param name="userLocale">User locale.</param>
		public void SetLocale(string userLocale)
		{
			locale = userLocale;
		}

		/// <summary>
		/// Reads the content async.
		/// </summary>
		/// <returns>The content async.</returns>
		/// <param name="response">Response.</param>
		/// <typeparam name="T">The 1st type parameter.</typeparam>
		public async Task<T> ReadContentAsync<T>(HttpResponseMessage response) where T : IBaseResponse, new()
		{
			var message = string.Empty;

			try
			{
				message = await response.Content.ReadAsStringAsync();
				var result = JsonConvert.DeserializeObject<dynamic>(message).message.ToString().Replace("[OAuthLogin] ", "");
			}
			catch
			{
				message = string.Empty;
			}

			if (!string.IsNullOrWhiteSpace(message))
			{
				var token = JToken.Parse(message);
				if (token.Type == JTokenType.Object && (((JToken)"ERROR").Equals(token["status"]) || ((JToken)"FAILURE").Equals(token["status"])))
				{
					var r = new T();
					r.Code = (int)token["code"];
					r.StatusMessage = (string)token["message"];
					r.Success = false;
					r.Term = (string)token["term"];
					return r;
				}
			}
			else
			{
				var r = new T();
				r.Success = true;
				return r;
			}

			var jsonSerializerSettings = new JsonSerializerSettings { MissingMemberHandling = MissingMemberHandling.Ignore };
			jsonSerializerSettings.Error += (sender, errorArgs) =>
			{
				errorArgs.ErrorContext.Handled = true;
			};
			//jsonSerializerSettings.Converters.Add(new DateTimeConverter());
			return JsonConvert.DeserializeObject<T>(message, jsonSerializerSettings);

		}

		/// <summary>
		/// Gets the async.
		/// </summary>
		/// <returns>The async.</returns>
		/// <param name="url">URL.</param>
		/// <param name="cancellationToken">Cancellation token.</param>
		public async Task<HttpResponseMessage> GetAsync(string url, CancellationToken? cancellationToken = null)
		{
			System.Diagnostics.Debug.WriteLine($"URL = {url}");
			System.Diagnostics.Debug.WriteLineIf(!string.IsNullOrWhiteSpace(locale), $"LOCALE = {locale}");

			if (CrossConnectivity.Current.IsConnected)
			{
				using (var client = new HttpClient(new NativeMessageHandler() { UseCookies = false, DisableCaching = true }))
				{
					if (cookie != null)
						client.DefaultRequestHeaders.Add("Cookie", cookie);

					client.DefaultRequestHeaders.Add("Cache-Control", "max-age=0");
					client.DefaultRequestHeaders.CacheControl = new CacheControlHeaderValue() { NoCache = true };
					if (cancellationToken.HasValue)
						return await client.GetAsync(url, cancellationToken.Value).ConfigureAwait(false);
					else
						return await client.GetAsync(url).ConfigureAwait(false);
				}
			}
			return new HttpResponseMessage();
		}

		/// <summary>
		/// Gets the async.
		/// </summary>
		/// <returns>The async.</returns>
		/// <param name="url">URL.</param>
		/// <param name="cancellationToken">Cancellation token.</param>
		/// <typeparam name="T">The 1st type parameter.</typeparam>
		public async Task<T> GetAsync<T>(string url, CancellationToken? cancellationToken = null) where T : IBaseResponse, new()
		{
			var result = await this.GetAsync(url, cancellationToken);
			return await this.ReadContentAsync<T>(result);
		}

		public async Task<T> PostAsync<T>(object postData, string url) where T : IBaseResponse, new()
		{
			if (CrossConnectivity.Current.IsConnected)
			{
				using (HttpClient client = new HttpClient())
				{
					var uri = new Uri(url);

					setPostRequestHeadersForClient(client);

					var result = await client.PostAsync(uri, new StringContent(postData.ToString(), Encoding.UTF8, "application/json"));


					if (result.StatusCode != System.Net.HttpStatusCode.OK && result.StatusCode != System.Net.HttpStatusCode.Created)
					{
						var r = new T();
						r.Success = false;
						return r;
					}

					return await this.ReadContentAsync<T>(result).ConfigureAwait(false);
				}
			}
			throw new Exception($"!CrossConnectivity.Current.IsConnected");
		}


		/// <summary>
		/// Posts the async.
		/// </summary>
		/// <returns>The async.</returns>
		/// <param name="postData">Post data.</param>
		/// <param name="url">URL.</param>
		public async Task<AuthResponse> PostAsync(object postData, string url)
		{
			if (CrossConnectivity.Current.IsConnected)
			{
				using (HttpClient client = new HttpClient())
				{
					var uri = new Uri(url);

					setPostRequestHeadersForClient(client);

					var result = await client.PostAsync(uri, new StringContent(postData.ToString(), Encoding.UTF8, "application/json"));

					//var response = await result.Content.ReadAsStringAsync().ConfigureAwait(false);

					//var token = JToken.Parse(response);
					//if (token.Type == JTokenType.Object && ((JToken)"ERROR").Equals(token["status"]))
					//{
					//	//throw new RemoteServiceException((int)token["code"], (string)token["message"], (string)token["term"]);
					//}

					//var resultProfile = JsonConvert.DeserializeObject<UserProfile>(response);
					//var authResponse = new AuthResponse();

					//if (resultProfile != null)
					//{
					//	authResponse.Profile = resultProfile;


					//}

					//return authResponse;
				}
			}
			throw new Exception($"!CrossConnectivity.Current.IsConnected");
		}

		/// <summary>
		/// Gets the async.
		/// </summary>
		/// <returns>The async.</returns>
		/// <param name="url">URL.</param>
		/// <param name="headers">Headers.</param>
		public async Task<HttpResponseMessage> GetAsync(string url, Dictionary<string, string> headers)
		{
			if (CrossConnectivity.Current.IsConnected)
			{
				using (var client = new HttpClient(new NativeMessageHandler() { UseCookies = false, DisableCaching = true }))
				{
					if (headers != null)
					{
						foreach (var key in headers.Keys)
						{
							client.DefaultRequestHeaders.Add(key, headers[key]);
						}
					}

					return await client.GetAsync(url).ConfigureAwait(false);
				}
			}

			return new HttpResponseMessage();
		}

		/// <summary>
		/// Sets the post request headers for client.
		/// </summary>
		/// <param name="client">Client.</param>
		private void setPostRequestHeadersForClient(HttpClient client)
		{
			client.DefaultRequestHeaders.Clear();

			client.DefaultRequestHeaders.Add("cache-control", "no-cache");
			client.DefaultRequestHeaders.Add("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:57.0) Gecko/20100101 Firefox/57.0");
			client.DefaultRequestHeaders.Add("referer", "http://staging-www-sandman.mobiusbookingengine.com/");
			client.DefaultRequestHeaders.Add("origin", "http://staging-www-sandman.mobiusbookingengine.com");
			client.DefaultRequestHeaders.Add("keystone-tenant", "eyJhbGciOiJSUzI1NiIsInR5cCI6IkpXVCJ9.eyJpYXQiOjE0OTQ4ODcwMzYyODksImp0aSI6IjJmNDczZjEwLTM5YmQtMTFlNy04ODU2LTAxNDZmNTQ2MTRlMSIsImlzcyI6IktleXN0b25lIGxvZ2luIHVzZXIiLCJzdWIiOiJLZXlzdG9uZSBjbGFpbXMgdXNlciIsImF1ZCI6IktleXN0b25lIEFwcGxpY2F0aW9uIFVzZXIiLCJ0ZW5hbnQiOiJzYW5kbWFuIiwicm9sZSI6InVzZXIifQ.wbkvdvftpJ0yLIwe5E-_RLOLDKZVKhC6AmgqwgMO5HbSVzMLctfoDwY38pwbevEKG5zv8tKDA7zLXfom4n0EcZ0Ut-kss_eGSJfGjTPQ_XRBVzG6m7Rkm-1_jVk2PkDZg-3_oniMagm1cA02RSWC_vpRj9nTRjMW9q9I69br-SFgtF-bbjfFZGjU3xjwlRizCxqaIywNCh4FeE2qwg-RkSNAHQp7MdnP7SYgnL1UJ8Zt2X-KCHqtO2jyuRu4U9dnKXMY_eIir6OFx0pDhfBDlu28KSP3zE03kkKraIJP3WIdYKLz7Cw-uaJmYkb5iXi0jjJuLUEW9sv4-3eKB8kRV_-by7LU-_Cqo8Q5JbITB9oytf_nK9StcdkF1bt1JF4J_OmiTXnmhI3_KXbLstax-RJn8ecU3vV69vwqTbxWCff5lOfiEWZCIwUBQbzw5IzsDpkcbHhPzjiDPXpBaFs0h6l31PbW5uIj1jQqEvmTR4rTGLQW9z-qekEKfkQGQ4Y8yuRae0Yn-S1Aa74Za6Q9zMFGsEeIm9y19Ex27HVlog7s-Zwia1dLVXycPs1pTPeC4yAcAXLz1aB9P9GwIVs25EdvN7Rm1M_gkQf-g3PUDGHT9SzYs-2ro799UQJjXtZ97X3XCWryC-LUymO5-G9FNAvdMCBLT3JaIaFZnTAiufw");
			client.DefaultRequestHeaders.Add("host", "staging-sso.mobiusbookingengine.com");
			client.DefaultRequestHeaders.Add("cookie", "__cfduid=d93bd96cc36dd9b0a29d8f925709fb4671512374544; ajs_user_id=null; ajs_group_id=null; ajs_anonymous_id=%22bbd0e3d8-ea53-4a28-a08c-7af6bb02bf99%22; SANDMAN_USER_KS_SESSION=; _uetsid=_uetbe0d29a5");
			client.DefaultRequestHeaders.Add("connection", "keep-alive");
			client.DefaultRequestHeaders.Add("accept-language", "en-US,en;q=0.5");
			client.DefaultRequestHeaders.Add("accept-encoding", "gzip, deflate, br");
			client.DefaultRequestHeaders.Add("accept", "application/json, text/plain, */*");
		}

		/// <summary>
		/// Sets the get request headers for client.
		/// </summary>
		/// <param name="client">Client.</param>
		private void setGetRequestHeadersForClient(HttpClient client)
		{
			client.DefaultRequestHeaders.Clear();
			client.DefaultRequestHeaders.Add("mobius-channelid", "6");
			client.DefaultRequestHeaders.Add("cache-control", "no-cache");
			client.DefaultRequestHeaders.Add("accept", "application/json, text/plain, */*");
			client.DefaultRequestHeaders.Add("mobius-tenant", "1");
			client.DefaultRequestHeaders.Add("mobius-languagecode", "en-us");
			client.DefaultRequestHeaders.Add("mobius-currencycode", "CAD");
			client.DefaultRequestHeaders.Add("accept-language", "en-US,en;q=0.8");
		}			
	}
}