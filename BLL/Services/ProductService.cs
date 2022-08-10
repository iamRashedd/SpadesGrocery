using DAL;
using DAL.EF;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ProductService
    {
        public static bool Create(ProductModel item)
        {
            var data = new Product()
            {
                Product_ID = item.Product_ID,
                Name = item.Name,
                Quantity = item.Quantity,
                Price = item.Price,
                Rating = item.Rating,
                Vendor_ID = item.Vendor_ID,
                Description = item.Description
            };
            DataAccessFactory.GetProductDataAccess().Create(data);
            return true;
        }
        public static List<ProductModel> GetAll()
        {
            var data = DataAccessFactory.GetProductDataAccess().GetAll();
            var products = new List<ProductModel>();
            foreach(var item in data)
            {
                products.Add(new ProductModel()
                {
                    Product_ID = item.Product_ID,
                    Name = item.Name,
                    Quantity = item.Quantity,
                    Price = item.Price,
                    Rating = item.Rating,
                    Vendor_ID = item.Vendor_ID,
                    Description = item.Description
                });
            }
            return products;
        }
        public static ProductModel GetById(int id)
        {
            var data = DataAccessFactory.GetProductDataAccess().GetById(id);
            var product = new ProductModel()
            {
                Product_ID = data.Product_ID,
                Name = data.Name,
                Quantity = data.Quantity,
                Price = data.Price,
                Rating = data.Rating,
                Vendor_ID = data.Vendor_ID,
                Description = data.Description
            };
            return product;
        }
        public static bool Update(ProductModel p)
        {
            var data = new Product()
            {
                Product_ID = p.Product_ID,
                Name = p.Name,
                Quantity = p.Quantity,
                Price = p.Price,
                Rating = p.Rating,
                Vendor_ID = p.Vendor_ID,
                Description = p.Description
            };
            return DataAccessFactory.GetProductDataAccess().Update(data);
        }
        public static bool Delete(int id)
        {
            return DataAccessFactory.GetProductDataAccess().Delete(id);
        }

    }
}
