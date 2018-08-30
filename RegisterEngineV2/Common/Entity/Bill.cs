using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Entity
{
    public class Bill : List<LineItem>
    {
        #region Properties

        public Guid BillID { get; }

        public float TotalLineItems
        {
            get
            {
                float sum = 0f;
                foreach (LineItem li in this)
                {
                    sum += li.Total;
                }

                return sum;
            }
        }

        public Coupon Coupon { get; set; }

        public float TotalCouponDiscountAmount
        {
            get
            {
                if(this.Coupon.GetType()==typeof(TotalDiscountCoupon))
                {
                    return (float) this.TotalLineItems * ((TotalDiscountCoupon)this.Coupon).TotalPercentageDiscount / 100;
                }
                else if(this.Coupon.GetType()==typeof(BuyGetCoupon))
                {
                    BuyGetCoupon cpn = (BuyGetCoupon)this.Coupon;
                    LineItem item = this.GetLineItemByBarcode(cpn.ItemBarcode);
                    int freeItemCount = cpn.GetFreeItemCount(item);

                    return (float)freeItemCount * item.PricePerUnit;
                }
                return 0;
            }
        }

        public float TotalWithCouponApplied
        {
            get
            {
                return TotalLineItems - TotalCouponDiscountAmount;
            }
        }

        public float TaxRate
        {
            get { return 0.08f; }
        }

        public float TaxAmount
        {
            get
            {
                return (float)Math.Round((double)(this.TotalWithCouponApplied * TaxRate), 2);
            }
        }

        public float TotalWithCouponAndTaxApplied
        {
            get
            {
                return (float)(this.TotalWithCouponApplied + this.TaxAmount);
            }
        }

        #endregion

        protected LineItem GetLineItemByBarcode(string itemBarcode)
        {
            return this.Where(i => i.Barcode.Equals(itemBarcode)).SingleOrDefault();
        }

        public void AddLineItem(LineItem item)
        {
            this.Add(item);
        }

        public string GetFormattedBill()
        {
            StringBuilder builder = new StringBuilder();

            foreach(LineItem item in this)
            {
                builder.Append(string.Format("{0}\t\t{1}\t{2}\t{3:c}\r\n", item.Name, item.Quantity, item.PricePerUnit, item.Total));
            }

            //builder.Append(string.Format("\r\nSub Total: \t\t\t{0:c}\r\n", this.TotalLineItems));
            builder.Append(string.Format("\r\nCoupon: \t\t\t{0:c}\r\n", this.TotalCouponDiscountAmount));
            builder.Append(string.Format("\r\nSub Total: \t\t\t{0:c}\r\n", this.TotalWithCouponApplied));
            builder.Append(string.Format("Tax:\t\t\t\t{0:c}\r\n", this.TaxAmount));

            builder.Append(string.Format("Grand Total:\t\t\t{0:c}", this.TotalWithCouponAndTaxApplied));


            return builder.ToString();
        }
    }
}
