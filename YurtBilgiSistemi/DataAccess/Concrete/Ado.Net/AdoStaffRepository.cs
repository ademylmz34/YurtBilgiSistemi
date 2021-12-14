using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YurtBilgiSistemi.DataAccess.Abstract;
using YurtBilgiSistemi.Entity;

namespace YurtBilgiSistemi.DataAccess.Concrete.Ado.Net
{
    public class AdoStaffRepository : IStaffRepository
    {
        NpgsqlConnection connection = new NpgsqlConnection("Server=localhost; port=5432; Database=Dormitory; user ID = postgres; password=123");
        public bool Add(Staff entity)
        {
            connection.Open();
            int[] ultilites = Converting(entity);


            NpgsqlCommand cmd = new NpgsqlCommand("insert into staff.staff(tcno,name,lastname,birthdate,city,district,address,phonenumber" +
            ",gender,persontype,workingunit,startdateofwork,dormitory) values(@tcno, @name,@lastname,@birthdate," +
            "@city,@district,@address,@phonenumber,@gender,@persontype,@departmen,@startdate,@dormitory)", connection);
            cmd.Parameters.AddWithValue("@tcno", entity.TcNo);
            cmd.Parameters.AddWithValue("@name", entity.Name);
            cmd.Parameters.AddWithValue("@lastname", entity.LastName);
            cmd.Parameters.AddWithValue("@birthdate", entity.BirthDate);
            cmd.Parameters.AddWithValue("@city", ultilites[0]);
            cmd.Parameters.AddWithValue("@district", ultilites[1]);
            cmd.Parameters.AddWithValue("@address", entity.Address);
            cmd.Parameters.AddWithValue("@phonenumber", entity.Phone);
            cmd.Parameters.AddWithValue("@gender", entity.Gender);
            cmd.Parameters.AddWithValue("@persontype",entity.PersonType);
            cmd.Parameters.AddWithValue("@departmen", ultilites[3]);
            cmd.Parameters.AddWithValue("@startdate", entity.StartDateOfWork);
            cmd.Parameters.AddWithValue("@dormitory", ultilites[2]);
                
            cmd.ExecuteNonQuery();

            connection.Close();
            return true;
        }
            
        
        public int[] Converting(Staff entity)
        {
            
            NpgsqlCommand daCity = new NpgsqlCommand("select * from cities where cityname=@p", connection);
            daCity.Parameters.AddWithValue("@p", entity.City);
            int dtcity = (int)daCity.ExecuteScalar();

            NpgsqlCommand daDistrict = new NpgsqlCommand("select * from districts where districtname=@p1", connection);
            daDistrict.Parameters.AddWithValue("@p1", entity.District);
            int dtdistrict = (int)daDistrict.ExecuteScalar();

            NpgsqlCommand daDormitory = new NpgsqlCommand("select * from dormitory.dormitories where dormitoryname=@p2", connection);
            daDormitory.Parameters.AddWithValue("@p2", entity.Dormitory);
            int dtdormitory = (int)daDormitory.ExecuteScalar();

            NpgsqlCommand daDepartmen = new NpgsqlCommand("select * from dormitory.workofunits where name=@p4", connection);
            daDepartmen.Parameters.AddWithValue("@p4", entity.Departman);
            int dtdepartmen = (int)daDepartmen.ExecuteScalar();

            return new int[] { dtcity, dtdistrict, dtdormitory, dtdepartmen };
        }

        

        public bool CreateSalary(Salary salary)
        {
            connection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("insert into staff.staffsalaryinformation(salaryno,staffno,amountpaid,date) values(@salaryno,@staffno,@salaryamount,@date)", connection);
            cmd.Parameters.AddWithValue("@salaryno", salary.SalaryNo);
            cmd.Parameters.AddWithValue("@staffno", salary.StaffNo);
            cmd.Parameters.AddWithValue("@salaryamount",salary.SalaryAmount);
            cmd.Parameters.AddWithValue("@date", salary.Date);
            cmd.ExecuteNonQuery();
            connection.Close();
            return true;
        }

        public bool Delete(string tcNo)
        {
            connection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("delete from staff.staff where tcno=@p1", connection);
            cmd.Parameters.AddWithValue("@p1", tcNo);
            cmd.ExecuteNonQuery();
            connection.Close();
            return true;
        }

        public DataSet GetAll()
        {
            connection.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("Select * from staffinformation", connection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            connection.Close();
            return ds;
        }

        public DataSet GetSalaries()
        {
            connection.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("Select * from staffsalaries", connection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            connection.Close();
            return ds;
        }

        public bool Update(Staff entity)
        {
            connection.Open();
            int[] ultilites = Converting(entity);
            NpgsqlCommand cmd = new NpgsqlCommand("update staff.staff set name=@name,lastname=@lastname,city=@city,district=@district," +
                "address=@address,phonenumber=@phonenumber" +
                    ",workingunit=@departmen,dormitory=@dormitory,persontype=@persontype where tcno=@tcno", connection);
            cmd.Parameters.AddWithValue("@tcno", entity.TcNo);
            cmd.Parameters.AddWithValue("@name", entity.Name);
            cmd.Parameters.AddWithValue("@lastname", entity.LastName);
            cmd.Parameters.AddWithValue("@city", ultilites[0]);
            cmd.Parameters.AddWithValue("@district", ultilites[1]);
            cmd.Parameters.AddWithValue("@address", entity.Address);
            cmd.Parameters.AddWithValue("@phonenumber", entity.Phone);
            cmd.Parameters.AddWithValue("@departmen", ultilites[3]);
            cmd.Parameters.AddWithValue("@dormitory", ultilites[2]);
            cmd.Parameters.AddWithValue("@persontype", entity.PersonType);
            cmd.ExecuteNonQuery();
            connection.Close();
            return true;
        }
    }
}
