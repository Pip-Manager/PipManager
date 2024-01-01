﻿using PipManager.Models.Pages;
using PipManager.Services.Configuration;
using Serilog;
using System.Collections.ObjectModel;
using Wpf.Ui.Controls;

namespace PipManager.ViewModels.Pages.About;

public partial class AboutViewModel(IConfigurationService configurationService) : ObservableObject, INavigationAware
{
    private bool _isInitialized;

    [ObservableProperty] private string _appVersion = "Development";
    [ObservableProperty] private bool _debugMode;
    [ObservableProperty] private bool _experimentMode;

    public void OnNavigatedTo()
    {
        if (!_isInitialized)
            InitializeViewModel();
    }

    public void OnNavigatedFrom()
    {
    }

    private void InitializeViewModel()
    {
        DebugMode = configurationService.DebugMode;
        ExperimentMode = configurationService.ExperimentMode;
        AppVersion = AppInfo.AppVersion;
        _isInitialized = true;
        Log.Information("[About] Initialized");
    }

    [ObservableProperty]
    private ObservableCollection<AboutNugetLibraryListItem> _nugetLibraryList =
    [
        new AboutNugetLibraryListItem("Antelcat.I18N.WPF", "1.0.1", "MIT", "Copyright (c) 2023 Feast", "https://github.com/Antelcat/Antelcat.I18N"),
        new AboutNugetLibraryListItem("CommunityToolkit.Mvvm", "8.2.2", "MIT", "Copyright © .NET Foundation and Contributors", "https://github.com/CommunityToolkit/dotnet"),
        new AboutNugetLibraryListItem("Microsoft.Extensions.Hosting", "8.0.0", "MIT", "Copyright © .NET Foundation and Contributors", "https://github.com/dotnet/runtime"),
        new AboutNugetLibraryListItem("Microsoft.Xaml.Behaviors.Wpf", "1.1.75", "MIT", "Copyright (c) 2015 Microsoft", "https://github.com/microsoft/XamlBehaviorsWpf"),
        new AboutNugetLibraryListItem("Newtonsoft.Json", "13.0.3", "MIT", "Copyright (c) 2007 James Newton-King", "https://github.com/JamesNK/Newtonsoft.Json"),
        new AboutNugetLibraryListItem("Serilog", "3.1.1", "Apache-2.0", "Copyright © 2013-2020 Serilog Contributors", "https://github.com/serilog/serilog"),
        new AboutNugetLibraryListItem("Serilog.Sinks.Console", "5.0.1", "Apache-2.0", "Copyright © 2016 Serilog Contributors", "https://github.com/serilog/serilog-sinks-console"),
        new AboutNugetLibraryListItem("Serilog.Sinks.File", "5.0.0", "Apache-2.0", "Copyright © 2016 Serilog Contributors", "https://github.com/serilog/serilog-sinks-file"),
        new AboutNugetLibraryListItem("ValueConverters", "3.0.26", "MIT", "Copyright (c) 2019 Thomas Galliker", "https://github.com/thomasgalliker/ValueConverters.NET"),
        new AboutNugetLibraryListItem("WPF-UI", "3.0.0-preview.13", "MIT", "Copyright (c) 2021-2023 Leszek Pomianowski and WPF UI Contributors.", "https://github.com/lepoco/wpfui"),
        new AboutNugetLibraryListItem("WPF-UI.Tray", "3.0.0-preview.11", "MIT", "Copyright (c) 2021-2023 Leszek Pomianowski and WPF UI Contributors.", "https://github.com/lepoco/wpfui"),
    ];
}