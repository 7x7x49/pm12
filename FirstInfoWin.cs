using System;
using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Data.SqlClient;
    using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using static System.Windows.Forms.VisualStyles.VisualStyleElement;

    namespace active_way
    {
         public partial class FirstInfoWin : Form
         {
            ImageLoader imageLoader = new ImageLoader();
            private OpenFileDialog openFileDialog1;
            public int lne = 0;
            public int lnd = 0;
            public DialogResult result;
            public string caption = "Ошибка!";
            Conection conection = new Conection();
        public FirstInfoWin()
            {
            InitializeComponent();
               
            MaximizeBox = false;
                MinimizeBox = false;
                ControlBox = false;
                AutoSizeMode = AutoSizeMode.GrowAndShrink;
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
    
        private void buttonSave_Click(object sender, EventArgs e)
            {
                try // рассчёт нормы
                {
                    if ((Convert.ToInt32(tbAge.Text) < 5) || (Convert.ToInt32(tbAge.Text) > 110)) // проверка возраста
                    {
                        string message = "Введите другой возраст";
                        result = MessageBox.Show(message, caption);
                    }
                
                    if ((Convert.ToInt32(tbWeight.Text) < 16) || (Convert.ToInt32(tbWeight.Text) > 160)) // проверка веса
                    {
                        string message = "Введите другой вес";
                        result = MessageBox.Show(message, caption);
                    }

                    if ((Convert.ToInt32(tbHeight.Text) < 100) || (Convert.ToInt32(tbHeight.Text) > 210)) // проверка роста
                    {
                        string message = "Введите другой рост";
                        result = MessageBox.Show(message, caption);
                    }

                    if (rbMan.Checked && tbWeight != null && tbHeight != null && tbAge != null)
                    {
                        lne = 66 + 14 * Convert.ToInt32(tbWeight.Text) + 5 * Convert.ToInt32(tbHeight.Text) - 7 * Convert.ToInt32(tbAge.Text); // калории

                        // проверка на корректность данных и => закрытие окна, если всё правильно
                        if (((Convert.ToInt32(tbAge.Text) >= 5) || (Convert.ToInt32(tbAge.Text) <= 110)) && ((Convert.ToInt32(tbWeight.Text) >= 16) || (Convert.ToInt32(tbWeight.Text) <= 160)) && ((Convert.ToInt32(tbHeight.Text) >= 100) || (Convert.ToInt32(tbHeight.Text) <= 210)))
                        {
                        conection.openConnection();
                        int userId = Convert.ToInt32(UserManager.GetUserId());
                        string query = $"UPDATE [User] SET Height = {Convert.ToInt32(tbHeight.Text)}, Weight = {Convert.ToInt32(tbWeight.Text)}, Age = {Convert.ToInt32(tbAge.Text)}, Gender = 'М', WHERE ID_User = {userId}";

                        SqlCommand command = conection.commandConection(query);
                        if (command.ExecuteNonQuery() == 1)
                        {
                            conection.closeConnection();
                            Profil pf = new Profil();
                            this.Close();
                            pf.Show();
                        }
                        else 
                        { 
                            MessageBox.Show("Запись не добавлена", "Осторожно"); 
                        }
                            conection.closeConnection();
                        }
                       
                    }

                    if (rbWoman.Checked && tbWeight != null && tbHeight != null && tbAge != null)
                    {
                        lne = 655 + 10 * Convert.ToInt32(tbWeight.Text) + 2 * Convert.ToInt32(tbHeight.Text) - 5 * Convert.ToInt32(tbAge.Text);

                        lnd = Convert.ToInt32(tbWeight.Text) * 31;

                        conection.openConnection();
                    int userId = Convert.ToInt32(UserManager.GetUserId());
                    string query = $"UPDATE [User] SET Height = {Convert.ToInt32(tbHeight.Text)}, Weight = {Convert.ToInt32(tbWeight.Text)}, Age = {Convert.ToInt32(tbAge.Text)}, Gender = 'Ж', WHERE ID_User = {userId}";

                    SqlCommand command = conection.commandConection(query);
                        if (command.ExecuteNonQuery() == 1)
                        {
                            conection.closeConnection();
                            Profil pf = new Profil();
                            this.Close();
                            pf.Show();
                        }
                        else
                        {
                            MessageBox.Show("Запись не добавлена", "Осторожно");
                        }
                        conection.closeConnection();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
               
            }

            private void FirstInfoWin_Load(object sender, EventArgs e)
            {
            pictureBox1.ImageLocation = imageLoader.LoadImage();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Paint += PictureBox1_Paint;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Avatar av = new Avatar();
            this.Hide();
            av.Show();
        }
        }
    }
