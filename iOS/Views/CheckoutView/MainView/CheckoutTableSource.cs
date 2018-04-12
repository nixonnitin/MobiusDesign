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
                    cell.ViewSeperator.Hidden = true;
                    return cell;
                }
                else if (indexPath.Row == 1)
                {
                    var cell = (CheckoutPriceBreakdownCell)tableView.DequeueReusableCell(CheckoutPriceBreakdownCell.Key, indexPath);
                    cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                    cell.ViewSeperator.Hidden = false;
                    cell.LabelAmount.TextColor = MobiusHelper.GetColorGray();
                    cell.LabelAmount.Font = MobiusHelper.GetFontRegularWithSize(14);
                    cell.LabelDetail.TextColor = MobiusHelper.GetColorGray();
                    cell.LabelDetail.Font = MobiusHelper.GetFontRegularWithSize(14);
                    cell.ViewSeperator.BackgroundColor = MobiusHelper.GetColorBorderGrey();
                    return cell;
                    
                }else{
                    var cell = (CheckoutPriceBreakdownCell)tableView.DequeueReusableCell(CheckoutPriceBreakdownCell.Key, indexPath);
                    cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                    cell.ViewSeperator.Hidden = true;
                    cell.LabelAmount.Font = MobiusHelper.GetFontBoldWithSize(16);
                    cell.LabelDetail.Font = MobiusHelper.GetFontBoldWithSize(16);
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
    }
}