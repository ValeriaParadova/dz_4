//  Напишите программу, которая задаёт массив 
//  из введенного числа и выводит их на экран.
//  Пользователь вводит число элементов в массиве 
//  минимальное, и максимальное значение. 
//  Надо заполнить массив рандоными данными от минимального 
//  до максимального значение. И важное уточнениее, делать все в 
//  методе который возвращает массив
//  Например:
// 5, 1, 20 -> [1, 2, 5, 7, 19]
// 3, 1, 33 -> [6, 1, 33]


Console.WriteLine("Введите размер массива ");
int A = int.Parse(Console.ReadLine());
int [] array = new int[10]; 
int arraySize = int.Parse(Console.ReadLine());

Console.WriteLine("Введите минимальное значение ");
int minValue = int.Parse(Console.ReadLine());

Console.WriteLine("Введите максимальное значение ");
int maxValue = int.Parse(Console.ReadLine());

for (int i = 0; i < A; i++)
int[] array  = new int[10];

void PrintArray(int[] array)
{{
    array[i] = new Random().Next(0,100);
    Console.Write(string.Join(" ", array[i]+" "));
}
    for (int i = 0; i < 10; i++)
    {
        array[i] = new Random().Next(minValue, maxValue);
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
 PrintArray(array);
