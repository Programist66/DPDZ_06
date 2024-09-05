namespace Interpreter.Expr;

public class PrintExpr : IExpr
{
    private IExpr expr;
    public PrintExpr(IExpr expr) 
    { 
        this.expr = expr; 
    }

    public int Calculate()
    {
        Console.WriteLine(expr.Calculate());
        return 0;
    }
}
