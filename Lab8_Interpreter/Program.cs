using System;
using System.Collections.Generic;

namespace Lab8_Interpreter
{
    //Программа для вычисления простейших математических операций сложения и вычитания с помощью переменных
    class Program
    {
        static void Main(string[] args)
        {
            double.TryParse(Console.ReadLine()?.Replace('.', ','), out double a);
            double.TryParse(Console.ReadLine()?.Replace('.', ','), out double b);
            double.TryParse(Console.ReadLine()?.Replace('.', ','), out double c);
            double.TryParse(Console.ReadLine()?.Replace('.', ','), out double d);

            Context context = new Context();
            context.SetVarValue("a", a);
            context.SetVarValue("b", b);
            context.SetVarValue("c", c);
            context.SetVarValue("d", d);

            //a + b - c + d
            IExpression exp = new AddExpression(
                new SubtractExpression(
                    new AddExpression(
                        new NumberExpression("a"), new NumberExpression("b")),
                    new NumberExpression("c")),
                new NumberExpression("d"));

            double res = exp.Interpret(context);
            Console.WriteLine($"{a} + {b} - {c} + {d} = {res}");

            Console.ReadKey();
        }
    }
}
