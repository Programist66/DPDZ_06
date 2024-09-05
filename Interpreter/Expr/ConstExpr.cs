namespace Interpreter.Expr;

public class ConstExpr : IExpr
{
    private int value;
    public ConstExpr(int value) 
    {
        this.value = value; 
    }

    public int Calculate() 
    {
        return value;
    }
}
