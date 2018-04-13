using System;
using UIKit;
using System.Collections.Generic;
using Foundation;
using CoreGraphics;
using Mobius.iOS.Helper;

namespace Mobius.iOS.Views
{
    public class BuyEnhancementTableSource : UITableViewSource
    {
        UITableView table;
        List<string> sections;
        //List<string> collectionViewLabels;
        //List<string> collectionViewImages;

        public BuyEnhancementTableSource(UITableView table, List<string> sections)
        {
            this.table = table;
            this.sections = sections;
            //this.collectionViewLabels = collectionViewLabels;
            //this.collectionViewImages = collectionViewImages;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {


            switch (indexPath.Section)
            {
                case 0:
                    var cell = (HomeRateCell)tableView.DequeueReusableCell(HomeRateCell.Key, indexPath);
                    cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                    cell.ConstraintButtonCheckinHeight.Constant = 0;
                    cell.ConstraintLabelAdvancedPurchaseHeight.Constant = 0;
                    cell.buttonHotelImageEdit.Hidden = true;
                    return cell;

                case 1:
                    var cell1 = (HomeRateCell)tableView.DequeueReusableCell(HomeRateCell.Key, indexPath);
                    cell1.SelectionStyle = UITableViewCellSelectionStyle.None;
                    cell1.ConstraintButtonCheckinHeight.Constant = 0;
                    cell1.labelAdvabcePurchaseRate.Hidden = true;
                    cell1.constraintHotelImageHeight.Constant = 0;
                    cell1.buttonHotelImageEdit.Hidden = true;

                    return cell1;
                case 2:
                    var cell2 = (HomeEnhancementsCell)tableView.DequeueReusableCell(HomeEnhancementsCell.Key, indexPath);
                    cell2.SelectionStyle = UITableViewCellSelectionStyle.None;
                    cell2.ConstraintSelectedViewWidth.Constant = 0;
                    UIViewHelper.SetShadow(cell2, 5, 0.3f, 3f, 0.2f, 0.2f); 
                    return cell2;
                case 3:
                    var cell3 = (HomeEnhancementsCell)tableView.DequeueReusableCell(HomeEnhancementsCell.Key, indexPath);
                    cell3.SelectionStyle = UITableViewCellSelectionStyle.None;
                    UIViewHelper.SetShadow(cell3, 5, 0.3f, 3f, 0.2f, 0.2f); 
                    return cell3;
                case 4:
                    var cell4 = (HomeNotificationCell)tableView.DequeueReusableCell(HomeNotificationCell.Key, indexPath);
                    cell4.SelectionStyle = UITableViewCellSelectionStyle.None;
                    cell4.labelGrayBelow.Text = "Enhancement has been added to your booking and will be payable on hotel checkin";
                    cell4.labelGrayBelow.Font = MobiusHelper.GetFontRegularWithSize(12);
                    cell4.labelGrayBelow.TextColor = MobiusHelper.GetColorGray();
                    cell4.labelMainPopUp.Text = "Enhancement Added";
                    return cell4;

                case 5:
                    var cell5 = (BreakfastViewCell)tableView.DequeueReusableCell(BreakfastViewCell.Key, indexPath);
                    cell5.SelectionStyle = UITableViewCellSelectionStyle.None;
                    return cell5;
                case 6:
                    var cell6 = (SearchAmentiesButtonViewCell)tableView.DequeueReusableCell(SearchAmentiesButtonViewCell.Key, indexPath);
                    cell6.SelectionStyle = UITableViewCellSelectionStyle.None;
                    return cell6;
                 


                default:
                    var cellDefault = new UITableViewCell();
                    return cellDefault;

            }

        }

        public override nint RowsInSection(UITableView tableView, nint section)
        {
            if(section ==2){
                return 3;
            }
            return 1;
        }

        public override nint NumberOfSections(UITableView tableView)
        {

            return sections.Count;
        }



    }
}

