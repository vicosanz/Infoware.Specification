using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTest
{
    public static class OlderThanSpecificationExtension
    {
        public static OlderThanSpecification Create(int threshold) => new(threshold);

        public static bool OlderThan(this UserModel userModel, int threshold)
        {
            var specification = Create(threshold);
            bool result = specification.IsSatisfied(userModel);
            return result;
        }

        public static IEnumerable<UserModel> OlderThan(this IEnumerable<UserModel> userModels, int threshold)
        {
            return userModels.Where(x => x.OlderThan(threshold));
        }

        public static IQueryable<UserModel> OlderThan(this IQueryable<UserModel> userModels, int threshold)
        {
            return userModels.Where(Create(threshold).Expression);
        }

    }
}
