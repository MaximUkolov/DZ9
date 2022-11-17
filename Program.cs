/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/


// Console.WriteLine("Введите число");

// int number = Convert.ToInt32(Console.ReadLine());

// printNaturalNumbers(number);


// void printNaturalNumbers(int n) {

//     if(n == 1 ) {
//         Console.Write(n);
//     } else {
//         Console.Write(n + ", ");
//         printNaturalNumbers(n-1);
//     }
// }









/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

// Console.WriteLine("Введите число число для начала счета");
// int from = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число число для окончания счета");
// int to = Convert.ToInt32(Console.ReadLine());

// printNaturalNumbers(from, to, 0);


// void printNaturalNumbers(int numberStart, int numberStop, int sum) {

//     if (numberStart > numberStop) 
//     {
//         Console.WriteLine($"Сумма элементов {sum}"); 
//         return;
//     }
//     sum += (numberStart ++);
//     printNaturalNumbers(numberStart, numberStop, sum);
// }



/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/


Console.WriteLine("Введите число число M");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число число N");
int numberN = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Значение функции {ackermannFunction(numberM, numberN)}");

int ackermannFunction(int m, int n) {

    if(m == 0) {
        return n + 1;
    }
    if(m > 0 && n == 0) {
        return ackermannFunction(m - 1, 1);
    }
    if(m > 0 && n > 0) {
       return ackermannFunction(m - 1, ackermannFunction(m, n - 1));
    }
    return ackermannFunction(m, n);
}