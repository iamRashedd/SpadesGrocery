using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface ISalesRepo<CLASS, ID, RT>
    {
        List<CLASS> GetAll();
        CLASS GetById(ID id);

        RT Create(CLASS obj);
        bool Update(CLASS obj);
        bool Delete(ID id);

    }
}
