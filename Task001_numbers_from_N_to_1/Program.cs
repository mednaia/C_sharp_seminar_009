// Показать натуральные числа от N до 1, N задано

// for(int n = 10; n>0; n--)
// {
//     Console.Write($"{n} ");
// }

// string NumbersRec(int a, int n)
// {
// if (a <= n) return NumbersRec(a + 1, n) + $"{a} ";
// else return String.Empty;
// }
// Console.WriteLine(NumbersRec(1, 10));

void Num(int n)
{
    if(n > 0)
    {
        Console.Write("{0} ", n);
        Num(n - 1);
    }
}

Console.WriteLine("Input the number");
int n = int.Parse(Console.ReadLine());
Num(n);



