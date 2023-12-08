void FillArray(int[] array)
{
    Console.WriteLine("Enter elements of array:");
    for (int index = 0; index < array.Length; index++)
    {
        Console.Write($"[{index}] of [{array.Length}]: ");
        array[index] = Convert.ToInt32(Console.ReadLine());
    }
}


void ShowEvenNumbers(int[] array)
{
    int count = 0;

    for (int index = 0; index < array.Length; index++)
    {
        if (array[index] % 2 == 0)
        {
            count++;
        }
    }
    Console.WriteLine($"The number of even numbers is {count}");
}

int[] array = new int[10];

FillArray(array);
ShowEvenNumbers(array);