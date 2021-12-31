//CLASSES

//A Class is C#Sharp is like a blueprint that lets us create an object

using Classes;

// DONUT TYPES AND --------------------------------------
Donut doug = new Donut("Jelly Filled");
//doug.donutType = "Jelly Filled";    see line 66
Console.WriteLine(doug.donutType);

doug.donutType = "Bavarian Cream Filled";
Console.WriteLine(doug.GetDonutType());

doug.SetDonutType("Glazed Cinnamon Twist Chocolate Sprinkled Way Too Extra Donut");
string typeOfFirstDonut = doug.GetDonutType();
Console.WriteLine(typeOfFirstDonut);

// Interacting with Properties
doug.Filling = "Strawberry Jam";
Console.WriteLine(doug.Filling);
doug.Topping = "Jimmies";
doug.Price = 1.50m;
doug.IsOnSpecial = false;
Console.WriteLine($"This donut is {doug.GetDonutType()}, full of {doug.Filling}, and topped with {doug.Topping} for ${doug.Price}.");

Donut secondDonut = new Donut("Cookies 'n' Cream", "Dutch Crumbles", true, 1.23m);
secondDonut.SetDonutType("Weekly Special");
Console.WriteLine(secondDonut.GetDonutType());

Donut plain = new Donut("Plain Cake");
Console.WriteLine(plain.donutType);

Donut cruller = new Donut("French Cruller");
Console.WriteLine(cruller.donutType);

Donut appleFritter = new Donut("Apple Fritter");
Console.WriteLine(appleFritter.donutType);

Donut powdered = new Donut("Powdered");
Console.WriteLine(powdered.donutType);


namespace Classes
{
  // Classes are written in PascalCase
  class Donut
  {
/* FIELDS  -- anything a class contains is known as a member.  You have a class and the things inside of it are members of that class.  
A field is a variable of any type, and is declared directly inside a type.  In this case that type is Donut.  The syntax of a field is below

accessModifier dataType nameOfField;
public string myField;

*/
/*CONSTRUCTORS
A constructor is one of the first pieces of code that runs when a new instance is created.  This means anything you want the object to start off with as soon as it is instantiated, can be put in the constructor.

SYNTAX OF CONSTRUCTOR:

accessModifier ClassName(type valueGiven)
{
    valueToSet = valueGiven;
}
*/
public string donutType;

 public Donut(string typeOfDonut)
    {
      donutType = typeOfDonut; // This code makes the code found on line8 invalid.  It now reuires a value of type string to be given to it.
    }
    
    public Donut(string filling, string topping, bool onSpecial, decimal price)
    {
      Filling = filling;
      Topping = topping;
      IsOnSpecial = onSpecial;
      Price = price;
    }
//METHODS

// Methods are a code block that contains a series of statements.  This code block is reusable and can be invoked by calling the method in your code.
// A constructor is a specific type of method and as such have a lot of the characteristics of methods.

//Their access modifier, their name, parameters, the body, these are all parts of methods. A regular method has one more main component that we will discuss, the return type.

/* SYNTAX OF A METHOD:  ( M E T H O D  S I G N A T U R E)
--------------------
accessModifier returnType MethodName(parameterType parameterName)
{
    statements run here
}
--------------------  */

 public string GetDonutType()
    {
      return donutType;
    }

    public void SetDonutType(string type)
    {
      donutType = type;
    }

  //PROPERTIES
  // A property is a member that provides a flexible mechanism to read, write, or compute the value of a private field.
  // Properties can be used as if they are public data members, but they are actually special methods called accessors.
  //This enables data to be accessed easily and still helps promote the safety and flexibility of methods.

public string Filling { get; set;}  //get and set are auto-implemented and used to make property declaration easier to implement and read.
public string Topping { get; set;}
public bool IsOnSpecial { get; set; }
public decimal Price { get; set; }

/* 
From this line we can deduce this property has:

A  PUBLIC access modifier
The type STRING
The name FILLING
A GET and SET accessor, which function like our  and  methods we wrote.

We can now assign values to our Filling property, similar to how we assigned values to our donutType field originally.

*/

  }
}
