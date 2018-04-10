using System;
using System.Collections.Generic;
using Foundation;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class RoomViewController : UIViewController
    {
        List<string> sections;
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
        }
        private void initUI()
        {
            TableRoomView.RowHeight = UITableView.AutomaticDimension;
            TableRoomView.EstimatedRowHeight = 100;


            TableRoomView.RegisterNibForCellReuse(UINib.FromName("SelectedRoomCell", NSBundle.MainBundle), "SelectedRoomCell");
            TableRoomView.RegisterNibForCellReuse(UINib.FromName("RoomNameCell", NSBundle.MainBundle), "RoomNameCell");
            TableRoomView.RegisterNibForCellReuse(UINib.FromName("DirectBookCell", NSBundle.MainBundle), "DirectBookCell");
            TableRoomView.RegisterNibForCellReuse(UINib.FromName("DisplayPriceTextCell", NSBundle.MainBundle), "DisplayPriceTextCell");
            TableRoomView.RegisterNibForCellReuse(UINib.FromName("RoomRateCell", NSBundle.MainBundle), "RoomRateCell");


            TableRoomView.Source = new RoomTableSource(TableRoomView, sections);
            TableRoomView.Delegate = new RoomTableDelegate(TableRoomView, View.Frame.Size, sections);





        }
    }
}

