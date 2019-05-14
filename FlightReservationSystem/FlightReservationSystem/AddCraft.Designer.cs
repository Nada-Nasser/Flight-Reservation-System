namespace FlightReservationSystem
{
    partial class AddCraft
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ModelTxtBox = new System.Windows.Forms.TextBox();
            this.IDTxtBox = new System.Windows.Forms.TextBox();
            this.CNameTxtBox = new System.Windows.Forms.TextBox();
            this.nPassTxtBox = new System.Windows.Forms.TextBox();
            this.MYearTxtBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.COMPANY_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aIRCOMPANYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flight_ReservationDataSet = new FlightReservationSystem.Flight_ReservationDataSet();
            this.aIRCOMPANYTableAdapter = new FlightReservationSystem.Flight_ReservationDataSetTableAdapters.AIRCOMPANYTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.cOMPANYNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lOCATIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BackBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aIRCOMPANYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flight_ReservationDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label1.Location = new System.Drawing.Point(102, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Model :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label2.Location = new System.Drawing.Point(90, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Plane ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label3.Location = new System.Drawing.Point(58, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Company Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label4.Location = new System.Drawing.Point(23, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "number of Passengers :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label5.Location = new System.Drawing.Point(77, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 14);
            this.label5.TabIndex = 4;
            this.label5.Text = "Model Year :";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.button1.Location = new System.Drawing.Point(170, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ModelTxtBox
            // 
            this.ModelTxtBox.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ModelTxtBox.Location = new System.Drawing.Point(170, 52);
            this.ModelTxtBox.Name = "ModelTxtBox";
            this.ModelTxtBox.Size = new System.Drawing.Size(174, 22);
            this.ModelTxtBox.TabIndex = 6;
            // 
            // IDTxtBox
            // 
            this.IDTxtBox.Font = new System.Drawing.Font("Tahoma", 9F);
            this.IDTxtBox.Location = new System.Drawing.Point(170, 84);
            this.IDTxtBox.Name = "IDTxtBox";
            this.IDTxtBox.Size = new System.Drawing.Size(174, 22);
            this.IDTxtBox.TabIndex = 7;
            // 
            // CNameTxtBox
            // 
            this.CNameTxtBox.Font = new System.Drawing.Font("Tahoma", 9F);
            this.CNameTxtBox.Location = new System.Drawing.Point(170, 111);
            this.CNameTxtBox.Name = "CNameTxtBox";
            this.CNameTxtBox.Size = new System.Drawing.Size(174, 22);
            this.CNameTxtBox.TabIndex = 8;
            // 
            // nPassTxtBox
            // 
            this.nPassTxtBox.Font = new System.Drawing.Font("Tahoma", 9F);
            this.nPassTxtBox.Location = new System.Drawing.Point(170, 141);
            this.nPassTxtBox.Name = "nPassTxtBox";
            this.nPassTxtBox.Size = new System.Drawing.Size(174, 22);
            this.nPassTxtBox.TabIndex = 9;
            // 
            // MYearTxtBox
            // 
            this.MYearTxtBox.Font = new System.Drawing.Font("Tahoma", 9F);
            this.MYearTxtBox.Location = new System.Drawing.Point(170, 172);
            this.MYearTxtBox.Name = "MYearTxtBox";
            this.MYearTxtBox.Size = new System.Drawing.Size(174, 22);
            this.MYearTxtBox.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COMPANY_NAME,
            this.cOMPANYNAMEDataGridViewTextBoxColumn,
            this.lOCATIONDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.aIRCOMPANYBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(372, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(145, 142);
            this.dataGridView1.TabIndex = 11;
            // 
            // COMPANY_NAME
            // 
            this.COMPANY_NAME.DataPropertyName = "COMPANY_NAME";
            this.COMPANY_NAME.HeaderText = "Company Name";
            this.COMPANY_NAME.Name = "COMPANY_NAME";
            this.COMPANY_NAME.ReadOnly = true;
            // 
            // aIRCOMPANYBindingSource
            // 
            this.aIRCOMPANYBindingSource.DataMember = "AIRCOMPANY";
            this.aIRCOMPANYBindingSource.DataSource = this.flight_ReservationDataSet;
            // 
            // flight_ReservationDataSet
            // 
            this.flight_ReservationDataSet.DataSetName = "Flight_ReservationDataSet";
            this.flight_ReservationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aIRCOMPANYTableAdapter
            // 
            this.aIRCOMPANYTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label6.Location = new System.Drawing.Point(355, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Names of all aircraft companies ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label7.Location = new System.Drawing.Point(358, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "that you can choose from..";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label8.Location = new System.Drawing.Point(8, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(304, 22);
            this.label8.TabIndex = 14;
            this.label8.Text = "Write new data for the new aircraft : ";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(565, 276);
            this.shapeContainer1.TabIndex = 15;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = -2;
            this.lineShape1.X2 = 567;
            this.lineShape1.Y1 = 37;
            this.lineShape1.Y2 = 37;
            // 
            // cOMPANYNAMEDataGridViewTextBoxColumn
            // 
            this.cOMPANYNAMEDataGridViewTextBoxColumn.DataPropertyName = "COMPANY_NAME";
            this.cOMPANYNAMEDataGridViewTextBoxColumn.HeaderText = "COMPANY_NAME";
            this.cOMPANYNAMEDataGridViewTextBoxColumn.Name = "cOMPANYNAMEDataGridViewTextBoxColumn";
            this.cOMPANYNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lOCATIONDataGridViewTextBoxColumn
            // 
            this.lOCATIONDataGridViewTextBoxColumn.DataPropertyName = "LOCATION";
            this.lOCATIONDataGridViewTextBoxColumn.HeaderText = "LOCATION";
            this.lOCATIONDataGridViewTextBoxColumn.Name = "lOCATIONDataGridViewTextBoxColumn";
            this.lOCATIONDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // BackBtn
            // 
            this.BackBtn.Font = new System.Drawing.Font("Tahoma", 10F);
            this.BackBtn.Location = new System.Drawing.Point(26, 207);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(123, 34);
            this.BackBtn.TabIndex = 16;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // AddCraft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 276);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.MYearTxtBox);
            this.Controls.Add(this.nPassTxtBox);
            this.Controls.Add(this.CNameTxtBox);
            this.Controls.Add(this.IDTxtBox);
            this.Controls.Add(this.ModelTxtBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "AddCraft";
            this.Text = "AddCraft";
            this.Load += new System.EventHandler(this.AddCraft_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aIRCOMPANYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flight_ReservationDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ModelTxtBox;
        private System.Windows.Forms.TextBox IDTxtBox;
        private System.Windows.Forms.TextBox CNameTxtBox;
        private System.Windows.Forms.TextBox nPassTxtBox;
        private System.Windows.Forms.TextBox MYearTxtBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Flight_ReservationDataSet flight_ReservationDataSet;
        private System.Windows.Forms.BindingSource aIRCOMPANYBindingSource;
        private Flight_ReservationDataSetTableAdapters.AIRCOMPANYTableAdapter aIRCOMPANYTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn COMPANY_NAME;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOMPANYNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lOCATIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button BackBtn;
    }
}