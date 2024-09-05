using Interpreter.Expr;

namespace Interpreter.Statement;

public class IfElseStatement : IStatement
{
    private IExpr condition;  // условие
    private IStatement then;
    private IStatement @else;

    public IfElseStatement(IExpr condition, IStatement then, IStatement @else)
    {
        this.condition = condition;
        this.then = then;
        this.@else = @else;
    }

    public void Execute()
    {
        if (condition.Calculate() != 0)
        {
            then.Execute();
        }
        else
        {
            @else.Execute();
        }
    }
}
