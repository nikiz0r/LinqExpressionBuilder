using System.Linq.Expressions;

namespace LinqExpressionBuilder;

public class MemberAccessModifier<T> : ExpressionVisitor
{
    private readonly Expression _parameterExpression;

    public MemberAccessModifier(Expression parameterExpression)
    {
        _parameterExpression = parameterExpression;
    }

    public Expression Modify(Expression expression)
    {
        return Visit(((LambdaExpression)expression).Body);
    }

    protected override Expression VisitMember(MemberExpression node)
    {
        return node.Member.DeclaringType?.Name == typeof(T).Name
            ? Expression.Property(_parameterExpression, node.Member.Name)
            : base.VisitMember(node);
    }
}