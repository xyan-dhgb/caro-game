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
        SettingControl settingControl;
        public player1Form()
        {
            InitializeComponent();

            ChessBoard = new ChessBoardManager(chessBoardPanel, nameTextBox, player1Image);
            // Vẽ bàn cờ
            ChessBoard.DrawChessBoard();

            settingControl = new SettingControl();
        }
    }
}
