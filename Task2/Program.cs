/*Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

int GetNumber(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine());
    return result; 
} 
int b1 = GetNumber ("Введите b1");
int k1 = GetNumber ("Введите k1");
int b2 = GetNumber ("Введите b2");
int k2 = GetNumber ("Введите k2");

double coordinateX=0;
double coordinateY=0;
if (b1==b2 && k1==k2)
{
Console.WriteLine("Прямые совпадают");
}
else if (k1==k2) 
Console.WriteLine("Прямые параллельны друг другу");
else 
{
coordinateX = (double)(b2-b1)/(k1-k2);
coordinateY = (double)(b1*k2-b2*k1)/(k2-k1); 
Console.WriteLine($"точка пересечения двух прямых с координатами: {coordinateX}; {coordinateY}");
}
