/*
 * Kyer Potts
 * 30003389
 */

import java.io.*;
import java.net.*;
public class Server {

    public static void main(String[] args) {
        try (ServerSocket serverSocket = new ServerSocket(1234)){
            System.out.println("Server is listening on port #" + serverSocket.getLocalPort());
            try(Socket clientSocket = serverSocket.accept()){
                String clientHostName = clientSocket.getInetAddress().getHostName();
                int clientPortNumber = clientSocket.getLocalPort();
                System.out.println("Connected from " + clientHostName + "on #" + clientPortNumber);
                
                BufferedReader inStream;
                inStream = new BufferedReader(new InputStreamReader(clientSocket.getInputStream()));
                
                DataOutputStream outStream;
                outStream = new DataOutputStream(clientSocket.getOutputStream());
                
                while(true) {
                    String inLine = inStream.readLine();
                    System.out.println("Recieved from client: " + inLine);
                    
                    if (inLine.equalsIgnoreCase("quit")) {
                        System.out.println("Client Disconnected");
                        break;
                    }
                    
                    String outLine = "You said" + inLine + ".";
                    outStream.writeBytes(outLine);
                    outStream.write(13);
                    outStream.write(10);
                    outStream.flush();
                }
                inStream.close();
                outStream.close();
            }
            
        } catch (IOException e ){
            System.err.println("IOException occured" + e);
        }
    }

}
