namespace Infoware.Specification
{
    public interface IExpressionSpecificationOperator
    {
        ExpressionSpecification<T> AndAlso<T>(ExpressionSpecification<T> left, ExpressionSpecification<T> right);
        ExpressionSpecification<T> OrElse<T>(ExpressionSpecification<T> left, ExpressionSpecification<T> right);
    }
}