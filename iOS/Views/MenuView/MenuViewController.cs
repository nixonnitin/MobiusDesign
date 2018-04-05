using System;

using UIKit;
using System.Collections.Generic;
using Foundation;
namespace Mobius.iOS.Views
{
    
    public partial class MenuViewController : UIViewController
    {
        List<string> labels;
        List<string> sections;
        List<string> images;
        public MenuViewController() : base("MenuViewController", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            initData();
            initUI();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        private void initData()
        {
            labels = new List<string> { "Label 1", "Label 2", "Label 3" };
            sections = new List<string> { "General", "About You", "Loyalty","Hotel Info", "Help", "Other" };
            images = new List<string> { "img1.png", "img2.png", "img3.png" };
        }

        private void initUI()
        {
            //var tableViewLovalty = new UITableView(View.Bounds, UITableViewStyle.Grouped);
            //tableViewLovalty.Source = new LovaltyDataSource(tableViewLovalty, labels, images);
            //tableViewLovalty.RowHeight = UITableView.AutomaticDimension;
            //tableViewLovalty.EstimatedRowHeight = 64;

            //View.AddSubview(tableViewLovalty);
            tblMenu.RowHeight = UITableView.AutomaticDimension;
            tblMenu.EstimatedRowHeight = 64;
            tblMenu.RegisterNibForCellReuse(UINib.FromName("MenuExistingUserCell1",NSBundle.MainBundle),"MenuExistingUserCell1");
            tblMenu.Source = new LovaltyDataSource(tblMenu, labels, images,sections);


        }
    }

    public class LovaltyDataSource : UITableViewSource
    {
        UITableView table;
        List<string> labels;
        List<string> sections;
        List<string> images;

        public LovaltyDataSource(UITableView table, List<string> labels, List<string> images,  List<string> sections)
        {
            this.table = table;
            this.labels = labels;
            this.sections = sections;
            this.images = images;

            //table.RegisterNibForCellReuse(UINib.FromName("MenuExistingUserCell1", NSBundle.MainBundle), MenuExistingUserCell1.Key);
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            
            var cell = (MenuExistingUserCell1)tableView.DequeueReusableCell(MenuExistingUserCell1.Key, indexPath);
            cell.SelectionStyle = UITableViewCellSelectionStyle.None;
            //cell.imgIcon.Image = UIImage.FromFile(images[indexPath.Row]);
            cell.lblName.Text = labels[indexPath.Row];

            return cell;
        }

        public override nint RowsInSection(UITableView tableView, nint section)
        {
            return labels.Count;
        }

		public override nint NumberOfSections(UITableView tableView)
		{
            return sections.Count;
		}

		public override string TitleForHeader(UITableView tableView, nint section)
		{
            var titleHeader = sections[(int)section];
            return titleHeader;//base.TitleForHeader(tableView, section);
		}
	}

    //public class LovaltyDelegate:UITableViewDelegate{
    //    public override 
    //}
}


