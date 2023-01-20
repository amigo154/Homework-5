// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] CreateRandomArray(int N, int start, int end){
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(start, end + 1);
    }
    return RandomArray;
}
int[] CreateArray(){
    Console.WriteLine("Введите количество элементов массива");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {   
        Console.WriteLine($"Введите {i+1} элемент массива");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
void ShowArray(int[] array){

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.Clear();
Console.Write("Введите длину массива:  ");
int n = Convert.ToInt32(Console.ReadLine());
int [] MyArray = CreateRandomArray(n, 100, 998);

int quantity = 0;
for (int i = 0; i < MyArray.Length; i++)
{
    if (MyArray[i] % 2 == 0)
    {
        quantity++;
    }
}
ShowArray(MyArray);
Console.WriteLine($"В заданном массиве {quantity} четных чисел");