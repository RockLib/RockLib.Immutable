# RockLib.Immutable [![Build status](https://ci.appveyor.com/api/projects/status/e217hl1l8yaj7du7?svg=true)](https://ci.appveyor.com/project/RockLib/rocklib-immutable) [![NuGet](https://img.shields.io/nuget/vpre/RockLib.Immutable.svg)](https://www.nuget.org/packages/RockLib.Immutable)

This library contains the `Semimutable` class, which represents a "semimutable" value. Its value can be changed either via the setter of the <see cref="Value"/> property, or by calling the <see cref="SetValue"/> method. However, once the getter of the <see cref="Value"/> property is accessed or the <see cref="LockValue"/> method is called, the value will never change again.

It's like Schrödinger's cat - once you open the box, the cat's fate is sealed.

```c#
public class Example
{
    private readonly Semimutable<int> _number = new Semimutable<int>(LoadDefaultNumber);
    
    public int Number
    {
        get => _number.Value;
        set => _number.Value = value;
    }
    
    // This value returned by this function might be expensive, so we don't want to execute it unless necessary.
    private static int LoadDefaultNumber() => 123;
}
```

If the `Example` class is instantiated, and its `Number` property never set, then the value will come from the `LoadDefaultNumber` method.

```c#
var example = new Example();
Console.WriteLine(example.Number); // Writes "123"
```

If we create and `Example` class and set its `Number` property, then its value is as expected.

```c#
var example = new Example();
example.Number = 456;
Console.WriteLine(example.Number); // Writes "456"
```

Once the `Number` property has been read from, its value can no longer be changed.

```c#
var example = new Example();
Console.WriteLine(example.Number);
example.Number = 456; // Throws InvalidOperationException - "Setting the value of a Semimutable object is not permitted after it has been locked."
```
