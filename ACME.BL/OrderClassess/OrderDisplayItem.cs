using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACME.BL.OrderClassess
{
    /// <summary>
    /// Contains properties in order to display a specific item from a specific order
    /// </summary>
    public class OrderDisplayItem
    {
        public int OrderItemId { get; private set; }
        public int OrderQuantity { get; set; }
        public string ProductName { get; set; }
        public decimal? PurchasePrice { get; set; }
    }
}
