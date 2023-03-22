// Structure built-in types (value)
// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/struct
namespace data_structures;

public struct WayPoint {
    // Constructor
    // https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/constructors
    public WayPoint(string name, float latitude, float longitude) {
        Name = name;
        Latitude = latitude;
        Longitude = longitude;
    }

    // Properties
    // https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/properties
    public string Name { get; }
    public float Latitude { get; }
    public float Longitude { get; }
}