using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YurtBilgiSistemi.Forms.Rooms
{
    public partial class TripleRooms : Form
    {
        public TripleRooms()
        {
            InitializeComponent();
        }

        NpgsqlConnection connection = new NpgsqlConnection("Server=localhost; port=5432; Database=Dormitory; user ID = postgres; password=123");
        private void TripleRooms_Load(object sender, EventArgs e)
        {
            connection.Open();
            NpgsqlDataAdapter cmd = new NpgsqlDataAdapter("Select tcno,name,lastname,gender,cityname,districtname,phonenumber,roomid,departmenname,breakfast,dinner from studentinformation where id = 3", connection);
            DataSet ds = new DataSet();
            cmd.Fill(ds);
            dataGridTripleRooms.DataSource = ds.Tables[0];
            connection.Close();
        }
    }
}
