/**
 * @author Kyer Potts
 * @version version 1
 * @30003389
 */

/**
 * Package contains variables and methods associated with the creation of car objects
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
    
    /**
     * Creates a Car object with  the following parameters
     * 
     * @param make Contains the make of the car object
     * @param model Contains the model of the car object
     * @param year Contains the year of the car object
     * @param odometer Contains the odometer reading of the car object
     */
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
    /** Compare method used for sort algorithm
     * @param compareCar the string used to match against the comparable interface arguments
     */
    public int compareTo(Car compareCar){
        
        return this.make.compareTo(compareCar.getMake());
        
    }
}

