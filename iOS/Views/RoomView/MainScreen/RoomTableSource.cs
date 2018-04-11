using System;
using UIKit;
using System.Collections.Generic;
using Foundation;
using CoreGraphics;
using Mobius.iOS.Helper;

namespace Mobius.iOS.Views
{
    public class RoomTableSource : UITableViewSource
    {
        UITableView table;
        List<string> sections;
        List<string> collectionViewLabels;
        List<string> collectionViewImages;

        public RoomTableSource(UITableView table, List<string> sections, List<string> collectionViewLabels, List<string> collectionViewImages)
        {
            this.table = table;
            this.sections = sections;
            this.collectionViewLabels = collectionViewLabels;
            this.collectionViewImages = collectionViewImages;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            

            switch (indexPath.Section)
            {
                case 0:
                    var cell = (SelectedRoomCell)tableView.DequeueReusableCell(SelectedRoomCell.Key, indexPath);
                    cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                    cell.ConstraintImageSliderHeight.Constant = 200;
                    return cell;

                case 1:
                    var cell1 = (RoomNameCell)tableView.DequeueReusableCell(RoomNameCell.Key, indexPath);
                    cell1.SelectionStyle = UITableViewCellSelectionStyle.None;
                   
                    return cell1;
                case 2:
                    var cell2 = (DirectBookCell)tableView.DequeueReusableCell(DirectBookCell.Key, indexPath);
                    cell2.SelectionStyle = UITableViewCellSelectionStyle.None;
                   
                    return cell2;
                case 3:
                    var cell3 = (DisplayPriceTextCell)tableView.DequeueReusableCell(DisplayPriceTextCell.Key, indexPath);
                    cell3.SelectionStyle = UITableViewCellSelectionStyle.None;
                    //UIViewHelper.SetShadow(cell3, 2); 
                    return cell3;
                case 4:
                    var cell4 = (RoomRateCell)tableView.DequeueReusableCell(RoomRateCell.Key, indexPath);
                    cell4.SelectionStyle = UITableViewCellSelectionStyle.None;

                    //UIViewHelper.SetShadow(cell4, 2); 
                    return cell4;
                case 6:
                    var cell6 = (RoomDescriptionCell)tableView.DequeueReusableCell(RoomDescriptionCell.Key, indexPath);
                    cell6.SelectionStyle = UITableViewCellSelectionStyle.None;

                    //UIViewHelper.SetShadow(cell4, 2); 
                    return cell6;
                case 5 :
                    
                    var cell5 = (HomeCollectionContainerCell)tableView.DequeueReusableCell(HomeCollectionContainerCell.Key, indexPath);
                    cell5.SelectionStyle = UITableViewCellSelectionStyle.None;
                    cell5.CollectionViewHomeCell.RegisterNibForCell(UINib.FromName("HotelAmenitiesCollectionCell", NSBundle.MainBundle), "HotelAmenitiesCollectionCell");
                    var layout = new UICollectionViewFlowLayout();

                    layout.ScrollDirection = UICollectionViewScrollDirection.Horizontal;
                    cell5.CollectionViewHomeCell.CollectionViewLayout = layout;
                    cell5.ConstraintCollectionViewHeight.Constant = tableView.Frame.Height * (nfloat)0.20;

                    cell5.CollectionViewHomeCell.Source = new HotelCollectionViewSource(cell5.CollectionViewHomeCell,collectionViewLabels, collectionViewImages);
                    cell5.CollectionViewHomeCell.Delegate = new HotelCollectionViewDelegate(cell5.CollectionViewHomeCell);
                    return cell5;




                default: 
                    var cellDefault = new UITableViewCell();
                    return cellDefault;
                   
            }


            /*
            if (indexPath.Section == 0)
            {
                var cell = (HomeIntroductionCell)tableView.DequeueReusableCell(HomeIntroductionCell.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                cell.LabelText.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.";
                return cell;
            }
            */
           
        }

        public override nint RowsInSection(UITableView tableView, nint section)
        {
            return 1;
            /*
            if (section == 10 || section == 11 || section == 15)
            {
                return 3;
            }
            else
            {
                return 1;
            }
            */
        }

        public override nint NumberOfSections(UITableView tableView)
        {
            
            return sections.Count;
        }

      

    }
}

