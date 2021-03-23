/*
 * 30003389
 * Kyer Potts 
 */
package wordreaderfromfile;

import java.nio.file.*;
import java.io.*;


public class WordReaderFromFile {
    
    public static void main(String[] args) {
        Path file = Paths.get("F:\\Java 1\\Practical\\Q6\\Word.txt");
        InputStream input;
        try{
            input = Files.newInputStream(file);
            BufferedReader reader = new BufferedReader(new InputStreamReader(input));
            String word = reader.readLine();
            System.out.println(word);
            input.close();
        }catch(IOException e){
            System.out.println(e);
        }catch(Exception e){
            System.out.println(e);
        }
    }
}
