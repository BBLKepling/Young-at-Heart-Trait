using HarmonyLib;
using RimWorld;
using Verse;

namespace YoungAtHeart
{
    [HarmonyPatch(typeof(BabyPlayUtility), nameof(BabyPlayUtility.GetRoomPlayGainFactors))]
    public class BabyPlayUtility_GetRoomPlayGainFactors_Patch
    {
        [HarmonyPostfix]
        public static void Postfix(Pawn baby, ref float __result)
        {
            if (YoungAtHeartSettings.playBonus &&
                baby?.CurJob?.targetA.Thing is Pawn pawn && 
                pawn.RaceProps.Humanlike &&
                pawn.learning == null && 
                pawn.story.traits.HasTrait(YoungAtHeartDefOf.BBLK_BigKid)
                ) __result += (float)YoungAtHeartSettings.playRate / 100;
        }
    }
}
