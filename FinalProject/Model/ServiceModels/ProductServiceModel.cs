using Model.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ServiceModels
{
    public class ProductServiceModel
    {
        public void Post(Product product)
        {
            using (var Context = new FinalProjectDbContext())
            {
                try
                {
                    Context.Add(product);
                    Context.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    if (Context != null)
                        Context.Dispose();
                }
            }

        }

        public List<Product> SelectAll()
        {
            using (var Context = new FinalProjectDbContext())
            {
                try
                {
                    var Products = Context.Product.ToList();
                    return Products;
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    if (Context != null)
                        Context.Dispose();
                }
            }
        }

        public void Edit(Product product)
        {
            using (var context = new FinalProjectDbContext())
            {
                try
                {
                    var productFind = context.Product.Find(product.Id);
                    if (productFind != null)
                    {
                        productFind.Id = product.Id;
                        productFind.ProductName = product.ProductName;
                        productFind.ProductPrice = product.ProductPrice;
                        productFind.ProductId = product.ProductId;
                        context.SaveChanges();
                    }
                }
                catch (Exception e)
                {
                    throw new AggregateException("Error");
                }

            }


        }

        public void Delete(Product product)
        {
            using (var context = new FinalProjectDbContext())
            {
                try
                {
                    context.Product.Remove(product);
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    throw new AggregateException("Error");
                }
            }
        }
    }
}
