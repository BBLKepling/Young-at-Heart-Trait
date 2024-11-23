using RimWorld;
using System.Linq;
using Verse;

namespace YoungAtHeart
{
    public class ThoughtWorker_HaveKids : ThoughtWorker
    {
        protected override ThoughtState CurrentStateInternal(Pawn pawn)
        {
            if (!YoungAtHeartSettings.haveKid || pawn.learning != null || pawn.needs.play != null || !(pawn.Map is Map map)) return ThoughtState.Inactive;
            int num = map.mapPawns.SpawnedPawnsInFaction(Faction.OfPlayer).Count(KidIdentifier.IsKid);
            switch (num)
            {
                case 0: return ThoughtState.ActiveAtStage(0);
                case 1: return ThoughtState.ActiveAtStage(1);
                case 2: return ThoughtState.ActiveAtStage(2);
                default:
                    {
                        if (num < 5)
                        {
                            return ThoughtState.ActiveAtStage(3);
                        }
                        if (num < 10)
                        {
                            return ThoughtState.ActiveAtStage(4);
                        }
                        return ThoughtState.ActiveAtStage(5);
                    }
            }
        }
    }
}
