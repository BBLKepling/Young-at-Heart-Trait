using Verse;

namespace YoungAtHeart
{
    public class YoungAtHeartSettings : ModSettings
    {
        public static bool haveKid = true;
        public static bool haveOpinion = true;
        public static bool learnBonus = true;
        public static int learnRate = 25;
        public static bool playBonus = true;
        public static int playRate = 25;
        public override void ExposeData()
        {
            Scribe_Values.Look(ref haveKid, "haveKid", true);
            Scribe_Values.Look(ref haveOpinion, "haveOpinion", true);
            Scribe_Values.Look(ref learnBonus, "learnBonus", true);
            Scribe_Values.Look(ref learnRate, "learnRate", 25);
            Scribe_Values.Look(ref playBonus, "playBonus", true);
            Scribe_Values.Look(ref playRate, "playRate", 25);
            base.ExposeData();
        }
    }
}
