// See https://aka.ms/new-console-template for more information
using ConsoleAppTest;
using Infoware.Specification;

var specification = new In21CenturySpecification();
DateTime isNow = DateTime.Now;

Console.WriteLine($"We are in 21 Century? {specification.IsSatisfied(isNow)}");

var user = new UserModel()
{
    Id = 1,
    Name = "Victor",
    Height = 180,
    Age = 20
};

var youngerSpecification = new YoungerThanSpecification(18);


Console.WriteLine($"Are you a child? {youngerSpecification.IsSatisfied(user)}");

Console.WriteLine($"Are you a child? {user.YoungerThan(18)}");

var rangeSpecification = YoungerThanSpecificationExtension.Create(35)
    .And(OlderThanSpecificationExtension.Create(18));

Console.WriteLine($"Are you between 18 and 35 years old? {rangeSpecification.IsSatisfied(user)}");
