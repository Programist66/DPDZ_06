namespace Interpreter.Expr.MathExpr;

public class PlusExpr : BinaryExpr
{
    public PlusExpr(IExpr left, IExpr right) : base(left, right)
    {
    }

    public override int Calculate()
    {
        return left.Calculate() + right.Calculate();
    }
}
