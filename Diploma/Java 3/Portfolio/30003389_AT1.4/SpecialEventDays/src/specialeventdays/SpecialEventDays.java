/*
 * Kyer Potts
 * 30003389
 */

package specialeventdays;
import java.util.ArrayList;
import java.util.Scanner;
import java.util.regex.*;

public class SpecialEventDays {

    public static void main(String[] args) {
        ArrayList<Date> specialEventDays = new ArrayList<Date>();
        Scanner sc = new Scanner(System.in);
        Pattern dp = Pattern.compile("(0[1-9]|[12][0-9]|3[01])/(0[1-9]|1[012])/([0-9]{4})");
        Matcher dm;
        System.out.println("Please enter special event days in the DD/MM/YYYY format. An invalid format will terminate the user input");
        String specialDate = sc.next();
        
        dm = dp.matcher(specialDate);
        
        while(dm.matches()){
            Date d = new Date(dm.group(1), dm.group(2), dm.group(3));
            specialEventDays.add(d);
            System.out.println("Enter another special event day in the DD/MM/YYYY format. An invalid format will terminate the user input");
            specialDate = sc.next();
            dm = dp.matcher(specialDate);
        }
        
        System.out.println("Invalid date format entered, terminating user input.");
        
        sc.close();
        
        for (Date d: specialEventDays){
            d.PrintDate();
        }
        
        System.out.println("You have " + specialEventDays.size() + " special event days.");
    }
}
