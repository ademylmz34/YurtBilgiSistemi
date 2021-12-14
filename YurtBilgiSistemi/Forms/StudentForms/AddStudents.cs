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

namespace YurtBilgiSistemi.Forms
{
    public partial class AddStudents : Form
    {
        public AddStudents()
        {
            InitializeComponent();
        }
        Get getAll = new Get();
        private void AddStudents_Load(object sender, EventArgs e)
        {
            
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
        private void clear()
        {
            txtTc.Clear();
            txtName.Clear();
            txtLastname.Clear();
            dtpBirth.Value = DateTime.Now;
            rchAddress.Clear();
            txtPhone.Clear();
            dtpContactEndDate.Value = DateTime.Now;
            dtpRegistration.Value = DateTime.Now;
            txtGuardianName.Clear();
            txtGuardianPhone.Clear();
            txtTc.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            
          
                AdoStudentRepository studentRepository = new AdoStudentRepository();

                Student student = new Student()
                {
                    TcNo = txtTc.Text,
                    Name = txtName.Text,
                    LastName = txtLastname.Text,
                    BirthDate = dtpBirth.Value,
                    Gender = rdnMale.Checked ? rdnMale.Text : rdnFemale.Text,
                    City=cmbCity.Text,
                    District=cmbDistrict.Text,
                    Address=rchAddress.Text,
                    Phone=txtPhone.Text,
                    Dormitory=cmbDormitory.Text,
                    RoomType=cmbRoomType.Text,
                    RoomNo=int.Parse(cmbRoomNo.Text),
                    Term=cmbTerm.Text,
                    Departman=cmbDepartman.Text,
                    Breakfast = rdnBreakfastYes.Checked ? true : false,
                    Dinner = rdnDinnerYes.Checked ? true : false,
                    RegistrationDate=dtpRegistration.Value,
                    ContractEndDate=dtpContactEndDate.Value,
                    GuardianName=txtGuardianName.Text,
                    GuardianPhone=txtGuardianPhone.Text
                };
                
                if(studentRepository.Add(student))
                {
                    MessageBox.Show("başarılı");
                    clear();
                }
                else
                {
                    MessageBox.Show("eklemek istediğiniz oda kapasitesi dolu.");
                }
                

            
        }

        private void txtTc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void txtLastname_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void cmbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDistrict.DisplayMember = "districtname";
            cmbDistrict.ValueMember = "id";
            cmbDistrict.DataSource = getAll.Districts(cmbCity.SelectedIndex+1);
        }

        private void cmbRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbRoomNo.DisplayMember = "roomid";
            cmbRoomNo.ValueMember = "roomid";
            if (rdnMale.Checked==true)
            {
                cmbRoomNo.DataSource = getAll.Rooms((cmbRoomType.SelectedIndex+1), true);
            }
            else
            {
                cmbRoomNo.DataSource = getAll.Rooms((cmbRoomType.SelectedIndex+1), false);
            }
            


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
            cmbRoomNo.DataSource = getAll.Rooms((cmbRoomType.SelectedIndex +1), false);
        }
    }
}
