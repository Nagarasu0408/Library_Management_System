namespace libraryManagaementSystem;

public class Book : LibraryItem
{
    // public string Book_Name { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }

    public Book() { }
    public Book(string id,string Name) : base(id,Name)
    {
        Id = id;
        Title = Name;
    }
    public void DisplayBookDetails()
    {
        Console.WriteLine($"Book Title is {Title}");
        Console.WriteLine($"Book Author is {Author}");
        Console.WriteLine($"Book ISBN - {ISBN}");
    }


}