/*
 * Kyer Potts
 * 30003389
 */
package multilevelinheritance;

public class Car extends WheeledVehicle {

    private int numOfWheels = 4;
    private boolean windowSetting = true;

    public void RollWindows() {
        if (windowSetting == true) {
            this.windowSetting = false;
        } else {
            this.windowSetting = true;
        }
    }
    
    public boolean getWindowSetting(){
        return windowSetting;
    }

}
