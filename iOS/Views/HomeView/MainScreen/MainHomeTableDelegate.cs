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
        public MainHomeTableDelegate(UITableView tableView, CGSize viewSize)
        {
            this.table = tableView;
            this.viewSize = viewSize;
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
