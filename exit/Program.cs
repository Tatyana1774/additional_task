/* Есть программа с бесконечным циклом. Когда пользователь вводит exit программа заканчивается */

Console.Write("Введите любую цифру: ");
string? number = Console.ReadLine();
while (number != "exit")
{
Console.Write("Введите любую цифру: ");
number = Console.ReadLine();
}