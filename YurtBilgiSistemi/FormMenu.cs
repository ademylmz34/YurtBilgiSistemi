using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YurtBilgiSistemi.Forms;
using YurtBilgiSistemi.Forms.Rooms;
using YurtBilgiSistemi.Forms.StaffForms;
using YurtBilgiSistemi.Forms.StudentForms;

namespace YurtBilgiSistemi
{
    public partial class FormMenu : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public FormMenu()
        {
            InitializeComponent();
            customizeDesign();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelSideMenu.Controls.Add(leftBorderBtn);

            this.Text = string.Empty;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);

                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                panelTitleBar.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Current Child Form Icon


            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(116, 86, 174);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            panelTitleBar.BackColor = Color.FromArgb(116, 86, 174);
            lblTitleChildForm.Text = "Home";

        }
            //Events
            //Reset
            private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            
        }
        private void customizeDesign()
        {
            panelStudentSubMenu.Visible = false;
            panelStaffSubMenu.Visible = false;
            panelRoomSubMenu.Visible = false;

        }

        private void hideSubMenu()
        {
            if (panelStudentSubMenu.Visible == true)
                panelStudentSubMenu.Visible = false;
            if (panelStaffSubMenu.Visible == true)
                panelStaffSubMenu.Visible = false;
            if (panelRoomSubMenu.Visible == true)
                panelRoomSubMenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible==false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void iconbtnHome_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new FormHome());
            lblTitleChildForm.Text = iconbtnHome.Text;
        }

        private void iconbtnStudent_Click(object sender, EventArgs e)
        {
            showSubMenu(panelStudentSubMenu);
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new ListStudents());
            lblTitleChildForm.Text = iconbtnStudent.Text;
        }

        private void iconbtnStaff_Click(object sender, EventArgs e)
        {
            showSubMenu(panelStaffSubMenu);
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new ListStaff());
            lblTitleChildForm.Text = iconbtnStaff.Text;
        }

        private void iconbtnRooms_Click(object sender, EventArgs e)
        {
            showSubMenu(panelRoomSubMenu);
            ActivateButton(sender, RGBColors.color4);
            lblTitleChildForm.Text = iconbtnRooms.Text;
        }

        private void iconbtnLogout_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            ActivateButton(sender, RGBColors.color5);
            FormLogin login = new FormLogin();
            login.Show();
            this.Hide();
        }

        private void btnAddStudent_Click_1(object sender, EventArgs e)
        {
           
            OpenChildForm(new AddStudents());
        }

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            
            OpenChildForm(new UpdateStudents());
        }

        

        private void btnListStudent_Click(object sender, EventArgs e)
        {
           
            OpenChildForm(new ListStudents());

        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            
            OpenChildForm(new PaymentForm());
        }

       

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddStaff());
        }

        private void btnUpdateStaff_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UpdateStaff());
        }

        private void btnDeleteStaff_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnListStaff_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ListStaff());
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SalaryForm());
        }

        

        private void btnSingleRoom_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SingleRooms());

        }

        private void btnDoubleRoom_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DoubleRooms());
        }

        private void btnTripleRoom_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TripleRooms());
        }

        private void btnQuadRoom_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuadRooms());
        }

        private void btn_PictureBox_Click(object sender, EventArgs e)
        {
            
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Form3Menu_Load(object sender, EventArgs e)
        {
            OpenChildForm(new FormHome());
        }

        private void btnAddManager_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddStaff());
        }

        private void FormMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
        }
    }
}
