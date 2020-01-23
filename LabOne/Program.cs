using System;


// Variant 5
namespace LabOne
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputKey = ConsoleKey.Enter;

            while (inputKey != ConsoleKey.Escape)
            {
                Console.WriteLine("Введите номер уравнения для расчета: (для выхода нажмите Esc)");
                inputKey = Console.ReadKey().Key;

                switch (inputKey)
                {
                    case ConsoleKey.D1:
                        ExpressionCalculator.GetResultFromFirstExpression().ToConsole();
                        break;
                    case ConsoleKey.D2:
                        ExpressionCalculator.GetResultFromSecondExpression().ToConsole();
                        break;
                    case ConsoleKey.D3:
                        ExpressionCalculator.GetResultFromThirdExpression().ToConsole();
                        break;
                    case ConsoleKey.Escape:
                        return;
                    default:
                        Console.WriteLine("\nВведите корректный символ.");
                        break;
                }
            }
        }
    }
}
