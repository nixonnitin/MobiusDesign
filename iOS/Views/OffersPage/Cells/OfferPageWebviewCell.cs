using System;

using Foundation;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class OfferPageWebviewCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("OfferPageWebviewCell");
        public static readonly UINib Nib;

        static OfferPageWebviewCell()
        {
            Nib = UINib.FromName("OfferPageWebviewCell", NSBundle.MainBundle);
        }

        protected OfferPageWebviewCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        #region properties
        public UIKit.NSLayoutConstraint constraintWebviewHeight{
            get { return ConstraintWebviewHeight; }
            set { ConstraintWebviewHeight = value; }
        }

        public UIKit.UIWebView webviewDescription
        {
            get { return WebviewDescription; }
            set { WebviewDescription = value; }
        }

       
        #endregion
    }
}
