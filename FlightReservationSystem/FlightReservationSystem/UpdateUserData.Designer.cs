namespace FlightReservationSystem
{
    partial class UpdateUserData
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
            this.Done = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NameTxtBox = new System.Windows.Forms.TextBox();
            this.IDTxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BackBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Done
            // 
            this.Done.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Done.Location = new System.Drawing.Point(207, 172);
            this.Done.Name = "Done";
            this.Done.Size = new System.Drawing.Size(106, 39);
            this.Done.TabIndex = 0;
            this.Done.Text = "Update";
            this.Done.UseVisualStyleBackColor = true;
            this.Done.Click += new System.EventHandler(this.Done_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 18);
            this.label3.TabIndex = 3;
            // 
            // NameTxtBox
            // 
            this.NameTxtBox.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTxtBox.Location = new System.Drawing.Point(141, 68);
            this.NameTxtBox.Name = "NameTxtBox";
            this.NameTxtBox.Size = new System.Drawing.Size(172, 26);
            this.NameTxtBox.TabIndex = 4;
            this.NameTxtBox.TextChanged += new System.EventHandler(this.NameTxtBox_TextChanged);
            // 
            // IDTxtBox
            // 
            this.IDTxtBox.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDTxtBox.Location = new System.Drawing.Point(141, 111);
            this.IDTxtBox.Name = "IDTxtBox";
            this.IDTxtBox.Size = new System.Drawing.Size(172, 26);
            this.IDTxtBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(280, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Write your New Data ( Name / Email ) :- ";
            // 
            // BackBtn
            // 
            this.BackBtn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.Location = new System.Drawing.Point(100, 172);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(90, 39);
            this.BackBtn.TabIndex = 7;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // UpdateUserData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.IDTxtBox);
            this.Controls.Add(this.NameTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Done);
            this.Name = "UpdateUserData";
            this.Text = "UpdateUserData";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Done;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NameTxtBox;
        private System.Windows.Forms.TextBox IDTxtBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BackBtn;
    }
}