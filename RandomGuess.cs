using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doubler
{
    public partial class RandomGuess : Form
    {
        int randomValue;
        public RandomGuess()
        {
            InitializeComponent();
        }
        private bool Win()
        {
            if (randomValue == Convert.ToInt32(valuePersonal.Text))
                return true;
            return false;
        }
        private void Start()
        {
            Random randomTaskValue = new Random();
            randomValue = randomTaskValue.Next(1, 10);
            taskValue.Text = "Число загадано";
            count.Text = "0";
        }
        private void OverGame()
        {
            if (taskValue.Text != "")
            {                
                if (Win())
                {
                    MessageBox.Show($"Победа! за {count.Text} попыток");
                    Start();
                }
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Start();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(valuePersonal.Text) == randomValue)
                {
                    taskValue.Text = "ВЕРНО!";
                    count.Text = $"{Convert.ToInt32(count.Text) + 1}";
                    OverGame();
                }
                if (Convert.ToInt32(valuePersonal.Text) != randomValue)
                {
                    taskValue.Text = "НЕ УГАДАЛ";
                    count.Text = $"{Convert.ToInt32(count.Text) + 1}";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Неверные данные");
            }
        }
    }
}
