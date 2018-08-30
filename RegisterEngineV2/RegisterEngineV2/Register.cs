using Common.Entity;
using System;

namespace RegisterEngineV2
{
    public class Register : IRegister
    {
        Bill scannedBill = new Bill();

        public void Scan(string barcode, float quantity = 1)
        {
            LineItem item = Cached.AvailableItems.GetLineItemByBarcode(barcode);
            Coupon coupon = Cached.AvailableCoupons.GetCouponByBarcode(barcode);
            if (item == null)
            {
                if (coupon == null)
                    throw new Exception("Product not available for sale");
            }

            try
            {
                if (item != null)
                {
                    item.Quantity = quantity;
                    scannedBill.AddLineItem(item);
                }
                else if(coupon!=null)
                {
                    scannedBill.Coupon = coupon;
                }
            }
            catch(Exception ex)
            {
                //  Log Error

                throw new Exception("Product not added. Try again.");
            }
        }
        
        public string GetBill()
        {
            return scannedBill.GetFormattedBill();
        }
    }
}
