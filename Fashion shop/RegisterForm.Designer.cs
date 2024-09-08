namespace Fashion_shop
{
    partial class RegisterForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttion_signin = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.show_password_register = new System.Windows.Forms.CheckBox();
            this.button_signup = new System.Windows.Forms.Button();
            this.password_register = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.username_register = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.password_register_comfirm = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.exit_sign_in = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(908, -44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "X";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.buttion_signin);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-58, -55);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(597, 604);
            this.panel1.TabIndex = 10;
            // 
            // buttion_signin
            // 
            this.buttion_signin.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttion_signin.Location = new System.Drawing.Point(219, 521);
            this.buttion_signin.Margin = new System.Windows.Forms.Padding(4);
            this.buttion_signin.Name = "buttion_signin";
            this.buttion_signin.Size = new System.Drawing.Size(163, 34);
            this.buttion_signin.TabIndex = 0;
            this.buttion_signin.Text = "SIGN IN";
            this.buttion_signin.UseVisualStyleBackColor = true;
            this.buttion_signin.Click += new System.EventHandler(this.button_signin_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(140, 470);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(336, 35);
            this.label5.TabIndex = 9;
            this.label5.Text = "Already have an account?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Desktop;
            this.pictureBox1.Image = global::Fashion_shop.Properties.Resources.R_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(-62, 40);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(712, 611);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // show_password_register
            // 
            this.show_password_register.AutoSize = true;
            this.show_password_register.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.show_password_register.Location = new System.Drawing.Point(575, 368);
            this.show_password_register.Name = "show_password_register";
            this.show_password_register.Size = new System.Drawing.Size(162, 27);
            this.show_password_register.TabIndex = 18;
            this.show_password_register.Text = "Show Password";
            this.show_password_register.UseVisualStyleBackColor = true;
            this.show_password_register.CheckedChanged += new System.EventHandler(this.show_password_register_CheckedChanged);
            // 
            // button_signup
            // 
            this.button_signup.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_signup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_signup.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_signup.Location = new System.Drawing.Point(575, 418);
            this.button_signup.Margin = new System.Windows.Forms.Padding(4);
            this.button_signup.Name = "button_signup";
            this.button_signup.Size = new System.Drawing.Size(147, 37);
            this.button_signup.TabIndex = 17;
            this.button_signup.Text = "SIGNUP";
            this.button_signup.UseVisualStyleBackColor = false;
            // 
            // password_register
            // 
            this.password_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.password_register.Location = new System.Drawing.Point(575, 235);
            this.password_register.Margin = new System.Windows.Forms.Padding(4);
            this.password_register.Name = "password_register";
            this.password_register.PasswordChar = '*';
            this.password_register.Size = new System.Drawing.Size(401, 34);
            this.password_register.TabIndex = 16;
            this.password_register.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(571, 208);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 23);
            this.label4.TabIndex = 15;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(571, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "Username";
            // 
            // username_register
            // 
            this.username_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.username_register.Location = new System.Drawing.Point(575, 139);
            this.username_register.Margin = new System.Windows.Forms.Padding(4);
            this.username_register.Name = "username_register";
            this.username_register.Size = new System.Drawing.Size(401, 30);
            this.username_register.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(569, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 35);
            this.label2.TabIndex = 12;
            this.label2.Text = "REGISTER";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(973, -39);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "X";
            // 
            // password_register_comfirm
            // 
            this.password_register_comfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.password_register_comfirm.Location = new System.Drawing.Point(575, 327);
            this.password_register_comfirm.Margin = new System.Windows.Forms.Padding(4);
            this.password_register_comfirm.Name = "password_register_comfirm";
            this.password_register_comfirm.PasswordChar = '*';
            this.password_register_comfirm.Size = new System.Drawing.Size(401, 34);
            this.password_register_comfirm.TabIndex = 20;
            this.password_register_comfirm.TabStop = false;
            this.password_register_comfirm.TextChanged += new System.EventHandler(this.password_register_comfirm_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(571, 300);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 23);
            this.label7.TabIndex = 19;
            this.label7.Text = "Comfirm Password";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // exit_sign_in
            // 
            this.exit_sign_in.AutoSize = true;
            this.exit_sign_in.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.exit_sign_in.Location = new System.Drawing.Point(972, 9);
            this.exit_sign_in.Name = "exit_sign_in";
            this.exit_sign_in.Size = new System.Drawing.Size(27, 25);
            this.exit_sign_in.TabIndex = 21;
            this.exit_sign_in.Text = "X";
            this.exit_sign_in.Click += new System.EventHandler(this.label8_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 542);
            this.Controls.Add(this.exit_sign_in);
            this.Controls.Add(this.password_register_comfirm);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.show_password_register);
            this.Controls.Add(this.button_signup);
            this.Controls.Add(this.password_register);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.username_register);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttion_signin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox show_password_register;
        private System.Windows.Forms.Button button_signup;
        private System.Windows.Forms.TextBox password_register;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox username_register;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox password_register_comfirm;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label exit_sign_in;
    }
}