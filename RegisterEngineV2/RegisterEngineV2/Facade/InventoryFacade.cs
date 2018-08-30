using Common.Entity;
using Common.Enumeration;

namespace RegisterEngineV2.Facade
{
    public class InventoryFacade
    {
        public Inventory GetInventory()
        {
            Inventory inv = new Inventory();

            //  Build Mock Inventory

            inv.Add(new LineItem() { Name = "Apple", Barcode = "1", PricePerUnit = 1.99f, UnitOfMeasurement = UnitOfMeasurement.Weight });
            inv.Add(new LineItem() { Name = "Cereal", Barcode = "2", PricePerUnit = 4.99f, UnitOfMeasurement = UnitOfMeasurement.Each });
            inv.Add(new LineItem() { Name = "Wine", Barcode = "3", PricePerUnit = 15.99f, UnitOfMeasurement = UnitOfMeasurement.Each });
            inv.Add(new LineItem() { Name = "Scallop", Barcode = "4", PricePerUnit = 19.99f, UnitOfMeasurement = UnitOfMeasurement.Weight });
            inv.Add(new LineItem() { Name = "Chips", Barcode = "5", PricePerUnit = 3.99f, UnitOfMeasurement = UnitOfMeasurement.Each });
            inv.Add(new LineItem() { Name = "Cup", Barcode = "6", PricePerUnit = 2.99f, UnitOfMeasurement = UnitOfMeasurement.Each });
            
            return inv;
        }
    }
}
