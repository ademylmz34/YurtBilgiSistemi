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

namespace YurtBilgiSistemi.Forms
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
            NpgsqlConnection connection = new NpgsqlConnection("Server=localhost; port=5432; Database=Dormitory; user ID = postgres; password=123");
            NpgsqlCommand cmd;
            connection.Open();
            cmd = new NpgsqlCommand("select countemployees()", connection);
            int numberOfEmployees = (int)cmd.ExecuteScalar();

            cmd = new NpgsqlCommand("select countstudents()", connection);
            int numberOfStudents = (int)cmd.ExecuteScalar();

            cmd = new NpgsqlCommand("select numberofsinglerooms()", connection);
            int numberOfSingleRooms = (int)cmd.ExecuteScalar();

            cmd = new NpgsqlCommand("select numberofdoublerooms()", connection);
            int numberOfDoubleRooms = (int)cmd.ExecuteScalar();

            cmd = new NpgsqlCommand("select numberoftriplerooms()", connection);
            int numberOfTripleRooms = (int)cmd.ExecuteScalar();

            cmd = new NpgsqlCommand("select numberofquadrooms()", connection);
            int numberOfQuadRooms = (int)cmd.ExecuteScalar();

            cmd = new NpgsqlCommand("select numberoffullsinglerooms()", connection);
            int numberOfFullSingleRooms = (int)cmd.ExecuteScalar();

            cmd = new NpgsqlCommand("select numberoffulldoublerooms()", connection);
            int numberOfFullDoubleRooms = (int)cmd.ExecuteScalar();

            cmd = new NpgsqlCommand("select numberoffulltriplerooms()", connection);
            int numberOfFullTripleRooms = (int)cmd.ExecuteScalar();

            cmd = new NpgsqlCommand("select numberoffullquadrooms()", connection);
            int numberOfFullQuadRooms = (int)cmd.ExecuteScalar();

            lblEmployeeCount.Text = numberOfEmployees.ToString();
            lblStudentCount.Text = numberOfStudents.ToString();

            lblEmptySingleRooms.Text = (numberOfSingleRooms - numberOfFullSingleRooms).ToString();
            lblFullSingleRooms.Text = numberOfFullSingleRooms.ToString();

            lblEmptyDoubleRooms.Text = (numberOfDoubleRooms - numberOfFullDoubleRooms).ToString();
            lblFullDoubleRooms.Text = numberOfFullDoubleRooms.ToString();

            lblEmptyTripleRooms.Text = (numberOfTripleRooms - numberOfFullTripleRooms).ToString();
            lblFullTripleRooms.Text = numberOfFullTripleRooms.ToString();

            lblEmptyQuadRooms.Text = (numberOfQuadRooms - numberOfFullQuadRooms).ToString();
            lblFullQuadRooms.Text = numberOfFullQuadRooms.ToString();

            connection.Close();
        }
        
        private void FormHome_Load(object sender, EventArgs e)
        {
            
        }
    }
}
