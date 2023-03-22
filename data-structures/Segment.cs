// Class reference type
// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/class
namespace data_structures;

public class Segment {
    // Constructor
    // https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/constructors
    public Segment(WayPoint start, WayPoint end) {
        Start = start;
        End = end;
    }

    // Properties
    // https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/properties
    public WayPoint Start { get; set; }
    public WayPoint End { get; set; }
    
    // Methods
    // https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/methods
    public float distance() {
        const double EARTH_RADIUS_IN_KILOMETERS = 6371.0d;
        var start_radians = this.radians(Start.Latitude);
        var end_radians = this.radians(End.Latitude);
        var delta_latitude = this.radians(Start.Latitude - End.Latitude);
        var delta_longitude = this.radians(Start.Longitude - End.Longitude);
        var inner_central_angle = Math.Pow(Math.Sin(delta_latitude / 2), 2)
            + Math.Cos(start_radians)
            * Math.Cos(end_radians)
            * Math.Pow(Math.Sin(delta_longitude / 2), 2);
        var central_angle = 2 * Math.Asin(Math.Sqrt(inner_central_angle));
        var distance = EARTH_RADIUS_IN_KILOMETERS * central_angle;
        return (float)distance;
    }

    // Method Access - protected
    // https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/methods#method-access
    protected double radians(double degrees) {
        return (Math.PI / 180) * degrees;
    }
}