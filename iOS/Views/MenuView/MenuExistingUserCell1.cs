using System;

using Foundation;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class MenuExistingUserCell1 : UITableViewCell
    {
        public static readonly NSString Key = new NSString("MenuExistingUserCell1");
        public static readonly UINib Nib;

        static MenuExistingUserCell1()
        {
            Nib = UINib.FromName("MenuExistingUserCell1", NSBundle.MainBundle);
            //Console.WriteLine("Test");
        }

        protected MenuExistingUserCell1(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
    }
}
