﻿using System;

using UIKit;
using System.Collections.Generic;
using Foundation;
using Mobius.iOS.Helper;
namespace Mobius.iOS.Views
{
    public partial class CheckoutViewController : UIViewController
    {
        List<string> sections;
        public CheckoutViewController() : base("CheckoutViewController", null)
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
            sections = new List<string> { "", "Enter Your Details", "Offers", "Hotels Near You", "Popular Destinations","","", "",
                "Selected Offers:", "Your Up Coming Stay:", "Your Purchased Enhancements:", "Recommended Enhancements:", "Your Reservation:", "Your Reservation:" ,"","Select your welcome benefit:","","","","","","" };
        }

        private void initUI()
        {
            View.BackgroundColor = MobiusHelper.GetColorLightGrey();

            TableCheckout.BackgroundColor = MobiusHelper.GetColorLightGrey();

            TableCheckout.RowHeight = UITableView.AutomaticDimension;
            TableCheckout.EstimatedRowHeight = 100;
            TableCheckout.RegisterNibForCellReuse(UINib.FromName("HomeIntroductionCell", NSBundle.MainBundle), "HomeIntroductionCell");
            TableCheckout.RegisterNibForCellReuse(UINib.FromName("CheckoutBookingDetailCell", NSBundle.MainBundle), "CheckoutBookingDetailCell");
            TableCheckout.RegisterNibForCellReuse(UINib.FromName("CheckoutInputTextCell", NSBundle.MainBundle), "CheckoutInputTextCell");
            TableCheckout.RegisterNibForCellReuse(UINib.FromName("CheckoutSingleInputTextCell", NSBundle.MainBundle), "CheckoutSingleInputTextCell");
            TableCheckout.RegisterNibForCellReuse(UINib.FromName("CheckoutSignupInfoCell", NSBundle.MainBundle), "CheckoutSignupInfoCell");
            TableCheckout.RegisterNibForCellReuse(UINib.FromName("CheckoutPromocodeCell", NSBundle.MainBundle), "CheckoutPromocodeCell");
            //CheckoutTermsConditionsCell
            TableCheckout.RegisterNibForCellReuse(UINib.FromName("CheckoutTermsConditionsCell", NSBundle.MainBundle), "CheckoutTermsConditionsCell");
            TableCheckout.RegisterNibForCellReuse(UINib.FromName("CheckoutNextCell", NSBundle.MainBundle), "CheckoutNextCell");
            TableCheckout.RegisterNibForCellReuse(UINib.FromName("CheckoutPriceBreakdownCell", NSBundle.MainBundle), "CheckoutPriceBreakdownCell");
            TableCheckout.RegisterNibForCellReuse(UINib.FromName("CheckoutPaymentOptionButtons", NSBundle.MainBundle), "CheckoutPaymentOptionButtons");
            TableCheckout.RegisterNibForCellReuse(UINib.FromName("CheckoutScanCardButtonCell", NSBundle.MainBundle), "CheckoutScanCardButtonCell");
            TableCheckout.RegisterNibForCellReuse(UINib.FromName("CheckoutInputCardCell", NSBundle.MainBundle), "CheckoutInputCardCell");
            TableCheckout.RegisterNibForCellReuse(UINib.FromName("CheckoutCardExpireCell", NSBundle.MainBundle), "CheckoutCardExpireCell");
            TableCheckout.RegisterNibForCellReuse(UINib.FromName("CheckoutPostcodeCountryCell", NSBundle.MainBundle), "CheckoutPostcodeCountryCell");
            TableCheckout.RegisterNibForCellReuse(UINib.FromName("ImageVisaViewCell", NSBundle.MainBundle), "ImageVisaViewCell");

            TableCheckout.RegisterNibForCellReuse(UINib.FromName("PointsDataViewCell", NSBundle.MainBundle), "PointsDataViewCell");


            TableCheckout.Source = new CheckoutTableSource(TableCheckout, sections);
            //TableCheckout.Delegate = new CheckoutTableDelegate(TableCheckout, View.Frame.Size, sections);
        }
    }

    public class CheckoutTableSource : UITableViewSource
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
            //var tableCell = new UITableViewCell();
            //return tableCell;
            if (indexPath.Section == 0)
            {
                var cell = (HomeIntroductionCell)tableView.DequeueReusableCell(HomeIntroductionCell.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                cell.imageBackground.Image = UIImage.FromBundle("backgroundRed");
                cell.LabelTitle.TextAlignment = UITextAlignment.Left;
                cell.LabelText.TextAlignment = UITextAlignment.Left;
                cell.LabelText.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.";
                //cell.BackgroundColor = MobiusHelper.GetColorLightGrey();
                //cell.LabelText.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.";
                //MobiusHelper.GetRoundedCornerFromSideOfView(cell.ViewOfferDetailContainer, UIRectCorner.BottomLeft | UIRectCorner.BottomRight);
                return cell;
            }
            else if (indexPath.Section == 1)
            {
                var cell = (CheckoutBookingDetailCell)tableView.DequeueReusableCell(CheckoutBookingDetailCell.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                cell.BackgroundColor = MobiusHelper.GetColorLightGrey();
                //cell.LabelText.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.";
                //MobiusHelper.GetRoundedCornerFromSideOfView(cell.ViewOfferDetailContainer, UIRectCorner.BottomLeft | UIRectCorner.BottomRight);
                return cell;
            }
            else if (indexPath.Section == 2)
            {
                if (indexPath.Row == 0)
                {
                    var cell = (CheckoutInputTextCell)tableView.DequeueReusableCell(CheckoutInputTextCell.Key, indexPath);
                    cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                    //cell.LabelText.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.";
                    //MobiusHelper.GetRoundedCornerFromSideOfView(cell.ViewOfferDetailContainer, UIRectCorner.BottomLeft | UIRectCorner.BottomRight);
                    cell.imageInputView.Image = UIImage.FromBundle("personGrey");
                    cell.textInput.Placeholder = "First Name";
                    cell.textSubInput.Placeholder = "Last Name";
                    return cell;
                }
                else if (indexPath.Row == 1)
                {
                    var cell = (CheckoutSingleInputTextCell)tableView.DequeueReusableCell(CheckoutSingleInputTextCell.Key, indexPath);
                    cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                    //cell.LabelText.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.";
                    //MobiusHelper.GetRoundedCornerFromSideOfView(cell.ViewOfferDetailContainer, UIRectCorner.BottomLeft | UIRectCorner.BottomRight);
                    cell.imageInputView.Image = UIImage.FromBundle("emailGrey");
                    cell.textInput.Placeholder = "Email Address";
                    return cell;
                }
                else
                {
                    var cell = (CheckoutSingleInputTextCell)tableView.DequeueReusableCell(CheckoutSingleInputTextCell.Key, indexPath);
                    cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                    cell.imageInputView.Image = UIImage.FromBundle("phoneGrey");
                    cell.textInput.Placeholder = "Telephone Number";
                    return cell;
                }

            }
            else if (indexPath.Section == 3)
            {
                var cell = (CheckoutSignupInfoCell)tableView.DequeueReusableCell(CheckoutSignupInfoCell.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                //cell.BackgroundColor = MobiusHelper.GetColorLightGrey();
                //cell.LabelText.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.";
                //MobiusHelper.GetRoundedCornerFromSideOfView(cell.ViewOfferDetailContainer, UIRectCorner.BottomLeft | UIRectCorner.BottomRight);
                return cell;
            }
            else if (indexPath.Section == 4)
            {
                var cell = (CheckoutSingleInputTextCell)tableView.DequeueReusableCell(CheckoutSingleInputTextCell.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                //cell.LabelText.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.";
                //MobiusHelper.GetRoundedCornerFromSideOfView(cell.ViewOfferDetailContainer, UIRectCorner.BottomLeft | UIRectCorner.BottomRight);
                cell.imageInputView.Image = UIImage.FromBundle("lockGrey");
                cell.textInput.Placeholder = "Enter a Password";
                cell.textInput.SecureTextEntry = true;
                return cell;
            }
            else if (indexPath.Section == 5)
            {
                var cell = (CheckoutPromocodeCell)tableView.DequeueReusableCell(CheckoutPromocodeCell.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                return cell;
            }
            else if (indexPath.Section == 6)
            {
                var cell = (CheckoutTermsConditionsCell)tableView.DequeueReusableCell(CheckoutTermsConditionsCell.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                return cell;
            }
            else if (indexPath.Section == 7)
            {

                var cell = (CheckoutNextCell)tableView.DequeueReusableCell(CheckoutNextCell.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                //cell.ButtonNext.AddTarget(TestAction, UIControlEvent.TouchUpInside);
                return cell;
            }
            else if (indexPath.Section == 8)
            {
                if (indexPath.Row == 0)
                {
                    var cell = (CheckoutPriceBreakdownCell)tableView.DequeueReusableCell(CheckoutPriceBreakdownCell.Key, indexPath);
                    cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                    cell.viewSeperator.Hidden = true;
                    return cell;
                }
                else if (indexPath.Row == 1)
                {
                    var cell = (CheckoutPriceBreakdownCell)tableView.DequeueReusableCell(CheckoutPriceBreakdownCell.Key, indexPath);
                    cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                    cell.viewSeperator.Hidden = false;
                    cell.labelAmount.TextColor = MobiusHelper.GetColorGray();
                    cell.labelAmount.Font = MobiusHelper.GetFontRegularWithSize(14);
                    cell.labelDetail.TextColor = MobiusHelper.GetColorGray();
                    cell.labelDetail.Font = MobiusHelper.GetFontRegularWithSize(14);
                    cell.viewSeperator.BackgroundColor = MobiusHelper.GetColorBorderGrey();
                    return cell;

                }
                else
                {
                    var cell = (CheckoutPriceBreakdownCell)tableView.DequeueReusableCell(CheckoutPriceBreakdownCell.Key, indexPath);
                    cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                    cell.viewSeperator.Hidden = true;
                    cell.labelAmount.Font = MobiusHelper.GetFontBoldWithSize(16);
                    cell.labelDetail.Font = MobiusHelper.GetFontBoldWithSize(16);
                    return cell;
                }

            }
            else if (indexPath.Section == 9)
            {

                var cell = (CheckoutPaymentOptionButtons)tableView.DequeueReusableCell(CheckoutPaymentOptionButtons.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                //cell.ButtonNext.AddTarget(TestAction, UIControlEvent.TouchUpInside);
                return cell;
            }
            else if (indexPath.Section == 10)
            {

                var cell = (CheckoutScanCardButtonCell)tableView.DequeueReusableCell(CheckoutScanCardButtonCell.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                //cell.ButtonNext.AddTarget(TestAction, UIControlEvent.TouchUpInside);
                return cell;
            }
            else if (indexPath.Section == 11)
            {

                var cell = (CheckoutInputCardCell)tableView.DequeueReusableCell(CheckoutInputCardCell.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                //cell.ButtonNext.AddTarget(TestAction, UIControlEvent.TouchUpInside);
                return cell;
            }
            else if (indexPath.Section == 12)
            {
                var cell = (CheckoutCardExpireCell)tableView.DequeueReusableCell(CheckoutCardExpireCell.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                //cell.ButtonNext.AddTarget(TestAction, UIControlEvent.TouchUpInside);
                return cell;
            }
            else if (indexPath.Section == 13)
            {

                var cell = (ImageVisaViewCell)tableView.DequeueReusableCell(ImageVisaViewCell.Key, indexPath);
                // cell.SelectionStyle = UITableViewCellSelectionStyle.None;

                //cell.ButtonNext.AddTarget(TestAction, UIControlEvent.TouchUpInside);
                return cell;
            }else if (indexPath.Section == 14)
            {

                var cell = (PointsDataViewCell)tableView.DequeueReusableCell(PointsDataViewCell.Key, indexPath);
                // cell.SelectionStyle = UITableViewCellSelectionStyle.None;

                //cell.ButtonNext.AddTarget(TestAction, UIControlEvent.TouchUpInside);
                return cell;
            }
            else
            {

                var cell = (CheckoutPostcodeCountryCell)tableView.DequeueReusableCell(CheckoutPostcodeCountryCell.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                //cell.ButtonNext.AddTarget(TestAction, UIControlEvent.TouchUpInside);
                return cell;

            }

            //CheckoutTermsConditionsCell
        }

        public override nint RowsInSection(UITableView tableView, nint section)
        {
            if (section == 2 || section == 8)
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
            //return sections.Count;
            return 16;
        }

    }
}
