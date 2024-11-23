using Verse;

namespace YoungAtHeart
{
    public static class KidIdentifier
    {
        public static bool IsKid(this Pawn pawn)
        {
            return (pawn.learning != null || pawn.needs.play != null);
        }
    }
}
