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
    public interface IStudentRepository:IBaseRepository<Student>
    {
        
        NpgsqlDataReader StudentControl(string tcno);
        bool CreatePayment(Payment payment);
        bool DeleteStudent(string tcNo, int roomNo);
        DataSet GetPayments();
        

    }
}
