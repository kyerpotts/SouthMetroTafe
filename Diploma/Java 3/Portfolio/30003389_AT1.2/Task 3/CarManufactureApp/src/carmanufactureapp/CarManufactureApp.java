/*
 * 30003389
 * Kyer Potts
 */
package carmanufactureapp;
import java.util.Date;
public class CarManufactureApp {

    public static void main(String[] args) {
        // Test default constructor and print instance attributes.
        Car c1 = new Car();
        
        System.out.println("------------------------------------------------------------");
        System.out.println(c1);
        System.out.println("------------------------------------------------------------");
        
        // Test overloaded constructor and print instance attributes.
        Car c2 = new Car("Honda", new Date(1325599999999L), "Honda", "Prelude", "Coupe", new VehicleChassis("Unibody"), new ManufacturedEngine("Honda", new Date(), "H-Series", "H23A1", "2WD: Two-Wheel Drive", 4, "88 AKI"), 2);
        System.out.println(c2);
    }
}
