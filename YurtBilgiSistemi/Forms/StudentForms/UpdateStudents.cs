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

namespace YurtBilgiSistemi.Forms.StudentForms
{
    public partial class UpdateStudents : Form
    {
        public UpdateStudents()
        {
            InitializeComponent();
        }
        NpgsqlConnection connection = new NpgsqlConnection("Server=localHost; port=5432;Database=Dormitory;user Id = postgres; password=123");
        AdoStudentRepository adoStudentRepository = new AdoStudentRepository();
        private void txtLastname_KeyPress(object sender, KeyPressEventArgs e)
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
            Student student = new Student()
            {
                TcNo = txtTc.Text,
                Name = txtName.Text,
                LastName = txtLastname.Text,
                City = cmbCity.Text,
                District = cmbDistrict.Text,
                Address = rchAddress.Text,
                Phone = txtPhone.Text,
                Dormitory = cmbDormitory.Text,
                Term = cmbTerm.Text,
                Departman = cmbDepartman.Text,
                Breakfast = rdnBreakfastYes.Checked ? true : false,
                Dinner = rdnDinnerYes.Checked ? true : false,
                RegistrationDate = dtpRegistration.Value,
                ContractEndDate = dtpContactEndDate.Value
            };
            if (adoStudentRepository.Update(student))
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
        private void UpdateStudents_Load(object sender, EventArgs e)
        {
            connection.Open();
            cmbCity.DisplayMember = "CityName";
            cmbCity.ValueMember = "Id";
            cmbCity.DataSource = getAll.Cities();

            cmbRoomType.DisplayMember = "Name";
            cmbRoomType.ValueMember = "Id";
            cmbRoomType.DataSource = getAll.RoomTypes();

            cmbDormitory.DisplayMember = "dormitoryname";
            cmbDormitory.ValueMember = "dormitoryid";
            cmbDormitory.DataSource = getAll.Dormitories();

            cmbDepartman.DisplayMember = "name";
            cmbDepartman.ValueMember = "departmenid";
            cmbDepartman.DataSource = getAll.Departmens();

            cmbTerm.DisplayMember = "termname";
            cmbTerm.ValueMember = "id";
            cmbTerm.DataSource = getAll.Terms();

        }

        private void cmbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDistrict.DisplayMember = "districtname";
            cmbDistrict.ValueMember = "id";
            cmbDistrict.DataSource = getAll.Districts(cmbCity.SelectedIndex + 1);
        }

        private void cmbDormitory_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void rdnMale_CheckedChanged(object sender, EventArgs e)
        {
            cmbRoomNo.DisplayMember = "roomid";
            cmbRoomNo.ValueMember = "roomid";
            cmbRoomNo.DataSource = getAll.Rooms((cmbRoomType.SelectedIndex+1), true);
        }

        private void rdnFemale_CheckedChanged(object sender, EventArgs e)
        {
            cmbRoomNo.DisplayMember = "roomid";
            cmbRoomNo.ValueMember = "roomid";
            cmbRoomNo.DataSource = getAll.Rooms((cmbRoomType.SelectedIndex+1), false);
        }

        private void cmbRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbRoomNo.DisplayMember = "roomid";
            cmbRoomNo.ValueMember = "roomid";
            if (rdnMale.Checked == true)
            {
                cmbRoomNo.DataSource = getAll.Rooms((cmbRoomType.SelectedIndex+1), true);
            }
            else
            {
                cmbRoomNo.DataSource = getAll.Rooms((cmbRoomType.SelectedIndex+1) , false);
            }
        }

        private void ShowControls()
        {
            txtName.Enabled = true;
            txtLastname.Enabled = true;
            cmbCity.Enabled = true;
            cmbDistrict.Enabled = true;
            rchAddress.Enabled = true;
            txtPhone.Enabled = true;
            cmbTerm.Enabled = true;
            cmbDepartman.Enabled = true;
            dtpContactEndDate.Enabled = true;
            dtpRegistration.Enabled = true;
            btnUpdate.Enabled = true;
            txtTc.Enabled = false;
        }


        
        private void txtTc_TextChanged(object sender, EventArgs e)
        {
            
            NpgsqlCommand tccontrol = new NpgsqlCommand("select studentcontrol(@tc)", connection);
            tccontrol.Parameters.AddWithValue("@tc", txtTc.Text);
            int dttccontrol = (int)tccontrol.ExecuteScalar();
            
            if (dttccontrol==1)
            {
                ShowControls();
                NpgsqlCommand cmd = new NpgsqlCommand("Select * from studentinformation where tcno=@tcno", connection);
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
                    cmbDormitory.Text = reader.GetString(11);
                    cmbRoomType.Text = reader.GetString(12);
                    cmbRoomNo.Text = reader.GetInt32(13).ToString();
                    cmbTerm.Text = reader.GetString(14);
                    cmbDepartman.Text = reader.GetString(15);
                    if (reader.GetBoolean(16)==true)
                    {
                        rdnBreakfastYes.Checked = true;
                    }
                    else
                    {
                        rdnBreakfastNo.Checked = true;
                    }
                    if (reader.GetBoolean(17)==true)
                    {
                        rdnDinnerYes.Checked = true;
                    }
                    else
                    {
                        rdnDinnerNo.Checked = true;
                    }
                    dtpRegistration.Value = reader.GetDateTime(18);
                    dtpContactEndDate.Value = reader.GetDateTime(19);

                }
                connection.Close();
            }
            
            
        }
    }
}
