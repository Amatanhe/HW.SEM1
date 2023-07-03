// Задача 10:

// Console.WriteLine ("Напишите 3 значное число: ") ;
// int n = Convert.ToInt32 (Console.ReadLine ()) ;
// int FirstDigit = n / 10;
// int SecondDigit = FirstDigit % 10;
// Console.Write($"Второе число равно {SecondDigit} ");

// Задача 13:
// int number = ReadInt("Введите число: ");
// int count = number.ToString().Length;
// Console.Write(MakeArray(number, count));
// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }
// int MakeArray(int a, int b)
// {
// int result = 0;
//     if (b < 3)
//     {
//         Console.Write("Третьей цифры нет, держи: ");
//     }
//     else
//     {
//         int c = 1;
//         for (int i = b; i > 3; i--)
//         {
//             c = c * 10;
//         }

//         result = (a / c) % 10;
//     }
// return result;
// }

// Задача 15:
// Console.WriteLine ("Напишите любое число, обозначающее день недели (1-7): ") ;
// int day = Convert.ToInt32 (Console.ReadLine ()) ;
// if ( day < 1 && day > 7)
// {
// Console.Write("Это не день недели");
// };
// if (day < 5)
// {
// Console.Write("Это будний день");
// }
// else
// {
// Console.Write("Это выходной день");
// };

// Задача доп.:

// Console.WriteLine ("Напишите 3 значное число: ") ;
// int number = Convert.ToInt32 (Console.ReadLine ()) ;
// int FirstDigit = 0;
// int SecondDigit= 0;
// int ThirdDigit = 0;
// int Sum= 0;
// int Mult = 0;
// FirstDigit = number / 100;
// SecondDigit = (number % 100) / 10;
// ThirdDigit = (number % 100) % 10;
// Sum = FirstDigit + SecondDigit + ThirdDigit ;
// Mult = FirstDigit * SecondDigit * ThirdDigit ;
// if ( Mult % Sum == 0)
// {
// Console.WriteLine ("Число интересное") ;
// }
// else
// {
// Console.Write ("Это не интересное число");
// }