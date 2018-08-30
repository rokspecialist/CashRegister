using Common.Entity;

namespace RegisterEngineV2.Facade
{
    public class CouponFacade
    {
        public CouponCollection GetCoupons()
        {
            CouponCollection collection = new CouponCollection();

            //  Build Mock Coupon Collection

            collection.Add(new BuyGetCoupon("C1", "1", 4, 1) { });
            collection.Add(new TotalDiscountCoupon("C2", 10f) { });

            return collection;
        }
    }
}
