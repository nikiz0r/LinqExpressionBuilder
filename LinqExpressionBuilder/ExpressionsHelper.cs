using System.Linq.Expressions;

namespace LinqExpressionBuilder;

public static class ExpressionsHelper<TEntityObject> where TEntityObject : EntityObject
{
    public static Expression FromLambda<T>(MemberAccessModifier<TEntityObject> memberAccessModifier, Expression<Func<TEntityObject, T>> expression)
    {
        return memberAccessModifier.Modify(expression);
    }
}
