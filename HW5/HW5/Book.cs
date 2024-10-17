using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    public class Book
    {
        public Book(string title, string author, string isbn, int copiesAvailable) 
        { 
            Title = title;
            Author = author;
            ISBN = isbn;
            CopiesAvailable = copiesAvailable;
        }
        #region PrivateFields
        private string title;
        private string author;
        private string isbn;
        private int copiesAvailable;
        #endregion
        #region Properties
        public string Title 
        { 
            get 
            {
                return title; 
            } 
            set
            {
                if(!string.IsNullOrEmpty(value) && !value.Contains("0123456789"))
                {
                    title = value;
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            } 
        }
        public string Author
        {
            get
            {
                return author;
            }
            set
            {
                if (!string.IsNullOrEmpty(value) && !value.Contains("0123456789"))
                {
                    author = value;
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            }
        }
        public string ISBN
        {
            set
            {
                if (!string.IsNullOrEmpty(value) && value.Length == 13)
                {
                    isbn = value;
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            }

        }

        private int CopiesAvailable
        {
            get 
            {
                return copiesAvailable;
            }
            set
            {
                //მე მაღაზიაში ერთი ტიპის მაქსიმუმ 1000 წიგნი ვიცი :) სხვა ვალიდაცია ამ თემაზე ვერ მოვიფიქრე
                if (value > 0 || value < 1000)
                {
                    copiesAvailable = value;
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            }

        }
        #endregion
        #region Methods
        public void DisplayInfo()
        {
            Console.WriteLine($"Title: {Title}\nAuthor: {Author}\nCopies Available: {CopiesAvailable}\n");
        }
        public void BorrowBook()
        {
            copiesAvailable--;
        }
        public void ReturnBook()
        {
            copiesAvailable++;
        }
    #endregion
    }
}
