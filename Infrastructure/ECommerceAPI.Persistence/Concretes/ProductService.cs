using ECommerceAPI.Application.Abstractions;
using ECommerceAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Persistence.Concretes
{
    public class ProductService : IProductService
    {
        public List<Product> GetProducts()
        => new() 
        {
            new() {Id=Guid.NewGuid(),Name="Product-1" ,Price=100,Stock=10},
            new() {Id=Guid.NewGuid(),Name="Product-2" ,Price=200,Stock=150},
            new() {Id=Guid.NewGuid(),Name="Product-3" ,Price=50,Stock=200},
            new() {Id=Guid.NewGuid(),Name="Product-4" ,Price=125,Stock=45},
            new() {Id=Guid.NewGuid(),Name="Product-5" ,Price=80,Stock=30}
        };
    }
}
