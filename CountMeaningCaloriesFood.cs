using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace active_way
{
    public partial class CountMeaningCaloriesFood : Form
    {
        Conection conection = new Conection();
        public CountMeaningCaloriesFood()
        {
            InitializeComponent();

            MaximizeBox = false;
            MinimizeBox = false;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;

            //убираем верхнюю панель
            ControlBox = false;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            conection.openConnection();
            string userId = UserManager.GetUserId();
            string query1 = $"SELECT [AllFoodMeaning] FROM [CurrentDataFood] WHERE [ID_User] = {userId}";
            SqlCommand command1 = conection.commandConection(query1);
            object result = command1.ExecuteScalar();
            int calories = result != DBNull.Value ? Convert.ToInt32(result) : 0;
            decimal weight;
            if (decimal.TryParse(label2.Text, out decimal inputCalories))
            {
                // If parsing is successful, add to calories and convert to decimal
                weight = Convert.ToDecimal(inputCalories + calories);
            }
            else
            {
                // Handle the case where label2.Text is not a valid integer
                // For example, you could set weight to a default value or display an error message
                weight = 0; // or some other default or error handling
            }
            string query = $"UPDATE [CurrentDataFood] SET [AllFoodMeaning] = @weight WHERE [ID_User] = @userId";
            SqlCommand command = conection.commandConection(query);
            command.Parameters.AddWithValue("@weight", weight);
            command.Parameters.AddWithValue("@userId", userId);
            if (command.ExecuteNonQuery() == 1)
            {
                WinCalories wc = new WinCalories();
                this.Close();
                wc.Show();
            }
            else
            {
                MessageBox.Show("Запись не добавлена", "Осторожно");
            }
            conection.closeConnection();
            
        }

        private void CountMeaningCaloriesFood_Load(object sender, EventArgs e)
        {
            conection.openConnection();
            string query = "SELECT nameFood FROM Food";
            using (SqlCommand command = conection.commandConection(query))
            {
                try
                {
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string itemName = reader.GetString(0); // Получаем значение из первого столбца
                        comboBoxFood.Items.Add(itemName); // Добавляем значение в ComboBox
                    }

                    // Закрываем reader
                    reader.Close();
                }
                catch (Exception ex)
                {
                    // Обрабатываем возможные ошибки
                    MessageBox.Show("Ошибка при заполнении ComboBox: " + ex.Message);
                }


                conection.closeConnection();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conection.openConnection();
            string selectedF = comboBoxFood.SelectedItem.ToString();
            string query1 = $"SELECT CaloriesFood FROM Food WHERE name = '{selectedF}'";
            SqlCommand command1 = conection.commandConection(query1);
            decimal calories = (decimal)command1.ExecuteScalar();
            decimal totalCaloriesBurned = calories * Convert.ToDecimal(tbWeight.Text) / 60; // перевод в минуты
            label2.Text = totalCaloriesBurned.ToString();
            conection.closeConnection();
        }
    }
}
