using System;
using UIKit;
using System.Collections.Generic;
using Foundation;
using CoreGraphics;
namespace Mobius.iOS.Views
{
    public class CheckoutTableSource: UITableViewSource
    {
        UITableView table;
        List<string> sections;
        public CheckoutTableSource(UITableView table, List<string> sections)
        {
            this.table = table;
            this.sections = sections;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var tableCell = new UITableViewCell();
            return tableCell;
        }
        public override nint RowsInSection(UITableView tableView, nint section)
        {
            return 1;
        }
        public override nint NumberOfSections(UITableView tableView)
        {
            return sections.Count;
        }
    }
}
