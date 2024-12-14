Console.WriteLine("Are you coming or leaving?(in/out): ");
string userChoice = Console.ReadLine();

if (userChoice == "in" )
{
    PrintHello();
}
else
{
    PrintGoodBye();
}






static void PrintHello() //function ehk method
{
    Console.WriteLine("Hello, World!");
}

static void PrintGoodBye()
{
    Console.WriteLine("See you later alligator");
}