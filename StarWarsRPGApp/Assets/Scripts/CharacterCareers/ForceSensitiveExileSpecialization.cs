using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ForceSensitiveExileSpecialization : BaseSpecialization
{

    public ForceSensitiveExileSpecialization()
    {
        SpecName = "ForceSensitiveExile";
        SpecCareer = BaseEotECareer.EotECareers.UNIVERSAL;
        SpecSkills = new List<BaseEotECareer.EotESkills> {};
        SpecDescription = "The Force Sensitive Exile is not just any Force-sensitive being; he is one who survived the purges. He may have been a " +
                          "young Padawan or even a minor Jedi who managed to flee the Empire and hide. He may also have been a child, hidden by " +
                          "friends or family. Whatever the case, he's spent the last decades in a hostile galaxy. His formal training is likely " +
                          "to be limited or even non-existent, and he uses his powers carefully or not at all. Even his mastery of the Force is " +
                          "shaped by his experiences--his powers focus more around concealment and control than flashy displays of ability.";
        //Force Rating = 1
    }

    public static BaseEotETalent rootUncannySenses = new UncannySensesTalent(true, 5);
    public static BaseEotETalent rootInsight = new InsightTalent(true, 5);
    public static BaseEotETalent rootForager = new ForagerTalent(true, 5);
    public static BaseEotETalent rootUncannyReactions = new UncannyReactionsTalent(true, 5);
    public static BaseEotETalent convincingDemeanor = new ConvincingDemeanorTalent(new List<BaseEotETalent> { rootUncannySenses }, 10);
    public static BaseEotETalent rootOverwhelmEmotions = new OverwhelmEmotionsTalent(true, 10);
    public static BaseEotETalent rootIntenseFocus = new IntenseFocusTalent(true, 10);
    public static BaseEotETalent quickDraw = new QuickDrawTalent(new List<BaseEotETalent> { rootUncannyReactions }, 10);
    public static BaseEotETalent senseDanger = new SenseDangerTalent(new List<BaseEotETalent> { convincingDemeanor, streetSmartsA }, 15);
    public static BaseEotETalent senseEmotions = new SenseEmotionsTalent(new List<BaseEotETalent> { rootOverwhelmEmotions, uncannySensesA }, 15);
    public static BaseEotETalent balance = new BalanceTalent(new List<BaseEotETalent> { rootIntenseFocus, uncannyReactionsA }, 15);
    public static BaseEotETalent touchOfFate = new TouchOfFateTalent(new List<BaseEotETalent> { quickDraw, streetSmartsB }, 15);
    public static BaseEotETalent streetSmartsA = new StreetSmartsTalent(new List<BaseEotETalent> { senseDanger, uncannySensesA, sixthSense }, 20);
    public static BaseEotETalent uncannySensesA = new UncannySensesTalent(new List<BaseEotETalent> { senseEmotions, streetSmartsA, uncannyReactionsA, forceRating }, 20);
    public static BaseEotETalent uncannyReactionsA = new UncannyReactionsTalent(new List<BaseEotETalent> { balance, uncannySensesA, streetSmartsB, dedication }, 20);
    public static BaseEotETalent streetSmartsB = new StreetSmartsTalent(new List<BaseEotETalent> { touchOfFate, uncannyReactionsA, superiorReflexes }, 20);
    public static BaseEotETalent sixthSense = new SixthSenseTalent(new List<BaseEotETalent> { streetSmartsA, forceRating }, 25);
    public static BaseEotETalent forceRating = new ForceRatingTalent(new List<BaseEotETalent> { uncannySensesA, sixthSense, dedication }, 25);
    public static BaseEotETalent dedication = new DedicationTalent(new List<BaseEotETalent> { uncannyReactionsA, forceRating, superiorReflexes }, 25);
    public static BaseEotETalent superiorReflexes = new SuperiorReflexesTalent(new List<BaseEotETalent> { streetSmartsB, dedication }, 25);
}