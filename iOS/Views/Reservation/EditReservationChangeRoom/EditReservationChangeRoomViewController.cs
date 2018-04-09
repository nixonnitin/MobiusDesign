using System;

using UIKit;

namespace Mobius.iOS.Views
{
    public partial class EditReservationChangeRoomViewController : UIViewController
    {
        public EditReservationChangeRoomViewController() : base("EditReservationChangeRoomViewController", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            ReservationEditRoomPopUp.Layer.CornerRadius = 6;
            ReservationEditRoomPopUp.Layer.MasksToBounds = true;
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

