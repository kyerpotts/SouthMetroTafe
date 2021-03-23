/*
 * Kyer Potts
 * 30003389
 */

package specialeventdays;


public class Date {
    public String day;
    public String month;
    public String year;
    
    public Date(String d, String m, String y){
        day = d;
        month = m;
        year = y;
    }
    
    public void PrintDate(){
        System.out.println("Day: " + day + ", Month: " + month + ", Year: " + year);
    }
    
}
