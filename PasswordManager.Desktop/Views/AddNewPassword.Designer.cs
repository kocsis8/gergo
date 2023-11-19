namespace PasswordManager.Desktop.Views
{
    partial class AddNewPassword
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
            label1 = new Label();
            textBox_username = new TextBox();
            textBox_pw = new TextBox();
            label2 = new Label();
            textBox_website = new TextBox();
            label3 = new Label();
            button_cancel = new Button();
            button_save = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 58);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // textBox_username
            // 
            textBox_username.Location = new Point(137, 50);
            textBox_username.Name = "textBox_username";
            textBox_username.Size = new Size(100, 23);
            textBox_username.TabIndex = 1;
            // 
            // textBox_pw
            // 
            textBox_pw.Location = new Point(137, 79);
            textBox_pw.Name = "textBox_pw";
            textBox_pw.PasswordChar = '*';
            textBox_pw.Size = new Size(100, 23);
            textBox_pw.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 87);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // textBox_website
            // 
            textBox_website.Location = new Point(137, 108);
            textBox_website.Name = "textBox_website";
            textBox_website.Size = new Size(100, 23);
            textBox_website.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 116);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 4;
            label3.Text = "Website";
            // 
            // button_cancel
            // 
            button_cancel.Location = new Point(63, 158);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(75, 23);
            button_cancel.TabIndex = 8;
            button_cancel.Text = "Cancel";
            button_cancel.UseVisualStyleBackColor = true;
            button_cancel.Click += button_cancel_Click;
            // 
            // button_save
            // 
            button_save.Location = new Point(215, 158);
            button_save.Name = "button_save";
            button_save.Size = new Size(75, 23);
            button_save.TabIndex = 9;
            button_save.Text = "Save";
            button_save.UseVisualStyleBackColor = true;
            button_save.Click += button_save_Click;
            // 
            // AddNewPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(343, 219);
            Controls.Add(button_save);
            Controls.Add(button_cancel);
            Controls.Add(textBox_website);
            Controls.Add(label3);
            Controls.Add(textBox_pw);
            Controls.Add(label2);
            Controls.Add(textBox_username);
            Controls.Add(label1);
            Name = "AddNewPassword";
            Text = "Add new password";
            Load += AddNewPassword_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox_username;
        private TextBox textBox_pw;
        private Label label2;
        private TextBox textBox_website;
        private Label label3;
        private Button button_cancel;
        private Button button_save;
    }
}