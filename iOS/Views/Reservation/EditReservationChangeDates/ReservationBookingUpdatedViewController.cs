using System;

using UIKit;

namespace Mobius.iOS.Views
{
    public partial class ReservationBookingUpdatedViewController : UIViewController
    {
        public ReservationBookingUpdatedViewController() : base("ReservationBookingUpdatedViewController", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            BookUpdatedAlertView.Layer.CornerRadius = 8;
            BookUpdatedAlertView.Layer.MasksToBounds = true;    
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

