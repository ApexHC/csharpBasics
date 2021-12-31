/* LOOPS

WHILE LOOPS
Anatomy
while(boolean)
{
    body of code to run
    
}

*/

int counter = 0;
while(counter <= 50)
{
    Console.WriteLine($"Your number is (counter)");
    counter += 10;
}


//For
//Anatomy of a For
//for(initial setup; condition to loop; after loop do this)
//{
//  body of code to loop
//}

List<string> listOfAnimals = new List<string> { "Cat", "Dog", "Fish", "Goat" };
listOfAnimals.Add("Platypus");
int lengthOfList = listOfAnimals.Count;

for(int i = 0; i < lengthOfList; i++)
{
    Console.WriteLine(listOfAnimals[i]);
}

//FOR EACH

//Anatomy of a FOREACH
/*
foreach(type variableName in collectionName)
{
    body of code to run
}

These are specifically designed to work with collections.  Below we use the list of animals above as our collection.
*/

foreach(string animal in listOfAnimals)
{
    Console.WriteLine(animal);
}

//You could call the string anything you want... as long as you reference it on the console.writeline(name)

//For example you could call the string potato - you'd have to Console.WriteLine(potato)

// FROM THE MODULE

/*Declaring a variable to use in our loops boolean expression
int number = 0

//While the value in number is less than or equal to 100, run the following
while (number <= 100)

//Write the value of number to the console and then increment by 5
{
    Console.WriteLine(number);
number = number + 5;
}
*/