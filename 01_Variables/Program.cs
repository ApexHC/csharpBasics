// See https://aka.ms/new-console-template for more information

/* Declaration is when we create a new variable.
Once declared, we can assign a value.

Below, we write our first string.

In javascript we would write: 
let firstName = "Ethan";                  */
string firstName = "Billy";

// we can assign a new value of firstName by using the following:

firstName = "Ethan";
firstName = "Tommy";
firstName = "Billy";

Console.WriteLine(firstName);

Console.WriteLine("What is your favorite color?");
string color = Console.ReadLine();

Console.WriteLine("You said your favorite color is " + color);

/* 

NUMBERS:

In javascript:
let num = 42;

in CSharp
int num = 42;

uint unsigned = 4000000000 is how you would write something larger than 32 bits

short 20-1500  is a whole number size of 16 bits range -32768  to 32768

DECIMALS
Three different types that hold decimals.

(1) Float - floating point decimal
float f = 3.1415926535897932384626433f

(2) Double - 

(3) Decimal

*/

float f = 3.1415926535897932384626433f;
double d = 3.1415926535897932384626433d;
decimal m = 3.1415926535897932384626433m;

Console.WriteLine(f);
Console.WriteLine(d);
Console.WriteLine(m);

//  Boolean values (true and false)
bool isLoggedIn = false;

//  Characters
//  A string is made up of characters.  You would rarely use a single character in CSharp.  You can use backticks and \
char letter = 'i';
Console.WriteLine(letter);