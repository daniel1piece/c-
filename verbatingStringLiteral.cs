// Verbating literals helps us avoid writing
// escacped sequences such as // or /n or /t and so on.
Console.WriteLine(@"c:\source\repos
                  (Here is where you code goes.)");
Console.WriteLine(@"c:\invoices");

// We may also use unicode characters in verbatig literal strings
Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");