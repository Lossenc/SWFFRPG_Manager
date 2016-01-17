using UnityEngine;
using System.Collections;

public class BaseSkill {

    private string skillName;
    private string skillDescription;

	private int skillRank = 0;
    private int minSkillRank = 0;
    private bool isCareerSkill;
    private bool isCareerBonusSkill;
    private bool initialCareerBoost;
    private bool initialBonusBoost;
    private bool initialNonCareerBoost;

    
    public enum SkillCharacteristic
    {
        BRAWN,
        AGILITY,
        INTELLECT,
        CUNNING,
        WILLPOWER,
        PRESENCE
    }

    private SkillCharacteristic skillStat;

    public SkillCharacteristic SkillStat
    {
        get { return skillStat; }
        set { skillStat = value; }
    }

    public enum SkillCategory
    {
        GENERAL,
        KNOWLEDGE,
        COMBAT
    }

    private SkillCategory skillType;

    public SkillCategory SkillType
    {
        get { return skillType; }
        set { skillType = value; }
    }

    public string SkillName
    {
        get { return skillName; }
        set { skillName = value; }
    }

    public string SkillDescription
    {
        get { return skillDescription; }
        set { skillDescription = value; }
    }

    public int MinSkillRank
    {
        get { return minSkillRank; }
        set { minSkillRank = value; }
    }

    public int SkillRank
    {
        get { return skillRank; }
        set { skillRank = value; }
    }

    public bool IsCareerSkill
    {
        get { return isCareerSkill; }
        set { isCareerSkill = value; }
    }

    public bool IsCareerBonusSkill
    {
        get { return isCareerBonusSkill; }
        set { isCareerBonusSkill = value; }
    }

    public bool InitialCareerBoost
    {
        get { return initialCareerBoost; }
        set { initialCareerBoost = value; }
    }

    public bool InitialBonusBoost
    {
        get { return initialBonusBoost; }
        set { initialBonusBoost = value; }
    }

    public bool InitialNonCareerBoost
    {
        get { return initialNonCareerBoost; }
        set { initialNonCareerBoost = value; }
    }
}
