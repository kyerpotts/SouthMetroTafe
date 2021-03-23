/*
 * Kyer Potts
 * 30003389
 */

package openfile;

import java.io.*;
import java.awt.Desktop;

public class OpenFile {

    public static void main(String[] args) throws IOException {
        File file = new File("myFile.txt");
        try{
            if(Desktop.isDesktopSupported()){
                Desktop.getDesktop().open(file);
            }
        } catch(MyException ex){
            System.out.println("Exception: " + ex.getMessage());
        }
    }
}
