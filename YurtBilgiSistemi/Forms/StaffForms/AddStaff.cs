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
    public partial class AddStaff : Form
    {
        public AddStaff()
        {
            InitializeComponent();
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

        private void txtLastname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        AdoStaffRepository staffRepository = new AdoStaffRepository();
        private void btnSave_Click(object sender, EventArgs e)
        {
            
            Staff staff = new Staff()
            {
                TcNo=txtTc.Text,
                Name=txtName.Text,
                LastName=txtLastname.Text,
                BirthDate=dtpBirth.Value,
                Gender = rdnMale.Checked ? rdnMale.Text : rdnFemale.Text,
                City=cmbCity.Text,
                District=cmbDistrict.Text,
                Address=rchAddress.Text,
                Phone=txtPhone.Text,
                Dormitory=cmbDormitory.Text,
                Departman=cmbDepartman.Text,
                StartDateOfWork=dtpStartDate.Value,
                PersonType=cmbpersontype.Text
            };
            if (staffRepository.Add(staff))
            {
                MessageBox.Show("başarılı");
            }
            else
            {
                MessageBox.Show("başarısız.");
            }
        }

        private void AddStaff_Load(object sender, EventArgs e)
        {
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

        Get getAll = new Get();
        private void cmbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDistrict.DisplayMember = "districtname";
            cmbDistrict.ValueMember = "id";
            cmbDistrict.DataSource = getAll.Districts(cmbCity.SelectedIndex + 1);
        }
    }
}
