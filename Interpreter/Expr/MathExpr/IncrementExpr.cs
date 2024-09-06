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
            new AssignExpr(operand, new ConstExpr(operand.Calculate() + 1)).Calculate();
            return (operand.Calculate() - 1);
        }
    }
}
