using System;
using Newtonsoft.Json;
namespace Mobius.Entities
{
	public class BaseResponse : IBaseResponse
	{
		[JsonIgnore]
		public bool Success { get; set; } = true;
		[JsonIgnore]
		public int Code { get; set; }
		[JsonIgnore]
		public string StatusMessage { get; set; }
		[JsonIgnore]
		public string Term { get; set; }
	}

	public interface IBaseResponse
	{
		bool Success { get; set; }
		int Code { get; set; }
		string StatusMessage { get; set; }
		string Term { get; set; }
	}
}