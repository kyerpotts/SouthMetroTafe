/*  
    Software Deployment AT1.7
    Kyer Potts
    30003389
 */
package configexample;

import java.io.FileNotFoundException;
import java.io.IOException;
import java.io.InputStream;
import java.util.Properties;

public class ConfigReader {

    String result = "";
    InputStream inputStream;

    public String getPropValues() throws IOException {
        try {
            Properties prop = new Properties();
            String propFileName = "config.properties";
            inputStream = getClass().getClassLoader().getResourceAsStream(propFileName);
            if (inputStream != null) {
                prop.load(inputStream);
            } else {
                throw new FileNotFoundException("property file '" + propFileName + "' not found.");
            }
            // get the property value and print it out
            String name = prop.getProperty("name");
            String version = prop.getProperty("version");
            String date = prop.getProperty("release_date");
            String lang = prop.getProperty("lang");
            result = "Properties list = " + name + ", " + version + ", " + date + ", " + lang;
            System.out.println(result);
        } catch (IOException ex) {
            System.out.println("Exception: " + ex);
        }
        return result;
    }

}
