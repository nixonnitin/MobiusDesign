using System;
using UIKit;
using System.Collections.Generic;
using Foundation;
using CoreGraphics;
using Mobius.iOS.Helper;
namespace Mobius.iOS.Views
{
    public class CheckoutTableSource : UITableViewSource
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
            }
            else if (indexPath.Section == 1)
            {
                if (indexPath.Row == 0)
                {
                    var cell = (CheckoutInputTextCell)tableView.DequeueReusableCell(CheckoutInputTextCell.Key, indexPath);
                    cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                    //cell.LabelText.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.";
                    //MobiusHelper.GetRoundedCornerFromSideOfView(cell.ViewOfferDetailContainer, UIRectCorner.BottomLeft | UIRectCorner.BottomRight);
                    cell.imageInputView.Image = UIImage.FromBundle("personGrey");
                    cell.textInput.Placeholder = "First Name";
                    cell.textSubInput.Placeholder = "Last Name";
                    return cell;
                }
                else if (indexPath.Row == 1)
                {
                    var cell = (CheckoutSingleInputTextCell)tableView.DequeueReusableCell(CheckoutSingleInputTextCell.Key, indexPath);
                    cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                    //cell.LabelText.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.";
                    //MobiusHelper.GetRoundedCornerFromSideOfView(cell.ViewOfferDetailContainer, UIRectCorner.BottomLeft | UIRectCorner.BottomRight);
                    cell.imageInputView.Image = UIImage.FromBundle("emailGrey");
                    cell.textInput.Placeholder = "Email Address";
                    return cell;
                }
                else
                {
                    var cell = (CheckoutSingleInputTextCell)tableView.DequeueReusableCell(CheckoutSingleInputTextCell.Key, indexPath);
                    cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                    cell.imageInputView.Image = UIImage.FromBundle("phoneGrey");
                    cell.textInput.Placeholder = "Telephone Number";
                    return cell;
                }

            }
            else if (indexPath.Section == 2)
            {
                var cell = (CheckoutSignupInfoCell)tableView.DequeueReusableCell(CheckoutSignupInfoCell.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                //cell.BackgroundColor = MobiusHelper.GetColorLightGrey();
                //cell.LabelText.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.";
                //MobiusHelper.GetRoundedCornerFromSideOfView(cell.ViewOfferDetailContainer, UIRectCorner.BottomLeft | UIRectCorner.BottomRight);
                return cell;
            }
            else if (indexPath.Section == 3)
            {
                var cell = (CheckoutSingleInputTextCell)tableView.DequeueReusableCell(CheckoutSingleInputTextCell.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                //cell.LabelText.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.";
                //MobiusHelper.GetRoundedCornerFromSideOfView(cell.ViewOfferDetailContainer, UIRectCorner.BottomLeft | UIRectCorner.BottomRight);
                cell.imageInputView.Image = UIImage.FromBundle("lockGrey");
                cell.textInput.Placeholder = "Enter a Password";
                cell.textInput.SecureTextEntry = true;
                return cell;
            }else if (indexPath.Section == 4)
            {
                var cell = (CheckoutPromocodeCell)tableView.DequeueReusableCell(CheckoutPromocodeCell.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                return cell;
            }else if (indexPath.Section == 6 || indexPath.Section == 5)
            {
                var cell = (CheckoutTermsConditionsCell)tableView.DequeueReusableCell(CheckoutTermsConditionsCell.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                return cell;
            }
            else if (indexPath.Section == 7)
            {

                var cell = (CheckoutNextCell)tableView.DequeueReusableCell(CheckoutNextCell.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                return cell;
            }else 
            {
                if (indexPath.Row == 0)
                {
                    var cell = (CheckoutPriceBreakdownCell)tableView.DequeueReusableCell(CheckoutPriceBreakdownCell.Key, indexPath);
                    cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                    cell.viewSeperator.Hidden = true;
                    return cell;
                }
                else if (indexPath.Row == 1)
                {
                    var cell = (CheckoutPriceBreakdownCell)tableView.DequeueReusableCell(CheckoutPriceBreakdownCell.Key, indexPath);
                    cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                    cell.viewSeperator.Hidden = false;
                    cell.labelAmount.TextColor = MobiusHelper.GetColorGray();
                    cell.labelAmount.Font = MobiusHelper.GetFontRegularWithSize(14);
                    cell.labelDetail.TextColor = MobiusHelper.GetColorGray();
                    cell.labelDetail.Font = MobiusHelper.GetFontRegularWithSize(14);
                    cell.viewSeperator.BackgroundColor = MobiusHelper.GetColorBorderGrey();
                    return cell;
                    
                }else{
                    var cell = (CheckoutPriceBreakdownCell)tableView.DequeueReusableCell(CheckoutPriceBreakdownCell.Key, indexPath);
                    cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                    cell.viewSeperator.Hidden = true;
                    cell.labelAmount.Font = MobiusHelper.GetFontBoldWithSize(16);
                    cell.labelDetail.Font = MobiusHelper.GetFontBoldWithSize(16);
                    return cell;
                }

            }

            //CheckoutTermsConditionsCell
        }
        public override nint RowsInSection(UITableView tableView, nint section)
        {
            if (section == 1 || section == 8)
            {
                return 3;
            }
            else
            {
                return 1;
            }

        }
        public override nint NumberOfSections(UITableView tableView)
        {
            //return sections.Count;
            return 9;
        }


		public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
		{
            if(indexPath.Section == 2){
                var cell = (CheckoutSignupInfoCell)tableView.DequeueReusableCell(CheckoutSignupInfoCell.Key, indexPath);
                //System.Console.WriteLine("Tapped");
                //if(cell.ConstraintViewHeight.Constant <= 0){
                //    cell.ConstraintViewHeight.Constant = 82.5f;
                //}else{
                //    cell.ConstraintViewHeight.Constant = 0;
                //}
                //tableView.reloadRows(at: [IndexPath(row: label.tag, section: 0)], with: .fade)
                NSIndexPath[] indexPaths = new NSIndexPath[1];
                indexPaths[0] = indexPath;
                //tableView.ReloadRows
                         tableView.ReloadRows(indexPaths, UITableViewRowAnimation.Automatic);
                tableView.BeginUpdates();
                tableView.EndUpdates();
            }
		}

		//public override void RowHighlighted(UITableView tableView, NSIndexPath rowIndexPath)
		//{
  //          var cell = (CheckoutSignupInfoCell)tableView.CellAt(rowIndexPath);
  //          cell.ConstraintViewHeight.Constant = 0;
  //          System.Console.WriteLine("Highlighted");
		//}

		//public override void RowUnhighlighted(UITableView tableView, NSIndexPath rowIndexPath)
		//{
  //          var cell = (CheckoutSignupInfoCell)tableView.CellAt(rowIndexPath);
  //          cell.ConstraintViewHeight.Constant = 82.5f;
  //          System.Console.WriteLine("UnHighlighted");
		//}

	}

    public class CheckoutTableDelegate : UITableViewDelegate
    {
        UITableView table;
        CGSize viewSize;
        List<string> sections;
        public CheckoutTableDelegate(UITableView tableView, CGSize viewSize, List<string> sections)
        {
            this.table = tableView;
            this.viewSize = viewSize;
            this.sections = sections;
        }

		//public override UIView GetViewForHeader(UITableView tableView, nint section)
		//{
		//    var headerText = sections[(int)section];
		//    var headerHeight = 22;


		//    var headerView = new UIView(new CGRect(0, 0, tableView.Frame.Size.Width, headerHeight));
		//    if (headerText == "")
		//    {
		//        headerView.BackgroundColor = UIColor.Clear;
		//    }
		//    else
		//    {
		//        headerView.BackgroundColor = UIColor.White;
		//    }

		//    var headerLabel = new UILabel(new CGRect(5, 2, tableView.Frame.Size.Width - 5, 18));
		//    headerLabel.BackgroundColor = UIColor.Clear;
		//    headerLabel.TextColor = UIColor.Black;
		//    headerLabel.Font = UIFont.BoldSystemFontOfSize(16);

		//    headerLabel.Text = headerText;
		//    headerLabel.TextAlignment = UITextAlignment.Left;
		//    //headerLabel.Center.Y = headerView.Center.Y;
		//    headerView.AddSubview(headerLabel);
		//    return headerView;
		//}

	}
}


