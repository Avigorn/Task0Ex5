//  Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();
int ReadInt(string message)
{
    System.Console.Write($"{message}: ");
    string inputedString = Console.ReadLine();
    if (int.TryParse(inputedString, out int convertedInt))
    {
        return convertedInt;
    }

    System.Console.WriteLine("Вы ввели не число");
    Environment.Exit(0);
    return 0;
}

int[] GenerateArray(int len)
{
    int[] array = new int[len];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = ReadInt($"Введите {i+ 1}-ый элемент массива");
    }
    return array;
}

void ShowArray(int[] arr)
{
    foreach (int item in arr)
    {
        System.Console.Write($"{item} ");
    }
}

void GetPlussNums(int[] len)
{
    int nums = 0;
    for (int i = 0; i < len.Length; i++)
    {
        if (len[i] > 0)
        {
            nums++;
        }
    }
    System.Console.WriteLine(nums);
}

int userNum = ReadInt("Введите длину массива: ");
int[] arr = GenerateArray(userNum);
ShowArray(arr);
System.Console.WriteLine();
GetPlussNums(arr);