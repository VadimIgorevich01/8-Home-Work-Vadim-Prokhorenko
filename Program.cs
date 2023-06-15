int GetCheckedNumber (string info, string allowedCharacters)
{
    Console.WriteLine (info);
    string? numberToBeChecked = Console.ReadLine();
    while (IsThereText(numberToBeChecked!, allowedCharacters!) | TestForNullOrEmpty(numberToBeChecked!))
    {
        Console.WriteLine ("Условие не выполнено или строка пуста, попробуйте ввести иначе");
        Console.WriteLine (info);
        numberToBeChecked = Console.ReadLine ();
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

bool IsThereText (string typedNumber, string okChars)
{
    char characterToBeChecked = ' ';
    int checkedChars = 0;
    for (int i = 0; i < typedNumber.Length; i++)
    {
        characterToBeChecked = typedNumber [i];
        for (int j = 0; j < okChars.Length; j++)
        {
            if (characterToBeChecked == okChars [j])
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

int [,] FillIntMatrix (int [,] matrixToBeFilled)
{
    for (int i = 0; i < matrixToBeFilled.GetLength(0); i++)
    {
        for (int j = 0; j < matrixToBeFilled.GetLength(1); j++)
        {
            matrixToBeFilled [i, j] = new Random().Next(-9, 10);
            if (matrixToBeFilled [i, j] >= 0)
            {
                Console.Write ("  " + matrixToBeFilled[i,j]);
            }
            else
            {
                Console.Write (" " + matrixToBeFilled[i,j]);
            }
            
        }
        Console.WriteLine();
    }
    return matrixToBeFilled;
}

void Show2DimArray (int [,] array2Dim, string info)
{
    Console.WriteLine (info);
    for (int i = 0; i < array2Dim.GetLength(0); i++)
    {
        for (int j = 0; j < array2Dim.GetLength(1); j++)
        {
            if (array2Dim [i, j] >= 0)
            {
                Console.Write ("  " + array2Dim[i,j]);
            }
            else
            {
                Console.Write (" " + array2Dim[i,j]);
            }
        }
        Console.WriteLine();
    }
}
void ShowTaskNumber (int numberOfTask)
{
    Console.WriteLine("\nЗадача номер " + numberOfTask);
}
// Task1___________________________
// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
ShowTaskNumber(1);
int rowTask1 = 4;
int columnTask1 = 4;
int [,] emptyArrayTwoDimensionalTask1 = new int [rowTask1, columnTask1];
int [,] fullArrTwoDimenTsk1 = FillIntMatrix (emptyArrayTwoDimensionalTask1);
int maxValue = -1;
int indexOfLastColumn = columnTask1 - 1;
int j = 1;



for (int q = 0; q < fullArrTwoDimenTsk1.GetLength(0); q++)
{
    for (int i = 0; i < (columnTask1 - 1); i++)
    {
        while (j != columnTask1) 
        {
            if (fullArrTwoDimenTsk1[q, i] < fullArrTwoDimenTsk1 [q, j])
            {
                maxValue = fullArrTwoDimenTsk1 [q, j];
                fullArrTwoDimenTsk1 [q, j] = fullArrTwoDimenTsk1 [q, i];
                fullArrTwoDimenTsk1 [q, i] = maxValue;
            }
            j++;
        }
        j = i + 1;
    }
    j = 1;
}

Show2DimArray (fullArrTwoDimenTsk1, "Ниже наш упорядоченный массив:");
// ________________________________________________________

// Task2___________________________________________________

