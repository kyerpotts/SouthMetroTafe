/*
 * 30003389
 * Kyer Potts
 */
package wordwriterfromuser;

import java.util.Scanner;
import java.nio.file.*;
import java.io.*;
import static java.nio.file.StandardOpenOption.*;


public class WordWriterFromUser {

    public static void main(String[] args) {
        Scanner readIn = new Scanner(System.in);
        System.out.println("Enter a single word with no spaces");
        String word = readIn.nextLine();
        
            while(word.contains(" ")) {
                System.out.println("You entered a space, please try again");
                word = readIn.nextLine();
                }
            Path file = Paths.get("F:\\Java 1\\Practical\\Q6\\Word.txt");
            byte[] data = word.getBytes();
            OutputStream output;
            try{
                output = new BufferedOutputStream(Files.newOutputStream(file, CREATE));
                output.write(data);
                output.flush();
                output.close();
            }catch (Exception e){
                System.out.println("Message: " + e);
            }
           
        
        
    }

}
