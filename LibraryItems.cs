namespace libraryManagaementSystem;


public class LibraryItem
{
    public string Id{ get; set; }
    public string Title{ get; set; }

    public LibraryItem() { }
    public LibraryItem(string id,string title)
    {
        Id = id;
        Title = title;
    }
    public void ShowInfo()
    {
        Console.WriteLine($"The Item is {Title} .");
    }

}