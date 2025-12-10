
// Char literal
Console.WriteLine('b');
// If we enter the following, we would get an error
// Since singlue quotes are only for a character not string of characters
// Console.WriteLine('Hello World');

// Integer literal in C#endregion
Console.WriteLine(123);

// Floating point literal in C#e
/**
Float Type Precicsion
-----------------------
float       ~6 - 9 digits
double      ~15 - 17 digits
decimal     28 - 29 digits
*/
Console.WriteLine(0.25F); // F can be lowercase as well.

// The float in C# are double by default
// When entering the number without a suffix
Console.WriteLine(2.625);
// Either m or M tells the compiler that
// We wish to work with a decimal type
Console.WriteLine(12.39816m);

// Boolean types (bool in c#)
Console.WriteLine(true);
Console.WriteLine(false);