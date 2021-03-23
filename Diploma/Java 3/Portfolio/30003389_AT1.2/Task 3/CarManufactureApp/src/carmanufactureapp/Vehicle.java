/*
 * 30003389
 * Kyer Potts
 */
package carmanufactureapp;

import java.util.Date;

public class Vehicle implements Engine, Chassis {

    private Date vehicleManufacturedDate;
    private String vehicleManufacturer;
    private String vehicleMake;
    private String vehicleModel;
    private Chassis vehicleFrame;
    private String vehicleType;
    private String driveTrain;
    private Engine vehicleEngine;

    public Vehicle() {
        this.vehicleManufacturedDate = new Date();
        this.vehicleManufacturer = "Generic";
        this.vehicleMake = "Generic";
        this.vehicleModel = "Generic";
        this.vehicleType = "None";
        this.vehicleFrame = new VehicleFrame();
        this.vehicleEngine = new ManufacturedEngine();
        this.vehicleEngine.setEngineType("88 AKI");
        this.vehicleEngine.setDriveTrain("2WD: Two-Wheel Drive");
    }

    public Vehicle(String vehicleManufacturer, Date vehicleManufacturedDate, String vehicleMake, String vehicleModel, String vehicleType, Chassis vehicleFrame, Engine vehicleEngine) {
        this.vehicleManufacturedDate = vehicleManufacturedDate;
        this.vehicleManufacturer = vehicleManufacturer;
        this.vehicleMake = vehicleMake;
        this.vehicleModel = vehicleModel;
        this.vehicleType = vehicleType;
        this.vehicleFrame = vehicleFrame;
        this.vehicleEngine = vehicleEngine;
    }

    public void setEngineCylinders(int engineCylinders) {
        vehicleEngine.setEngineCylinders(engineCylinders);
    }

    public void setEngineManufacturedDate(Date date) {
        vehicleEngine.setEngineManufacturedDate(date);
    }

    public void setEngineManufacturer(String manufacturer) {
        this.vehicleManufacturer = manufacturer;
    }

    public void setEngineMake(String engineMake) {
        this.vehicleEngine.setEngineMake(engineMake);
    }

    public void setEngineModel(String engineModel) {
        this.vehicleEngine.setEngineModel(engineModel);
    }

    public void setDriveTrain(String driveTrain) {
        this.vehicleEngine.setDriveTrain(driveTrain);
    }

    public void setEngineType(String fuel) {
        this.vehicleEngine.setEngineType(fuel);
    }

    public Chassis getChassisType() {
        return vehicleFrame;
    }

    public void setChassisType(String vehicleChassis) {
        this.vehicleFrame.setChassisType(vehicleChassis);
    }

    public String toString() {
        return "Manufacturer Name : " + this.vehicleManufacturer + "\n"
                + "Manufactured Date : " + this.vehicleManufacturedDate.toString() + "\n"
                + "Vehicle Make : " + this.vehicleMake + "\n" + "Vehicle Model : " + this.vehicleModel + "\n"
                + "Vehicle Type : " + this.vehicleType + "\n"
                + vehicleEngine.toString();
    }
}
