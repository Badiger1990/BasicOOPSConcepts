using System;

public class AccessModifier
{
    public static void Main(string[] args)
    {
    }
    //Available only to the container Class 
    private string privateVariable;

    // Available in entire assembly across the classes 
    internal string internalVariable;

    //Available in the container class and the derived class   
    protected string protectedVariable;

    //Available to the container class, entire assembly and to outside    
    public string publicVariable;

    //Available to the derived class and entire assembly as well
    protected internal string protectedInternalVariable;

    private string PrivateFunction()
    {
        return privateVariable;
    }

    internal string InternalFunction()
    {
        return internalVariable;
    }

    protected string ProtectedFunction()
    {
        return protectedVariable;
    }

    public string PublicFunction()
    {
        return publicVariable;
    }

    protected internal string ProtectedInternalFunction()
    {
        return protectedInternalVariable;
    }
}