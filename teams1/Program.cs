/*Добавить к программе, которая заканчивается, когда пишем exit еще 4 команды (их можно придумать самому). Например:
SetName – Установить имя
Help – вывести список команд
SetPassword – Установить пароль
Exit – выход
WriteName – вывести имя после ввода пароля*/

string? userName = null;
string? setPassword = null;
string? userForm = ReadInt("Введите команду -> ");

string ReadInt(string text)
{
Console.Write(text);
return Console.ReadLine().ToLower();
}

void help()
{
  Console.WriteLine();
  Console.WriteLine("Список команд ");
  Console.WriteLine("setname - установить имя ");
  Console.WriteLine("setpassword – установить пароль ");
  Console.WriteLine("writeName – вывести имя после ввода пароля ");
  Console.WriteLine("help – вывести список команд ");
  Console.WriteLine("exit – выход ");
  Console.WriteLine();
  userForm = ReadInt("Введите команду -> ");
 }


while(userForm != "exit")
{
  switch(userForm)
  {
    case "help":
      help();
      break;
    
    case "userform":
      userForm = ReadInt("Введите команду -> ");
      break;
      
    case "setname":
      userName = ReadInt("Введите ваше имя -> ");
      Console.WriteLine("Пользователь создан");
      Console.WriteLine();
      goto case "userform";

    case "setpassword":
      setPassword = ReadInt("Придумайте пароль -> ");
      Console.WriteLine("Пароль создан");
      Console.WriteLine();
      goto case "userform";

    case "writename":
    {
      if(setPassword == null ||userName == null)
      {
        if(setPassword == null)
        {
         Console.WriteLine("Вы не задали пароль");
         Console.WriteLine("Чтобы задать новый пароль, напишите команду setpassword !");
          goto case "userform";
        }
        {
          Console.WriteLine("Вы не задали имя");
          Console.WriteLine("чтобы задать имя, напишите команду setname !");
          goto case "userform";
        }
      }
      if(setPassword != null && userName != null)
      {
         string checkPass = ReadInt("Введите ваш пароль -> ");
         Console.WriteLine();
         if(checkPass == setPassword)
              {
                Console.WriteLine($"userName = {userName}");
                Console.WriteLine($"setPassword = {setPassword}");
                Console.WriteLine();
                goto case "userform";
              }
              {
                Console.WriteLine("Вы указали неверный пароль");
                Console.WriteLine("Чтобы задать новый пароль, напишите команду setpassword !");
               goto case "userform";
              }
      }
   }    
    break;
    default:
    Console.WriteLine($"{userForm} - такой команды не существует!");
    help();
    break;
}
}

Console.WriteLine("до свидания!");