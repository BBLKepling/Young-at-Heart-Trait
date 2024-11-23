using HarmonyLib;
using RimWorld;
using Verse;

namespace YoungAtHeart
{
    [HarmonyPatch(typeof(LearningUtility), nameof(LearningUtility.LearningRateFactor))]
    public class LearningUtility_LearningRateFactor_Patch
    {
        [HarmonyPostfix]
        public static void Postfix(Pawn pawn, ref float __result)
        {
            if (YoungAtHeartSettings.learnBonus && 
                ((pawn?.CurJob?.targetA.Thing is Pawn pawn2 && pawn2.learning == null && pawn2.story.traits.HasTrait(YoungAtHeartDefOf.BBLK_BigKid)) ||
                (pawn?.CurJob?.targetB.Thing is Pawn pawn3 && pawn3.learning == null && pawn3.story.traits.HasTrait(YoungAtHeartDefOf.BBLK_BigKid)))
                ) __result += (float)YoungAtHeartSettings.learnRate / 100;
        }
    }
}
