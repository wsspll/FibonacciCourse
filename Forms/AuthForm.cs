using Fibonacci.Helpers;
using Fibonacci.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fibonacci.Forms
{
    public partial class AuthForm : Form
    {

        public AuthForm()
        {
            InitializeComponent();
            DatabaseHelper.InitializeDatabase();
        }

        // Обработка события авторизации.
        private void auth_Click(object sender, EventArgs e)
        {
            string username = textBoxLogin.Text;
            string password = textBoxPass.Text;
            if (DatabaseHelper.ValidateUser(username, password))
            {
                MessageBox.Show("Авторизация успешна!");
                openFibonacciForm();
            }
            else
            {
                MessageBox.Show("Неверные учетные данные.");
            }
        }

        /// <summary>
        /// Открытие формы регистрации.
        /// </summary>
        private void register_Click(object sender, EventArgs e)
        {
            Hide();
            var regForm = new RegisterForm();
            regForm.Closed += (s, args) => Close();
            regForm.Show();
        }

        // Открытие новой формы для работы с последовательностью Фибоначчи.
        private void openFibonacciForm()
        {
            Hide();
            var fibForm = new FibonacciForm();
            fibForm.Closed += (s, args) => Close();
            fibForm.Show();
        }
    }
}
