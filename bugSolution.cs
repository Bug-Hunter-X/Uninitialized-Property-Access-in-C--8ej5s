public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Initialize the property before accessing it.
        MyProperty = 0; // or another appropriate default value
        Console.WriteLine(MyProperty);
    }

    public void MyMethod2() //Alternative solution with constructor
    {
        Console.WriteLine(MyProperty);
    }
    public ExampleClass(int propertyValue)
    {
        MyProperty = propertyValue;
    }
} 