// See https://aka.ms/new-console-template for more information
using CheckName;
Check che = new Check();
Console.WriteLine("Enter Input");
try
{
    string input = Console.ReadLine();
    if(input != "")
    {
        bool result = che.chekN(input);
        if(result==true)
        {
            Console.WriteLine("Correct name");
        }
        else
        {
            Console.WriteLine("incorrect name");
        }
    }
    else
    {
        Console.WriteLine("Invalid input");
    }
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}