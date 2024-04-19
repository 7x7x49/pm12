using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace active_way
{
    public partial class Profil : Form
    {
        ImageLoader imageLoader = new ImageLoader();
        Conection conection = new Conection();
        public Profil()
        {
            InitializeComponent();
           
        }

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            // Определяем толщину обводки
            int borderWidth = 3;

            // Создаем круглую область с учетом толщины обводки
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(borderWidth, borderWidth, pictureBox1.Width - 2 * borderWidth, pictureBox1.Height - 2 * borderWidth);

            // Устанавливаем маску для PictureBox
            pictureBox1.Region = new Region(path);

            // Рисуем круглую обводку внутри PictureBox с антиалиасингом
            using (Pen pen = new Pen(Color.Black, borderWidth))
            {
                pen.Alignment = PenAlignment.Inset; // Обводка внутрь
                pen.LineJoin = LineJoin.Round; // Скругляем углы обводки

                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias; // Включаем антиалиасинг
                e.Graphics.DrawEllipse(pen, borderWidth, borderWidth, pictureBox1.Width - 2 * borderWidth, pictureBox1.Height - 2 * borderWidth);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FirstInfoWin first= new FirstInfoWin();
            this.Close();
            first.Show();
        }

        private void Profil_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = imageLoader.LoadImage();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Paint += PictureBox1_Paint;
            label8.Text = select("Height");
            label9.Text = select("Age");
            label7.Text = select("Weight");
            label6.Text = select("Gender");
        }

        private string select(string labeltext)
        {
            conection.openConnection();
            int userId;
            int.TryParse(UserManager.GetUserId(), out userId);
            string query = $"SELECT {labeltext} FROM [User] where ID_User = '{userId}'";
            SqlCommand command = conection.commandConection(query);
            object result = command.ExecuteScalar();
            string word;

            if (result != null)
            {
                // Проверка, является ли результат десятичным числом
                if (result is decimal)
                {
                    // Преобразование десятичного числа к строке
                    decimal decimalValue = (decimal)result;
                    word = decimalValue.ToString("0.00"); // Форматирование строки с двумя десятичными знаками
                }
                else
                {
                    // Преобразование к строке, если результат не является десятичным числом
                    word = result.ToString();
                }
            }
            else
            {
                word = string.Empty; // Или другое значение по умолчанию, если результат запроса равен NULL
            }
            conection.closeConnection();
            return word;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            WinMain wm = new WinMain();
            this.Close();
            wm.Show();
        }
    }
}
