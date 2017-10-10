# OpenAsserts
The `Assert` classes and methods we get out of the box cover a lot of what needs to be said about systems under test, but they're by no means comprehensive. OpenAsserts aims to fill some of the gaps. In these early implementations, the focus is on asserting against `default` values, but I intend to expand the project as I come up with more requirements or as I receive suggestions.

# Examples

## `DefaultAssert` Is/Not
As is typical with `Assert` vocabulary, I use "Is" and "IsNot" to assert that a single argument is or is not equal to the default for its type.

```csharp
// Consider a Foo
public class Foo
{
  public string Name { get; private set; }
  public string Description { get; private set; }
  public DateTime LastModified {get; private set; }

  public void UpdateDescription(string description) {
    Description = description;
    LastModified = DateTime.Now;
  }
}

// Constructing one of these fills the properties with default values.
// Calling `UpdateDescription` mutates the timestamp.
// It can be tested like so:
[TestMethod]
public void TestDefaultMutations() {
  Foo foo = new Foo();
  DefaultAssert.IsDefault(foo.Name);
  DefaultAssert.IsDefault(foo.Description);
  DefaultAssert.IsDefault(foo.LastModified);

  foo.UpdateDescription("new description");
  DefaultAssert.IsDefault(foo.Name); // verify this wasn't mutated
  DefaultAssert.IsNotDefault(foo.Description); // this was *obviously* changed
  DefaultAssert.IsNotDefault(foo.LastModified); // this was a less obvious change.
}
```

## `DefaultAssert` Are/Not
`Are` and `AreNot` methods of this kind aren't typical, in my experience. I wanted a quick way to assert against a bunch of fields or properties of the same type.

```csharp
// Keep in mind the Foo from above.
[TestMethod]
public void DefaultCtor_MakesNameDescriptionDefault() {
  Foo foo = new Foo();
  DefaultAssert.AreDefault(new List<string> { foo.Name, foo.Description });
}
