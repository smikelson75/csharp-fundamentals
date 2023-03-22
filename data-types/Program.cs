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

// Array
// https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/
float[] location_array = new float[] {41.4094069f, -81.8546911f};
string abbreviation = "KCLE";
Console.WriteLine($"Location Name: {abbreviation}, Latitude: {location_array[0]}, Longitude: {location_array[1]}");

// There are no destructuring for arrays only Tuples and user-defined types using (Deconstruct)
// https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/functional/deconstruct

// Tuples
// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/value-tuples
(float, float) location_tuple = (location_array[0], location_array[1]);
Console.WriteLine($"Location Name: {abbreviation}, Latitude: {location_tuple.Item1}, Longitude: {location_tuple.Item2}");

(string name, float latitude, float longitude) location_named_tuple = (abbreviation, location_array[0], location_array[1]);
Console.WriteLine($"Location Name: {location_named_tuple.name}, Latitude: {location_named_tuple.latitude}, Longitude: {location_named_tuple.longitude}");

// Destructuring tuples
var (name, latitude1, longitude1) = location_named_tuple;
Console.WriteLine($"Location Name: {name}, Latitude: {latitude1}, Longitude: {longitude1}");

// Destructuring with discards
var (location_name, _, _) = location_named_tuple;
Console.WriteLine($"Location Name: {location_name}");