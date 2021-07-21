using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab._5___Zadanie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Login = textBox1.Text;
            var Password = textBox2.Text;

            var loginUser = User.users.Where(x => x.Login == Login).Select(x => x.Login);
            var passwordUser = User.users.Where(x => x.Login == Login).Select(x => x.Password);

            if (loginUser.Count() == 0)
            {
                MessageBox.Show("Brak użytkownika lub błędny login");

            }
            else if (passwordUser.First() != Password)
            {
                MessageBox.Show("Nie poprawny login lub hasło");
            }
            else
            {
                MessageBox.Show("Zalogowano!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var Login = textBox3.Text;
            var Password = textBox4.Text;
            var Password2 = textBox5.Text;
            var Check = checkBox1.Checked;

            var loginUser = User.users.Where(x => x.Login == Login).Select(x => x.Login);

            if (string.IsNullOrWhiteSpace(Login))
            {
                MessageBox.Show("Wpisz login");
            }
            else if(loginUser.Count() != 0)
            {
                MessageBox.Show("Istnieje już użytkownik o takim loginie");
            }
            else if (string.IsNullOrWhiteSpace(Password))
            {
                MessageBox.Show("Wpisz hasło");
            }
            else if (string.IsNullOrWhiteSpace(Password2))
            {
                MessageBox.Show("Musisz potwierdzić hasło");
            }
            else if (!Password.Equals(Password2))
            {
                MessageBox.Show("Hasła muszą być takie same");
            }
            else if (Check == false)
            {
                MessageBox.Show("Zaznacz Rodo aby się zarejestrować!");
            }
            else
            {
                User user = new User(Login, Password);
                User.AddUser(user);

                MessageBox.Show("Zarejestrowałeś się");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
