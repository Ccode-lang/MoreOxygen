using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameNetcodeStuff;
using HarmonyLib;

namespace MoreOxygen.Patches
{
    [HarmonyPatch(typeof(PlayerControllerB), "SetFaceUnderwaterFilters")]
    internal class PlayerControllerBPatches
    {
        public static void Prefix()
        {
            StartOfRound.Instance.drowningTimer = 1f;
        }
    }
}
