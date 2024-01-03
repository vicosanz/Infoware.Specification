using System.Linq.Expressions;

namespace Infoware.Specification
{
    internal class ExpressionSpecificationAndOperator: IExpressionSpecificationOperator
    {
        public ExpressionSpecification<T> AndAlso<T>(ExpressionSpecification<T> left, ExpressionSpecification<T> right)
        {
            Expression<Func<T, bool>> resultExpression;
            ParameterExpression param = left.Expression.Parameters.First();
            if (ReferenceEquals(param, right.Expression.Parameters.First()))
            {
                resultExpression = Expression.Lambda<Func<T, bool>>(
                    Expression.AndAlso(left.Expression.Body, right.Expression.Body), param);
            }
            else
            {
                resultExpression = Expression.Lambda<Func<T, bool>>(
                    Expression.AndAlso(
                        left.Expression.Body,
                        Expression.Invoke(right.Expression, param)
                    ), 
                    param
                );
            }

            return new DynamicExpressionSpecification<T>(resultExpression);
        }

        public ExpressionSpecification<T> OrElse<T>(ExpressionSpecification<T> left, ExpressionSpecification<T> right)
        {
            Expression<Func<T, bool>> resultExpression;
            ParameterExpression param = left.Expression.Parameters.First();
            if (ReferenceEquals(param, right.Expression.Parameters.First()))
            {
                resultExpression = Expression.Lambda<Func<T, bool>>(
                    Expression.OrElse(left.Expression.Body, right.Expression.Body), param);
            }
            else
            {
                resultExpression = Expression.Lambda<Func<T, bool>>(
                    Expression.OrElse(
                        left.Expression.Body,
                        Expression.Invoke(right.Expression, param)
                    ), 
                    param
                );
            }

            return new DynamicExpressionSpecification<T>(resultExpression);
        }
    }
}