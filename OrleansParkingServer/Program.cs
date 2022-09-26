using Microsoft.Extensions.Hosting;
using Orleans;
using Orleans.Hosting;

using var host = Host.CreateDefaultBuilder()
    .UseOrleans(siloBuilder =>
    {
        siloBuilder.UseLocalhostClustering();
    })
    .Build();

// Start the host
await host.StartAsync();


Console.WriteLine("Setup completed.");
Console.WriteLine("Now you can launch the client.");

// Exit when any key is pressed
Console.WriteLine("Press any key to exit.");
Console.ReadKey();
await host.StopAsync();

return 0;