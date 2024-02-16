using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_Api.Repositories.ProductRepository;

namespace RealEstate_Dapper_Api.Controllers
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
        public async Task<IActionResult> ProductList()
        {
            var values = await _productRepository.GetAllProductAsync();
            return Ok(values);
        }

        [HttpGet("ProductListWithCategory")]
        public async Task<IActionResult> ProductListWithCategory()
        {
            var values = await _productRepository.GetAllProductWithCategoryAsync();
            return Ok(values);
        }
        [HttpGet("ProductDealOfTheDayStatusChangeToTrue/{id}")]
        public async Task<IActionResult> ProductDealOfTheDayStatusChangeToTrue(int id)
        {
            _productRepository.ProductDealOfTheDayStatusChangeToTrue(id);
            return Ok("İlan Günün Fırsatları Arasına Eklendi");
        }

        [HttpGet("ProductDealOfTheDayStatusChangeToFalse/{id}")]
        public async Task<IActionResult> ProductDealOfTheDayStatusChangeToFalse(int id)
        {
            _productRepository.ProductDealOfTheDayStatusChangeToFalse(id);
            return Ok("İlan Günün Fırsatları Arasından Çıkarıldı");
        }

        //[HttpPost]
        //public async Task<IActionResult> CreateProduct(CreateProductDto createProductDto)
        //{
        //    _productRepository.CreateProduct(createProductDto);
        //    return Ok("Product Kısmı Başarılı Bir Şekilde Eklendi");
        //}
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteProduct(int id)
        //{
        //    _productRepository.DeleteProduct(id);
        //    return Ok("Product Kısmı Başarılı Bir Şekilde Silindi");
        //}
        //[HttpPut]
        //public async Task<IActionResult> UpdateProduct(UpdateProductDto updateProductDto)
        //{
        //    _productRepository.UpdateProduct(updateProductDto);
        //    return Ok("Product Kısmı Başarıyla Güncellendi");
        //}
        //[HttpGet("{id}")]
        //public async Task<IActionResult> GetProduct(int id)
        //{
        //    var value = await _productRepository.GetProduct(id);
        //    return Ok(value);
        //}


    }
}
