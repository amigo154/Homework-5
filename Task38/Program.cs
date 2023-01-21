// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

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
int min = MyArray[0];
int max = MyArray[0];
for (int i = 0; i < MyArray.Length; i++)
{
    if (MyArray[i] < min)
    min = MyArray[i];
}

for (int i = 0; i < MyArray.Length; i++)
{
    if (MyArray[i] > max) 
    max = MyArray [i];
}

ShowArray(MyArray);
Console.WriteLine($"min равно {min}; max равно {max}, а разница между ними равна {max - min}");