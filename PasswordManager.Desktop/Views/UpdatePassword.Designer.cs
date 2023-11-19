namespace PasswordManager.Desktop.Views
{
    partial class UpdatePassword
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
            label2 = new Label();
            label3 = new Label();
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            textBoxWebsite = new TextBox();
            button_save = new Button();
            button_cancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 54);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 86);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 1;
            label2.Text = "New Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(69, 120);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 2;
            label3.Text = "Website";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(128, 46);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(100, 23);
            textBoxUsername.TabIndex = 3;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(128, 78);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(100, 23);
            textBoxPassword.TabIndex = 4;
            // 
            // textBoxWebsite
            // 
            textBoxWebsite.Location = new Point(128, 112);
            textBoxWebsite.Name = "textBoxWebsite";
            textBoxWebsite.Size = new Size(100, 23);
            textBoxWebsite.TabIndex = 5;
            // 
            // button_save
            // 
            button_save.Location = new Point(211, 165);
            button_save.Name = "button_save";
            button_save.Size = new Size(84, 23);
            button_save.TabIndex = 6;
            button_save.Text = "Save";
            button_save.UseVisualStyleBackColor = true;
            button_save.Click += button_save_Click;
            // 
            // button_cancel
            // 
            button_cancel.Location = new Point(58, 165);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(85, 23);
            button_cancel.TabIndex = 7;
            button_cancel.Text = "Cancel";
            button_cancel.UseVisualStyleBackColor = true;
            button_cancel.Click += button_cancel_click;
            // 
            // UpdatePassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 216);
            Controls.Add(button_cancel);
            Controls.Add(button_save);
            Controls.Add(textBoxUsername);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxWebsite);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UpdatePassword";
            Text = "UpdatePassword";
            Load += UpdatePassword_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private TextBox textBoxWebsite;
        private Button button_save;
        private Button button_cancel;
    }
}