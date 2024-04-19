using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace active_way
{
    public partial class WinCalories : Form
    {
        Conection conection = new Conection();
        CountMeaningCalories cmc = new CountMeaningCalories();
        CountMeaningCaloriesFood cmcf = new CountMeaningCaloriesFood();
        int w = 0;
        int wa = 0;
        double lEat;
        double lActive;
        int norma;
        int normaWater;


        public WinCalories()
        {
            InitializeComponent();

            MaximizeBox = false;
            MinimizeBox = false;
            ControlBox = false;
        }

        private void MainWin_Load(object sender, EventArgs e)
        {
            conection.openConnection();

            int userid = Convert.ToInt32(UserManager.GetUserId());

            string query = $"SELECT [NormalFood] FROM [Normal] where [ID_User] = '{userid}'"; //выбрать норму еды
            SqlCommand command = conection.commandConection(query);
            norma = (int)command.ExecuteScalar();

            string query2 = $"SELECT [AllFoodMeaning] FROM [CurrentDataFood] WHERE [ID_User] = {userid}"; //выбрать суммарное значение калорий
            SqlCommand command2 = conection.commandConection(query2);
            object result = command2.ExecuteScalar();
            double lEat = result != DBNull.Value ? Convert.ToDouble(result) : 0;
            if (lEat == null) lEat = 0;

            string query3 = $"SELECT [AllActiveMeaning] FROM [CurrentDataActive] WHERE [ID_User] = {userid}";
            SqlCommand command3 = conection.commandConection(query3);
            result = command3.ExecuteScalar();
            double lActive = result != DBNull.Value ? Convert.ToDouble(result) : 0;
            if (lActive == null) lActive = 0;

            conection.closeConnection();

            labelNormalFood.Text = Convert.ToInt32(lEat).ToString(); //обновление лабелек
            labelActiveNormal.Text = Convert.ToInt32(lActive).ToString();

            // подсказки при наводке
            ToolTip HintBack = new ToolTip();
            HintBack.SetToolTip(buttonBack, "Назад");

            ToolTip HintSpenting = new ToolTip();
            HintSpenting.SetToolTip(buttonSpenting, "Активность");

            ToolTip HintEating = new ToolTip();
            HintEating.SetToolTip(buttonEating, "Пища");

            ToolTip HintDrinking = new ToolTip();

            ToolTip HintLabelNormalEating = new ToolTip();
            HintLabelNormalEating.SetToolTip(labelNormalFood, "Норма потребляемых калорий в день для поддержания веса (базовый расход организма)");

            labelCurrentFood.Text = norma.ToString();

            w = (int)Math.Round((lEat / norma) * 540);
            picCurrentFood.Size = new Size(w, 3);
            wa = (int)Math.Round((lActive / (norma / 2)) * 540);
            picCurrentActive.Size = new Size(wa, 3);
            
            if (w > 540)
            {
                picCurrentFood.Size = new Size(540, 3);
            }

            if (wa > 540)
            {
                picCurrentActive.Size = new Size(540, 3);
            }

        }

        private void buttonSpenting_Click(object sender, EventArgs e)
        {
            this.Close();
            cmc.Show();
        }

        private void buttonEating_Click(object sender, EventArgs e)
        {
            this.Close();
            cmcf.Show();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            SingletonForm.Instance.Controls.Show();
        }
    }
}
