using concurrency;

await Chef();

async Task Chef() {
    // Synchronous task -> Pour the coffee;
    Coffee cup = Breakfast.PourCoffee();
    Console.WriteLine("coffee is ready");

    // Asynchronous tasks -> Fry the Eggs and Bacon
    // Delays run in the background
    Task<Egg> eggsTask = Breakfast.FryEggs(2);
    Task<Bacon> baconTask = Breakfast.FryBacon(3);
    Task<Toast> toastTask = Breakfast.MakeToastWithButterAndJam(2);
    await Task.WhenAll(eggsTask, baconTask, toastTask); // or Task.WaitAll(...)
    Console.WriteLine("bacon is ready");
    Console.WriteLine("eggs are ready");
    Console.WriteLine("toast is ready");

    // Pour Orange juice
    Juice oj = Breakfast.PourOJ();
    Console.WriteLine("oj is ready");
    Console.WriteLine("Breakfast is ready!");
}