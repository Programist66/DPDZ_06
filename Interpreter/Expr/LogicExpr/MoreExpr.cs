using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter.Expr.LogicExpr
{
    internal class MoreExpr : BinaryExpr
    {
        public MoreExpr(IExpr left, IExpr right) : base(left, right)
        {
        }

        public override int Calculate()
        {
            return left.Calculate() > right.Calculate() ? 1 : 0;
        }
    }
}
