/*
 * Kyer Potts
 * 30003389
 */
package countrycollection;
import java.util.*;
public class CountryCollection {

    public static void main(String[] args) {
        Set<String> CountriesSet = new HashSet<String>();
        CountriesSet.add("USA");
        CountriesSet.add("Australia");
        CountriesSet.add("Canada");
        CountriesSet.add("Germany");
        CountriesSet.add("France");
        CountriesSet.add("Australia");
        
        for (String c : CountriesSet){
            System.out.println(c);
        }
    }
    
}
