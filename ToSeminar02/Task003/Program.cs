// Напишите программу, которая принимает на
// вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным.

bool Weekend (int num)
{
    if(num == 6 & num == 7)
    {
        return true;
    }
    else
    {
        return false;
    }
}

System.Console.Write("Input day of the week: ");
int num = Convert.ToInt32(Console.ReadLine());
bool result = Weekend(num);
System.Console.WriteLine(result);