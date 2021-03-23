/*
 * Kyer Potts
 * 30003389
 */

package backwardsday;


public class BackwardsDay {

    public static void main(String[] args) {
        String startword = "Monday";
        System.out.println(backwardsDay(startword));
        
    }
    
    public static String backwardsDay(String original){
        String backwards = "";
        for (int i = original.length() -1; i>=0; i--){
            backwards += original.substring(i, i+1);
        }
        return backwards;
    }

}
