﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class ProductRepository
    {
        /// <summary>
        /// Retrieve one product.
        /// </summary>
        public Product Retrieve(int productId)
        {
            // TODO: Code that retrieves the defined product
            Product product = null;

            if (productId == 2)
            {
                product = new Product(productId)
                {
                    ProductName = "Product",
                    ProductDescription = "Description",
                    CurrentPrice = 15.95M
                };
            }
            else
            {
                product = new Product(productId);
            }

            return product;
        }

        /// <summary>
        /// Saves the current product.
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            // TODO: Code that saves the defined product
            return true;
        }
    }
}
