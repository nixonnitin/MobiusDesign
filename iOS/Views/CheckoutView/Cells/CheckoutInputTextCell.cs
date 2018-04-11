using System;

using Foundation;
using UIKit;
using Mobius.iOS.Helper;
namespace Mobius.iOS.Views
{
    public partial class CheckoutInputTextCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("CheckoutInputTextCell");
        public static readonly UINib Nib;

        static CheckoutInputTextCell()
        {
            Nib = UINib.FromName("CheckoutInputTextCell", NSBundle.MainBundle);
        }

        protected CheckoutInputTextCell(IntPtr handle) : base(handle)
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

            ViewSubInputContainer.Layer.BorderColor = MobiusHelper.GetColorBorderGrey().CGColor;
            ViewSubInputContainer.Layer.BorderWidth = 2;
            ViewSubInputContainer.Layer.CornerRadius = 5;

            TextInput.Font = MobiusHelper.GetFontLightWithSize(14);
            TextSubInput.Font = MobiusHelper.GetFontLightWithSize(14);
        }

        public UIImageView imageInputView
      {
            get { return ImageInputView; }
            set { ImageInputView = value; }
      } 
        public UITextField textInput
      {
            get { return TextInput; }
            set { TextInput = value; }
      } 
        public UITextField textSubInput
      {
            get { return TextSubInput; }
            set { TextSubInput = value; }
      } 
    }
}
