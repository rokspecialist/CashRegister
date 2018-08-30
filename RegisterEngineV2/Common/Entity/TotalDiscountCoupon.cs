namespace Common.Entity
{
    public class TotalDiscountCoupon : Coupon
    {
        public float TotalPercentageDiscount { get; }

        public TotalDiscountCoupon(string barcode, float discountRate) 
            : base(barcode)
        {
            this.TotalPercentageDiscount = discountRate;
        }
    }
}
