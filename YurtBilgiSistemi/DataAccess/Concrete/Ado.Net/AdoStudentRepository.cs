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
    public class AdoStudentRepository : IStudentRepository
    {

        NpgsqlConnection connection = new NpgsqlConnection("Server=localhost; port=5432; Database=Dormitory; user ID = postgres; password=123");

        public bool Add(Student entity)
        {
            connection.Open();
            int[] ultilites = Converting(entity);
            NpgsqlCommand daroomtype = new NpgsqlCommand("select * from dormitory.roomtypes where name=@p5", connection);
            daroomtype.Parameters.AddWithValue("@p5", entity.RoomType);
            int dtroomtype = (int)daroomtype.ExecuteScalar();

            NpgsqlCommand roomcontrol = new NpgsqlCommand("select roomcontrol(@roomid,@roomtype)", connection);
            roomcontrol.Parameters.AddWithValue("@roomid", entity.RoomNo);
            roomcontrol.Parameters.AddWithValue("@roomtype", dtroomtype);
            int dtroomcontrol = (int)roomcontrol.ExecuteScalar();

            if (dtroomcontrol==1)
            {
                NpgsqlCommand cmd = new NpgsqlCommand("insert into student.students(tcno,name,lastname,birthdate,city,district,address,phonenumber" +
                    ",gender,persontype,departmen,registrationdate,contractenddate,room,breakfast,dinner,term,dormitory,remainingpayment,guardianname,guardianphone) values(@tcno, @name,@lastname,@birthdate," +
                    "@city,@district,@address,@phonenumber,@gender,@persontype,@departmen,@registrationdate,@contractenddate,@room,@breakfast,@dinner,@term,@dormitory,@payment,@guardianname,@guardianphone)", connection);
                cmd.Parameters.AddWithValue("@tcno", entity.TcNo);
                cmd.Parameters.AddWithValue("@name", entity.Name);
                cmd.Parameters.AddWithValue("@lastname", entity.LastName);
                cmd.Parameters.AddWithValue("@birthdate", entity.BirthDate);
                cmd.Parameters.AddWithValue("@city", ultilites[0]);
                cmd.Parameters.AddWithValue("@district", ultilites[1]);
                cmd.Parameters.AddWithValue("@address", entity.Address);
                cmd.Parameters.AddWithValue("@phonenumber", entity.Phone);
                cmd.Parameters.AddWithValue("@gender", entity.Gender);
                cmd.Parameters.AddWithValue("@persontype", "student");
                cmd.Parameters.AddWithValue("@departmen", ultilites[4]);
                cmd.Parameters.AddWithValue("@registrationdate", entity.RegistrationDate);
                cmd.Parameters.AddWithValue("@contractenddate", entity.ContractEndDate);
                cmd.Parameters.AddWithValue("@room", entity.RoomNo);
                cmd.Parameters.AddWithValue("@breakfast", entity.Breakfast);
                cmd.Parameters.AddWithValue("@dinner", entity.Dinner);
                cmd.Parameters.AddWithValue("@term", ultilites[3]);
                cmd.Parameters.AddWithValue("@dormitory", ultilites[2]);
                if (dtroomtype==1)
                {
                    cmd.Parameters.AddWithValue("@payment",20000);
                }
                else if (dtroomtype==2)
                {
                    cmd.Parameters.AddWithValue("@payment", 15000);
                }
                else if (dtroomtype==3)
                {
                    cmd.Parameters.AddWithValue("@payment", 10000);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@payment", 7000);
                }
                cmd.Parameters.AddWithValue("@guardianname", entity.GuardianName);
                cmd.Parameters.AddWithValue("@guardianphone", entity.GuardianPhone);
                cmd.ExecuteNonQuery();

                NpgsqlCommand increaseCapacity = new NpgsqlCommand("select increaseroomcapacity(@roomid,@roomtype)", connection);
                increaseCapacity.Parameters.AddWithValue("@roomid", entity.RoomNo);
                increaseCapacity.Parameters.AddWithValue("@roomtype", dtroomtype);
                increaseCapacity.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            else
            {
                return false;
            }

            
        }

      

        public int[] Converting(Student entity)
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


            NpgsqlCommand daTerm = new NpgsqlCommand("select * from term where termname=@p3", connection);
            daTerm.Parameters.AddWithValue("@p3", entity.Term);
            int dtterm = (int)daTerm.ExecuteScalar();

            NpgsqlCommand daDepartmen = new NpgsqlCommand("select * from student.departmen where name=@p4", connection);
            daDepartmen.Parameters.AddWithValue("@p4", entity.Departman);
            int dtdepartmen = (int)daDepartmen.ExecuteScalar();

            return new int[] { dtcity, dtdistrict, dtdormitory, dtterm, dtdepartmen };
        }


        public bool CreatePayment(Payment payment)
        {
            connection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("insert into student.studentpayments(paymentno,studentno,amountpaid,date) values(@paymentno,@studentno,@amountpaid,@date)", connection);
            cmd.Parameters.AddWithValue("@paymentno", payment.PaymentNo);
            cmd.Parameters.AddWithValue("@studentno", payment.StudentNo);
            cmd.Parameters.AddWithValue("@amountpaid", payment.AmountPaid);
            cmd.Parameters.AddWithValue("@date", DateTime.Now);
            cmd.ExecuteNonQuery();
            connection.Close();
            return true;
        }

        

        public bool DeleteStudent(string tcNo,int roomNo)
        {
            connection.Open();

            NpgsqlCommand cmd = new NpgsqlCommand("delete from student.students where tcno=@p1", connection);
            cmd.Parameters.AddWithValue("@p1", tcNo);
            cmd.ExecuteNonQuery();

            NpgsqlCommand decreaseCapacity = new NpgsqlCommand("select decreaseroomcapacity(@roomid)", connection);
            decreaseCapacity.Parameters.AddWithValue("@roomid", roomNo);
            decreaseCapacity.ExecuteNonQuery();

            connection.Close();
            return true;
        }

        

        public DataSet GetAll()
        {
            connection.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("Select * from studentinformation", connection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            connection.Close();
            return ds;
            
        }


        public DataSet GetPayments()
        {
            connection.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("Select recordNo,id,name,lastname,amountpaid,date from studentpaymentinformation", connection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            connection.Close();
            return ds;
        }

        public NpgsqlDataReader StudentControl(string tcno)
        {
            connection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("Select * from studentinformation where tcno=@tcno", connection);
            cmd.Parameters.AddWithValue("@tc", tcno);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }

        public bool Update(Student entity)
        {
            connection.Open();
            int[] ultilites = Converting(entity);
            NpgsqlCommand cmd = new NpgsqlCommand("update student.students set name=@name,lastname=@lastname,city=@city,district=@district," +
                "address=@address,phonenumber=@phonenumber" +
                    ",departmen=@departmen,registrationdate=@registrationdate,contractenddate=@contractenddate,breakfast=@breakfast,dinner=@dinner,term=@term where tcno=@tcno", connection);
            cmd.Parameters.AddWithValue("@tcno", entity.TcNo);
            cmd.Parameters.AddWithValue("@name", entity.Name);
            cmd.Parameters.AddWithValue("@lastname", entity.LastName);
            cmd.Parameters.AddWithValue("@city", ultilites[0]);
            cmd.Parameters.AddWithValue("@district", ultilites[1]);
            cmd.Parameters.AddWithValue("@address", entity.Address);
            cmd.Parameters.AddWithValue("@phonenumber", entity.Phone);
            cmd.Parameters.AddWithValue("@departmen", ultilites[4]);
            cmd.Parameters.AddWithValue("@registrationdate", entity.RegistrationDate);
            cmd.Parameters.AddWithValue("@contractenddate", entity.ContractEndDate);
            cmd.Parameters.AddWithValue("@breakfast", entity.Breakfast);
            cmd.Parameters.AddWithValue("@dinner", entity.Dinner);
            cmd.Parameters.AddWithValue("@term", ultilites[3]);
            cmd.ExecuteNonQuery();
            connection.Close();
            return true;
        }
    }
}
