/*
 * Kyer Potts
 * 30003389
 */
package multilevelinheritance;

public class Vehicle {
    private boolean move;
    
    public void MoveVehicle(){
        setMove(true);
    }
    public void StopVehicle(){
        setMove(false);
    }

    public boolean getMove() {
        return move;
    }

    public void setMove(boolean move) {
        this.move = move;
    }
    
}
