# NOTE ABOUT THE NETWORK PART OF CARO GAME (TCP connection)

1 form is both a client and a server (client joins the room and the server creates the room)

+ To create a room, you must CHECK the connection
  1. If there is a room => Connect => Create client
  2. If there is not => Not connected => Create server => Create IP (shared network, shared port (allows transmission to the correct application))

+ In case the Client connects to the Server:
  1. If there is no Server => Connection error
  2. If there is a Server => OK

+ The Server is responsible for initializing => Bind (waiting for connection) => Listen (listening to Client)
  1. If the Server does not accept => Cut
  2. If the Server accepts => Connect

==> Client and Server have successfully connected

- Sơ đồ giải thuật:
          +----------------------------+
           |          Start             |
           +----------------------------+
                          |
                          v
           +----------------------------+
           |  Khởi động ứng dụng        |
           +----------------------------+
                          |
                          v
           +----------------------------+
           |  Kiểm tra kết nối          |
           +----------------------------+
                          |
         +------------------------+
         |                        |
         v                        v
+------------------------+  +------------------------+
|  Không có phòng        |  |  Có phòng              |
+------------------------+  +------------------------+
         |                        |
         v                        v
+------------------------+  +------------------------+
|  Tạo Server            |  |  Tạo Client            |
+------------------------+  +------------------------+
         |                        |
         v                        v
+------------------------+  +------------------------+
|  Tạo IP (chung mạng,   |  |  Client kết nối đến    |
|  chung port)           |  |  Server                |
+------------------------+  +------------------------+
         |                        |
         v                        v
+------------------------+  +------------------------+
|  Server khởi tạo       |  |  Có Server?            |
+------------------------+  +------------------------+
         |                        +---------+
         v                        |         |
+------------------------+        |         |
|  Bind (đợi kết nối)    |        |         v
+------------------------+        |  +--------------------+
         |                        |  |  Không có Server   |
         v                        |  +--------------------+
+------------------------+        |         |
|  Listen (lắng nghe     |        |         v
|  Client)               |        |  +--------------------+
+------------------------+        |  |  Lỗi kết nối       |
         |                        |  +--------------------+
         v                        |
+------------------------+        |
|  Accept (chấp nhận     |        v
|  kết nối)              |  +--------------------+
+------------------------+  |  Có Server         |
         |                   +--------------------+
         v                            |
+------------------------+            v
|  Server chấp nhận?     |  +--------------------+
+------------------------+  |         OK         |
         |                        +--------------------+
         |                        |
         v                        v
+------------------------+  +------------------------+
|  Không chấp nhận       |  |  Kết nối thành công    |
+------------------------+  +------------------------+
         |                        |
         v                        v
+------------------------+  +------------------------+
|  Cắt                   |  |  Client và Server đã   |
+------------------------+  |  kết nối thành công    |
         |                        +------------------------+
         v                                 |
+----------------------------+             |
|            End             |             v
+----------------------------+  +----------------------------+
                               |            End             |
                               +----------------------------+
