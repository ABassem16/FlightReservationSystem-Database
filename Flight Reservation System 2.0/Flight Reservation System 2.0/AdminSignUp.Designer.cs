namespace Flight_Reservation_System_2._0
{
    partial class AdminSignUp
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label anameLabel;
            System.Windows.Forms.Label apassLabel;
            this.EnterSigninA = new System.Windows.Forms.Button();
            this.BackSigninA = new System.Windows.Forms.Button();
            this.flightReservationSystemDataSet = new Flight_Reservation_System_2._0.FlightReservationSystemDataSet();
            this.adminBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adminTableAdapter = new Flight_Reservation_System_2._0.FlightReservationSystemDataSetTableAdapters.AdminTableAdapter();
            this.tableAdapterManager = new Flight_Reservation_System_2._0.FlightReservationSystemDataSetTableAdapters.TableAdapterManager();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            anameLabel = new System.Windows.Forms.Label();
            apassLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.flightReservationSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // anameLabel
            // 
            anameLabel.AutoSize = true;
            anameLabel.Location = new System.Drawing.Point(38, 85);
            anameLabel.Name = "anameLabel";
            anameLabel.Size = new System.Drawing.Size(55, 13);
            anameLabel.TabIndex = 10;
            anameLabel.Text = "Username";
            // 
            // apassLabel
            // 
            apassLabel.AutoSize = true;
            apassLabel.Location = new System.Drawing.Point(40, 108);
            apassLabel.Name = "apassLabel";
            apassLabel.Size = new System.Drawing.Size(53, 13);
            apassLabel.TabIndex = 12;
            apassLabel.Text = "Password";
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
            // flightReservationSystemDataSet
            // 
            this.flightReservationSystemDataSet.DataSetName = "FlightReservationSystemDataSet";
            this.flightReservationSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adminBindingSource
            // 
            this.adminBindingSource.DataMember = "Admin";
            this.adminBindingSource.DataSource = this.flightReservationSystemDataSet;
            // 
            // adminTableAdapter
            // 
            this.adminTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdminTableAdapter = this.adminTableAdapter;
            this.tableAdapterManager.AirplaneTableAdapter = null;
            this.tableAdapterManager.AirportTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Booking_officeTableAdapter = null;
            this.tableAdapterManager.FlightTableAdapter = null;
            this.tableAdapterManager.Has_BookingTableAdapter = null;
            this.tableAdapterManager.Land_onTableAdapter = null;
            this.tableAdapterManager.PassengerTableAdapter = null;
            this.tableAdapterManager.reservesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Flight_Reservation_System_2._0.FlightReservationSystemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(100, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 13;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(99, 105);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '$';
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 14;
            // 
            // AdminSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(anameLabel);
            this.Controls.Add(apassLabel);
            this.Controls.Add(this.EnterSigninA);
            this.Controls.Add(this.BackSigninA);
            this.Name = "AdminSignUp";
            this.Text = "AdminSignUp";
            this.Load += new System.EventHandler(this.AdminSignUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.flightReservationSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button EnterSigninA;
        private System.Windows.Forms.Button BackSigninA;
        private FlightReservationSystemDataSet flightReservationSystemDataSet;
        private System.Windows.Forms.BindingSource adminBindingSource;
        private FlightReservationSystemDataSetTableAdapters.AdminTableAdapter adminTableAdapter;
        private FlightReservationSystemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}