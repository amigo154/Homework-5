// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

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
Console.Write("Введите начало диапазона чисел в массиве:  ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите конец диапазона чисел в массиве:  ");
int b  = Convert.ToInt32(Console.ReadLine());

int [] MyArray = CreateRandomArray(n, a, b);
int summ = 0;

for (int i = 1; i < MyArray.Length; i+=2)
{
    summ = summ + MyArray[i];
}

ShowArray(MyArray);
Console.WriteLine($"В указанном массиве сумма элементов на нечетных позициях равна {summ}");
