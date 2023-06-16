// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int Promt(string message)
{
    System.Console.Write(message);
    string number = System.Console.ReadLine()!;
    if ((int.TryParse(number, out int numberr)) == false)
    {
        System.Console.WriteLine("Ошибка! Введите число: ");

    }
    return numberr;
}


int[,] GetMatrix(int rows, int colums, int minvalue, int maxvalue)
{
    int[,] matrix = new int[rows, colums];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            matrix[i, j] = new Random().Next(minvalue, maxvalue);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] mymatrix)
{
    for (int i = 0; i < mymatrix.GetLength(0); i++)
    {
        for (int j = 0; j < mymatrix.GetLength(1); j++)
        {
            System.Console.Write($"{mymatrix[i, j]}     ");
        }
        System.Console.WriteLine();
    }

}
void ReplaceRowsIndex(int[,] mymatrix)
{
    for (int i = 0; i < mymatrix.GetLength(0); i++)
    {
        for (int j = 0; j < mymatrix.GetLength(1); j++)
        {
            for (int z = 0; z < mymatrix.GetLength(1) - 1; z++)
            {
                if (mymatrix[i, z] < mymatrix[i, z + 1])
                {
                    int temp = mymatrix[i, z + 1];
                    mymatrix[i, z + 1] = mymatrix[i, z];
                    mymatrix[i, z] = temp;
                }
            }

        }

    }

    for (int i = 0; i < mymatrix.GetLength(0); i++)
    {
        for (int j = 0; j < mymatrix.GetLength(1); j++)
        {
            Console.Write($"{mymatrix[i, j]}     ");
        }
        Console.WriteLine();
    }


}
int rows = Promt("Введите колличество строк: ");
int columns = Promt("Введите колличество столбцов: ");
int[,] mymatrix = GetMatrix(rows, columns, 0, 10);
PrintMatrix(mymatrix);
System.Console.WriteLine("---------------------");
ReplaceRowsIndex(mymatrix);