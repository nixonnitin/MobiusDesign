using System;

using Foundation;
using Mobius.iOS.Helper;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class BreakLineViewCell : UITableViewCell
    {
    	
        public static readonly NSString Key = new NSString("BreakLineViewCell");
        public static readonly UINib Nib;

        static BreakLineViewCell()
        {
            Nib = UINib.FromName("BreakLineViewCell", NSBundle.MainBundle);
        }

        protected BreakLineViewCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
        public override void AwakeFromNib()
        {
            base.AwakeFromNib();

            segmentControlTab.Layer.BorderColor = MobiusHelper.GetColorLightGreen().CGColor;
            segmentControlTab.TintColor = MobiusHelper.GetColorLightGreen();
            segmentControlTab.Layer.MasksToBounds = true;
            UiViewBreakline.BackgroundColor = MobiusHelper.GetColorBorderGrey();

        }


        #region properties
        public UIKit.UISegmentedControl segmentControlTab{
            get { return SegmentControlTab; }
            set { SegmentControlTab = value; }
        }
        #endregion


    }
}
