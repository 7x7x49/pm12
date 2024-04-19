using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using Microsoft.VisualBasic;
using System.Security;

namespace active_way
{
    public partial class Regestration : Form
    {

        Conection conection = new Conection();
        public Regestration()
        {
            InitializeComponent();
            panel2.Visible = false;
        }

        private void Regestration_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Генерация кода подтверждения (вызывайте этот метод там, где у вас создается код)
            string verificationCode = GenerateVerificationCode();
            SendVerificationEmail(textBoxEmail.Text, verificationCode);
            string enteredCode = Interaction.InputBox("Введите код подтверждения:", "Подтверждение", "");
            if (enteredCode == verificationCode)
            {
                conection.openConnection();
                string query = $"Insert into [User](Login, Password, Mail) Values ('{textBoxLogReg.Text}', '{textBoxPasReg.Text}', '{textBoxEmail.Text}')";
                SqlCommand command = conection.commandConection(query);
                if (command.ExecuteNonQuery() == 1)
                {
                    string query1 = $"SELECT ID_User FROM [User] where Login = '{textBoxLogReg.Text}'";
                    SqlCommand command1 = conection.commandConection(query1);
                    int userId = (int)command1.ExecuteScalar();
                    UserManager.SetUserId(userId.ToString());
                    MessageBox.Show("Аккаунт добавлен", "Успех");
                    FirstInfoWin first =  new FirstInfoWin();
                    this.Hide();
                    first.Show();
                }
                else
                {
                    MessageBox.Show("Запись не добавлена", "Осторожно");
                }
                conection.closeConnection();
            }
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conection.openConnection();
            string query = $"SELECT Password FROM [User] where Login = '{textBoxLogin.Text}'";
            SqlCommand command = conection.commandConection(query);
            string password = (string)command.ExecuteScalar();
            if (textBoxPassword.Text.Equals(password)){
                string query1 = $"SELECT ID_User FROM [User] where Login = '{textBoxLogin.Text}'";
                SqlCommand command1 = conection.commandConection(query1);
                int userId = (int)command1.ExecuteScalar();
                UserManager.SetUserId(userId.ToString());
                WinMain wm = new WinMain();
                this.Hide();
                wm.Show();
                
            }
           





            conection.closeConnection();

        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        public static string CreateMD5(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder sb = new System.Text.StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }

        private void enterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel1.Visible = true;

        }

        private void regesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
        }
        private void SendVerificationEmail(string emailAddress, string verificationCode)
        {
            bool bl = true;
            if (!textBox5.Text.Equals(textBoxPasReg.Text))
            {
                bl = false;


            }

            if (bl)
            {
                try
                {
                    // Адрес отправителя
                    string senderEmail = "Renden15@yandex.ru";
                    string senderPassword = "fl1pow2vr3";

                    // Адрес получателя
                    string to = emailAddress;

                    // Тема письма
                    string subject = "Код подтверждения для регистрации";

                    // Текст письма
                    string body = $"Ваш код подтверждения: {verificationCode}";

                    // Настройки SMTP сервера для Яндекс почты
                    SmtpClient smtp = new SmtpClient
                    {
                        Host = "smtp.yandex.ru",
                        Port = 587,
                        EnableSsl = true,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = false,
                        Credentials = new NetworkCredential(senderEmail, senderPassword)
                    };

                    // Отправка письма
                    using (MailMessage message = new MailMessage(senderEmail, to, subject, body))
                    {
                        smtp.Send(message);
                    }

                    MessageBox.Show("Код подтверждения отправлен на вашу почту.", "Информация");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при отправке письма: {ex.Message}", "Ошибка");
                }
            }
        }

        private string GenerateVerificationCode()
        {
            // Ваш код генерации кода подтверждения, например, случайная строка
            // Замените на ваш механизм генерации кода
            return Guid.NewGuid().ToString().Substring(0, 6).ToUpper();
        }

        private void textBoxLogReg_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPasReg_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
