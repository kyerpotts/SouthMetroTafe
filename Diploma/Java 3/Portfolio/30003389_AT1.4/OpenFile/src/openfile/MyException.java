/*
 * Kyer Potts
 * 30003389
 */

package openfile;
import java.io.IOException;

public class MyException extends IOException {
    public MyException() {
        super();
    }
    
    public MyException(String message) {
        super(message);
    }

}
