namespace PackMan.Telemetry;

public interface IUpdateChecker
{
    bool CheckForUpdates(string v1, string v2, string currentVersion);
}
