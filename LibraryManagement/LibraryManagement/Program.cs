namespace LibraryManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book b = new Book("Diary of A Wimpy Kid", "Jeff Kinney");
            b.DisplayDetails();
            Book e = new EBook("Atomic Habits", "James Clear", 100, "ATH");
            e.DisplayDetails();
        }
    }
}