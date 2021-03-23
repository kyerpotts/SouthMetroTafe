/*
 * Kyer Potts
 * 30003389
 */


import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.io.IOException;
import java.net.Socket;
import java.net.UnknownHostException;
import java.util.Scanner;

public class Client {
    static Socket socket;
    static DataOutputStream outStream;
    static DataInputStream inStream;

    public static void main(String[] args) {
        if (args.length !=2){
            System.out.println("Incorrect arguments used!");
            System.out.println("Usage: java ClientClass hostName port#");
            System.exit(1);
        }
        
        String host = args[0];
        int port = Integer.valueOf(args[1]).intValue();
        
        try {
            socket = new Socket(host, port);
            
            inStream = new DataInputStream(socket.getInputStream());
            outStream = new DataOutputStream(socket.getOutputStream());
        } catch (UnknownHostException e){
            System.out.println(e);
            System.exit(1);
        } catch (IOException e) {
            System.out.println(e);
            System.exit(1);
        }
        
        chat();
        
        try{
            socket.close();
            inStream.close();
            outStream.close();
        } catch (IOException e){
            System.out.println("IO Exception occured" + e);
        }
    }
    
    public static void chat(){
        Scanner sc = new Scanner(System.in);
        
        while(true){
            try {
                String lineInput = sc.nextLine();
                
                if(lineInput.length() > 0) {
                    outStream.writeBytes(lineInput);
                    outStream.write(13);
                    outStream.write(10);
                    outStream.flush();
                    
                    if(lineInput.equalsIgnoreCase("quit")){
                        System.exit(0);
                    }
                    
                    int inByte;
                    System.out.print("Server>>>");
                    while((inByte = inStream.read()) != '\n'){
                        System.out.write(inByte);
                    }
                    System.out.println();
                }
            } catch(IOException e){
                System.out.println(e);
            }
        }
    }

}
