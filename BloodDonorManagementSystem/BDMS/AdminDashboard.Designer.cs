
namespace BDMS
{
    partial class AdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.usernameText = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.newRecordBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloodGroupColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnFullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBloodgroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDonationcount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnLastdonated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(441, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(537, 45);
            this.label2.TabIndex = 22;
            this.label2.Text = "Blood Donor Management System";
            // 
            // usernameText
            // 
            this.usernameText.AutoSize = true;
            this.usernameText.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.usernameText.Location = new System.Drawing.Point(79, 53);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(60, 23);
            this.usernameText.TabIndex = 21;
            this.usernameText.Text = "Admin";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(51, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 29);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // logoutBtn
            // 
            this.logoutBtn.Image = ((System.Drawing.Image)(resources.GetObject("logoutBtn.Image")));
            this.logoutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.logoutBtn.Location = new System.Drawing.Point(1355, 37);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(98, 39);
            this.logoutBtn.TabIndex = 19;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnEmail,
            this.columnFullname,
            this.ColumnPhone,
            this.ColumnBloodgroup,
            this.columnDonationcount,
            this.columnLastdonated,
            this.columnAddress,
            this.Column10,
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(26, 138);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1427, 494);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // newRecordBtn
            // 
            this.newRecordBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.newRecordBtn.Location = new System.Drawing.Point(26, 101);
            this.newRecordBtn.Name = "newRecordBtn";
            this.newRecordBtn.Size = new System.Drawing.Size(149, 29);
            this.newRecordBtn.TabIndex = 17;
            this.newRecordBtn.Text = "Add Record";
            this.newRecordBtn.UseVisualStyleBackColor = true;
            this.newRecordBtn.Click += new System.EventHandler(this.newRecordBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1130, 103);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(223, 27);
            this.textBox1.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1359, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 24;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // IdColumn
            // 
            this.IdColumn.DataPropertyName = "id";
            this.IdColumn.HeaderText = "ID";
            this.IdColumn.MinimumWidth = 6;
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.Width = 60;
            // 
            // emailColumn
            // 
            this.emailColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.emailColumn.DataPropertyName = "email";
            this.emailColumn.HeaderText = "Email";
            this.emailColumn.MinimumWidth = 6;
            this.emailColumn.Name = "emailColumn";
            this.emailColumn.Width = 250;
            // 
            // fullNameColumn
            // 
            this.fullNameColumn.DataPropertyName = "full_name";
            this.fullNameColumn.HeaderText = "Full name";
            this.fullNameColumn.MinimumWidth = 6;
            this.fullNameColumn.Name = "fullNameColumn";
            this.fullNameColumn.Width = 350;
            // 
            // phoneColumn
            // 
            this.phoneColumn.DataPropertyName = "phone";
            this.phoneColumn.HeaderText = "Phone no";
            this.phoneColumn.MinimumWidth = 6;
            this.phoneColumn.Name = "phoneColumn";
            this.phoneColumn.Width = 90;
            // 
            // bloodGroupColumn
            // 
            this.bloodGroupColumn.DataPropertyName = "blood_group";
            this.bloodGroupColumn.HeaderText = "Blood Group";
            this.bloodGroupColumn.MinimumWidth = 6;
            this.bloodGroupColumn.Name = "bloodGroupColumn";
            this.bloodGroupColumn.Width = 130;
            // 
            // ColumnID
            // 
            this.ColumnID.DataPropertyName = "id";
            this.ColumnID.HeaderText = "Id";
            this.ColumnID.MinimumWidth = 6;
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.Width = 125;
            // 
            // ColumnEmail
            // 
            this.ColumnEmail.DataPropertyName = "email";
            this.ColumnEmail.HeaderText = "Email";
            this.ColumnEmail.MinimumWidth = 6;
            this.ColumnEmail.Name = "ColumnEmail";
            this.ColumnEmail.Width = 125;
            // 
            // columnFullname
            // 
            this.columnFullname.DataPropertyName = "full_name";
            this.columnFullname.HeaderText = "Full name";
            this.columnFullname.MinimumWidth = 6;
            this.columnFullname.Name = "columnFullname";
            this.columnFullname.Width = 125;
            // 
            // ColumnPhone
            // 
            this.ColumnPhone.DataPropertyName = "phone";
            this.ColumnPhone.HeaderText = "Phone ";
            this.ColumnPhone.MinimumWidth = 6;
            this.ColumnPhone.Name = "ColumnPhone";
            this.ColumnPhone.Width = 125;
            // 
            // ColumnBloodgroup
            // 
            this.ColumnBloodgroup.DataPropertyName = "blood_group";
            this.ColumnBloodgroup.HeaderText = "Blood Group";
            this.ColumnBloodgroup.MinimumWidth = 6;
            this.ColumnBloodgroup.Name = "ColumnBloodgroup";
            this.ColumnBloodgroup.Width = 125;
            // 
            // columnDonationcount
            // 
            this.columnDonationcount.DataPropertyName = "donation_count";
            this.columnDonationcount.HeaderText = "Donation count";
            this.columnDonationcount.MinimumWidth = 6;
            this.columnDonationcount.Name = "columnDonationcount";
            this.columnDonationcount.Width = 125;
            // 
            // columnLastdonated
            // 
            this.columnLastdonated.DataPropertyName = "last_donated";
            this.columnLastdonated.HeaderText = "Last Donated";
            this.columnLastdonated.MinimumWidth = 6;
            this.columnLastdonated.Name = "columnLastdonated";
            this.columnLastdonated.Width = 125;
            // 
            // columnAddress
            // 
            this.columnAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnAddress.DataPropertyName = "address";
            this.columnAddress.HeaderText = "Address";
            this.columnAddress.MinimumWidth = 6;
            this.columnAddress.Name = "columnAddress";
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "Update";
            this.Column10.HeaderText = "Update";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column10.Text = "update";
            this.Column10.ToolTipText = "Update";
            this.Column10.Width = 125;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Delete";
            this.Column1.HeaderText = "Delete";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column1.Text = "delete";
            this.Column1.ToolTipText = "Delete";
            this.Column1.Width = 125;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1479, 644);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.usernameText);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.newRecordBtn);
            this.Name = "AdminDashboard";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label usernameText;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button newRecordBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bloodGroupColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBloodgroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDonationcount;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnLastdonated;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnAddress;
        private System.Windows.Forms.DataGridViewButtonColumn Column10;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
    }
}