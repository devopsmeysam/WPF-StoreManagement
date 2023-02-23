using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ProductDataAccess
    {
        public List<Product> Products { get; set; } = new List<Product>();

        public ProductDataAccess()
        {
            ReadProducts();
        }

        public void CreateProduct(Product product)
        {
            Products.Add(product);
        }

        private void ReadProducts()
        {
            Product product01 = new Product()
            {
                Id = 1,
                Name = "Interuniversalism",
                Producer = "Mohammad Ali Taheri",
                Price = 18,
                AvailableCount = 22
            };
            Product product02 = new Product()
            {
                Id= 2,
                Name = "It Snows In This House",
                Producer = "Hamed Esmaeilion",
                Price = 20,
                AvailableCount = 28
            };
            Products.Add(product01);
            Products.Add(product02);
        }

        public void UpdateProduct(Product product)
        {
            Product temp = Products.First(x =>  x.Id == product.Id);
            int index = Products.IndexOf(temp);
            Products[index] = product;
        }

        public void DeleteProduct(int id)
        {
            Product temp = Products.First(x => x.Id == id);
            Products.Remove(temp);
        }

        public int GetNextId()
        {
            int index = Products.Any() ? Products.Max(x => x.Id) + 1 : 1;
            
            return index;
        }
    }
}
