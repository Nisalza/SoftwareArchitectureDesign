using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_Interpreter
{
    public class SubtractExpression : IExpression
    {
        private IExpression _left;
        private IExpression _right;

        public SubtractExpression(IExpression left, IExpression right)
        {
            _left = left;
            _right = right;
        }

        public double Interpret(Context context)
        {
            return _left.Interpret(context) - _right.Interpret(context);
        }
    }
}
