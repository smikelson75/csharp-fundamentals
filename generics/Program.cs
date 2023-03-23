using generics;

var vor = new Navaid<double, string>("DQN", 114.5,"DQN is a VOR");

var ndb_data = new Navaid<int, (int, int)>("NDB", 256, (256, 262) );

Console.WriteLine($"Location: {vor.Name}; Frequency: {vor.Frequency}, Data: {vor.Data}");
Console.WriteLine($"Location: {ndb_data.Name}; Frequency: {ndb_data.Frequency}, Data: {ndb_data.Data}");