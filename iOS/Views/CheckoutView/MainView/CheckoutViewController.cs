using System;

using UIKit;
using System.Collections.Generic;
using Foundation;
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
            sections = new List<string> { "", "", "Offers", "Hotels Near You", "Popular Destinations","","", "",
                "Selected Offers:", "Your Up Coming Stay:", "Your Purchased Enhancements:", "Recommended Enhancements:", "Your Reservation:", "Your Reservation:" ,"","Select your welcome benefit:","","","" };
        }

        private void initUI()
        {
            TableCheckout.RowHeight = UITableView.AutomaticDimension;
            TableCheckout.EstimatedRowHeight = 100;
            TableCheckout.RegisterNibForCellReuse(UINib.FromName("CheckoutBookingDetailCell", NSBundle.MainBundle), "CheckoutBookingDetailCell");
            TableCheckout.Source = new CheckoutTableSource(TableCheckout, sections);
            //TableCheckout.Delegate = new MainHomeTableDelegate(TableCheckout, View.Frame.Size, sections);
        }
    }
}

