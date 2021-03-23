/*
 * Kyer Potts
 * 30003389
 */
package multilevelinheritance;

public class WheeledVehicle extends Vehicle{
    private int directions = 4;
    private int currentDirection;
    
    public void DirectVehicle(int d){
        this.currentDirection = d;
    }
    
    public int showCurrentDirection(){
        return currentDirection;
    }
}
