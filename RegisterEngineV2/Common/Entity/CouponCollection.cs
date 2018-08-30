using System.Collections.Generic;
using System.Linq;

namespace Common.Entity
{
    public class CouponCollection : List<Coupon>
    {
        public Coupon GetCouponByBarcode(string barcode)
        {
            return this.Where(c => c.Barcode.Equals(barcode)).SingleOrDefault();
        }
    }
}
