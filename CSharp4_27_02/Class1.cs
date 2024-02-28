namespace CSharp4_27_02
{
    public class ReadingList
    {
        private List<string> books = new List<string>();

        
        public List<string> Books
        {
            get { return books; }
            set { books = value; }
        }

        
        public void AddBook(string book)
        {
            books.Add(book);
        }

        
        public void RemoveBook(string book)
        {
            books.Remove(book);
        }

        
        public bool ContainsBook(string book)
        {
            return books.Contains(book);
        }

        
        public string this[int index]
        {
            get { return books[index]; }
            set { books[index] = value; }
        }

        
        public static ReadingList operator +(ReadingList readingList, string book)
        {
            readingList.AddBook(book);
            return readingList;
        }

        
        public static ReadingList operator -(ReadingList readingList, string book)
        {
            readingList.RemoveBook(book);
            return readingList;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ReadingList myReadingList = new ReadingList();

            myReadingList += "Book 1";
            myReadingList += "Book 2";
            myReadingList += "Book 3";

            Console.WriteLine("Books to Read:");
            foreach (string book in myReadingList.Books)
            {
                Console.WriteLine(book);
            }

            
            myReadingList -= "Book 2";

            
            Console.WriteLine($"Is 'Book 2' in the reading list? {myReadingList.ContainsBook("Book 2")}");

            
            Console.WriteLine($"Book at index 0: {myReadingList[0]}");
        }
    }
}

