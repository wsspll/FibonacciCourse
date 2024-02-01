using Fibonacci.Helpers;
using System;
using System.Windows.Forms;

namespace Fibonacci.Forms
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        // Обработка события регистрации нового пользователя.
        private void reguster_Click(object sender, EventArgs e)
        {
            string username = regLoginTextBox.Text;
            string password = regPassTextBox.Text;
            string conirmPassword = regConfPassTextBox.Text;

            if (password != conirmPassword)
            {
                MessageBox.Show("Пароли не совпадают.");
                return;
            }

            if (DatabaseHelper.CreateUser(username, password))
            {
                MessageBox.Show("Регистрация успешна!");
                openFibonacciForm();
            }
            else
            {
                MessageBox.Show("Что-то пошло не так, повторите попытку позже.");
            }
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
