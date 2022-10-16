

Console.Write("Enter array of strings separated by a space: ");
string input = Console.ReadLine()!;
string[] array = input.Split(' ');

string[] newArray = ArrayNoMoreThreeChars(array);
Console.WriteLine($"[ {string.Join(", ", newArray)} ]");


string[] ArrayNoMoreThreeChars(string[] array)
{
    string[] newArray = new string[array.Length];
    int i = 0;
    foreach (string item in array)
    {
        if (item.Length <= 3)
        {
            newArray[i] = item;
            i++;
        }
    }
    string[] resultArray = new string[i];
    for (int j = 0; j < resultArray.Length; j++)
    {
        resultArray[j] = newArray[j];
    }
    return resultArray;
}


// Решение, при котором сразу выводятся на печать строки, удовлетвоояющие условию по длине.


// PrintArrayNoMoreThreeChars(array);

// void PrintArrayNoMoreThreeChars(string[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i].Length <= 3)
//         {
//             Console.Write($"{array[i]} ");
//         }
//         else Console.Write("");
//     }
// }