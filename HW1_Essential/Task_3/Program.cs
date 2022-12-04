namespace Task_3
{
     class Program
    {
        static void Main()
        {
        
            Title title = new Title();
            title.Content = "title 1";

            Content content = new Content();
            content.Content1 = "test content";

            Author author = new Author();
            author.Content = "Adam Dou";

            Book book = new Book(title, content, author);

            book.Show();

            
            Console.ReadKey();
        }
    }
}