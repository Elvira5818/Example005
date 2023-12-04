// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();
double[] array = MyArray(4,0,10);
Console.WriteLine(string.Join(" ", array));
double positivenum = GetPosNum(array);
double negativenum = GetNegNum(array);
double difference = positivenum - negativenum;

Console.WriteLine($"Разница между максимальным и минимальным элементов массива равна {difference}");

double [] MyArray(int size, int min, int max)
{
    double[]result = new double[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().NextDouble();        
    }
    return result;
}
double GetPosNum(double[] array)
{
    double maxnum = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if ( array[i]>maxnum) maxnum = array[i];
    }
    return maxnum;
}
double GetNegNum(double[] array)
{
    double minnum = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < minnum) minnum = array[i];
    }
    return minnum;
}


// Задайте массив заполненный 
//случайными положительными трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
Console.Clear();
int[] array = MyArray(5, 100, 999);
Console.WriteLine(string.Join(" ", array));
int evennum = MyEvenNum(array);
PrintArray(array);


int[] MyArray(int size, int min, int max)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max + 1);
    }
    return result;
}
int MyEvenNum(int[] array)
{
    int count = 0;
    foreach (int el in array)
    {

        if (el % 2 == 0) count++;

    }
    return count;
}
void PrintArray(int[] array)
{
    Console.WriteLine($"В массиве колличество четных чисел составляет {evennum}");
}
// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();
int[] array = MyArray(6, 0, 10);
Console.WriteLine(string.Join(" ", array));
int evennum = GetMyArray(array);

Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях равна {evennum}");

int[] MyArray(int size, int min, int max)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max + 1);
    }
    return result;
}

int GetMyArray(int[] array)
{

    int num = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0) num += array[i];
    }
    return num;

}