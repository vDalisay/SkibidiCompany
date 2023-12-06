using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using SkibidiCompany.Patches;
using bieLogger = BepInEx.Logging.Logger;

namespace SkibidiCompany;
[BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
public class Plugin : BaseUnityPlugin
{
    private readonly Harmony harmony = new(PluginInfo.PLUGIN_GUID);

    private static Plugin Instance;

    internal ManualLogSource _logger;
    void Awake()
    {
        if (Instance == null) { Instance = this; }

        _logger = bieLogger.CreateLogSource(PluginInfo.PLUGIN_GUID);
        _logger.LogInfo("Skibidi skibidi");

        harmony.PatchAll(typeof(Plugin));
        harmony.PatchAll(typeof(PlayerControllerBPatch));
    }
}
