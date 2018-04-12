using System;
using UIKit;
using System.Collections.Generic;
using Foundation;
using CoreGraphics;

namespace Mobius.iOS.Views
{
    public class MainHomeTableSource : UITableViewSource
    {
        UITableView table;
        List<string> sections;

        public MainHomeTableSource(UITableView table, List<string> sections)
        {
            this.table = table;
            this.sections = sections;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {

            if (indexPath.Section == 0)
            {
                var cell = (HomeIntroductionCell)tableView.DequeueReusableCell(HomeIntroductionCell.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                cell.LabelText.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.";
                return cell;
            }
            else if (indexPath.Section == 1)
            {
                var cell = (HomeButtonCell)tableView.DequeueReusableCell(HomeButtonCell.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                cell.bookYourStay.BackgroundColor = new UIColor(red: 0.20f, green: 0.55f, blue: 0.61f, alpha: 1.0f);
                //cell.BookYourStay.Layer.BorderWidth = 1;
                //cell.BookYourStay.Layer.BorderColor = new UIColor(red: 0.20f, green: 0.55f, blue: 0.61f, alpha: 1.0f).CGColor;
                //                self.yourView.layer.borderWidth = 1
                //self.yourView.layer.borderColor = UIColor(red: 222 / 255, green: 225 / 255, blue: 227 / 255, alpha: 1).cgColor
                cell.bookYourStay.SetTitleColor(UIColor.White, UIControlState.Normal);
                return cell;
            }
            else if (indexPath.Section == 2)
            {
                var cell = (HomeCollectionContainerCell)tableView.DequeueReusableCell(HomeCollectionContainerCell.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                cell.CollectionViewHomeCell.RegisterNibForCell(UINib.FromName("HomeOfferCellSmall", NSBundle.MainBundle), "HomeOfferCellSmall");
                cell.CollectionViewHomeCell.Tag = 1;
                var layout = new UICollectionViewFlowLayout();
                layout.ScrollDirection = UICollectionViewScrollDirection.Horizontal;
                //layout.ItemSize = new CGSize(tableView.Frame.Width * (nfloat)0.8,tableView.Frame.Height * (nfloat)0.25);
                cell.CollectionViewHomeCell.CollectionViewLayout = layout;
                cell.ConstraintCollectionViewHeight.Constant = tableView.Frame.Height * (nfloat)0.25;

                cell.CollectionViewHomeCell.Source = new MainHomeCollectionSource(cell.CollectionViewHomeCell);
                cell.CollectionViewHomeCell.Delegate = new MainHomeCollectionLayoutDelegate(cell.CollectionViewHomeCell);
                return cell;
            }
            else if (indexPath.Section == 3)
            {
                var cell = (HomeCollectionContainerCell)tableView.DequeueReusableCell(HomeCollectionContainerCell.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                cell.CollectionViewHomeCell.RegisterNibForCell(UINib.FromName("HomeNearHotelCell", NSBundle.MainBundle), "HomeNearHotelCell");
                var layout = new UICollectionViewFlowLayout();
                layout.ScrollDirection = UICollectionViewScrollDirection.Horizontal;
                //layout.ItemSize = new CGSize(tableView.Frame.Width * (nfloat)0.8,tableView.Frame.Height * (nfloat)0.25);
                cell.CollectionViewHomeCell.CollectionViewLayout = layout;
                cell.ConstraintCollectionViewHeight.Constant = tableView.Frame.Height * (nfloat)0.35;
                cell.CollectionViewHomeCell.Tag = 2;
                cell.CollectionViewHomeCell.Source = new MainHomeCollectionSource(cell.CollectionViewHomeCell);
                cell.CollectionViewHomeCell.Delegate = new MainHomeCollectionLayoutDelegate(cell.CollectionViewHomeCell);
                return cell;
            }
            else if (indexPath.Section == 4)
            {
                var cell = (HomeCollectionContainerCell)tableView.DequeueReusableCell(HomeCollectionContainerCell.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                cell.CollectionViewHomeCell.RegisterNibForCell(UINib.FromName("HomePopularDestinationsCell", NSBundle.MainBundle), "HomePopularDestinationsCell");
                var layout = new UICollectionViewFlowLayout();
                layout.ScrollDirection = UICollectionViewScrollDirection.Horizontal;
                //layout.ItemSize = new CGSize(tableView.Frame.Width * (nfloat)0.8,tableView.Frame.Height * (nfloat)0.25);
                cell.CollectionViewHomeCell.CollectionViewLayout = layout;
                cell.ConstraintCollectionViewHeight.Constant = tableView.Frame.Height * (nfloat)0.35;
                cell.CollectionViewHomeCell.Tag = 3;
                cell.CollectionViewHomeCell.Source = new MainHomeCollectionSource(cell.CollectionViewHomeCell);
                cell.CollectionViewHomeCell.Delegate = new MainHomeCollectionLayoutDelegate(cell.CollectionViewHomeCell);
                return cell;
            }
            else if (indexPath.Section == 5)
            {
                var cell = (HomeLastSearchCell)tableView.DequeueReusableCell(HomeLastSearchCell.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                cell.ConstraintImageWidth.Constant = 0;
                return cell;
            }
            else if (indexPath.Section == 6)
            {
                var cell = (HomeOfferCellLarge)tableView.DequeueReusableCell(HomeOfferCellLarge.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                cell.ConstraintImageHeight.Constant = 195;
                return cell;
            }
            else if (indexPath.Section == 7)
            {
                var cell = (HomeLastSearchCell)tableView.DequeueReusableCell(HomeLastSearchCell.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                return cell;
            }
            else if (indexPath.Section == 8)
            {
                var cell = (HomeCollectionContainerCell)tableView.DequeueReusableCell(HomeCollectionContainerCell.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                cell.CollectionViewHomeCell.RegisterNibForCell(UINib.FromName("HomeOfferCellSmall", NSBundle.MainBundle), "HomeOfferCellSmall");
                cell.CollectionViewHomeCell.Tag = 4;
                var layout = new UICollectionViewFlowLayout();
                layout.ScrollDirection = UICollectionViewScrollDirection.Vertical;
                cell.CollectionViewHomeCell.CollectionViewLayout = layout;
                cell.ConstraintCollectionViewHeight.Constant = tableView.Frame.Height * (nfloat)0.75;
                cell.CollectionViewHomeCell.Source = new HomeViewOffer3Cell(cell.CollectionViewHomeCell);
                cell.CollectionViewHomeCell.Delegate = new HomeViewOffer3CellLayout(cell.CollectionViewHomeCell);
                //cell.CollectionViewHomeCell14.scrol
                return cell;
            }
            else if (indexPath.Section == 9)
            {
                var cell = (HomeRateCell)tableView.DequeueReusableCell(HomeRateCell.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                //cell.ConstraintSelectedViewWidth.Constant = 0;
                //cell.ConstraintOfferHeight.Constant =
                cell.ConstraintOfferHeight.Constant = 25;
                cell.ConstraintButtonCheckinHeight.Constant = 0;
                cell.ConstraintLabelAdvancedPurchaseHeight.Constant = 0;
                return cell;
            }
            else if (indexPath.Section == 10)
            {
                var cell = (HomeEnhancementsCell)tableView.DequeueReusableCell(HomeEnhancementsCell.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                cell.ConstraintSelectedViewWidth.Constant = 85;
                cell.LabelPointsDetail.Hidden = false;
                return cell;
            }
            else if (indexPath.Section == 11)
            {
                var cell = (HomeEnhancementsCell)tableView.DequeueReusableCell(HomeEnhancementsCell.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                cell.ConstraintSelectedViewWidth.Constant = 0;
                cell.LabelPointsDetail.Hidden = false;
                return cell;
            }else if (indexPath.Section == 12)
            {
                var cell = (HomeRateCell)tableView.DequeueReusableCell(HomeRateCell.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                //cell.ConstraintSelectedViewWidth.Constant = 0;
                //cell.ConstraintOfferHeight.Constant =
                //cell.ConstraintButtonCheckinHeight.Constant = 0;
                //cell.ConstraintLabelAdvancedPurchaseHeight.Constant = 0;
                cell.ConstraintOfferHeight.Constant = 0;
                cell.ConstraintButtonCheckinHeight.Constant = 35;
                cell.ConstraintLabelAdvancedPurchaseHeight.Constant = 16.5f;
                return cell;
            }
            else if (indexPath.Section == 13)
            {
                var cell = (HomeRateCell)tableView.DequeueReusableCell(HomeRateCell.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                //cell.ConstraintOfferHeight.Constant = 0;
                cell.ConstraintOfferHeight.Constant = 25;
                cell.ConstraintButtonCheckinHeight.Constant = 35;
                cell.ConstraintLabelAdvancedPurchaseHeight.Constant = 16.5f;
                return cell;
            }
            else if (indexPath.Section == 14)
            {
                var cell = (HomeWidgetCell)tableView.DequeueReusableCell(HomeWidgetCell.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                return cell;
            }
            else if (indexPath.Section == 15)
            {
                var cell = (HomeEnhancementsCell)tableView.DequeueReusableCell(HomeEnhancementsCell.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                cell.ConstraintSelectedViewWidth.Constant = 0;
                cell.LabelPointsDetail.Hidden = true;
                return cell;
            }
            else if (indexPath.Section == 16)
            {
                var cell = (HomeNotificationCell)tableView.DequeueReusableCell(HomeNotificationCell.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                cell.labelGrayBelow.Hidden = true;
                return cell;
            }
            else if (indexPath.Section == 17)
            {
                var cell = (HomeButtonCell)tableView.DequeueReusableCell(HomeButtonCell.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                //cell.ConstraintSelectedViewWidth.Constant = 0;
                //cell.LabelPointsDetail.Hidden = true;
                cell.bookYourStay.BackgroundColor = UIColor.White;
                cell.bookYourStay.Layer.BorderWidth = 1;
                cell.bookYourStay.Layer.BorderColor = new UIColor(red: 0.20f, green: 0.55f, blue: 0.61f, alpha: 1.0f).CGColor;
                //                self.yourView.layer.borderWidth = 1
                //self.yourView.layer.borderColor = UIColor(red: 222 / 255, green: 225 / 255, blue: 227 / 255, alpha: 1).cgColor
                cell.bookYourStay.SetTitleColor(new UIColor(red: 0.20f, green: 0.55f, blue: 0.61f, alpha: 1.0f), UIControlState.Normal);
                return cell;
            }
            else
            {
                var cell = (HomeOfferCellLarge)tableView.DequeueReusableCell(HomeOfferCellLarge.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                cell.ConstraintImageHeight.Constant = 0;
                return cell;
            }

        }

        public override nint RowsInSection(UITableView tableView, nint section)
        {
            //return 1;
            if (section == 10 || section == 11 || section == 15)
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
            return sections.Count;
        }

	}
}
