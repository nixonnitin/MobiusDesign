using System;
using System.Collections.Generic;
using Foundation;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class HotelSubPageViewController : UIViewController
    {
        List<string> labels;

        public HotelSubPageViewController() : base("HotelSubPageViewController", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            labels = new List<string> { "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum." };

            initUI();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        private void initUI()
        {
            TableViewHotelSubPage.RowHeight = UITableView.AutomaticDimension;
            TableViewHotelSubPage.EstimatedRowHeight = 111;
            TableViewHotelSubPage.RegisterNibForCellReuse(UINib.FromName("HotelQuickBookImageCell", NSBundle.MainBundle), "HotelQuickBookImageCell");
            TableViewHotelSubPage.RegisterNibForCellReuse(UINib.FromName("HotelSubPageCell", NSBundle.MainBundle), "HotelSubPageCell");
            TableViewHotelSubPage.Source = new TableViewHotelSubPageSource(TableViewHotelSubPage, labels);
        }
    }

    public class TableViewHotelSubPageSource : UITableViewSource
    {
        UITableView table;
        List<string> labels;

        public TableViewHotelSubPageSource(UITableView table, List<string> labels)
        {
            this.table = table;
            this.labels = labels;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            if (indexPath.Row == 0)
            {
                var cell = (HotelQuickBookImageCell)tableView.DequeueReusableCell(HotelQuickBookImageCell.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                cell.ButtonLeft.SetImage(UIImage.FromBundle("ArrowWhitePrevious"), UIControlState.Normal);
                cell.ButtonRight.SetImage(UIImage.FromBundle("ArrowWhiteNext"), UIControlState.Normal);

                return cell;
            }
            else
            {
                var cell = (HotelSubPageCell)tableView.DequeueReusableCell(HotelSubPageCell.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                cell.LabelContent.Text = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.";
                cell.LabelContent.Font = UIFont.SystemFontOfSize(15, UIFontWeight.Light);
                cell.LabelContent.TextColor = UIColor.Black;
                return cell;
            }

        }

        public override nint RowsInSection(UITableView tableView, nint section)
        {
            return 2;
        }

        public override nfloat GetHeightForRow(UITableView tableView, NSIndexPath indexPath)
        {
            if (indexPath.Row == 0)
            {
                return 250;
            }
            else 
            {
                return UITableView.AutomaticDimension;
            }
        }
    }
}

