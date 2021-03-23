
package pinvalidator;
import java.util.*;
/**
 * 30003389
 * Kyer Potts
 */
public class PinValidator {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        
        System.out.println("Set a new pin");
        int newPin = sc.nextInt();
        System.out.println("Enter your pin");
        int pin = sc.nextInt();
        
        while(pin != newPin){
            System.out.println("The pin entered is not correct, please try again");
            pin = sc.nextInt();
        }
        System.out.println("That is the correct pin");
    }
    
}
