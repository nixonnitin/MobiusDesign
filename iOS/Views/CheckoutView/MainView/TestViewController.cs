using System;

using UIKit;
using System.Collections.Generic;
using Foundation;
using Mobius.iOS.Helper;
namespace Mobius.iOS.Views
{
    public partial class TestViewController : UIViewController
    {
        public TestViewController() : base("TestViewController", null)
        {
            initUI();
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        private void initUI()
        {
            View.BackgroundColor = MobiusHelper.GetColorLightGrey();

            TableTest.BackgroundColor = MobiusHelper.GetColorLightGrey();

            TableTest.RowHeight = UITableView.AutomaticDimension;
            TableTest.EstimatedRowHeight = 100;
            TableTest.RegisterNibForCellReuse(UINib.FromName("HomeIntroductionCell", NSBundle.MainBundle), "HomeIntroductionCell");
            TableTest.RegisterNibForCellReuse(UINib.FromName("CheckoutInputCardCell", NSBundle.MainBundle), "CheckoutInputCardCell");
            TableTest.RegisterNibForCellReuse(UINib.FromName("CheckoutCardExpireCell", NSBundle.MainBundle), "CheckoutCardExpireCell");
            //TableTest.RegisterNibForCellReuse(UINib.FromName("CheckoutPromocodeCell", NSBundle.MainBundle), "CheckoutPromocodeCell");
            ////CheckoutTermsConditionsCell
            //TableTest.RegisterNibForCellReuse(UINib.FromName("CheckoutTermsConditionsCell", NSBundle.MainBundle), "CheckoutTermsConditionsCell");
            TableTest.Source = new TestTableSource(TableTest);
        }
    }
}

