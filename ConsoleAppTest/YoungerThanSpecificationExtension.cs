using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTest
{
    public static class YoungerThanSpecificationExtension
    {
        public static YoungerThanSpecification Create(int threshold) => new(threshold);

        public static bool YoungerThan(this UserModel userModel, int threshold)
        {
            var specification = Create(threshold);
            bool result = specification.IsSatisfied(userModel);
            return result;
        }

        public static IEnumerable<UserModel> YoungerThan(this IEnumerable<UserModel> userModels, int threshold)
        {
            return userModels.Where(x => x.YoungerThan(threshold));
        }

        public static IQueryable<UserModel> YoungerThan(this IQueryable<UserModel> userModels, int threshold)
        {
            return userModels.Where(Create(threshold).Expression);
        }

    }
}
