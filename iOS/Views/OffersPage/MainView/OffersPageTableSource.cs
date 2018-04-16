using System;
using UIKit;
using System.Collections.Generic;
using Foundation;
using CoreGraphics;
using Mobius.iOS.Helper;
namespace Mobius.iOS.Views
{
    public class OffersPageTableSource : UITableViewSource
    {
        UITableView table;
        List<string> sections;
        public OffersPageTableSource(UITableView table, List<string> sections)
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
                var cell = (OfferPageOfferCell)tableView.DequeueReusableCell(OfferPageOfferCell.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                return cell;
            }
            else if (indexPath.Section == 1)
            {
                var cell = (OfferPageWebviewCell)tableView.DequeueReusableCell(OfferPageWebviewCell.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                cell.ConstraintWebviewHeight.Constant = 300;
                cell.WebviewDescription.BackgroundColor = MobiusHelper.GetColorLightGrey();

                NSUrlRequest req = new NSUrlRequest(new NSUrl("https://m.facebook.com"));
                cell.WebviewDescription.LoadRequest(req);
                return cell;
            }
            else
            {
                var cell = (HomeButtonCell)tableView.DequeueReusableCell(HomeButtonCell.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                cell.BackgroundColor = MobiusHelper.GetColorLightGrey();
                //cell.LabelText.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.";
                //MobiusHelper.GetRoundedCornerFromSideOfView(cell.ViewOfferDetailContainer, UIRectCorner.BottomLeft | UIRectCorner.BottomRight);
                return cell;
            }


            //CheckoutTermsConditionsCell
        }
        public override nint RowsInSection(UITableView tableView, nint section)
        {
            
                return 1;
            

        }
        public override nint NumberOfSections(UITableView tableView)
        {
            return sections.Count;
            //return 12;
        }

    }

       public class OffersPageTableDelegate : UITableViewDelegate
       {
           UITableView table;
           CGSize viewSize;
           List<string> sections;
        public OffersPageTableDelegate(UITableView tableView, CGSize viewSize, List<string> sections)
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


