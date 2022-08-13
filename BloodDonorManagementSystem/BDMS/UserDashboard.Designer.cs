
namespace BDMS
{
    partial class UserDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserDashboard));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.usernameText = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnFullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBloodgroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDonationcount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnLastdonated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // logoutBtn
            // 
            this.logoutBtn.Image = ((System.Drawing.Image)(resources.GetObject("logoutBtn.Image")));
            this.logoutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.logoutBtn.Location = new System.Drawing.Point(1279, 4);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(111, 39);
            this.logoutBtn.TabIndex = 39;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(427, -2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(537, 45);
            this.label2.TabIndex = 38;
            this.label2.Text = "Blood Donor Management System";
            // 
            // usernameText
            // 
            this.usernameText.AutoSize = true;
            this.usernameText.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.usernameText.Location = new System.Drawing.Point(44, 20);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(54, 23);
            this.usernameText.TabIndex = 37;
            this.usernameText.Text = "Guest";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 29);
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnEmail,
            this.columnFullname,
            this.ColumnPhone,
            this.ColumnBloodgroup,
            this.columnDonationcount,
            this.columnLastdonated,
            this.columnAddress});
            this.dataGridView1.Location = new System.Drawing.Point(3, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1397, 494);
            this.dataGridView1.TabIndex = 35;
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
            // UserDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1404, 616);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.usernameText);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UserDashboard";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.UserDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label usernameText;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBloodgroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDonationcount;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnLastdonated;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnAddress;
    }
}