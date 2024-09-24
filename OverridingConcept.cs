using System;
namespace September_24;

class ParentClass
{
    public void display()
    {
        Console.WriteLine("Executing Parent class");
    }
}

class ChildClass : ParentClass
{
    public void display()
    {
        Console.WriteLine("Executing Child Class");
    }
}

class Child_Child_Class : ChildClass
{
    public void display()
    {
        Console.WriteLine("Executing Child-Child Class");
    }
}

class MainMethod
{
    public static void Main(string[] args)
    {
        // Making Parent class object with parent class and call display()
        ParentClass pc = new ParentClass();
        pc.display(); // Executing Parent Class

        // Making Child Class object with child class and call display()
        ChildClass cc = new ChildClass();
        cc.display(); // Executing Child Class

        // Making Child-Child Class object with Child-Child Class and call display()
        Child_Child_Class ccc = new Child_Child_Class();
        ccc.display(); // 

        // Making child-Child class object with child class and call display()
        ChildClass cc1 = new Child_Child_Class();
        cc1.display();
        
        // Making child-Child class object with parent class and call display()
        ParentClass cp1 = new Child_Child_Class();
        cp1.display();

        // Making Child Class Object with Parent Class and call display() 
        ParentClass pc1 = new ChildClass(); // Object is created of Child class only, referencing Parent class.
        pc.display();

    }
}