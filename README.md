System.ComponentModel.DataAnnotations provides attribute classes that are used to define metadata for [ASP.NET](http://ASP.NET) MVC and [ASP.NET](http://ASP.NET) data controls.

The namespace has new annotations and modifications to existing ones on .NET8. 

## Length

Specifies the minimum and maximum length of collection/string data allowed in a property.

```csharp
[Length(1, 20)]
public string FirstName { get; set; }

[Length(1, 5)]
public List<string> Courses { get; set; }
```

## Range

Specifies the numeric range constraints for the value of a data field. Now, you can specify whether the range values are inclusive or exclusive.

* **MinimumIsExclusive** : Specifies whether validation should fail for values that are equal to Minimum.
    
* **MaximumIsExclusive** : Specifies whether validation should fail for values that are equal to Maximum.
    

```csharp
[Range(15, 25, MinimumIsExclusive = true, MaximumIsExclusive = true)]
public int Age { get; set; }
```

## AllowedValues

Specifies a list of values that should be allowed in a property.

```csharp
[AllowedValues("Freshman", "Sophomore", "Junior", "Senior")]
public string Grade { get; set; }
```

# **DeniedValues**

Specifies a list of values that should not be allowed in a property.

```csharp
[DeniedValues("123456", "qwerty")]
public string Password { get; set; }
```

# **Base64String**

Specifies that a data field value is a well-formed Base64 string.

```csharp
[Base64String]
public string Hash { get; set; }
```

## Required

From the blogs, I see that RequiredAttribute has a new property, DisallowAllDefaultValues to exclude default values. However, I cannot see this new feature in the code and documentation. I guess, this was remove in the release.

# Reference

[https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations?view=net-8.0](https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations?view=net-8.0)
