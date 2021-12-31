//ternaries
//Anatamy of a ternary
// Boolean ? What to return if true : what to return if false;
Console.Write("Enter your age: ");
string responseAgeAsString = Console.ReadLine();

int responseAge = int.Parse(responseAgeAsString);

string output = responseAge >= 100 ? "Wow you are old" : "What are you talking about you arent that old";
Console.WriteLine(output);

