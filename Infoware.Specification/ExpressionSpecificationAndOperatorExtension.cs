using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infoware.Specification
{
    public static class ExpressionSpecificationAndOperatorExtension
    {
        public static ExpressionSpecification<T> And<T>(this ExpressionSpecification<T> specificationLeft, ExpressionSpecification<T> specificationRight)
        {
            var specificationAndOperator = new ExpressionSpecificationAndOperator();
            ExpressionSpecification<T> expressionSpecification = specificationAndOperator.AndAlso(specificationLeft, specificationRight);
            return expressionSpecification;
        }

        public static ExpressionSpecification<T> Or<T>(this ExpressionSpecification<T> specificationLeft, ExpressionSpecification<T> specificationRight)
        {
            var specificationAndOperator = new ExpressionSpecificationAndOperator();
            ExpressionSpecification<T> expressionSpecification = specificationAndOperator.AndAlso(specificationLeft, specificationRight);
            return expressionSpecification;
        }

    }
}
