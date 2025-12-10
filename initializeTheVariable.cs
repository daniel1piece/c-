string firstName;
// If we do not initialize a variable in c#
// before using it, we will get an error message
// CS0165: Use of unassigned local variable 'firstName'
// Console.WriteLine(firstName);

// By declaring and initializing the variable
// we avoid this issue.
string firstName2 = "Daniel";
Console.WriteLine(firstName2);