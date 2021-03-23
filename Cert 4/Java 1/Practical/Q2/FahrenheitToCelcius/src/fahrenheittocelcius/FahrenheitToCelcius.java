/*
 * 30003389
 * Kyer Potts
 */
package fahrenheittocelcius;
import java.util.Scanner;

public class FahrenheitToCelcius {

    
    public static void main(String[] args) {
        Scanner readIn = new Scanner(System.in);
        System.out.println("Enter the Fahrenheit temperature to convert to Celcius");
        int f = readIn.nextInt();
        double c = (double)(f - 32)* 5/9;
        System.out.println(f + "F converts to " + c + "C");
    }
    
}
