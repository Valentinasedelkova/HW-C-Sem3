// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> дa

static string Palindromos(int number)
    {
        string numberString = number.ToString();
        int i = 0;
        int j = numberString.Length - 1;
        while (i < j)
        {
            if (numberString[i] != numberString[j])
            {
                return "нет";
            }

            i++;
            j--;
        }
            return "да";
    }

int GetInfo(string message)
{
    Console.Write(message);
    int inputNum = Convert.ToInt32(Console.ReadLine());
    return inputNum;
}

int number = GetInfo("Введите пятизначное число: ");
Console.WriteLine(Palindromos(number));
