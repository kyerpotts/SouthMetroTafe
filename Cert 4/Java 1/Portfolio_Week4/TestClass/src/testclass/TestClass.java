/*
* 30003389
 * Kyer Potts
 */
package testclass;

import java.util.*;

public class TestClass {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        ComputeMethods cm = new ComputeMethods();

        System.out.println("Enter a Fahrenheit temp to convert to Celcius");
        double temp = cm.fTOC(sc.nextDouble());
        System.out.println("The converted temperature is " + temp);

        System.out.println("Enter enter side 'a' and side 'b' to calculate the hypotenuse");
        double hypotenuse = cm.hypotenuse(sc.nextInt(), sc.nextInt());
        System.out.println("The hypotenuse is " + hypotenuse);
        
        int roll = cm.roll();
        System.out.println("We rolled 2 dice, the result is " + roll);
    }

}
