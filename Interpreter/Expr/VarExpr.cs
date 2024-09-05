namespace Interpreter.Expr;

public class VarExpr : IExpr
{
    public static IDictionary<string, int> Vars { get; } = new Dictionary<string, int>();

    public string Name { get; }
    public VarExpr(string name)
    {
        Name = name;
    }

    public int Calculate()
    {
        return Vars[Name];
    }
}
