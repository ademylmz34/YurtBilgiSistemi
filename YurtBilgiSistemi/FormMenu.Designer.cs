
namespace YurtBilgiSistemi
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.iconbtnLogout = new FontAwesome.Sharp.IconButton();
            this.panelRoomSubMenu = new System.Windows.Forms.Panel();
            this.btnQuadRoom = new System.Windows.Forms.Button();
            this.btnTripleRoom = new System.Windows.Forms.Button();
            this.btnDoubleRoom = new System.Windows.Forms.Button();
            this.btnSingleRoom = new System.Windows.Forms.Button();
            this.iconbtnRooms = new FontAwesome.Sharp.IconButton();
            this.panelStaffSubMenu = new System.Windows.Forms.Panel();
            this.btnSalary = new System.Windows.Forms.Button();
            this.btnListStaff = new System.Windows.Forms.Button();
            this.btnUpdateStaff = new System.Windows.Forms.Button();
            this.btnAddStaff = new System.Windows.Forms.Button();
            this.iconbtnStaff = new FontAwesome.Sharp.IconButton();
            this.panelStudentSubMenu = new System.Windows.Forms.Panel();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnListStudent = new System.Windows.Forms.Button();
            this.btnUpdateStudent = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.iconbtnStudent = new FontAwesome.Sharp.IconButton();
            this.iconbtnHome = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelSideMenu.SuspendLayout();
            this.panelRoomSubMenu.SuspendLayout();
            this.panelStaffSubMenu.SuspendLayout();
            this.panelStudentSubMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.panelSideMenu.Controls.Add(this.iconbtnLogout);
            this.panelSideMenu.Controls.Add(this.panelRoomSubMenu);
            this.panelSideMenu.Controls.Add(this.iconbtnRooms);
            this.panelSideMenu.Controls.Add(this.panelStaffSubMenu);
            this.panelSideMenu.Controls.Add(this.iconbtnStaff);
            this.panelSideMenu.Controls.Add(this.panelStudentSubMenu);
            this.panelSideMenu.Controls.Add(this.iconbtnStudent);
            this.panelSideMenu.Controls.Add(this.iconbtnHome);
            this.panelSideMenu.Controls.Add(this.panel2);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(220, 779);
            this.panelSideMenu.TabIndex = 0;
            // 
            // iconbtnLogout
            // 
            this.iconbtnLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconbtnLogout.FlatAppearance.BorderSize = 0;
            this.iconbtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconbtnLogout.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconbtnLogout.ForeColor = System.Drawing.Color.White;
            this.iconbtnLogout.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.iconbtnLogout.IconColor = System.Drawing.Color.White;
            this.iconbtnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnLogout.IconSize = 32;
            this.iconbtnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconbtnLogout.Location = new System.Drawing.Point(0, 1009);
            this.iconbtnLogout.Name = "iconbtnLogout";
            this.iconbtnLogout.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iconbtnLogout.Size = new System.Drawing.Size(203, 60);
            this.iconbtnLogout.TabIndex = 9;
            this.iconbtnLogout.Text = "Logout";
            this.iconbtnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconbtnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconbtnLogout.UseVisualStyleBackColor = true;
            this.iconbtnLogout.Click += new System.EventHandler(this.iconbtnLogout_Click);
            // 
            // panelRoomSubMenu
            // 
            this.panelRoomSubMenu.BackColor = System.Drawing.Color.Gainsboro;
            this.panelRoomSubMenu.Controls.Add(this.btnQuadRoom);
            this.panelRoomSubMenu.Controls.Add(this.btnTripleRoom);
            this.panelRoomSubMenu.Controls.Add(this.btnDoubleRoom);
            this.panelRoomSubMenu.Controls.Add(this.btnSingleRoom);
            this.panelRoomSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRoomSubMenu.Location = new System.Drawing.Point(0, 849);
            this.panelRoomSubMenu.Name = "panelRoomSubMenu";
            this.panelRoomSubMenu.Size = new System.Drawing.Size(203, 160);
            this.panelRoomSubMenu.TabIndex = 8;
            // 
            // btnQuadRoom
            // 
            this.btnQuadRoom.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQuadRoom.FlatAppearance.BorderSize = 0;
            this.btnQuadRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuadRoom.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuadRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnQuadRoom.Location = new System.Drawing.Point(0, 120);
            this.btnQuadRoom.Name = "btnQuadRoom";
            this.btnQuadRoom.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnQuadRoom.Size = new System.Drawing.Size(203, 40);
            this.btnQuadRoom.TabIndex = 3;
            this.btnQuadRoom.Text = "Quad Room";
            this.btnQuadRoom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuadRoom.UseVisualStyleBackColor = true;
            this.btnQuadRoom.Click += new System.EventHandler(this.btnQuadRoom_Click);
            // 
            // btnTripleRoom
            // 
            this.btnTripleRoom.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTripleRoom.FlatAppearance.BorderSize = 0;
            this.btnTripleRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTripleRoom.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTripleRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnTripleRoom.Location = new System.Drawing.Point(0, 80);
            this.btnTripleRoom.Name = "btnTripleRoom";
            this.btnTripleRoom.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnTripleRoom.Size = new System.Drawing.Size(203, 40);
            this.btnTripleRoom.TabIndex = 2;
            this.btnTripleRoom.Text = "Triple Room";
            this.btnTripleRoom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTripleRoom.UseVisualStyleBackColor = true;
            this.btnTripleRoom.Click += new System.EventHandler(this.btnTripleRoom_Click);
            // 
            // btnDoubleRoom
            // 
            this.btnDoubleRoom.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDoubleRoom.FlatAppearance.BorderSize = 0;
            this.btnDoubleRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoubleRoom.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoubleRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnDoubleRoom.Location = new System.Drawing.Point(0, 40);
            this.btnDoubleRoom.Name = "btnDoubleRoom";
            this.btnDoubleRoom.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnDoubleRoom.Size = new System.Drawing.Size(203, 40);
            this.btnDoubleRoom.TabIndex = 1;
            this.btnDoubleRoom.Text = "Double Room";
            this.btnDoubleRoom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoubleRoom.UseVisualStyleBackColor = true;
            this.btnDoubleRoom.Click += new System.EventHandler(this.btnDoubleRoom_Click);
            // 
            // btnSingleRoom
            // 
            this.btnSingleRoom.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSingleRoom.FlatAppearance.BorderSize = 0;
            this.btnSingleRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSingleRoom.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSingleRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnSingleRoom.Location = new System.Drawing.Point(0, 0);
            this.btnSingleRoom.Name = "btnSingleRoom";
            this.btnSingleRoom.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSingleRoom.Size = new System.Drawing.Size(203, 40);
            this.btnSingleRoom.TabIndex = 0;
            this.btnSingleRoom.Text = "Single Rooms";
            this.btnSingleRoom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSingleRoom.UseVisualStyleBackColor = true;
            this.btnSingleRoom.Click += new System.EventHandler(this.btnSingleRoom_Click);
            // 
            // iconbtnRooms
            // 
            this.iconbtnRooms.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconbtnRooms.FlatAppearance.BorderSize = 0;
            this.iconbtnRooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconbtnRooms.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconbtnRooms.ForeColor = System.Drawing.Color.White;
            this.iconbtnRooms.IconChar = FontAwesome.Sharp.IconChar.Building;
            this.iconbtnRooms.IconColor = System.Drawing.Color.White;
            this.iconbtnRooms.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnRooms.IconSize = 32;
            this.iconbtnRooms.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconbtnRooms.Location = new System.Drawing.Point(0, 789);
            this.iconbtnRooms.Name = "iconbtnRooms";
            this.iconbtnRooms.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iconbtnRooms.Size = new System.Drawing.Size(203, 60);
            this.iconbtnRooms.TabIndex = 7;
            this.iconbtnRooms.Text = "Rooms";
            this.iconbtnRooms.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconbtnRooms.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconbtnRooms.UseVisualStyleBackColor = true;
            this.iconbtnRooms.Click += new System.EventHandler(this.iconbtnRooms_Click);
            // 
            // panelStaffSubMenu
            // 
            this.panelStaffSubMenu.BackColor = System.Drawing.Color.Gainsboro;
            this.panelStaffSubMenu.Controls.Add(this.btnSalary);
            this.panelStaffSubMenu.Controls.Add(this.btnListStaff);
            this.panelStaffSubMenu.Controls.Add(this.btnUpdateStaff);
            this.panelStaffSubMenu.Controls.Add(this.btnAddStaff);
            this.panelStaffSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStaffSubMenu.Location = new System.Drawing.Point(0, 549);
            this.panelStaffSubMenu.Name = "panelStaffSubMenu";
            this.panelStaffSubMenu.Size = new System.Drawing.Size(203, 240);
            this.panelStaffSubMenu.TabIndex = 6;
            // 
            // btnSalary
            // 
            this.btnSalary.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSalary.FlatAppearance.BorderSize = 0;
            this.btnSalary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalary.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnSalary.Location = new System.Drawing.Point(0, 120);
            this.btnSalary.Name = "btnSalary";
            this.btnSalary.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSalary.Size = new System.Drawing.Size(203, 40);
            this.btnSalary.TabIndex = 4;
            this.btnSalary.Text = "Make Payment";
            this.btnSalary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalary.UseVisualStyleBackColor = true;
            this.btnSalary.Click += new System.EventHandler(this.btnSalary_Click);
            // 
            // btnListStaff
            // 
            this.btnListStaff.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListStaff.FlatAppearance.BorderSize = 0;
            this.btnListStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListStaff.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListStaff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnListStaff.Location = new System.Drawing.Point(0, 80);
            this.btnListStaff.Name = "btnListStaff";
            this.btnListStaff.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnListStaff.Size = new System.Drawing.Size(203, 40);
            this.btnListStaff.TabIndex = 3;
            this.btnListStaff.Text = "List Staff";
            this.btnListStaff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListStaff.UseVisualStyleBackColor = true;
            this.btnListStaff.Click += new System.EventHandler(this.btnListStaff_Click);
            // 
            // btnUpdateStaff
            // 
            this.btnUpdateStaff.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpdateStaff.FlatAppearance.BorderSize = 0;
            this.btnUpdateStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateStaff.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateStaff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnUpdateStaff.Location = new System.Drawing.Point(0, 40);
            this.btnUpdateStaff.Name = "btnUpdateStaff";
            this.btnUpdateStaff.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnUpdateStaff.Size = new System.Drawing.Size(203, 40);
            this.btnUpdateStaff.TabIndex = 1;
            this.btnUpdateStaff.Text = "Update Staff";
            this.btnUpdateStaff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateStaff.UseVisualStyleBackColor = true;
            this.btnUpdateStaff.Click += new System.EventHandler(this.btnUpdateStaff_Click);
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddStaff.FlatAppearance.BorderSize = 0;
            this.btnAddStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStaff.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStaff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnAddStaff.Location = new System.Drawing.Point(0, 0);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAddStaff.Size = new System.Drawing.Size(203, 40);
            this.btnAddStaff.TabIndex = 0;
            this.btnAddStaff.Text = "Add Staff";
            this.btnAddStaff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddStaff.UseVisualStyleBackColor = true;
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
            // 
            // iconbtnStaff
            // 
            this.iconbtnStaff.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconbtnStaff.FlatAppearance.BorderSize = 0;
            this.iconbtnStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconbtnStaff.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconbtnStaff.ForeColor = System.Drawing.Color.White;
            this.iconbtnStaff.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.iconbtnStaff.IconColor = System.Drawing.Color.White;
            this.iconbtnStaff.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnStaff.IconSize = 32;
            this.iconbtnStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconbtnStaff.Location = new System.Drawing.Point(0, 489);
            this.iconbtnStaff.Name = "iconbtnStaff";
            this.iconbtnStaff.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iconbtnStaff.Size = new System.Drawing.Size(203, 60);
            this.iconbtnStaff.TabIndex = 5;
            this.iconbtnStaff.Text = "Staff";
            this.iconbtnStaff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconbtnStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconbtnStaff.UseVisualStyleBackColor = true;
            this.iconbtnStaff.Click += new System.EventHandler(this.iconbtnStaff_Click);
            // 
            // panelStudentSubMenu
            // 
            this.panelStudentSubMenu.BackColor = System.Drawing.Color.Gainsboro;
            this.panelStudentSubMenu.Controls.Add(this.btnPayment);
            this.panelStudentSubMenu.Controls.Add(this.btnListStudent);
            this.panelStudentSubMenu.Controls.Add(this.btnUpdateStudent);
            this.panelStudentSubMenu.Controls.Add(this.btnAddStudent);
            this.panelStudentSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStudentSubMenu.Location = new System.Drawing.Point(0, 249);
            this.panelStudentSubMenu.Name = "panelStudentSubMenu";
            this.panelStudentSubMenu.Size = new System.Drawing.Size(203, 240);
            this.panelStudentSubMenu.TabIndex = 4;
            // 
            // btnPayment
            // 
            this.btnPayment.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPayment.FlatAppearance.BorderSize = 0;
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayment.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnPayment.Location = new System.Drawing.Point(0, 120);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnPayment.Size = new System.Drawing.Size(203, 40);
            this.btnPayment.TabIndex = 4;
            this.btnPayment.Text = "Make Payment";
            this.btnPayment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnListStudent
            // 
            this.btnListStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListStudent.FlatAppearance.BorderSize = 0;
            this.btnListStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListStudent.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnListStudent.Location = new System.Drawing.Point(0, 80);
            this.btnListStudent.Name = "btnListStudent";
            this.btnListStudent.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnListStudent.Size = new System.Drawing.Size(203, 40);
            this.btnListStudent.TabIndex = 3;
            this.btnListStudent.Text = "List Students";
            this.btnListStudent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListStudent.UseVisualStyleBackColor = true;
            this.btnListStudent.Click += new System.EventHandler(this.btnListStudent_Click);
            // 
            // btnUpdateStudent
            // 
            this.btnUpdateStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpdateStudent.FlatAppearance.BorderSize = 0;
            this.btnUpdateStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateStudent.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnUpdateStudent.Location = new System.Drawing.Point(0, 40);
            this.btnUpdateStudent.Name = "btnUpdateStudent";
            this.btnUpdateStudent.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnUpdateStudent.Size = new System.Drawing.Size(203, 40);
            this.btnUpdateStudent.TabIndex = 1;
            this.btnUpdateStudent.Text = "Update Student";
            this.btnUpdateStudent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateStudent.UseVisualStyleBackColor = true;
            this.btnUpdateStudent.Click += new System.EventHandler(this.btnUpdateStudent_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddStudent.FlatAppearance.BorderSize = 0;
            this.btnAddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStudent.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnAddStudent.Location = new System.Drawing.Point(0, 0);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAddStudent.Size = new System.Drawing.Size(203, 40);
            this.btnAddStudent.TabIndex = 0;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click_1);
            // 
            // iconbtnStudent
            // 
            this.iconbtnStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconbtnStudent.FlatAppearance.BorderSize = 0;
            this.iconbtnStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconbtnStudent.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconbtnStudent.ForeColor = System.Drawing.Color.White;
            this.iconbtnStudent.IconChar = FontAwesome.Sharp.IconChar.UserGraduate;
            this.iconbtnStudent.IconColor = System.Drawing.Color.White;
            this.iconbtnStudent.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnStudent.IconSize = 32;
            this.iconbtnStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconbtnStudent.Location = new System.Drawing.Point(0, 189);
            this.iconbtnStudent.Name = "iconbtnStudent";
            this.iconbtnStudent.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iconbtnStudent.Size = new System.Drawing.Size(203, 60);
            this.iconbtnStudent.TabIndex = 2;
            this.iconbtnStudent.Text = "Students";
            this.iconbtnStudent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconbtnStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconbtnStudent.UseVisualStyleBackColor = true;
            this.iconbtnStudent.Click += new System.EventHandler(this.iconbtnStudent_Click);
            // 
            // iconbtnHome
            // 
            this.iconbtnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconbtnHome.FlatAppearance.BorderSize = 0;
            this.iconbtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconbtnHome.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconbtnHome.ForeColor = System.Drawing.Color.White;
            this.iconbtnHome.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconbtnHome.IconColor = System.Drawing.Color.White;
            this.iconbtnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnHome.IconSize = 32;
            this.iconbtnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconbtnHome.Location = new System.Drawing.Point(0, 129);
            this.iconbtnHome.Name = "iconbtnHome";
            this.iconbtnHome.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iconbtnHome.Size = new System.Drawing.Size(203, 60);
            this.iconbtnHome.TabIndex = 1;
            this.iconbtnHome.Text = "Home";
            this.iconbtnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconbtnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconbtnHome.UseVisualStyleBackColor = true;
            this.iconbtnHome.Click += new System.EventHandler(this.iconbtnHome_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(203, 129);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(50, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(118, 120);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 135;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1068, 75);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.White;
            this.lblTitleChildForm.Location = new System.Drawing.Point(496, 22);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(76, 30);
            this.lblTitleChildForm.TabIndex = 2;
            this.lblTitleChildForm.Text = "HOME";
            // 
            // panelDesktop
            // 
            this.panelDesktop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDesktop.BackColor = System.Drawing.Color.White;
            this.panelDesktop.Controls.Add(this.pictureBox1);
            this.panelDesktop.Location = new System.Drawing.Point(220, 75);
            this.panelDesktop.MaximumSize = new System.Drawing.Size(1068, 704);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1068, 704);
            this.panelDesktop.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(151, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(794, 534);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 134;
            this.pictureBox1.TabStop = false;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 779);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelSideMenu);
            this.MinimumSize = new System.Drawing.Size(1304, 818);
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMenu_FormClosing);
            this.Load += new System.EventHandler(this.Form3Menu_Load);
            this.panelSideMenu.ResumeLayout(false);
            this.panelRoomSubMenu.ResumeLayout(false);
            this.panelStaffSubMenu.ResumeLayout(false);
            this.panelStudentSubMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconButton iconbtnHome;
        private FontAwesome.Sharp.IconButton iconbtnStudent;
        private FontAwesome.Sharp.IconButton iconbtnLogout;
        private System.Windows.Forms.Panel panelRoomSubMenu;
        private System.Windows.Forms.Button btnQuadRoom;
        private System.Windows.Forms.Button btnTripleRoom;
        private System.Windows.Forms.Button btnDoubleRoom;
        private System.Windows.Forms.Button btnSingleRoom;
        private FontAwesome.Sharp.IconButton iconbtnRooms;
        private System.Windows.Forms.Panel panelStaffSubMenu;
        private System.Windows.Forms.Button btnSalary;
        private System.Windows.Forms.Button btnListStaff;
        private System.Windows.Forms.Button btnUpdateStaff;
        private System.Windows.Forms.Button btnAddStaff;
        private FontAwesome.Sharp.IconButton iconbtnStaff;
        private System.Windows.Forms.Panel panelStudentSubMenu;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnListStudent;
        private System.Windows.Forms.Button btnUpdateStudent;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Label lblTitleChildForm;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}