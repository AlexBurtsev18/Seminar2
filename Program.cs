// Task 1. Напишите программу, которая на вход принимает случайное трехзначное число
// и удаляет вторую цифру этого числа.

// int CutNumber(int num)
// {
//     int hundreds = num / 100;
//     int unites = num % 10;
//     int result = hundreds * 10 + unites;
//     return result;
// }

// int randNumber = new Random().Next(100, 1000);
// int shortNumber = CutNumber(randNumber);
// Console.WriteLine($"New version of {randNumber} is {shortNumber}");

// Task 2++. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// int Numeral(int num)
// {
//     int decade = num / 10;
//     return decade;
// }
// int randNumber = new Random().Next(10, 100);
// int firstNum = Numeral(randNumber);
// Console.WriteLine($"First number of {randNumber} is {firstNum}");


// Task 3+. Напишите программу, которая будет принимать на вход два числа и выводить,
// является ли второе число кратным первому.
//bool

// bool Even(int num1, int num2)
// {
//     if(num2 % num1 == 0)
//         return true;    
//     else
//         return false;
// }

// Console.WriteLine("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// bool result = Even(num1, num2);
// Console.WriteLine(result);


// Task 4. Напишите программу, которая принимает на вход число N и проверяет, кратно ли оно одновременно a и b.

// bool Even(int num1, int num2, int arg)
// {
//     if(arg % num1 == 0 && arg % num2 == 0)
//         return true;    
//     else
//         return false;
// }

// Console.WriteLine("Введите проверочное число: ");
// int arg = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// bool result = Even(num1, num2, arg);
// Console.WriteLine(result);

// Task 5++. Напишите программу, которая принимает на вход два числа и проверяет, 
// является ли одно число квадратом второго.

bool Check(int num1, int num2)
{
    if(num1 == num2 * num2 || num2 == num1 * num1)
        return true;
    else
        return false;
}

Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
bool result = Check(num1, num2);
Console.WriteLine(result);