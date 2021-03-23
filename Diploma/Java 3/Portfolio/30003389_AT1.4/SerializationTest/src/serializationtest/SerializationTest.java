/*
 * Kyer Potts
 * 30003389
 */

package serializationtest;

import java.io.*;

public class SerializationTest {
    
    public static void WriteTest(Person es, String filePath){
        try {
            FileOutputStream fileOut = new FileOutputStream(filePath);
            ObjectOutputStream out = new ObjectOutputStream(fileOut);
            out.writeObject(es);
            out.close();
            fileOut.close();
        }catch (Exception ex){
            System.out.println(ex);
        } finally {
            System.out.println("Wrote object to file " + filePath);
        }
    }
    
    public static void ReadTest(String filePath){
        try{
            FileInputStream fileIn = new FileInputStream(filePath);
            ObjectInputStream in = new ObjectInputStream(fileIn);
            Person p = (Person) in.readObject();
            in.close();
            System.out.println(p);
        }catch (Exception ex){
            System.out.println(ex);
        }
    }

    public static void main(String[] args) {
        String filePath = "example.bin";
        
        Person p1 = new Person("Mike", 20);
        System.out.println("Original: " + p1);
        
        WriteTest(p1, filePath);
        ReadTest(filePath);
    }
}
