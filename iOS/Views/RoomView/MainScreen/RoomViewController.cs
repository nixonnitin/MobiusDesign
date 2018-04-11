using System;
using System.Collections.Generic;
using Foundation;
using Mobius.iOS.Helper;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class RoomViewController : UIViewController
    {
        List<string> sections;
        List<string> collectionViewLabels;
        List<string> collectionViewImages;

        public RoomViewController() : base("RoomViewController", null)
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
            sections = new List<string> { "", "", "", "", "", "", "", "", "" };
            collectionViewLabels = new List<string> { "On-Site Parking", "24-Hours Front Desk", "Complimentary Wireless Internet", "Denny's Restaurant" };
            collectionViewImages = new List<string> { "parking-1", "food-1", "gym", "homeWiFi" };
        }
        private void initUI()
        {
            TableRoomView.RowHeight = UITableView.AutomaticDimension;
            TableRoomView.EstimatedRowHeight = 100;
            TableRoomView.BackgroundColor = MobiusHelper.GetColorLightGraySeperator();

            TableRoomView.RegisterNibForCellReuse(UINib.FromName("SelectedRoomCell", NSBundle.MainBundle), "SelectedRoomCell");
            TableRoomView.RegisterNibForCellReuse(UINib.FromName("RoomNameCell", NSBundle.MainBundle), "RoomNameCell");
            TableRoomView.RegisterNibForCellReuse(UINib.FromName("DirectBookCell", NSBundle.MainBundle), "DirectBookCell");
            TableRoomView.RegisterNibForCellReuse(UINib.FromName("DisplayPriceTextCell", NSBundle.MainBundle), "DisplayPriceTextCell");
            TableRoomView.RegisterNibForCellReuse(UINib.FromName("RoomRateCell", NSBundle.MainBundle), "RoomRateCell");
            TableRoomView.RegisterNibForCellReuse(UINib.FromName("RoomDescriptionCell", NSBundle.MainBundle), "RoomDescriptionCell");

            TableRoomView.RegisterNibForCellReuse(UINib.FromName("HomeCollectionContainerCell", NSBundle.MainBundle), "HomeCollectionContainerCell");




            TableRoomView.Source = new RoomTableSource(TableRoomView, sections,collectionViewLabels,collectionViewImages);
            TableRoomView.Delegate = new RoomTableDelegate(TableRoomView, View.Frame.Size, sections);





        }
    }
}

