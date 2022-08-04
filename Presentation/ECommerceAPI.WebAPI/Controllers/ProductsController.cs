
using ECommerceAPI.Application.Repositories.ProductRepositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceAPI.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductReadRepository _productReadRepository;
        private readonly IProductWriteRepository _productWriteRepository;

        public ProductsController(IProductReadRepository productReadRepository, IProductWriteRepository productWriteRepository)
        {
            _productReadRepository = productReadRepository;
            _productWriteRepository = productWriteRepository;
        }
        [HttpGet]
        public async void Get()
        {
           await _productWriteRepository.AddRangeAsync(new()
            {
                new(){Id=Guid.NewGuid(),CreatedDate=DateTime.UtcNow,Name="Product1",Price=100,Stock=10},
                new(){Id=Guid.NewGuid(),CreatedDate=DateTime.UtcNow,Name="Product2",Price=200,Stock=20},
                new(){Id=Guid.NewGuid(),CreatedDate=DateTime.UtcNow,Name="Product3",Price=300,Stock=30}
            });
            var count= await _productWriteRepository.SaveAsync();
        }
    }
}
