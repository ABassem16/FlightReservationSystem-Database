namespace Flight_Reservation_System_2._0
{
    partial class AdminSignIn
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.EnterSigninA = new System.Windows.Forms.Button();
            this.BackSigninA = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(111, 65);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 11;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(111, 107);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // EnterSigninA
            // 
            this.EnterSigninA.Location = new System.Drawing.Point(172, 173);
            this.EnterSigninA.Name = "EnterSigninA";
            this.EnterSigninA.Size = new System.Drawing.Size(75, 23);
            this.EnterSigninA.TabIndex = 9;
            this.EnterSigninA.Text = "Enter";
            this.EnterSigninA.UseVisualStyleBackColor = true;
            this.EnterSigninA.Click += new System.EventHandler(this.EnterSigninA_Click);
            // 
            // BackSigninA
            // 
            this.BackSigninA.Location = new System.Drawing.Point(57, 173);
            this.BackSigninA.Name = "BackSigninA";
            this.BackSigninA.Size = new System.Drawing.Size(75, 23);
            this.BackSigninA.TabIndex = 8;
            this.BackSigninA.Text = "Back";
            this.BackSigninA.UseVisualStyleBackColor = true;
            this.BackSigninA.Click += new System.EventHandler(this.BackSigninA_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Username";
            // 
            // AdminSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.EnterSigninA);
            this.Controls.Add(this.BackSigninA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdminSignIn";
            this.Text = "AdminSignIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button EnterSigninA;
        private System.Windows.Forms.Button BackSigninA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}