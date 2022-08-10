using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class DeliveryScheduleRepo : ISalesRepo<DeliverySchedule, int, DeliverySchedule>
    {
        SpadesGroceryEntities db;
        public DeliveryScheduleRepo(SpadesGroceryEntities db)
        {
            this.db = db;
        }
        public DeliverySchedule Create(DeliverySchedule obj)
        {
            var data = db.DeliverySchedules.Add(obj);
            db.SaveChanges();
            return data;
        }

        public bool Delete(int id)
        {
            db.DeliverySchedules.Remove(GetById(id));
            db.SaveChanges();
            return true;
        }

        public List<DeliverySchedule> GetAll()
        {
            return db.DeliverySchedules.ToList();
        }

        public DeliverySchedule GetById(int id)
        {
            return db.DeliverySchedules.SingleOrDefault(x => x.ID == id);
        }

        public bool Update(DeliverySchedule obj)
        {
            var old = db.DeliverySchedules.FirstOrDefault(x=>x.ID == obj.ID);
            if(old != null)
            {
                db.Entry(old).CurrentValues.SetValues(obj);
                db.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
