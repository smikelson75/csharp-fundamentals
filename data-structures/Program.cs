using data_structures;

var kcle = new WayPoint(
    "KCLE",
    41.4075f,
    -81.851111f
);

var kslc = new WayPoint(
    "KSLC",
    40.7861f,
    -111.9822f
);

var kcle_kslc = new Segment(kcle, kslc);
var distance = kcle_kslc.distance();

// Custom numeric formatting
// https://learn.microsoft.com/en-us/dotnet/standard/base-types/custom-numeric-format-strings
Console.WriteLine(String.Format("{0:0.0}", distance));