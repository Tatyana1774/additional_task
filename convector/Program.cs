//Конвертер валют. У пользователя есть баланс в каждой из представленных валют. С помощью команд он может попросить сконвертировать одну валюту в другую.
//Курс конвертации просто описать в программе. Программа заканчивает свою работу в тот момент, когда решит пользователь.

public class Program
{
public static void Main()
{
double sumUsd, sumRub, sumEur, convSumUsd, convSumRub, convSumEur;
string? firstValue, secondValue;
Console.WriteLine("Здравствуйте. Это конвектор валют. Здесь ты можешь перевести свои деньги;");

Console.Write("Сколько у тебя USD? -> ");
sumUsd = Convert.ToSingle(Console.ReadLine());

Console.Write("Сколько у тебя RUB? -> ");
sumRub = Convert.ToSingle(Console.ReadLine());

Console.Write("Сколько у тебя EUR? -> ");
sumEur = Convert.ToSingle(Console.ReadLine());

Console.WriteLine("Для выхода из конвектора напиши  - end ");

while (true)
{
Console.Write("\n1)USD\n2)RUB\n3)EUR");
Console.Write("\nИз какой валюты хотите выполнить перевод? -> ");
firstValue = Console.ReadLine();
if (firstValue.ToLower() == "end")
{
break;
}

Console.Write("\nВ какую вылюту вы хотите перевести? -> ");
secondValue = Console.ReadLine();
if (firstValue.ToLower() == "end")
{
break;
}
else if (firstValue == "1" && secondValue == "2")
{
Console.Write("\nСколько вы отдаёте Долларов? -> ");
convSumUsd = Convert.ToSingle(Console.ReadLine());
if(convSumUsd > sumUsd)
{
Console.WriteLine("\n У вас недостаточно Долларов!\n ");
}
else
{
Console.WriteLine("\nКурс Доллара к Рублю на данный момент = 60.66");
sumUsd -= convSumUsd;
sumRub += convSumUsd * 60.66;
Console.WriteLine($"Сейчас у вас на счету {sumUsd.ToString("0.00")} Долларов и {sumRub.ToString("0.00")} Рублей");
}
}
else if (firstValue == "1" && secondValue == "3")
{
Console.Write("\nСколько Долларов вы хотите поменять? -> ");
convSumUsd = Convert.ToSingle(Console.ReadLine());
if (convSumUsd > sumUsd)
{
Console.WriteLine("\nУ вас недостаточно Долларов!\n ");
}
else
{
Console.WriteLine("\nКурс Доллара к Евро на данный момент = 0.96787");
sumUsd -= convSumUsd;
sumEur += convSumUsd / 0.96787;
Console.WriteLine($"Сейчас у вас на счету {sumUsd.ToString("0.00")} Долларов и {sumEur.ToString("0.00")} Евро");
}
}
else if (firstValue == "2" && secondValue == "1")
{
Console.Write("\nСколько Рублей вы хотите обменять? -> ");
convSumRub = Convert.ToSingle(Console.ReadLine());
if (convSumRub > sumRub)
{
Console.WriteLine("\nУ вас недостаточно Рублей!\n ");
}
else
{
Console.WriteLine("\nКурс Рубля к Доллару на данный момент = 0.016486");
sumRub -= convSumRub;
sumUsd += convSumRub / 0.016486;
Console.WriteLine($"Сейчас у вас на счету {sumRub.ToString("0.00")} Рублей и {sumUsd.ToString("0.00")} Долларов");
}
}
else if (firstValue == "2" && secondValue == "3")
{
Console.Write("\nСколько Рублей вы хотите обменять? -> ");
convSumRub = Convert.ToSingle(Console.ReadLine());
if (convSumRub > sumRub)
{
Console.WriteLine("\nУ вас недостаточно Рублей!\n ");
}
else
{
Console.WriteLine("\nКурс Рубля к Евро на данный момент = 0.016083");
sumRub -= convSumRub;
sumEur += convSumRub / 0.016486;
Console.WriteLine($"Сейчас у вас на счету {sumRub.ToString("0.00")} Рублей и {sumEur.ToString("0.00")} Евро ");
}
}
else if (firstValue == "3" && secondValue == "1")
{
Console.Write("\nСколько Евро вы хотите обменять? -> ");
convSumEur = Convert.ToSingle(Console.ReadLine());
if (convSumEur > sumEur)
{
Console.WriteLine("\nУ вас недостаточно Евро!\n ");
}
else
{
Console.WriteLine("\nКурс Евро к Доллару на данный момент = 1.03");
sumEur -= convSumEur;
sumUsd += convSumEur * 1.03;
Console.WriteLine($"Сейчас у вас на счету {sumEur.ToString("0.00")} Евро и {sumUsd.ToString("0.00")} Долларов ");
}
}
else if(firstValue == "3" && secondValue == "2")
{
Console.Write("\nСколько Евро вы хотите обменяь? -> ");
convSumEur = Convert.ToSingle(Console.ReadLine());
if (convSumEur > sumEur)
{
Console.WriteLine("\nУ вас недостаточно Евро!\n ");
}
else
{
Console.WriteLine("\nКурс Евро к Рублю на данный момент = 62.18");
sumEur -= convSumEur;
sumRub += convSumEur * 62.18;
Console.WriteLine($"Сейчас у вас на счету {sumEur.ToString("0.00")} Евро и {sumRub.ToString("0.00")} Рублей ");
}
}
}
Console.WriteLine("Спасибо, что использовали мой конвектор валют))");
}
}