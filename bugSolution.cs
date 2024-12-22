public class MyClass
{
    public int MyProperty { get; set; }

    // Constructor to initialize the property
    public MyClass(int initialValue)
    {
        MyProperty = initialValue;
    }

    public void MyMethod()
    {
        // Property is now initialized in the constructor
        int value = MyProperty * 2;
        Console.WriteLine(value);
    }
}