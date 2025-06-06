using Application;
using CLI.Commands;
using CLI.Handlers;
using Microsoft.Extensions.DependencyInjection;

namespace CLI;

class Program
{
    static async Task Main(string[] args)
    {
        // Настройка и инициализация приложения
        var serviceProvider = ConfigureServices();

        // Обработка аргументов командной строки
        if (args.Length < 1)
        {
            Console.WriteLine("Usage: dotnet run create-applicant [firstName] [lastName] [email] [phoneNumber]");
            return;
        }

        if (args[0] == "create-applicant")
        {
            var command = new CreateApplicantCommand
            {
                FirstName = args[1],
                LastName = args[2],
                Email = args[3],
                PhoneNumber = args[4]
            };

            var commandHandler = serviceProvider.GetRequiredService<ICommandHandler<CreateApplicantCommand>>();
            await commandHandler.HandleAsync(command);

            Console.WriteLine("Applicant created successfully.");
        }
        else
        {
            Console.WriteLine($"Unknown command: {args[0]}");
        }
    }

    private static IServiceProvider ConfigureServices()
    {
        var services = new ServiceCollection();

        services.AddSkillMatchServices();

        services.AddScoped<ICommandHandler<CreateApplicantCommand>, CreateApplicantCommandHandler>();

        return services.BuildServiceProvider();
    }

}

