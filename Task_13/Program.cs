// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите  число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 99)
{
int ten =(int)Math.Log10(num);
// Находит разрядность числа
int a = num / (int)Math.Pow(10, ten-2);
// Делит число на необходимое  в 10 раз для получения трехзначного
int ThirdFigure = a % 10;
Console.WriteLine($"Третья цифра в числе {num} -> {ThirdFigure}");
}
else
{
   Console.WriteLine("В этом числе нет третьей цифры");
}
