// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int rows = Promt("Введите колличество строк: ");
int columns = Promt("Введите колличество столбцов: ");
int[,] mymatrix = GetMatrix(rows, columns, 0, 10);
PrintMatrix(mymatrix);
System.Console.WriteLine("---------------------");
MinSumRow();

void MinSumRow()
{
    int minsumrow = 0;
    int sumrow = RowsSum(mymatrix, 0);
    for (int i = 1; i < mymatrix.GetLength(0); i++)
    {
        int temprow = RowsSum(mymatrix, i);
        if (sumrow > temprow)
        {
            sumrow = temprow;
            minsumrow = i;
        }
    }
    Console.WriteLine($"\n{minsumrow + 1} - строкa с наименьшей суммой ({sumrow}) элементов ");
}
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

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write($"{matr[i, j]}     ");
        }
        System.Console.WriteLine();
    }

}
int RowsSum(int[,] mymatrix, int i)
{
    int sumrows = mymatrix[i, 0];    
    for (int j = 1; j < mymatrix.GetLength(1); j++)
    {
        sumrows += mymatrix[i, j];

    }
    return sumrows;
}

