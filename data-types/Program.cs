// Disable unused variable warningh
#pragma warning disable 219

// Numeric Built-in Value types -> Integer
//    signed: sbyte (1 byte), short (2 bytes), int (4 bytes), long (8 bytes)
//    unsigned: byte (1 byte), ushort (2 bytes), uint (4 bytes), ulong (8 bytes)
// (https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/integral-numeric-types)
sbyte one_byte = 127;

// Numeric Built-in Value types -> Float
//     float (4 bytes), double (8 bytes), decimal (16 bytes)
// (https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types)
float four_byte_float = 10.23f;
double eight_byte_double = 10.1234d;
decimal sixteen_byte_decimal = 10.123456m;

// Boolean Built-in Value type (bool)
// (https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool)
bool true_false = true;

// Character Unicode UTF-16 Built-in Value type (char)
// (https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/char)
char two_byte_char = 'A';

// Strings
// (https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/strings/)
string greeting = "Hello World, ";
string person = new String("John");
string personalized_greeting = greeting + person + "!"; // concatenation

