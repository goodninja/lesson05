// Задача 2: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

Console.Write($"Задайте количество элементов для одномерного массива: ");
int numberOfElements = Convert.ToInt32(Console.ReadLine());

int RandomNumbers(int numberOfElements, int min, int max)
{
    int[] randomNumbers = new int[numberOfElements];
    int sumOfElements = 0;
    Console.Write("Массив: ");

    for (int i = 0; i < randomNumbers.Length; i++)
    {
        randomNumbers[i] = new Random().Next(min, max);

        Console.Write(randomNumbers[i] + " ");

        if (i % 2 != 1)
        {
            sumOfElements = sumOfElements + randomNumbers[i];
        }
    }
    return sumOfElements;
}

int randomNumbers = RandomNumbers(numberOfElements, 1, 10);

Console.WriteLine($"\nСумма элементов на нечётных позициях = {randomNumbers}");