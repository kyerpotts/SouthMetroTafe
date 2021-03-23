package dice;

/**
 * 30003389
 * Kyer Potts
 */
public class Dice {

    public static void main(String[] args) {
        
        int roll_1 = (int)(Math.random() * 6) + 1;
        int roll_2 = (int)(Math.random() * 6) + 1;
        int roll_3 = (int)(Math.random() * 6) + 1;
        
        
        System.out.println("Your dice rolls are:");
        System.out.println(roll_1);
        System.out.println(roll_2);
        System.out.println(roll_3);
        
    }
    
}
