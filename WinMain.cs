using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace active_way
{
    public partial class WinMain : Form
    {

        WinCalories wc = new WinCalories();
        Profil fiw = new Profil();
        WinTask wt = new WinTask();
        WinTranslete wtl = new WinTranslete();

        public WinMain()
        {
            InitializeComponent();

            //чтобы нельзя было изменить размер окна
            MaximizeBox = false;
            MinimizeBox = false;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        private void WinMain_Load(object sender, EventArgs e)
        {
           
        }

        private void buttonOpenWinCal_Click(object sender, EventArgs e)
        {
            try
            {
                wc.Show();
                Hide();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            try
            {
                fiw.Show();
                Hide();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

      
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                wt.Show();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                wtl.Show();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
