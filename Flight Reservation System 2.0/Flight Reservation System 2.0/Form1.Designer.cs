namespace Flight_Reservation_System_2._0
{
    partial class Form1
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
            this.SignUpAdmin = new System.Windows.Forms.Button();
            this.SignupCust = new System.Windows.Forms.Button();
            this.Sign_in_Admin = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SignUpAdmin
            // 
            this.SignUpAdmin.Location = new System.Drawing.Point(183, 93);
            this.SignUpAdmin.Name = "SignUpAdmin";
            this.SignUpAdmin.Size = new System.Drawing.Size(75, 23);
            this.SignUpAdmin.TabIndex = 11;
            this.SignUpAdmin.Text = "Sign up";
            this.SignUpAdmin.UseVisualStyleBackColor = true;
            this.SignUpAdmin.Click += new System.EventHandler(this.SignUpAdmin_Click);
            // 
            // SignupCust
            // 
            this.SignupCust.Location = new System.Drawing.Point(107, 140);
            this.SignupCust.Name = "SignupCust";
            this.SignupCust.Size = new System.Drawing.Size(125, 23);
            this.SignupCust.TabIndex = 10;
            this.SignupCust.Text = "Sign up";
            this.SignupCust.UseVisualStyleBackColor = true;
            this.SignupCust.Click += new System.EventHandler(this.SignupCust_Click);
            // 
            // Sign_in_Admin
            // 
            this.Sign_in_Admin.Location = new System.Drawing.Point(84, 93);
            this.Sign_in_Admin.Name = "Sign_in_Admin";
            this.Sign_in_Admin.Size = new System.Drawing.Size(75, 23);
            this.Sign_in_Admin.TabIndex = 8;
            this.Sign_in_Admin.Text = "Sign in";
            this.Sign_in_Admin.UseVisualStyleBackColor = true;
            this.Sign_in_Admin.Click += new System.EventHandler(this.Sign_in_Admin_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Passenger";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Admin";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.SignUpAdmin);
            this.Controls.Add(this.SignupCust);
            this.Controls.Add(this.Sign_in_Admin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SignUpAdmin;
        private System.Windows.Forms.Button SignupCust;
        private System.Windows.Forms.Button Sign_in_Admin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

