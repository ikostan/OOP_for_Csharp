using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL.OrderClassess
{
    public class OrderItem
    {
        private int _orderItemId;

        /// <summary>
        /// No args constructor
        /// </summary>
        public OrderItem()
        {

        }

        /// <summary>
        /// Allows to set an OrderItem id
        /// </summary>
        /// <param name="orderItemId"></param>
        public OrderItem(int orderItemId)
        {
            this._orderItemId = orderItemId;
        }
        public int OrderItemId { get { return _orderItemId; } }
        public int OrderQuantity { get; set; }
        public int ProductId { get; set; }
        public decimal? PurchasePrice { get; set; }

        /// <summary>
        /// Retrieve one order item.
        /// </summary>
        public OrderItem Retrieve(int orderItemId)
        {
            //TODO: Code that retrieves the defined order item
            return new OrderItem();
        }

        /// <summary>
        /// Saves the current order item.
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            //TODO: Code that saves the defined order item
            return true;
        }

        /// <summary>
        /// Validates the order item data.
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (OrderQuantity <= 0) isValid = false;
            if (ProductId <= 0) isValid = false;
            if (PurchasePrice == null) isValid = false;

            return isValid;
        }
    }
}
