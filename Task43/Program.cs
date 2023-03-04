// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


int[] InputArray(string text)
{
    Console.WriteLine(text);
    int[] array = new int[4];
    string[] arrayText = new string[4] { "b1", "k1", "b2", "k2" };
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите значение {arrayText[i]}:");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
int[] FindingTheIntersectionPoint(int[] array)
{
    int[] arrayXY = new int[2];
    if (array[1] == array[3] && array[0] == array[2])
    {
        Console.WriteLine("Графики совпадают");
    }
    else if (array[1] == array[3])
    {
        Console.WriteLine("Графики параллельны");
    }
    else
    {
        arrayXY[0] = (array[2] - array[0]) / (array[1] - array[3]);
        arrayXY[1] = array[1] * arrayXY[0] + array[0];
    }
    return arrayXY;
}
void PrintArray(int[] array)
{
    Console.WriteLine("(" + string.Join("; ", array) + ")");
}

PrintArray(FindingTheIntersectionPoint(InputArray("Для определения точки пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2")));

