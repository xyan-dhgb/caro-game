using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CARO_GAME
{
    public class ChessBoardManager
    {
        #region Properties
        private Panel chessBoard;

        public Panel ChessBoard
        {
            get { return chessBoard;  }
            set { chessBoard = value; }
        }

        private List<Player> player;

        public List<Player> Player 
        { 
            get => player; 
            set => player = value; 
        }

        private int currentPlayer;
        public int CurrentPlayer
        {
            get => currentPlayer;
            set => currentPlayer = value; 
        }

        private TextBox playerName;
        public TextBox PlayerName 
        { 
            get => playerName; 
            set => playerName = value; 
        }
       
        private PictureBox playerMark;
        public PictureBox PlayerMark 
        { 
            get => playerMark; 
            set => playerMark = value; 
        }

        // Ý tưởng xét thắng thua: 
        // Phải biết được các button nào nằm cùng hàng (Xét các ký tự trùng)
        // Lưu các button vào trong ma trận (Sử dụng danh sách chồng danh sách) => Mỗi button phải lưu lại được 
        // nó nằm ở hàng nào (Để dễ dàng tìm ra vị trí sau đó truy xuất các vị trí còn lại).

        private List<List<Button>> matrix;

        private List<List<Button>> Matrix
        {
            get => matrix;
            set => matrix = value;
        }
        #endregion

        #region Initialize
        public ChessBoardManager(Panel chessBoard, TextBox playerName, PictureBox mark)
        {
            this.ChessBoard = chessBoard;
            this.PlayerName = playerName;
            this.PlayerMark = mark;
            this.Player = new List<Player>()
            {
                new Player("YOU", Image.FromFile(Application.StartupPath + "\\Resources\\tick.jpg")),
                new Player("AI", Image.FromFile(Application.StartupPath + "\\Resources\\circle.jpg"))
            };

            currentPlayer = 0;
            changePlayer();
        }

        #endregion

        #region Methods

        public void DrawChessBoard()
        {
            // Khởi tạo thắng thua vì sẽ có trường hợp New game
            Matrix = new List<List<Button>>();

            Button oldButton = new Button() { Width = 0, Location = new Point(0, 0) };
            for (int i = 0; i < Constant.CHESS_BOARD_HEIGHT; i++)
            {
                Matrix.Add(new List<Button>());
                for (int j = 0; j < Constant.CHESS_BOARD_WIDTH; j++)
                {
                    Button btn = new Button()
                    {
                        Width = Constant.CHESS_WIDTH,
                        Height = Constant.CHESS_HEIGTH,
                        Location = new Point(oldButton.Location.X + oldButton.Width, oldButton.Location.Y),
                        BackgroundImageLayout = ImageLayout.Stretch,
                        Tag = i.ToString()
                    };

                    btn.Click += btn_Click;

                    ChessBoard.Controls.Add(btn);

                    Matrix[i].Add(btn);

                    oldButton = btn;
                }
                oldButton.Location = new Point(0, oldButton.Location.Y + Constant.CHESS_HEIGTH);
                oldButton.Width = 0;
                oldButton.Height = 0;
            }
        }
        void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (btn.BackgroundImage != null)
            {
                return;
            }

            Mark(btn);

            changePlayer();

            if (isEndGame(btn))
            {
                EndGame();
            }
        }

        private void EndGame()
        {
            MessageBox.Show("Your game is over!!!", "Look at me", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private bool isEndGame(Button btn)
        {
            return isEndHorizontal(btn) || isEndVertical(btn) || isEndPrimaryDiagonal(btn) || isEndSecondDiagonal(btn) ;
        }

        // Hàm lấy tọa độ
        private Point getChessPoint(Button btn)
        {
            // Lấy tọa độ hàng dọc
            int vertical = Convert.ToInt32(btn.Tag);
            // Lấy tọa độ hàng ngang
            int horizontal = Matrix[vertical].IndexOf(btn);

            Point point = new Point(horizontal, vertical);

            return point;
        }


        // Kết thúc game ở hàng ngang
        // Ý tưởng: Đếm các button bên trái hoặc phải, nếu chúng cộng lại = 5 thì WIN 
        private bool isEndHorizontal(Button btn) 
        { 
            Point point = getChessPoint(btn);
            int countLeft = 0;
            for (int i = point.X; i >= 0; i--)
            {
                if (Matrix[point.Y][i].BackgroundImage == btn.BackgroundImage)
                {
                    countLeft++;
                }
                else
                {
                    break;
                }
            }

            int countRight = 0;
            for (int i = point.X+1; i < Constant.CHESS_BOARD_WIDTH; i++)
            {
                if (Matrix[point.Y][i].BackgroundImage == btn.BackgroundImage)
                {
                    countRight++;
                }
                else
                {
                    break;
                }
            }

            return countLeft + countRight == 5;
        }

        // Kết thúc game ở hàng dọc
        private bool isEndVertical(Button btn)
        {
            Point point = getChessPoint(btn);
            int countTop = 0;
            for (int i = point.Y; i >= 0; i--)
            {
                if (Matrix[i][point.X].BackgroundImage == btn.BackgroundImage)
                {
                    countTop++;
                }
                else
                {
                    break;
                }
            }

            int countBottom = 0;
            for (int i = point.Y + 1; i < Constant.CHESS_BOARD_HEIGHT; i++)
            {
                if (Matrix[i][point.X].BackgroundImage == btn.BackgroundImage)
                {
                    countBottom++;
                }
                else
                {
                    break;
                }
            }

            return countTop + countBottom == 5;
        }

        // Kết thúc game ở đường chéo chính
        private bool isEndPrimaryDiagonal(Button btn)
        {
            Point point = getChessPoint(btn);
            int countTop = 0;
            for (int i = 0; i <= point.X; i++)
            {
                // Xét trường hợp vượt qua khỏi mảng
                if (point.X - i < 0 || point.Y - i < 0)
                {
                    break;
                }
                if (Matrix[point.Y - i][point.X - i].BackgroundImage == btn.BackgroundImage)
                {
                    countTop++;
                }
                else
                {
                    break;
                }
            }

            int countBottom = 0;
            for (int i = 1; i < Constant.CHESS_BOARD_WIDTH - point.X; i++)
            {
                // Xét trường hợp vượt qua khỏi mảng
                if (point.Y + i >= Constant.CHESS_BOARD_HEIGHT || point.X + i >= Constant.CHESS_BOARD_WIDTH)
                {
                    break;
                }
                if (Matrix[point.Y + i][point.X + i].BackgroundImage == btn.BackgroundImage)
                {
                    countBottom++;
                }
                else
                {
                    break;
                }
            }

            return countTop + countBottom == 5;
        }

        // Kết thúc game ở đường chéo phụ
        private bool isEndSecondDiagonal( Button btn)
        {
            Point point = getChessPoint(btn);
            int countTop = 0;
            for (int i = 0; i <= point.X; i++)
            {
                // Xét trường hợp vượt qua khỏi mảng
                if (point.X + i > Constant.CHESS_BOARD_WIDTH || point.Y - i < 0)
                {
                    break;
                }
                if (Matrix[point.Y - i][point.X + i].BackgroundImage == btn.BackgroundImage)
                {
                    countTop++;
                }
                else
                {
                    break;
                }
            }

            int countBottom = 0;
            for (int i = 1; i < Constant.CHESS_BOARD_WIDTH - point.X; i++)
            {
                // Xét trường hợp vượt qua khỏi mảng
                if (point.Y + i >= Constant.CHESS_BOARD_HEIGHT || point.X - i < 0)
                {
                    break;
                }
                if (Matrix[point.Y + i][point.X - i].BackgroundImage == btn.BackgroundImage)
                {
                    countBottom++;
                }
                else
                {
                    break;
                }
            }

            return countTop + countBottom == 5;
        }

        private void Mark(Button btn)
        {
            btn.BackgroundImage = Player[currentPlayer].Mark;

            currentPlayer = currentPlayer == 1 ? 0 : 1;
        }

        private void changePlayer ()
        {
            PlayerName.Text = Player[currentPlayer].Name;

            PlayerMark.Image = Player[currentPlayer].Mark;
        }


        
        
        
        
        
        
        
        
        
        
        #endregion
    }
}
