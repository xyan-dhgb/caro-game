using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CARO_GAME
{
    public partial class PlayerControl : UserControl
    {
        public PlayerControl()
        {
            InitializeComponent();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void player1Button_Click(object sender, EventArgs e)
        {
            player1Form player1 = new player1Form();
            player1.Show();
        }

        private void play2Button_Click(object sender, EventArgs e)
        {
            player2Form player2 = new player2Form();
            player2.Show();
        }
    }
}
