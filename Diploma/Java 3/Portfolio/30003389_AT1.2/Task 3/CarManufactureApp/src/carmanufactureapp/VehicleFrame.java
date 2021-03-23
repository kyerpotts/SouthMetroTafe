/*
 * 30003389
 * Kyer Potts
 */
package carmanufactureapp;

public class VehicleFrame implements Chassis {
    private String vehicleFrameType;
    
    public VehicleFrame(){
        this.vehicleFrameType = "Unibody";
    }
    public VehicleFrame(String vehicleFrameType){
        this.vehicleFrameType = vehicleFrameType;
    }
    
    public Chassis getChassisType(){
        return this;
    }
    public void setChassisType(String vehicleChassis){
        this.vehicleFrameType = vehicleChassis;
    }
    
    public String toString() {
        return "Chassis : " + Chassis.chassis + "\n" + "Vehicle Frame : " + this.vehicleFrameType;
    }
    
}
