using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreOxygen
{
    [BepInPlugin(MyGuid, PluginName, VersionString)]
    public class Plugin : BaseUnityPlugin
    {
        private const string MyGuid = "Ccode.MoreOxygen";
        private const string PluginName = "Ccode.MoreOxygen";
        private const string VersionString = "0.0.1";

        private static readonly Harmony Harmony = new Harmony(MyGuid);

        public static ManualLogSource Log;

        public void Awake()
        {
            Harmony.PatchAll();
            Logger.LogInfo(PluginName + " " + VersionString + " " + "loaded.");
            Log = Logger;
        }
    }
}
