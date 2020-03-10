using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_Interpreter
{
    public class Context
    {
        private readonly Dictionary<string, double> _vars;

        public Context()
        {
            _vars = new Dictionary<string, double>();
        }

        public double GetVarValue(string name) => _vars[name];

        public void SetVarValue(string name, double value)
        {
            if (_vars.ContainsKey(name))
            {
                _vars[name] = value;
            }
            else
            {
                _vars.Add(name, value);
            }
        }
    }
}
