using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Mobius.Entities;
using System.Collections.Generic;

namespace Mobius.Services
{
	public interface IHttpService
	{
		void SetLocale(string locale);
		void SetCookie(string cookie);
		Task<T> ReadContentAsync<T>(HttpResponseMessage response) where T : IBaseResponse, new();
		Task<HttpResponseMessage> GetAsync(string url, CancellationToken? cancellationToken = null);
		Task<T> GetAsync<T>(string url, CancellationToken? cancellationToken = null) where T : IBaseResponse, new();
		Task<T> PostAsync<T>(object postData, string url) where T : IBaseResponse, new();
		Task<AuthResponse> PostAsync(object postData, string url);
		Task<HttpResponseMessage> GetAsync(string url, Dictionary<string, string> headers);

	}
}
