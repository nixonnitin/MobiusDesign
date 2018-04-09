using System;

using UIKit;

namespace Mobius.iOS.Views
{
    public partial class EditReservationChangeDatesAmountConfirmationViewController : UIViewController
    {
        public EditReservationChangeDatesAmountConfirmationViewController() : base("EditReservationChangeDatesAmountConfirmationViewController", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            EditReservationChangeDatesPopUp.Layer.CornerRadius = 8;
            EditReservationChangeDatesPopUp.Layer.MasksToBounds = true;
            ButtonConfirmChangeDates.Layer.CornerRadius = 8;
            ButtonConfirmChangeDates.Layer.MasksToBounds = true;
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

