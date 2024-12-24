public class MyClass
{
    public int MyProperty { get; set; }

    // Constructor to initialize MyProperty
    public MyClass()
    {
        MyProperty = 0; // Or any other default value
    }

    public void MyMethod()
    {
        Console.WriteLine(MyProperty.ToString());
    }
}