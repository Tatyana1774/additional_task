
/* В переменной string есть секретное сообщение, во второй есть пароль.
Пользователю программы даётся 3 попытки ввести пароль и увидеть секретное сообщение. */
string secretMessage = "Секретное сообщение: Привет!";
string password = "123";
int attempts = 3;

string ReadInput(string text)
{
Console.Write(text);
return Console.ReadLine();
}

Console.WriteLine($"Колличество попыток {attempts}");
string checkPass = ReadInput("Введите пароль: ");

for (int i = 1; i <= attempts; i++)
{
if (checkPass == password)
{
Console.WriteLine($"Пароль верный! {secretMessage}");
break;
}
else if (i == attempts)
{
Console.WriteLine("Попытки закончились");
break;
}
else
{
Console.WriteLine($"Пароль неверный! Осталось попыток: {attempts - i} ");
checkPass = ReadInput("Введите пароль: ");
}
}