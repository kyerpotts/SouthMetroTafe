using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBooks
{
    class Book
    {
        //fields for the attricutes collected by textbox controls, no getters/setters required due to AddBook method and constructor
        private string Title;
        private string Author;
        private string Date;
        private string Publisher;
        //create a constructor that sets values for variables when class is instanced
        public Book(string title, string author, string date, string publisher)
        {
            this.Title = title;
            this.Author = author;
            this.Date = date;
            this.Publisher = publisher;
        }

        //method to display the fields within the listbox output
        public string AddBook()
        {
            string newBook = (Title + ", " + Author + ", " + Date + ", " + Publisher);
            return newBook;
        }
        
        public string getTitle()
        {
            return Title;
        }
        public string getAuthor()
        {
            return Author;
        }
        public string getDate()
        {
            return Date;
        }
        public string getPublisher()
        {
            return Publisher;
        }
        public void setTitle(string title)
        {
            Title = title;
        }
        public void setAuthor(string author)
        {
            Author = author;
        }
        public void setDate(string date)
        {
            Date = date;
        }
        public void setPublisher(string publisher)
        {
            Publisher = publisher;
        }


        
    }
}
