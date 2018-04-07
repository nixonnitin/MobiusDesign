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
                cell.BookYourStay.BackgroundColor = new UIColor(red: 0.20f, green: 0.55f, blue: 0.61f, alpha: 1.0f);
                //cell.BookYourStay.Layer.BorderWidth = 1;
                //cell.BookYourStay.Layer.BorderColor = new UIColor(red: 0.20f, green: 0.55f, blue: 0.61f, alpha: 1.0f).CGColor;
                //                self.yourView.layer.borderWidth = 1
                //self.yourView.layer.borderColor = UIColor(red: 222 / 255, green: 225 / 255, blue: 227 / 255, alpha: 1).cgColor
                cell.BookYourStay.SetTitleColor(UIColor.White, UIControlState.Normal);
                return cell;
            }
            else if (indexPath.Section == 2)
            {
                var cell = (HomeCollectionContainerCell)tableView.DequeueReusableCell(HomeCollectionContainerCell.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                cell.CollectionViewHomeCell14.RegisterNibForCell(UINib.FromName("HomeCell4", NSBundle.MainBundle), "HomeCell4");
                cell.CollectionViewHomeCell14.Tag = 1;
                var layout = new UICollectionViewFlowLayout();
                layout.ScrollDirection = UICollectionViewScrollDirection.Horizontal;
                //layout.ItemSize = new CGSize(tableView.Frame.Width * (nfloat)0.8,tableView.Frame.Height * (nfloat)0.25);
                cell.CollectionViewHomeCell14.CollectionViewLayout = layout;
                cell.ConstraintCollectionViewHeight.Constant = tableView.Frame.Height * (nfloat)0.25;

                cell.CollectionViewHomeCell14.Source = new MainHomeCollectionSource(cell.CollectionViewHomeCell14);
                cell.CollectionViewHomeCell14.Delegate = new MainHomeCollectionLayoutDelegate(cell.CollectionViewHomeCell14);
                return cell;
            }
            else if (indexPath.Section == 3)
            {
                var cell = (HomeCollectionContainerCell)tableView.DequeueReusableCell(HomeCollectionContainerCell.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                cell.CollectionViewHomeCell14.RegisterNibForCell(UINib.FromName("HomeCell2", NSBundle.MainBundle), "HomeCell2");
                var layout = new UICollectionViewFlowLayout();
                layout.ScrollDirection = UICollectionViewScrollDirection.Horizontal;
                //layout.ItemSize = new CGSize(tableView.Frame.Width * (nfloat)0.8,tableView.Frame.Height * (nfloat)0.25);
                cell.CollectionViewHomeCell14.CollectionViewLayout = layout;
                cell.ConstraintCollectionViewHeight.Constant = tableView.Frame.Height * (nfloat)0.45;
                cell.CollectionViewHomeCell14.Tag = 2;
                cell.CollectionViewHomeCell14.Source = new MainHomeCollectionSource(cell.CollectionViewHomeCell14);
                cell.CollectionViewHomeCell14.Delegate = new MainHomeCollectionLayoutDelegate(cell.CollectionViewHomeCell14);
                return cell;
            }
            else if (indexPath.Section == 4)
            {
                var cell = (HomeCollectionContainerCell)tableView.DequeueReusableCell(HomeCollectionContainerCell.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                cell.CollectionViewHomeCell14.RegisterNibForCell(UINib.FromName("HomeCell6", NSBundle.MainBundle), "HomeCell6");
                var layout = new UICollectionViewFlowLayout();
                layout.ScrollDirection = UICollectionViewScrollDirection.Horizontal;
                //layout.ItemSize = new CGSize(tableView.Frame.Width * (nfloat)0.8,tableView.Frame.Height * (nfloat)0.25);
                cell.CollectionViewHomeCell14.CollectionViewLayout = layout;
                cell.ConstraintCollectionViewHeight.Constant = tableView.Frame.Height * (nfloat)0.45;
                cell.CollectionViewHomeCell14.Tag = 3;
                cell.CollectionViewHomeCell14.Source = new MainHomeCollectionSource(cell.CollectionViewHomeCell14);
                cell.CollectionViewHomeCell14.Delegate = new MainHomeCollectionLayoutDelegate(cell.CollectionViewHomeCell14);
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
                var cell = (HomeCell15)tableView.DequeueReusableCell(HomeCell15.Key, indexPath);
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
                cell.CollectionViewHomeCell14.RegisterNibForCell(UINib.FromName("HomeCell4", NSBundle.MainBundle), "HomeCell4");
                cell.CollectionViewHomeCell14.Tag = 4;
                var layout = new UICollectionViewFlowLayout();
                layout.ScrollDirection = UICollectionViewScrollDirection.Vertical;
                cell.CollectionViewHomeCell14.CollectionViewLayout = layout;
                cell.ConstraintCollectionViewHeight.Constant = tableView.Frame.Height * (nfloat)0.75;
                cell.CollectionViewHomeCell14.Source = new HomeViewOffer3Cell(cell.CollectionViewHomeCell14);
                cell.CollectionViewHomeCell14.Delegate = new HomeViewOffer3CellLayout(cell.CollectionViewHomeCell14);
                //cell.CollectionViewHomeCell14.scrol
                return cell;
            }
            else if (indexPath.Section == 9)
            {
                var cell = (HomeCell13)tableView.DequeueReusableCell(HomeCell13.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                //cell.ConstraintSelectedViewWidth.Constant = 0;
                //cell.ConstraintOfferHeight.Constant =
                cell.ConstraintButtonCheckinHeight.Constant = 0;
                cell.ConstraintLabelAdvancedPurchaseHeight.Constant = 0;
                return cell;
            }
            else if (indexPath.Section == 10)
            {
                var cell = (HomeCell10)tableView.DequeueReusableCell(HomeCell10.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                cell.ConstraintSelectedViewWidth.Constant = 85;
                cell.LabelPointsDetail.Hidden = false;
                return cell;
            }
            else if (indexPath.Section == 11)
            {
                var cell = (HomeCell10)tableView.DequeueReusableCell(HomeCell10.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                cell.ConstraintSelectedViewWidth.Constant = 0;
                cell.LabelPointsDetail.Hidden = false;
                return cell;
            }else if (indexPath.Section == 12)
            {
                var cell = (HomeCell13)tableView.DequeueReusableCell(HomeCell13.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                //cell.ConstraintSelectedViewWidth.Constant = 0;
                //cell.ConstraintOfferHeight.Constant =
                //cell.ConstraintButtonCheckinHeight.Constant = 0;
                //cell.ConstraintLabelAdvancedPurchaseHeight.Constant = 0;
                cell.ConstraintOfferHeight.Constant = 0;
                return cell;
            }
            else if (indexPath.Section == 13)
            {
                var cell = (HomeCell13)tableView.DequeueReusableCell(HomeCell13.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                //cell.ConstraintOfferHeight.Constant = 0;
                return cell;
            }
            else if (indexPath.Section == 14)
            {
                var cell = (HomeCell16)tableView.DequeueReusableCell(HomeCell16.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                return cell;
            }
            else if (indexPath.Section == 15)
            {
                var cell = (HomeCell10)tableView.DequeueReusableCell(HomeCell10.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                cell.ConstraintSelectedViewWidth.Constant = 0;
                cell.LabelPointsDetail.Hidden = true;
                return cell;
            }
            else if (indexPath.Section == 16)
            {
                var cell = (HomeCell11)tableView.DequeueReusableCell(HomeCell11.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                return cell;
            }
            else if (indexPath.Section == 17)
            {
                var cell = (HomeButtonCell)tableView.DequeueReusableCell(HomeButtonCell.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                //cell.ConstraintSelectedViewWidth.Constant = 0;
                //cell.LabelPointsDetail.Hidden = true;
                cell.BookYourStay.BackgroundColor = UIColor.White;
                cell.BookYourStay.Layer.BorderWidth = 1;
                cell.BookYourStay.Layer.BorderColor = new UIColor(red: 0.20f, green: 0.55f, blue: 0.61f, alpha: 1.0f).CGColor;
                //                self.yourView.layer.borderWidth = 1
                //self.yourView.layer.borderColor = UIColor(red: 222 / 255, green: 225 / 255, blue: 227 / 255, alpha: 1).cgColor
                cell.BookYourStay.SetTitleColor(new UIColor(red: 0.20f, green: 0.55f, blue: 0.61f, alpha: 1.0f), UIControlState.Normal);
                return cell;
            }
            else
            {
                var cell = (HomeCell15)tableView.DequeueReusableCell(HomeCell15.Key, indexPath);
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

		//public override string TitleForHeader(UITableView tableView, nint section)
		//{
		//    var titleHeader = sections[(int)section];
		//    return titleHeader;
		//}
		//public override UIView GetViewForHeader(UITableView tableView, nint section)
		//{
  //          UIView v = new UIView(new System.Drawing.RectangleF(0, 0, (float)tableView.Frame.Size.Width, 44));
  //          v.BackgroundColor = UIColor.Red;
  //          return v;
		//}
		//public override UIView GetViewForHeader(UITableView tableView, int section)
        //{
        //    UIView v = new UIView(new System.Drawing.RectangleF(0, 0, UIScreen.MainScreen.Bounds.Width, UIScreen.MainScreen.Bounds.Height));
        //    v.BackgroundColor = UIColor.Red;
        //    return v;
        //}
		//public override
		public override UIView GetViewForHeader(UITableView tableView, nint section)
		{
            
            //return base.GetViewForHeader(tableView, section);





            // 1. The view for the header

            //        UIView* headerView = [[UIView alloc] initWithFrame: CGRectMake(0, 0, tableView.frame.size.width, 22)];
            var headerView = new UIView(new CGRect(0, 0, tableView.Frame.Size.Width, 22));

            headerView.BackgroundColor = UIColor.Clear;

            //        // 2. Set a custom background color and a border 
            //        headerView.backgroundColor = [UIColor colorWithWhite: 0.5f alpha: 1.0f];
            //        headerView.layer.borderColor = [UIColor colorWithWhite: 0.5 alpha: 1.0].CGColor;
            //        headerView.layer.borderWidth = 1.0;

            //        // 3. Add a label
            var headerLabel = new UILabel(new CGRect(5, 2, tableView.Frame.Size.Width - 5, 18));
            headerLabel.BackgroundColor = UIColor.Clear;
            headerLabel.TextColor = UIColor.Black;
            headerLabel.Font = UIFont.BoldSystemFontOfSize(14);
            headerLabel.Text = sections[(int)section];
            headerLabel.TextAlignment = UITextAlignment.Left;

            headerView.AddSubview(headerLabel);
            return headerView;
    //        UILabel* headerLabel = [[UILabel alloc] init];
    //        headerLabel.frame = CGRectMake(5, 2, tableView.frame.size.width - 5, 18);
    //        headerLabel.backgroundColor = [UIColor clearColor];
    //        headerLabel.textColor = [UIColor whiteColor];
    //        headerLabel.font = [UIFont boldSystemFontOfSize: 16.0];
    //        headerLabel.text = @"This is the custom header view";
    //        headerLabel.textAlignment = NSTextAlignmentLeft;

    //// 4. Add the label to the header view
    //    [headerView addSubview:headerLabel];

    //// 5. Finally return
    //return headerView;

		}
	}
}
