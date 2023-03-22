// Disable unused variable warningh
#pragma warning disable 219

// Remainder operator
// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/arithmetic-operators#remainder-operator-
// output: 4
var modulus = 18 % 7;
Console.WriteLine(modulus);

// Raise an integer to an exponent of integer
// https://learn.microsoft.com/en-us/dotnet/api/system.math.pow?view=net-6.0
// output: 64
var squared = Math.Pow(8, 2);
Console.WriteLine(squared);

// Arthimatic Operators
// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/arithmetic-operators
// Order of operations (Parenthesis, Exponents, Multiplication/Division, Addition/Subtraction)
// Execute order of operation, when not significant, then left to right, 
// output: 9
var order_ops = 8+4*2-(12/3+7)+4;
Console.WriteLine(order_ops);

var value = 1; 
Console.WriteLine($"{++value}"); // Displays 2

value = 1;
Console.WriteLine($"{value++}"); // Displays 1

// Comparison operators
// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/comparison-operators
var isGreaterThan = 1 > 6; // false
var isLessThan = 3 < 7;    // true
var isEqualTo = 4 == 6;    // false
var isGreaterThanOrEqualTo = 9 >= 5; // true
var isLessThanOrEqualTo = 4 <= 8; // true

// Logical Operators
// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/boolean-logical-operators
var logicalAnd = true && false; // false
var logicalOr = true || false;  // true
var logicalNot = true && !false; // true

// Review documentation for Binary Operations (&, |, ^)
// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/boolean-logical-operators
// Bitwise Operators (restricted to integers)
// And (&)
// 0101 0110
// 0001 1011 &
// -----------
// 0001 0010
// value: 18
int bitwise_and = 86 & 27;
Console.WriteLine(bitwise_and);

// Or (|)
// 0101 0110
// 0001 1011 |
// -----------
// 0101 1111
// value: 95
int bitwise_or = 86 | 27;
Console.WriteLine(bitwise_or);

// XOr (^)
// 0101 0110
// 0001 1011 ^
// -----------
// 0100 1101
// value: 77
int bitwise_xor = 86 ^ 27;
Console.WriteLine(bitwise_xor);

// Review documentation for Bitwise and shift operators
// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/bitwise-and-shift-operators

// Left shift (<<)
// 0101 0110 << by 1 bit is 1010 1100 
// value: 172
int bitwise_left_shift = 86 << 1;
Console.WriteLine(bitwise_left_shift);

// Right shift (>>)
// 0101 0110 >> by 1 bit is 0010 1011
// value: 43
int bitwise_right_shift = 86 >> 1;
Console.WriteLine(bitwise_right_shift);