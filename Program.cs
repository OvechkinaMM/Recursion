//Домашняя работа
// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

// Console.Write ("Введите число M: ");
// int M = Convert.ToInt32 (Console.ReadLine ());
// Console.Write ("Введите число N: ");
// int N = Convert.ToInt32 (Console.ReadLine ());
// void ShowNubers (int M, int N)
// {
//     if (M == N)
//     {
//         Console.Write (M);
//         return; // ломает всю программу, если попали в этот фрагмент

//     }
//     Console.Write (M + " ");
//     ShowNubers (M + 1, N);
// }
// ShowNubers (M, N);

//Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.


// int m = InputNumbers("Введите m: ");
// int n = InputNumbers("Введите n: ");

// int functionAkkerman = Ack(m, n);

// Console.Write($"Функция Аккермана = {functionAkkerman} ");

// int Ack(int m, int n)
// {
//   if (m == 0) return n + 1;
//   else if (n == 0) return Ack(m - 1, 1);
//   else return Ack(m - 1, Ack(m, n - 1));
// }

// int InputNumbers(string input) 
// {
//   Console.Write(input);
//   int output = Convert.ToInt32(Console.ReadLine());
//   return output;
// }



// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.
// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1 

// int [] array = {1, 2, 5, 0, 10, 34};
// int size = array.Length;
// void PrintArray (int [] array)
// {
//     int size = array.Length - 1;
//     if (size == 0)
//     {
//         Console.Write (array [size]);
//         return;
//     }

//     Console.Write (array [size]);
    
// }
