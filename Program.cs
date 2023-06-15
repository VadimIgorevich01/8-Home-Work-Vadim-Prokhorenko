int GetCheckedNumber(string info, string allowedCharacters)
{
    Console.WriteLine(info);
    string? numberToBeChecked = Console.ReadLine();
    while (IsThereText(numberToBeChecked!, allowedCharacters!) | 
                        TestForNullOrEmpty(numberToBeChecked!))
    {
        Console.WriteLine("Условие не выполнено или строка пуста, попробуйте ввести иначе");
        Console.WriteLine(info);
        numberToBeChecked = Console.ReadLine();
    }
    int numberOk = Convert.ToInt32(numberToBeChecked);
    return numberOk;
}

bool TestForNullOrEmpty(string s)
{
    bool result;
    result = s == null || s == string.Empty;
    return result;
}

bool IsThereText(string typedNumber, string okChars)
{
    char characterToBeChecked = ' ';
    int checkedChars = 0;
    for (int i = 0; i < typedNumber.Length; i++)
    {
        characterToBeChecked = typedNumber[i];
        for (int j = 0; j < okChars.Length; j++)
        {
            if (characterToBeChecked == okChars[j])
            {
                checkedChars++;
                break;
            }
        }
    }
    if (checkedChars == typedNumber.Length)
    {
        return false;
    }
    else
    {
        return true;
    }
}

int[,] FillIntMatrix(int[,] matrixToBeFilled, int min, int max)
{
    Console.WriteLine();
    for (int i = 0; i < matrixToBeFilled.GetLength(0); i++)
    {
        for (int j = 0; j < matrixToBeFilled.GetLength(1); j++)
        {
            matrixToBeFilled[i, j] = new Random().Next(min, max + 1);
            if (matrixToBeFilled[i, j] >= 0)
            {
                Console.Write("  " + matrixToBeFilled[i, j]);
            }
            else
            {
                Console.Write(" " + matrixToBeFilled[i, j]);
            }

        }
        Console.WriteLine();
    }
    return matrixToBeFilled;
}

void Show2DimArray(int[,] array2Dim, string info)
{
    Console.WriteLine(info);
    for (int i = 0; i < array2Dim.GetLength(0); i++)
    {
        for (int j = 0; j < array2Dim.GetLength(1); j++)
        {
            if (array2Dim[i, j] >= 0)
            {
                Console.Write("  " + array2Dim[i, j]);
            }
            else
            {
                Console.Write(" " + array2Dim[i, j]);
            }
        }
        Console.WriteLine();
    }
}
void ShowTaskNumber(int numberOfTask)
{
    Console.WriteLine("\nЗадача номер " + numberOfTask);
}

int[,] Create2DimArr(string infoRow, string infoColumn, string allowedChars)
{
    int row = GetCheckedNumber(infoRow, allowedChars);
    int column = GetCheckedNumber(infoColumn, allowedChars);
    int[,] empty2DimArr = new int[row, column];
    return empty2DimArr;
}
// Task1___________________________
// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
ShowTaskNumber(1);
int[,] emptyArrayTwoDimensionalTask1 = Create2DimArr("Укажите количество строк",
                                    "Укажите количество столбцов", "123456789");
int[,] fullArrTwoDimenTsk1 = FillIntMatrix(emptyArrayTwoDimensionalTask1, -9, 9);
int maxValue = -1;
int indexOfLastColumn = fullArrTwoDimenTsk1.GetLength(1) - 1;
int j = 1;



for (int q = 0; q < fullArrTwoDimenTsk1.GetLength(0); q++)
{
    for (int i = 0; i < (fullArrTwoDimenTsk1.GetLength(1) - 1); i++)
    {
        while (j != fullArrTwoDimenTsk1.GetLength(1))
        {
            if (fullArrTwoDimenTsk1[q, i] < fullArrTwoDimenTsk1[q, j])
            {
                maxValue = fullArrTwoDimenTsk1[q, j];
                fullArrTwoDimenTsk1[q, j] = fullArrTwoDimenTsk1[q, i];
                fullArrTwoDimenTsk1[q, i] = maxValue;
            }
            j++;
        }
        j = i + 1;
    }
    j = 1;
}

Show2DimArray(fullArrTwoDimenTsk1, "Ниже наш упорядоченный массив:");
// ________________________________________________________

// Task2___________________________________________________
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
ShowTaskNumber(2);
int[,] emptyArray2DimensionTask2 = new int[3, 4];
int[,] fullArr2DimTsk2 = FillIntMatrix(emptyArray2DimensionTask2, -9, 9);
int sumOfRow = 0;
int[] arrayOfSumsOfRows = new int[fullArr2DimTsk2.GetLength(0)];
for (int w = 0; w < fullArr2DimTsk2.GetLength(0); w++)
{
    for (int e = 0; e < fullArr2DimTsk2.GetLength(1); e++)
    {
        sumOfRow += fullArr2DimTsk2[w, e];
    }
    arrayOfSumsOfRows[w] = sumOfRow;
    sumOfRow = 0;
}
var sumOfRowString = string.Join(", ", arrayOfSumsOfRows);
Console.WriteLine("Суммы строчек соответсвенно: " + sumOfRowString);
int minValue = arrayOfSumsOfRows[0];
int indexOfminValue = 0;
for (int r = 0; r < arrayOfSumsOfRows.Length; r++)
{
    if (minValue > arrayOfSumsOfRows[r])
    {
        indexOfminValue = r;
        minValue = arrayOfSumsOfRows[r];
    }
}
Console.WriteLine($"Строка под номером {indexOfminValue + 1} с наименьшей суммой элементов");
// ________________________________________

// Task3___________________________________
// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
ShowTaskNumber(3);
int [,] emptyMatrix1 = Create2DimArr ("Введите количество строк от 2", "Введите количество столбцов от 2",
                                    "23456789");
int columnOfMatrix2 = GetCheckedNumber ("Введите количество столбцов от 2 для второй матрицы",
                                    "23456789");
int [,] emptyMatrix2 = new int [emptyMatrix1.GetLength(1), columnOfMatrix2];
int [,] filledMatrix1 = FillIntMatrix (emptyMatrix1, 0, 9);
int [,] filledMatrix2 = FillIntMatrix (emptyMatrix2, 0, 9);
int [,] productOfTwoMatrix = new int [filledMatrix1.GetLength(0), filledMatrix2.GetLength(1)];
int multiplicationSum = 0;
for (int t = 0; t < productOfTwoMatrix.GetLength(0); t++)
{
    for (int y = 0; y < productOfTwoMatrix.GetLength(1); y++)
    {
        for (int u = 0; u < filledMatrix1.GetLength(1); u++)
        {
            multiplicationSum += (filledMatrix1[t, u] * filledMatrix2 [u, y]);
        } 
        productOfTwoMatrix [t, y] = multiplicationSum;
        multiplicationSum = 0;
    }
}
Show2DimArray (productOfTwoMatrix, "\nНиже наше произведение двух матриц");
// ________________________________________________

// Task4___________________________________________
// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
ShowTaskNumber(4);
int [,,] array3Dimension = new int [2, 2, 2];
int maxNumberOfValues = array3Dimension.GetLength(0) * array3Dimension.GetLength(1) * 
                                                        array3Dimension.GetLength(2);
int numberToBePut = 0;
int [] reservedNumbers = new int [maxNumberOfValues];
int timesChecked = 0;
int index = 0;
for (int o = 0; o < array3Dimension.GetLength(0); o++)
{
    for (int p = 0; p < array3Dimension.GetLength(1); p++)
    {
        for (int a = 0; a < array3Dimension.GetLength(2); a++)
        {
            numberToBePut = new Random().Next(10, 100);
            while (timesChecked != reservedNumbers.Length)
            {
                if (reservedNumbers[timesChecked] == numberToBePut)
                {
                    numberToBePut = new Random().Next(10, 100);
                    timesChecked = - 1;
                }
                timesChecked++;
            }
            array3Dimension [o, p, a] = numberToBePut;
            reservedNumbers [index] = numberToBePut;
            index++;
            timesChecked = 0;
            Console.Write ($"{array3Dimension [o, p, a]}({o},{p},{a}) ");
        }
        Console.WriteLine();
    }
}
// _______________________________________________

// Task5__________________________________________
// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
ShowTaskNumber(5);
string [,] matrix4x4 = new string [4, 4];
int increment = 0;
string numberString = string.Empty;
for (int s = 0; s < matrix4x4.GetLength(1); s++)
{
    increment++;
    numberString = increment.ToString();
    matrix4x4 [0, s] = "0" + numberString;
}
for (int d = 1; d < matrix4x4.GetLength(0); d++)
{
    increment++;
    numberString = increment.ToString();
    matrix4x4 [d, 3] = "0" + numberString;
}
for (int f = matrix4x4.GetLength(1) - 2; f >= 1; f--)
{
    increment++;
    numberString = increment.ToString();
    matrix4x4 [3, f] = "0" + numberString;
}
for (int g = matrix4x4.GetLength(0) - 1; g >= 1; g--)
{
    increment++;
    numberString = increment.ToString();
    matrix4x4 [g, 0] = numberString;
}
for (int h = 1; h < matrix4x4.GetLength(1) - 1; h++)
{
    increment++;
    numberString = increment.ToString();
    matrix4x4 [1, h] = numberString;
}
for (int k = matrix4x4.GetLength(1) - 2; k >= 1; k--)
{
    increment++;
    numberString = increment.ToString();
    matrix4x4 [2, k] = numberString;
}


for (int l = 0; l < matrix4x4.GetLength(0); l++)
{
    for (int z = 0; z < matrix4x4.GetLength(1); z++)
    {
        Console.Write (matrix4x4 [l,z] + " ");
    }
    Console.WriteLine ();
}


