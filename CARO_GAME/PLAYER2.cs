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
    public partial class player2Form : Form
    {
        ChessBoardManager ChessBoard;
        public player2Form()
        {
            InitializeComponent();

            ChessBoard = new ChessBoardManager(chessBoardPanel, nameTextBox, player2Image);
            // Vẽ bàn cờ
            ChessBoard.DrawChessBoard();
        }
    }
}
