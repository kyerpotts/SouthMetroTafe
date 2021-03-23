/*
 * Kyer Potts.
 * 30003389
 */
package sortedstrings;
import java.util.Arrays;
public class SortedStrings {

    public static void main(String[] args) {
        String[] nameArray = {"Jim", "Carl", "Bob", "Kyer", "Charlie"};
        
        Arrays.sort(nameArray);
        
        for (String n : nameArray){
            System.out.println(n);
        }
        
        int result = binarySearch(nameArray, "Kyer");
        if(result == -1){
            System.out.println("Name was not found in the array");
        } else{
            System.out.println("Name found at index " + result);
        }
    }
    
    public static int binarySearch(String[] arr, String x){
            int l = 0, r = arr.length - 1;
            while(l <= r){
                int m = (l + r) / 2;
                
                int res = x.compareTo(arr[m]);
                
                if (res == 0)
                    return m;
                
                if (res > 0)
                    l = m + 1;
                else
                    r = m - 1;
            }
            
            return -1;
    }
}

  