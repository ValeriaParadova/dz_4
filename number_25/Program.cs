// Напишите цикл, который принимает на вход два 
// числа (A и B) и возводит число A в натуральную 
// степень B.
// Например:
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.Write("Enter number A: ");
string a = Console.ReadLine();

Console.Write("Enter number B: ");
string b = Console.ReadLine();

double degreeResult;
double RaiseToADegree(double number, int degreeOfNumber)
{
    double degree = 1;
    for (int i = 0; i < degreeOfNumber; i++)
    {
        degree *= number;
    }
    return degree;
}
void Exponentiation(string enterA, string enterB)
{
    bool yesDouble = double.TryParse(enterA, out double resultNumber);
    bool yesInt = int.TryParse(enterB, out int result);
    if (yesInt && yesDouble && result > 0)
    {
        degreeResult = RaiseToADegree(resultNumber, result);
        Console.WriteLine("{0},{1} -> {2}", resultNumber, result, degreeResult);
    }
    else 
    {
        Console.WriteLine("{0}, {1} -> Некорректный ввод!", a, b);
    }  
}
Exponentiation(a, b);
