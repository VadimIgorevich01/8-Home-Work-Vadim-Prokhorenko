int GetCheckedNumber(string info, string allowedCharacters)
{
    Console.WriteLine(info);
    string? numberToBeChecked = Console.ReadLine();
    while (IsThereText(numberToBeChecked!, allowedCharacters!) | TestForNullOrEmpty(numberToBeChecked!))
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
//________________________________________

//Task3___________________________________
