using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Mobius.Services
{
	public interface IPlatformService
	{		
		string Version { get; }
		object Owner { get; }

		void SetOwner(object owner);
		Task<bool> NotifyAsync(string title, string message, string okText, Action completionHandler = null);
		Task<bool> ConfirmAsync(string title, string message, string yesText, string noText, Action<bool> callback);
		void Log(Exception ex, [CallerMemberName] string memberName = "", [CallerLineNumber] int sourceLineNumber = 0);
		void Log(string error, [CallerMemberName] string memberName = "", [CallerLineNumber] int sourceLineNumber = 0);
		void NotifyConnectionLost();

		void CreateSymbolicLinkFolder(string path, string destinationPath);
		bool IsAndroid { get; }
	}
}
