/*
 * 30003389
 * Kyer Potts
 */
package testcircle;
import java.util.Scanner;
public class TestCircle {

    
    public static void main(String[] args) {
        Scanner readIn = new Scanner(System.in);
        Circle[] circs = new Circle[5];
        
        for(int i = 0; i < 5; i++){
        System.out.println("Enter a value for circle " + (i + 1));
        circs[i] = new Circle(readIn.nextDouble());
        }
        for(int i = 0; i< 5; i++){
            if(circs[i].getRad() == 1.0){
                System.out.println("Circle " + (i + 1) + ":");
                System.out.println("This unit is a circle");
                System.out.println();
            }
            else{
                System.out.println("Circle " + (i + 1) + ":");
                circs[i].CalcCirc();
                System.out.println();
            }
        }
       
    }
    
}
