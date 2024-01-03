using Infoware.Specification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTest
{
    public class In21CenturySpecification : ISpecification<DateTime>
    {
        private readonly DateTime _start = new DateTime(2001, 01, 01);
        private readonly DateTime _end = new DateTime(2101, 01, 01);

        public bool IsSatisfied(DateTime obj)
        {
            bool result = obj >= _start && obj < _end;
            return result;
        }
    }
}
