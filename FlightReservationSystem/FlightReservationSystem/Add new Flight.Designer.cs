namespace FlightReservationSystem
{
    partial class Add_new_Flight
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
            this.flight_ReservationDataSet = new FlightReservationSystem.Flight_ReservationDataSet();
            this.fLIGHTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fLIGHTTableAdapter = new FlightReservationSystem.Flight_ReservationDataSetTableAdapters.FLIGHTTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.DateTimeTB = new System.Windows.Forms.TextBox();
            this.DestTB = new System.Windows.Forms.TextBox();
            this.PilotIDTB = new System.Windows.Forms.TextBox();
            this.nStopsTB = new System.Windows.Forms.TextBox();
            this.DurationTB = new System.Windows.Forms.TextBox();
            this.SourceTB = new System.Windows.Forms.TextBox();
            this.FlightIDTB = new System.Windows.Forms.TextBox();
            this.nSeatsTB = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FLIGHT_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DEPARTURE_CITY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESTINATION_CITY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fLIGHTBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.fKFLYFLYFLIGHTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fLYTableAdapter = new FlightReservationSystem.Flight_ReservationDataSetTableAdapters.FLYTableAdapter();
            this.fLIGHTBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.AddFlightBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.label10 = new System.Windows.Forms.Label();
            this.BackBtn = new System.Windows.Forms.Button();
            this.dATEANDTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESTINATIONCITYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pILOTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nSTOPSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dURATIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dEPARTURECITYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fLIGHTNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAVAILABLESEATSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.flight_ReservationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fLIGHTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fLIGHTBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKFLYFLYFLIGHTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fLIGHTBindingSource1)).BeginInit();
            this.SuspendLayout();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label1.Location = new System.Drawing.Point(91, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date and Time :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label2.Location = new System.Drawing.Point(111, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Destination :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label3.Location = new System.Drawing.Point(133, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pilot ID :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label4.Location = new System.Drawing.Point(79, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "Number of Stops :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label5.Location = new System.Drawing.Point(126, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 14);
            this.label5.TabIndex = 4;
            this.label5.Text = "Duration :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label6.Location = new System.Drawing.Point(134, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 14);
            this.label6.TabIndex = 5;
            this.label6.Text = "Source :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label7.Location = new System.Drawing.Point(120, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 14);
            this.label7.TabIndex = 6;
            this.label7.Text = "Fligth No. :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label8.Location = new System.Drawing.Point(5, 276);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(182, 14);
            this.label8.TabIndex = 7;
            this.label8.Text = "Number of the Available seats  :";
            // 
            // DateTimeTB
            // 
            this.DateTimeTB.Location = new System.Drawing.Point(214, 66);
            this.DateTimeTB.Name = "DateTimeTB";
            this.DateTimeTB.Size = new System.Drawing.Size(194, 20);
            this.DateTimeTB.TabIndex = 8;
            // 
            // DestTB
            // 
            this.DestTB.Location = new System.Drawing.Point(214, 98);
            this.DestTB.Name = "DestTB";
            this.DestTB.Size = new System.Drawing.Size(194, 20);
            this.DestTB.TabIndex = 9;
            // 
            // PilotIDTB
            // 
            this.PilotIDTB.Location = new System.Drawing.Point(214, 131);
            this.PilotIDTB.Name = "PilotIDTB";
            this.PilotIDTB.Size = new System.Drawing.Size(194, 20);
            this.PilotIDTB.TabIndex = 10;
            // 
            // nStopsTB
            // 
            this.nStopsTB.Location = new System.Drawing.Point(214, 160);
            this.nStopsTB.Name = "nStopsTB";
            this.nStopsTB.Size = new System.Drawing.Size(194, 20);
            this.nStopsTB.TabIndex = 11;
            // 
            // DurationTB
            // 
            this.DurationTB.Location = new System.Drawing.Point(214, 186);
            this.DurationTB.Name = "DurationTB";
            this.DurationTB.Size = new System.Drawing.Size(194, 20);
            this.DurationTB.TabIndex = 12;
            // 
            // SourceTB
            // 
            this.SourceTB.Location = new System.Drawing.Point(214, 215);
            this.SourceTB.Name = "SourceTB";
            this.SourceTB.Size = new System.Drawing.Size(194, 20);
            this.SourceTB.TabIndex = 13;
            // 
            // FlightIDTB
            // 
            this.FlightIDTB.Location = new System.Drawing.Point(214, 246);
            this.FlightIDTB.Name = "FlightIDTB";
            this.FlightIDTB.Size = new System.Drawing.Size(194, 20);
            this.FlightIDTB.TabIndex = 14;
            // 
            // nSeatsTB
            // 
            this.nSeatsTB.Location = new System.Drawing.Point(214, 274);
            this.nSeatsTB.Name = "nSeatsTB";
            this.nSeatsTB.Size = new System.Drawing.Size(194, 20);
            this.nSeatsTB.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FLIGHT_NO,
            this.DEPARTURE_CITY,
            this.DESTINATION_CITY,
            this.dATEANDTIMEDataGridViewTextBoxColumn,
            this.dESTINATIONCITYDataGridViewTextBoxColumn,
            this.pILOTIDDataGridViewTextBoxColumn,
            this.nSTOPSDataGridViewTextBoxColumn,
            this.dURATIONDataGridViewTextBoxColumn,
            this.dEPARTURECITYDataGridViewTextBoxColumn,
            this.fLIGHTNODataGridViewTextBoxColumn,
            this.nAVAILABLESEATSDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.fLIGHTBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(426, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(339, 247);
            this.dataGridView1.TabIndex = 16;
            // 
            // FLIGHT_NO
            // 
            this.FLIGHT_NO.DataPropertyName = "FLIGHT_NO";
            this.FLIGHT_NO.HeaderText = "Flight no.";
            this.FLIGHT_NO.Name = "FLIGHT_NO";
            this.FLIGHT_NO.ReadOnly = true;
            // 
            // DEPARTURE_CITY
            // 
            this.DEPARTURE_CITY.DataPropertyName = "DEPARTURE_CITY";
            this.DEPARTURE_CITY.HeaderText = "Source city";
            this.DEPARTURE_CITY.Name = "DEPARTURE_CITY";
            this.DEPARTURE_CITY.ReadOnly = true;
            // 
            // DESTINATION_CITY
            // 
            this.DESTINATION_CITY.DataPropertyName = "DESTINATION_CITY";
            this.DESTINATION_CITY.HeaderText = "Destination city";
            this.DESTINATION_CITY.Name = "DESTINATION_CITY";
            this.DESTINATION_CITY.ReadOnly = true;
            // 
            // fLIGHTBindingSource2
            // 
            this.fLIGHTBindingSource2.DataMember = "FLIGHT";
            this.fLIGHTBindingSource2.DataSource = this.flight_ReservationDataSet;
            // 
            // fKFLYFLYFLIGHTBindingSource
            // 
            this.fKFLYFLYFLIGHTBindingSource.DataMember = "FK_FLY_FLY_FLIGHT";
            this.fKFLYFLYFLIGHTBindingSource.DataSource = this.fLIGHTBindingSource;
            // 
            // fLYTableAdapter
            // 
            this.fLYTableAdapter.ClearBeforeFill = true;
            // 
            // fLIGHTBindingSource1
            // 
            this.fLIGHTBindingSource1.DataMember = "FLIGHT";
            this.fLIGHTBindingSource1.DataSource = this.flight_ReservationDataSet;
            // 
            // AddFlightBtn
            // 
            this.AddFlightBtn.Font = new System.Drawing.Font("Tahoma", 10F);
            this.AddFlightBtn.Location = new System.Drawing.Point(214, 318);
            this.AddFlightBtn.Name = "AddFlightBtn";
            this.AddFlightBtn.Size = new System.Drawing.Size(194, 31);
            this.AddFlightBtn.TabIndex = 17;
            this.AddFlightBtn.Text = "Add Flight";
            this.AddFlightBtn.UseVisualStyleBackColor = true;
            this.AddFlightBtn.Click += new System.EventHandler(this.AddFlightBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label9.Location = new System.Drawing.Point(4, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(264, 22);
            this.label9.TabIndex = 18;
            this.label9.Text = "Write new Data for new Fligth : ";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(777, 370);
            this.shapeContainer1.TabIndex = 19;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = -6;
            this.lineShape1.X2 = 769;
            this.lineShape1.Y1 = 41;
            this.lineShape1.Y2 = 41;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label10.Location = new System.Drawing.Point(464, 323);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(267, 22);
            this.label10.TabIndex = 20;
            this.label10.Text = "Table of all Flights Exist till now ";
            // 
            // BackBtn
            // 
            this.BackBtn.Font = new System.Drawing.Font("Tahoma", 10F);
            this.BackBtn.Location = new System.Drawing.Point(8, 318);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(194, 31);
            this.BackBtn.TabIndex = 21;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
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
            // pILOTIDDataGridViewTextBoxColumn
            // 
            this.pILOTIDDataGridViewTextBoxColumn.DataPropertyName = "PILOT_ID";
            this.pILOTIDDataGridViewTextBoxColumn.HeaderText = "PILOT_ID";
            this.pILOTIDDataGridViewTextBoxColumn.Name = "pILOTIDDataGridViewTextBoxColumn";
            this.pILOTIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nSTOPSDataGridViewTextBoxColumn
            // 
            this.nSTOPSDataGridViewTextBoxColumn.DataPropertyName = "N_STOPS";
            this.nSTOPSDataGridViewTextBoxColumn.HeaderText = "N_STOPS";
            this.nSTOPSDataGridViewTextBoxColumn.Name = "nSTOPSDataGridViewTextBoxColumn";
            this.nSTOPSDataGridViewTextBoxColumn.ReadOnly = true;
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
            // nAVAILABLESEATSDataGridViewTextBoxColumn
            // 
            this.nAVAILABLESEATSDataGridViewTextBoxColumn.DataPropertyName = "N_AVAILABLESEATS";
            this.nAVAILABLESEATSDataGridViewTextBoxColumn.HeaderText = "N_AVAILABLESEATS";
            this.nAVAILABLESEATSDataGridViewTextBoxColumn.Name = "nAVAILABLESEATSDataGridViewTextBoxColumn";
            this.nAVAILABLESEATSDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Add_new_Flight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 370);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.AddFlightBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.nSeatsTB);
            this.Controls.Add(this.FlightIDTB);
            this.Controls.Add(this.SourceTB);
            this.Controls.Add(this.DurationTB);
            this.Controls.Add(this.nStopsTB);
            this.Controls.Add(this.PilotIDTB);
            this.Controls.Add(this.DestTB);
            this.Controls.Add(this.DateTimeTB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "Add_new_Flight";
            this.Text = "Add_new_Flight";
            this.Load += new System.EventHandler(this.Add_new_Flight_Load);
            ((System.ComponentModel.ISupportInitialize)(this.flight_ReservationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fLIGHTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fLIGHTBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKFLYFLYFLIGHTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fLIGHTBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Flight_ReservationDataSet flight_ReservationDataSet;
        private System.Windows.Forms.BindingSource fLIGHTBindingSource;
        private Flight_ReservationDataSetTableAdapters.FLIGHTTableAdapter fLIGHTTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox DateTimeTB;
        private System.Windows.Forms.TextBox DestTB;
        private System.Windows.Forms.TextBox PilotIDTB;
        private System.Windows.Forms.TextBox nStopsTB;
        private System.Windows.Forms.TextBox DurationTB;
        private System.Windows.Forms.TextBox SourceTB;
        private System.Windows.Forms.TextBox FlightIDTB;
        private System.Windows.Forms.TextBox nSeatsTB;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource fKFLYFLYFLIGHTBindingSource;
        private Flight_ReservationDataSetTableAdapters.FLYTableAdapter fLYTableAdapter;
        private System.Windows.Forms.BindingSource fLIGHTBindingSource2;
        private System.Windows.Forms.BindingSource fLIGHTBindingSource1;
        private System.Windows.Forms.Button AddFlightBtn;
        private System.Windows.Forms.Label label9;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FLIGHT_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DEPARTURE_CITY;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESTINATION_CITY;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATEANDTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESTINATIONCITYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pILOTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nSTOPSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dURATIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dEPARTURECITYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fLIGHTNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAVAILABLESEATSDataGridViewTextBoxColumn;
    }
}