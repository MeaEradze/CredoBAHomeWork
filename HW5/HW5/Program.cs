using HW5;

Book book1 = new Book("To Kill a Mockingbird", "Harper Lee", "0780061120084", 500);
Book book2 = new Book("1984", "George Orwell", "9780451524935", 300);
Book book3 = new Book("The Great Gatsby", "F. Scott Fitzgerald", "0780743273565", 450);
Book book4 = new Book("Pride and Prejudice", "Jane Austen", "9781503290563", 600);
Book book5 = new Book("The Catcher in the Rye", "J.D. Salinger", "9780316769488", 700);

Console.WriteLine("----------Book 1----------");
book1.DisplayInfo();
book1.BorrowBook();
book1.BorrowBook();
book1.BorrowBook();

Console.WriteLine("----------Book 1(after we borrow 3 books)----------");
book1.DisplayInfo();


Console.WriteLine("----------Book 1(after we return 1 book)----------");
book1.ReturnBook();
book1.DisplayInfo();


Library library = new Library();
library.AddBook(book1);
library.AddBook(book2);
library.AddBook(book3);
library.AddBook(book4);
library.AddBook(book5);

Console.WriteLine("---------------Displaying my Library----------------");
library.DisplayAllBooks();

Console.WriteLine("---------------Displaying my Library(after removing book1 and book2)----------------");
library.RemoveBook(book1);
library.RemoveBook(book2);
library.DisplayAllBooks();

Console.WriteLine("---------------Displaying my Library(after adding book1)----------------");
library.AddBook(book1);
library.DisplayAllBooks();

Console.WriteLine("---------------Search result for [the great])----------------");
library.Search("the great");