using Model.DomainModels;
using Model.ServiceModels;
using Service.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class ProductService
    {
        private readonly ProductServiceModel _productServiceModel;
        public ProductService()
        {
            _productServiceModel = new ProductServiceModel();
        }
        public void Post(PostProductDto dto)
        {
            var Product = new Product()
            {
                ProductName = dto.ProductName,
                ProductId = dto.ProductId,
                ProductPrice = dto.ProductPrice,
            };
            _productServiceModel.Post(Product);
        }
        public List<Product> GetAll()
        {
            var Products = _productServiceModel.SelectAll();
            var getProductDto = new List<GetProductDto>();
            foreach (var item in Products)
            {
                var gpd = new GetProductDto()
                {
                    Id = item.Id,
                    ProductName = item.ProductName,
                    ProductPrice = item.ProductPrice,
                    ProductId = item.ProductId,
                };
                getProductDto.Add(gpd);
            }
            return Products;
        }
        public void Edit(EditProductDto editProductDto)
        {
            var product = new Product()
            {
                Id = editProductDto.Id,
                ProductName = editProductDto.ProductName,
                ProductId= editProductDto.ProductId,
                ProductPrice= editProductDto.ProductPrice,
            };
            _productServiceModel.Edit(product);
        }

        public void Delete(DeleteProductDto DeleteProductDto)
        {
            var product = new Product()
            {
                Id = DeleteProductDto.Id
            };
            _productServiceModel.Delete(product);
        }
    }
}
