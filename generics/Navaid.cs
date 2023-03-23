namespace generics;

public struct Navaid<T, U> {
    public Navaid(string name, T frequency, U data) {
        Name = name;
        Frequency = frequency;
        Data = data;
    }

    public string Name {get; set;}
    public T Frequency { get; set; }
    public U Data { get; set; }
}