namespace FlightReservationSystem
{
    partial class DeleteFlight
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FIDTB = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.flight_ReservationDataSet = new FlightReservationSystem.Flight_ReservationDataSet();
            this.fLIGHTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fLIGHTTableAdapter = new FlightReservationSystem.Flight_ReservationDataSetTableAdapters.FLIGHTTableAdapter();
            this.dATEANDTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESTINATIONCITYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dURATIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dEPARTURECITYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fLIGHTNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flight_ReservationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fLIGHTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(151, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Delete Flight";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Flight ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FIDTB
            // 
            this.FIDTB.Location = new System.Drawing.Point(101, 126);
            this.FIDTB.Name = "FIDTB";
            this.FIDTB.Size = new System.Drawing.Size(121, 20);
            this.FIDTB.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dATEANDTIMEDataGridViewTextBoxColumn,
            this.dESTINATIONCITYDataGridViewTextBoxColumn,
            this.dURATIONDataGridViewTextBoxColumn,
            this.dEPARTURECITYDataGridViewTextBoxColumn,
            this.fLIGHTNODataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.fLIGHTBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(278, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(541, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // flight_ReservationDataSet
            // 
            this.flight_ReservationDataSet.DataSetName = "Flight_ReservationDataSet";
            this.flight_ReservationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fLIGHTBindingSource
            // 
            this.fLIGHTBindingSource.DataMember = "FLIGHT";
            this.fLIGHTBindingSource.DataSource = this.flight_ReservationDataSet;
            // 
            // fLIGHTTableAdapter
            // 
            this.fLIGHTTableAdapter.ClearBeforeFill = true;
            // 
            // dATEANDTIMEDataGridViewTextBoxColumn
            // 
            this.dATEANDTIMEDataGridViewTextBoxColumn.DataPropertyName = "DATE_AND_TIME";
            this.dATEANDTIMEDataGridViewTextBoxColumn.HeaderText = "DATE_AND_TIME";
            this.dATEANDTIMEDataGridViewTextBoxColumn.Name = "dATEANDTIMEDataGridViewTextBoxColumn";
            this.dATEANDTIMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dESTINATIONCITYDataGridViewTextBoxColumn
            // 
            this.dESTINATIONCITYDataGridViewTextBoxColumn.DataPropertyName = "DESTINATION_CITY";
            this.dESTINATIONCITYDataGridViewTextBoxColumn.HeaderText = "DESTINATION_CITY";
            this.dESTINATIONCITYDataGridViewTextBoxColumn.Name = "dESTINATIONCITYDataGridViewTextBoxColumn";
            this.dESTINATIONCITYDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dURATIONDataGridViewTextBoxColumn
            // 
            this.dURATIONDataGridViewTextBoxColumn.DataPropertyName = "DURATION";
            this.dURATIONDataGridViewTextBoxColumn.HeaderText = "DURATION";
            this.dURATIONDataGridViewTextBoxColumn.Name = "dURATIONDataGridViewTextBoxColumn";
            this.dURATIONDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dEPARTURECITYDataGridViewTextBoxColumn
            // 
            this.dEPARTURECITYDataGridViewTextBoxColumn.DataPropertyName = "DEPARTURE_CITY";
            this.dEPARTURECITYDataGridViewTextBoxColumn.HeaderText = "DEPARTURE_CITY";
            this.dEPARTURECITYDataGridViewTextBoxColumn.Name = "dEPARTURECITYDataGridViewTextBoxColumn";
            this.dEPARTURECITYDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fLIGHTNODataGridViewTextBoxColumn
            // 
            this.fLIGHTNODataGridViewTextBoxColumn.DataPropertyName = "FLIGHT_NO";
            this.fLIGHTNODataGridViewTextBoxColumn.HeaderText = "FLIGHT_NO";
            this.fLIGHTNODataGridViewTextBoxColumn.Name = "fLIGHTNODataGridViewTextBoxColumn";
            this.fLIGHTNODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(38, 193);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 4;
            this.Back.Text = "back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // DeleteFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 261);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.FIDTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "DeleteFlight";
            this.Text = "DeleteFlight";
            this.Load += new System.EventHandler(this.DeleteFlight_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flight_ReservationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fLIGHTBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FIDTB;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Flight_ReservationDataSet flight_ReservationDataSet;
        private System.Windows.Forms.BindingSource fLIGHTBindingSource;
        private Flight_ReservationDataSetTableAdapters.FLIGHTTableAdapter fLIGHTTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATEANDTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESTINATIONCITYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dURATIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dEPARTURECITYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fLIGHTNODataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Back;
    }
}