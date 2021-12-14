using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YurtBilgiSistemi.Entity;

namespace YurtBilgiSistemi.DataAccess.Abstract
{
    public interface IBaseRepository<T> where T:class
    {
        int[] Converting(T entity);
        DataSet GetAll();
        bool Add(T entity);
        bool Update(T entity);
    }
}
