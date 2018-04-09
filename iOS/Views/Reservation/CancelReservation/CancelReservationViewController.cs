using System;

using UIKit;

namespace Mobius.iOS.Views
{
    public partial class CancelReservationViewController : UIViewController
    {
        public CancelReservationViewController() : base("CancelReservationViewController", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            ButtonYes.Layer.CornerRadius = 8;
            ButtonYes.Layer.MasksToBounds = true;
            ButtonNo.Layer.CornerRadius = 8;
            ButtonNo.Layer.MasksToBounds = true;
            ViewCancelReservation.Layer.CornerRadius = 8;
            ViewCancelReservation.Layer.MasksToBounds = true;
            ButtonNo.Layer.BorderWidth = 1;
            ButtonNo.Layer.BorderColor = UIColor.FromRGB(58,156,170).CGColor;
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

