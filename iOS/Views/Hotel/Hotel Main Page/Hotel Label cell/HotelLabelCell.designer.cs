// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Mobius.iOS.Views
{
	[Register ("HotelLabelCell")]
	partial class HotelLabelCell
	{
		[Outlet]
		public UIKit.UILabel LabelText { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (LabelText != null) {
				LabelText.Dispose ();
				LabelText = null;
			}
		}
	}
}
