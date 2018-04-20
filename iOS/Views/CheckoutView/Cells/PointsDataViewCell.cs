using System;

using Foundation;
using Mobius.iOS.Helper;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class PointsDataViewCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("PointsDataViewCell");
        public static readonly UINib Nib;

        static PointsDataViewCell()
        {
            Nib = UINib.FromName("PointsDataViewCell", NSBundle.MainBundle);
        }

        protected PointsDataViewCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
		public override void AwakeFromNib()
		{
            base.AwakeFromNib();


            LabelPointsData.Text = "Current Points";
            LabelPointsData.Font = MobiusHelper.GetFontRegularWithSize(14);
            LabelPointsData.TextColor = UIColor.Black;
            LabelPointsData.TextAlignment = UITextAlignment.Left;


            LablePointsDataValue.TextAlignment = UITextAlignment.Right;
            LablePointsDataValue.Text = "1,925";
            LablePointsDataValue.Font = MobiusHelper.GetFontRegularWithSize(14);
            LablePointsDataValue.TextColor = UIColor.Green;

           //UIViewHelper.SetShadow(ViewMainPointsData, 5, 0.3f, 3f, 0.2f, 0.2f);


		}


	}
}
