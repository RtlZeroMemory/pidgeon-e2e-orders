using Microsoft.Extensions.Hosting;
using SDG.Pidgeon.Abstractions;
using SDG.Pidgeon.Engine.Wolverine;

string serviceName = ReadSetting("PIDGEON_SERVICE", "orders-service");
string environmentName = ReadSetting("PIDGEON_ENVIRONMENT", "production");
string profileName = ReadSetting("PIDGEON_PROFILE", "orders-service");
string topologyPath = ReadSetting("PIDGEON_TOPOLOGY_PATH", "topology.yaml");

Host.CreateDefaultBuilder(args)
    .UsePidgeonWolverine(
        ServiceName.Parse(serviceName),
        environmentName,
        profileName,
        topologyPath)
    .Build()
    .Run();

static string ReadSetting(string key, string fallback)
{
    string? value = Environment.GetEnvironmentVariable(key);
    return string.IsNullOrWhiteSpace(value) ? fallback : value;
}
