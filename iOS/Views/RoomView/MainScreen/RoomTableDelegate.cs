using System;
using UIKit;
using System.Collections.Generic;
using Foundation;
using CoreGraphics;
namespace Mobius.iOS.Views
{
    public class RoomTableDelegate : UITableViewDelegate
    {
        UITableView table;
        CGSize viewSize;
        List<string> sections;
        public RoomTableDelegate(UITableView tableView, CGSize viewSize, List<string> sections)
        {
            this.table = tableView;
            this.viewSize = viewSize;
            this.sections = sections;
        }
        /*
        public override UIView GetViewForHeader(UITableView tableView, nint section)
        {
           var headerText = sections[(int)section];
            var headerHeight = 0;


            var headerView = new UIView(new CGRect(0, 0, tableView.Frame.Size.Width, headerHeight));
            if (headerText == "")
            {
                headerView.BackgroundColor = UIColor.Red;
            }
            else
            {
                headerView.BackgroundColor = UIColor.Green;
            }
            
            var headerLabel = new UILabel(new CGRect(5, 2, tableView.Frame.Size.Width - 5, 0));
            headerLabel.BackgroundColor = UIColor.Clear;
            headerLabel.TextColor = UIColor.Black;
            headerLabel.Font = UIFont.BoldSystemFontOfSize(16);

            headerLabel.Text = headerText;
            headerLabel.TextAlignment = UITextAlignment.Left;
            //headerLabel.Center.Y = headerView.Center.Y;
            headerView.AddSubview(headerLabel);

            return headerView;

        }
        */
    }
}
