using UnityEngine;
using Verse;

namespace YoungAtHeart
{
    public class YoungAtHeartMod : Mod
    {
        public YoungAtHeartMod(ModContentPack content) : base(content)
        {
            GetSettings<YoungAtHeartSettings>();
        }
        public override void DoSettingsWindowContents(Rect inRect)
        {
            Listing_Standard listingStandard = new Listing_Standard();
            listingStandard.Begin(inRect);
            listingStandard.CheckboxLabeled("BBLK_YoungAtHeart_haveKid_Label".Translate(), ref YoungAtHeartSettings.haveKid, "BBLK_YoungAtHeart_haveKid_ToolTip".Translate());
            listingStandard.CheckboxLabeled("BBLK_YoungAtHeart_haveOpinion_Label".Translate(), ref YoungAtHeartSettings.haveOpinion, "BBLK_YoungAtHeart_haveOpinion_ToolTip".Translate());
            listingStandard.CheckboxLabeled("BBLK_YoungAtHeart_learnBonus_Label".Translate(), ref YoungAtHeartSettings.learnBonus, "BBLK_YoungAtHeart_learnBonus_ToolTip".Translate());
            YoungAtHeartSettings.learnRate = (int)listingStandard.SliderLabeled("BBLK_YoungAtHeart_learnRate_Label".Translate() + " " + YoungAtHeartSettings.learnRate + "%", YoungAtHeartSettings.learnRate, 1, 200, tooltip: "BBLK_YoungAtHeart_learnRate_ToolTip".Translate());
            listingStandard.CheckboxLabeled("BBLK_YoungAtHeart_playBonus_Label".Translate(), ref YoungAtHeartSettings.playBonus, "BBLK_YoungAtHeart_playBonus_ToolTip".Translate());
            YoungAtHeartSettings.playRate = (int)listingStandard.SliderLabeled("BBLK_YoungAtHeart_playRate_Label".Translate() + " " + YoungAtHeartSettings.playRate + "%", YoungAtHeartSettings.playRate, 1, 200, tooltip: "BBLK_YoungAtHeart_playRate_ToolTip".Translate());
            listingStandard.End();
            base.DoSettingsWindowContents(inRect);
        }
        public override string SettingsCategory() => "BBLK_YoungAtHeart_Settings".Translate();
    }
}
