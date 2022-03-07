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
    public partial class Doubler : Form
    {
        public Doubler()
        {
            InitializeComponent();
        }

        private bool Win()
        {
            if (value.Text == taskValue.Text)                
                    return true;
            return false;
        }

        private bool Fail()
        {
            try
            {
                if (Convert.ToInt32(value.Text) > Convert.ToInt32(taskValue.Text))                    
                    return true;
            }
            catch(Exception)
            { }
            return false;
        }
        private void Start()
        {
            value.Text = "0";
            count.Text = "0";
            Random randomTaskValue = new Random();
            int randomValue = randomTaskValue.Next(0, 100);
            taskValue.Text = $"{randomValue}";
        }
        private void OverGame()
        {
            if (taskValue.Text != "")
            { 
                if (Fail())
                {
                    MessageBox.Show($"Неудача! попробуйте с другим числом");
                    Start();
                }
                if (Win())
                {
                    MessageBox.Show($"Победа! за {count.Text} попыток");
                    Start();
                }
            }
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            Start();
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            try
            {
                value.Text = $"{Convert.ToInt32(value.Text) + 1}";
                count.Text = $"{Convert.ToInt32(count.Text) + 1}";
            }
            catch(FormatException)
            { }
            OverGame();
        }
        private void multiplyButton_Click(object sender, EventArgs e)
        {
            try
            {
                value.Text = $"{Convert.ToInt32(value.Text) * 2}";
                count.Text = $"{Convert.ToInt32(count.Text) + 1}";
            }
            catch (FormatException)
            { }
            OverGame();
        }
    }
}