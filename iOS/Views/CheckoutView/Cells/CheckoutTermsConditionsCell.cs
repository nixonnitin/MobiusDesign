using System;

using Foundation;
using UIKit;
using Mobius.iOS.Helper;
namespace Mobius.iOS.Views
{
    public partial class CheckoutTermsConditionsCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("CheckoutTermsConditionsCell");
        public static readonly UINib Nib;

        static CheckoutTermsConditionsCell()
        {
            Nib = UINib.FromName("CheckoutTermsConditionsCell", NSBundle.MainBundle);
        }

        protected CheckoutTermsConditionsCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void AwakeFromNib()
        {
            base.AwakeFromNib();
            this.BackgroundColor = MobiusHelper.GetColorLightGrey();
            ViewContainer.BackgroundColor = MobiusHelper.GetColorLightGrey();

            LabelAgree.TextColor = MobiusHelper.GetColorGray();
            LabelAgree.Font = MobiusHelper.GetFontLightWithSize(14);

            LabelTerms.Font = MobiusHelper.GetFontMediumWithSize(14);
            LabelTerms.TextColor = MobiusHelper.GetColorSeaBlue();
        }

        #region properties
        public UIKit.UILabel labelAgree{
            get{
                return LabelAgree;
            }
            set{
                LabelAgree = value;
            }
        }

        public UIKit.UILabel labelTerms
        {
            get
            {
                return LabelTerms;
            }
            set
            {
                LabelTerms = value;
            }
        }

   
        public UIKit.UIView viewContainer
        {
            get
            {
                return ViewContainer;
            }
            set
            {
                ViewContainer = value;
            }
        }



        #endregion
    }
}
