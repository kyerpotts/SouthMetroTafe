/*
 * 30003389
 * Kyer Potts
 */
package carpackage;

import java.util.ArrayList;
import java.util.Collections;

/** Car class holds all information relating to specific instances of car objects, and contains methods for sorting and displaying the relevant information. */
public class Car implements Comparable<Car>, java.io.Serializable{
    private String make;
    private String model;
    private String year;
    private int odometer;
    
    public Car(String make){
        this.make = make;
    }
    
    public Car (String make, String model, String year, int odometer){
        this.make = make;
        this.model = model;
        this.year = year;
        this.odometer = odometer;
    }
    /** Display method prints the information contained within each instance of the Car object */
    public void display(){
        System.out.println("" + make + " " + model + "\t\tYear: " + year);
        System.out.println("\t\t\tkm travelled: " + odometer);
    }
    /** Returns the make of the car Object*/
    public String getMake(){
        return make;
    }
    /** Compare method used for sort algorithm */
    public int compareTo(Car compareCar){
        
        return this.make.compareTo(compareCar.getMake());
        
    }
}
