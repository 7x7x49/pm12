using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace active_way
{
    public partial class Avatar : Form
    {
        Conection conection = new Conection();
        public Avatar()
        {
            InitializeComponent();
            LoadAvatarImages();
        }

        private void pictureBoxSelectedAvatar_Click(object sender, EventArgs e)
        {

        }

        private void buttonUploadImage_Click(object sender, EventArgs e)
        {
            FirstInfoWin fw = new FirstInfoWin();
            this.Close();
            fw.Show();
            fw.Update();
        }

        // В этот же класс формы, добавьте метод для обновления изображений в FlowLayoutPanel:
        private void LoadAvatarImages()
        {
            // Получаем путь к текущему рабочему каталогу

            string projectFolder = Directory.GetCurrentDirectory();

            
            while (!Directory.Exists(Path.Combine(projectFolder, "Avatar_folder")))
            {
                projectFolder = Directory.GetParent(projectFolder).FullName;
            }
            string imagesDirectory = Path.Combine(projectFolder, "Avatar_folder");
            
            flowLayoutPanelAvatars.Controls.Clear();

            // Получение списка файлов с расширениями .jpg и .png
            string[] filters = { ".jpg", "*.png" };
            List<string> files = new List<string>();

            

            foreach (var filter in filters)
            {
                files.AddRange(Directory.GetFiles(imagesDirectory, filter, SearchOption.TopDirectoryOnly));
            }

            foreach (var file in files)
            {
                PictureBox pictureBox = new PictureBox
                {
                    Image = Image.FromFile(file),
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Height = 100,
                    Width = 100,
                    Padding = new Padding(5),
                    Cursor = Cursors.Hand
                };
                pictureBox.Click += (sender, e) => {
                    pictureBoxSelectedAvatar.Image = pictureBox.Image;
                    // Обновление информации об аватаре в базе данных
                    UpdateUserProfileAvatar(file);
                };
                flowLayoutPanelAvatars.Controls.Add(pictureBox);
            }
        }

        // обновление авата 
        private void UpdateUserProfileAvatar(string avatarPath)
        {
            UpdateAvatarInDatabase(avatarPath);
        }

        private void UpdateAvatarInDatabase(string avatarPath)
        {
            conection.openConnection();
            string userId = UserManager.GetUserId();
            string query = $"UPDATE [User] SET [Avatar] = '{avatarPath}' WHERE [ID_User] = {userId}";
            SqlCommand command = conection.commandConection(query);
            if (command.ExecuteNonQuery() == 1)
            {
               
            }
            else
            {
                MessageBox.Show("Запись не добавлена", "Осторожно");
            }
            conection.closeConnection();
           
        }

        private void Avatar_Load(object sender, EventArgs e)
        {

        }
    }
}
