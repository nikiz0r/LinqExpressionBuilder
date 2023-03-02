namespace LinqExpressionBuilder;

public class ObjectExample : EntityObject
{
    public string? ObjectDescription { get; set; }
}

public abstract class EntityObject
{
    public Guid Id { get; set; }
}
