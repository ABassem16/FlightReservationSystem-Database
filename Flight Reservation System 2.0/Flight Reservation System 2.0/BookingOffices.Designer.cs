namespace Flight_Reservation_System_2._0
{
    partial class BookingOffices
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
            System.Windows.Forms.Label office_idLabel;
            System.Windows.Forms.Label office_nameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookingOffices));
            this.flightReservationSystemDataSet = new Flight_Reservation_System_2._0.FlightReservationSystemDataSet();
            this.booking_officeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.booking_officeTableAdapter = new Flight_Reservation_System_2._0.FlightReservationSystemDataSetTableAdapters.Booking_officeTableAdapter();
            this.tableAdapterManager = new Flight_Reservation_System_2._0.FlightReservationSystemDataSetTableAdapters.TableAdapterManager();
            this.booking_officeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.booking_officeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.booking_officeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.office_idTextBox = new System.Windows.Forms.TextBox();
            this.office_nameTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            office_idLabel = new System.Windows.Forms.Label();
            office_nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.flightReservationSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booking_officeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booking_officeBindingNavigator)).BeginInit();
            this.booking_officeBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booking_officeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // office_idLabel
            // 
            office_idLabel.AutoSize = true;
            office_idLabel.Location = new System.Drawing.Point(12, 59);
            office_idLabel.Name = "office_idLabel";
            office_idLabel.Size = new System.Drawing.Size(49, 13);
            office_idLabel.TabIndex = 2;
            office_idLabel.Text = "Office id:";
            // 
            // office_nameLabel
            // 
            office_nameLabel.AutoSize = true;
            office_nameLabel.Location = new System.Drawing.Point(12, 85);
            office_nameLabel.Name = "office_nameLabel";
            office_nameLabel.Size = new System.Drawing.Size(67, 13);
            office_nameLabel.TabIndex = 4;
            office_nameLabel.Text = "Office name:";
            // 
            // flightReservationSystemDataSet
            // 
            this.flightReservationSystemDataSet.DataSetName = "FlightReservationSystemDataSet";
            this.flightReservationSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // booking_officeBindingSource
            // 
            this.booking_officeBindingSource.DataMember = "Booking_office";
            this.booking_officeBindingSource.DataSource = this.flightReservationSystemDataSet;
            // 
            // booking_officeTableAdapter
            // 
            this.booking_officeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdminTableAdapter = null;
            this.tableAdapterManager.AirplaneTableAdapter = null;
            this.tableAdapterManager.AirportTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Booking_officeTableAdapter = this.booking_officeTableAdapter;
            this.tableAdapterManager.FlightTableAdapter = null;
            this.tableAdapterManager.Has_BookingTableAdapter = null;
            this.tableAdapterManager.Land_onTableAdapter = null;
            this.tableAdapterManager.PassengerTableAdapter = null;
            this.tableAdapterManager.reservesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Flight_Reservation_System_2._0.FlightReservationSystemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // booking_officeBindingNavigator
            // 
            this.booking_officeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.booking_officeBindingNavigator.BindingSource = this.booking_officeBindingSource;
            this.booking_officeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.booking_officeBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.booking_officeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.booking_officeBindingNavigatorSaveItem});
            this.booking_officeBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.booking_officeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.booking_officeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.booking_officeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.booking_officeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.booking_officeBindingNavigator.Name = "booking_officeBindingNavigator";
            this.booking_officeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.booking_officeBindingNavigator.Size = new System.Drawing.Size(511, 25);
            this.booking_officeBindingNavigator.TabIndex = 0;
            this.booking_officeBindingNavigator.Text = "bindingNavigator1";
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
            // booking_officeBindingNavigatorSaveItem
            // 
            this.booking_officeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.booking_officeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("booking_officeBindingNavigatorSaveItem.Image")));
            this.booking_officeBindingNavigatorSaveItem.Name = "booking_officeBindingNavigatorSaveItem";
            this.booking_officeBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.booking_officeBindingNavigatorSaveItem.Text = "Save Data";
            this.booking_officeBindingNavigatorSaveItem.Click += new System.EventHandler(this.booking_officeBindingNavigatorSaveItem_Click);
            // 
            // booking_officeDataGridView
            // 
            this.booking_officeDataGridView.AutoGenerateColumns = false;
            this.booking_officeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booking_officeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.booking_officeDataGridView.DataSource = this.booking_officeBindingSource;
            this.booking_officeDataGridView.Location = new System.Drawing.Point(248, 28);
            this.booking_officeDataGridView.Name = "booking_officeDataGridView";
            this.booking_officeDataGridView.Size = new System.Drawing.Size(243, 220);
            this.booking_officeDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Office_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Office_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Office_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Office_name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // office_idTextBox
            // 
            this.office_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booking_officeBindingSource, "Office_id", true));
            this.office_idTextBox.Location = new System.Drawing.Point(85, 56);
            this.office_idTextBox.Name = "office_idTextBox";
            this.office_idTextBox.Size = new System.Drawing.Size(100, 20);
            this.office_idTextBox.TabIndex = 3;
            // 
            // office_nameTextBox
            // 
            this.office_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booking_officeBindingSource, "Office_name", true));
            this.office_nameTextBox.Location = new System.Drawing.Point(85, 82);
            this.office_nameTextBox.Name = "office_nameTextBox";
            this.office_nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.office_nameTextBox.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(96, 138);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(167, 167);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(96, 196);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(333, 254);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 10;
            this.button5.Text = "Show Data";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // BookingOffices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 329);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(office_idLabel);
            this.Controls.Add(this.office_idTextBox);
            this.Controls.Add(office_nameLabel);
            this.Controls.Add(this.office_nameTextBox);
            this.Controls.Add(this.booking_officeDataGridView);
            this.Controls.Add(this.booking_officeBindingNavigator);
            this.Name = "BookingOffices";
            this.Text = "BookingOffices";
            this.Load += new System.EventHandler(this.BookingOffices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.flightReservationSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booking_officeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booking_officeBindingNavigator)).EndInit();
            this.booking_officeBindingNavigator.ResumeLayout(false);
            this.booking_officeBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booking_officeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlightReservationSystemDataSet flightReservationSystemDataSet;
        private System.Windows.Forms.BindingSource booking_officeBindingSource;
        private FlightReservationSystemDataSetTableAdapters.Booking_officeTableAdapter booking_officeTableAdapter;
        private FlightReservationSystemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator booking_officeBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton booking_officeBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView booking_officeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.TextBox office_idTextBox;
        private System.Windows.Forms.TextBox office_nameTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}