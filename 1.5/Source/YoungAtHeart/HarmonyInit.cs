using HarmonyLib;
using Verse;

namespace YoungAtHeart
{
    [StaticConstructorOnStartup]
    public class HarmonyInit
    {
        static HarmonyInit()
        {
            Harmony harmonyInstance = new Harmony("BBLKepling.YoungAtHeart");
            harmonyInstance.PatchAll();
        }
    }
}
