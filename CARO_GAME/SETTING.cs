using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CARO_GAME
{
    public partial class SettingControl : UserControl
    {
        private player1Form player1;
        private player2Form player2;
        public SettingControl()
        {
            InitializeComponent();

            player1 = new player1Form();
            player2 = new player2Form();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (lightButton.Checked)
            {
                player1.BackColor = Color.White;
                
                foreach (Control control in player1.Controls)
                {
                    control.ForeColor = Color.Black;
                }
            }
            else if (darkButton.Checked)
            {
                player1.BackColor = Color.Black;

                foreach (Control control in player1.Controls)
                {
                    control.ForeColor = Color.White;
                }
            }
        }

    }
}
