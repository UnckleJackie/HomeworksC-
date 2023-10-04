//  Напишите программу, которая принимает на
// вход пятизначное число и проверяет, является ли оно
// палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

bool IsPalindrome (int number)
{
    if(number > 9999 && number < 100000 && number / 10000 == number % 10 && (number % 100 - number % 10) / 10 == number / 1000 - number / 10000 * 10)
    {
        System.Console.WriteLine("Да, друг, твое число является палиндромом!");
        return true;
    }
    else
    {
        System.Console.WriteLine("Твое число самое обычное и никакой ценности"
         + " в себе не несет");
        return false;
    }
}

int Prompt(string message)
{
    System.Console.Write(message);
    string readInput = System.Console.ReadLine();
    int result1 = Convert.ToInt32(readInput);
    return result1;
}

int number = Prompt("Введи пятизначное число: ");
bool result = IsPalindrome(number);
// System.Console.Write("Введите пятизначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());

//System.Console.WriteLine(result);

// int Prompt(string message) //с помощью данного метода мы получим пятизначное число
// { 
//     System.Console.Write(message);
//     int number = Convert.ToInt32(System.Console.ReadLine());
//     return number;
// }

// int num = Prompt("Здравствуй, Гражданин! Введи пятизначное число, будь человеком: ");
// System.Console.WriteLine("Благодарствую, Дорогой, секунду, я проверю, подходит ли оно под условия");
// System.Console.WriteLine($"Итак, добрый человек, ты назвал мне число {num} Отлично! ");

// if(num < 10000 || num >= 100000)
// {
//     System.Console.WriteLine("Однако, я скажу тебе, мил человек, что ты пытался обмануть меня и назвал вовсе не пятизначное число. А это означает, что либо у тебя проблемы с математикой, либо ты думал, что я совсем дурачок. В любом случае, у тебя проблемы, друг мой. И я тебе дам шанс исправиться");
// }
// else
// {
//     System.Console.WriteLine("Сейчас я тебе кое-что скажу про твое число...");
//         bool Multiplicity (int num)
//     {
//         if(num / 10000 == num % 10 && (num % 100 - num % 10) / 10 == num / 1000 - num / 10000 * 10)  // && num % 23 == 0)
//         {
//             return true;
//         }
//         else
//         {
//             return false;
//         }
//     }



//     System.Console.Write("Input num: ");
//     int num = Convert.ToInt32(Console.ReadLine());
//     bool result = Multiplicity(num);
//     System.Console.WriteLine(result);
//}

//Давай порассуждаем над решением, вообще с какого конца подойти.
//Для начала возьмем трехзачное число. Чтобы оно было палиндромом, необходимо, чтобы первая и последняя цифра совпадали:
//121, 252, 525 и тд. Как это можно проверить?
//Необходимо, чтобы сотни и единицы совпадали
//Найти сотню мы можем? Да! Это х / 100, а последняя цифра - это остаток от деления
//Давай тогда введем две переменные int firstDigit и thirdDigit и напишем метод

// bool IsPalindrome (int number)
// {
//     // int firstCheck = number % 100;
//     // int secondCheck = number / 1000;
//     if(number / 10000 == number % 10 || (number / 1000 - number / 10000 * 10) == (number % 100 - number % 10) / 10); //в первых скобках получаем 4е число, во вторых второе
//     {
//         return true;
//     }
//     else
//     {
//         return false;
//     }
// }

// bool result = IsPalindrome(number);
// IsPalindrome(Prompt(result));

// int Quarter(int A, int B)
// {
//     if(A > 0 && B > 0) return 1;
//     if(A > 0 && B < 0) return 2;
//     if(A < 0 && B < 0) return 3;
//     if(A < 0 && B > 0) return 4;
//     else return 0;
// }
// System.Console.WriteLine(Quarter(x, y));