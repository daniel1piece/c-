// The var keyword tells the C# compiler that the data type is implied 
// by the assigned value. For example:
var message = "Hello World";
Console.WriteLine(message);

// Now if we down the road assign a different data type
// We get an error
// message =  10.704;
// CS0029: Cannot implicitly convert type 'decimal' to 'string'
/*
In other words, the type is locked in at the time of  declaration and therefore 
will never be able to hold values of a different data type.
*/

/*

It's important to understand that the var keyword is dependent on 
the value you use to initialize the variable. If you try to use 
the var keyword without initializing the variable, 
you'll receive an error when you attempt to compile your code.
*/

// Now if we do this

// var message;

// We get CS0818: Implicitly-typed variables must be initialized