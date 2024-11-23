using RimWorld;
using Verse;

namespace YoungAtHeart
{
    public class ThoughtWorker_BigKid : ThoughtWorker
    {
        protected override ThoughtState CurrentSocialStateInternal(Pawn p, Pawn other)
        {
            //adult to kid
            if (!YoungAtHeartSettings.haveOpinion ||
                !p.RaceProps.Humanlike ||
                p.learning != null ||
                !p.story.traits.HasTrait(YoungAtHeartDefOf.BBLK_BigKid) ||
                !RelationsUtility.PawnsKnowEachOther(p, other) ||
                other.def != p.def ||
                other.learning == null
                ) return false;
            return true;
        }
    }
}
