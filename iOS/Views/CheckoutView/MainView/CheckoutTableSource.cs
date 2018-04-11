using System;
using UIKit;
using System.Collections.Generic;
using Foundation;
using CoreGraphics;
using Mobius.iOS.Helpers;
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
            if (indexPath.Section == 0)
            {
                var cell = (CheckoutBookingDetailCell)tableView.DequeueReusableCell(CheckoutBookingDetailCell.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                cell.BackgroundColor = MobiusHelper.GetColorLightGrey();
                //cell.LabelText.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.";
                //MobiusHelper.GetRoundedCornerFromSideOfView(cell.ViewOfferDetailContainer, UIRectCorner.BottomLeft | UIRectCorner.BottomRight);
                return cell;
            }else{
                if(indexPath.Row == 0){
                    var cell = (CheckoutInputTextCell)tableView.DequeueReusableCell(CheckoutInputTextCell.Key, indexPath);
                    cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                    //cell.LabelText.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.";
                    //MobiusHelper.GetRoundedCornerFromSideOfView(cell.ViewOfferDetailContainer, UIRectCorner.BottomLeft | UIRectCorner.BottomRight);
                    cell.imageInputView.Image = UIImage.FromBundle("personGrey");
                    cell.textInput.Placeholder = "First Name";
                    cell.textSubInput.Placeholder = "Last Name";
                    return cell;
                }else if (indexPath.Row == 1)
                {
                    var cell = (CheckoutSingleInputTextCell)tableView.DequeueReusableCell(CheckoutSingleInputTextCell.Key, indexPath);
                    cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                    //cell.LabelText.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.";
                    //MobiusHelper.GetRoundedCornerFromSideOfView(cell.ViewOfferDetailContainer, UIRectCorner.BottomLeft | UIRectCorner.BottomRight);
                    cell.ImageInput.Image = UIImage.FromBundle("emailGrey");
                    cell.TextInput.Placeholder = "Email Address";
                    return cell;
                }else
                {
                    var cell = (CheckoutSingleInputTextCell)tableView.DequeueReusableCell(CheckoutSingleInputTextCell.Key, indexPath);
                    cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                    cell.ImageInput.Image = UIImage.FromBundle("phoneGrey");
                    cell.TextInput.Placeholder = "Telephone Number";
                    return cell;
                }

            }
        }
        public override nint RowsInSection(UITableView tableView, nint section)
        {
            if(section == 1){
                return 3;
            }else{
                return 1;
            }

        }
        public override nint NumberOfSections(UITableView tableView)
        {
            //return sections.Count;
            return 2;
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
