/*
 * Kyer Potts
 * 30003389
 */

package fibonacci;


public class Fibonacci {
    
    public static double fibonacci(int x){
        if (x < 2){
            return x;
        } else {
            return fibonacci(x - 1) + fibonacci(x - 2);
        }
    }

    public static void main(String[] args) {
        int d = 5;
        
        for (int i = 0; i < d; i++){
            System.out.println("Fibonacci index [" + i + "] value [" + fibonacci(i) + "]");
        }
    }

}
