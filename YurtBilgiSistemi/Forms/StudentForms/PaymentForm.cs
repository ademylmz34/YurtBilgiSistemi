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
    public partial class PaymentForm : Form
    {
        public PaymentForm()
        {
            InitializeComponent();
        }
        NpgsqlConnection connection = new NpgsqlConnection("Server=localHost; port=5432;Database=Dormitory;user Id = postgres; password=123");
        AdoStudentRepository studentRepository = new AdoStudentRepository();
        private void txtTc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        
        private void btnPay_Click(object sender, EventArgs e)
        {
            connection.Open();
            NpgsqlCommand paymentcontrol = new NpgsqlCommand("select paymentcontrol(@studentno)", connection);
            paymentcontrol.Parameters.AddWithValue("@studentno", int.Parse(txtStudentNo.Text));
            int dtpaymentcontrol = (int)paymentcontrol.ExecuteScalar();
            connection.Close();

            if (dtpaymentcontrol==1)
            {
                MessageBox.Show("borcunuz yok");
                
            }
            else
            {
                Payment payment = new Payment()
                {
                    StudentNo = int.Parse(txtStudentNo.Text),
                    Name = txtNameLastName.Text,
                    TotalPaid = decimal.Parse(txtTotalPaid.Text),
                    RemainPaid = decimal.Parse(txtRemainn.Text),
                    AmountPaid = decimal.Parse(txtAmount.Text),
                    PaymentNo = paymentNo

                };
                if (studentRepository.CreatePayment(payment))
                {
                    
                    MessageBox.Show("başarılı");
                    dataGridListStudents.DataSource = studentRepository.GetPayments().Tables[0];
                    
                }
                else
                {
                    MessageBox.Show("Başarısız");
                }
            }
            

        }
        int paymentNo = 0;
        
        private void txtTc_TextChanged(object sender, EventArgs e)
        {
            
            connection.Open();
            NpgsqlCommand tccontrol = new NpgsqlCommand("select studentcontrol(@tc)", connection);
            tccontrol.Parameters.AddWithValue("@tc", txtTc.Text);
            int dttccontrol = (int)tccontrol.ExecuteScalar();

            if (dttccontrol == 1)
            {
                NpgsqlCommand cmd = new NpgsqlCommand("Select * from studentpaymentinformation where tcno=@tcno", connection);
                cmd.Parameters.AddWithValue("@tcno", txtTc.Text);
                NpgsqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtStudentNo.Text = reader.GetInt32(3).ToString();
                    txtNameLastName.Text = reader.GetString(4) + "" + reader.GetString(5);
                    txtTotalPaid.Text = reader.GetDecimal(8).ToString();
                    txtRemainn.Text = reader.GetDecimal(9).ToString();
                    paymentNo = reader.GetInt32(1);
                }
                
            }
            connection.Close();
            showControls();
            
        }
        private void showControls()
        {
            cmbType.Enabled = true;
            txtAmount.Enabled = true;
            btnPay.Enabled = true;
            dataGridListStudents.Enabled = true;
        }
        private void Payment_Load(object sender, EventArgs e)
        {
            dataGridListStudents.DataSource = studentRepository.GetPayments().Tables[0];
        }
    }
}
