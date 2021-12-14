
namespace YurtBilgiSistemi.Forms.StaffForms
{
    partial class SalaryForm
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
            this.btnPay = new System.Windows.Forms.Button();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNameLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStaffNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridListSalaries = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListSalaries)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPay
            // 
            this.btnPay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPay.Enabled = false;
            this.btnPay.FlatAppearance.BorderSize = 0;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Location = new System.Drawing.Point(27, 470);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(185, 34);
            this.btnPay.TabIndex = 163;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // txtSalary
            // 
            this.txtSalary.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSalary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtSalary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSalary.Enabled = false;
            this.txtSalary.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalary.Location = new System.Drawing.Point(27, 330);
            this.txtSalary.Margin = new System.Windows.Forms.Padding(4);
            this.txtSalary.Multiline = true;
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(230, 30);
            this.txtSalary.TabIndex = 156;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 295);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 17);
            this.label7.TabIndex = 155;
            this.label7.Text = "Salary Amount";
            // 
            // dtpDate
            // 
            this.dtpDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpDate.CalendarFont = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Enabled = false;
            this.dtpDate.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Location = new System.Drawing.Point(26, 415);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(142, 23);
            this.dtpDate.TabIndex = 154;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 382);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 153;
            this.label4.Text = "Date";
            // 
            // txtNameLastName
            // 
            this.txtNameLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNameLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtNameLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNameLastName.Enabled = false;
            this.txtNameLastName.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameLastName.Location = new System.Drawing.Point(27, 235);
            this.txtNameLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtNameLastName.Multiline = true;
            this.txtNameLastName.Name = "txtNameLastName";
            this.txtNameLastName.Size = new System.Drawing.Size(230, 30);
            this.txtNameLastName.TabIndex = 152;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 200);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 151;
            this.label1.Text = "Name - Last Name";
            // 
            // txtStaffNo
            // 
            this.txtStaffNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtStaffNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtStaffNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStaffNo.Enabled = false;
            this.txtStaffNo.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffNo.Location = new System.Drawing.Point(26, 146);
            this.txtStaffNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtStaffNo.Multiline = true;
            this.txtStaffNo.Name = "txtStaffNo";
            this.txtStaffNo.Size = new System.Drawing.Size(230, 30);
            this.txtStaffNo.TabIndex = 150;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 149;
            this.label3.Text = "Staff No";
            // 
            // txtTc
            // 
            this.txtTc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtTc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTc.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTc.Location = new System.Drawing.Point(26, 54);
            this.txtTc.Margin = new System.Windows.Forms.Padding(4);
            this.txtTc.MaxLength = 11;
            this.txtTc.Multiline = true;
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(230, 30);
            this.txtTc.TabIndex = 148;
            this.txtTc.TextChanged += new System.EventHandler(this.txtTc_TextChanged);
            this.txtTc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTc_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 147;
            this.label2.Text = "Tc No";
            // 
            // dataGridListSalaries
            // 
            this.dataGridListSalaries.BackgroundColor = System.Drawing.Color.White;
            this.dataGridListSalaries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridListSalaries.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.dataGridListSalaries.Location = new System.Drawing.Point(285, 54);
            this.dataGridListSalaries.Name = "dataGridListSalaries";
            this.dataGridListSalaries.Size = new System.Drawing.Size(757, 450);
            this.dataGridListSalaries.TabIndex = 164;
            // 
            // SalaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1068, 704);
            this.Controls.Add(this.dataGridListSalaries);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNameLastName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStaffNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTc);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1068, 704);
            this.Name = "SalaryForm";
            this.Text = "Salary";
            this.Load += new System.EventHandler(this.SalaryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListSalaries)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNameLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStaffNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridListSalaries;
    }
}