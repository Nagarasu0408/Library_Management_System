namespace libraryManagaementSystem;

public class FineCalculator
{
    public int days { get; set; }
    public int fine { get; set; }

    public string type { get;  set; }
    public FineCalculator() { }
    public FineCalculator(int Days, int Fine, string Type)
    {
        days = Days;
        fine = Fine;
        type = Type;
    }

    public void CalculateFine(int days)
    {
        Console.WriteLine(days * 5);
    }

    public void CalculateFine(int days, int fine)
    {
        Console.WriteLine(days * fine);
    }
    public void CalculateFine(int days, int fine,string type)
    {
        switch (type)
        {
            case "Faculty":
            Console.WriteLine(days * fine*10);
            break;
            default:
                Console.WriteLine("No more Discount....Sorry");
                break;
        }
    }
}
