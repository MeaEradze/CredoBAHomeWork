namespace HW5
{
    public class Library
    {
        private List<Book> books = new List<Book>();
        public void AddBook(Book book)
        {
            books.Add(book);
        }
        public void RemoveBook(Book book)
        {
            books.Remove(book);
        }
        public void DisplayAllBooks()
        {
            foreach (Book book in books)
            {
                book.DisplayInfo();
            }
        }
        public void Search(string query)
        {
            foreach (Book book in books)
            {
                if (book.Title.ToLower().Contains(query.ToLower()) || book.Author.ToLower().Contains(query.ToLower()))
                {
                     book.DisplayInfo();
                }
            }
        }
    }
}
