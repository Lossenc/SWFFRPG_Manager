using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BaseEotECharacter {

    private string characterName;
    //private BaseEotESpecies playerSpecies;
    //private BaseEotECareer playerPrimaryCareer;
    //private BaseEotESpecialization playerPrimarySpec;

    //private List<BaseEotETalent> playerTalents;
    
    private int minBrawn;
    private int minAgility;
    private int minIntellect;
    private int minCunning;
    private int minWillpower;
    private int minPresence;
    
    private int woundThreshold;
    private int strainThreshold;
    private int startingExp;
    private string specialAbilities;

    private int credits;
    private int startingCredits;

    private int currentAvailXP;
    private int totalXP;

    private int initialCareerSkills = 4;
    private int initialCareerBonusSkills = 2;
    private int initialNonCareerSkills = 0;

    private BaseSkill astrogation = new AstrogationSkill();
    private BaseSkill athletics = new AthleticsSkill();
    private BaseSkill brawl = new BrawlSkill();
    private BaseSkill charm = new CharmSkill();
    private BaseSkill coercion = new CoercionSkill();
    private BaseSkill computers = new ComputersSkill();
    private BaseSkill cool = new CoolSkill();
    private BaseSkill coordination = new CoordinationSkill();
    private BaseSkill coreWorlds = new CoreWorldsSkill();
    private BaseSkill deception = new DeceptionSkill();
    private BaseSkill discipline = new DisciplineSkill();
    private BaseSkill education = new EducationSkill();
    private BaseSkill gunnery = new GunnerySkill();
    private BaseSkill leadership = new LeadershipSkill();
    private BaseSkill lore = new LoreSkill();
    private BaseSkill mechanics = new MechanicsSkill();
    private BaseSkill medicine = new MedicineSkill();
    private BaseSkill melee = new MeleeSkill();
    private BaseSkill negotiation = new NegotiationSkill();
    private BaseSkill outerRim = new OuterRimSkill();
    private BaseSkill perception = new PerceptionSkill();
    private BaseSkill pilotingPlanetary = new PilotingPlanetarySkill();
    private BaseSkill pilotingSpace = new PilotingSpaceSkill();
    private BaseSkill rangedHeavy = new RangedHeavySkill();
    private BaseSkill rangedLight = new RangedLightSkill();
    private BaseSkill resilience = new ResilienceSkill();
    private BaseSkill skulduggery = new SkulduggerySkill();
    private BaseSkill stealth = new StealthSkill();
    private BaseSkill streetwise = new StreetwiseSkill();
    private BaseSkill survival = new SurvivalSkill();
    private BaseSkill underworld = new UnderworldSkill();
    private BaseSkill vigilance = new VigilanceSkill();
    private BaseSkill xenology = new XenologySkill();

    public string CharacterName
    {
        get { return characterName; }
        set { characterName = value; }
    }

    public int MinBrawn
    {
        get { return minBrawn; }
        set { minBrawn = value; }
    }

    public int MinAgility
    {
        get { return minAgility; }
        set { minAgility = value; }
    }

    public int MinIntellect
    {
        get { return minIntellect; }
        set { minIntellect = value; }
    }

    public int MinCunning
    {
        get { return minCunning; }
        set { minCunning = value; }
    }

    public int MinWillpower
    {
        get { return minWillpower; }
        set { minWillpower = value; }
    }

    public int MinPresence
    {
        get { return minPresence; }
        set { minPresence = value; }
    }

    public int WoundThreshold
    {
        get { return woundThreshold; }
        set { woundThreshold = value; }
    }

    public int StrainThreshold
    {
        get { return strainThreshold; }
        set { strainThreshold = value; }
    }

    public int StartingExp
    {
        get { return startingExp; }
        set { startingExp = value; }
    }

    public string SpecialAbilities
    {
        get { return specialAbilities; }
        set { specialAbilities = value; }
    }

    public int Credits
    {
        get { return credits; }
        set { credits = value; }
    }

    public int StartingCredits
    {
        get { return startingCredits; }
        set { startingCredits = value; }
    }

    public int CurrentAvailXP
    {
        get { return currentAvailXP; }
        set { currentAvailXP = value; }
    }

    public int TotalXP
    {
        get { return totalXP; }
        set { totalXP = value; }
    }

    public int InitialCareerSkills
    {
        get { return initialCareerSkills; }
        set { initialCareerSkills = value; }
    }

    public int InitialCareerBonusSkills
    {
        get { return initialCareerBonusSkills; }
        set { initialCareerBonusSkills = value; }
    }

    public int InitialNonCareerSkills
    {
        get { return initialNonCareerSkills; }
        set { initialNonCareerSkills = value; }
    }

    /*  SKILL GETTERS/SETTERS   */
    public BaseSkill Astrogation
    {
        get { return astrogation; }
        set { astrogation = value; }
    }

    public BaseSkill Athletics
    {
        get { return athletics; }
        set { athletics = value; }
    }

    public BaseSkill Brawl
    {
        get { return brawl; }
        set { brawl = value; }
    }

    public BaseSkill Charm
    {
        get { return charm; }
        set { charm = value; }
    }

    public BaseSkill Coercion
    {
        get { return coercion; }
        set { coercion = value; }
    }

    public BaseSkill Computers
    {
        get { return computers; }
        set { computers = value; }
    }

    public BaseSkill Cool
    {
        get { return cool; }
        set { cool = value; }
    }

    public BaseSkill Coordination
    {
        get { return coordination; }
        set { coordination = value; }
    }

    public BaseSkill CoreWorlds
    {
        get { return coreWorlds; }
        set { coreWorlds = value; }
    }

    public BaseSkill Deception
    {
        get { return deception; }
        set { deception = value; }
    }

    public BaseSkill Discipline
    {
        get { return discipline; }
        set { discipline = value; }
    }

    public BaseSkill Education
    {
        get { return education; }
        set { education = value; }
    }

    public BaseSkill Gunnery
    {
        get { return gunnery; }
        set { gunnery = value; }
    }

    public BaseSkill Leadership
    {
        get { return leadership; }
        set { leadership = value; }
    }

    public BaseSkill Lore
    {
        get { return lore; }
        set { lore = value; }
    }

    public BaseSkill Mechanics
    {
        get { return mechanics; }
        set { mechanics = value; }
    }

    public BaseSkill Medicine
    {
        get { return medicine; }
        set { medicine = value; }
    }

    public BaseSkill Melee
    {
        get { return melee; }
        set { melee = value; }
    }

    public BaseSkill Negotiation
    {
        get { return negotiation; }
        set { negotiation = value; }
    }

    public BaseSkill OuterRim
    {
        get { return outerRim; }
        set { outerRim = value; }
    }

    public BaseSkill Perception
    {
        get { return perception; }
        set { perception = value; }
    }

    public BaseSkill PilotingPlanetary
    {
        get { return pilotingPlanetary; }
        set { pilotingPlanetary = value; }
    }

    public BaseSkill PilotingSpace
    {
        get { return pilotingSpace; }
        set { pilotingSpace = value; }
    }

    public BaseSkill RangedHeavy
    {
        get { return rangedHeavy; }
        set { rangedHeavy = value; }
    }

    public BaseSkill RangedLight
    {
        get { return rangedLight; }
        set { rangedLight = value; }
    }

    public BaseSkill Resilience
    {
        get { return resilience; }
        set { resilience = value; }
    }

    public BaseSkill Skulduggery
    {
        get { return skulduggery; }
        set { skulduggery = value; }
    }

    public BaseSkill Stealth
    {
        get { return stealth; }
        set { stealth = value; }
    }
    
    public BaseSkill Streetwise
    {
        get { return streetwise; }
        set { streetwise = value; }
    }

    public BaseSkill Survival
    {
        get { return survival; }
        set { survival = value; }
    }

    public BaseSkill Underworld
    {
        get { return underworld; }
        set { underworld = value; }
    }

    public BaseSkill Vigilance
    {
        get { return vigilance; }
        set { vigilance = value; }
    }

    public BaseSkill Xenology
    {
        get { return xenology; }
        set { xenology = value; }
    }

}
