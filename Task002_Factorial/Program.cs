// Факториал числа

// int Factorial(int n)
// {
//     int factorial = 1;
//     for(;n>0; n--)
//     {
//         factorial = factorial*n;
//     }
//     return factorial;
// }
// Console.Write(Factorial(10));


int FactorialRec(int n)
{
if (n == 1) return 1;
else return n * FactorialRec(n - 1);
}
Console.WriteLine(FactorialRec(10)); 

