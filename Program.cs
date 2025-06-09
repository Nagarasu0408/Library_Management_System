// using System;
using libraryManagaementSystem; //--> Namespace to connect 2 Documents


Book b1 = new Book { Title = "Psychology of money", Author = "Morgan Housel", ISBN = "9798875154072" };

// Book b2 = new Book { Book_Name = "Psychology of money", Author = "Morgan Housel", ISBN = "9798875154072" };

b1.DisplayBookDetails();

// LibraryItem l1 = new LibraryItem(b1.Book_Name);

Magazine m1 = new Magazine ("123","Ghjk","1234");

// b1.ShowInfo();
// m1.ShowInfo();
   
FineCalculator f = new FineCalculator();

f.CalculateFine(10);
f.CalculateFine(10, 5);
f.CalculateFine(10, 5, "Faculty");

try
{
    // int[] arrr = new int[10];
    // arrr[11] = 10;
    int k = 100;
    Console.WriteLine(k / 0);
}
catch (DivideByZeroException e)
{
    Console.WriteLine(e.Message);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
finally
{
    Console.WriteLine("Hello");
}