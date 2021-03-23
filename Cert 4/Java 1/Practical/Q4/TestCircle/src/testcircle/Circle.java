/*
 * 30003389
 * Kyer Potts
 */
package testcircle;

public class Circle {
    private double rad;
    Circle(){
        rad = 1;
    }
    Circle(double r){
        rad = r;
    }
    public void CalcCirc(){
        double area = 	Math.PI * Math.pow(rad, 2);
        double circumf = 2 * Math.PI * rad;
        System.out.println("The area of the circle is " + area);
        System.out.println("The circumference of the circle is " + circumf);
    }
    public double getRad(){
        return rad;
    }
    
}
