/* CONDITIONALS - IF STATEMENTS

In javascript we used "if else", switches, "if" and ternaries.

Anatomy of an if
if(boolean logic)
{
    body of code to run
}


Syntax:
if (true/false value)
{
    body of code, execute this code if above value is true
}



if(true)
{
    Console.WriteLine("This wall always run");
}

if(false)
{
    Console.WriteLine("This code will never run");
}

*/



bool isRaining = true;
bool isGoingOutside = true;

if (isRaining)
{
    Console.WriteLine("Its raining out!");
}

// ------------------------------------------
int age = 42;
if(age >= 36)
{
    Console.WriteLine("You can run for president");
}
else if(age >= 18)
{
    Console.WriteLine("You can Vote");
}
else
{
    Console.WriteLine("You are still a child");
}

// SWITCHES
// used to evaluate multiple results
// Anatomy of a switch case:
// switch(whateverWeAreEvaluating)
// {
//     case whatWeAreLookingFor:
//          code that will run
//   break;
//   default;
//  }

Console.WriteLine("Enter a Name");
string name = Console.ReadLine();
switch(name)
{  //You can stack case names that should have the same response.  For example:
    case "Bob":
    case "Tommy":
    case "Susan":
        Console.WriteLine("Hello There.  This is a secret message for Bob, Tommy, or Susan");
        break;
    case "Dave":
        Console.WriteLine("I'm sorry I cannot do that");
        break;
    default:
    Console.WriteLine($"Hello, {name} Your name is not cool like Bob, Tommy, or Susan");
        break;
}


//IF ELSE EXERCISE FROM THE MODULE
/* THE FOLLOWING CODE HAS ERRORS... GO BACK TO THE MODULE AND FIND IT! */

Console.WriteLine("How are you feeling today on a scale of 1-5?");
string feelingRating = Console.ReadLine();

if (feelingRating == "5")
{
    Console.WriteLine("Thats great to hear!");
}
else if (feelingRating == "4")
{
    Console.WriteLine("Good Stuff");
}
else if (feelingRating == "3")
{
    Console.WriteLine("Hope Things Improve!");
}
else if (feelingRating == "2")
{
    Console.WriteLine("Oh... Sorry to hear that");
}
else if (feelingRating == "1")
{
    Console.WriteLine("Dang. We hope your day gets better!");
}
else
{
    Console.WriteLine("Sorry, we don't understand.  Please try again later");
}

// COLLECTION

// ARRAY
string[] arrayOfNames = { "Bob", "Janet", firstName };
Console.WriteLine(arrayOfNames[0]);

// LISTS

List<int> listOfNumbers = new List<int>();

listOfNumbers.Add(2);
listOfNumbers.Add(14);
listOfNumbers.Add(33);

Console.WriteLine(listOfNumbers);

// the above simply prints out WHAT the list is... a generic list.  It doesn't show the numbers.

// queue (FIFO)  stacks (LIFO)  dictionary