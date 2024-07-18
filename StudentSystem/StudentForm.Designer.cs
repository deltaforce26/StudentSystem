namespace StudentSystem
{
    partial class StudentForm
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
            label_welcome = new Label();
            label_st_debt = new Label();
            label_st_name = new Label();
            label_debt = new Label();
            textBox_enterc_name = new TextBox();
            label_signToCourse = new Label();
            button_signToCourse = new Button();
            SuspendLayout();
            // 
            // label_welcome
            // 
            label_welcome.AutoSize = true;
            label_welcome.Location = new Point(250, 30);
            label_welcome.Name = "label_welcome";
            label_welcome.Size = new Size(69, 20);
            label_welcome.TabIndex = 0;
            label_welcome.Text = "welcome";
            // 
            // label_st_debt
            // 
            label_st_debt.AutoSize = true;
            label_st_debt.Location = new Point(197, 244);
            label_st_debt.Name = "label_st_debt";
            label_st_debt.Size = new Size(73, 20);
            label_st_debt.TabIndex = 1;
            label_st_debt.Text = "your debt";
            // 
            // label_st_name
            // 
            label_st_name.AutoSize = true;
            label_st_name.Location = new Point(456, 30);
            label_st_name.Name = "label_st_name";
            label_st_name.Size = new Size(61, 20);
            label_st_name.TabIndex = 2;
            label_st_name.Text = "st name";
            // 
            // label_debt
            // 
            label_debt.AutoSize = true;
            label_debt.Location = new Point(520, 244);
            label_debt.Name = "label_debt";
            label_debt.Size = new Size(40, 20);
            label_debt.TabIndex = 3;
            label_debt.Text = "debt";
            // 
            // textBox_enterc_name
            // 
            textBox_enterc_name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_enterc_name.Location = new Point(409, 88);
            textBox_enterc_name.Name = "textBox_enterc_name";
            textBox_enterc_name.Size = new Size(170, 34);
            textBox_enterc_name.TabIndex = 4;
            // 
            // label_signToCourse
            // 
            label_signToCourse.AutoSize = true;
            label_signToCourse.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_signToCourse.Location = new Point(197, 94);
            label_signToCourse.Name = "label_signToCourse";
            label_signToCourse.Size = new Size(170, 25);
            label_signToCourse.TabIndex = 5;
            label_signToCourse.Text = "enter course name";
            // 
            // button_signToCourse
            // 
            button_signToCourse.Location = new Point(299, 177);
            button_signToCourse.Name = "button_signToCourse";
            button_signToCourse.Size = new Size(155, 29);
            button_signToCourse.TabIndex = 6;
            button_signToCourse.Text = "sign to course";
            button_signToCourse.UseVisualStyleBackColor = true;
            button_signToCourse.Click += button_signToCourse_Click;
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_signToCourse);
            Controls.Add(label_signToCourse);
            Controls.Add(textBox_enterc_name);
            Controls.Add(label_debt);
            Controls.Add(label_st_name);
            Controls.Add(label_st_debt);
            Controls.Add(label_welcome);
            Name = "StudentForm";
            Text = "StudentForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_welcome;
        private Label label_st_debt;
        private Label label_st_name;
        private Label label_debt;
        private TextBox textBox_enterc_name;
        private Label label_signToCourse;
        private Button button_signToCourse;
    }
}