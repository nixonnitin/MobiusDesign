using System;
using UIKit;
using System.Collections.Generic;
using Foundation;
using CoreGraphics;
using Mobius.iOS.Helper;
namespace Mobius.iOS.Views
{
    public class TestTableSource: UITableViewSource
    {
        UITableView table;
        public TestTableSource(UITableView table)
        {
            this.table = table;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            //if (indexPath.Section == 0)
            //{

            //    var cell = (CheckoutTermsConditionsCell)tableView.DequeueReusableCell(CheckoutTermsConditionsCell.Key, indexPath);
            //    cell.SelectionStyle = UITableViewCellSelectionStyle.None;
            //    return cell;
            //}
             if (indexPath.Section == 0)
            {
                var cell = (CheckoutInputCardCell)tableView.DequeueReusableCell(CheckoutInputCardCell.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                return cell;

            }
            else if (indexPath.Section == 1)
            {
                var cell = (HomeIntroductionCell)tableView.DequeueReusableCell(HomeIntroductionCell.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                cell.imageBackground.Image = UIImage.FromBundle("backgroundRed");
                cell.LabelTitle.TextAlignment = UITextAlignment.Left;
                cell.LabelText.TextAlignment = UITextAlignment.Left;
                cell.LabelText.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.";
                //cell.BackgroundColor = MobiusHelper.GetColorLightGrey();
                //cell.LabelText.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.";
                //MobiusHelper.GetRoundedCornerFromSideOfView(cell.ViewOfferDetailContainer, UIRectCorner.BottomLeft | UIRectCorner.BottomRight);
                return cell;
            }else{

                var cell = (CheckoutCardExpireCell)tableView.DequeueReusableCell(CheckoutCardExpireCell.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                return cell;
            }
        }

        public override nint RowsInSection(UITableView tableView, nint section)
        {
            return 1;
        }

        public override nint NumberOfSections(UITableView tableView)
        {
            return 3;
        }
    }
}
