using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infoware.Specification
{
    public abstract class ExpressionSpecification<T> : ISpecification<T>
    {
        public Expression<Func<T, bool>> Expression { get; }

        private Func<T, bool>? _expressionFunc;
        private Func<T, bool> ExpressionFunc => _expressionFunc ??= Expression.Compile();

        protected ExpressionSpecification(Expression<Func<T, bool>> expression)
        {
            Expression = expression;
        }

        public bool IsSatisfied(T obj)
        {
            return ExpressionFunc(obj);
        }
    }
}
