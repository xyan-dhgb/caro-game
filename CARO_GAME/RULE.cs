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
    public partial class RULE : Form
    {
        public RULE()
        {
            InitializeComponent();
        }

        private void RULE_Load(object sender, EventArgs e)
        {
            contentrichTextBox.SelectionFont = new Font(FontFamily.GenericSansSerif, 16.0F, FontStyle.Bold);
            contentrichTextBox.AppendText("Overview\n\n");

            contentrichTextBox.SelectionFont = new Font(FontFamily.GenericSansSerif, 13.0F, FontStyle.Regular);
            contentrichTextBox.AppendText("Caro, also known as Gomoku or Five in a Row, is a traditional board game that is widely popular in many cultures. The game is simple yet challenging, requiring strategic thinking and planning. The objective is to align five of your pieces in a row, either horizontally, vertically, or diagonally, before your opponent does.\n\n");

            contentrichTextBox.SelectionFont = new Font(FontFamily.GenericSansSerif, 16.0F, FontStyle.Bold);
            contentrichTextBox.AppendText("Game Rules\n\n");

            contentrichTextBox.SelectionFont = new Font(FontFamily.GenericSansSerif, 13.0F, FontStyle.Regular);
            contentrichTextBox.AppendText("- Players: The game is played by two players. Each player has 15 seconds to play \n");
            contentrichTextBox.SelectionFont = new Font(FontFamily.GenericSansSerif, 13.0F, FontStyle.Regular);
            contentrichTextBox.AppendText("- Board: The game is played on a grid. Typically, a 15x20 board is used. \n");
            contentrichTextBox.SelectionFont = new Font(FontFamily.GenericSansSerif, 13.0F, FontStyle.Regular);
            contentrichTextBox.AppendText("- Pieces: Each player has a set of pieces. One player uses X pieces, and the other uses O pieces.\n");
            contentrichTextBox.SelectionFont = new Font(FontFamily.GenericSansSerif, 13.0F, FontStyle.Regular);
            contentrichTextBox.AppendText("- Objective: The goal is to be the first player to get an unbroken row of five pieces horizontally, vertically, or diagonally. \n");
            contentrichTextBox.SelectionFont = new Font(FontFamily.GenericSansSerif, 13.0F, FontStyle.Regular);
            contentrichTextBox.AppendText("- Gameplay:\n" +
                "\t * Players take turns placing their pieces on an empty cell of the board.\n " +
                "\t * The first player to align five of their pieces wins the game.\n" +
                "\t * If the board is filled and no player has achieved five in a row, the game is considered a draw. \n\n");

            contentrichTextBox.SelectionFont = new Font(FontFamily.GenericSansSerif, 16.0F, FontStyle.Bold);
            contentrichTextBox.AppendText("Feature\n\n");

            contentrichTextBox.SelectionFont = new Font(FontFamily.GenericSansSerif, 13.0F, FontStyle.Regular);
            contentrichTextBox.AppendText("- Multiplayer Mode: Play against another player on the same device or over a network. \n");

            contentrichTextBox.SelectionFont = new Font(FontFamily.GenericSansSerif, 13.0F, FontStyle.Regular);
            contentrichTextBox.AppendText("- Fantastic Menu: Give you multiple choices to make your game more and more creative. \n");

            contentrichTextBox.SelectionFont = new Font(FontFamily.GenericSansSerif, 13.0F, FontStyle.Regular);
            contentrichTextBox.AppendText("- Music: Allows players to unmute or mute music when they are playing. \n");

            contentrichTextBox.SelectionFont = new Font(FontFamily.GenericSansSerif, 13.0F, FontStyle.Regular);
            contentrichTextBox.AppendText("- Change UI Mode: An excellent feature to change UI mode (light and dark mode). \n");

            contentrichTextBox.SelectionFont = new Font(FontFamily.GenericSansSerif, 13.0F, FontStyle.Regular);
            contentrichTextBox.AppendText("- User-Friendly Interface: Clean and intuitive interface for an enjoyable playing experience. \n");

        }
    }
}
