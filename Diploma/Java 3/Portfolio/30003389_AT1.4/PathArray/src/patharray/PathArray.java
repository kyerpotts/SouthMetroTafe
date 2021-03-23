/*
 * Kyer Potts
 * 30003389
 */

package patharray;

import java.nio.file.*;
import java.util.ArrayList;

public class PathArray {

    public static void main(String[] args) {
        FileSystem fs = FileSystems.getDefault();
        ArrayList<Path> pathList = new ArrayList<Path>();
        
        Path path1 = fs.getPath("./MyFile.txt"); // Relative path
        Path path2 = fs.getPath("E:/Assignments/Java3/Portfolio_Week4"); // Absolute path
        Path path3 = fs.getPath("C:/Program Files/Java"); // Absolute path
        
        pathList.add(path1);
        pathList.add(path2);
        pathList.add(path3);
        
        for (Path p : pathList) {
            System.out.println("Path: " + p);
        }

        
    }

}
