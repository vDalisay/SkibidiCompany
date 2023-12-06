using GameNetcodeStuff;
using HarmonyLib;
//Make sure this class resides in the Patches folder
namespace SkibidiCompany.Patches;
[HarmonyPatch(typeof(PlayerControllerB))]
internal class PlayerControllerBPatch
{
    //If method is public you can access it using: [HarmonyPatch(nameof({className}.{methodName}))]
    //Tells the order of the function to run in a certain order
    [HarmonyPatch("Update")]
    [HarmonyPostfix]
    static void InfiniteSprintPatch(ref float ___sprintMeter)
    {
        ___sprintMeter = 1f;
    }
}
