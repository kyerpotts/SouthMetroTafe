/*
 * Kyer Potts
 * 30003389
 */
package squarenumber;

import java.io.*;
import java.net.*;

public class Server {

    private Socket socket = null;
    private ServerSocket server = null;
    private DataInputStream in = null;
    private DataOutputStream out = null;
    private PrintWriter pWriter;

    private static int squareNumber(int num) {
        int squaredNum = num * num;
        return squaredNum;
    }

    public Server(int port) {
        try {
            server = new ServerSocket(port);
            System.out.println("Waiting for client to connect ...");

            socket = server.accept();
            System.out.println("Client connected");
            out = new DataOutputStream(socket.getOutputStream());
            pWriter = new PrintWriter(out, true);
            in = new DataInputStream(new BufferedInputStream(socket.getInputStream()));
            String line = "";
            //String over = "Over";

            while (!line.equals("Over")) {
                try {
                    line = in.readUTF();
                    line = Integer.toString(squareNumber(Integer.parseInt(line)));
                    pWriter.println(line);
                    pWriter.flush();

                } catch (Exception e) {
                    System.out.println("Encountered an error!" + e);
                }
            }
            in.close();
            out.close();
            socket.close();
            pWriter.close();
        } catch (Exception e) {
            System.out.println("Client has been disconnected" + e);
        }
    }

    public static void main(String[] args) {
        Server server = new Server(1234);

    }

}
