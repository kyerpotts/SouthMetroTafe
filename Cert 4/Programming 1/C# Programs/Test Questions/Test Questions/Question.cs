using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Questions
{
    class Question
    {
        private int questionNumber;
        private int marks;
        private string prompt;

        public Question()//this is a constructor
        {
            marks = 1; //this creates a default value for marks
        }
        public Question( int questionNumber, string prompt, int marks) : this()//this constructor calls the default constructor and adds peramters
        {
            QuestionNumber = questionNumber;
            Prompt = prompt;
            Marks = marks;
        }

        public int QuestionNumber
        {
            get { return questionNumber; }
            set
            {
                if(value > 0)
                {
                    questionNumber = value;
                }
            }
        }
        public int Marks
        {
            get { return marks; }
            set
            {
                if(value>=1)
                {
                    marks = value;
                }
            }
        }
        public string Prompt
        {
            get { return prompt; }
            set { prompt = value; }
        }

        //the virtual keyword makes it possible for sublasses to override the method with their own behaviour
        public virtual void DisplayPrompt()
        {
            Console.WriteLine(QuestionNumber + ") " + Prompt);
        }
        public void DisplayMarks()
        {
            string suffix = "";
            if(marks > 1)
            {
                suffix = " marks\n";
            }
            else
            {
                suffix = " mark\n";
            }
            Console.WriteLine("\n\t\t\t\t\t" + Marks + suffix);

        }
    }
}
