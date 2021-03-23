
package numberwithspaces;

import java.util.*;

public class NumberWithSpaces {

    
    public static void main(String[] args) {
    
        Scanner sc = new Scanner(System.in);
        
        System.out.println("Enter a 5 digit number");
        int num = sc.nextInt();
        
        int num1  = num / 10000;
        
        int num2 = (num % 10000)/1000;
        
        int num3 = ((num % 10000) % 1000) / 100;
        
        int num4 = (((num % 10000) % 1000) % 100) / 10;
        
        int num5 = (((num % 10000) % 1000) % 100) % 10;
        
        System.out.println(num1 + "   " + num2 + "   " + num3 + "   " + num4 + "   " + num5);
        
    }
    
}
