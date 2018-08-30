using Common.Enumeration;

namespace Common.Entity
{
    public class SellableProduct : Product
    {
        public string Barcode { get; set; }
        public float PricePerUnit { get; set; }
        public UnitOfMeasurement UnitOfMeasurement { get; set; }
    }
}
