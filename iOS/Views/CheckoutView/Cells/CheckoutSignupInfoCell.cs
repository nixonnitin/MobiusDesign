using System;

using Foundation;
using UIKit;
using Mobius.iOS.Helper;
namespace Mobius.iOS.Views
{
    public partial class CheckoutSignupInfoCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("CheckoutSignupInfoCell");
        public static readonly UINib Nib;

        static CheckoutSignupInfoCell()
        {
            Nib = UINib.FromName("CheckoutSignupInfoCell", NSBundle.MainBundle);
        }

        protected CheckoutSignupInfoCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void AwakeFromNib()
        {
            base.AwakeFromNib();
            this.BackgroundColor = MobiusHelper.GetColorLightGrey();

            ViewInfoContainer.Layer.BorderColor = MobiusHelper.GetColorSeaBlue().CGColor;
            ViewInfoContainer.Layer.BorderWidth = 1;
            ViewInfoContainer.Layer.CornerRadius = 5;
            ViewInfoContainer.BackgroundColor = MobiusHelper.GetColorInformationBlue();

            LabelInfo.Font = MobiusHelper.GetFontLightWithSize(17);
            LabelInfo.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque varius est dui, non feugiat lacus dictum " +
                "ullamcorper. Morbi blandit sapien nec enim pretium, eget interdum turpis pretium. Vivamus pharetra orci vulputate purus " +
                "scelerisque varius. Aliquam tristique metus in turpis elementum, et sollicitudin diam tristique.";
        }
    }
}
