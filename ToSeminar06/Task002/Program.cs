// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// k1*x + b1 = k2*x + b2 => (k1 - k2)*x = b2 - b1 => x = (b2 - b1) / (k1 - k2)

double Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    double result = Convert.ToDouble(value);
    return result;
}

System.Console.WriteLine("Здравствуй, Дорогой! \n"
+ "Сейчас я буду решать для тебя задачу по поиску точки пересечения двух прямых. \n"
+ "Шаблон у нас следующий: \nЗаданы 2 прямые формата y = kx + b \n"
+ "ты задаешь мне переменные k1, k2, b1, b2  \nЯ ищу точку пересечения "
+ "и выдаю тебе результат");
System.Console.WriteLine();
System.Console.WriteLine("Решение для таких прямых выглядит следующим образом: \n"
+ "Точка пересечения - это значит, что у обоих прямых х и у совпадают, верно? \n"
+ "Стало быть k1x + b1 = k2x + b2. Перебрасываем иксы и b: \n"
+ "k1x - k2x = b2 - b1. Далее выносим х за скобки: \n"
+ "x(k1 - k2) = b2 - b1. Вытаскиваем х через деление на (k1 - k2) \n"
+ "x = (b2 - b1) / (k1 - k2). А дальше легче легкого: подставляем х и находим у: \n"
+ "y = k1x + b1.\n"
+ "Искомая точка будет (х, у) \n"
+ "Данное решение я тебе расписал на случай, если учительница спросит, \nмол, как ты решал задачу:)\n");
//System.Console.WriteLine();
System.Console.WriteLine("Итак, поехали вводить данные для расчетов...");

double k1 = Prompt("k1: ");
double b1 = Prompt("b1: ");
double k2 = Prompt("k2: ");
double b2 = Prompt("b2: ");

double FindAcrossX(double k1, double b1, double k2, double b2)
{
    double acrossX = (b2 - b1) / (k1 - k2);
    return acrossX;
}
double x = FindAcrossX(k1, b1, k2, b2);

double FindAcrossY(double k1, double b1)
{
    double acrossY = k1 * x + b1;
    return acrossY;
}
double y = FindAcrossY(k1, b1);

System.Console.WriteLine($"Координаты точки пересечения прямых y = {k1}x + {b1} и y = {k2}x + {b2}: ({x}, {y})");