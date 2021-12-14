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
using YurtBilgiSistemi.DataAccess.Concrete.Ado.Net;
using YurtBilgiSistemi.Entity;

namespace YurtBilgiSistemi.Forms.StudentForms
{
    public partial class ListStudents : Form
    {
        NpgsqlConnection connection = new NpgsqlConnection("Server=localHost; port=5432;Database=Dormitory;user Id = postgres; password=123");
        AdoStudentRepository studentRepository = new AdoStudentRepository();
        public ListStudents()
        {
            InitializeComponent();
            dataGridListStudents.DataSource = studentRepository.GetAll().Tables[0];
        }

        private void txtTc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        
       

        private void btnRemove_Click(object sender, EventArgs e)
        {
            connection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("Select * from student.students where tcno=@tcno", connection);
            cmd.Parameters.AddWithValue("@tcno", txtTc.Text);
            int roomNo=0;
            NpgsqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                roomNo = reader.GetInt32(14);

            }
            connection.Close();
            if (studentRepository.DeleteStudent(txtTc.Text,roomNo))
            {
                MessageBox.Show("silme işlemi başarılı");
                dataGridListStudents.DataSource = studentRepository.GetAll().Tables[0];
                txtTc.Clear();
            }
            else
            {
                MessageBox.Show("hata");
            }
        }

        private void ListStudents_Load(object sender, EventArgs e)
        {

        }
    }
}
