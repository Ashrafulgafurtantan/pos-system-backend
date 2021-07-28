using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using pos_system.Model;

namespace pos_system.Repository
{
    public class ProductRepository : DatabaseRepository
    {

        public bool IsFound(string pid)
        {
            foreach(var product in DatabaseContext.Products)
            {
                if (product.pid == pid)
                    return true;
            }

            return false;
        }
        public bool Add(Product product)
        {
            if (IsFound(product.pid))
                return false;

            DatabaseContext.Products.Add(product);
            DatabaseContext.SaveChanges();
            return true;
        }

        public bool Update(Product product)
        {
            DatabaseContext.Products.Update(product);
            DatabaseContext.SaveChanges();
            return true;
        }

        public bool Delete(Product product)
        {
            DatabaseContext.Products.Remove(product);
            DatabaseContext.SaveChanges();
            return true;
        }

        public Product Search(string pid)
        {
            foreach(var product in DatabaseContext.Products)
            {
                if (product.pid == pid)
                    return product;
            }
            return null;
        }

        public List<Product> GetAll()
        {
            return DatabaseContext.Products.ToList();
        }

    }
}
