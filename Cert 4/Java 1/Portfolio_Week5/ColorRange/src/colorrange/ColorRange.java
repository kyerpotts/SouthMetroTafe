/*
 * 30003389
 * Kyer Potts
 */
package colorrange;

import java.util.*;
        
public class ColorRange {

   
    public static void main(String[] args) {
        
        Scanner readIn = new Scanner(System.in);
        String violet = "Violet";
        String blue = "Blue";
        String green = "Green";
        String yellow = "Yellow";
        String orange = "Orange";
        String red = "Red";
        
        System.out.println("Enter a colour code");
        
        double value = readIn.nextDouble();
        
        if((value >= 380) && (value <= 450)){
            System.out.println("The colour is " + violet);
        }
        else if((value >= 450) && (value <= 495)){
            System.out.println("The colour is " + blue);
        }
        else if((value >= 495) && (value <= 570)){
            System.out.println("The colour is " + green);
        }
        else if((value >= 570) && (value <= 590)){
            System.out.println("The colour is " + yellow);
        }
        else if((value >= 590) && (value <= 620)){
            System.out.println("The colour is " + orange);
        }
        else if((value >= 620) && (value <= 750)){
            System.out.println("The colour is " + red);
        }
        else{
            System.out.println("The entered wavelength is not a part of the visible spectrum.");
        }
    }   
}
