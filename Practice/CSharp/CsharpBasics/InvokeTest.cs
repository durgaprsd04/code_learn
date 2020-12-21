using System;
using System.Reflection;

public class MagicClass
{
    private int magicBaseValue;

    public MagicClass()
    {
        magicBaseValue = 9;
    }

    public int ItsMagic(int preMagic)
    {
        return preMagic * magicBaseValue;
    }
}

public class TestMethodInfo
{
    public  void Main1()
    {
        // Get the constructor and create an instance of MagicClass

        Type magicType = Type.GetType("MagicClass");
        ConstructorInfo magicConstructor = magicType.GetConstructor(Type.EmptyTypes);
        object magicClassObject = magicConstructor.Invoke(new object[]{});

        // Get the ItsMagic method and invoke with a parameter value of 100

        var testObj = new MagicClass();
        MethodInfo magicMethod = magicType.GetMethod("ItsMagic");
        object magicValue = magicMethod.Invoke(testObj, new object[]{100});

        Console.WriteLine("MethodInfo.Invoke() Example\n");
        Console.WriteLine("MagicClass.ItsMagic() returned: {0}", magicValue);
    }
}