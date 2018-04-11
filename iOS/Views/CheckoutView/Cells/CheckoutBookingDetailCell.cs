using System;

using Foundation;
using UIKit;
using Mobius.iOS.Helpers;
namespace Mobius.iOS.Views
{
    public partial class CheckoutBookingDetailCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("CheckoutBookingDetailCell");
        public static readonly UINib Nib;

        static CheckoutBookingDetailCell()
        {
            Nib = UINib.FromName("CheckoutBookingDetailCell", NSBundle.MainBundle);
        }

        protected CheckoutBookingDetailCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void AwakeFromNib()
        {
            base.AwakeFromNib();
            //UIViewHelper.SetShadow(ViewBookingDetailContainer, 50);

            ViewBookingDetailContainer.Layer.CornerRadius = 5;
            //MobiusHelper.GetRoundedCornerFromSideOfView(ViewBookingDetailContainer, UIRectCorner.AllCorners);
            UIViewHelper.SetShadow(ViewBookingDetailContainer, 5, 0.3f, 3f, 0.2f, 0.2f);
            //ViewOfferDetailContainer.Layer.CornerRadius = 5;
            MobiusHelper.GetRoundedCornerFromSideOfView(ViewOfferDetailContainer, UIRectCorner.BottomLeft|UIRectCorner.BottomRight,10,10);
            UIViewHelper.SetShadow(ViewOfferDetailContainer, 5, 0.3f, 3f, 0.2f, 0.2f);
            //MobiusHelper.GetRoundedCornerFromSideOfView(ViewOfferDetailContainer, );
            MobiusHelper.GetRoundedCornerFromSideOfView(ViewDetailContainer, UIRectCorner.BottomLeft | UIRectCorner.BottomRight);
            //ViewDetailContainer.Layer.CornerRadius = 5;

            MobiusHelper.GetRoundedCornerFromSideOfView(ImageHotel, UIRectCorner.TopRight);
            //ImageHotel.Layer.CornerRadius = 5;

            ViewOfferDetailContainer.BackgroundColor = MobiusHelper.GetColorMaroonRed();
            LabelOffer.Font = MobiusHelper.GetFontMediumWithSize(14f);

            LabelHotelName.Font = MobiusHelper.GetFontMediumWithSize(16f);
            LabelRoomDetail.Font = MobiusHelper.GetFontRegularWithSize(14f);

            LabelCheckin.Font = MobiusHelper.GetFontRegularWithSize(14f);
            LabelCheckinDetails.Font = MobiusHelper.GetFontMediumWithSize(16f);
            LabelCheckinDetails.TextColor = MobiusHelper.GetColorDarkGreen();

            LabelRooms.Font = MobiusHelper.GetFontRegularWithSize(14f);
            LabelRoomsDetails.Font = MobiusHelper.GetFontMediumWithSize(14f);
            LabelRoomsDetails.TextColor = MobiusHelper.GetColorDarkGreen();

            LabelGuests.Font = MobiusHelper.GetFontRegularWithSize(14f);
            LabelGuestsDetails.Font = MobiusHelper.GetFontMediumWithSize(14f);
            LabelGuestsDetails.TextColor = MobiusHelper.GetColorDarkGreen();

            LabelNights.Font = MobiusHelper.GetFontRegularWithSize(14f);
            LabelNightsDetails.Font = MobiusHelper.GetFontMediumWithSize(14f);
            LabelNightsDetails.TextColor = MobiusHelper.GetColorDarkGreen();


        }



    }


}
