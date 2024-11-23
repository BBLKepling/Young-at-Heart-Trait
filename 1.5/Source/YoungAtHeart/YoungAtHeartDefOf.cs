using RimWorld;

namespace YoungAtHeart
{
    [DefOf]
    public class YoungAtHeartDefOf
    {
        static YoungAtHeartDefOf()
        {
            DefOfHelper.EnsureInitializedInCtor(typeof(YoungAtHeartDefOf));
        }

        public static TraitDef BBLK_BigKid;
    }
}
