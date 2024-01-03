using Infoware.Specification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTest
{
    public class YoungerThanSpecification : ExpressionSpecification<UserModel>
    {
        public YoungerThanSpecification(int threshold) : base(u => u.Age < threshold)
        {
        }
    }
}
