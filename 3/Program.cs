// Напишите программу, которая меняет строки на столбцы, и выводит сообщение если это возможно

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] =new Random().Next(-10,11);
        }
    }
}

void PrintMatrix(int[,] matrix) 
{
        for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} \t");
        }
        Console.WriteLine();
    }
}

void ReleaseMatrix(int[,] matrix)
{
    int temp;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = i+1; j < matrix.GetLength(1); j++)
        {
            temp=matrix[i,j];
            matrix[i,j]=matrix[j,i];
            matrix[j,i]=temp;
        }
    }
}


Console.Clear();
Console.Write("Введите размер матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x=> int.Parse(x)).ToArray();
while(size[0] != size[1])
{
    Console.Write("Mistake!!! Введите размер матрицы: ");
   size = Console.ReadLine().Split(" ").Select(x=> int.Parse(x)).ToArray();
}
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
ReleaseMatrix(matrix);
PrintMatrix(matrix);