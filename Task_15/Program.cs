//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите порядковый номер дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());
if (day > 0 & day < 8)
{
   
    if (day < 6)
    {
       Console.WriteLine("К сожалению,  сегодня рабочий день "); 
    }
    else
    {
        Console.WriteLine("Ура! Сегодня выходной!"); 
    }
}
else
{
    Console.WriteLine("В неделе 7 дней!");
}   