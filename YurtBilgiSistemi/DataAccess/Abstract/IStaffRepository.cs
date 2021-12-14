using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YurtBilgiSistemi.Entity;

namespace YurtBilgiSistemi.DataAccess.Abstract
{
    public interface IStaffRepository:IBaseRepository<Staff>
    {
        bool CreateSalary(Salary salary);
        bool Delete(string tcNo);
        DataSet GetSalaries();
    }
}
