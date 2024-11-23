using RimWorld;
using Verse;

namespace YoungAtHeart
{
    public class ThoughtWorker_LittleKid : ThoughtWorker
    {
        protected override ThoughtState CurrentSocialStateInternal(Pawn p, Pawn other)
        {
            if (!YoungAtHeartSettings.haveOpinion) return false;
            //adult to adult
            if (p.learning == null && 
                other.learning == null && 
                p.story.traits.HasTrait(YoungAtHeartDefOf.BBLK_BigKid) && 
                other.story.traits.HasTrait(YoungAtHeartDefOf.BBLK_BigKid)
                ) return true;
            //kid to adult
            if (!p.RaceProps.Humanlike ||
                other.learning != null ||
                !other.story.traits.HasTrait(YoungAtHeartDefOf.BBLK_BigKid) ||
                !RelationsUtility.PawnsKnowEachOther(p, other) ||
                other.def != p.def ||
                p.learning == null
                ) return false;
            return true;
        }
    }
}
