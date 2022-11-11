double[] array = { 3, 7, 22, 2, 78 };                      //Создание  массива, заполненного вещественными числами;
int i;
void fillArray (double [] array)                            //Заполнение массива
{
for (i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}
}
fillArray (array);

Console.WriteLine();

double findMax(double[] array)
{
    double max;                                     //Поиск максимального значения в массиве
    max = array[0];
    for (i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}
double max = findMax(array);

Console.WriteLine("Максимальное значение: " + max);

double findMin(double[] array)
{
    double min;                                        //Поиск минимального в массиве;
    min = array[0];
    for (i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}
double min = findMin(array);
Console.WriteLine("Минимальное значение: " + min);
Console.WriteLine("Разность: " + (max - min));                     //разность 