﻿using Microsoft.EntityFrameworkCore;
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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using User = PasswordManager.Core.Models.User;

namespace PasswordManager.Desktop.Views
{
    public partial class Registration : Form
    {
        private readonly PasswordManagerDbContext _context;
        private readonly BindingSource _bindingSource = new();

        public User User { get; private set; }

        public Registration()
        {
            _context = Program.GetDbContext();
            InitializeComponent();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mf = new MainForm();
            mf.Show();
        }

        private void button_registration_Click(object sender, EventArgs e)
        {
            if (!pwdIsValid(textBox_pw.Text))
            {
                MessageBox.Show("A jelszó nem fele mega követelményeknek!");
                return;
            }

            bool textboxsIsNotEmty = textBox_pw.Text.Length > 0 && textBox_email.Text.Length > 0 && textBox_username.Text.Length > 0 && textBox_fn.Text.Length > 0 && textBox_ln.Text.Length > 0;

            if (textboxsIsNotEmty)
            {
                EncryptedType encryptedData = new EncryptedType(textBox_email.Text, textBox_pw.Text);
                EncryptedType encryptedResult = encryptedData.Encrypt();



                var newUser = new Core.Models.User
                {
                    Password = encryptedResult.Secret,
                    Email = textBox_email.Text,
                    Username = textBox_username.Text,
                    FirstName = textBox_fn.Text,
                    LastName = textBox_ln.Text,
                };


                _context.User.Add(newUser);
                _context.SaveChanges();

                this.Hide();
                Dashboard df = new Dashboard(newUser);
                df.Show();

            }
            else
            {

                Alert af = new Alert();
                af.Show();
            }

        }

        private bool pwdIsValid(string text)
        {

            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasLowerChar = new Regex(@"[a-z]+");
            var hasMinimum6Chars = new Regex(@".{6,}");

            return (hasNumber.IsMatch(text) &&hasLowerChar.IsMatch(text) && hasUpperChar.IsMatch(text) && hasMinimum6Chars.IsMatch(text));


        }
    }
}
