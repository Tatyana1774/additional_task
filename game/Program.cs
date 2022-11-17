/*3. Игра угадайка. Программа загадывает случайное число. Пользователь его угадывает. Если пользователь дает неправильный ответ, 
то программа сообщает, больше загаданное число или меньше. На отгадывание дается 3 попытки.*/

Console.WriteLine("Введите число от 0 до 10: ");
int randomNumber = new Random().Next(0, 10);
int attempts = 3;  
Console.WriteLine($"Колличество попыток {attempts}");

for(int i = 1; i <= attempts; i++)
while (true)
{
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if (number == randomNumber)
{
Console.WriteLine($"Вы угадали! Осталось {attempts-i} попыток");
}

    else if (number > randomNumber)
    {
    Console.WriteLine($"Неверно! Загаданное число меньше, чем {number}! Осталось {attempts-i} попыток");
    break;
    }
    else
    {
    Console.WriteLine($"Неверно! Загаданное число больше, чем {number}!  Осталось {attempts-i} попыток");
    break;
    }
if (number == randomNumber)
    {
    if (i == attempts)
    {
    Console.WriteLine("Попытки закончились");
    break;
    }
  }
}

