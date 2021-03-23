/*
 * Kyer Potts
 * 30003389
 */

package pathtest;

import java.nio.file.*;

public class PathTest {

    public static void main(String[] args) {
        FileSystem fs = FileSystems.getDefault();
        
        Path path = fs.getPath("E:\\Diploma\\Java 3\\Portfolio\\30003389_AT1.4\\PathTest\\Test.txt");
        
        System.out.println("Path URL: " + path);
    }

}
