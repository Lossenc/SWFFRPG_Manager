using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

public class CharacterInformation : MonoBehaviour {

    private static string characterName = "CHARACTER NAME";
    private static string playerName = "PLAYER NAME";
    /*private static List<BaseEotESpecies> speciesList = new List<BaseEotESpecies> { new BothanSpecies(), new DroidSpecies(), new GandSpecies(), new HumanSpecies(), new RodianSpecies(), new TrandoshanSpecies(), new TwilekSpecies(), new WookieeSpecies() };
    private static List<BaseEotECareer> careerList = new List<BaseEotECareer> { new BountyHunterEotECareer(), new ColonistEotECareer(), new ExplorerEotECareer(), new HiredGunEotECareer(), new SmugglerEotECareer(), new TechnicianEotECareer() };

    public static List<BaseEotESpecies> SpeciesList
    {
        get { return speciesList; }
        set { speciesList = value; }
    }
    

    public static List<BaseEotECareer> CareerList
    {
        get { return careerList; }
        set { careerList = value; }
    }*/

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    private static string baseGame;

    private static bool contentEotEMain;
    private static bool contentEotEEtU;
    private static bool contentEotESoF;
    private static bool contentEotEDC;
    private static bool contentEotEFH;
    private static bool contentEotELoNH;
    private static bool contentEotEFC;
    private static bool contentAoRMain;
    private static bool contentFaDMain;

    public static string BaseGame
    {
        get { return baseGame; }
        set { baseGame = value; }
    }

    public static bool ContentEotEMain
    {
        get { return contentEotEMain; }
        set { contentEotEMain = value; }
    }

    public static bool ContentEotEEtU
    {
        get { return contentEotEEtU; }
        set { contentEotEEtU = value; }
    }

    public static bool ContentEotESoF
    {
        get { return contentEotESoF; }
        set { contentEotESoF = value; }
    }

    public static bool ContentEotEDC
    {
        get { return contentEotEDC; }
        set { contentEotEDC = value; }
    }

    public static bool ContentEotEFH
    {
        get { return contentEotEFH; }
        set { contentEotEFH = value; }
    }

    public static bool ContentEotELoNH
    {
        get { return contentEotELoNH; }
        set { contentEotELoNH = value; }
    }

    public static bool ContentEotEFC
    {
        get { return contentEotEFC; }
        set { contentEotEFC = value; }
    }

    public static bool ContentAoRMain
    {
        get { return contentAoRMain; }
        set { contentAoRMain = value; }
    }

    public static bool ContentFaDMain
    {
        get { return contentFaDMain; }
        set { contentFaDMain = value; }
    }

    public static bool IsMale { get; set; }
    public static string CharacterName
    {
        get { return characterName; }
        set { characterName = value; }
    }
    public static string PlayerName
    {
        get { return playerName; }
        set { playerName = value; }
    }
    public static string CharacterBio { get; set; }
    public static BaseEotESpecies CharacterSpecies { get; set; }
    public static BaseEotECareer CharacterCareer { get; set; }
    
    public static int Brawn { get; set; }
    public static int Agility { get; set; }
    public static int Intellect { get; set; }
    public static int Cunning { get; set; }
    public static int Willpower { get; set; }
    public static int Presence { get; set; }
    
    public static int WoundThreshold { get; set; }
    public static int StrainThreshold { get; set; }
    public static int StartingExp { get; set; }
    public static string SpecialAbilities { get; set; }

    public static int Credits { get; set; }

    public static int CurrentAvailXP { get; set; }
    public static int TotalXP { get; set; }

    public static BaseSkill astrogation = new AstrogationSkill();
    public static BaseSkill athletics = new AthleticsSkill();
    public static BaseSkill brawl = new BrawlSkill();
    public static BaseSkill charm = new CharmSkill();
    public static BaseSkill coercion = new CoercionSkill();
    public static BaseSkill computers = new ComputersSkill();
    public static BaseSkill cool = new CoolSkill();
    public static BaseSkill coordination = new CoordinationSkill();
    public static BaseSkill coreWorlds = new CoreWorldsSkill();
    public static BaseSkill deception = new DeceptionSkill();
    public static BaseSkill discipline = new DisciplineSkill();
    public static BaseSkill education = new EducationSkill();
    public static BaseSkill gunnery = new GunnerySkill();
    public static BaseSkill leadership = new LeadershipSkill();
    public static BaseSkill lore = new LoreSkill();
    public static BaseSkill mechanics = new MechanicsSkill();
    public static BaseSkill medicine = new MedicineSkill();
    public static BaseSkill melee = new MeleeSkill();
    public static BaseSkill negotiation = new NegotiationSkill();
    public static BaseSkill outerRim = new OuterRimSkill();
    public static BaseSkill perception = new PerceptionSkill();
    public static BaseSkill pilotingPlanetary = new PilotingPlanetarySkill();
    public static BaseSkill pilotingSpace = new PilotingSpaceSkill();
    public static BaseSkill rangedHeavy = new RangedHeavySkill();
    public static BaseSkill rangedLight = new RangedLightSkill();
    public static BaseSkill resilience = new ResilienceSkill();
    public static BaseSkill skulduggery = new SkulduggerySkill();
    public static BaseSkill stealth = new StealthSkill();
    public static BaseSkill streetwise = new StreetwiseSkill();
    public static BaseSkill survival = new SurvivalSkill();
    public static BaseSkill underworld = new UnderworldSkill();
    public static BaseSkill vigilance = new VigilanceSkill();
    public static BaseSkill xenology = new XenologySkill();

    public static List<BaseSkill> characterGeneralSkills = new List<BaseSkill> { astrogation, athletics, charm, coercion, computers, cool, coordination, deception, discipline, leadership, mechanics, medicine, negotiation, perception, pilotingPlanetary, pilotingSpace, resilience, skulduggery, stealth, streetwise, survival, vigilance };
    public static List<BaseSkill> characterCombatSkills = new List<BaseSkill> { brawl, gunnery, melee, rangedLight, rangedHeavy };
    public static List<BaseSkill> characterKnowledgeSkills = new List<BaseSkill> { coreWorlds, education, lore, outerRim, underworld, xenology };
    public static List<BaseSpecialization> characterSpecList = new List<BaseSpecialization> { };

    public static List<BaseEotETalent> talentsLearned = new List<BaseEotETalent> { };
    public static List<BaseItem> itemsCarried = new List<BaseItem> { };

    public static void AddTalent(BaseEotETalent talentToAdd)
    {
        foreach (var talent in talentsLearned)
        {
            if(talent.GetType() == talentToAdd.GetType())
            {
                if (talent.RankedTalent)
                {
                    talent.TalentRank += 1;
                    return;
                }
                else
                {
                    Debug.Log("THIS SHOULD NOT HAPPEN.  CHECK ME: " + talent.TalentName);
                    return;
                }
            }
        }

        talentToAdd.TalentRank = 1;
        talentsLearned.Add(talentToAdd);
        return;
        //var first = talentsLearned.OfType<>()
    }

    public static void RemoveTalent(BaseEotETalent talentToRemove)
    {
        foreach (var talent in talentsLearned)
        {
            if (talent.GetType() == talentToRemove.GetType())
            {
                if (talent.RankedTalent)
                {
                    if (talent.TalentRank > 1)
                    {
                        talent.TalentRank -= 1;
                        return;
                    }
                    talentsLearned.Remove(talent);
                    return;
                }
                else
                {
                    Debug.Log("THIS SHOULD NOT HAPPEN.  CHECK ME: " + talent.TalentName);
                    return;
                }
            }
        }

        talentsLearned.Remove(talentToRemove);
        return;
        //var first = talentsLearned.OfType<>()
    }

    public static void AddItem(BaseItem item)
    {
        itemsCarried.Add(item);
    }

    public static string TranslateSkillToName(BaseEotECareer.EotESkills skill)
    {
        string skillName = "";

        switch (skill)
        {
            case BaseEotECareer.EotESkills.ASTROGATION:
                skillName = "Astrogation";
                break;
            case BaseEotECareer.EotESkills.ATHLETICS:
                skillName = "Athletics";
                break;
            case BaseEotECareer.EotESkills.BRAWL:
                skillName = "Brawl";
                break;
            case BaseEotECareer.EotESkills.CHARM:
                skillName = "Charm";
                break;
            case BaseEotECareer.EotESkills.COERCION:
                skillName = "Coercion";
                break;
            case BaseEotECareer.EotESkills.COMPUTERS:
                skillName = "Computers";
                break;
            case BaseEotECareer.EotESkills.COOL:
                skillName = "Cool";
                break;
            case BaseEotECareer.EotESkills.COORDINATION:
                skillName = "Coordination";
                break;
            case BaseEotECareer.EotESkills.COREWORLDS:
                skillName = "Core Worlds";
                break;
            case BaseEotECareer.EotESkills.DECEPTION:
                skillName = "Deception";
                break;
            case BaseEotECareer.EotESkills.DISCIPLINE:
                skillName = "Discipline";
                break;
            case BaseEotECareer.EotESkills.EDUCATION:
                skillName = "Knowledge - Education";
                break;
            case BaseEotECareer.EotESkills.GUNNERY:
                skillName = "Gunnery";
                break;
            case BaseEotECareer.EotESkills.LEADERSHIP:
                skillName = "Leadership";
                break;
            case BaseEotECareer.EotESkills.LORE:
                skillName = "Lore";
                break;
            case BaseEotECareer.EotESkills.MECHANICS:
                skillName = "Mechanics";
                break;
            case BaseEotECareer.EotESkills.MEDICINE:
                skillName = "Medicine";
                break;
            case BaseEotECareer.EotESkills.MELEE:
                skillName = "Melee";
                break;
            case BaseEotECareer.EotESkills.NEGOTIATION:
                skillName = "Negotiation";
                break;
            case BaseEotECareer.EotESkills.OUTERRIM:
                skillName = "Outer Rim";
                break;
            case BaseEotECareer.EotESkills.PERCEPTION:
                skillName = "Perception";
                break;
            case BaseEotECareer.EotESkills.PILOTINGPLANETARY:
                skillName = "Piloting - Planetary";
                break;
            case BaseEotECareer.EotESkills.PILOTINGSPACE:
                skillName = "Piloting - Space";
                break;
            case BaseEotECareer.EotESkills.RANGEDHEAVY:
                skillName = "Ranged - Heavy";
                break;
            case BaseEotECareer.EotESkills.RANGEDLIGHT:
                skillName = "Ranged - Light";
                break;
            case BaseEotECareer.EotESkills.RESILIENCE:
                skillName = "Resilience";
                break;
            case BaseEotECareer.EotESkills.SKULDUGGERY:
                skillName = "Skulduggery";
                break;
            case BaseEotECareer.EotESkills.STEALTH:
                skillName = "Stealth";
                break;
            case BaseEotECareer.EotESkills.STREETWISE:
                skillName = "Streetwise";
                break;
            case BaseEotECareer.EotESkills.SURVIVAL:
                skillName = "Survival";
                break;
            case BaseEotECareer.EotESkills.UNDERWORLD:
                skillName = "Underworld";
                break;
            case BaseEotECareer.EotESkills.VIGILANCE:
                skillName = "Vigilance";
                break;
            case BaseEotECareer.EotESkills.XENOLOGY:
                skillName = "Xenology";
                break;
            default:
                Debug.LogWarning("Skill name not identifiable.");
                break;
        }
        return skillName;
    }

    public static BaseSkill TranslateSkillEnumToSkillInstance(BaseEotECareer.EotESkills skill)
    {
        BaseSkill skillName = astrogation;

        switch (skill)
        {
            case BaseEotECareer.EotESkills.ASTROGATION:
                skillName = astrogation;
                break;
            case BaseEotECareer.EotESkills.ATHLETICS:
                skillName = athletics;
                break;
            case BaseEotECareer.EotESkills.BRAWL:
                skillName = brawl;
                break;
            case BaseEotECareer.EotESkills.CHARM:
                skillName = charm;
                break;
            case BaseEotECareer.EotESkills.COERCION:
                skillName = coercion;
                break;
            case BaseEotECareer.EotESkills.COMPUTERS:
                skillName = computers;
                break;
            case BaseEotECareer.EotESkills.COOL:
                skillName = cool;
                break;
            case BaseEotECareer.EotESkills.COORDINATION:
                skillName = coordination;
                break;
            case BaseEotECareer.EotESkills.COREWORLDS:
                skillName = coreWorlds;
                break;
            case BaseEotECareer.EotESkills.DECEPTION:
                skillName = deception;
                break;
            case BaseEotECareer.EotESkills.DISCIPLINE:
                skillName = discipline;
                break;
            case BaseEotECareer.EotESkills.EDUCATION:
                skillName = education;
                break;
            case BaseEotECareer.EotESkills.GUNNERY:
                skillName = gunnery;
                break;
            case BaseEotECareer.EotESkills.LEADERSHIP:
                skillName = leadership;
                break;
            case BaseEotECareer.EotESkills.LORE:
                skillName = lore;
                break;
            case BaseEotECareer.EotESkills.MECHANICS:
                skillName = mechanics;
                break;
            case BaseEotECareer.EotESkills.MEDICINE:
                skillName = medicine;
                break;
            case BaseEotECareer.EotESkills.MELEE:
                skillName = melee;
                break;
            case BaseEotECareer.EotESkills.NEGOTIATION:
                skillName = negotiation;
                break;
            case BaseEotECareer.EotESkills.OUTERRIM:
                skillName = outerRim;
                break;
            case BaseEotECareer.EotESkills.PERCEPTION:
                skillName = perception;
                break;
            case BaseEotECareer.EotESkills.PILOTINGPLANETARY:
                skillName = pilotingPlanetary;
                break;
            case BaseEotECareer.EotESkills.PILOTINGSPACE:
                skillName = pilotingSpace;
                break;
            case BaseEotECareer.EotESkills.RANGEDHEAVY:
                skillName = rangedHeavy;
                break;
            case BaseEotECareer.EotESkills.RANGEDLIGHT:
                skillName = rangedLight;
                break;
            case BaseEotECareer.EotESkills.RESILIENCE:
                skillName = resilience;
                break;
            case BaseEotECareer.EotESkills.SKULDUGGERY:
                skillName = skulduggery;
                break;
            case BaseEotECareer.EotESkills.STEALTH:
                skillName = stealth;
                break;
            case BaseEotECareer.EotESkills.STREETWISE:
                skillName = streetwise;
                break;
            case BaseEotECareer.EotESkills.SURVIVAL:
                skillName = survival;
                break;
            case BaseEotECareer.EotESkills.UNDERWORLD:
                skillName = underworld;
                break;
            case BaseEotECareer.EotESkills.VIGILANCE:
                skillName = vigilance;
                break;
            case BaseEotECareer.EotESkills.XENOLOGY:
                skillName = xenology;
                break;
            default:
                Debug.LogWarning("Skill name not identifiable.");
                break;
        }
        return skillName;
    }

    /*public string TranslateSpecialization()
    {
        return "";
    }*/

    public string TranslateSkillCategory(BaseSkill.SkillCategory category)
    {
        string categoryString = "";

        switch (category)
        {
            case BaseSkill.SkillCategory.COMBAT:
                categoryString = "Combat";
                break;
            case BaseSkill.SkillCategory.GENERAL:
                categoryString = "General";
                break;
            case BaseSkill.SkillCategory.KNOWLEDGE:
                categoryString = "Knowledge";
                break;
            default:
                Debug.Log("Skill category could not be identified: " + category.ToString());
                break;
        }
        return categoryString;
    }

    public string TranslateSkillCharacteristic(BaseSkill.SkillCharacteristic characteristic)
    {
        string characteristicString = "";
        switch (characteristic)
        {
            case BaseSkill.SkillCharacteristic.AGILITY:
                characteristicString = "Agility";
                break;
            case BaseSkill.SkillCharacteristic.BRAWN:
                characteristicString = "Brawn";
                break;
            case BaseSkill.SkillCharacteristic.CUNNING:
                characteristicString = "Cunning";
                break;
            case BaseSkill.SkillCharacteristic.INTELLECT:
                characteristicString = "Intellect";
                break;
            case BaseSkill.SkillCharacteristic.PRESENCE:
                characteristicString = "Presence";
                break;
            case BaseSkill.SkillCharacteristic.WILLPOWER:
                characteristicString = "Willpower";
                break;
            default:
                Debug.LogWarning("Skill characteristic could not be identified: " + characteristic.ToString());
                break;
        }
        return characteristicString;
    }

    public string TranslateTalentActivation(BaseEotETalent.Activation activation)
    {
        string activationString = "";

        switch (activation)
        {
            case BaseEotETalent.Activation.ACTIVE:
                activationString = "Active";
                break;
            case BaseEotETalent.Activation.PASSIVE:
                activationString = "Passive";
                break;
            default:
                Debug.LogWarning("Talent activation could not be identified: " + activation.ToString());
                break;
        }

        return activationString;
    }

    public string TranslateTalentActivationSpecial(BaseEotETalent.ActivationSpec activationSpec)
    {
        string activationSpecString = "";

        switch (activationSpec)
        {
            case BaseEotETalent.ActivationSpec.ACTION:
                activationSpecString = "Action";
                break;
            case BaseEotETalent.ActivationSpec.INCIDENTAL:
                activationSpecString = "Incidental";
                break;
            case BaseEotETalent.ActivationSpec.MANEUVER:
                activationSpecString = "Maneuver";
                break;
            case BaseEotETalent.ActivationSpec.OUTOFTURN:
                activationSpecString = "Out of Turn";
                break;
            default:
                Debug.LogWarning("Talent specific activation could not be identified: " + activationSpec.ToString());
                break;
        }
        return activationSpecString;
    }

    public string TranslateCareerTree(BaseEotETalent.Trees careerTree)
    {
        string careerTreeString = "";

        switch(careerTree)
        {
            case BaseEotETalent.Trees.ASSASSIN:
                careerTreeString = "Assassin";
                break;
            case BaseEotETalent.Trees.BODYGUARD:
                careerTreeString = "Bodyguard";
                break;
            case BaseEotETalent.Trees.DOCTOR:
                careerTreeString = "Doctor";
                break;
            case BaseEotETalent.Trees.FORCESENSITIVEEXILE:
                careerTreeString = "Force Sensitive Exile";
                break;
            case BaseEotETalent.Trees.FRINGER:
                careerTreeString = "Fringer";
                break;
            case BaseEotETalent.Trees.GADGETEER:
                careerTreeString = "Gadgeteer";
                break;
            case BaseEotETalent.Trees.MARAUDER:
                careerTreeString = "Marauder";
                break;
            case BaseEotETalent.Trees.MECHANIC:
                careerTreeString = "Mechanic";
                break;
            case BaseEotETalent.Trees.MERCENARYSOLDIER:
                careerTreeString = "Mercenary Soldier";
                break;
            case BaseEotETalent.Trees.NPCONLY:
                careerTreeString = "NPC Only";
                break;
            case BaseEotETalent.Trees.OUTLAWTECH:
                careerTreeString = "Outlaw Tech";
                break;
            case BaseEotETalent.Trees.PILOT:
                careerTreeString = "Pilot";
                break;
            case BaseEotETalent.Trees.POLITICO:
                careerTreeString = "Politico";
                break;
            case BaseEotETalent.Trees.SCHOLAR:
                careerTreeString = "Scholar";
                break;
            case BaseEotETalent.Trees.SCOUNDREL:
                careerTreeString = "Scoundrel";
                break;
            case BaseEotETalent.Trees.SCOUT:
                careerTreeString = "Scout";
                break;
            case BaseEotETalent.Trees.SLICER:
                careerTreeString = "Slicer";
                break;
            case BaseEotETalent.Trees.SURVIVALIST:
                careerTreeString = "Survivalist";
                break;
            case BaseEotETalent.Trees.THIEF:
                careerTreeString = "Thief";
                break;
            case BaseEotETalent.Trees.TRADER:
                careerTreeString = "Trader";
                break;
            default:
                Debug.LogWarning("Talent career tree could not be identified: " + careerTree.ToString());
                break;
        }

        return careerTreeString;
    }

}