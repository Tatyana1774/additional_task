/*Добавить к программе, которая заканчивается, когда пишем exit еще 4 команды (их можно придумать самому). Например:
SetName – Установить имя
Help – вывести список команд
SetPassword – Установить пароль
Exit – выход
WriteName – вывести имя после ввода пароля*/
string ReadInput(string text)
{
Console.Write(text);
return Console.ReadLine();
}
Console.Write("ЗДавай знакомиться :-) набери пожалуйста hi -> ");
string? number = Console.ReadLine();
string? comands = "hi";
string? comand1 = "setName";
string? comand2 = "age";
string? comand3 = "gender";
Console.Write("Здравствуй! Для заполнения анкеты наберите setName");
string checkPass2 = ReadInput("-> ");
Console.Write("Как тебя зовут? ");
string checkPass3 = ReadInput("-> ");
Console.Write("теперь нужно набрать age");
string checkPass4 = ReadInput("-> ");
Console.Write("Сколько тебе лет? "); 
string checkPass5 = ReadInput("-> ");
Console.Write("теперь нужно набрать gender");
string checkPass6 = ReadInput("-> ");
Console.Write("Какой у тебя пол? ");
string checkPass7 = ReadInput("-> ");

while (number != "exit")
{
Console.Write("Для выхода напиши exit :-) -> ");
number = Console.ReadLine();
}

