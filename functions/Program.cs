// Methods => Pass by value, return value
var greater = Utilities.return_greater(91, 22);
Console.WriteLine($"{greater}");

// Method => Pass by value, return void
Utilities.print_original("original value");

// Lambda Expression
Func<int, int> lambda_expression = (int value) => value * value; 
Console.WriteLine("lambda_expression: {0}", lambda_expression(2));

// Local Function - used.
ShowValue(greater);

// Local Function
void ShowValue(int value) {
    Console.WriteLine("Greater value: {0}", value);
}
