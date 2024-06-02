// Thiết lập cơ chế truyền tọa độ (02.06.2024)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Drawing;

namespace CARO_GAME
{
    [Serializable] 
    public class SocketData
    {
        private int command;

        public int Command
        {
            get => command;
            set => command = value;
        }
        private Point point;
        public Point Point
        {
            get => point;
            set => point = value;
        }

       private string message;

       public string Message
        {
            get => message;
            set => message = value;
        }

        public SocketData(int command, string message, Point point)
        {
            this.Command = command;
            this.Point = point;
            this.Message = message;
        }

        
    }

    // enum (viết tắt của "enumeration") là một kiểu dữ liệu đặc biệt cho phép bạn định nghĩa một tập hợp các hằng số có tên.
    public enum SocketCommand
    {
        SEND_POINT,
        NOTIFICATION,
        NEW_GAME,
        END_GAME,
        QUIT
    }

}
