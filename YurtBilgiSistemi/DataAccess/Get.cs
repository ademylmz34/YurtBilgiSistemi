using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YurtBilgiSistemi.DataAccess
{
    public class Get
    {
        NpgsqlConnection connection = new NpgsqlConnection("Server=localhost; port=5432; Database=Dormitory; user ID = postgres; password=123");
        NpgsqlCommand cmd;
        DataTable dt;
        public DataTable Cities()
        {
            connection.Open();
            cmd = new NpgsqlCommand("SELECT * FROM cities", connection);
            dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            connection.Close();
            return dt;
        }


        public  DataTable Districts(int cityNo)
        {
            connection.Open();
            cmd = new NpgsqlCommand("SELECT * FROM districts where cityno="+cityNo, connection);
            dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            connection.Close();
            return dt;
        }
        public  DataTable Dormitories()
        {
            connection.Open();
            cmd = new NpgsqlCommand("SELECT dormitoryname FROM dormitory.dormitories", connection);
            dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            connection.Close();
            return dt;
        }
        public  DataTable WorkOfUnits()
        {

            connection.Open();
            cmd = new NpgsqlCommand("SELECT name FROM dormitory.workofunits", connection);
            dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            connection.Close();
            return dt;
        }
        public  DataTable Departmens()
        {
            connection.Open();
            cmd = new NpgsqlCommand("SELECT name FROM student.departmen", connection);
            dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            connection.Close();
            return dt;
        }
        public  DataTable Rooms(int roomType,bool gender)
        {
            connection.Open();
            if (gender==true)
            {
                cmd = new NpgsqlCommand("SELECT roomid FROM dormitory.rooms where blockno=1 and roomtype=" + roomType, connection);
            }
            else
            {
                cmd = new NpgsqlCommand("SELECT roomid FROM dormitory.rooms where blockno=2 and roomtype=" + roomType, connection);

            }
            dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            connection.Close();
            return dt;
        }
        public  DataTable RoomTypes()
        {
            connection.Open();
            cmd = new NpgsqlCommand("SELECT * FROM dormitory.roomtypes", connection);
            dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            connection.Close();
            return dt;
        }
        public  DataTable Terms()
        {
            connection.Open();
            cmd = new NpgsqlCommand("SELECT * FROM term", connection);
            dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            connection.Close();
            return dt;
        }
    }
}
