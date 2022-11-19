/*Добавить к программе, которая заканчивается, когда пишем exit еще 4 команды (их можно придумать самому). Например:
SetName – Установить имя
Help – вывести список команд
SetPassword – Установить пароль
Exit – выход
WriteName – вывести имя после ввода пароля*/

Help();
string? UserName = null;
string? SetPassword = null;
string? userForm = ReadInt("Введите команду -> ");

string ReadInt(string text)
{
Console.Write(text);
return Console.ReadLine().ToLower();
}

while(userForm != "exit")
{
  switch(userForm)
  {
    case "help":
    Commands();
    break;
    case "setname":
    UserName = ReadInt("Введите ваше имя -> ");
    Console.WriteLine("Пользователь создан");
    Console.WriteLine();
    userForm = ReadInt("Введите команду -> ");
    break;
    case "setpassword":
    SetPassword = ReadInt("Придумайте пароль -> ");
    Console.WriteLine("Пароль создан");
    Console.WriteLine();
    userForm = ReadInt("Введите команду -> ");
    break;
    case "writename":
    string checkPass = ReadInt("Введите ваш пароль -> ");
    Console.WriteLine();
    if(checkPass == SetPassword)
    {
      if(UserName == null)
      {
        Console.WriteLine("Вы не задали имя");
        Console.WriteLine("Чтобы задать имя, напишите команду SetName");
        Console.WriteLine();
        userForm = ReadInt("Введите команду -> ");
      }
      else
      {
        Console.WriteLine($"UserName = {UserName}");
        Console.WriteLine($"SetPassword = {SetPassword}");
        Console.WriteLine();
        userForm = ReadInt("Введите команду -> ");
      }
    }
    else
    {
      Console.WriteLine("Пароль неверный или нет имени!");
      Console.WriteLine();
      userForm = ReadInt("Введите команду -> ");
    }
    break;
    default:
    Console.WriteLine($"{userForm} - такой команды не существует!");
    Commands();
    break;
  }
}
Console.WriteLine("До свидания!");
void Commands()
{
  Console.WriteLine();
  Console.WriteLine("Список команд ");
  Console.WriteLine("SetName - установить имя ");
  Console.WriteLine("SetPassword – установить пароль ");
  Console.WriteLine("WriteName – вывести имя после ввода пароля ");
  Console.WriteLine("Help – вывести список команд ");
  Console.WriteLine("Exit – выход ");
  Console.WriteLine();
  userForm = ReadInt("Введите команду -> ");
 }
 
 void Help()
 {
  Console.WriteLine("Для вывода списка команд наберите help");
 }