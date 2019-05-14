namespace FlightReservationSystem
{
    partial class AdmenForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.Namelbl = new System.Windows.Forms.Label();
            this.IDlbl = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.label2 = new System.Windows.Forms.Label();
            this.UpdateDataBtn = new System.Windows.Forms.Button();
            this.AddCraftBtn = new System.Windows.Forms.Button();
            this.UpdateCraftBtn = new System.Windows.Forms.Button();
            this.AddFlightBtn = new System.Windows.Forms.Button();
            this.UpdateFlightBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pASSENGERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tYPEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pASSENGERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flight_ReservationDataSet = new FlightReservationSystem.Flight_ReservationDataSet();
            this.pASSENGERTableAdapter = new FlightReservationSystem.Flight_ReservationDataSetTableAdapters.PASSENGERTableAdapter();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.showTickets = new System.Windows.Forms.Button();
            this.AddAdmin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.DeleteFlight = new System.Windows.Forms.Button();
            this.Delete_Craft = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pASSENGERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flight_ReservationDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.Location = new System.Drawing.Point(52, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your Name : ";
            // 
            // Namelbl
            // 
            this.Namelbl.AutoSize = true;
            this.Namelbl.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Namelbl.Location = new System.Drawing.Point(156, 9);
            this.Namelbl.Name = "Namelbl";
            this.Namelbl.Size = new System.Drawing.Size(43, 17);
            this.Namelbl.TabIndex = 1;
            this.Namelbl.Text = "NAME";
            // 
            // IDlbl
            // 
            this.IDlbl.AutoSize = true;
            this.IDlbl.Font = new System.Drawing.Font("Tahoma", 10F);
            this.IDlbl.Location = new System.Drawing.Point(576, 9);
            this.IDlbl.Name = "IDlbl";
            this.IDlbl.Size = new System.Drawing.Size(61, 17);
            this.IDlbl.TabIndex = 2;
            this.IDlbl.Text = "Passport";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(716, 446);
            this.shapeContainer1.TabIndex = 3;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 2;
            this.lineShape1.X2 = 709;
            this.lineShape1.Y1 = 39;
            this.lineShape1.Y2 = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.Location = new System.Drawing.Point(405, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Your Passport Number :";
            // 
            // UpdateDataBtn
            // 
            this.UpdateDataBtn.Font = new System.Drawing.Font("Tahoma", 9F);
            this.UpdateDataBtn.Location = new System.Drawing.Point(35, 54);
            this.UpdateDataBtn.Name = "UpdateDataBtn";
            this.UpdateDataBtn.Size = new System.Drawing.Size(168, 31);
            this.UpdateDataBtn.TabIndex = 5;
            this.UpdateDataBtn.Text = "Update Your Data";
            this.UpdateDataBtn.UseVisualStyleBackColor = true;
            this.UpdateDataBtn.Click += new System.EventHandler(this.UpdateDataBtn_Click);
            // 
            // AddCraftBtn
            // 
            this.AddCraftBtn.Font = new System.Drawing.Font("Tahoma", 9F);
            this.AddCraftBtn.Location = new System.Drawing.Point(35, 91);
            this.AddCraftBtn.Name = "AddCraftBtn";
            this.AddCraftBtn.Size = new System.Drawing.Size(168, 31);
            this.AddCraftBtn.TabIndex = 6;
            this.AddCraftBtn.Text = "Adding a new Aircraft";
            this.AddCraftBtn.UseVisualStyleBackColor = true;
            this.AddCraftBtn.Click += new System.EventHandler(this.AddCraftBtn_Click);
            // 
            // UpdateCraftBtn
            // 
            this.UpdateCraftBtn.Font = new System.Drawing.Font("Tahoma", 9F);
            this.UpdateCraftBtn.Location = new System.Drawing.Point(35, 129);
            this.UpdateCraftBtn.Name = "UpdateCraftBtn";
            this.UpdateCraftBtn.Size = new System.Drawing.Size(168, 31);
            this.UpdateCraftBtn.TabIndex = 7;
            this.UpdateCraftBtn.Text = "Update an Aircraft details";
            this.UpdateCraftBtn.UseVisualStyleBackColor = true;
            this.UpdateCraftBtn.Click += new System.EventHandler(this.UpdateCraftBtn_Click);
            // 
            // AddFlightBtn
            // 
            this.AddFlightBtn.Font = new System.Drawing.Font("Tahoma", 9F);
            this.AddFlightBtn.Location = new System.Drawing.Point(35, 166);
            this.AddFlightBtn.Name = "AddFlightBtn";
            this.AddFlightBtn.Size = new System.Drawing.Size(168, 31);
            this.AddFlightBtn.TabIndex = 8;
            this.AddFlightBtn.Text = "Adding a new Flight";
            this.AddFlightBtn.UseVisualStyleBackColor = true;
            this.AddFlightBtn.Click += new System.EventHandler(this.AddFlightBtn_Click);
            // 
            // UpdateFlightBtn
            // 
            this.UpdateFlightBtn.Font = new System.Drawing.Font("Tahoma", 9F);
            this.UpdateFlightBtn.Location = new System.Drawing.Point(35, 204);
            this.UpdateFlightBtn.Name = "UpdateFlightBtn";
            this.UpdateFlightBtn.Size = new System.Drawing.Size(168, 31);
            this.UpdateFlightBtn.TabIndex = 9;
            this.UpdateFlightBtn.Text = "Update Flight Details";
            this.UpdateFlightBtn.UseVisualStyleBackColor = true;
            this.UpdateFlightBtn.Click += new System.EventHandler(this.UpdateFlightBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pASSENGERIDDataGridViewTextBoxColumn,
            this.eMAILDataGridViewTextBoxColumn,
            this.nAMEDataGridViewTextBoxColumn,
            this.tYPEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pASSENGERBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(239, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(442, 263);
            this.dataGridView1.TabIndex = 10;
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
            // nAMEDataGridViewTextBoxColumn
            // 
            this.nAMEDataGridViewTextBoxColumn.DataPropertyName = "NAME";
            this.nAMEDataGridViewTextBoxColumn.HeaderText = "NAME";
            this.nAMEDataGridViewTextBoxColumn.Name = "nAMEDataGridViewTextBoxColumn";
            // 
            // tYPEDataGridViewTextBoxColumn
            // 
            this.tYPEDataGridViewTextBoxColumn.DataPropertyName = "TYPE";
            this.tYPEDataGridViewTextBoxColumn.HeaderText = "TYPE";
            this.tYPEDataGridViewTextBoxColumn.Name = "tYPEDataGridViewTextBoxColumn";
            // 
            // pASSENGERBindingSource
            // 
            this.pASSENGERBindingSource.DataMember = "PASSENGER";
            this.pASSENGERBindingSource.DataSource = this.flight_ReservationDataSet;
            // 
            // flight_ReservationDataSet
            // 
            this.flight_ReservationDataSet.DataSetName = "Flight_ReservationDataSet";
            this.flight_ReservationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pASSENGERTableAdapter
            // 
            this.pASSENGERTableAdapter.ClearBeforeFill = true;
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.Font = new System.Drawing.Font("Tahoma", 9F);
            this.LogoutBtn.Location = new System.Drawing.Point(31, 403);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(168, 31);
            this.LogoutBtn.TabIndex = 11;
            this.LogoutBtn.Text = "Logout";
            this.LogoutBtn.UseVisualStyleBackColor = true;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // showTickets
            // 
            this.showTickets.Font = new System.Drawing.Font("Tahoma", 9F);
            this.showTickets.Location = new System.Drawing.Point(35, 246);
            this.showTickets.Name = "showTickets";
            this.showTickets.Size = new System.Drawing.Size(168, 31);
            this.showTickets.TabIndex = 12;
            this.showTickets.Text = "Show All Tickets";
            this.showTickets.UseVisualStyleBackColor = true;
            this.showTickets.Click += new System.EventHandler(this.showTickets_Click);
            // 
            // AddAdmin
            // 
            this.AddAdmin.Font = new System.Drawing.Font("Tahoma", 9F);
            this.AddAdmin.Location = new System.Drawing.Point(35, 289);
            this.AddAdmin.Name = "AddAdmin";
            this.AddAdmin.Size = new System.Drawing.Size(168, 31);
            this.AddAdmin.TabIndex = 13;
            this.AddAdmin.Text = "Add new Admin";
            this.AddAdmin.UseVisualStyleBackColor = true;
            this.AddAdmin.Click += new System.EventHandler(this.AddAdmin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label3.Location = new System.Drawing.Point(209, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(503, 22);
            this.label3.TabIndex = 14;
            this.label3.Text = "List of all Clients and Admins that you add and edit there info.";
            // 
            // DeleteFlight
            // 
            this.DeleteFlight.Location = new System.Drawing.Point(35, 330);
            this.DeleteFlight.Name = "DeleteFlight";
            this.DeleteFlight.Size = new System.Drawing.Size(164, 35);
            this.DeleteFlight.TabIndex = 15;
            this.DeleteFlight.Text = "Delete Flight";
            this.DeleteFlight.UseVisualStyleBackColor = true;
            this.DeleteFlight.Click += new System.EventHandler(this.DeeleteFlight_Click);
            // 
            // Delete_Craft
            // 
            this.Delete_Craft.Location = new System.Drawing.Point(35, 372);
            this.Delete_Craft.Name = "Delete_Craft";
            this.Delete_Craft.Size = new System.Drawing.Size(164, 23);
            this.Delete_Craft.TabIndex = 16;
            this.Delete_Craft.Text = "Delete Craft";
            this.Delete_Craft.UseVisualStyleBackColor = true;
            this.Delete_Craft.Click += new System.EventHandler(this.Delete_Craft_Click);
            // 
            // AdmenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 446);
            this.Controls.Add(this.Delete_Craft);
            this.Controls.Add(this.DeleteFlight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AddAdmin);
            this.Controls.Add(this.showTickets);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.UpdateFlightBtn);
            this.Controls.Add(this.AddFlightBtn);
            this.Controls.Add(this.UpdateCraftBtn);
            this.Controls.Add(this.AddCraftBtn);
            this.Controls.Add(this.UpdateDataBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IDlbl);
            this.Controls.Add(this.Namelbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "AdmenForm";
            this.Text = "AdmenForm";
            this.Load += new System.EventHandler(this.AdmenForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pASSENGERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flight_ReservationDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Namelbl;
        private System.Windows.Forms.Label IDlbl;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button UpdateDataBtn;
        private System.Windows.Forms.Button AddCraftBtn;
        private System.Windows.Forms.Button UpdateCraftBtn;
        private System.Windows.Forms.Button AddFlightBtn;
        private System.Windows.Forms.Button UpdateFlightBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Flight_ReservationDataSet flight_ReservationDataSet;
        private System.Windows.Forms.BindingSource pASSENGERBindingSource;
        private Flight_ReservationDataSetTableAdapters.PASSENGERTableAdapter pASSENGERTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pASSENGERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tYPEDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Button showTickets;
        private System.Windows.Forms.Button AddAdmin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button DeleteFlight;
        private System.Windows.Forms.Button Delete_Craft;
    }
}