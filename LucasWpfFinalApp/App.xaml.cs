﻿using LucasWpfFinalApp.Helpers;
using LucasWpfFinalApp.MVVM.ViewModels;
using LucasWpfFinalApp.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace LucasWpfFinalApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    /// 
    /* 
         Singleton = en endaste instans av någonting i hela programmet. Tills vi startar om Servern/Webservern
         Scoped = en ny instans för varje gång vi går in på en kontroller men våra partial views får samma information
         Transient = en ny instans för varje sak vi gör, avsett vad
    */
    public partial class App : Application
    {

        //public static IHost? app { get; private set; }

    //public App()
    //{
    //    app = Host.CreateDefaultBuilder().ConfigureServices((context, services) =>
    //    {
    //        services.AddSingleton<MainWindow>();
    //        services.AddSingleton<NavigationStore>();
    //        services.AddScoped<IDeviceService, DeviceService>();
    //        services.AddScoped<IWeatherService, WeatherService>();
    //    }).Build();
    //}

    //protected override async void OnStartup(StartupEventArgs e)
    //{
    //    var navigationStore = app!.Services.GetRequiredService<NavigationStore>();
    //    var deviceService = app!.Services.GetRequiredService<IDeviceService>();
    //    var weatherService = app!.Services.GetRequiredService<IWeatherService>();
    //    navigationStore.CurrentViewModel = new MainViewModel(navigationStore, deviceService, weatherService);

    //    await app!.StartAsync();
    //    var MainWindow = app.Services.GetRequiredService<MainWindow>();
    //    MainWindow.DataContext = new MainViewModel();
    //    MainWindow.Show();

    //    base.OnStartup(e);
    //}

    //protected override async void OnExit(ExitEventArgs e)
    //{
    //    await app!.StopAsync();
    //    base.OnExit(e);
    //}
    }
}
