using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_15.Интерфейсы
{
    internal class Program
    {
        static void Main(string[] args)
        {
        calc:
            Console.WriteLine("Введите начальное значение прогрессии целое число:");
            int firstValue = Int32.Parse(Console.ReadLine());
            Console.WriteLine("\nВведите шаг арифметической прогрессии:");
            int stepValue = Int32.Parse(Console.ReadLine());
            Console.WriteLine("\nВведите шаг геометрической прогрессии:");
            int denomValue = Int32.Parse(Console.ReadLine());
            Console.WriteLine("\nВведите количество членов прогрессий:");
            int number = Int32.Parse(Console.ReadLine());
            Console.WriteLine();

            ArithProgression arith = new ArithProgression(firstValue, stepValue);
            Console.WriteLine("\nАрифметическая прогрессия:\n");
            Console.Write($"\t{firstValue} ");
            for (int i = 0; i < number - 1; i++)
            {
                Console.Write($"\t{arith.getNext()} ");
            }
            Console.WriteLine();

            GeomProgression geom = new GeomProgression(firstValue, denomValue);
            Console.WriteLine("\nГеометрическая прогрессия:\n");
            Console.Write($"\t{firstValue} ");
            for (int i = 0; i < number - 1; i++)
            {
                Console.Write($"\t{geom.getNext()} ");
            }

            Console.WriteLine("\nесли хотите начать заново  - Нажмите <Enter>, \nДля выхода, нажмите любую клавишу...");
            if (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                Console.Clear();
                goto calc;

            }
            Console.ReadKey();

            arith.setStart(firstValue);
            arith.setStep(stepValue);

            Console.WriteLine(arith.getNext());
            Console.WriteLine(arith.getNext());
            Console.WriteLine(arith.getNext());
            arith.reset();
            Console.WriteLine(arith.getNext());
            Console.WriteLine(arith.getNext());
            geom.reset();


        }

    }
}
