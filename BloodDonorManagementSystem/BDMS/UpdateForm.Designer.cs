
namespace BDMS
{
    partial class UpdateForm
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
            this.submitBtn = new System.Windows.Forms.Button();
            this.lastDonated = new System.Windows.Forms.DateTimePicker();
            this.address = new System.Windows.Forms.RichTextBox();
            this.bloodGroup = new System.Windows.Forms.TextBox();
            this.donationCount = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.fullname = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // submitBtn
            // 
            this.submitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.submitBtn.ForeColor = System.Drawing.Color.White;
            this.submitBtn.Location = new System.Drawing.Point(457, 580);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(94, 29);
            this.submitBtn.TabIndex = 32;
            this.submitBtn.Text = "Update";
            this.submitBtn.UseVisualStyleBackColor = false;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // lastDonated
            // 
            this.lastDonated.Location = new System.Drawing.Point(258, 404);
            this.lastDonated.Name = "lastDonated";
            this.lastDonated.Size = new System.Drawing.Size(293, 27);
            this.lastDonated.TabIndex = 31;
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(258, 454);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(293, 120);
            this.address.TabIndex = 30;
            this.address.Text = "";
            // 
            // bloodGroup
            // 
            this.bloodGroup.Location = new System.Drawing.Point(258, 279);
            this.bloodGroup.Name = "bloodGroup";
            this.bloodGroup.Size = new System.Drawing.Size(293, 27);
            this.bloodGroup.TabIndex = 29;
            // 
            // donationCount
            // 
            this.donationCount.Location = new System.Drawing.Point(258, 338);
            this.donationCount.Name = "donationCount";
            this.donationCount.Size = new System.Drawing.Size(293, 27);
            this.donationCount.TabIndex = 28;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(258, 163);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(293, 27);
            this.email.TabIndex = 27;
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(258, 225);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(293, 27);
            this.phone.TabIndex = 26;
            // 
            // fullname
            // 
            this.fullname.Location = new System.Drawing.Point(258, 104);
            this.fullname.Name = "fullname";
            this.fullname.Size = new System.Drawing.Size(293, 27);
            this.fullname.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.label8.Location = new System.Drawing.Point(120, 467);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.label7.Location = new System.Drawing.Point(120, 345);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Donation Count";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.label6.Location = new System.Drawing.Point(120, 409);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Last Donated";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.label5.Location = new System.Drawing.Point(120, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.label4.Location = new System.Drawing.Point(120, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Blood Group";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.label3.Location = new System.Drawing.Point(120, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Phone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.label2.Location = new System.Drawing.Point(120, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Fullname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.label1.Location = new System.Drawing.Point(258, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 31);
            this.label1.TabIndex = 17;
            this.label1.Text = "Update Record";
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(671, 631);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.lastDonated);
            this.Controls.Add(this.address);
            this.Controls.Add(this.bloodGroup);
            this.Controls.Add(this.donationCount);
            this.Controls.Add(this.email);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.fullname);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdateForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.UpdateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.DateTimePicker lastDonated;
        private System.Windows.Forms.RichTextBox address;
        private System.Windows.Forms.TextBox bloodGroup;
        private System.Windows.Forms.TextBox donationCount;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.TextBox fullname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}