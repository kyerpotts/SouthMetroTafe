
package totalaverage;

import java.util.*;

public class TotalAverage {

    
    public static void main(String[] args) {
       
        Scanner sc = new Scanner(System.in);
        
        System.out.println("Enter a number");
        double num1 = sc.nextDouble();
        
        System.out.println("Enter another number");
        double num2 = sc.nextDouble();
        
        System.out.println("Enter another number");
        double num3 = sc.nextDouble();
        
        double total = (num1 + num2 + num3);
        
        double average = (total / 3);
        
        System.out.println("The total of the three numbers is " + total);
        
        System.out.println("Enter average of the three numbers is " + average);
    }
    
}
