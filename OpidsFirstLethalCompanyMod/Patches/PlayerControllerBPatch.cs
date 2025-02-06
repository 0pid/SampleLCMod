using GameNetcodeStuff;
using HarmonyLib;

namespace OpidsFirstLethalCompanyMod.Patches
{
    [HarmonyPatch(typeof(PlayerControllerB))]
    internal class PlayerControllerBPatch
    {
        [HarmonyPatch("Update")]
        [HarmonyPostfix]
        static void infiniteSprintPatch(ref float ___sprintMeter) // Do I need to triple underscore??
        {
            ___sprintMeter = 1f;
        }
    }
}
