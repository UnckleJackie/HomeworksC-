// Напишите программу, которая принимает на вход число и 
// выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Prompt(string message)
{
    System.Console.Write(message); //Выводим приглашение ко вводу
    string readInput = System.Console.ReadLine(); // Вводим значение
    int result = int.Parse(readInput); //конвертируем в число
    return result; //возвращаем результат
}

int SumAllDigit(int number)
{
    int result = 0;
    while (number > 0)
    { // 9012. Берем %10 = 2 и намбер = 901 % 10 = 1 +2 = 3 и 901 / 10 = 90 / 10 = 9 + 3 = 12
        result = result + number % 10;
        number = number / 10;
    }
    return result;
}

int number = Prompt("Введите число: ");
System.Console.WriteLine($"Сумма всех цифр в числе {number} = {SumAllDigit(number)}");
