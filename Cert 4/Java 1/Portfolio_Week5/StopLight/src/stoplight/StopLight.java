
package stoplight;
import java.util.*;
/**
 * 30003389
 * Kyer Potts
 */
public class StopLight {

    
    public static void main(String[] args) {
        Scanner readIn = new Scanner(System.in);
        System.out.println("Enter a value for the current colour of the light.");
        System.out.println("Red = 1. Green = 2. Amber = 3.");
        
        int colour = readIn.nextInt();
        
        switch(colour){
            case 1:
                System.out.println("The next traffic light is green");
                break;
                
            case 2:
                System.out.println("The next traffic light is amber");
                break;
                
            case 3:
                System.out.println("The next traffic light is red");
                break;
                
            default:
                System.out.println("Invalid colour code");
                
        }
                
    }
    
}
