using Microsoft.Azure.Amqp.Encoding;
using Microsoft.Azure.Amqp.Framing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using YandexTranslateCSharpSdk;

namespace active_way
{
    public partial class WinTranslete : Form
    {
        Conection conection = new Conection();
        private readonly Random random = new Random();
        public WinTranslete()
        {
            InitializeComponent();
            buttonNext.Visible = false;
        }
        private async Task<string> TranslateTextAsync(string text, string source, string target)
        {
            string IAM_TOKEN = "t1.9euelZqNkIrNlMiZzseRyJPHm5SWi-3rnpWaiZGOlcuRm8nPlJaPnM-LiZ3l8_dTJnpO-e95V2U__t3z9xNVd07573lXZT_-zef1656VmprLjJibz57KzY_PjZKOl4-N7_zF656VmprLjJibz57KzY_PjZKOl4-N.lfeXZvvObgfgVo6KIJMHJPo_oFrRQfk79YOfLNQjKEuEuQ16oX9gasIJVkFeyfshHmuZbDolvpoAEuRh_08CDQ";
            string folder_id = "b1ge70ic3ls738d0gvfg";
            string target_language = "ru";

            var body = new
            {
                targetLanguageCode = target_language,
                texts = text, // Здесь передаем один текст, а не массив texts
                folderId = folder_id
            };

            var jsonBody = JsonSerializer.Serialize(body);

            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", IAM_TOKEN);
                httpClient.DefaultRequestHeaders.Add("ContentType", "application/json"); // Исправляем "ContentType" на "Content-Type"

                var content = new StringContent(jsonBody, System.Text.Encoding.UTF8, "application/json");

                var response = await httpClient.PostAsync("https://translate.api.cloud.yandex.net/translate/v2/translate", content);

                if (response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(responseContent);
                    string pattern = @"\""text\"":\s*\""([^\""]*)\""";

                    Match match = Regex.Match(responseContent, pattern);
                    if (match.Success)
                    {
                        string translatedText = match.Groups[1].Value.Trim();
                        Console.WriteLine(translatedText);
                        return translatedText;
                    }
                    return $"Error: {response.StatusCode}";
                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode}");
                    return $"Error: {response.StatusCode}";
                }
            }

        }

        private void labelAnswer_Click(object sender, EventArgs e)
        {

        }

        private void WinTranslete_Load(object sender, EventArgs e)
        {
            generateQuestion();
        }
        private async void generateQuestion()
        {
            conection.openConnection();
            int nextNumber = random.Next(1, 1000);
            string query = $"SELECT word FROM Dictionary where id = '{nextNumber}'";
            SqlCommand command = conection.commandConection(query);
            string word = (string)command.ExecuteScalar();
            labelQuestion.Text = word;
            conection.closeConnection();
        }

        private void buttonSaveAnswer_Click(object sender, EventArgs e)
        {
            buttonTranslat();
        }
        private async void buttonTranslat()
        {
            string inputText = labelQuestion.Text;
            string targetLanguage = "ru"; // Задайте целевой язык здесь, например, "de" для немецкого

            string translatedText = await TranslateTextAsync(inputText, "en", "ru");
            if (tbAnswer.Text.Trim().Equals(translatedText.Trim(), StringComparison.OrdinalIgnoreCase))
            {
                labelAnswer.Text = "Правильно";
            }
            else
            {
                labelAnswer.Text = "Неправильно";
            }
            buttonNext.Visible = true;
            labelAnswer.Visible = true;

        }
        private void buttonNext_Click(object sender, EventArgs e)
        {
            generateQuestion();
            buttonNext.Visible = false;
            labelAnswer.Visible = false;
        }
    }
}
