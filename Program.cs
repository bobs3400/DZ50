Console.Clear();
Console.WriteLine("Введите позицию элемента массива");
int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());
int m = new Random().Next(1, 10);
int n = new Random().Next(1, 10);
//int[,] arr = GetArray(m, n);
PrintArray(arr);
Console.WriteLine();
Console.WriteLine(GetArraySum(arr));

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
int GetArraySum(int[,] Array) 
{   
     int sum = 0;
     for (int i = 0; i < Array.GetLength(0); i++)     
     {
        for(int j = 0; j < Array.GetLength(1); j++)
        {
            if(i == j) sum = sum + Array[i, j];
        }              
     }
     return sum;
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