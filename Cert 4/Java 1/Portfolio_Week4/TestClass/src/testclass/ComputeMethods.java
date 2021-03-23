/*
 * 30003389
 * Kyer Potts
 */
package testclass;


public class ComputeMethods {
    public double fTOC (double degreesF){
        double c = (double)5/9*(degreesF - 32) ;
        return c;
        
    }
    
    public double hypotenuse (int a, int b){
        double c = Math.sqrt( a * a + b * b);
        return c;
    }
    
    public int roll (){
        int roll = (int)(Math.random() * 11) + 2;
        return roll;
        
    }

}
