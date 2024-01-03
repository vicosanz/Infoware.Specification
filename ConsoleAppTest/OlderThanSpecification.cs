using Infoware.Specification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTest
{
    public class OlderThanSpecification : ExpressionSpecification<UserModel>
    {
        public OlderThanSpecification(int threshold) : base(u => u.Age > threshold)
        {
        }
    }
}
