using Interpreter.Expr;
using Interpreter.Expr.LogicExpr;
using Interpreter.Expr.MathExpr;
using Interpreter.Statement;

namespace Interpreter;

internal class Program {
    static void Main (string[] args) 
    {
        new BlockStatement
        (
            new ExprStatement
            (
                new AssignExpr
                (
                    new VarExpr("n"),
                    new InputExpr()
                )
            ),
            new ExprStatement
            (
                new AssignExpr
                (
                    new VarExpr("sum"),
                    new ConstExpr(0)
                )
            ),
            new ForStatement
            (
                new AssignExpr
                (
                    new VarExpr("i"),
                    new ConstExpr(0)
                ),
                new LessExpr
                (
                    new VarExpr("i"),
                    new VarExpr("n")
                ),
                new IncrementExpr
                (
                    new VarExpr("i")
                ),
                new ExprStatement
                (
                    new AssignExpr
                    (
                        new VarExpr("sum"),
                        new PlusExpr
                        (
                            new VarExpr("sum"),
                            new VarExpr("i")
                        )
                    )
                )
            ),
            new ExprStatement
            (
                new PrintExpr(new VarExpr("sum"))
            )
        ).Execute();
    }
}
