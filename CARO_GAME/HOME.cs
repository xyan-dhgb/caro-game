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
    public partial class HomeForm : Form
    {
        private PlayerControl playerControl;
        private SettingControl settingControl;
        public HomeForm()
        {
            InitializeComponent();
            
            // Tạo PlayerControl và thêm vào Form
            playerControl = new PlayerControl();
            playerControl.Visible = false; // Ẩn UserControl lúc ban đầu
            this.Controls.Add(playerControl);

            // Sự kiện lúc nhấn newButton
            newButton.Click += new EventHandler(this.newButton_Click);


            // Tạo SettingControl và thêm vào Form
            settingControl = new SettingControl();
            settingControl.Visible = false;
            this.Controls.Add(settingControl);

            settingButton.Click += new EventHandler(this.settingButton_Click);
        }
        private void newButton_Click(object sender, EventArgs e)
        {
            // Hiển thị UserControl
            playerControl.Visible = true;
            playerControl.BringToFront();
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            string letterTitle = "A lovely goodbye";
            MessageBox.Show("Thank you for playing this game. See you again!", letterTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void settingButton_Click(object sender, EventArgs e)
        {
            settingControl.Visible = true;
            settingControl.BringToFront();
        }
    }
}
