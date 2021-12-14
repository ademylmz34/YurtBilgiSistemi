
namespace YurtBilgiSistemi.Forms.StaffForms
{
    partial class AddStaff
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSave = new System.Windows.Forms.Button();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbDormitory = new System.Windows.Forms.ComboBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rchAddress = new System.Windows.Forms.RichTextBox();
            this.cmbDistrict = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpBirth = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDepartman = new System.Windows.Forms.ComboBox();
            this.rdnFemale = new System.Windows.Forms.RadioButton();
            this.rdnMale = new System.Windows.Forms.RadioButton();
            this.cmbpersontype = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(334, 624);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(230, 38);
            this.btnSave.TabIndex = 127;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpStartDate.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Location = new System.Drawing.Point(334, 506);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(175, 23);
            this.dtpStartDate.TabIndex = 126;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(331, 469);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(126, 17);
            this.label16.TabIndex = 125;
            this.label16.Text = "Start Date Of Work";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(30, 378);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 17);
            this.label14.TabIndex = 120;
            this.label14.Text = "Gender";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(330, 391);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 17);
            this.label11.TabIndex = 112;
            this.label11.Text = "Departman";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(330, 303);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 17);
            this.label9.TabIndex = 109;
            this.label9.Text = "Which Dormitory?";
            // 
            // cmbDormitory
            // 
            this.cmbDormitory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbDormitory.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDormitory.FormattingEnabled = true;
            this.cmbDormitory.Location = new System.Drawing.Point(331, 335);
            this.cmbDormitory.Name = "cmbDormitory";
            this.cmbDormitory.Size = new System.Drawing.Size(230, 24);
            this.cmbDormitory.TabIndex = 108;
            this.cmbDormitory.Text = "Select...";
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhone.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(331, 239);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhone.MaxLength = 11;
            this.txtPhone.Multiline = true;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(230, 30);
            this.txtPhone.TabIndex = 107;
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(328, 206);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 17);
            this.label8.TabIndex = 106;
            this.label8.Text = "Phone Number";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(328, 27);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 17);
            this.label7.TabIndex = 105;
            this.label7.Text = "Address";
            // 
            // rchAddress
            // 
            this.rchAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rchAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.rchAddress.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rchAddress.Location = new System.Drawing.Point(329, 58);
            this.rchAddress.Name = "rchAddress";
            this.rchAddress.Size = new System.Drawing.Size(293, 112);
            this.rchAddress.TabIndex = 104;
            this.rchAddress.Text = "";
            // 
            // cmbDistrict
            // 
            this.cmbDistrict.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbDistrict.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDistrict.FormattingEnabled = true;
            this.cmbDistrict.Location = new System.Drawing.Point(30, 552);
            this.cmbDistrict.Name = "cmbDistrict";
            this.cmbDistrict.Size = new System.Drawing.Size(145, 24);
            this.cmbDistrict.TabIndex = 103;
            this.cmbDistrict.Text = "Select...";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 523);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 102;
            this.label6.Text = "District";
            // 
            // cmbCity
            // 
            this.cmbCity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbCity.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Location = new System.Drawing.Point(31, 478);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(144, 24);
            this.cmbCity.TabIndex = 101;
            this.cmbCity.Text = "Select...";
            this.cmbCity.SelectedIndexChanged += new System.EventHandler(this.cmbCity_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 449);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 17);
            this.label5.TabIndex = 100;
            this.label5.Text = "City";
            // 
            // dtpBirth
            // 
            this.dtpBirth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpBirth.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirth.Location = new System.Drawing.Point(33, 331);
            this.dtpBirth.Name = "dtpBirth";
            this.dtpBirth.Size = new System.Drawing.Size(170, 23);
            this.dtpBirth.TabIndex = 99;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 298);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 98;
            this.label4.Text = "Birth Date";
            // 
            // txtLastname
            // 
            this.txtLastname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLastname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtLastname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastname.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastname.Location = new System.Drawing.Point(33, 241);
            this.txtLastname.Margin = new System.Windows.Forms.Padding(4);
            this.txtLastname.Multiline = true;
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(230, 30);
            this.txtLastname.TabIndex = 97;
            this.txtLastname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLastname_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 206);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 96;
            this.label1.Text = "Last Name";
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(32, 152);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(230, 30);
            this.txtName.TabIndex = 95;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 94;
            this.label3.Text = "Name";
            // 
            // txtTc
            // 
            this.txtTc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtTc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTc.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTc.Location = new System.Drawing.Point(32, 60);
            this.txtTc.Margin = new System.Windows.Forms.Padding(4);
            this.txtTc.MaxLength = 11;
            this.txtTc.Multiline = true;
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(230, 30);
            this.txtTc.TabIndex = 93;
            this.txtTc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTc_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 92;
            this.label2.Text = "Tc No";
            // 
            // cmbDepartman
            // 
            this.cmbDepartman.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbDepartman.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDepartman.FormattingEnabled = true;
            this.cmbDepartman.Location = new System.Drawing.Point(334, 422);
            this.cmbDepartman.Name = "cmbDepartman";
            this.cmbDepartman.Size = new System.Drawing.Size(228, 24);
            this.cmbDepartman.TabIndex = 130;
            this.cmbDepartman.Text = "Select...";
            // 
            // rdnFemale
            // 
            this.rdnFemale.AutoSize = true;
            this.rdnFemale.Checked = true;
            this.rdnFemale.Location = new System.Drawing.Point(105, 412);
            this.rdnFemale.Name = "rdnFemale";
            this.rdnFemale.Size = new System.Drawing.Size(70, 21);
            this.rdnFemale.TabIndex = 134;
            this.rdnFemale.TabStop = true;
            this.rdnFemale.Text = "Female";
            this.rdnFemale.UseVisualStyleBackColor = true;
            // 
            // rdnMale
            // 
            this.rdnMale.AutoSize = true;
            this.rdnMale.Location = new System.Drawing.Point(32, 412);
            this.rdnMale.Name = "rdnMale";
            this.rdnMale.Size = new System.Drawing.Size(56, 21);
            this.rdnMale.TabIndex = 133;
            this.rdnMale.TabStop = true;
            this.rdnMale.Text = "Male";
            this.rdnMale.UseVisualStyleBackColor = true;
            // 
            // cmbpersontype
            // 
            this.cmbpersontype.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbpersontype.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbpersontype.FormattingEnabled = true;
            this.cmbpersontype.Items.AddRange(new object[] {
            "Staff",
            "Manager"});
            this.cmbpersontype.Location = new System.Drawing.Point(333, 581);
            this.cmbpersontype.Name = "cmbpersontype";
            this.cmbpersontype.Size = new System.Drawing.Size(145, 24);
            this.cmbpersontype.TabIndex = 136;
            this.cmbpersontype.Text = "Staff";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(330, 552);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 17);
            this.label10.TabIndex = 135;
            this.label10.Text = "Person Type";
            // 
            // AddStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1068, 704);
            this.Controls.Add(this.cmbpersontype);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.rdnFemale);
            this.Controls.Add(this.rdnMale);
            this.Controls.Add(this.cmbDepartman);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbDormitory);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rchAddress);
            this.Controls.Add(this.cmbDistrict);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbCity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpBirth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTc);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1068, 704);
            this.Name = "AddStaff";
            this.Text = "AddStaff";
            this.Load += new System.EventHandler(this.AddStaff_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbDormitory;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox rchAddress;
        private System.Windows.Forms.ComboBox cmbDistrict;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpBirth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDepartman;
        private System.Windows.Forms.RadioButton rdnFemale;
        private System.Windows.Forms.RadioButton rdnMale;
        private System.Windows.Forms.ComboBox cmbpersontype;
        private System.Windows.Forms.Label label10;
    }
}