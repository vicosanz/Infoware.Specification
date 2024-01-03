using System.Linq.Expressions;

namespace Infoware.Specification
{
    public class DynamicExpressionSpecification<TModel> : ExpressionSpecification<TModel>
    {
        public DynamicExpressionSpecification(Expression<Func<TModel, bool>> expression) : base(expression)
        {
        }
    }
}