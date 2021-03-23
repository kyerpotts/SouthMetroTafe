/*
 * Kyer Potts
 * 30003389
 */

package factorial;


public class Factorial {
    
    public static double factorial(double v){
        if (v <= 1){
            return 1;
        }
        else {
            return v * factorial(v - 1);
        }
    }

    public static void main(String[] args) {
        double d = 5;
        double result;
        
        result = factorial(d);
        System.out.println("Factorial [" + result + "] of [" + d + "]");
    }

}
