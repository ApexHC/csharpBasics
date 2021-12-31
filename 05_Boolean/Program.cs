// BOOLEAN LOGICAL OPERATORS
// NEGATION OPERATOR (BANG!)
bool isTrue = !false;
bool isFalse = !true;

// AND OPERATOR
bool trueAndExample = true && true;
bool falseAndExample = true && false;

// OR OPERATOR
bool trueOrExample = true || false;
bool falseOrExample = false || false;

// X OR OPERATOR
bool trueExclusiveOr = true ^ false;
bool falseExclusiveOr = true ^ true;

bool xor = (true && false) || (false && true);

Console.WriteLine($"NOT False = {isTrue}");
Console.WriteLine($"False AND True = {falseAndExample}");
Console.WriteLine($"True OR True = {trueOrExample}");
Console.WriteLine($"True XOR True = {falseExclusiveOr}");