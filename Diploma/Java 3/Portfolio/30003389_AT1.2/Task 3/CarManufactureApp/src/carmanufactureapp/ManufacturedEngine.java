/*
 * 30003389
 * Kyer Potts
 */
package carmanufactureapp;

import java.util.Date;

public class ManufacturedEngine implements Engine {

    private String engineManufacturer;
    private Date engineManufacturedDate;
    private String engineMake;
    private String engineModel;
    private int engineCylinders;
    private String engineType;
    private String driveTrain;

    public ManufacturedEngine() {
        this.engineManufacturer = "Generic";
        this.engineManufacturedDate = new Date();
        this.engineMake = "Generic";
        this.engineModel = "Generic";
        this.engineCylinders = 0;
        this.engineType = "85 AKI";
        this.driveTrain = "2WD: Two-Wheel Drive";
    }

    public ManufacturedEngine(String engineManufacturer, Date engineManufacturedDate, String engineMake, String engineModel, String driveTrain, int engineCylinders, String engineType) {
        this.engineManufacturer = engineManufacturer;
        this.engineManufacturedDate = engineManufacturedDate;
        this.engineMake = engineMake;
        this.engineModel = engineModel;
        this.engineCylinders = engineCylinders;
        this.engineType = engineType;
        this.driveTrain = driveTrain;
    }

    public final void setEngineManufacturedDate(Date date) {
        this.engineManufacturedDate = date;
    }

    public final void setEngineManufacturer(String manufacturer) {
        this.engineManufacturer = manufacturer;
    }

    public void setEngineMake(String engineMake) {
        this.engineMake = engineMake;
    }

    public void setEngineModel(String engineModel) {
        this.engineModel = engineModel;
    }

    public final void setEngineType(String fuel) {
        this.engineType = fuel;
    }

    public void setEngineCylinders(int engineCylinders) {
        this.engineCylinders = engineCylinders;
    }

    public void setDriveTrain(String driveTrain) {
        this.driveTrain = driveTrain;
    }

    public String toString() {
        return "Engine Manufacturer : " + this.engineManufacturer + "\n"
                + "Engine Manufactured : " + this.engineManufacturedDate.toString() + "\n"
                + "Engine Make : " + this.engineMake + "\n"
                + "Engine Model : " + this.engineModel + "\n"
                + "Engine Type : " + this.engineType + "\n"
                + "Engine Cylinders : " + this.engineCylinders + "\n"
                + "Drive Train : " + this.driveTrain;
    }
}
