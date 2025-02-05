using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BepInEx;
using BepInEx.Logging;
using HarmonyLib;

namespace OpidsFirstLethalCompanyMod
{
    [BepInPlugin(modGUID, modName, modVersion)]
    public class Base : BaseUnityPlugin
    {
        private const string modGUID = "Opid.Sample";
        private const string modName = "OpidsSampleMod";
        private const string modVersion = "1.0.0.0";

        private readonly Harmony harmony = new Harmony(modGUID);

        private static Base Instance;

        internal ManualLogSource mls;

        void Awake()
        {
            if (Instance == null) {
                Instance = this;
            }

            mls = BepInEx.Logging.Logger.CreateLogSource(modGUID);
            mls.LogInfo("Hello world");
            //harmony.PatchAll(typeof(Base);
            harmony.PatchAll();
        }
    }
}
