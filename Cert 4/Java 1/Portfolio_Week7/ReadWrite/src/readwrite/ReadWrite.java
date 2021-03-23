package readwrite;
import java.nio.file.*;
import java.io.*;
import static java.nio.file.StandardOpenOption.*;

/**
 * 30003389
 * Kyer Potts
 */
public class ReadWrite {

    
    public static void main(String[] args) {
        
        Path file = Paths.get("Example.txt");
        String examp = "Example Data";
        byte[] data = examp.getBytes();
        OutputStream output = null;
        try{
            output = new BufferedOutputStream(Files.newOutputStream(file, CREATE));
            output.write(data);
            output.flush();
            output.close();
        }catch (Exception e){
            System.out.println("Message: " + e);
        }
        
        file = Paths.get("Example.txt");
        InputStream input = null;
        
        try{
            input = Files.newInputStream(file);
            BufferedReader reader = new BufferedReader(new InputStreamReader(input));
            String s = reader.readLine();
            System.out.println(s);
            input.close();
        }catch (IOException e){
            System.out.println(e);
        }
        catch (Exception e){
            System.out.println(e);
        }
    }
    
}
