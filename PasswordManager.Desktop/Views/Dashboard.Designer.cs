namespace PasswordManager.Desktop.Views
{
    partial class Dashboard
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
            menuStrip1 = new MenuStrip();
            optionsToolStripMenuItem = new ToolStripMenuItem();
            addVaultToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            dataGridViewVault = new DataGridView();
            button_add_new_vault = new Button();
            button_delete = new Button();
            button_edit = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVault).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { optionsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addVaultToolStripMenuItem, exitToolStripMenuItem });
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new Size(61, 20);
            optionsToolStripMenuItem.Text = "Options";
            // 
            // addVaultToolStripMenuItem
            // 
            addVaultToolStripMenuItem.Name = "addVaultToolStripMenuItem";
            addVaultToolStripMenuItem.Size = new Size(125, 22);
            addVaultToolStripMenuItem.Text = "Add Vault";
            addVaultToolStripMenuItem.Click += addVaultToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(125, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // dataGridViewVault
            // 
            dataGridViewVault.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVault.Location = new Point(0, 36);
            dataGridViewVault.Name = "dataGridViewVault";
            dataGridViewVault.RowHeadersWidth = 51;
            dataGridViewVault.RowTemplate.Height = 25;
            dataGridViewVault.Size = new Size(800, 367);
            dataGridViewVault.TabIndex = 1;
            // 
            // button_add_new_vault
            // 
            button_add_new_vault.Location = new Point(686, 415);
            button_add_new_vault.Name = "button_add_new_vault";
            button_add_new_vault.Size = new Size(102, 23);
            button_add_new_vault.TabIndex = 2;
            button_add_new_vault.Text = "Add new Vault";
            button_add_new_vault.UseVisualStyleBackColor = true;
            button_add_new_vault.Click += button_add_new_vault_Click;
            // 
            // button_delete
            // 
            button_delete.Location = new Point(556, 415);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(102, 23);
            button_delete.TabIndex = 3;
            button_delete.Text = "Delete Vault";
            button_delete.UseVisualStyleBackColor = true;
            button_delete.Click += button_delete_Click;
            // 
            // button_edit
            // 
            button_edit.Location = new Point(20, 417);
            button_edit.Name = "button_edit";
            button_edit.Size = new Size(102, 23);
            button_edit.TabIndex = 4;
            button_edit.Text = "Edit Vault";
            button_edit.UseVisualStyleBackColor = true;
            button_edit.Click += button_edit_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_edit);
            Controls.Add(button_delete);
            Controls.Add(button_add_new_vault);
            Controls.Add(dataGridViewVault);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVault).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem addVaultToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private DataGridView dataGridViewVault;
        private Button button_add_new_vault;
        private Button button_delete;
        private Button button_edit;
    }
}