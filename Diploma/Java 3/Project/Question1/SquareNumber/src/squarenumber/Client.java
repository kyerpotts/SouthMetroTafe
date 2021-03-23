/*
 * Kyer Potts
 * 30003389
 */
package squarenumber;

import java.io.BufferedReader;
import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.io.IOException;
import java.io.InputStreamReader;
import java.net.Socket;
import java.net.UnknownHostException;

public class Client {

    private Socket socket = null;
    private DataInputStream in = null;
    private DataOutputStream out = null;

    private static boolean isNumeric(String message) {
        try {
            Integer.parseInt(message);
            return true;
        } catch (NumberFormatException e) {
            return false;
        }
    }

    public Client(String address, int port) {
        try {
            socket = new Socket(address, port);
            System.out.println("Connected");

            in = new DataInputStream(System.in);
            out = new DataOutputStream(socket.getOutputStream());

        } catch (UnknownHostException e) {
            System.out.println(e);
        } catch (IOException i) {
            System.out.println(i);
        }

        String line = "";
        //String over = "Over";
        String recieveMessage;
        while (!line.equals("Over")) {
            try {
                System.out.println("Please enter a number to square or 'Over'");
                BufferedReader received = new BufferedReader(new InputStreamReader(socket.getInputStream()));
                line = in.readLine();
                if (isNumeric(line)) {
                    out.writeUTF(line);
                }
                if (line.equals("Over")) {
                    out.writeUTF(line);
                    System.out.println("Disconnecting...");
                }
                if ((recieveMessage = received.readLine()) != null) {
                    System.out.println(line + " squared is " + recieveMessage);
                }
            } catch (IOException e) {

                System.out.println(e);
            }
        }
        try {
            in.close();
            out.close();
            socket.close();
        } catch (IOException e) {
            System.out.println(e);
        }
    }

    public static void main(String[] args) {
        Client client = new Client("127.0.0.1", 1234);
    }

}
