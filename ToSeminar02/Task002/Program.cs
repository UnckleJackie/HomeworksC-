// Напишите программу, которая выводит третью
// цифру заданного числа или сообщает, что третьей цифры нет.
// Третья цифра - это будут сотни, стало быть будем иметь дело с x / 100
// Также необходимо выполнить условие Если меньше 100, то пишем, что нет цифры

void ThirdDigit()
{
    System.Console.WriteLine("Ай, здраствуй дарагой, да, Хочищь фокус тебе пакажу. Введи по-братски число какое-нибудь: ");
    int num = Convert.ToInt32(System.Console.ReadLine());
    System.Console.WriteLine("Спасибо, слющий! Щас у тебя челюсть атпадет, те гаварю да!");
    System.Console.WriteLine();
    int thDig = num / 100;

     if (num >= 100) //либо if (thDig = 0, то меняем сценарии местами)
     {
         System.Console.WriteLine($"Ваааа, прикинь, третья цифра тваего числа {thDig} Крутяк, да? Сотка гони эээ ");
         System.Console.WriteLine();
         System.Console.WriteLine();
     }
     else     
     {
         System.Console.WriteLine("Аааай, вацок, слющий, зачем такой маленький число сказаль да, там нет третий цифра, ц-ц-ц...");
         System.Console.WriteLine();
         System.Console.WriteLine();
     }

}

ThirdDigit();