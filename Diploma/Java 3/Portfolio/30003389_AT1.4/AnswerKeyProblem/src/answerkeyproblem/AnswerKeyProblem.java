/*
 * Kyer Potts
 * 30003389
 */

package answerkeyproblem;
import java.io.*;
import java.util.regex.*;

public class AnswerKeyProblem {

    public static void main(String[] args) throws IOException {
        BufferedReader codedAnswers = new BufferedReader(new FileReader("CodedAnswerKey.txt"));
        
        String answers = "";
        String line = codedAnswers.readLine();
        
        while (line != null){
            if (line.matches("[a-fA-F]")){
                answers += line;
            }
            line = codedAnswers.readLine();
        }
        System.out.println(answers);
    }

}
