using Interpreter.Expr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter.Statement
{
    internal class ForStatement : IStatement
    {
        private AssignExpr counter;
        private IExpr condition;
        private IExpr operation;
        private IStatement statement;

        public ForStatement(AssignExpr counter, IExpr condition, IExpr operation, IStatement statement)
        {
            this.counter = counter;
            this.condition = condition;
            this.operation = operation;
            this.statement = statement;
        }

        public void Execute()
        {
            new ExprStatement(counter).Execute();
            while (condition.Calculate() != 0) 
            {
                statement.Execute();
                new ExprStatement(new AssignExpr(counter.Left, operation)).Execute();
            }
        }
    }
}
