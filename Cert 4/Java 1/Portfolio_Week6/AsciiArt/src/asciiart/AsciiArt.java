
package asciiart;
import java.util.Scanner;
/**
 * 30003389
 * Kyer Potts
 */
public class AsciiArt {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        
        System.out.println("Enter a width for the rectangle");
        int recWidth = sc.nextInt();
        
        System.out.println("Enter a height for the rectangle");
        int recHeight = sc.nextInt();
        
        for(int i = 1; i < recWidth + 1; i++){
            System.out.print('#');
        }
        System.out.println();
        for(int i = 1; i < recHeight -1; i++){
            System.out.print('#');
            for(int j = 1; j < recWidth -1; j++){
                System.out.print(' ');
            }
            if(recWidth > 1){
                System.out.print('#');
            }
            System.out.println();
        }
        for(int i = 1; i < recWidth + 1; i++){
            System.out.print('#');
        }
        System.out.println();
        
        System.out.println("Enter a height for the triangle");
        int triHeight = sc.nextInt();
        
        for(int i = 0; i < triHeight -1; i++){
            System.out.print('#');
            for(int j = 0; j < i - 1; j++){
                System.out.print(' ');
            }
            if (i > 0){
                System.out.print('#');
            }
            System.out.println();
        }
        for(int i = 0; i< triHeight;i++){
            System.out.print('#');
        }
        System.out.println();
    }
    
}
