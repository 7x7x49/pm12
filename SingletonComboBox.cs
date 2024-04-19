using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace active_way
{
    public class SingletonComboBox
    {
        private static SingletonComboBox instance; //паттерн для создания одиночного объекта формы
        private ComboBox comboBox;

        public static SingletonComboBox Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SingletonComboBox();
                }
                return instance;
            }
        }

        private SingletonComboBox()
        {
            comboBox = new ComboBox();
        }

        public ComboBox Controls
        {
            get { return comboBox; }
        }
    }
}
