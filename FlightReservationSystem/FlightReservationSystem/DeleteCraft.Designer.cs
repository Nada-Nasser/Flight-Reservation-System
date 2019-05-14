namespace FlightReservationSystem
{
    partial class DeleteCraft
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
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.flight_ReservationDataSet = new FlightReservationSystem.Flight_ReservationDataSet();
            this.aIRCRAFTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aIRCRAFTTableAdapter = new FlightReservationSystem.Flight_ReservationDataSetTableAdapters.AIRCRAFTTableAdapter();
            this.mODELDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pLANEIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOMPANYNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.PIDTB = new System.Windows.Forms.TextBox();
            this.Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flight_ReservationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aIRCRAFTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(126, 203);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteBtn.TabIndex = 0;
            this.DeleteBtn.Text = "Delete Craft";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mODELDataGridViewTextBoxColumn,
            this.pLANEIDDataGridViewTextBoxColumn,
            this.cOMPANYNAMEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.aIRCRAFTBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(243, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(341, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // flight_ReservationDataSet
            // 
            this.flight_ReservationDataSet.DataSetName = "Flight_ReservationDataSet";
            this.flight_ReservationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aIRCRAFTBindingSource
            // 
            this.aIRCRAFTBindingSource.DataMember = "AIRCRAFT";
            this.aIRCRAFTBindingSource.DataSource = this.flight_ReservationDataSet;
            // 
            // aIRCRAFTTableAdapter
            // 
            this.aIRCRAFTTableAdapter.ClearBeforeFill = true;
            // 
            // mODELDataGridViewTextBoxColumn
            // 
            this.mODELDataGridViewTextBoxColumn.DataPropertyName = "MODEL";
            this.mODELDataGridViewTextBoxColumn.HeaderText = "MODEL";
            this.mODELDataGridViewTextBoxColumn.Name = "mODELDataGridViewTextBoxColumn";
            this.mODELDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pLANEIDDataGridViewTextBoxColumn
            // 
            this.pLANEIDDataGridViewTextBoxColumn.DataPropertyName = "PLANE_ID";
            this.pLANEIDDataGridViewTextBoxColumn.HeaderText = "PLANE_ID";
            this.pLANEIDDataGridViewTextBoxColumn.Name = "pLANEIDDataGridViewTextBoxColumn";
            this.pLANEIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cOMPANYNAMEDataGridViewTextBoxColumn
            // 
            this.cOMPANYNAMEDataGridViewTextBoxColumn.DataPropertyName = "COMPANY_NAME";
            this.cOMPANYNAMEDataGridViewTextBoxColumn.HeaderText = "COMPANY_NAME";
            this.cOMPANYNAMEDataGridViewTextBoxColumn.Name = "cOMPANYNAMEDataGridViewTextBoxColumn";
            this.cOMPANYNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Plane ID";
            // 
            // PIDTB
            // 
            this.PIDTB.Location = new System.Drawing.Point(101, 76);
            this.PIDTB.Name = "PIDTB";
            this.PIDTB.Size = new System.Drawing.Size(100, 20);
            this.PIDTB.TabIndex = 3;
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(32, 203);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 4;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // DeleteCraft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 261);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.PIDTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.DeleteBtn);
            this.Name = "DeleteCraft";
            this.Text = "DeleteCraft";
            this.Load += new System.EventHandler(this.DeleteCraft_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flight_ReservationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aIRCRAFTBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Flight_ReservationDataSet flight_ReservationDataSet;
        private System.Windows.Forms.BindingSource aIRCRAFTBindingSource;
        private Flight_ReservationDataSetTableAdapters.AIRCRAFTTableAdapter aIRCRAFTTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mODELDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pLANEIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOMPANYNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PIDTB;
        private System.Windows.Forms.Button Back;
    }
}