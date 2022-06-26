// Показать натуральные числа от N до 1, N задано

///Вариант 1
// for(int n = 10; n>0; n--)
// {
//     Console.Write($"{n} ");
// }

///Вариант 2
// string NumbersRec(int a, int n)
// {
// if (a <= n) return NumbersRec(a + 1, n) + $"{a} ";
// else return String.Empty;
// }
// Console.WriteLine(NumbersRec(1, 10));

///Вариант 3
// void Num(int n)
// {
//     if(n > 0)
//     {
//         Console.Write("{0} ", n);
//         Num(n - 1);
//     }
// }

// Console.WriteLine("Input the number");
// int n = int.Parse(Console.ReadLine());
// Num(n);


///Вариант 4
void PrintNumber(int n)
{
    Console.Write(n + " ");
    n--;
    if(n==0) return;
    PrintNumber(n);
}

int n = 10;
PrintNumber(n);



