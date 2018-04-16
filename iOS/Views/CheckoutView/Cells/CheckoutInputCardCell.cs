using System;

using Foundation;
using UIKit;
using Mobius.iOS.Helper;
namespace Mobius.iOS.Views
{
    public partial class CheckoutInputCardCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("CheckoutInputCardCell");
        public static readonly UINib Nib;

        static CheckoutInputCardCell()
        {
            Nib = UINib.FromName("CheckoutInputCardCell", NSBundle.MainBundle);
        }

        protected CheckoutInputCardCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void AwakeFromNib()
        {
            base.AwakeFromNib();
            this.BackgroundColor = MobiusHelper.GetColorLightGrey();

            ViewInputContainer.Layer.BorderColor = MobiusHelper.GetColorBorderGrey().CGColor;
            ViewInputContainer.Layer.BorderWidth = 2;
            ViewInputContainer.Layer.CornerRadius = 5;

            TextInput.Font = MobiusHelper.GetFontLightWithSize(14);
            ViewErrorContainer.Layer.CornerRadius = 5;

            LabelError.Font = MobiusHelper.GetFontRegularWithSize(12);
        }
    }
}
