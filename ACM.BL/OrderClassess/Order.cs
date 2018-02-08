﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL.OrderClassess
{
    /// <summary>
    /// Holds information about an order
    /// </summary>
    public class Order
    {

        private int _orderId;

        /// <summary>
        /// No args constructor
        /// </summary>
        public Order()
        {

        }

        /// <summary>
        /// Holds customer Id
        /// </summary>
        public int CustomerId { get; set; }

        /// <summary>
        /// Holds related shipping address id
        /// </summary>
        public int ShippingAddressId { get; set; }

        /// <summary>
        /// Holds list of ordered items
        /// </summary>
        public IEnumerable<OrderItem> orderItems { get; set; }

        /// <summary>
        /// Allows to set an order id
        /// </summary>
        /// <param name="orderId"></param>
        public Order(int orderId)
        {
            this._orderId = orderId;
        }

        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get { return _orderId; } }

        /// <summary>
        /// Validates the order data.
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (OrderDate == null)
            {
                isValid = false;
            }

            return isValid;
        }
    }
}