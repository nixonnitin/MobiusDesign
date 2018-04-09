using System;

using UIKit;

namespace Mobius.iOS.Views
{
    public partial class NoReservationPopUpViewController : UIViewController
    {
        public NoReservationPopUpViewController() : base("NoReservationPopUpViewController", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            ButtonBookYourStay.Layer.CornerRadius = 6;
            ButtonBookYourStay.Layer.MasksToBounds = true;
            NoReservationAlertPopUp.Layer.CornerRadius = 6;
            NoReservationAlertPopUp.Layer.MasksToBounds = true;
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

