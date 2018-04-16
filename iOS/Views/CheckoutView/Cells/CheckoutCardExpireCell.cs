using System;

using Foundation;
using Mobius.iOS.Helper;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class CheckoutCardExpireCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("CheckoutCardExpireCell");
        public static readonly UINib Nib;

        static CheckoutCardExpireCell()
        {
            Nib = UINib.FromName("CheckoutCardExpireCell", NSBundle.MainBundle);
        }

        protected CheckoutCardExpireCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void AwakeFromNib()
        {
            base.AwakeFromNib();
            this.BackgroundColor = MobiusHelper.GetColorLightGrey();
            LabelExpire.Font = MobiusHelper.GetFontRegularWithSize(13);
            LabelCVV.Font = MobiusHelper.GetFontRegularWithSize(13);


            ViewMMContainer.Layer.BorderColor = MobiusHelper.GetColorBorderGrey().CGColor;
            ViewMMContainer.Layer.BorderWidth = 2;
            ViewMMContainer.Layer.CornerRadius = 5;

            ViewYYContainer.Layer.BorderColor = MobiusHelper.GetColorBorderGrey().CGColor;
            ViewYYContainer.Layer.BorderWidth = 2;
            ViewYYContainer.Layer.CornerRadius = 5;

            ViewCVVContainer.Layer.BorderColor = MobiusHelper.GetColorBorderGrey().CGColor;
            ViewCVVContainer.Layer.BorderWidth = 2;
            ViewCVVContainer.Layer.CornerRadius = 5;

            TextMM.Font = MobiusHelper.GetFontLightWithSize(14);
            TextYY.Font = MobiusHelper.GetFontLightWithSize(14);
            TextCVV.Font = MobiusHelper.GetFontLightWithSize(14);
        }
    }
}
