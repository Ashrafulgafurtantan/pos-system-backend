using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using pos_system.Model;
using pos_system.Repository;

namespace pos_system.Controllers
{
    public class ProductController : Controller
    {
        private ProductRepository _productRepository = new ProductRepository();

        [HttpPost("api/admin/stock/add")]
        public IActionResult Add([FromBody] Product product)
        {
            var addedProduct = _productRepository.Add(product);
            return Ok(addedProduct);
        }

        [HttpGet("api/admin/stock/report")]
        public IActionResult getAllProduct()
        {
            
            var allProduct = _productRepository.GetAll();
            return Ok(allProduct);
        }

        [HttpPost("api/admin/stock/delete")]
        public IActionResult Delete([FromBody] Product product)
        {

            var deleted = _productRepository.Delete(product);
            return Ok(deleted);
        }

        [HttpPost("api/admin/stock/update")]
        public IActionResult Update([FromBody] Product product)
        {
            var updateProduct = _productRepository.Update(product);
            return Ok(updateProduct);
        }

        [HttpGet("api/product/search")]
        public IActionResult Search(string pid)
        {
            var product = _productRepository.Search(pid);
            return Ok(product);
        }
    }
}
