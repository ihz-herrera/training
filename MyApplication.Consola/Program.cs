using Microsoft.Extensions.DependencyInjection;
using Techsoft.MyApplication.Aplicacion.Servicios;

namespace MyApplication.Consola;

internal class Program
{
    static void Main(string[] args)
    {

        // Create a new service collection
        var serviceCollection = new ServiceCollection();


        serviceCollection.AddHttpClient("namedClient", client =>
        {
            client.BaseAddress = new Uri("https://api.example.com/");
            client.DefaultRequestHeaders.Add("Accept", "application/json");
        });


        // Add HttpClientFactory to the DI container
        serviceCollection.AddHttpClient();

        // Register your services, for instance:
        serviceCollection.AddTransient<MyService>();

        // Build the service provider
        var serviceProvider = serviceCollection.BuildServiceProvider();

        // Get and use your service
        var myService = serviceProvider.GetRequiredService<MyService>();
        myService.Execute();






        Console.WriteLine("Hello, World!");

        //Guardar Cliente

        var clienteService = new ClienteService();


        try
        {
            clienteService.Guardar("Wendy", "Castro", "8095555555", "Santo Domingo", 30);
        }
        catch (System.Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.ReadLine();
    }
}

public class MyService
{
    private readonly HttpClient _client;

    public MyService(HttpClient client)
    {
        _client = client;
    }

    public void Execute()
    {
        var result = _client.GetStringAsync("https://api.example.com/data").Result;
        Console.WriteLine(result);
    }
}
