using Interpreter.Expr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter.Statement
{
    internal class IfStatement : IStatement
    {
        private IExpr condition;
        private IStatement then;

        public IfStatement(IExpr condition, IStatement then)
        {
            this.condition = condition;
            this.then = then;
        }

        public void Execute()
        {
            if (condition.Calculate() != 0)
            {
                then.Execute();
            }
        }
    }
}
