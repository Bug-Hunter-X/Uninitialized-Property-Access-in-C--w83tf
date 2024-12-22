public class MyClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Accessing a property before it's initialized can lead to unexpected behavior.
        int value = MyProperty * 2; // Bug: MyProperty might be uninitialized
        Console.WriteLine(value);
    }
}