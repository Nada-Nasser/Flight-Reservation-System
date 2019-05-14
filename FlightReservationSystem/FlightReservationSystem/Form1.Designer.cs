namespace FlightReservationSystem
{
    partial class LoginForm
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
            this.LoginBtn = new System.Windows.Forms.Button();
            this.SignUpBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NameTxtBox = new System.Windows.Forms.TextBox();
            this.IDTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(179, 135);
            this.LoginBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(156, 41);
            this.LoginBtn.TabIndex = 0;
            this.LoginBtn.Text = "Sign in";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // SignUpBtn
            // 
            this.SignUpBtn.Location = new System.Drawing.Point(179, 238);
            this.SignUpBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SignUpBtn.Name = "SignUpBtn";
            this.SignUpBtn.Size = new System.Drawing.Size(156, 35);
            this.SignUpBtn.TabIndex = 1;
            this.SignUpBtn.Text = "Sign up";
            this.SignUpBtn.UseVisualStyleBackColor = true;
            this.SignUpBtn.Click += new System.EventHandler(this.SignUpBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "User Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "User Passport :";
            // 
            // NameTxtBox
            // 
            this.NameTxtBox.Location = new System.Drawing.Point(179, 51);
            this.NameTxtBox.Name = "NameTxtBox";
            this.NameTxtBox.Size = new System.Drawing.Size(156, 24);
            this.NameTxtBox.TabIndex = 4;
            // 
            // IDTxtBox
            // 
            this.IDTxtBox.Location = new System.Drawing.Point(179, 91);
            this.IDTxtBox.Name = "IDTxtBox";
            this.IDTxtBox.Size = new System.Drawing.Size(156, 24);
            this.IDTxtBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "You don\'t have an account yet?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sign up and Create a new one.. ";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 356);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IDTxtBox);
            this.Controls.Add(this.NameTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SignUpBtn);
            this.Controls.Add(this.LoginBtn);
            this.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LoginForm";
            this.Text = "Login Flight reservation system";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Button SignUpBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameTxtBox;
        private System.Windows.Forms.TextBox IDTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

