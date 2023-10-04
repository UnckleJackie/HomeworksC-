// Поработаем здесь над булевыми методами

bool IsPalindrome (int number)
{
    if(number <= 0)
    {
        System.Console.WriteLine("Брат, ты дал число, которое меньше нуля!");
        return false;
    }
    else
    {
        if (number > 0 & number < 100)
        {
        System.Console.WriteLine("Твое число в пределах сотни");
        return true;
        }
        else
        {
            System.Console.WriteLine("По ходу твое число уже трехзначное, а то и больше");
            return true;
        }
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
