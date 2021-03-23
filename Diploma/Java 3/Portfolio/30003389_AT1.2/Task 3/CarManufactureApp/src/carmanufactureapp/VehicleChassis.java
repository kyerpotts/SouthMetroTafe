/*
 * 30003389
 * Kyer Potts
 */
package carmanufactureapp;

public class VehicleChassis implements Chassis{
    private String chassisName;
    
    public VehicleChassis(){
        this.chassisName = Chassis.chassis;
    }
    public VehicleChassis(String chassisName){
        this.chassisName = chassisName;
    }
    
    public Chassis getChassisType(){
        return this;
    }
    
    public void setChassisType(String vehicleChassis){
        this.chassisName = vehicleChassis;
    }
    
    public String toString(){
        return "Chassis Name: " + this.chassisName;
    }
}
