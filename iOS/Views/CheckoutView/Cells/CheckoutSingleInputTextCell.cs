using System;

using Foundation;
using UIKit;
using Mobius.iOS.Helper;
namespace Mobius.iOS.Views
{
    public partial class CheckoutSingleInputTextCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("CheckoutSingleInputTextCell");
        public static readonly UINib Nib;

        static CheckoutSingleInputTextCell()
        {
            Nib = UINib.FromName("CheckoutSingleInputTextCell", NSBundle.MainBundle);
        }

        protected CheckoutSingleInputTextCell(IntPtr handle) : base(handle)
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
        }

        public UIImageView imageInputView
     {
           get { return ImageInput; }
           set { ImageInput = value; }
     } 
       public UITextField textInput
     {
           get { return TextInput; }
           set { TextInput = value; }
     } 
    }
}
