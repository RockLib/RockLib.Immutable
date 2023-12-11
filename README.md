# **RockLib.Immutable Deprecation**

RockLib has been a cornerstone of our open source efforts here at Rocket Mortgage, and it's played a significant role in our journey to drive innovation and collaboration within our organization and the open source community. It's been amazing to witness the collective creativity and hard work that you all have poured into this project.

However, as technology relentlessly evolves, so must we. The decision to deprecate this library is rooted in our commitment to staying at the cutting edge of technological advancements. While this chapter is ending, it opens the door to exciting new opportunities on the horizon.

We want to express our heartfelt thanks to all the contributors and users who have been a part of this incredible journey. Your contributions, feedback, and enthusiasm have been invaluable, and we are genuinely grateful for your dedication. 🚀

# RockLib.Immutable

This library contains the `Semimutable` class, which represents a "semimutable" value. It's value can be set via the setter of the <see cref="Value"/> property, or by calling the <see cref="SetValue"/> method. Once the getter of the <see cref="Value"/> property is accessed or the <see cref="LockValue"/> method is called, the value will never change again.

It's like Schrödinger's cat - once you open the box, the cat's fate is sealed.

## Examples

```csharp
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

```csharp
var example = new Example();
Console.WriteLine(example.Number); // Writes "123"
```

If we create and `Example` class and set its `Number` property, then its value is as expected.

```csharp
var example = new Example();
example.Number = 456;
Console.WriteLine(example.Number); // Writes "456"
```

Once the `Number` property has been read from, its value can no longer be changed.

```csharp
var example = new Example();
Console.WriteLine(example.Number);
example.Number = 456; // Throws InvalidOperationException - "Setting the value of a Semimutable object is not permitted after it has been locked."
```
