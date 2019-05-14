namespace FlightReservationSystem
{
    partial class All_Tickets
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pASSENGERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sEATNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tICKETNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLASSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fLIGHTNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pILOTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tICKETBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flight_ReservationDataSet = new FlightReservationSystem.Flight_ReservationDataSet();
            this.tICKETTableAdapter = new FlightReservationSystem.Flight_ReservationDataSetTableAdapters.TICKETTableAdapter();
            this.BackBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tICKETBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flight_ReservationDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pASSENGERIDDataGridViewTextBoxColumn,
            this.eMAILDataGridViewTextBoxColumn,
            this.sEATNODataGridViewTextBoxColumn,
            this.tICKETNODataGridViewTextBoxColumn,
            this.cLASSDataGridViewTextBoxColumn,
            this.fLIGHTNODataGridViewTextBoxColumn,
            this.pILOTIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tICKETBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(723, 273);
            this.dataGridView1.TabIndex = 0;
            // 
            // pASSENGERIDDataGridViewTextBoxColumn
            // 
            this.pASSENGERIDDataGridViewTextBoxColumn.DataPropertyName = "PASSENGER_ID";
            this.pASSENGERIDDataGridViewTextBoxColumn.HeaderText = "PASSENGER_ID";
            this.pASSENGERIDDataGridViewTextBoxColumn.Name = "pASSENGERIDDataGridViewTextBoxColumn";
            // 
            // eMAILDataGridViewTextBoxColumn
            // 
            this.eMAILDataGridViewTextBoxColumn.DataPropertyName = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.HeaderText = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.Name = "eMAILDataGridViewTextBoxColumn";
            // 
            // sEATNODataGridViewTextBoxColumn
            // 
            this.sEATNODataGridViewTextBoxColumn.DataPropertyName = "SEAT_NO";
            this.sEATNODataGridViewTextBoxColumn.HeaderText = "SEAT_NO";
            this.sEATNODataGridViewTextBoxColumn.Name = "sEATNODataGridViewTextBoxColumn";
            // 
            // tICKETNODataGridViewTextBoxColumn
            // 
            this.tICKETNODataGridViewTextBoxColumn.DataPropertyName = "TICKET_NO";
            this.tICKETNODataGridViewTextBoxColumn.HeaderText = "TICKET_NO";
            this.tICKETNODataGridViewTextBoxColumn.Name = "tICKETNODataGridViewTextBoxColumn";
            // 
            // cLASSDataGridViewTextBoxColumn
            // 
            this.cLASSDataGridViewTextBoxColumn.DataPropertyName = "CLASS";
            this.cLASSDataGridViewTextBoxColumn.HeaderText = "CLASS";
            this.cLASSDataGridViewTextBoxColumn.Name = "cLASSDataGridViewTextBoxColumn";
            // 
            // fLIGHTNODataGridViewTextBoxColumn
            // 
            this.fLIGHTNODataGridViewTextBoxColumn.DataPropertyName = "FLIGHT_NO";
            this.fLIGHTNODataGridViewTextBoxColumn.HeaderText = "FLIGHT_NO";
            this.fLIGHTNODataGridViewTextBoxColumn.Name = "fLIGHTNODataGridViewTextBoxColumn";
            // 
            // pILOTIDDataGridViewTextBoxColumn
            // 
            this.pILOTIDDataGridViewTextBoxColumn.DataPropertyName = "PILOT_ID";
            this.pILOTIDDataGridViewTextBoxColumn.HeaderText = "PILOT_ID";
            this.pILOTIDDataGridViewTextBoxColumn.Name = "pILOTIDDataGridViewTextBoxColumn";
            // 
            // tICKETBindingSource
            // 
            this.tICKETBindingSource.DataMember = "TICKET";
            this.tICKETBindingSource.DataSource = this.flight_ReservationDataSet;
            // 
            // flight_ReservationDataSet
            // 
            this.flight_ReservationDataSet.DataSetName = "Flight_ReservationDataSet";
            this.flight_ReservationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tICKETTableAdapter
            // 
            this.tICKETTableAdapter.ClearBeforeFill = true;
            // 
            // BackBtn
            // 
            this.BackBtn.Font = new System.Drawing.Font("Tahoma", 9F);
            this.BackBtn.Location = new System.Drawing.Point(579, 311);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(156, 32);
            this.BackBtn.TabIndex = 1;
            this.BackBtn.Text = "Back To my page";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // All_Tickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 363);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "All_Tickets";
            this.Text = "All_Tickets";
            this.Load += new System.EventHandler(this.All_Tickets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tICKETBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flight_ReservationDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Flight_ReservationDataSet flight_ReservationDataSet;
        private System.Windows.Forms.BindingSource tICKETBindingSource;
        private Flight_ReservationDataSetTableAdapters.TICKETTableAdapter tICKETTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pASSENGERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEATNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tICKETNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLASSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fLIGHTNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pILOTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button BackBtn;
    }
}