using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter.Expr.MathExpr
{
    internal class IncrementExpr : UnaryExpr
    {
        public IncrementExpr(VarExpr operand) : base(operand)
        {
        }

        public override int Calculate()
        {
            return VarExpr.Vars[operand.Name]++;
        }
    }
}
