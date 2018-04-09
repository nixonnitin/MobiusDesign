using System;

using UIKit;

namespace Mobius.iOS.Views
{
    public partial class EditReservationChangeRoomAmountConfirmationViewController : UIViewController
    {
        public EditReservationChangeRoomAmountConfirmationViewController() : base("EditReservationChangeRoomAmountConfirmationViewController", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            EditReservationChangeRoomAmountConfirmationPopUp.Layer.CornerRadius = 8;
            EditReservationChangeRoomAmountConfirmationPopUp.Layer.MasksToBounds = true;
            ButtonConfirmChangeRoom.Layer.CornerRadius = 8;
            ButtonConfirmChangeRoom.Layer.MasksToBounds = true;
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

