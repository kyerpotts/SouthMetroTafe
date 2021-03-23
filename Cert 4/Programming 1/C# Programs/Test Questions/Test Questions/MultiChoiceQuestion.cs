using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Questions
{
    class MultiChoiceQuestion : Question
    {
        private string optionA, optionB, optionC;

        public MultiChoiceQuestion (int questionNumber, string prompt, int marks, string optionA, string optionB, string optionC) : base(questionNumber, prompt, marks)
        {
            this.optionA = optionA;
            this.optionB = optionB;
            this.optionC = optionC;
        }

        public override void DisplayPrompt()
        {
            base.DisplayPrompt();
            Console.WriteLine("\t(a) " + optionA);
            Console.WriteLine("\t(b) " + optionB);
            Console.WriteLine("\t(c) " + optionC);

        }
    }
}
