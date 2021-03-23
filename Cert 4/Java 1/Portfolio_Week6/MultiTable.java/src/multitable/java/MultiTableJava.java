
package multitable.java;
import java.util.*;

/**
 * 30003389
 * Kyer Potts
 */
public class MultiTableJava {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.println("Enter the number you would like the multiple table for");
        int num1 = sc.nextInt();
        
        for(int i = 1; i <= 12; i++){
            System.out.println(num1 + " x " + i + " = " + (num1*i));
        }
    }
    
}
