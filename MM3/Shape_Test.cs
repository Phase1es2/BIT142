//Hao Yang
//11/09/2020
//Major_Coding_Assignment_3.cs
//Purpose:Multiple shapes each shape does something different depending on what it is.
using System;


public class Shape
{
    public Shape()
        //This invokes automatically when call the class
    {
        Console.WriteLine("I am a Shape! Shapes are cool!");
        //print
        for (int i = 0; i < 5; i++)
           //loop print 5 times 
        {
            Console.WriteLine("Shape");
        }
    }
}

public class Rectangle : Shape
//Inherited Derived class
{
    public Rectangle()
    {
        Console.WriteLine("\n I am a retangle... who has 4 sides");
    }
}

public class Triangle : Shape
//Inherited Derived class
{
    public Triangle()
    {
        Console.WriteLine("I am a triangle");
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("I have 3 sides");
        }
    }
}
public class Circle : Shape
//Inherited Derived class
{
    public Circle()
    {
        Console.WriteLine("\n I am round");
        for (int i = 0; i < 7; i++)
        {
            Console.WriteLine("I like to roll!");
        }
    }
}

public class Shape_Test
    //Main method
{
    public static void Main(string[] args)
    {
        //Call all the derived classes
        new Rectangle();
        new Triangle();
        new Circle();
    }
}