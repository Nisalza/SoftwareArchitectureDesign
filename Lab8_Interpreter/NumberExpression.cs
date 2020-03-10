using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_Interpreter
{
    public class NumberExpression : IExpression
    {
        private readonly string _name;

        public NumberExpression(string varName)
        {
            _name = varName;
        }

        public double Interpret(Context context)
        {
            return context.GetVarValue(_name);
        }
    }
}
