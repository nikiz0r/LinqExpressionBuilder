using System.Linq.Expressions;

namespace LinqExpressionBuilder;

public class UsageExample
{
    private readonly MemberAccessModifier<ObjectExample> _memberAccessModifier;

    public UsageExample(Expression expression)
    {
        _memberAccessModifier = new MemberAccessModifier<ObjectExample>(expression);
    }
    
    public Expression UsageTest()
    {
        return ExpressionsHelper<ObjectExample>.FromLambda(_memberAccessModifier, obj => obj.ObjectDescription != null);
    }
}
