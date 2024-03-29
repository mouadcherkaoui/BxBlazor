﻿using System.Threading.Tasks;
using BxBlazor.Services;
using Microsoft.Extensions.DependencyInjection;
using MediatR;
using BlazorState;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
namespace blazorwasm.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            builder.Services.AddMediatR(typeof(App).Assembly);
            builder.Services.AddBlazorState(o =>
            {
                o.UseReduxDevToolsBehavior = true;
            });
            builder.RootComponents.Add<App>("app");

            await builder.Build().RunAsync();
        }
    }
}
