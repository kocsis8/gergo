namespace PasswordManager.Desktop.Views
{
    partial class Alert
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
            button_ok = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(40, 26);
            label1.Name = "label1";
            label1.Size = new Size(136, 50);
            label1.TabIndex = 0;
            label1.Text = "Nem töltöttél \r\nki mindent!\r\n";
            // 
            // button_ok
            // 
            button_ok.Location = new Point(57, 105);
            button_ok.Name = "button_ok";
            button_ok.Size = new Size(75, 23);
            button_ok.TabIndex = 1;
            button_ok.Text = "Ok";
            button_ok.UseVisualStyleBackColor = true;
            button_ok.Click += button_ok_Click;
            // 
            // Alert
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(221, 140);
            Controls.Add(button_ok);
            Controls.Add(label1);
            Name = "Alert";
            Text = "Alert";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button_ok;
    }
}