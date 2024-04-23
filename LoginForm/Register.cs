using LoginForm.DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LoginForm.DataBase.Role;
using static System.Windows.Forms.DataFormats;

namespace LoginForm
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.StartPosition = FormStartPosition.CenterScreen;
            login.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RoleType userRole = RoleType.User;
            string UserDataBasePath = @"..\..\..\DataBase\UserList.txt";

            if (!File.Exists(UserDataBasePath))
            {
                File.Create(UserDataBasePath).Close();
            }

            string[] existingUsers = File.ReadAllLines(UserDataBasePath);

            // Check if user already exists
            bool userExists = existingUsers.Any(user => user.Split(',')[2] == UserName.Text);

            if (userExists)
            {
                MessageBox.Show("Bu Foydalanuvchi ro'yxatdan o'tgan");
            }
            else
            {
                int newUserId = existingUsers.Length + 1;
                File.AppendAllText(UserDataBasePath, newUserId.ToString() + ',' + FullName.Text + ',' + UserName.Text + ',' + Password.Text + ',' + userRole.ToString() + '\n');

                // Clear the form
                FullName.Text = "";
                UserName.Text = "";
                Password.Text = "";

                MessageBox.Show("Muvaffaqiyatli ro'yxatdan o'tdingiz");

                // Open the Login form
                Login login = new Login();
                login.StartPosition = FormStartPosition.CenterScreen;
                login.Show();

                // Close the current form
                this.Close();
            }
        }
    }
}
