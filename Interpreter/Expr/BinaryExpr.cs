namespace Interpreter.Expr;

public abstract class BinaryExpr : IExpr
{
    protected readonly IExpr left, right;
    public BinaryExpr(IExpr left, IExpr right)
    {
        this.left = left;
        this.right = right;
    }

    public abstract int Calculate();
}
