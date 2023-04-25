using Calc.core.Interfaces;
using CalculadoraCore;
using Microsoft.Extensions.DependencyInjection;

namespace WinFormsApp4
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddScoped<Icalc, CalculadoraCore.Calcu>()
                          .AddScoped<Form1>();

            using (var serviceProvider = serviceCollection.BuildServiceProvider())
            {
                var form1 = serviceProvider.GetRequiredService<Form1>();

                Application.Run(form1);
            }

        }
    }



}
   
