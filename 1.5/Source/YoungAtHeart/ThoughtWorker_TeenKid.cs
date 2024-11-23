using RimWorld;
using Verse;

namespace YoungAtHeart
{
    public class ThoughtWorker_TeenKid : ThoughtWorker
    {
        protected override ThoughtState CurrentSocialStateInternal(Pawn p, Pawn other)
        {
            //teen to adult
            if (!YoungAtHeartSettings.haveOpinion || 
                !p.RaceProps.Humanlike ||
                other.learning != null ||
                !other.story.traits.HasTrait(YoungAtHeartDefOf.BBLK_BigKid) ||
                !RelationsUtility.PawnsKnowEachOther(p, other) ||
                other.def != p.def ||
                p.learning != null ||
                p.story.traits.HasTrait(YoungAtHeartDefOf.BBLK_BigKid) || 
                (p.learning == null && p.ageTracker.AgeBiologicalYears > 17)
                ) return false;
            return true;
        }
    }
}
