void FillArray(double[] array)
{
    Console.WriteLine("Enter elements of array:");
    for (int index = 0; index < array.Length; index++)
    {
        Console.Write($"[{index}] of [{array.Length}]: ");
        array[index] = Convert.ToDouble(Console.ReadLine());
    }
}


void PrintRange(double[] array)
{
    double min = array[0];
    double max = min;

    if (array.Length < 2)
    {
        Console.WriteLine("Array size is too small!");
    } else {

        for (int index = 0; index < array.Length; index++)
        {
            if (array[index] < min)
            {
                min = array[index];
            } else if (array[index] > max)
            {
            max = array[index];
            }
        }
        Console.WriteLine("Range is: " + (max - min));
    }
}

double[] array = new double[3];

FillArray(array);
PrintRange(array);