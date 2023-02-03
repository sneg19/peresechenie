/*Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
y = k1((b2-b1)/(k1-k2)) + b1;
k1 * x + b1 = k2 * x + b2;
*/

double UserDialogB1()
{
Console.Write("Введите координату b1: ");
double b1 = double.Parse(Console.ReadLine()!);
return b1;
}
double UserDialogK1()
{
Console.Write("Введите координату k1: ");
double k1 = double.Parse(Console.ReadLine()!);
return k1;
}
double UserDialogB2()
{
Console.Write("Введите координату b2: ");
double b2 = double.Parse(Console.ReadLine()!);
return b2;
}
double UserDialogK2()
{
Console.Write("Введите координату k2: ");
double k2 = double.Parse(Console.ReadLine()!);
return k2;
}


double CalkulatX(double b1, double k1, double b2, double k2 )
{
double x = (b1-b2)/(k2-k1);
return x;
}
double CalkulatY(double b1, double k1, double b2, double k2)
{
double y = (k2*b1-k1*b2)/(k2-k1);
return y;
}


void PrintResilt( double x, double y)
{
    Console.WriteLine($"({x}, {y})");
}


void Main()
{
    double b1 = UserDialogB1();
    double k1 = UserDialogK1();
    double b2 = UserDialogB2();
    double k2 = UserDialogK2();
    double x = CalkulatX(b1, k1, b2, k2);
    double y = CalkulatY(b1, k1, b2, k2);
    PrintResilt(x, y);
}

Main();