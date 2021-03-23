/*
 * 30003389
 * Kyer Potts
 */
package carmanufactureapp;

import java.util.Date;

public class Car extends Vehicle {

    private int carAxle;

    public Car() {
        super();
        this.carAxle = 2;
    }

    public Car(String vehicleManufacturer, Date vehicleManufacturedDate, String vehicleMake, String vehicleModel, String vehicleType, Chassis vehicleFrame, Engine vehicleEngine, int carAxle) {
        super(vehicleManufacturer, vehicleManufacturedDate, vehicleMake, vehicleModel, vehicleType, vehicleFrame, vehicleEngine);
        this.carAxle = carAxle;
    }

    public String toString() {
        return super.toString() + "\nCar Axle : " + carAxle;
    }
}
