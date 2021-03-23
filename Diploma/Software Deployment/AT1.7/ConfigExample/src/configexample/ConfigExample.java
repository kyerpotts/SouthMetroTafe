/*  
    Software Deployment AT1.7
    Kyer Potts
    30003389
 */
package configexample;

import java.io.IOException;

public class ConfigExample {

    public static void main(String[] args) throws IOException {
        ConfigReader properties = new ConfigReader();
        properties.getPropValues();
    }
}
