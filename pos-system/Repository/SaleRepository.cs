using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using pos_system.Model;

namespace pos_system.Repository
{
    public class SaleRepository :  DatabaseRepository
    {
        private ProductRepository _productRepository = new ProductRepository();

        public bool Add(Sale sale)
        {
            DatabaseContext.Sales.Add(sale);
            _productRepository.Delete(_productRepository.Search(sale.pid));
            DatabaseContext.SaveChanges();
            return true;
        }

        public Sale Search(string pid)
        {
            foreach (var product in DatabaseContext.Sales)
            {
                if (product.pid == pid)
                    return product;
            }
            return null;
        }

        public List<Sale> GetAll()
        {
            return DatabaseContext.Sales.ToList();
        }
    }
}
