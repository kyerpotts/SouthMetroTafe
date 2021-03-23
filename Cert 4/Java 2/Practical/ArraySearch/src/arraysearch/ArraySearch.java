/*
 * Kyer Potts
 * 30003389
 */
package arraysearch;
import java.util.*;
public class ArraySearch {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        ArrayList <Integer> numList = new ArrayList<Integer>();
        for(int i = 0; i <10; i++){
            System.out.println("Enter a number");
            int num = sc.nextInt();
            numList.add(num);
        }
        
        Collections.sort(numList);
        
        System.out.println("The list has now been sorted, listing sorted numbers below");
        for (int i = 0; i < (numList.size()); i++){
            System.out.println(numList.get(i));
        }
        
        System.out.println("Enter the number you would like to search");
        int searchNum = sc.nextInt();
        int index = Collections.binarySearch(numList, searchNum);
        
        if (index >= 0 && index <= 9){
            System.out.println("The number was found at index " + index + " of the array list");
        } else{
            System.out.println("The number was not found within the array");
        }
    }
}
