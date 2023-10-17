// Напишите программу, которая удалит строку и столбец, на пересечении которых лежит наименьший элемент массива.

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
    int min = matrix[0,0], minRow = 0, minColumn = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i,j]<min)
            {
                min = matrix[i,j];
                minRow = i;
                minColumn = j;
            }
        }
    }
            for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i!=minRow&&j!=minColumn)
            Console.Write($"{matrix[i,j]} \t");
        }
        Console.WriteLine();
    }
}


Console.Clear();
Console.Write("Введите размер матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x=> int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
ReleaseMatrix(matrix);
