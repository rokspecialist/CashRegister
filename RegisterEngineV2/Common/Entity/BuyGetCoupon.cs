namespace Common.Entity
{
    public class BuyGetCoupon : Coupon
    {
        public string ItemBarcode { get; set; }
        public int BuyCount { get; set; }
        public int GetCount { get; set; }

        public BuyGetCoupon(string barcode, string itemBarcode, int buyCount, int getCount) 
            : base(barcode)
        {
            this.ItemBarcode = itemBarcode;
            this.BuyCount = buyCount;
            this.GetCount = getCount;
        }


        protected bool IsApplicable(LineItem item)
        {
            return item.Barcode == this.ItemBarcode &&
                        item.Quantity >= this.BuyCount + this.GetCount;
        }

        /// <summary>
        /// Returns number of free items
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public int GetFreeItemCount(LineItem item)
        {
            int freeItemCount = 0;

            if(this.IsApplicable(item))
            {
                int freeItemMultiplier = (int)item.Quantity / this.BuyCount;
                freeItemCount = freeItemMultiplier * this.GetCount;
            }

            return freeItemCount;
        }
    }
}
