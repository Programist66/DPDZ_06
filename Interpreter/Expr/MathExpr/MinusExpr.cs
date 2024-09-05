namespace Interpreter.Expr.MathExpr;

public class MinusExpr : BinaryExpr
{
    public MinusExpr(IExpr left, IExpr right) : base(left, right)
    {
    }

    public override int Calculate()
    {
        return left.Calculate() - right.Calculate();
    }
}
