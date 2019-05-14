namespace FlightReservationSystem
{
    partial class Update_Flight
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
            this.flight_ReservationDataSet = new FlightReservationSystem.Flight_ReservationDataSet();
            this.fLIGHTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fLIGHTTableAdapter = new FlightReservationSystem.Flight_ReservationDataSetTableAdapters.FLIGHTTableAdapter();
            this.FLIGHT_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DEPARTURE_CITY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESTINATION_CITY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nSeatsTB = new System.Windows.Forms.TextBox();
            this.FlightIDTB = new System.Windows.Forms.TextBox();
            this.SourceTB = new System.Windows.Forms.TextBox();
            this.DurationTB = new System.Windows.Forms.TextBox();
            this.nStopsTB = new System.Windows.Forms.TextBox();
            this.PilotIDTB = new System.Windows.Forms.TextBox();
            this.DestTB = new System.Windows.Forms.TextBox();
            this.DateTimeTB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.BackBtn = new System.Windows.Forms.Button();
            this.AddFlightBtn = new System.Windows.Forms.Button();
            this.dATEANDTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESTINATIONCITYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pILOTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nSTOPSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dURATIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dEPARTURECITYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fLIGHTNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAVAILABLESEATSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.inIDTB = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Select = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flight_ReservationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fLIGHTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
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
            this.dataGridView1.DataSource = this.fLIGHTBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(436, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(344, 284);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // FLIGHT_NO
            // 
            this.FLIGHT_NO.DataPropertyName = "FLIGHT_NO";
            this.FLIGHT_NO.HeaderText = "FLIGHT NO";
            this.FLIGHT_NO.Name = "FLIGHT_NO";
            // 
            // DEPARTURE_CITY
            // 
            this.DEPARTURE_CITY.DataPropertyName = "DEPARTURE_CITY";
            this.DEPARTURE_CITY.HeaderText = "DEPARTURE CITY";
            this.DEPARTURE_CITY.Name = "DEPARTURE_CITY";
            // 
            // DESTINATION_CITY
            // 
            this.DESTINATION_CITY.DataPropertyName = "DESTINATION_CITY";
            this.DESTINATION_CITY.HeaderText = "DESTINATION CITY";
            this.DESTINATION_CITY.Name = "DESTINATION_CITY";
            // 
            // nSeatsTB
            // 
            this.nSeatsTB.Location = new System.Drawing.Point(212, 317);
            this.nSeatsTB.Name = "nSeatsTB";
            this.nSeatsTB.ReadOnly = true;
            this.nSeatsTB.Size = new System.Drawing.Size(194, 20);
            this.nSeatsTB.TabIndex = 31;
            // 
            // FlightIDTB
            // 
            this.FlightIDTB.Location = new System.Drawing.Point(212, 289);
            this.FlightIDTB.Name = "FlightIDTB";
            this.FlightIDTB.ReadOnly = true;
            this.FlightIDTB.Size = new System.Drawing.Size(194, 20);
            this.FlightIDTB.TabIndex = 30;
            // 
            // SourceTB
            // 
            this.SourceTB.Location = new System.Drawing.Point(212, 258);
            this.SourceTB.Name = "SourceTB";
            this.SourceTB.ReadOnly = true;
            this.SourceTB.Size = new System.Drawing.Size(194, 20);
            this.SourceTB.TabIndex = 29;
            // 
            // DurationTB
            // 
            this.DurationTB.Location = new System.Drawing.Point(212, 229);
            this.DurationTB.Name = "DurationTB";
            this.DurationTB.ReadOnly = true;
            this.DurationTB.Size = new System.Drawing.Size(194, 20);
            this.DurationTB.TabIndex = 28;
            // 
            // nStopsTB
            // 
            this.nStopsTB.Location = new System.Drawing.Point(212, 203);
            this.nStopsTB.Name = "nStopsTB";
            this.nStopsTB.ReadOnly = true;
            this.nStopsTB.Size = new System.Drawing.Size(194, 20);
            this.nStopsTB.TabIndex = 27;
            // 
            // PilotIDTB
            // 
            this.PilotIDTB.Location = new System.Drawing.Point(212, 174);
            this.PilotIDTB.Name = "PilotIDTB";
            this.PilotIDTB.ReadOnly = true;
            this.PilotIDTB.Size = new System.Drawing.Size(194, 20);
            this.PilotIDTB.TabIndex = 26;
            // 
            // DestTB
            // 
            this.DestTB.Location = new System.Drawing.Point(212, 141);
            this.DestTB.Name = "DestTB";
            this.DestTB.ReadOnly = true;
            this.DestTB.Size = new System.Drawing.Size(194, 20);
            this.DestTB.TabIndex = 25;
            // 
            // DateTimeTB
            // 
            this.DateTimeTB.Location = new System.Drawing.Point(212, 109);
            this.DateTimeTB.Name = "DateTimeTB";
            this.DateTimeTB.ReadOnly = true;
            this.DateTimeTB.Size = new System.Drawing.Size(194, 20);
            this.DateTimeTB.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label8.Location = new System.Drawing.Point(3, 319);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(182, 14);
            this.label8.TabIndex = 23;
            this.label8.Text = "Number of the Available seats  :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label7.Location = new System.Drawing.Point(118, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 14);
            this.label7.TabIndex = 22;
            this.label7.Text = "Fligth No. :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label6.Location = new System.Drawing.Point(132, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 14);
            this.label6.TabIndex = 21;
            this.label6.Text = "Source :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label5.Location = new System.Drawing.Point(124, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 14);
            this.label5.TabIndex = 20;
            this.label5.Text = "Duration :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label4.Location = new System.Drawing.Point(77, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 14);
            this.label4.TabIndex = 19;
            this.label4.Text = "Number of Stops :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label3.Location = new System.Drawing.Point(131, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 14);
            this.label3.TabIndex = 18;
            this.label3.Text = "Pilot ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label2.Location = new System.Drawing.Point(109, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 14);
            this.label2.TabIndex = 17;
            this.label2.Text = "Destination :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label1.Location = new System.Drawing.Point(89, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 14);
            this.label1.TabIndex = 16;
            this.label1.Text = "Date and Time :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label9.Location = new System.Drawing.Point(12, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(262, 22);
            this.label9.TabIndex = 32;
            this.label9.Text = "Write new Data for The Fligth : ";
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = -2;
            this.lineShape1.X2 = 814;
            this.lineShape1.Y1 = 47;
            this.lineShape1.Y2 = 47;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(801, 436);
            this.shapeContainer1.TabIndex = 33;
            this.shapeContainer1.TabStop = false;
            // 
            // BackBtn
            // 
            this.BackBtn.Font = new System.Drawing.Font("Tahoma", 10F);
            this.BackBtn.Location = new System.Drawing.Point(16, 352);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(194, 31);
            this.BackBtn.TabIndex = 35;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // AddFlightBtn
            // 
            this.AddFlightBtn.Font = new System.Drawing.Font("Tahoma", 10F);
            this.AddFlightBtn.Location = new System.Drawing.Point(222, 352);
            this.AddFlightBtn.Name = "AddFlightBtn";
            this.AddFlightBtn.Size = new System.Drawing.Size(194, 31);
            this.AddFlightBtn.TabIndex = 34;
            this.AddFlightBtn.Text = "Update Flight";
            this.AddFlightBtn.UseVisualStyleBackColor = true;
            this.AddFlightBtn.Click += new System.EventHandler(this.AddFlightBtn_Click);
            // 
            // dATEANDTIMEDataGridViewTextBoxColumn
            // 
            this.dATEANDTIMEDataGridViewTextBoxColumn.DataPropertyName = "DATE_AND_TIME";
            this.dATEANDTIMEDataGridViewTextBoxColumn.HeaderText = "DATE_AND_TIME";
            this.dATEANDTIMEDataGridViewTextBoxColumn.Name = "dATEANDTIMEDataGridViewTextBoxColumn";
            // 
            // dESTINATIONCITYDataGridViewTextBoxColumn
            // 
            this.dESTINATIONCITYDataGridViewTextBoxColumn.DataPropertyName = "DESTINATION_CITY";
            this.dESTINATIONCITYDataGridViewTextBoxColumn.HeaderText = "DESTINATION_CITY";
            this.dESTINATIONCITYDataGridViewTextBoxColumn.Name = "dESTINATIONCITYDataGridViewTextBoxColumn";
            // 
            // pILOTIDDataGridViewTextBoxColumn
            // 
            this.pILOTIDDataGridViewTextBoxColumn.DataPropertyName = "PILOT_ID";
            this.pILOTIDDataGridViewTextBoxColumn.HeaderText = "PILOT_ID";
            this.pILOTIDDataGridViewTextBoxColumn.Name = "pILOTIDDataGridViewTextBoxColumn";
            // 
            // nSTOPSDataGridViewTextBoxColumn
            // 
            this.nSTOPSDataGridViewTextBoxColumn.DataPropertyName = "N_STOPS";
            this.nSTOPSDataGridViewTextBoxColumn.HeaderText = "N_STOPS";
            this.nSTOPSDataGridViewTextBoxColumn.Name = "nSTOPSDataGridViewTextBoxColumn";
            // 
            // dURATIONDataGridViewTextBoxColumn
            // 
            this.dURATIONDataGridViewTextBoxColumn.DataPropertyName = "DURATION";
            this.dURATIONDataGridViewTextBoxColumn.HeaderText = "DURATION";
            this.dURATIONDataGridViewTextBoxColumn.Name = "dURATIONDataGridViewTextBoxColumn";
            // 
            // dEPARTURECITYDataGridViewTextBoxColumn
            // 
            this.dEPARTURECITYDataGridViewTextBoxColumn.DataPropertyName = "DEPARTURE_CITY";
            this.dEPARTURECITYDataGridViewTextBoxColumn.HeaderText = "DEPARTURE_CITY";
            this.dEPARTURECITYDataGridViewTextBoxColumn.Name = "dEPARTURECITYDataGridViewTextBoxColumn";
            // 
            // fLIGHTNODataGridViewTextBoxColumn
            // 
            this.fLIGHTNODataGridViewTextBoxColumn.DataPropertyName = "FLIGHT_NO";
            this.fLIGHTNODataGridViewTextBoxColumn.HeaderText = "FLIGHT_NO";
            this.fLIGHTNODataGridViewTextBoxColumn.Name = "fLIGHTNODataGridViewTextBoxColumn";
            // 
            // nAVAILABLESEATSDataGridViewTextBoxColumn
            // 
            this.nAVAILABLESEATSDataGridViewTextBoxColumn.DataPropertyName = "N_AVAILABLESEATS";
            this.nAVAILABLESEATSDataGridViewTextBoxColumn.HeaderText = "N_AVAILABLESEATS";
            this.nAVAILABLESEATSDataGridViewTextBoxColumn.Name = "nAVAILABLESEATSDataGridViewTextBoxColumn";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label10.Location = new System.Drawing.Point(12, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(393, 19);
            this.label10.TabIndex = 36;
            this.label10.Text = "Write the Flight No. you want to update its Data First: ";
            // 
            // inIDTB
            // 
            this.inIDTB.Location = new System.Drawing.Point(415, 15);
            this.inIDTB.Name = "inIDTB";
            this.inIDTB.Size = new System.Drawing.Size(194, 20);
            this.inIDTB.TabIndex = 37;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label11.Location = new System.Drawing.Point(468, 397);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(267, 22);
            this.label11.TabIndex = 38;
            this.label11.Text = "Table of all Flights Exist till now ";
            // 
            // Select
            // 
            this.Select.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Select.Location = new System.Drawing.Point(624, 12);
            this.Select.Name = "Select";
            this.Select.Size = new System.Drawing.Size(146, 23);
            this.Select.TabIndex = 39;
            this.Select.Text = "Select this Flight";
            this.Select.UseVisualStyleBackColor = true;
            this.Select.Click += new System.EventHandler(this.Select_Click);
            // 
            // Update_Flight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 436);
            this.Controls.Add(this.Select);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.inIDTB);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.AddFlightBtn);
            this.Controls.Add(this.label9);
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
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "Update_Flight";
            this.Text = "Update_Flight";
            this.Load += new System.EventHandler(this.Update_Flight_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flight_ReservationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fLIGHTBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Flight_ReservationDataSet flight_ReservationDataSet;
        private System.Windows.Forms.BindingSource fLIGHTBindingSource;
        private Flight_ReservationDataSetTableAdapters.FLIGHTTableAdapter fLIGHTTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn FLIGHT_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DEPARTURE_CITY;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESTINATION_CITY;
        private System.Windows.Forms.TextBox nSeatsTB;
        private System.Windows.Forms.TextBox FlightIDTB;
        private System.Windows.Forms.TextBox SourceTB;
        private System.Windows.Forms.TextBox DurationTB;
        private System.Windows.Forms.TextBox nStopsTB;
        private System.Windows.Forms.TextBox PilotIDTB;
        private System.Windows.Forms.TextBox DestTB;
        private System.Windows.Forms.TextBox DateTimeTB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATEANDTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESTINATIONCITYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pILOTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nSTOPSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dURATIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dEPARTURECITYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fLIGHTNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAVAILABLESEATSDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button AddFlightBtn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox inIDTB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button Select;
    }
}