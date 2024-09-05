using Interpreter.Expr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter.Statement
{
    internal class WhileStatement : IStatement
    {
        private IExpr conditions;
        private IStatement statement;

        public WhileStatement(IExpr conditions, IStatement statement)
        {
            this.conditions = conditions;
            this.statement = statement;
        }

        public void Execute()
        {
            while (conditions.Calculate() != 0)
            {
                statement.Execute(); 
            }
        }
    }
}
