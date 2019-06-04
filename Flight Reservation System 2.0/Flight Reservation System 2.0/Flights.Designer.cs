namespace Flight_Reservation_System_2._0
{
    partial class Flights
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Flights));
            System.Windows.Forms.Label fromLabel;
            System.Windows.Forms.Label toLabel;
            System.Windows.Forms.Label dep_dateLabel;
            System.Windows.Forms.Label arrive_dateLabel;
            System.Windows.Forms.Label flight_idLabel;
            System.Windows.Forms.Label classLabel;
            System.Windows.Forms.Label arrive_timeLabel;
            System.Windows.Forms.Label dep_timeLabel;
            System.Windows.Forms.Label airlinesLabel;
            this.flightReservationSystemDataSet = new Flight_Reservation_System_2._0.FlightReservationSystemDataSet();
            this.flightBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flightTableAdapter = new Flight_Reservation_System_2._0.FlightReservationSystemDataSetTableAdapters.FlightTableAdapter();
            this.tableAdapterManager = new Flight_Reservation_System_2._0.FlightReservationSystemDataSetTableAdapters.TableAdapterManager();
            this.flightBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.flightBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.fromTextBox = new System.Windows.Forms.TextBox();
            this.toTextBox = new System.Windows.Forms.TextBox();
            this.dep_dateTextBox = new System.Windows.Forms.TextBox();
            this.arrive_dateTextBox = new System.Windows.Forms.TextBox();
            this.flight_idTextBox = new System.Windows.Forms.TextBox();
            this.classTextBox = new System.Windows.Forms.TextBox();
            this.arrive_timeTextBox = new System.Windows.Forms.TextBox();
            this.dep_timeTextBox = new System.Windows.Forms.TextBox();
            this.airlinesTextBox = new System.Windows.Forms.TextBox();
            this.flightDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            fromLabel = new System.Windows.Forms.Label();
            toLabel = new System.Windows.Forms.Label();
            dep_dateLabel = new System.Windows.Forms.Label();
            arrive_dateLabel = new System.Windows.Forms.Label();
            flight_idLabel = new System.Windows.Forms.Label();
            classLabel = new System.Windows.Forms.Label();
            arrive_timeLabel = new System.Windows.Forms.Label();
            dep_timeLabel = new System.Windows.Forms.Label();
            airlinesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.flightReservationSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightBindingNavigator)).BeginInit();
            this.flightBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flightDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // flightReservationSystemDataSet
            // 
            this.flightReservationSystemDataSet.DataSetName = "FlightReservationSystemDataSet";
            this.flightReservationSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // flightBindingSource
            // 
            this.flightBindingSource.DataMember = "Flight";
            this.flightBindingSource.DataSource = this.flightReservationSystemDataSet;
            // 
            // flightTableAdapter
            // 
            this.flightTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdminTableAdapter = null;
            this.tableAdapterManager.AirplaneTableAdapter = null;
            this.tableAdapterManager.AirportTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Booking_officeTableAdapter = null;
            this.tableAdapterManager.FlightTableAdapter = this.flightTableAdapter;
            this.tableAdapterManager.Has_BookingTableAdapter = null;
            this.tableAdapterManager.Land_onTableAdapter = null;
            this.tableAdapterManager.PassengerTableAdapter = null;
            this.tableAdapterManager.reservesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Flight_Reservation_System_2._0.FlightReservationSystemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // flightBindingNavigator
            // 
            this.flightBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.flightBindingNavigator.BindingSource = this.flightBindingSource;
            this.flightBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.flightBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.flightBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.flightBindingNavigatorSaveItem});
            this.flightBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.flightBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.flightBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.flightBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.flightBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.flightBindingNavigator.Name = "flightBindingNavigator";
            this.flightBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.flightBindingNavigator.Size = new System.Drawing.Size(970, 25);
            this.flightBindingNavigator.TabIndex = 0;
            this.flightBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // flightBindingNavigatorSaveItem
            // 
            this.flightBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.flightBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("flightBindingNavigatorSaveItem.Image")));
            this.flightBindingNavigatorSaveItem.Name = "flightBindingNavigatorSaveItem";
            this.flightBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.flightBindingNavigatorSaveItem.Text = "Save Data";
            this.flightBindingNavigatorSaveItem.Click += new System.EventHandler(this.flightBindingNavigatorSaveItem_Click_1);
            // 
            // fromLabel
            // 
            fromLabel.AutoSize = true;
            fromLabel.Location = new System.Drawing.Point(12, 25);
            fromLabel.Name = "fromLabel";
            fromLabel.Size = new System.Drawing.Size(33, 13);
            fromLabel.TabIndex = 1;
            fromLabel.Text = "From:";
            // 
            // fromTextBox
            // 
            this.fromTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.flightBindingSource, "From", true));
            this.fromTextBox.Location = new System.Drawing.Point(79, 22);
            this.fromTextBox.Name = "fromTextBox";
            this.fromTextBox.Size = new System.Drawing.Size(100, 20);
            this.fromTextBox.TabIndex = 2;
            this.fromTextBox.TextChanged += new System.EventHandler(this.fromTextBox_TextChanged);
            // 
            // toLabel
            // 
            toLabel.AutoSize = true;
            toLabel.Location = new System.Drawing.Point(12, 51);
            toLabel.Name = "toLabel";
            toLabel.Size = new System.Drawing.Size(23, 13);
            toLabel.TabIndex = 3;
            toLabel.Text = "To:";
            // 
            // toTextBox
            // 
            this.toTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.flightBindingSource, "To", true));
            this.toTextBox.Location = new System.Drawing.Point(79, 48);
            this.toTextBox.Name = "toTextBox";
            this.toTextBox.Size = new System.Drawing.Size(100, 20);
            this.toTextBox.TabIndex = 4;
            // 
            // dep_dateLabel
            // 
            dep_dateLabel.AutoSize = true;
            dep_dateLabel.Location = new System.Drawing.Point(12, 77);
            dep_dateLabel.Name = "dep_dateLabel";
            dep_dateLabel.Size = new System.Drawing.Size(54, 13);
            dep_dateLabel.TabIndex = 5;
            dep_dateLabel.Text = "Dep date:";
            // 
            // dep_dateTextBox
            // 
            this.dep_dateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.flightBindingSource, "Dep_date", true));
            this.dep_dateTextBox.Location = new System.Drawing.Point(79, 74);
            this.dep_dateTextBox.Name = "dep_dateTextBox";
            this.dep_dateTextBox.Size = new System.Drawing.Size(100, 20);
            this.dep_dateTextBox.TabIndex = 6;
            // 
            // arrive_dateLabel
            // 
            arrive_dateLabel.AutoSize = true;
            arrive_dateLabel.Location = new System.Drawing.Point(12, 103);
            arrive_dateLabel.Name = "arrive_dateLabel";
            arrive_dateLabel.Size = new System.Drawing.Size(61, 13);
            arrive_dateLabel.TabIndex = 7;
            arrive_dateLabel.Text = "Arrive date:";
            // 
            // arrive_dateTextBox
            // 
            this.arrive_dateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.flightBindingSource, "Arrive_date", true));
            this.arrive_dateTextBox.Location = new System.Drawing.Point(79, 100);
            this.arrive_dateTextBox.Name = "arrive_dateTextBox";
            this.arrive_dateTextBox.Size = new System.Drawing.Size(100, 20);
            this.arrive_dateTextBox.TabIndex = 8;
            // 
            // flight_idLabel
            // 
            flight_idLabel.AutoSize = true;
            flight_idLabel.Location = new System.Drawing.Point(12, 129);
            flight_idLabel.Name = "flight_idLabel";
            flight_idLabel.Size = new System.Drawing.Size(46, 13);
            flight_idLabel.TabIndex = 9;
            flight_idLabel.Text = "Flight id:";
            // 
            // flight_idTextBox
            // 
            this.flight_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.flightBindingSource, "Flight_id", true));
            this.flight_idTextBox.Location = new System.Drawing.Point(79, 126);
            this.flight_idTextBox.Name = "flight_idTextBox";
            this.flight_idTextBox.Size = new System.Drawing.Size(100, 20);
            this.flight_idTextBox.TabIndex = 10;
            // 
            // classLabel
            // 
            classLabel.AutoSize = true;
            classLabel.Location = new System.Drawing.Point(12, 155);
            classLabel.Name = "classLabel";
            classLabel.Size = new System.Drawing.Size(35, 13);
            classLabel.TabIndex = 11;
            classLabel.Text = "Class:";
            // 
            // classTextBox
            // 
            this.classTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.flightBindingSource, "Class", true));
            this.classTextBox.Location = new System.Drawing.Point(79, 152);
            this.classTextBox.Name = "classTextBox";
            this.classTextBox.Size = new System.Drawing.Size(100, 20);
            this.classTextBox.TabIndex = 12;
            // 
            // arrive_timeLabel
            // 
            arrive_timeLabel.AutoSize = true;
            arrive_timeLabel.Location = new System.Drawing.Point(12, 181);
            arrive_timeLabel.Name = "arrive_timeLabel";
            arrive_timeLabel.Size = new System.Drawing.Size(59, 13);
            arrive_timeLabel.TabIndex = 13;
            arrive_timeLabel.Text = "Arrive time:";
            // 
            // arrive_timeTextBox
            // 
            this.arrive_timeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.flightBindingSource, "Arrive_time", true));
            this.arrive_timeTextBox.Location = new System.Drawing.Point(79, 178);
            this.arrive_timeTextBox.Name = "arrive_timeTextBox";
            this.arrive_timeTextBox.Size = new System.Drawing.Size(100, 20);
            this.arrive_timeTextBox.TabIndex = 14;
            // 
            // dep_timeLabel
            // 
            dep_timeLabel.AutoSize = true;
            dep_timeLabel.Location = new System.Drawing.Point(12, 207);
            dep_timeLabel.Name = "dep_timeLabel";
            dep_timeLabel.Size = new System.Drawing.Size(52, 13);
            dep_timeLabel.TabIndex = 15;
            dep_timeLabel.Text = "Dep time:";
            // 
            // dep_timeTextBox
            // 
            this.dep_timeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.flightBindingSource, "Dep_time", true));
            this.dep_timeTextBox.Location = new System.Drawing.Point(79, 204);
            this.dep_timeTextBox.Name = "dep_timeTextBox";
            this.dep_timeTextBox.Size = new System.Drawing.Size(100, 20);
            this.dep_timeTextBox.TabIndex = 16;
            // 
            // airlinesLabel
            // 
            airlinesLabel.AutoSize = true;
            airlinesLabel.Location = new System.Drawing.Point(12, 233);
            airlinesLabel.Name = "airlinesLabel";
            airlinesLabel.Size = new System.Drawing.Size(43, 13);
            airlinesLabel.TabIndex = 17;
            airlinesLabel.Text = "Airlines:";
            // 
            // airlinesTextBox
            // 
            this.airlinesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.flightBindingSource, "Airlines", true));
            this.airlinesTextBox.Location = new System.Drawing.Point(79, 230);
            this.airlinesTextBox.Name = "airlinesTextBox";
            this.airlinesTextBox.Size = new System.Drawing.Size(100, 20);
            this.airlinesTextBox.TabIndex = 18;
            // 
            // flightDataGridView
            // 
            this.flightDataGridView.AutoGenerateColumns = false;
            this.flightDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.flightDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.flightDataGridView.DataSource = this.flightBindingSource;
            this.flightDataGridView.Location = new System.Drawing.Point(228, 25);
            this.flightDataGridView.Name = "flightDataGridView";
            this.flightDataGridView.Size = new System.Drawing.Size(651, 220);
            this.flightDataGridView.TabIndex = 19;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "From";
            this.dataGridViewTextBoxColumn1.HeaderText = "From";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "To";
            this.dataGridViewTextBoxColumn2.HeaderText = "To";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Dep_date";
            this.dataGridViewTextBoxColumn3.HeaderText = "Dep_date";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Arrive_date";
            this.dataGridViewTextBoxColumn4.HeaderText = "Arrive_date";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Flight_id";
            this.dataGridViewTextBoxColumn5.HeaderText = "Flight_id";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Class";
            this.dataGridViewTextBoxColumn6.HeaderText = "Class";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Arrive_time";
            this.dataGridViewTextBoxColumn7.HeaderText = "Arrive_time";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Dep_time";
            this.dataGridViewTextBoxColumn8.HeaderText = "Dep_time";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Airlines";
            this.dataGridViewTextBoxColumn9.HeaderText = "Airlines";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(509, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Show Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(872, 270);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(15, 269);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 22;
            this.button3.Text = "Add";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(130, 269);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 23;
            this.button4.Text = "Update";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(243, 269);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 24;
            this.button5.Text = "Delete";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Flights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 305);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flightDataGridView);
            this.Controls.Add(fromLabel);
            this.Controls.Add(this.fromTextBox);
            this.Controls.Add(toLabel);
            this.Controls.Add(this.toTextBox);
            this.Controls.Add(dep_dateLabel);
            this.Controls.Add(this.dep_dateTextBox);
            this.Controls.Add(arrive_dateLabel);
            this.Controls.Add(this.arrive_dateTextBox);
            this.Controls.Add(flight_idLabel);
            this.Controls.Add(this.flight_idTextBox);
            this.Controls.Add(classLabel);
            this.Controls.Add(this.classTextBox);
            this.Controls.Add(arrive_timeLabel);
            this.Controls.Add(this.arrive_timeTextBox);
            this.Controls.Add(dep_timeLabel);
            this.Controls.Add(this.dep_timeTextBox);
            this.Controls.Add(airlinesLabel);
            this.Controls.Add(this.airlinesTextBox);
            this.Controls.Add(this.flightBindingNavigator);
            this.Name = "Flights";
            this.Text = "Flights";
            this.Load += new System.EventHandler(this.Flights_Load);
            ((System.ComponentModel.ISupportInitialize)(this.flightReservationSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightBindingNavigator)).EndInit();
            this.flightBindingNavigator.ResumeLayout(false);
            this.flightBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flightDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlightReservationSystemDataSet flightReservationSystemDataSet;
        private System.Windows.Forms.BindingSource flightBindingSource;
        private FlightReservationSystemDataSetTableAdapters.FlightTableAdapter flightTableAdapter;
        private FlightReservationSystemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator flightBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton flightBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox fromTextBox;
        private System.Windows.Forms.TextBox toTextBox;
        private System.Windows.Forms.TextBox dep_dateTextBox;
        private System.Windows.Forms.TextBox arrive_dateTextBox;
        private System.Windows.Forms.TextBox flight_idTextBox;
        private System.Windows.Forms.TextBox classTextBox;
        private System.Windows.Forms.TextBox arrive_timeTextBox;
        private System.Windows.Forms.TextBox dep_timeTextBox;
        private System.Windows.Forms.TextBox airlinesTextBox;
        private System.Windows.Forms.DataGridView flightDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}