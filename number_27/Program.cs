// Напишите программу, которая принимает 
// на вход число и выдаёт сумму цифр в числе.
// Например:
// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.Write("Enter number: ");
int numberN = Convert.ToInt32(Console.ReadLine());
int SumNumber(int numberN)
{
    int A = Convert.ToString(numberN).Length;
    int B = 0;
    int result = 0;
    for (int i = 0; i < A; i++)
    {
        B = numberN - numberN % 10;
        result = result + (numberN - B);
        numberN = numberN / 10;
    }
    return result;
}
int sumNumber = SumNumber(numberN);
Console.WriteLine("Сумма цифр: " + sumNumber); 