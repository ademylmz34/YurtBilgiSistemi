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
using YurtBilgiSistemi.DataAccess;
using YurtBilgiSistemi.DataAccess.Concrete.Ado.Net;
using YurtBilgiSistemi.Entity;

namespace YurtBilgiSistemi.Forms.StaffForms
{
    public partial class UpdateStaff : Form
    {
        public UpdateStaff()
        {
            InitializeComponent();
        }
        NpgsqlConnection connection = new NpgsqlConnection("Server=localHost; port=5432;Database=Dormitory;user Id = postgres; password=123");
        AdoStaffRepository staffRepository = new AdoStaffRepository();
        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Staff staff = new Staff()
            {
                TcNo = txtTc.Text,
                Name = txtName.Text,
                LastName = txtLastname.Text,
                City = cmbCity.Text,
                District = cmbDistrict.Text,
                Address = rchAddress.Text,
                Phone = txtPhone.Text,
                Dormitory = cmbDormitory.Text,
                Departman = cmbDepartman.Text,
                PersonType=cmbpersontype.Text
                
            };
            if (staffRepository.Update(staff))
            {
                MessageBox.Show("güncelleme işlemi başarılı");
            }
            else
            {
                MessageBox.Show("güncelleme işlemi başarısız");
            }
        }

        private void txtTc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        Get getAll = new Get();
        private void UpdateStaff_Load(object sender, EventArgs e)
        {
            connection.Open();
            cmbCity.DisplayMember = "CityName";
            cmbCity.ValueMember = "Id";
            cmbCity.DataSource = getAll.Cities();

            cmbDormitory.DisplayMember = "dormitoryname";
            cmbDormitory.ValueMember = "dormitoryid";
            cmbDormitory.DataSource = getAll.Dormitories();

            cmbDepartman.DisplayMember = "name";
            cmbDepartman.ValueMember = "departmenid";
            cmbDepartman.DataSource = getAll.WorkOfUnits();
        }
        private void ShowControls()
        {
            txtName.Enabled = true;
            txtLastname.Enabled = true;
            cmbCity.Enabled = true;
            cmbDistrict.Enabled = true;
            rchAddress.Enabled = true;
            txtPhone.Enabled = true;
            cmbDepartman.Enabled = true;
            cmbDormitory.Enabled = true;
            cmbpersontype.Enabled = true;
            btnUpdate.Enabled = true;
            txtTc.Enabled = false;
        }
        
        private void txtTc_TextChanged(object sender, EventArgs e)
        {
            
            NpgsqlCommand tccontrol = new NpgsqlCommand("select staffcontrol(@tc)", connection);
            tccontrol.Parameters.AddWithValue("@tc", txtTc.Text);
            int dttccontrol = (int)tccontrol.ExecuteScalar();

            if (dttccontrol == 1)
            {
                ShowControls();
                NpgsqlCommand cmd = new NpgsqlCommand("Select * from staffinformation where tcno=@tcno", connection);
                cmd.Parameters.AddWithValue("@tcno", txtTc.Text);
                NpgsqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtName.Text = reader.GetString(1);
                    txtLastname.Text = reader.GetString(2);
                    dtpBirth.Value = reader.GetDateTime(3);
                    if (reader.GetString(4).Contains("Male"))
                    {
                        rdnMale.Checked = true;
                    }
                    else
                    {
                        rdnFemale.Checked = true;
                    }
                    cmbCity.Text = reader.GetString(5);
                    cmbDistrict.Text = reader.GetString(6);
                    rchAddress.Text = reader.GetString(7);
                    txtPhone.Text = reader.GetString(8);
                    cmbDormitory.Text = reader.GetString(9);
                    
                    cmbDepartman.Text = reader.GetString(10);
                    dtpStartDate.Value = reader.GetDateTime(11);
                    cmbpersontype.Text = reader.GetString(12);
                }

                connection.Close();
            }
            
        }

        private void cmbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDistrict.DisplayMember = "districtname";
            cmbDistrict.ValueMember = "id";
            cmbDistrict.DataSource = getAll.Districts(cmbCity.SelectedIndex + 1);
        }
    }
}
