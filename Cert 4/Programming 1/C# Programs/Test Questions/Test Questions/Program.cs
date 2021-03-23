using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Questions
{
    class Program
    {
        static void Main(string[] args)
        {
            Question[] test = new Question[4];
            //classes are used as types to create new variables, you call the class, then define a type and it shows up in blue, the same way that a native variable type would.
            //When the variable is then created, the 'new' will show up in blue because that's when the variable is created

            test[0] = new Question(); //c# will create a default constructor if there has not been one created in the class
            test[0].Prompt = "Which city is called the big apple?";
            test[0].QuestionNumber = 1;
            test[0].Marks = 1;

            test[1] = new Question(2, "what is the sum of 6 and 4",2);

            test[2] = new TrueFalseQuestion(3, "Sometimes dogs are brown.", 5);

            test[3] = new MultiChoiceQuestion(4, "Which of the following is a reptile", 3, "dog", "cat", "snake");

            for(int i = 0; i<test.Length;i++)
            {
                test[i].DisplayPrompt();
                test[i].DisplayMarks();
            }

        }
    }
}
