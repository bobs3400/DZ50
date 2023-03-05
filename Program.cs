Console.Clear();
Console.WriteLine("Введите позицию элемента массива");
int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());
int m = new Random().Next(1, 10);
int n = new Random().Next(1, 10);
int[,] arr = GetArray(m, n);
PrintArray(arr);
Console.WriteLine();
if(x < m && y < n) { Console.WriteLine(arr[x, y]); }
else {Console.WriteLine("Такого элемента в массиве нет");}

int[,] GetArray(int m, int n) 
{
     int[,] result = new int[m, n];
     for (int i = 0; i < m; i++)     
     {
        for(int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(1, 10);  
        }              
     }
     return result;
}

void PrintArray(int[,] inArray)
{
    for(int i = 0; i < inArray.GetLength(0); i++)
    {
        for(int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}