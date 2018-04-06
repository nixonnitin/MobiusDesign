using System;
using UIKit;
using System.Collections.Generic;
using Foundation;
using CoreGraphics;
namespace Mobius.iOS.Views
{
    public class MainHomeTableDelegate : UITableViewDelegate
    {
        UITableView table;
        CGSize viewSize;
        List<string> sections;
        public MainHomeTableDelegate(UITableView tableView, CGSize viewSize, List<string> sections)
        {
            this.table = tableView;
            this.viewSize = viewSize;
            this.sections = sections;
        }
        public override UIView GetViewForHeader(UITableView tableView, nint section)
        {
            var headerText = sections[(int)section];
            var headerHeight = 22;


            var headerView = new UIView(new CGRect(0, 0, tableView.Frame.Size.Width, headerHeight));
            if (headerText == "")
            {
                headerView.BackgroundColor = UIColor.Clear;
            }else{
                headerView.BackgroundColor = UIColor.White;
            }

            var headerLabel = new UILabel(new CGRect(5, 2, tableView.Frame.Size.Width - 5, 18));
            headerLabel.BackgroundColor = UIColor.Clear;
            headerLabel.TextColor = UIColor.Black;
            headerLabel.Font = UIFont.BoldSystemFontOfSize(16);

            headerLabel.Text = headerText;
            headerLabel.TextAlignment = UITextAlignment.Left;
            //headerLabel.Center.Y = headerView.Center.Y;
            headerView.AddSubview(headerLabel);
            return headerView;
        }
        //public override nfloat GetHeightForRow(UITableView tableView, NSIndexPath indexPath)
        //{
        //    if (indexPath.Section == 0)
        //    {
        //        return (viewSize.Height * (nfloat)0.20);
        //    }
        //    else if (indexPath.Section == 1)
        //    {
        //        return (viewSize.Height * (nfloat)0.10);
        //    }
        //    else if (indexPath.Section == 2)
        //    {

        //        return (viewSize.Height * (nfloat)0.25);
        //    }
        //    else if (indexPath.Section == 3)
        //    {
        //        return (viewSize.Height * (nfloat)0.35);
        //    }
        //    else
        //    {
        //        return (viewSize.Height * (nfloat)0.35);
        //    }
        //}
    }
}
