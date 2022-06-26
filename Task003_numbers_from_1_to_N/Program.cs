// Показать натуральные числа от 1 до N, N задано
///Вариант 1
// void NumberFor(int n)
// {
//     for(int i = 1; i<=n; i++) Console.Write($"{i} ");
// }
// NumberFor(10);

///Вариант 2
// string NumbersRec(int a, int b)
// {
// if (a <= b) return $"{a} " + NumbersRec(a + 1, b);
// else return String.Empty;
// }
// Console.WriteLine(NumbersRec(1, 10));

///Вариант 3
void PrintNumber(int n)
{
    if(n < 1) return;
    PrintNumber(n-1);
    Console.Write(n + " ");
}
PrintNumber(10);