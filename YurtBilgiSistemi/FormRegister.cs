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

namespace YurtBilgiSistemi
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }


        NpgsqlConnection connection = new NpgsqlConnection("Server=localhost; port=5432; Database=Dormitory; user ID = postgres; password=123");
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" && txtPassword.Text == "" && txtConfirmPassword.Text == "")
            {
                MessageBox.Show("UserName and Password fields are empty", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPassword.Text == txtConfirmPassword.Text)
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("insert into dormitory.users(username,password) values(@username,@password)", connection);
                cmd.Parameters.AddWithValue("@username", txtUsername.Text.ToString());
                cmd.Parameters.AddWithValue("@password", txtPassword.Text.ToString());
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Your Account has been Successfully Created", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtConfirmPassword.Text = "";
                txtUsername.Focus();
                connection.Open();
            }
            else
            {
                MessageBox.Show("Passwords does not match, Please Re-enter", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Text = "";
                txtConfirmPassword.Text = "";
                txtPassword.Focus();
            }
        }

        private void FormRegister_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtConfirmPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
                txtConfirmPassword.PasswordChar = '*';
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            txtUsername.Focus();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new FormLogin().Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
