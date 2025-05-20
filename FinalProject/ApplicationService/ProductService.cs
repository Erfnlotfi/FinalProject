using ApplicationService.Dtos;
using Model;
using Model.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationService
{
    public class ProductService(FinalDbContext context)
    {
        private readonly FinalDbContext _context = context;
        public List<GetProductDto> GetAllProducts()
        {
            return _context.product
                .Select(p => new GetProductDto
                {
                    Id = p.Id,
                    ProductName = p.ProductName,
                    Price = p.Price,
                    Quantity = p.Quantity,
                })
                .ToList();
        }

        public GetProductDto GetProductById(int id)
        {
            var product = _context.product.Find(id);
            return product == null ? null : new GetProductDto
            {
                Id = product.Id,
                ProductName = product.ProductName,
                Price = product.Price,
                Quantity = product.Quantity
            };
        }

        public void AddProduct(PostProductDto dto)
        {
            var product = new Product
            {
                ProductName = dto.ProductName,
                Price = dto.Price,
                Quantity = dto.Quantity
            };
            _context.product.Add(product);
            _context.SaveChanges();
        }

        public void UpdateProduct(EditProductDto dto)
        {
            var product = _context.product.Find(dto.Id);
            if (product != null)
            {
                product.ProductName = dto.ProductName;
                product.Price = dto.Price;
                product.Quantity = dto.Quantity;
                _context.SaveChanges();
            }
        }

        public void DeleteProduct(DeleteProductDto dto)
        {
            var product = _context.product.Find(dto.Id);
            if (product != null)
            {
                _context.product.Remove(product);
                _context.SaveChanges();
            }
        }
    }
}

