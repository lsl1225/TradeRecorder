using Dalamud.IoC;
using Dalamud.Plugin;
using Dalamud.Plugin.Services;

namespace TradeRecorder
{
  public class DalamudInterface
  {
    public static void Initialize(DalamudPluginInterface pluginInterface) => pluginInterface.Create<DalamudInterface>();

    [PluginService][RequiredVersion("1.0")] public static IObjectTable ObjectTable { get; private set; } = null!;
    [PluginService][RequiredVersion("1.0")] public static DalamudPluginInterface PluginInterface { get; private set; } = null!;
    [PluginService][RequiredVersion("1.0")] public static ICommandManager Commands { get; private set; } = null!;
    [PluginService][RequiredVersion("1.0")] public static IDataManager DataManager { get; private set; } = null!;
    [PluginService][RequiredVersion("1.0")] public static IChatGui ChatGui { get; private set; } = null!;
    [PluginService][RequiredVersion("1.0")] public static IClientState ClientState { get; private set; } = null!;
    [PluginService][RequiredVersion("1.0")] public static ICommandManager CommandManager { get; private set; } = null!;
    [PluginService][RequiredVersion("1.0")] public static IGameGui GameGui { get; private set; } = null!;
    [PluginService][RequiredVersion("1.0")] public static IGameNetwork GameNetwork { get; private set; } = null!;
    [PluginService][RequiredVersion("1.0")] public static ITextureProvider TextureProvider { get; private set; } = null!;
    [PluginService][RequiredVersion("1.0")] public static IPluginLog PluginLog { get; private set; } = null!;

  }
}
