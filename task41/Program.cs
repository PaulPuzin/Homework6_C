// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Введите размерность массива (число)");
int ElementsCount = Convert.ToInt32(Console.ReadLine());
int[] array = new int [ElementsCount];
for (int i = 0; i < array.Length; i++)
{
Console.WriteLine ("Введите число");   
array[i] = Convert.ToInt32(Console.ReadLine());
}
int sum = 0;
for (int i=0;i<array.Length;i++)
{
    if (array[i]>0)
    {
        sum=sum+1;
    }
}   
Console.WriteLine($"Количество чисел введенных пользователем больше нуля равно {sum}");
