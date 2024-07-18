namespace StudentSystem
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox_userName = new TextBox();
            textBox_password = new TextBox();
            button_login = new Button();
            label_userName = new Label();
            label_password = new Label();
            linkLabel_signup = new LinkLabel();
            SuspendLayout();
            // 
            // textBox_userName
            // 
            textBox_userName.Location = new Point(169, 77);
            textBox_userName.Name = "textBox_userName";
            textBox_userName.Size = new Size(165, 27);
            textBox_userName.TabIndex = 0;
            // 
            // textBox_password
            // 
            textBox_password.Location = new Point(169, 158);
            textBox_password.Name = "textBox_password";
            textBox_password.Size = new Size(165, 27);
            textBox_password.TabIndex = 1;
            // 
            // button_login
            // 
            button_login.Location = new Point(182, 245);
            button_login.Name = "button_login";
            button_login.Size = new Size(115, 29);
            button_login.TabIndex = 2;
            button_login.Text = "Login";
            button_login.UseVisualStyleBackColor = true;
            button_login.Click += button_login_Click;
            // 
            // label_userName
            // 
            label_userName.AutoSize = true;
            label_userName.Location = new Point(39, 77);
            label_userName.Name = "label_userName";
            label_userName.Size = new Size(77, 20);
            label_userName.TabIndex = 3;
            label_userName.Text = "user name";
            // 
            // label_password
            // 
            label_password.AutoSize = true;
            label_password.Location = new Point(44, 161);
            label_password.Name = "label_password";
            label_password.Size = new Size(72, 20);
            label_password.TabIndex = 4;
            label_password.Text = "password";
            // 
            // linkLabel_signup
            // 
            linkLabel_signup.AutoSize = true;
            linkLabel_signup.Location = new Point(358, 245);
            linkLabel_signup.Name = "linkLabel_signup";
            linkLabel_signup.Size = new Size(57, 20);
            linkLabel_signup.TabIndex = 5;
            linkLabel_signup.TabStop = true;
            linkLabel_signup.Text = "sign up";
            linkLabel_signup.LinkClicked += linkLabel_signup_LinkClicked;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 450);
            Controls.Add(linkLabel_signup);
            Controls.Add(label_password);
            Controls.Add(label_userName);
            Controls.Add(button_login);
            Controls.Add(textBox_password);
            Controls.Add(textBox_userName);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "loginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_userName;
        private TextBox textBox_password;
        private Button button_login;
        private Label label_userName;
        private Label label_password;
        private LinkLabel linkLabel_signup;
    }
}
