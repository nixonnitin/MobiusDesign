using System;
using CoreGraphics;
using UIKit;
using Foundation;
using Mobius.Core.ViewModels;
using Mobius.Entities;
using Mobius.Services;
using Mobius.Data;
using System.IO;
using Mobius.iOS.Helpers;
using System.Drawing;

namespace Mobius.iOS.Views
{
	public partial class RegistrationViewController : BaseViewController<AccountViewModel>    
    {
     	/// <summary>
     	/// Initializes a new instance of the <see cref="T:Mobius.iOS.Views.RegistrationViewController"/> class.
     	/// </summary>
		public RegistrationViewController() : base("RegistrationViewController", null)
        {
        }

		/// <summary>
		/// Views the did load.
		/// </summary>
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            initData();
            initTheme();

			ButtonRegister.TouchUpInside += (sender, e) => SignUp();
        }

		/// <summary>
		/// Signs up.
		/// </summary>
		private async void SignUp()
		{	
			//var result = await this.ViewModel.Login("abc@gmail.com", "abcd");
			var result = await this.ViewModel.SignUp(TextFieldEmailID.Text, TextFieldPassword.Text,TextFieldFirstName.Text,TextFieldLastName.Text,TextFieldDOB.Text);

			if (result)
			{				

				var controller = new Views.LoginViewController();
				var navController = new UINavigationController(controller);

				AppDelegate objAppDelegate = (AppDelegate)UIApplication.SharedApplication.Delegate;
				objAppDelegate.Window.RootViewController = navController;
				            
			}
		}

		/// <summary>
		/// Inits the data.
		/// </summary>
        private void initData()
		{
            LabelSocialAccess.Text = "Use Social for Faster Access";
            LabelBellowSocial.Text = "Or with e-mail";
            LabelPasswordRule.Text = "Your password must contain at least 6 characters, 1 number, 1 uppercase and 1 symbol.";
            LabelAgree.Text = "By signing up, agree to the";
            LabelTerms.Text = "Terms and Condictions";

            ButtonRegister.SetTitle("Register", UIControlState.Normal);

            TextFieldFirstName.Placeholder = "First Name";
            TextFieldLastName.Placeholder = "Last Name";
            TextFieldDOB.Placeholder = "Date of Birth";
            TextFieldEmailID.Placeholder = "Email Address";
            TextFieldPassword.Placeholder = "Password";

            ButtonSocialRight.BackgroundColor = UIColor.Gray;
            ButtonSocialRight.Layer.CornerRadius = 22;
            ButtonSocialLeft.BackgroundColor = UIColor.Gray;
            ButtonSocialLeft.Layer.CornerRadius = 22;
            ButtonSocialMiddle.BackgroundColor = UIColor.Gray;
            ButtonSocialMiddle.Layer.CornerRadius = 22;
        }


		/// <summary>
		/// Inits the theme.
		/// </summary>
        private void initTheme()
        {
            ConstraintHeightFrameFirstName.Constant = 65;
            ConstraintHeightFrameLastName.Constant = 65;
            ConstraintHeightFrameDOB.Constant = 65;
            ConstraintHeightFrameEmailID.Constant = 65;
            ConstraintHeightFramePassword.Constant = 65;

            ConstraintHeightLabelErrorFirstName.Constant = 0;
            ConstraintHeightLabelErrorLastName.Constant = 0;
            ConstraintHeightLabelErrorDOB.Constant = 0;
            ConstraintHeightLabelErrorEmailID.Constant = 0;
            ConstraintHeightLabelErrorPassword.Constant = 0;

			ButtonRegister.BackgroundColor = UIColor.Clear.FromHexString(ViewModel.SignUpAttributesObj.ButtonBackGroundColor);

            this.NavigationController.NavigationBar.SetBackgroundImage(new UIImage(), UIBarMetrics.Default);
            this.NavigationController.NavigationBar.ShadowImage = new UIImage();
            this.NavigationController.NavigationBar.Translucent = true;
            NavigationItem.Title = "Register";
            this.NavigationController.NavigationBar.TitleTextAttributes = new UIStringAttributes() { ForegroundColor = UIColor.White };

            ViewLastName.Layer.BorderWidth = 1;
            ViewLastName.Layer.CornerRadius = 5;

			LabelSocialAccess.TextColor = UIColor.Clear.FromHexString(ViewModel.SignUpAttributesObj.ButtonTextColor);
			LabelBellowSocial.TextColor = UIColor.Clear.FromHexString(ViewModel.SignUpAttributesObj.ButtonTextColor);

            TextFieldLastName.BorderStyle = UITextBorderStyle.None;
            TextFieldFirstName.EditingDidBegin += TextFieldFirstName_EditingDidBegin;
            TextFieldFirstName.EditingDidEnd += TextFieldFirstName_EditingDidEnd;
            TextFieldLastName.ShouldReturn += TextField_ShouldReturn;
           

            ViewFirstName.Layer.BorderWidth = 1;
            ViewFirstName.Layer.CornerRadius = 5;
            TextFieldFirstName.BorderStyle = UITextBorderStyle.None;
            TextFieldFirstName.ShouldReturn += TextField_ShouldReturn;

            ViewDOB.Layer.BorderWidth = 1;
            ViewDOB.Layer.CornerRadius = 5;
            TextFieldDOB.BorderStyle = UITextBorderStyle.None;
            TextFieldDOB.UserInteractionEnabled = false;
            TextFieldDOB.ShouldReturn += TextField_ShouldReturn;

            ViewEmailID.Layer.BorderWidth = 1;
            ViewEmailID.Layer.CornerRadius = 5;
            TextFieldEmailID.BorderStyle = UITextBorderStyle.None;
            TextFieldEmailID.ShouldReturn += TextField_ShouldReturn;

            ViewPassword.Layer.BorderWidth = 1;
            ViewPassword.Layer.CornerRadius = 5;
            TextFieldPassword.BorderStyle = UITextBorderStyle.None;
            TextFieldPassword.ShouldReturn += TextField_ShouldReturn;

            ButtonRegister.Layer.CornerRadius = 5;
            ButtonRegister.Layer.BorderWidth = 1;

            ImageBackground.Image = UIImage.FromFile("bgblur.png");

            ImageFirstName.Image = UIImage.FromFile("user.png");
        }

		/// <summary>
		/// Texts the field should return.
		/// </summary>
		/// <returns><c>true</c>, if field should return was texted, <c>false</c> otherwise.</returns>
		/// <param name="textField">Text field.</param>
        bool TextField_ShouldReturn(UITextField textField)
        {
            textField.ResignFirstResponder();
            return true;
        }

		/// <summary>
		/// Texts the field first name editing did end.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">E.</param>
        void TextFieldFirstName_EditingDidEnd(object sender, EventArgs e)
        {
            TextFieldFirstName.ResignFirstResponder();
        }

		/// <summary>
		/// Texts the field first name editing did begin.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">E.</param>
        void TextFieldFirstName_EditingDidBegin(object sender, EventArgs e)
        {
            
        }

		/// <summary>
		/// Dids the receive memory warning.
		/// </summary>
        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
        }
    }
}

