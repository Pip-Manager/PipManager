﻿namespace PipManager.Windows.Services.Toast;

public interface IToastService
{
    public void Info(string message);

    public void Warning(string message);

    public void Error(string message);

    public void Success(string message);
}