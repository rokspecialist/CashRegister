using Common.Entity;
using RegisterEngineV2.Facade;

namespace RegisterEngineV2
{
    public static class Cached
    {
        static Inventory _AvailableItems { get; set; }
        public static Inventory AvailableItems
        {
            get
            {
                if (_AvailableItems == null)
                {
                    InventoryFacade facade = new InventoryFacade();
                    _AvailableItems = facade.GetInventory();    
                }

                return _AvailableItems;
            }
        }

        static CouponCollection _AvailableCoupons { get; set; }
        public static CouponCollection AvailableCoupons
        {
            get
            {
                if (_AvailableCoupons == null)
                {
                    CouponFacade facade = new CouponFacade();
                    _AvailableCoupons = facade.GetCoupons();
                }

                return _AvailableCoupons;
            }
        }
    }
}
