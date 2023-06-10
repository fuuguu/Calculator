//Голубихин Данила 22-ИСП-2/2 1.47.

using Calculator;

public static class Calc
{
    public static void Main()
    {
        var a = new Fraction(5, 4);
        var b = new Fraction(1, 2);
        Console.WriteLine(-a); 
        Console.WriteLine(a + b);  
        Console.WriteLine(a - b);  
        Console.WriteLine(a * b);  
        Console.WriteLine(a / b); 
    }
}