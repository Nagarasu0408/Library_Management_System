namespace libraryManagaementSystem;


public class Magazine : LibraryItem
{
    public string Number { get; set; }


    public Magazine(string id, string Name, string number) : base(id, Name)
    {
        Id = id;
        Title = Name;
        Number = number;
    }
    
    public Magazine() { }
}