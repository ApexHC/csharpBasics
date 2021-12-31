//CHALLENGES

//BRONZE CHALLENGE
/*For this challenge go ahead and create a list of variables using the following data types:  int, string, bool, float, double, decimal, and ulong.  For each of these types, do the following:

Make at least two examples for each type.
Make one a declaration only.
Declar and initialize the other.

Once you have variables, go ahead and print some of these to the console.

*/

//INT
int number;
int firstNumber = 200;
Console.WriteLine (firstNumber);

//STRINGS

string text;
string longword = "reallylongword";
Console.WriteLine(longword);

//BOOLEAN
bool condition;
bool fordMakesMustang = true;
Console.WriteLine(fordMakesMustang);

//FLOAT
float cupsOfCoffee;
float gallonsOfGas = 12.7f;
Console.WriteLine(gallonsOfGas);

//DOUBLE
double myDouble;
double myCoffee = 10.5;
Console.WriteLine($"The number of cups my coffee maker can make is: " + (myCoffee));

//DECIMAL
decimal myDecimal;
decimal feetInMeter = 3.28m;
Console.WriteLine($"The number of feet in a meter is: " + (feetInMeter));

//UNSIGNED LONG
ulong bigOlNumber;
ulong brainCellsLost = 3113151354656185653;
Console.WriteLine($"The number of brain cells I lost in Basic Training is:" + (brainCellsLost));

//--------------SILVER STAGE

//Concatenate two string variables.  Then try to concatenate a number with a string as well.


int year = 1964;
string mfr = "Ford";
string model = "Mustang";
string mfgInfo = mfr + " " + model;
string yrMfgInfo = year + " " + mfgInfo;
Console.WriteLine(mfgInfo);
Console.WriteLine(yrMfgInfo);

//-------------GOLD STAGE

//  UNFORTUNATELY I AM NOT DOING THE GOLD STAGE RIGHT NOW... BUT WILL BE REVISITING IT LATER SIMPLY FOR THE JOY OF LEARNING...