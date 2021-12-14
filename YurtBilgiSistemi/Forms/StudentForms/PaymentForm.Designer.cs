
namespace YurtBilgiSistemi.Forms.StudentForms
{
    partial class PaymentForm
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
            this.txtNameLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStudentNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotalPaid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRemainn = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.dataGridListStudents = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNameLastName
            // 
            this.txtNameLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNameLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtNameLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNameLastName.Enabled = false;
            this.txtNameLastName.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameLastName.Location = new System.Drawing.Point(30, 244);
            this.txtNameLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtNameLastName.Multiline = true;
            this.txtNameLastName.Name = "txtNameLastName";
            this.txtNameLastName.Size = new System.Drawing.Size(230, 30);
            this.txtNameLastName.TabIndex = 128;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 209);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 127;
            this.label1.Text = "Name - Last Name";
            // 
            // txtStudentNo
            // 
            this.txtStudentNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtStudentNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtStudentNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStudentNo.Enabled = false;
            this.txtStudentNo.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentNo.Location = new System.Drawing.Point(29, 155);
            this.txtStudentNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtStudentNo.Multiline = true;
            this.txtStudentNo.Name = "txtStudentNo";
            this.txtStudentNo.Size = new System.Drawing.Size(230, 30);
            this.txtStudentNo.TabIndex = 126;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 120);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 125;
            this.label3.Text = "Student No";
            // 
            // txtTc
            // 
            this.txtTc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtTc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTc.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTc.Location = new System.Drawing.Point(29, 63);
            this.txtTc.Margin = new System.Windows.Forms.Padding(4);
            this.txtTc.MaxLength = 11;
            this.txtTc.Multiline = true;
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(230, 30);
            this.txtTc.TabIndex = 124;
            this.txtTc.TextChanged += new System.EventHandler(this.txtTc_TextChanged);
            this.txtTc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTc_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 123;
            this.label2.Text = "Tc No";
            // 
            // txtTotalPaid
            // 
            this.txtTotalPaid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTotalPaid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtTotalPaid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalPaid.Enabled = false;
            this.txtTotalPaid.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPaid.Location = new System.Drawing.Point(30, 339);
            this.txtTotalPaid.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalPaid.Multiline = true;
            this.txtTotalPaid.Name = "txtTotalPaid";
            this.txtTotalPaid.Size = new System.Drawing.Size(230, 30);
            this.txtTotalPaid.TabIndex = 139;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 304);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 17);
            this.label7.TabIndex = 138;
            this.label7.Text = "Total Paid";
            // 
            // txtRemainn
            // 
            this.txtRemainn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRemainn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtRemainn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRemainn.Enabled = false;
            this.txtRemainn.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemainn.Location = new System.Drawing.Point(28, 432);
            this.txtRemainn.Margin = new System.Windows.Forms.Padding(4);
            this.txtRemainn.Multiline = true;
            this.txtRemainn.Name = "txtRemainn";
            this.txtRemainn.Size = new System.Drawing.Size(230, 30);
            this.txtRemainn.TabIndex = 141;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 397);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 17);
            this.label8.TabIndex = 140;
            this.label8.Text = "Remaining Payment";
            // 
            // txtAmount
            // 
            this.txtAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAmount.Enabled = false;
            this.txtAmount.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(322, 58);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtAmount.Multiline = true;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(230, 30);
            this.txtAmount.TabIndex = 143;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(319, 30);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 17);
            this.label9.TabIndex = 142;
            this.label9.Text = "Amount Paid";
            // 
            // cmbType
            // 
            this.cmbType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbType.Enabled = false;
            this.cmbType.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "CASH",
            "CREDIT CARD"});
            this.cmbType.Location = new System.Drawing.Point(30, 513);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(230, 24);
            this.cmbType.TabIndex = 145;
            this.cmbType.Text = "Select...";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 484);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 17);
            this.label10.TabIndex = 144;
            this.label10.Text = "Payment Type";
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
            this.btnPay.Location = new System.Drawing.Point(589, 54);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(185, 34);
            this.btnPay.TabIndex = 146;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // dataGridListStudents
            // 
            this.dataGridListStudents.BackgroundColor = System.Drawing.Color.White;
            this.dataGridListStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridListStudents.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.dataGridListStudents.Location = new System.Drawing.Point(322, 120);
            this.dataGridListStudents.Name = "dataGridListStudents";
            this.dataGridListStudents.Size = new System.Drawing.Size(716, 418);
            this.dataGridListStudents.TabIndex = 147;
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1068, 704);
            this.Controls.Add(this.dataGridListStudents);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtRemainn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTotalPaid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNameLastName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStudentNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTc);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1068, 704);
            this.Name = "PaymentForm";
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Payment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNameLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStudentNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotalPaid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRemainn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.DataGridView dataGridListStudents;
    }
}