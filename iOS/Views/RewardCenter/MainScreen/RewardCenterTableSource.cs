﻿using System;
using UIKit;
using System.Collections.Generic;
using Foundation;
using CoreGraphics;
using Mobius.iOS.Helper;

namespace Mobius.iOS.Views
{
    public class RewardCenterTableSource : UITableViewSource
    {
        UITableView table;
        List<string> sections;
        //List<string> collectionViewLabels;
        //List<string> collectionViewImages;

        public RewardCenterTableSource(UITableView table, List<string> sections)
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
                    var cell = (RewardCenterMemberHeaderViewCell)tableView.DequeueReusableCell(RewardCenterMemberHeaderViewCell.Key, indexPath);
                    cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                    return cell;

                case 1:
                    var cell1 = (BreakLineViewCell)tableView.DequeueReusableCell(BreakLineViewCell.Key, indexPath);
                    cell1.SelectionStyle = UITableViewCellSelectionStyle.None;
                    return cell1;


                case 2:
                    var cell2 = (HomeEnhancementsCell)tableView.DequeueReusableCell(HomeEnhancementsCell.Key, indexPath);
                    cell2.SelectionStyle = UITableViewCellSelectionStyle.None;
                    cell2.ConstraintSelectedViewWidth.Constant = 0;
                    return cell2;
                case 3:
                    var cell3 = (ImageWithHeadingViewCell)tableView.DequeueReusableCell(ImageWithHeadingViewCell.Key, indexPath);
                    cell3.SelectionStyle = UITableViewCellSelectionStyle.None;
                    return cell3;

                case 4:
                    var cell4 = (RewardDescriptionWithButtonViewCell)tableView.DequeueReusableCell(RewardDescriptionWithButtonViewCell.Key, indexPath);
                    cell4.SelectionStyle = UITableViewCellSelectionStyle.None;
                    return cell4;
                case 5:
                    var cell5 = (RewardDescriptionViewCell)tableView.DequeueReusableCell(RewardDescriptionViewCell.Key, indexPath);
                    cell5.SelectionStyle = UITableViewCellSelectionStyle.None;
                    return cell5;
                case 6:
                    var cell6 = (RewardsTableViewCell)tableView.DequeueReusableCell(RewardsTableViewCell.Key, indexPath);
                    cell6.SelectionStyle = UITableViewCellSelectionStyle.None;
                    return cell6;

                default:
                    var cellDefault = new UITableViewCell();
                    return cellDefault;

            }

        }

        public override nint RowsInSection(UITableView tableView, nint section)
        {
            if (section == 2)
            {
                return 3;
            }

            if (section == 6)
            {
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

