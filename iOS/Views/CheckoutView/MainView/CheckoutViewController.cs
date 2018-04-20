using System;

using UIKit;
using System.Collections.Generic;
using Foundation;
using Mobius.iOS.Helper;
namespace Mobius.iOS.Views
{
    public partial class CheckoutViewController : UIViewController
    {
        List<string> sections;
        public CheckoutViewController() : base("CheckoutViewController", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            initData();
            initUI();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        private void initData()
        {
            sections = new List<string> { "", "Enter Your Details", "Offers", "Hotels Near You", "Popular Destinations","","", "",
                "Selected Offers:", "Your Up Coming Stay:", "Your Purchased Enhancements:", "Recommended Enhancements:", "Your Reservation:", "Your Reservation:" ,"","Select your welcome benefit:","","","","" };
        }

        private void initUI()
        {
            View.BackgroundColor = MobiusHelper.GetColorLightGrey();

            TableCheckout.BackgroundColor = MobiusHelper.GetColorLightGrey();

            TableCheckout.RowHeight = UITableView.AutomaticDimension;
            TableCheckout.EstimatedRowHeight = 100;
            TableCheckout.RegisterNibForCellReuse(UINib.FromName("HomeIntroductionCell", NSBundle.MainBundle), "HomeIntroductionCell");
            TableCheckout.RegisterNibForCellReuse(UINib.FromName("CheckoutBookingDetailCell", NSBundle.MainBundle), "CheckoutBookingDetailCell");
            TableCheckout.RegisterNibForCellReuse(UINib.FromName("CheckoutInputTextCell", NSBundle.MainBundle), "CheckoutInputTextCell");
            TableCheckout.RegisterNibForCellReuse(UINib.FromName("CheckoutSingleInputTextCell", NSBundle.MainBundle), "CheckoutSingleInputTextCell");
            TableCheckout.RegisterNibForCellReuse(UINib.FromName("CheckoutSignupInfoCell", NSBundle.MainBundle), "CheckoutSignupInfoCell");
            TableCheckout.RegisterNibForCellReuse(UINib.FromName("CheckoutPromocodeCell", NSBundle.MainBundle), "CheckoutPromocodeCell");
            //CheckoutTermsConditionsCell
            TableCheckout.RegisterNibForCellReuse(UINib.FromName("CheckoutTermsConditionsCell", NSBundle.MainBundle), "CheckoutTermsConditionsCell");
            TableCheckout.RegisterNibForCellReuse(UINib.FromName("CheckoutNextCell", NSBundle.MainBundle), "CheckoutNextCell");
            TableCheckout.RegisterNibForCellReuse(UINib.FromName("CheckoutPriceBreakdownCell", NSBundle.MainBundle), "CheckoutPriceBreakdownCell");
            TableCheckout.RegisterNibForCellReuse(UINib.FromName("CheckoutPaymentOptionButtons", NSBundle.MainBundle), "CheckoutPaymentOptionButtons");
            TableCheckout.RegisterNibForCellReuse(UINib.FromName("CheckoutScanCardButtonCell", NSBundle.MainBundle), "CheckoutScanCardButtonCell");
            TableCheckout.RegisterNibForCellReuse(UINib.FromName("CheckoutInputCardCell", NSBundle.MainBundle), "CheckoutInputCardCell");
            TableCheckout.RegisterNibForCellReuse(UINib.FromName("CheckoutCardExpireCell", NSBundle.MainBundle), "CheckoutCardExpireCell");
            TableCheckout.RegisterNibForCellReuse(UINib.FromName("CheckoutPostcodeCountryCell", NSBundle.MainBundle), "CheckoutPostcodeCountryCell");


            TableCheckout.Source = new CheckoutTableSource(TableCheckout, sections);
            //TableCheckout.Delegate = new CheckoutTableDelegate(TableCheckout, View.Frame.Size, sections);
        }
    }
}

