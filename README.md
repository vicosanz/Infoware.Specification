# Infoware.Specification
 Specification Pattern implementation

### Get it!
[![NuGet Badge](https://buildstats.info/nuget/Infoware.Specification)](https://www.nuget.org/packages/Infoware.Specification/)

### How to use it
- Create a new specification based on a class, pass into the constructor parameters and business logic as a boolean function

```csharp
	public class OlderThanSpecification : ExpressionSpecification<UserModel>
    {
        public OlderThanSpecification(int threshold) : base(user => user.Age > threshold)
        {
        }
    }

```

- Use this lambda function wrapper like this

```csharp
	var olderSpecification = new OlderThanSpecification(30);


    Console.WriteLine($"Are you a senior? {olderSpecification.IsSatisfied(user)}");
```

- Use this lambda function wrapper like this

```csharp
	var olderSpecification = new OlderThanSpecification(30);

	List<UserModel> users = _dataContext.UserModels.Where(olderSpecification).ToList();

    var youngerSpecification = new YoungerThanSpecification(50);

    List<UserModel> users30to50 = _dataContext.UserModels.Where(olderSpecification.And(youngerSpecification).ToList();


```

## Buy me a coofee
If you want, buy me a coofee :coffee: https://www.paypal.com/paypalme/vicosanzdev?locale.x=es_XC

