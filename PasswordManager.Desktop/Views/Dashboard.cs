using Microsoft.VisualBasic.ApplicationServices;
using passwordManager;
using PasswordManager.Core.Data;
using PasswordManager.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManager.Desktop.Views
{
    public partial class Dashboard : Form
    {
        private PasswordManagerDbContext _context;
        Core.Models.User loggedUser;


        public Dashboard(Core.Models.User newUser)
        {
            _context = Program.GetDbContext();
            this.loggedUser = newUser;
            InitializeComponent();

            InitializeDataGridView();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_add_new_vault_Click(object sender, EventArgs e)
        {

            AddNewPassword anpw = new AddNewPassword(loggedUser);
            anpw.FormClosed += (s, args) => RefreshDataGridView();
            anpw.ShowDialog();
        }

        private void addVaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewPassword anpw = new AddNewPassword(loggedUser);
            anpw.FormClosed += (s, args) => RefreshDataGridView();
            anpw.Show();

        }

        public void InitializeDataGridView()
        {
            dataGridViewVault.Columns.Add("Username", "Username");
            dataGridViewVault.Columns.Add("Password", "Password");
            dataGridViewVault.Columns.Add("Website", "Website");

            List<Vault> vaultList = _context.Vault.Where(v => v.User == loggedUser)
                                                  .OrderBy(v => v.Website)
                                                  .ToList();

            foreach (var vault in vaultList)
            {
                EncryptedType encryptedData = new EncryptedType(loggedUser.Email, vault.Password);
                EncryptedType decryptedResult = encryptedData.Decrypt();

                dataGridViewVault.Rows.Add(vault.Username, decryptedResult.Secret, vault.Website);
            }


        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (dataGridViewVault.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridViewVault.SelectedRows[0].Index;

                string selectedUsername = dataGridViewVault.SelectedRows[0].Cells[0].Value.ToString();

                Vault vaultToDelete = _context.Vault.FirstOrDefault(v => v.Username == selectedUsername && v.User == loggedUser);

                DialogResult dialogResult = MessageBox.Show("Sure", "delete vault", MessageBoxButtons.YesNo);
           

                if (vaultToDelete != null && dialogResult == DialogResult.Yes)
                {
            
                    _context.Vault.Remove(vaultToDelete);
                    _context.SaveChanges();

                    dataGridViewVault.Rows.RemoveAt(selectedIndex);
                }
            }
            else
            {
                MessageBox.Show("Please select a row.");
            }
        }

        private void button_edit_Click(object sender, EventArgs e)
        {

            if (dataGridViewVault.SelectedRows.Count > 0)
            {

                int selectedIndex = dataGridViewVault.SelectedRows[0].Index;

                string selectedUsername = dataGridViewVault.SelectedRows[0].Cells[0].Value.ToString();

                Vault vaultToUpdate = _context.Vault.FirstOrDefault(v => v.Username == selectedUsername && v.User == loggedUser);

                if (vaultToUpdate != null)
                {
                    UpdatePassword anpw = new UpdatePassword(loggedUser, vaultToUpdate);
                    anpw.FormClosed += (s, args) => RefreshDataGridView();
                    anpw.Show();
                }
            }
            else
            {
                MessageBox.Show("Please select a row.");
            }

        }

        public void RefreshDataGridView()
        {

            try
            {

                dataGridViewVault.Rows.Clear();
                _context.Dispose(); 
                _context = Program.GetDbContext();

                // Reload data from the database
                List<Vault> vaultList = _context.Vault.Where(v => v.User == loggedUser)
                                                      .OrderBy(v => v.Website) 
                                                      .ToList();
                foreach (var vault in vaultList)
                {
                    EncryptedType encryptedData = new EncryptedType(loggedUser.Email, vault.Password);
                    EncryptedType decryptedResult = encryptedData.Decrypt();

                    dataGridViewVault.Rows.Add(vault.Username, decryptedResult.Secret, vault.Website);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error refreshing data: " + ex.Message);
            }
        }
    }
}
