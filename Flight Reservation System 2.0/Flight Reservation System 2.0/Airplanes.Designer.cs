namespace Flight_Reservation_System_2._0
{
    partial class Airplanes
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
            System.Windows.Forms.Label seatsLabel;
            System.Windows.Forms.Label reg_numLabel;
            System.Windows.Forms.Label airoplane_typeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Airplanes));
            this.flightReservationSystemDataSet = new Flight_Reservation_System_2._0.FlightReservationSystemDataSet();
            this.airplaneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.airplaneTableAdapter = new Flight_Reservation_System_2._0.FlightReservationSystemDataSetTableAdapters.AirplaneTableAdapter();
            this.tableAdapterManager = new Flight_Reservation_System_2._0.FlightReservationSystemDataSetTableAdapters.TableAdapterManager();
            this.airplaneBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.airplaneBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.seatsTextBox = new System.Windows.Forms.TextBox();
            this.reg_numTextBox = new System.Windows.Forms.TextBox();
            this.airoplane_typeTextBox = new System.Windows.Forms.TextBox();
            this.airplaneDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            seatsLabel = new System.Windows.Forms.Label();
            reg_numLabel = new System.Windows.Forms.Label();
            airoplane_typeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.flightReservationSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airplaneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airplaneBindingNavigator)).BeginInit();
            this.airplaneBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.airplaneDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // seatsLabel
            // 
            seatsLabel.AutoSize = true;
            seatsLabel.Location = new System.Drawing.Point(26, 52);
            seatsLabel.Name = "seatsLabel";
            seatsLabel.Size = new System.Drawing.Size(37, 13);
            seatsLabel.TabIndex = 1;
            seatsLabel.Text = "Seats:";
            // 
            // reg_numLabel
            // 
            reg_numLabel.AutoSize = true;
            reg_numLabel.Location = new System.Drawing.Point(26, 78);
            reg_numLabel.Name = "reg_numLabel";
            reg_numLabel.Size = new System.Drawing.Size(53, 13);
            reg_numLabel.TabIndex = 3;
            reg_numLabel.Text = "Reg num:";
            // 
            // airoplane_typeLabel
            // 
            airoplane_typeLabel.AutoSize = true;
            airoplane_typeLabel.Location = new System.Drawing.Point(26, 104);
            airoplane_typeLabel.Name = "airoplane_typeLabel";
            airoplane_typeLabel.Size = new System.Drawing.Size(77, 13);
            airoplane_typeLabel.TabIndex = 5;
            airoplane_typeLabel.Text = "Airoplane type:";
            // 
            // flightReservationSystemDataSet
            // 
            this.flightReservationSystemDataSet.DataSetName = "FlightReservationSystemDataSet";
            this.flightReservationSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // airplaneBindingSource
            // 
            this.airplaneBindingSource.DataMember = "Airplane";
            this.airplaneBindingSource.DataSource = this.flightReservationSystemDataSet;
            // 
            // airplaneTableAdapter
            // 
            this.airplaneTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdminTableAdapter = null;
            this.tableAdapterManager.AirplaneTableAdapter = this.airplaneTableAdapter;
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
            // airplaneBindingNavigator
            // 
            this.airplaneBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.airplaneBindingNavigator.BindingSource = this.airplaneBindingSource;
            this.airplaneBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.airplaneBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.airplaneBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.airplaneBindingNavigatorSaveItem});
            this.airplaneBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.airplaneBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.airplaneBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.airplaneBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.airplaneBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.airplaneBindingNavigator.Name = "airplaneBindingNavigator";
            this.airplaneBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.airplaneBindingNavigator.Size = new System.Drawing.Size(752, 25);
            this.airplaneBindingNavigator.TabIndex = 0;
            this.airplaneBindingNavigator.Text = "bindingNavigator1";
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
            // airplaneBindingNavigatorSaveItem
            // 
            this.airplaneBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.airplaneBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("airplaneBindingNavigatorSaveItem.Image")));
            this.airplaneBindingNavigatorSaveItem.Name = "airplaneBindingNavigatorSaveItem";
            this.airplaneBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.airplaneBindingNavigatorSaveItem.Text = "Save Data";
            this.airplaneBindingNavigatorSaveItem.Click += new System.EventHandler(this.airplaneBindingNavigatorSaveItem_Click);
            // 
            // seatsTextBox
            // 
            this.seatsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.airplaneBindingSource, "Seats", true));
            this.seatsTextBox.Location = new System.Drawing.Point(109, 49);
            this.seatsTextBox.Name = "seatsTextBox";
            this.seatsTextBox.Size = new System.Drawing.Size(100, 20);
            this.seatsTextBox.TabIndex = 2;
            this.seatsTextBox.TextChanged += new System.EventHandler(this.seatsTextBox_TextChanged);
            // 
            // reg_numTextBox
            // 
            this.reg_numTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.airplaneBindingSource, "Reg_num", true));
            this.reg_numTextBox.Location = new System.Drawing.Point(109, 75);
            this.reg_numTextBox.Name = "reg_numTextBox";
            this.reg_numTextBox.Size = new System.Drawing.Size(100, 20);
            this.reg_numTextBox.TabIndex = 4;
            // 
            // airoplane_typeTextBox
            // 
            this.airoplane_typeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.airplaneBindingSource, "Airoplane_type", true));
            this.airoplane_typeTextBox.Location = new System.Drawing.Point(109, 101);
            this.airoplane_typeTextBox.Name = "airoplane_typeTextBox";
            this.airoplane_typeTextBox.Size = new System.Drawing.Size(100, 20);
            this.airoplane_typeTextBox.TabIndex = 6;
            // 
            // airplaneDataGridView
            // 
            this.airplaneDataGridView.AutoGenerateColumns = false;
            this.airplaneDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.airplaneDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.airplaneDataGridView.DataSource = this.airplaneBindingSource;
            this.airplaneDataGridView.Location = new System.Drawing.Point(328, 12);
            this.airplaneDataGridView.Name = "airplaneDataGridView";
            this.airplaneDataGridView.Size = new System.Drawing.Size(343, 220);
            this.airplaneDataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Seats";
            this.dataGridViewTextBoxColumn1.HeaderText = "Seats";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Reg_num";
            this.dataGridViewTextBoxColumn2.HeaderText = "Reg_num";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Airoplane_type";
            this.dataGridViewTextBoxColumn3.HeaderText = "Airoplane_type";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(85, 144);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(150, 173);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(85, 202);
            this.button4.Name = "button4";
            this.button4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(459, 238);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 12;
            this.button5.Text = "Show Data";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Airplanes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 310);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.airplaneDataGridView);
            this.Controls.Add(seatsLabel);
            this.Controls.Add(this.seatsTextBox);
            this.Controls.Add(reg_numLabel);
            this.Controls.Add(this.reg_numTextBox);
            this.Controls.Add(airoplane_typeLabel);
            this.Controls.Add(this.airoplane_typeTextBox);
            this.Controls.Add(this.airplaneBindingNavigator);
            this.Name = "Airplanes";
            this.Text = "Airplanes";
            this.Load += new System.EventHandler(this.Airplanes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.flightReservationSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airplaneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airplaneBindingNavigator)).EndInit();
            this.airplaneBindingNavigator.ResumeLayout(false);
            this.airplaneBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.airplaneDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlightReservationSystemDataSet flightReservationSystemDataSet;
        private System.Windows.Forms.BindingSource airplaneBindingSource;
        private FlightReservationSystemDataSetTableAdapters.AirplaneTableAdapter airplaneTableAdapter;
        private FlightReservationSystemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator airplaneBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton airplaneBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox seatsTextBox;
        private System.Windows.Forms.TextBox reg_numTextBox;
        private System.Windows.Forms.TextBox airoplane_typeTextBox;
        private System.Windows.Forms.DataGridView airplaneDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}