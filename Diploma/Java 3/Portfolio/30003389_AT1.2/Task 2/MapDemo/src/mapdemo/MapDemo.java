/*
 * Kyer Potts
 * 30003389
 */
package mapdemo;

public class MapDemo {

    public static void main(String[] args) {
        Map<Integer, String> carYear1 = new Map(1989, "GT-R");
        Map<Integer, String> carYear2 = new Map(1969, "Capri");
        Map<Integer, String> carYear3 = new Map(1953, "Corvette C1");
        System.out.println("Cars:\n" + carYear1 + carYear2 + carYear3);
    }
    
}
