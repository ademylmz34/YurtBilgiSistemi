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

namespace YurtBilgiSistemi.Forms.StaffForms
{
    public partial class ListStaff : Form
    {
        public ListStaff()
        {
            InitializeComponent();
            dataGridListStaff.DataSource = staffRepository.GetAll().Tables[0];
        }
        NpgsqlConnection connection = new NpgsqlConnection("Server=localHost; port=5432;Database=Dormitory;user Id = postgres; password=123");
        AdoStaffRepository staffRepository = new AdoStaffRepository();
        private void btnRemove_Click(object sender, EventArgs e)
        {
            connection.Open();
            
            if (staffRepository.Delete(txtTc.Text))
            {
                MessageBox.Show("silme işlemi başarılı");
                dataGridListStaff.DataSource = staffRepository.GetAll().Tables[0];
            }
            else
            {
                MessageBox.Show("hata");
            }
            connection.Close();
        }

        private void txtTc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
