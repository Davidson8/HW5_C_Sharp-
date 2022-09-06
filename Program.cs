// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
/* 
int[] numbers = new int[4];

int[] GetArray(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
    return numbers;
}

int GetEven(int count = 0)
    {
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
    } 

void PrintArray(){
    for(int i = 3; i < numbers.Length; i++)
    {
        Console.WriteLine($"всего {numbers.Length} чисела, {GetEven()} из них чётные");
    }
}

Console.WriteLine($"[{string.Join(", ", GetArray(numbers))}]");
PrintArray();
 */

//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
/* 
void Main()
    {
    int[] arr = new int[4];
    float sum = 0;
 
    for (int i = 0; i < 4; i++)
        {
            arr[i] = new Random().Next(1, 70);
        }
        Console.WriteLine($"[{string.Join(", ", arr)}]");

        for (int i = 1; i < arr.Length; i += 2)
        {
            sum += arr[i];
        }
               
        Console.WriteLine("Cумма элементов, стоящих на нечётных позициях = {0}", sum);     
    }

Main();
 */

// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.


/* double Array(){
    double[] arr = new double[5];
    for (int i = 0; i < arr.Length; i++ )
    {
        arr[i] = new Random().Next(1, 10);
        
    }
    Console.Write($"[{string.Join(", ", arr)}]");
    Console.WriteLine(" ");

    double max = arr[0];
    double min = arr[0];

    for (int i = 1; i < arr.Length; i++)
    {
        if (max < arr[i])
        {
        max = arr[i];
        }
        if (min > arr[i])
        {
        min = arr[i];
        }
    }
    double decision = max - min;
    return decision;
}
System.Console.WriteLine($"Разница между максимальным и минимальным элементом = {Array()}");
 */
