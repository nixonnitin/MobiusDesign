using System;
using UIKit;
using System.Collections.Generic;
using Foundation;
using CoreGraphics;
using Mobius.iOS.Helper;
namespace Mobius.iOS.Views
{
    public class CheckoutTableSource: UITableViewSource
    {
        UITableView table;
        List<string> sections;
        public CheckoutTableSource(UITableView table, List<string> sections)
        {
            this.table = table;
            this.sections = sections;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            //var tableCell = new UITableViewCell();
            //return tableCell;
            var cell = (CheckoutBookingDetailCell)tableView.DequeueReusableCell(CheckoutBookingDetailCell.Key, indexPath);
            cell.SelectionStyle = UITableViewCellSelectionStyle.None;
            //cell.LabelText.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.";
            //MobiusHelper.GetRoundedCornerFromSideOfView(cell.ViewOfferDetailContainer, UIRectCorner.BottomLeft | UIRectCorner.BottomRight);
            return cell;
        }
        public override nint RowsInSection(UITableView tableView, nint section)
        {
            return 1;
        }
        public override nint NumberOfSections(UITableView tableView)
        {
            //return sections.Count;
            return 1;
        }
    }

    //public class CheckoutTableDelegate : UITableViewDelegate
    //{
    //    UITableView table;
    //    CGSize viewSize;
    //    List<string> sections;
    //    public CheckoutTableDelegate(UITableView tableView, CGSize viewSize, List<string> sections)
    //    {
    //        this.table = tableView;
    //        this.viewSize = viewSize;
    //        this.sections = sections;
    //    }
    //    public override UIView GetViewForHeader(UITableView tableView, nint section)
    //    {
    //        var headerText = sections[(int)section];
    //        var headerHeight = 22;


    //        var headerView = new UIView(new CGRect(0, 0, tableView.Frame.Size.Width, headerHeight));
    //        if (headerText == "")
    //        {
    //            headerView.BackgroundColor = UIColor.Clear;
    //        }
    //        else
    //        {
    //            headerView.BackgroundColor = UIColor.White;
    //        }

    //        var headerLabel = new UILabel(new CGRect(5, 2, tableView.Frame.Size.Width - 5, 18));
    //        headerLabel.BackgroundColor = UIColor.Clear;
    //        headerLabel.TextColor = UIColor.Black;
    //        headerLabel.Font = UIFont.BoldSystemFontOfSize(16);

    //        headerLabel.Text = headerText;
    //        headerLabel.TextAlignment = UITextAlignment.Left;
    //        //headerLabel.Center.Y = headerView.Center.Y;
    //        headerView.AddSubview(headerLabel);
    //        return headerView;
    //    }

    //}
}
