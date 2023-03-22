// An explicit variable declaration
int defined_variable = 0;

// An implicit variable declaration
var inferred_variable = 0;

// Variables are defined mutible, meaning they can be modified by the program
defined_variable = 11;
inferred_variable = defined_variable;

// Multiple variable assignment
int i1 = 1, i2 = 2, i3 = 3;

Console.WriteLine("i1: {0}, i2: {1}, i3: {2}", i1, i2, i3);

// New C# compiler will notify of unused variable
// to turn this off, you can use #pragma warning disable 219
int unused_variable = 100;

// Implicit conversion exist, see the possible conversions of integer types
// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/language-specification/conversions#1023-implicit-numeric-conversions
float float_variable = 100.1f;
double double_variable = float_variable;

const float PI = 3.1415f;
Console.WriteLine($"PI: {PI}");
