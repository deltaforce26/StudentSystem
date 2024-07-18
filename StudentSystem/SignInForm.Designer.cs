namespace StudentSystem
{
    partial class SignInForm
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
            label_fname = new Label();
            textBox_fname = new TextBox();
            textBox_lname = new TextBox();
            label_lname = new Label();
            button_signin = new Button();
            textBox_password = new TextBox();
            label_password = new Label();
            SuspendLayout();
            // 
            // label_fname
            // 
            label_fname.AutoSize = true;
            label_fname.Location = new Point(101, 86);
            label_fname.Name = "label_fname";
            label_fname.Size = new Size(75, 20);
            label_fname.TabIndex = 0;
            label_fname.Text = "first name";
            // 
            // textBox_fname
            // 
            textBox_fname.Location = new Point(184, 79);
            textBox_fname.Name = "textBox_fname";
            textBox_fname.Size = new Size(125, 27);
            textBox_fname.TabIndex = 1;
            // 
            // textBox_lname
            // 
            textBox_lname.Location = new Point(184, 164);
            textBox_lname.Name = "textBox_lname";
            textBox_lname.Size = new Size(125, 27);
            textBox_lname.TabIndex = 2;
            // 
            // label_lname
            // 
            label_lname.AutoSize = true;
            label_lname.Location = new Point(101, 171);
            label_lname.Name = "label_lname";
            label_lname.Size = new Size(73, 20);
            label_lname.TabIndex = 3;
            label_lname.Text = "last name";
            // 
            // button_signin
            // 
            button_signin.Location = new Point(184, 317);
            button_signin.Name = "button_signin";
            button_signin.Size = new Size(94, 29);
            button_signin.TabIndex = 4;
            button_signin.Text = "sign in";
            button_signin.UseVisualStyleBackColor = true;
            button_signin.Click += button_signin_Click;
            // 
            // textBox_password
            // 
            textBox_password.Location = new Point(184, 248);
            textBox_password.Name = "textBox_password";
            textBox_password.Size = new Size(125, 27);
            textBox_password.TabIndex = 5;
            // 
            // label_password
            // 
            label_password.AutoSize = true;
            label_password.Location = new Point(101, 255);
            label_password.Name = "label_password";
            label_password.Size = new Size(72, 20);
            label_password.TabIndex = 6;
            label_password.Text = "password";
            // 
            // SignInForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(493, 450);
            Controls.Add(label_password);
            Controls.Add(textBox_password);
            Controls.Add(button_signin);
            Controls.Add(label_lname);
            Controls.Add(textBox_lname);
            Controls.Add(textBox_fname);
            Controls.Add(label_fname);
            Name = "SignInForm";
            Text = "SignInForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_fname;
        private TextBox textBox_fname;
        private TextBox textBox_lname;
        private Label label_lname;
        private Button button_signin;
        private TextBox textBox_password;
        private Label label_password;
    }
}