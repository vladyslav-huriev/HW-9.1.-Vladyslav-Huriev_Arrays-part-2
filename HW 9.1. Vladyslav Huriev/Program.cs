// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// 9.1.1 Написати програму, що знаходить другий найбільший елемент масиву.
/*using System;
int[] array = { 4, 7, 1, 9, 3, 6 };
int FindSecondLargest(int[] arr)
{
    if (arr.Length < 2)
        throw new Exception("The array should consist of 2 element as minimum");
    int largest = int.MinValue;
    int secondLargest = int.MinValue;
    foreach (int num in arr)
    {
        if (num > largest)
        {
            secondLargest = largest;
            largest = num;
        }
        else if (num > secondLargest && num < largest)
        {
            secondLargest = num;
        }
    }

    return secondLargest;
}
int secondLargest = FindSecondLargest(array);
Console.WriteLine($"Second biggest element of the array is: {secondLargest}");*/

// 9.1.2. Написати програму, що буде сортувати за зростанням елементи двовимірного масиву.

/* int[,] array = {
    { 8, 5, 3 },
    { 7, 1, 4 },
    { 6, 9, 2 }
};
int[] flatArray = new int[array.Length];
int index = 0;
foreach (int num in array)
    flatArray[index++] = num;
Array.Sort(flatArray);
index = 0;
for (int i = 0; i < array.GetLength(0); i++)
    for (int j = 0; j < array.GetLength(1); j++)
        array[i, j] = flatArray[index++];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i, j] + " ");
    Console.WriteLine();
} */

// 9.1.3. Написати програму, що буде видаляти з масиву елемент за вказаним індексом.

/* int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
Console.Write("Please enter the number to delete: ");
int index = int.Parse(Console.ReadLine());
if (index >= 0 && index < array.Length)
{
    int[] newArray = new int[array.Length - 1];
    for (int i = 0, j = 0; i < array.Length; i++)
        if (i != index)
            newArray[j++] = array[i];
    Console.WriteLine("A new array is: " + string.Join(", ", newArray));
}
else
{
    Console.WriteLine("THe number is wrong");
} */

// 9.1.4. Написати програму, що буде знаходити суму елементів по діагоналі у двовимірному масиві.

int[,] array = {
    { 78, 2, 3 },
    { 4, 52, 6 },
    { 7, 8, 34 }
};
int diagonalSum = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    diagonalSum += array[i, i];
}
Console.WriteLine("The summ of the elements is: " + diagonalSum);