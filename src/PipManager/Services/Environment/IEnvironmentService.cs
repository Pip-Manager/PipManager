﻿using PipManager.Models.AppConfigModels;
using PipManager.Models.Package;
using PipManager.Services.Environment.Response;

namespace PipManager.Services.Environment;

public interface IEnvironmentService
{
    public bool CheckEnvironmentExists(EnvironmentItem environmentItem);

    public (bool, string) CheckEnvironmentAvailable(EnvironmentItem environmentItem);

    public List<PackageItem>? GetLibraries();

    public Task<GetVersionsResponse> GetVersions(string packageName);

    public (bool, string) Install(string packageName);

    public (bool, string) Update(string packageName);

    public (bool, string) Uninstall(string packageName);
}