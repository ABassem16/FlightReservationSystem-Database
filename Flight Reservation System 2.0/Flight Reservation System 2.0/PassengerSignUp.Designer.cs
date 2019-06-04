namespace Flight_Reservation_System_2._0
{
    partial class PassengerSignUp
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
            System.Windows.Forms.Label ageLabel;
            System.Windows.Forms.Label pnameLabel;
            System.Windows.Forms.Label p_idLabel;
            System.Windows.Forms.Label anameLabel;
            System.Windows.Forms.Label office_idLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label contactLabel;
            System.Windows.Forms.Label e_mailLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PassengerSignUp));
            this.flightReservationSystemDataSet = new Flight_Reservation_System_2._0.FlightReservationSystemDataSet();
            this.passengerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.passengerTableAdapter = new Flight_Reservation_System_2._0.FlightReservationSystemDataSetTableAdapters.PassengerTableAdapter();
            this.tableAdapterManager = new Flight_Reservation_System_2._0.FlightReservationSystemDataSetTableAdapters.TableAdapterManager();
            this.passengerBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.passengerBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.pnameTextBox = new System.Windows.Forms.TextBox();
            this.p_idTextBox = new System.Windows.Forms.TextBox();
            this.anameTextBox = new System.Windows.Forms.TextBox();
            this.office_idTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.contactTextBox = new System.Windows.Forms.TextBox();
            this.e_mailTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ageLabel = new System.Windows.Forms.Label();
            pnameLabel = new System.Windows.Forms.Label();
            p_idLabel = new System.Windows.Forms.Label();
            anameLabel = new System.Windows.Forms.Label();
            office_idLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            contactLabel = new System.Windows.Forms.Label();
            e_mailLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.flightReservationSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengerBindingNavigator)).BeginInit();
            this.passengerBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Location = new System.Drawing.Point(12, 44);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new System.Drawing.Size(29, 13);
            ageLabel.TabIndex = 1;
            ageLabel.Text = "Age:";
            // 
            // pnameLabel
            // 
            pnameLabel.AutoSize = true;
            pnameLabel.Location = new System.Drawing.Point(12, 70);
            pnameLabel.Name = "pnameLabel";
            pnameLabel.Size = new System.Drawing.Size(43, 13);
            pnameLabel.TabIndex = 3;
            pnameLabel.Text = "Pname:";
            // 
            // p_idLabel
            // 
            p_idLabel.AutoSize = true;
            p_idLabel.Location = new System.Drawing.Point(12, 96);
            p_idLabel.Name = "p_idLabel";
            p_idLabel.Size = new System.Drawing.Size(28, 13);
            p_idLabel.TabIndex = 5;
            p_idLabel.Text = "P id:";
            // 
            // anameLabel
            // 
            anameLabel.AutoSize = true;
            anameLabel.Location = new System.Drawing.Point(12, 122);
            anameLabel.Name = "anameLabel";
            anameLabel.Size = new System.Drawing.Size(43, 13);
            anameLabel.TabIndex = 7;
            anameLabel.Text = "Aname:";
            // 
            // office_idLabel
            // 
            office_idLabel.AutoSize = true;
            office_idLabel.Location = new System.Drawing.Point(12, 148);
            office_idLabel.Name = "office_idLabel";
            office_idLabel.Size = new System.Drawing.Size(49, 13);
            office_idLabel.TabIndex = 9;
            office_idLabel.Text = "Office id:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(12, 174);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(47, 13);
            addressLabel.TabIndex = 11;
            addressLabel.Text = "address:";
            // 
            // contactLabel
            // 
            contactLabel.AutoSize = true;
            contactLabel.Location = new System.Drawing.Point(12, 200);
            contactLabel.Name = "contactLabel";
            contactLabel.Size = new System.Drawing.Size(47, 13);
            contactLabel.TabIndex = 13;
            contactLabel.Text = "Contact:";
            // 
            // e_mailLabel
            // 
            e_mailLabel.AutoSize = true;
            e_mailLabel.Location = new System.Drawing.Point(12, 226);
            e_mailLabel.Name = "e_mailLabel";
            e_mailLabel.Size = new System.Drawing.Size(38, 13);
            e_mailLabel.TabIndex = 15;
            e_mailLabel.Text = "E mail:";
            // 
            // flightReservationSystemDataSet
            // 
            this.flightReservationSystemDataSet.DataSetName = "FlightReservationSystemDataSet";
            this.flightReservationSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // passengerBindingSource
            // 
            this.passengerBindingSource.DataMember = "Passenger";
            this.passengerBindingSource.DataSource = this.flightReservationSystemDataSet;
            // 
            // passengerTableAdapter
            // 
            this.passengerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdminTableAdapter = null;
            this.tableAdapterManager.AirplaneTableAdapter = null;
            this.tableAdapterManager.AirportTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Booking_officeTableAdapter = null;
            this.tableAdapterManager.FlightTableAdapter = null;
            this.tableAdapterManager.Has_BookingTableAdapter = null;
            this.tableAdapterManager.Land_onTableAdapter = null;
            this.tableAdapterManager.PassengerTableAdapter = this.passengerTableAdapter;
            this.tableAdapterManager.reservesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Flight_Reservation_System_2._0.FlightReservationSystemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // passengerBindingNavigator
            // 
            this.passengerBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.passengerBindingNavigator.BindingSource = this.passengerBindingSource;
            this.passengerBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.passengerBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.passengerBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.passengerBindingNavigatorSaveItem});
            this.passengerBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.passengerBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.passengerBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.passengerBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.passengerBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.passengerBindingNavigator.Name = "passengerBindingNavigator";
            this.passengerBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.passengerBindingNavigator.Size = new System.Drawing.Size(284, 25);
            this.passengerBindingNavigator.TabIndex = 0;
            this.passengerBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // passengerBindingNavigatorSaveItem
            // 
            this.passengerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.passengerBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("passengerBindingNavigatorSaveItem.Image")));
            this.passengerBindingNavigatorSaveItem.Name = "passengerBindingNavigatorSaveItem";
            this.passengerBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.passengerBindingNavigatorSaveItem.Text = "Save Data";
            this.passengerBindingNavigatorSaveItem.Click += new System.EventHandler(this.passengerBindingNavigatorSaveItem_Click_2);
            // 
            // ageTextBox
            // 
            this.ageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.passengerBindingSource, "Age", true));
            this.ageTextBox.Location = new System.Drawing.Point(67, 41);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(100, 20);
            this.ageTextBox.TabIndex = 2;
            this.ageTextBox.TextChanged += new System.EventHandler(this.ageTextBox_TextChanged);
            // 
            // pnameTextBox
            // 
            this.pnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.passengerBindingSource, "Pname", true));
            this.pnameTextBox.Location = new System.Drawing.Point(67, 67);
            this.pnameTextBox.Name = "pnameTextBox";
            this.pnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.pnameTextBox.TabIndex = 4;
            // 
            // p_idTextBox
            // 
            this.p_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.passengerBindingSource, "P_id", true));
            this.p_idTextBox.Location = new System.Drawing.Point(67, 93);
            this.p_idTextBox.Name = "p_idTextBox";
            this.p_idTextBox.Size = new System.Drawing.Size(100, 20);
            this.p_idTextBox.TabIndex = 6;
            this.p_idTextBox.TextChanged += new System.EventHandler(this.p_idTextBox_TextChanged);
            // 
            // anameTextBox
            // 
            this.anameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.passengerBindingSource, "Aname", true));
            this.anameTextBox.Location = new System.Drawing.Point(67, 119);
            this.anameTextBox.Name = "anameTextBox";
            this.anameTextBox.Size = new System.Drawing.Size(100, 20);
            this.anameTextBox.TabIndex = 8;
            // 
            // office_idTextBox
            // 
            this.office_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.passengerBindingSource, "Office_id", true));
            this.office_idTextBox.Location = new System.Drawing.Point(67, 145);
            this.office_idTextBox.Name = "office_idTextBox";
            this.office_idTextBox.Size = new System.Drawing.Size(100, 20);
            this.office_idTextBox.TabIndex = 10;
            this.office_idTextBox.TextChanged += new System.EventHandler(this.office_idTextBox_TextChanged);
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.passengerBindingSource, "address", true));
            this.addressTextBox.Location = new System.Drawing.Point(67, 171);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(100, 20);
            this.addressTextBox.TabIndex = 12;
            // 
            // contactTextBox
            // 
            this.contactTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.passengerBindingSource, "Contact", true));
            this.contactTextBox.Location = new System.Drawing.Point(67, 197);
            this.contactTextBox.Name = "contactTextBox";
            this.contactTextBox.Size = new System.Drawing.Size(100, 20);
            this.contactTextBox.TabIndex = 14;
            // 
            // e_mailTextBox
            // 
            this.e_mailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.passengerBindingSource, "E_mail", true));
            this.e_mailTextBox.Location = new System.Drawing.Point(67, 223);
            this.e_mailTextBox.Name = "e_mailTextBox";
            this.e_mailTextBox.Size = new System.Drawing.Size(100, 20);
            this.e_mailTextBox.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(178, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 286);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBox1.Location = new System.Drawing.Point(67, 249);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Gender:";
            // 
            // PassengerSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 321);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(ageLabel);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(pnameLabel);
            this.Controls.Add(this.pnameTextBox);
            this.Controls.Add(p_idLabel);
            this.Controls.Add(this.p_idTextBox);
            this.Controls.Add(anameLabel);
            this.Controls.Add(this.anameTextBox);
            this.Controls.Add(office_idLabel);
            this.Controls.Add(this.office_idTextBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(contactLabel);
            this.Controls.Add(this.contactTextBox);
            this.Controls.Add(e_mailLabel);
            this.Controls.Add(this.e_mailTextBox);
            this.Controls.Add(this.passengerBindingNavigator);
            this.Name = "PassengerSignUp";
            this.Text = "PassengerSignUp";
            this.Load += new System.EventHandler(this.PassengerSignUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.flightReservationSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengerBindingNavigator)).EndInit();
            this.passengerBindingNavigator.ResumeLayout(false);
            this.passengerBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlightReservationSystemDataSet flightReservationSystemDataSet;
        private System.Windows.Forms.BindingSource passengerBindingSource;
        private FlightReservationSystemDataSetTableAdapters.PassengerTableAdapter passengerTableAdapter;
        private FlightReservationSystemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator passengerBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton passengerBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.TextBox pnameTextBox;
        private System.Windows.Forms.TextBox p_idTextBox;
        private System.Windows.Forms.TextBox anameTextBox;
        private System.Windows.Forms.TextBox office_idTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox contactTextBox;
        private System.Windows.Forms.TextBox e_mailTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}