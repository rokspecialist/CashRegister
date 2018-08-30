using Common.Enumeration;

namespace Common.Entity
{
    public class Coupon
    {
        public string Barcode { get; set; }

        public Coupon(string barcode)
        {
            this.Barcode = barcode;
        }
    }
}
