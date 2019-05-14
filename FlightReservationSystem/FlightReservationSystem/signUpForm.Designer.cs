namespace FlightReservationSystem
{
    partial class signUpForm
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
            this.DoneBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EmailTxtBox = new System.Windows.Forms.TextBox();
            this.IDTxtBox = new System.Windows.Forms.TextBox();
            this.NameTxtBox = new System.Windows.Forms.TextBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DoneBtn
            // 
            this.DoneBtn.Location = new System.Drawing.Point(191, 210);
            this.DoneBtn.Name = "DoneBtn";
            this.DoneBtn.Size = new System.Drawing.Size(75, 23);
            this.DoneBtn.TabIndex = 0;
            this.DoneBtn.Text = "Done";
            this.DoneBtn.UseVisualStyleBackColor = true;
            this.DoneBtn.Click += new System.EventHandler(this.DoneBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label1.Location = new System.Drawing.Point(75, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Name : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label2.Location = new System.Drawing.Point(78, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Passport Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label3.Location = new System.Drawing.Point(78, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 4;
            // 
            // EmailTxtBox
            // 
            this.EmailTxtBox.Location = new System.Drawing.Point(191, 149);
            this.EmailTxtBox.Name = "EmailTxtBox";
            this.EmailTxtBox.Size = new System.Drawing.Size(146, 20);
            this.EmailTxtBox.TabIndex = 5;
            // 
            // IDTxtBox
            // 
            this.IDTxtBox.Location = new System.Drawing.Point(191, 114);
            this.IDTxtBox.Name = "IDTxtBox";
            this.IDTxtBox.Size = new System.Drawing.Size(146, 20);
            this.IDTxtBox.TabIndex = 6;
            // 
            // NameTxtBox
            // 
            this.NameTxtBox.Location = new System.Drawing.Point(191, 73);
            this.NameTxtBox.Name = "NameTxtBox";
            this.NameTxtBox.Size = new System.Drawing.Size(146, 20);
            this.NameTxtBox.TabIndex = 7;
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(176, 250);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(111, 23);
            this.backBtn.TabIndex = 8;
            this.backBtn.Text = "Back to Login";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // signUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 336);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.NameTxtBox);
            this.Controls.Add(this.IDTxtBox);
            this.Controls.Add(this.EmailTxtBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DoneBtn);
            this.Name = "signUpForm";
            this.Text = "signUpForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DoneBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox EmailTxtBox;
        private System.Windows.Forms.TextBox IDTxtBox;
        private System.Windows.Forms.TextBox NameTxtBox;
        private System.Windows.Forms.Button backBtn;
    }
}