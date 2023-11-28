namespace Gik299_ExampleL3_Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string title = "The Lord of the Rings";
            Author author = new Author { FirstName = "J.R.R.", LastName = "Tolkien" }; //using struct Author that we created and defined in Author.cs
            BookFormat bookFormat = BookFormat.HardCover; //using enum BookFormat that we created and defined in BookFormat.cs. Note that you can only use values defined in the enum
            int numOfPages = 1178;
            int weight = 1500;
            string genre = "Fantasy";
            DateTime releaseDate = new DateTime(1954, 7, 29);

            Book book = new Book(title, author, bookFormat, numOfPages, weight, genre, releaseDate);

            Console.WriteLine(book.ToString());

        }
    }
}