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
    public partial class player1Form : Form
    {
        ChessBoardManager ChessBoard;
        public player1Form()
        {
            InitializeComponent();

            ChessBoard = new ChessBoardManager(chessBoardPanel, nameTextBox, player1Image);
            
            // Gọi event khi kết thúc lượt của người chơi
            ChessBoard.GameIsEnd += ChessBoard_GameIsEnd;

            // Gọi event khi lượt chơicủa người chơi được đánh dấu
            ChessBoard.PlayerMarked += ChessBoard_PlayerMarked;

            // Thêm dữ liệu vào process bar
            processBar.Step = Constant.COUNT_DOWN_STEP;
            processBar.Maximum = Constant.COUNT_DOWN_TIME;
            processBar.Value = 0;

            timerCountDown.Interval = Constant.COUNT_DOWN_INTERVAL;
            
            // Vẽ bàn cờ
            ChessBoard.DrawChessBoard();

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
            processBar.PerformStep();
            
            if (processBar.Value >= processBar.Maximum) 
            {
                EndGameAnnouncement();
            }

        }
    }
}
