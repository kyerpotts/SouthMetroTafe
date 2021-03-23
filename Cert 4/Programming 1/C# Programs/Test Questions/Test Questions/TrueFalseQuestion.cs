using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Questions
{
    class TrueFalseQuestion : Question
    {
        public TrueFalseQuestion (int questionNumber, string prompt, int marks) : base(questionNumber, prompt, marks)//base sends the values of the perameters defined in the constructor back to the parent class or superclass
        {

        }

        public override void DisplayPrompt()
        {
            Console.WriteLine(QuestionNumber + " )" + Prompt + " - True or False?");
        }
    }
}
