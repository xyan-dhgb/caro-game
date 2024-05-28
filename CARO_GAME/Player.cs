using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CARO_GAME
{
    public class Player
    {
        private string name;

        public string Name 
        { 
            get => name; 
            set => name = value; 
        }

        private Image mark;

        public Image Mark
        {
            get => mark;
            set => mark = value;
        }

        public Player(string name, Image mark)
        {
            this.Name = name;
            this.Mark = mark; // Láy theo thứ tự biến toàn cục và cục bộ (Ai ở gần sẽ được ưu tiên)
        }
    }
    
}
