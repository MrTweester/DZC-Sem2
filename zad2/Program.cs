//  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = 0;
int digit3 = 0;
if (number>99 && number<1000)
{
    digit3=number%10;
    Console.Write($"{number} -> {digit3}");
}
else if(number<99)
{
    Console.Write($"{number} ->третьей цифры нет");
}
else
{
    while (number>1000)
    {
    result = number/10;
    }
    digit3=result%10;
    Console.Write($"{number} -> {digit3}");
}
// while (number>1000)
// {
//     result = number/10;
// }
// if (number<=99)
// {
// Console.Write($"{number} ->третьей цифры нет");
// }
// else
// {
//     digit3 = result%10;
//     Console.Write($"{number} -> {digit3}");
// }