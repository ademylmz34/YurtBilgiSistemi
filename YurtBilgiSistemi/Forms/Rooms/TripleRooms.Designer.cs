
namespace YurtBilgiSistemi.Forms.Rooms
{
    partial class TripleRooms
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
            this.dataGridTripleRooms = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTripleRooms)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridTripleRooms
            // 
            this.dataGridTripleRooms.BackgroundColor = System.Drawing.Color.White;
            this.dataGridTripleRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTripleRooms.GridColor = System.Drawing.Color.Black;
            this.dataGridTripleRooms.Location = new System.Drawing.Point(33, 101);
            this.dataGridTripleRooms.Name = "dataGridTripleRooms";
            this.dataGridTripleRooms.Size = new System.Drawing.Size(994, 518);
            this.dataGridTripleRooms.TabIndex = 115;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(311, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 65);
            this.label1.TabIndex = 116;
            this.label1.Text = "TRIPLE ROOMS";
            // 
            // TripleRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1068, 704);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridTripleRooms);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1068, 704);
            this.Name = "TripleRooms";
            this.Text = "TripleRooms";
            this.Load += new System.EventHandler(this.TripleRooms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTripleRooms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridTripleRooms;
        private System.Windows.Forms.Label label1;
    }
}