/*
 * Kyer Potts
 * 30003389
 */
package multilevelinheritance;

public class MultiLevelInheritance {

    
    public static void main(String[] args) {
        Car car = new Car();
        car.MoveVehicle();
        car.RollWindows();
        car.DirectVehicle(3);
        System.out.println("The movement of the car is set to " + car.getMove());
        System.out.println("The state of the windows are set to up " + car.getWindowSetting());
        System.out.println("The direction of the vehicle is " + car.showCurrentDirection());
    }
    
}
