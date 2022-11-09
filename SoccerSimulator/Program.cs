using Microsoft.Extensions.DependencyInjection;
using SoccerSimulator.Application;
using SoccerSimulator.Domain.Behavior;
using SoccerSimulator.Domain.Model;
using SoccerSimulator.Observer;

public class Program
{
    static void Main(string[] args)
    {
        //setup our DI
        var services = new ServiceCollection();

        services.AddScoped<ISubject, Subject>();
        services.AddScoped<IObserver, Observer>();
        services.AddScoped<IPartida, PartidaDeFutebol>();
        services.AddScoped<IJogador, Jogador>();
        services.AddScoped<ITreinador, Treinador>();
        services.AddSingleton<IGeradorDeGolos, GeradorDeGolos>();

        var serviceProvider = services.BuildServiceProvider();

        var partidaDeFutebol = serviceProvider.GetService<IPartida>();
        partidaDeFutebol.IniciarPartida();

        Console.Read();
    }
}