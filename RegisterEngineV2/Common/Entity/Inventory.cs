using System.Collections.Generic;
using System.Linq;

namespace Common.Entity
{
    public class Inventory : List<LineItem>
    {
        public LineItem GetLineItemByBarcode(string barcode)
        {
            return this.Where(i => i.Barcode.Equals(barcode)).SingleOrDefault();
        }
    }
}
