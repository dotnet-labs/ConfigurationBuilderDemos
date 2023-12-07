namespace ArrayConfigurationInheritance;

public class Worker(AppSettings settings) : BackgroundService
{
    protected override Task ExecuteAsync(CancellationToken stoppingToken)
    {
        Console.WriteLine($"MyArray0: \t {string.Join(", ", settings.MyArray0)}");
        Console.WriteLine($"MyArray1: \t {string.Join(", ", settings.MyArray1)}");
        Console.WriteLine($"MyArray2: \t {string.Join(", ", settings.MyArray2)}");
        Console.WriteLine($"MyArray3: \t {string.Join(", ", settings.MyArray3)}");
        return Task.CompletedTask;
    }
}