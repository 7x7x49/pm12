using Microsoft.Azure.Amqp.Framing;
using NCalc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace active_way
{
    public partial class WinTask : Form
    {
        private object _answer;
        private int _score = 0;
        private readonly Random _random = new Random();

        public WinTask()
        {
            InitializeComponent();
            buttonNext.Visible = false;
            UpdateScore();
            GenerateTask();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            GenerateTask();
            labelAnswer.Visible = false;
        }

        private void tbAnswer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckAnswer();
                labelAnswer.Visible = true;
            }
        }

        private void buttonSaveAnswer_Click(object sender, EventArgs e)
        {
            CheckAnswer();
            labelAnswer.Visible = true;
        }

        private void GenerateTask()
        {
            int maxOperators = Math.Min((_score / 10) + 1, 3);

            StringBuilder question = new StringBuilder();
      

            char[] operators = { '+', '-', '*', '/' };
            char previousOperator = ' '; // Предыдущий оператор
            bool useParentheses = false; // Флаг использования скобок
            int openedParentheses = 0; // Счетчик открытых скобок
            for (int i = 0; i < maxOperators; i++)
            {
                char randomOperator = ChooseOperator(_score);

                int nextNumber = _random.Next(1, 10 + _score * 2);
                if (i != 0)
                {
                    if ((randomOperator == '*' || randomOperator == '/') && maxOperators > 1 && _random.Next(2) == 0)
                    {
                        // Если предыдущий оператор + или -, то добавляем открывающую скобку перед текущим выражением
                        if (previousOperator == '+' || previousOperator == '-')
                        {
                            question.Insert(0, "(");
                            openedParentheses++;
                        }
                    }

                    // Если есть открытые скобки, добавляем закрывающую скобку перед текущим оператором
                    if (openedParentheses > 0)
                    {
                        question.Append(")");
                        openedParentheses--;
                    }

                    question.Append($" {randomOperator} {nextNumber}");

                }
                else
                {
                    int number1 = _random.Next(1, 10 + _score * 2);
                    int number2 = _random.Next(1, 10 + _score * 2);
                    question.Append($"{number1} {randomOperator} {number2}");
  
                }

                previousOperator = randomOperator;
            }
            Expression e = new Expression(question.ToString());
            object result = e.Evaluate(); // Используем object, так как тип результата неизвестен
            if (result is int) // Проверяем, является ли результат целым числом
            {
                _answer = (int)result; // Приводим к типу int
            }
            else
            {
                _answer = (float)Math.Round((double)result, 2); // Приводим к типу float с округлением до сотых
            }

            tbAnswer.Text = "";
            buttonNext.Visible = false;
            labelQuestion.Text = question.ToString();
        }


        private char ChooseOperator(int score)
        {
            int randomValue = _random.Next(100);

            if (score >= 15)
            {
                if (randomValue < 30)
                    return '+';
                else if (randomValue < 60)
                    return '-';
                else if (randomValue < 80)
                    return '*';
                else
                    return '/';
            }
            else if (score >= 10)
            {
                if (randomValue < 40)
                    return '+';
                else if (randomValue < 70)
                    return '-';
                else
                    return '*';
            }
            else if (score >= 5)
            {
                if (randomValue < 60)
                    return '-';
                else
                    return '+';
            }
            else
            {
                return '+';
            }
        }

     

        private void CheckAnswer()
        {
            if (float.TryParse(tbAnswer.Text.Trim(), out float data)) // Пытаемся преобразовать введенный ответ в float
            {
                if (_answer is int && Math.Abs((int)_answer - data) < 0.01f) // Если _answer является целым числом, сравниваем его с введенным ответом
                {
                    _score += 5;
                    UpdateScore();
                    labelAnswer.Text = "Правильно";
                    buttonNext.Visible = true;
                }
                else if (_answer is float && Math.Abs((float)_answer - data) < 0.01f) // Если _answer является числом с плавающей точкой, сравниваем его с введенным ответом
                {
                    _score += 5;
                    UpdateScore();
                    labelAnswer.Text = "Правильно";
                    buttonNext.Visible = true;
                }
                else
                {
                    labelAnswer.Text = "Неправильно";
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите число в правильном формате (с плавающей точкой или целое число).");
                labelAnswer.Text = "";
            }

        }

        private void UpdateScore()
        {
            labelScore.Text = $"Счет: {_score}";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Пустой обработчик события щелчка по изображению
        }

        private void tbAnswer_TextChanged(object sender, EventArgs e)
        {
            // Пустой обработчик события изменения текста в текстовом поле
        }
    }
}
