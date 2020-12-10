using System;

namespace QuadraticEquationConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение a = ");      //Вывод на консоль строки "Введите значение a = "
            double a = Convert.ToDouble(Console.ReadLine());   //Ввод значения вещественного числа а
            Console.Write("Введите значение b = ");      //Вывод на консоль строки "Введите значение b = "
            double b = Convert.ToDouble(Console.ReadLine());   //Ввод значения вещественного числа b
            Console.Write("Введите значение c = ");      //Вывод на консоль строки "Введите значение c = "
            double c = Convert.ToDouble(Console.ReadLine());   //Ввод значения вещественного числа c
            double D, x1, x2;     //Объявление вещественных переменных D, x1, x2
            D = b * b - 4 * a * c;     //Вычисление дискриминанта 
            Console.WriteLine($"a = {a}  b = {b}  c = {c}  D = {D}");    //Вывод на консоль значений a, b, c и D
            if (D < 0)     //Проверка значения дискриминанта
            {
                Console.WriteLine("Дискриминант меньше 0. Корней уравнения нет!");  //Вывод сообщения, если D < 0.00
            }
            else if (D == 0)
            {
                Console.WriteLine("Дискриминант равен 0. Уравнение имеет один корень!");  //Вывод сообщения, если D = 0.00
                x1 = -b / (2 * a);    //Вычисление корня уравнения
                Console.WriteLine($"Корень уравнения = {x1}");    //Вывод корня уравнения
            }
            else
            {
                Console.WriteLine("Дискриминант больше 0. Уравнение имеет два корня!");  //Вывод сообщения, если D > 0.00
                x1 = (-b + Math.Sqrt(D)) / (2 * a);    //Вычисление 1-го корня уравнения
                x2 = (-b - Math.Sqrt(D)) / (2 * a);    //Вычисление 2-го корня уравнения
                Console.WriteLine($"Корни уравнения:  x1 = {x1},  x2 = {x2}.");     //Вывод корней уравнения
            }
        }
    }
}
