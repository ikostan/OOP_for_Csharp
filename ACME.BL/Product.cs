﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACME.BL
{
    public class Product : EntityBase
    {
        /// <summary>
        /// No args constructor
        /// </summary>
        public Product()
        {

        }

        /// <summary>
        /// Constructor that allows to set a product id
        /// </summary>
        /// <param name="productId"></param>
        public Product(int productId)
        {
            this.ProductId = productId;
        }

        public Decimal? CurrentPrice { get; set; }
        public int ProductId { get; private set; }
        public string ProductDescription { get; set; }

        private string _productName;

        public string ProductName
        {
            get { return _productName; }
            set { _productName = value; }
        }


        /// <summary>
        /// Validates the product data.
        /// </summary>
        /// <returns></returns>
        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }
    }
}
