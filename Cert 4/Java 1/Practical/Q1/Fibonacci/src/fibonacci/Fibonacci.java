/*
 * 30003389
 * Kyer Potts
 */
package fibonacci;

import java.util.Scanner;

public class Fibonacci {
    
    public static void main(String[] args) {
        Scanner readIn = new Scanner(System.in);
        System.out.println("How high would you like the sequence to reach?");
        int numLoops = readIn.nextInt();
        int num1 = 0;
        int num2 = 1;
        int result = 0;
        System.out.println(num1);
        System.out.println(num2);
        while(true){
            result = num1 + num2;
            num1 = num2;
            num2 = result;
            if( result < numLoops){
                System.out.println(result);
            }
            else{
                return;
            }
            
            
        }
        
    }
    
}
