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

==> Client and Server have successfully connected.

==> Go to [network_flow_chart](https://github.com/andreafletcherdinh/CARO/blob/main/network_Diagram.drawio.png) for more details
