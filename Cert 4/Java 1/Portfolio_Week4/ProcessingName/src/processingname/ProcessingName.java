/*
 * 30003389
 * Kyer Potts
 */
package processingname;
import java.util.*;

public class ProcessingName {

    
    public static void main(String[] args) {
        
        Scanner sc = new Scanner(System.in);
        
        System.out.println("Enter your full name");
        
        String name = sc.nextLine();
        String firstName = name.split(" ")[0];
        char firstInitial = firstName.charAt(0);
        String lastName = name.split(" ")[1];
        System.out.println("Your name is " + lastName + ", " + firstInitial);
        
        
    }
    
}
