using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter.Expr
{
    internal class InputExpr : IExpr
    {
        public int Calculate()
        {
            int num;
            Int32.TryParse(Console.ReadLine(), out num);
            return num;
        }
    }
}
