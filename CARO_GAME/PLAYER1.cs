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
using System.Configuration;
using System.Media;
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;

namespace CARO_GAME
{
    public partial class player1Form : Form
    {
        #region Properties
        ChessBoardManager ChessBoard;
        private int totalTime = 15; // Tổng thời gian đếm (15 giây)
        private SoundPlayer soundPlayer;
        SocketManager socket;
        #endregion

        public player1Form()
        {
            InitializeComponent();

            ChessBoard = new ChessBoardManager(chessBoardPanel, nameTextBox, player1Image);

            // Gọi event khi kết thúc lượt của người chơi
            ChessBoard.GameIsEnd += ChessBoard_GameIsEnd;

            // Gọi event khi lượt chơi của người chơi được đánh dấu
            ChessBoard.PlayerMarked += ChessBoard_PlayerMarked;

            // Thiết lập giá trị ban đầu cho progress bar
            processBar.Step = Constant.COUNT_DOWN_STEP;
            processBar.Maximum = Constant.COUNT_DOWN_TIME;
            processBar.Value = 0;

            timerCountDown.Interval = Constant.COUNT_DOWN_INTERVAL;


            // Mỗi khi bắt đầu trò chơi mới thì luôn tạo lại bàn cờ
            NewGame();

            // Đặt thời gian mặc định cho labelTime
            timeLabel.Text = TimeSpan.FromSeconds(0).ToString(@"mm\:ss");

            socket = new SocketManager();
        }


        void EndGameAnnouncement()
        {
            timerCountDown.Stop();
            chessBoardPanel.Enabled = false;
            MessageBox.Show("Your game is end!!!", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ChessBoard_PlayerMarked(object sender, EventArgs e)
        {
            timerCountDown.Start();
            processBar.Value = 0; // Reset thời gian
        }

        private void ChessBoard_GameIsEnd(object sender, EventArgs e)
        {
            EndGameAnnouncement();
        }

        private void timerCountDown_Tick(object sender, EventArgs e)
        {
            if (processBar.Value < processBar.Maximum)
            {
                processBar.PerformStep();

                // Cập nhật thời gian đã trôi qua dựa trên giá trị progress bar
                int elapsedTime = processBar.Value;
                timeLabel.Text = TimeSpan.FromSeconds(elapsedTime).ToString(@"mm\:ss");
            }

            if (processBar.Value >= processBar.Maximum)
            {
                EndGameAnnouncement();
            }
        }

        private void player1Form_Load(object sender, EventArgs e)
        {
            // Initialize UI elements if needed
            processBar.Minimum = 0;
            processBar.Maximum = totalTime;
            processBar.Value = 0;
            timeLabel.Text = TimeSpan.FromSeconds(0).ToString(@"mm\:ss");
        }

        void NewGame()
        {
            // Reset process bar
            processBar.Value = 0;
            timerCountDown.Stop();

            // Vẽ bàn cờ 
            ChessBoard.DrawChessBoard();

        }

        void QuitGame()
        {
            this.Close();
        }
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void quitGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuitGame();
        }

        private void player1Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Thông báo nếu người chơi có nhấn nhầm
            if (MessageBox.Show("Are you sure to exit?", "Hey hey!!!", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                e.Cancel = true;
            }

            if (soundPlayer != null)
            {
                soundPlayer.Stop();
            }
        }

        private void clickhereLabel_Click(object sender, EventArgs e)
        {
            RULE rule = new RULE();
            rule.ShowDialog();
        }

        private void unmute_Click(object sender, EventArgs e)
        {
            soundPlayer = new SoundPlayer("D:\\Network_programming\\Project\\CARO\\CARO_GAME\\Music\\the_epic.wav");
            soundPlayer.PlayLooping();
        }

        private void mute_Click(object sender, EventArgs e)
        {
            soundPlayer.Stop();
        }

        private void lightToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuToolStrip.Font = new Font(FontFamily.GenericSansSerif, 12.0F, FontStyle.Bold);
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            socket.IP = IPTextBox.Text;

            if (!socket.ConnectServer())
            {
                socket.CreateServer();

                Thread listenThread = new Thread(() =>
                {
                    while (true)
                    {
                        Thread.Sleep(500);
                        try
                        {
                            Listen();
                            break;
                        }
                        catch
                        {

                        }
                    }
                });
                listenThread.IsBackground = true;
                listenThread.Start();
            }
            else
            {
                Thread listenThread = new Thread(() =>
                {
                    Listen();
                });
                listenThread.IsBackground = true;
                listenThread.Start();

                socket.Send("Thông tin từ Client");
            }

        }

        private void player1Form_Shown(object sender, EventArgs e)
        {
            // Kết nối thông qua Wifi
            IPTextBox.Text = socket.GetLocalIPv4(NetworkInterfaceType.Wireless80211);

            if (string.IsNullOrEmpty(IPTextBox.Text))
            {
                IPTextBox.Text = socket.GetLocalIPv4(NetworkInterfaceType.Ethernet);
            }
        }

        void Listen()
        {
            string data = (string)socket.Receive();
            MessageBox.Show(data);
        }
    }
}
