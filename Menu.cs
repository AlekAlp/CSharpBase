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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void doublerChoice_Click(object sender, EventArgs e)
        {
            Doubler startDoubler = new Doubler();
            startDoubler.Show();
        }

        private void guessChoice_Click(object sender, EventArgs e)
        {
            RandomGuess startRandomGuess = new RandomGuess();
            startRandomGuess.Show();
        }
    }
}
