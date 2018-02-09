using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL.RepositoryClassess
{
    public class ProductRepository
    {
        /// <summary>
        /// Retrieve one product.
        /// </summary>
        public Product Retrieve(int productId)
        {
            // TODO: Code that retrieves the defined product

            // Code that retrieves the defined product
            Product product = new Product(productId);

            // Temporary hard coded values to return 
            // a populated product
            if (productId == 2)
            {
                product.ProductName = "Product";
                product.ProductDescription = "Description";
                product.CurrentPrice = 15.95M;
            }

            return product;
        }

        /// <summary>
        /// Saves the current product.
        /// </summary>
        /// <returns></returns>
        public bool Save(Product product)
        {
            
            var success = true;

            if (product.IsValid && product.HasChanges)
            {
                if (product.IsNew)
                {
                    // TODO: Code that saves the defined product
                }
                else
                {
                    // TODO: Code that updates the defined product
                }
            }          

            return success;
        }

        //End of Class
    }
}
