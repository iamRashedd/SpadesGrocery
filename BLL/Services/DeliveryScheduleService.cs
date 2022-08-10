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
    public class DeliveryScheduleService
    {
        public static bool Create(DeliveryModel d)
        {
            var data = new DeliverySchedule()
            {
                ID = d.ID,
                Order_ID = d.Order_ID,
                DeliveryMan_ID = d.DeliveryMan_ID,
                PurchaseDate = d.PurchaseDate,
                DeliveryDate = d.DeliveryDate,
                Address = d.Address,
                Status = d.Status
            };

            DataAccessFactory.GetDeliveryScheduleDataAccess().Create(data);
            return true;
        }
        public static List<DeliveryModel> GetAll()
        {
            var data = DataAccessFactory.GetDeliveryScheduleDataAccess().GetAll();
            var deliveries = new List<DeliveryModel>();
            foreach (var d in data)
            {
                deliveries.Add(new DeliveryModel()
                {
                    ID = d.ID,
                    Order_ID = d.Order_ID,
                    DeliveryMan_ID = d.DeliveryMan_ID,
                    PurchaseDate = d.PurchaseDate,
                    DeliveryDate = d.DeliveryDate,
                    Address = d.Address,
                    Status = d.Status
                });
            }
            return deliveries;
        }
        public static DeliveryModel GetById(int id)
        {
            var data = DataAccessFactory.GetDeliveryScheduleDataAccess().GetById(id);
            var delivery = new DeliveryModel()
            {
                ID = data.ID,
                DeliveryMan_ID = data.DeliveryMan_ID,
                Order_ID = data.Order_ID,
                PurchaseDate = data.PurchaseDate,
                DeliveryDate = data.DeliveryDate,
                Address = data.Address,
                Status = data.Status
            };
            return delivery;
        }
        public static bool Update(DeliveryModel d)
        {
            var data = new DeliverySchedule()
            {
                ID = d.ID,
                Order_ID = d.Order_ID,
                DeliveryMan_ID = d.DeliveryMan_ID,
                PurchaseDate = d.PurchaseDate,
                DeliveryDate = d.DeliveryDate,
                Address = d.Address,
                Status = d.Status
            };
            return DataAccessFactory.GetDeliveryScheduleDataAccess().Update(data);
        }
        public static bool Delete(int id)
        {
            return DataAccessFactory.GetDeliveryScheduleDataAccess().Delete(id);
        }
    }
}
