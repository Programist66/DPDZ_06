namespace Interpreter.Expr;

public class AssignExpr : IExpr
{
    public VarExpr Left { get; }
    private IExpr right;

    public AssignExpr(VarExpr left, IExpr right)
    {
        this.Left = left;
        this.right = right;
    }

    public int Calculate()
    {
        return VarExpr.Vars[Left.Name] = right.Calculate();
    }
}
