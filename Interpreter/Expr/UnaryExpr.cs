using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter.Expr
{
    internal abstract class UnaryExpr : IExpr
    {
        protected readonly VarExpr operand;

        protected UnaryExpr(VarExpr operand)
        {
            this.operand = operand;
        }

        public abstract int Calculate();
    }
}
