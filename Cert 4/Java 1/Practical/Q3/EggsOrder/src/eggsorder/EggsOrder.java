/*
 * 30003389
 * Kyer Potts
 */
package eggsorder;
import java.util.Scanner;
import java.text.DecimalFormat;

public class EggsOrder {

    public static void main(String[] args) {
        Scanner readIn = new Scanner(System.in);
        DecimalFormat df = new DecimalFormat("###.##");
        System.out.println("How many eggs would you like to buy?");
        int eggs = readIn.nextInt();
        int dozen = eggs / 12;
        int single = eggs % 12;
        double dozenCost = (double)dozen * 7.25;
        double singleCost = (double)single * 0.75;
        double totalCost = dozenCost + singleCost;
        System.out.println("You ordered " + eggs + ". That is " + dozen + " dozen eggs at $7.25. And " + single + " additional eggs at $0.75 each for a total of $" + df.format(totalCost));
    }
    
}
