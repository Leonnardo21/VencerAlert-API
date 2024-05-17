using Microsoft.AspNetCore.Mvc;
using VencerAlert.Domain.Abstractions;
using VencerAlert.Domain.Entities;

namespace VencerAlert.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductsController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public ActionResult GetAllProducts() {

            var products =  _productRepository.GetAllProducts();
            return Ok(products);
        }

        [HttpGet("{id:int}")]
        public ActionResult GetProductById(int id) { 
            var product = _productRepository.GetProductById(id);
            return Ok(product);
        }

        [HttpPost]
        public ActionResult AddProduct(Product product)
        {
            _productRepository.AddProduct(product);
            return Ok(product);
        }

        [HttpPut]
        public ActionResult EditProduct(Product product)
        {
            var productEdit = _productRepository.UpdateProduct(product);
            return Ok("Produto atualizado...");
        }

        [HttpDelete]
        public ActionResult DeleteProduct(int id)
        {
            _productRepository.DeleteProduct(id);
            return Ok("Produto removido...");
        }
    }
}
