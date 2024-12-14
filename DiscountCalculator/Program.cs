// nt kui arve summa on väiksem kui 10 siis allahindlus 1%
// 10 -20 vahel summa, siis %5
// kui total suurem kui 20 või võrdne siis %10


//static void- tühjus, vahemälust kustutatakse kui funk lõpetab. 
//double - vahemällu peab antud juhul väärtus alles jääma ja seetõttu double
//string - sobiks ka teatud juhtudel

Console.WriteLine("Provide total: ");
int userInput = Int32.Parse(Console.ReadLine());

double discount = CalculateDiscount(userInput);

Console.WriteLine($"Your discount is: {discount} %");

double newTotal = CalculatenewTotal(userInput, discount);

//Double newTotal = userInput - (userInput * discount) / 100;

Console.WriteLine($"Your updated total with {discount}%: {newTotal}");

static double CalculateDiscount(int total)
{
    if (total < 10)
    {
        return 1;
    }
    else if (total >= 10 && total < 20)
    {
        return 5;
    }
    else
    {
        return 10;
    }

    }

static double CalculatenewTotal(double total, double discount)
{
    double result = total - (total * discount) / 100;
    return result;
}