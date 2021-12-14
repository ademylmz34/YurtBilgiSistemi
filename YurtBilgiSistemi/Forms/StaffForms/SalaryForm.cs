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

namespace YurtBilgiSistemi.Forms.StaffForms
{
    public partial class SalaryForm : Form
    {
        public SalaryForm()
        {
            InitializeComponent();
        }
        NpgsqlConnection connection = new NpgsqlConnection("Server=localHost; port=5432;Database=Dormitory;user Id = postgres; password=123");
        AdoStaffRepository staffRepository = new AdoStaffRepository();
        private void txtTc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            connection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("Select id from dormitory.salaryinformation where staffno=@staffno", connection);
            cmd.Parameters.AddWithValue("@staffno",int.Parse(txtStaffNo.Text));
            int salaryno = (int)cmd.ExecuteScalar();
            
            Salary salary = new Salary()
            {
                StaffNo=int.Parse(txtStaffNo.Text),
                SalaryAmount=decimal.Parse(txtSalary.Text),
                Date=dtpDate.Value,
                SalaryNo=salaryno
            };
            if (staffRepository.CreateSalary(salary))
            {
                MessageBox.Show("başarıli");
                dataGridListSalaries.DataSource = staffRepository.GetSalaries().Tables[0];
             
                
            }
            else
            {
                MessageBox.Show("başarısız");
            }
            connection.Close();
        }
        
        private void txtTc_TextChanged(object sender, EventArgs e)
        {
            connection.Open();
            NpgsqlCommand tccontrol = new NpgsqlCommand("select staffcontrol(@tc)", connection);
            tccontrol.Parameters.AddWithValue("@tc", txtTc.Text);
            int dttccontrol = (int)tccontrol.ExecuteScalar();
            
            if (dttccontrol == 1)
            {
                ShowControls();
                NpgsqlCommand cmd = new NpgsqlCommand("Select id,name,lastname from staff.staff where tcno=@tcno", connection);
                cmd.Parameters.AddWithValue("@tcno", txtTc.Text);
                NpgsqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtStaffNo.Text = reader.GetInt32(0).ToString();
                    txtNameLastName.Text = reader.GetString(1) + " " + reader.GetString(2);
                }

                connection.Close();
            }
        }
        private void ShowControls()
        {
            txtSalary.Enabled = true;
            dtpDate.Enabled = true;
            btnPay.Enabled = true;
        }

        private void SalaryForm_Load(object sender, EventArgs e)
        {
            dataGridListSalaries.DataSource = staffRepository.GetSalaries().Tables[0];
        }
    }
}
