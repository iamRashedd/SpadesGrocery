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
    public class OrderedProductsService
    {
        public static List<Ordered_ProductsModel> GetAll()
        {
            var data = DataAccessFactory.GetOrderedProductsDataAccess().GetAll();
            var orderedProducts = new List<Ordered_ProductsModel>();
            foreach(var item in data)
            {
                orderedProducts.Add(new Ordered_ProductsModel()
                {
                    Ordered_Products_ID = item.Ordered_Products_ID,
                    Product_ID = item.Product_ID,
                    Quantity = item.Quantity,
                    Subtotal = item.Subtotal
                });
            }
            return orderedProducts;
        }
        public static List<Ordered_ProductsModel> GetById(int id)
        {
            var data = DataAccessFactory.GetOrderedProductsDataAccess().GetAll();
            var data2 = data.Where(x => x.Ordered_Products_ID == id).ToList();
            var orderedProduct = new List<Ordered_ProductsModel>();
            foreach (var item in data2)
            {
                orderedProduct.Add(new Ordered_ProductsModel()
                {
                    Ordered_Products_ID = item.Ordered_Products_ID,
                    Product_ID = item.Product_ID,
                    Quantity = item.Quantity,
                    Subtotal = item.Subtotal
                });
            }
            return orderedProduct;
        }
    }
}
