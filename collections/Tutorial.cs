using System.Collections.Generic;

namespace fundamentals;
public class Tutorial {
    public static void Lists() {
        // Declare new List<T>
        List<string> flights = new List<string>();

        // Add items to List<T>
        flights.Add("DA113\tto Boston departs at 6:20");
        flights.Add("DA98\tto London departs at 09:43");
        flights.Add("DA428\tto Salt Lake City departs at 12:05");
        flights.Add("DA41\tto Berlin departs at 15:30");

        foreach (string flight in flights) {
            Console.WriteLine(flight);
        }

        // Select the third value from the List<T>
        // Zero-based indexing
        var third = flights[2];
        Console.WriteLine(third);

        // Remove value from List<T>
        var fourth = flights.Remove("DA428\tto Salt Lake City departs at 12:05");

        // Insert value into the list at a specified location
        flights.Insert(2, "DA2815\tto Nashville departs at 17:11");

        foreach (string flight in flights) {
            Console.WriteLine(flight);
        }
    }

    public static void Queues() {
        Queue<string> flights = new Queue<string>();

        flights.Enqueue("DA113\tto Boston departs at 6:20");
        flights.Enqueue("DA98\tto London departs at 09:43");
        flights.Enqueue("DA428\tto Salt Lake City departs at 12:05");

        foreach (string flight in flights) {
            Console.WriteLine(flight);
        };

        var completedFlight = flights.Dequeue();
        Console.WriteLine($"Flight Completed: {completedFlight}");

        foreach (string flight in flights) {
            Console.WriteLine(flight);
        }
    }

    public static void Dictionaries() {
        Dictionary<string, (string, string)> flights = new Dictionary<string, (string, string)>();
        flights.Add("DA918", ("11:12", "Orlando"));
        flights.Add("DA428", ("12:05", "Salt Lake City"));
        flights.Add("DA98", ("09:43", "London"));
        flights.Add("DA133", ("06:20", "Boston"));
        flights.Add("DA41", ("15:30", "Berlin"));
        flights.Add("DA2815", ("17:11", "Nashville"));

        var flight_number = "DA41";

        var (time, destination) = flights[flight_number];
        Console.WriteLine($"Flight Number: {flight_number}, Departure Time: {time}, Destination: {destination}");

        if (flights.ContainsKey(flight_number)) {
            Console.WriteLine($"Flight {flight_number} already exists.");
        }

        flight_number = "DA531";

        var successful = flights.TryAdd(flight_number, ("12:00", "Puerto Rico"));
        if (!successful) {
            Console.WriteLine($"Flight {flight_number} already exists.");
        } 

        foreach (KeyValuePair<string, (string, string)> flight in flights) {
            Console.WriteLine($"Flight {flight.Key} leaving at {flight.Value.Item1} with a destination of {flight.Value.Item2}");
        }
    }
}