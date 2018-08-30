using System;

namespace Common.Entity
{
    public class LineItem : SellableProduct
    {
        public float Quantity { get; set; }
        public float Total
        {
            get
            {
                return (float)Math.Round((double)(this.Quantity * this.PricePerUnit), 2);
            }
        }
    }
}
