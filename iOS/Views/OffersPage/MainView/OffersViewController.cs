using System;

using UIKit;
using System.Collections.Generic;
using Foundation;
using Mobius.iOS.Helper;
namespace Mobius.iOS.Views
{
    public partial class OffersViewController : UIViewController
    {
        List<string> sections;
        public OffersViewController() : base("OffersViewController", null)
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
            sections = new List<string> { "", "",""};
        }

        private void initUI()
        {
            View.BackgroundColor = MobiusHelper.GetColorLightGrey();

            TableOffers.BackgroundColor = MobiusHelper.GetColorLightGrey();

            TableOffers.RowHeight = UITableView.AutomaticDimension;
            TableOffers.EstimatedRowHeight = 40;
            TableOffers.RegisterNibForCellReuse(UINib.FromName("OfferPageOfferCell", NSBundle.MainBundle), "OfferPageOfferCell");
            TableOffers.RegisterNibForCellReuse(UINib.FromName("OfferPageWebviewCell", NSBundle.MainBundle), "OfferPageWebviewCell");
            TableOffers.RegisterNibForCellReuse(UINib.FromName("HomeButtonCell", NSBundle.MainBundle), "HomeButtonCell");
            TableOffers.Source = new OffersPageTableSource(TableOffers, sections);
            TableOffers.Delegate = new OffersPageTableDelegate(TableOffers, View.Frame.Size, sections);
        }
    }
}

