using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AstrogationSkill : BaseSkill
{

    public AstrogationSkill()
    {
        SkillName = "Astrogation";
        SkillStat = SkillCharacteristic.INTELLECT;
        SkillType = SkillCategory.GENERAL;
    }

}

public class AthleticsSkill : BaseSkill
{

    public AthleticsSkill()
    {
        SkillName = "Athletics";
        SkillStat = SkillCharacteristic.BRAWN;
        SkillType = SkillCategory.GENERAL;
    }
}

public class BrawlSkill : BaseSkill
{

    public BrawlSkill()
    {
        SkillName = "Brawl";
        SkillStat = SkillCharacteristic.BRAWN;
        SkillType = SkillCategory.COMBAT;
    }
}

public class CharmSkill : BaseSkill
{

    public CharmSkill()
    {
        SkillName = "Charm";
        SkillStat = SkillCharacteristic.PRESENCE;
        SkillType = SkillCategory.GENERAL;
    }
}

public class CoercionSkill : BaseSkill
{

    public CoercionSkill()
    {
        SkillName = "Coercion";
        SkillStat = SkillCharacteristic.WILLPOWER;
        SkillType = SkillCategory.GENERAL;
    }
}

public class ComputersSkill : BaseSkill
{

    public ComputersSkill()
    {
        SkillName = "Computers";
        SkillStat = SkillCharacteristic.INTELLECT;
        SkillType = SkillCategory.GENERAL;
    }
}

public class CoolSkill : BaseSkill
{

    public CoolSkill()
    {
        SkillName = "Cool";
        SkillStat = SkillCharacteristic.PRESENCE;
        SkillType = SkillCategory.GENERAL;
    }
}

public class CoordinationSkill : BaseSkill
{

    public CoordinationSkill()
    {
        SkillName = "Coordination";
        SkillStat = SkillCharacteristic.AGILITY;
        SkillType = SkillCategory.GENERAL;
    }
}

public class CoreWorldsSkill : BaseSkill
{

    public CoreWorldsSkill()
    {
        SkillName = "Knowledge-Core Worlds";
        SkillStat = SkillCharacteristic.INTELLECT;
        SkillType = SkillCategory.KNOWLEDGE;
    }
}

public class DeceptionSkill : BaseSkill
{

    public DeceptionSkill()
    {
        SkillName = "Deception";
        SkillStat = SkillCharacteristic.CUNNING;
        SkillType = SkillCategory.GENERAL;
    }
}

public class DisciplineSkill : BaseSkill
{

    public DisciplineSkill()
    {
        SkillName = "Discipline";
        SkillStat = SkillCharacteristic.WILLPOWER;
        SkillType = SkillCategory.GENERAL;
    }
}

public class EducationSkill : BaseSkill
{

    public EducationSkill()
    {
        SkillName = "Knowledge-Education";
        SkillStat = SkillCharacteristic.INTELLECT;
        SkillType = SkillCategory.KNOWLEDGE;
    }
}

public class GunnerySkill : BaseSkill
{

    public GunnerySkill()
    {
        SkillName = "Gunnery";
        SkillStat = SkillCharacteristic.AGILITY;
        SkillType = SkillCategory.COMBAT;
    }
}

public class LeadershipSkill : BaseSkill
{

    public LeadershipSkill()
    {
        SkillName = "Leadership";
        SkillStat = SkillCharacteristic.PRESENCE;
        SkillType = SkillCategory.GENERAL;
    }
}

public class LoreSkill : BaseSkill
{

    public LoreSkill()
    {
        SkillName = "Knowledge-Lore";
        SkillStat = SkillCharacteristic.INTELLECT;
        SkillType = SkillCategory.KNOWLEDGE;
    }
}

public class MechanicsSkill : BaseSkill
{

    public MechanicsSkill()
    {
        SkillName = "Mechanics";
        SkillStat = SkillCharacteristic.INTELLECT;
        SkillType = SkillCategory.GENERAL;
    }
}

public class MedicineSkill : BaseSkill
{

    public MedicineSkill()
    {
        SkillName = "Medicine";
        SkillStat = SkillCharacteristic.INTELLECT;
        SkillType = SkillCategory.GENERAL;
    }
}

public class MeleeSkill : BaseSkill
{

    public MeleeSkill()
    {
        SkillName = "Melee";
        SkillStat = SkillCharacteristic.BRAWN;
        SkillType = SkillCategory.COMBAT;
    }
}

public class NegotiationSkill : BaseSkill
{

    public NegotiationSkill()
    {
        SkillName = "Negotiation";
        SkillStat = SkillCharacteristic.PRESENCE;
        SkillType = SkillCategory.GENERAL;
    }
}

public class OuterRimSkill : BaseSkill
{

    public OuterRimSkill()
    {
        SkillName = "Knowledge-Outer Rim";
        SkillStat = SkillCharacteristic.INTELLECT;
        SkillType = SkillCategory.KNOWLEDGE;
    }
}

public class PerceptionSkill : BaseSkill
{

    public PerceptionSkill()
    {
        SkillName = "Perception";
        SkillStat = SkillCharacteristic.CUNNING;
        SkillType = SkillCategory.GENERAL;
    }
}

public class PilotingPlanetarySkill : BaseSkill
{

    public PilotingPlanetarySkill()
    {
        SkillName = "Piloting-Planetary";
        SkillStat = SkillCharacteristic.AGILITY;
        SkillType = SkillCategory.GENERAL;
    }
}

public class PilotingSpaceSkill : BaseSkill
{

    public PilotingSpaceSkill()
    {
        SkillName = "Piloting-Space";
        SkillStat = SkillCharacteristic.AGILITY;
        SkillType = SkillCategory.GENERAL;
    }
}

public class RangedHeavySkill : BaseSkill
{

    public RangedHeavySkill()
    {
        SkillName = "Ranged-Heavy";
        SkillStat = SkillCharacteristic.AGILITY;
        SkillType = SkillCategory.COMBAT;
    }
}

public class RangedLightSkill : BaseSkill
{

    public RangedLightSkill()
    {
        SkillName = "Ranged-Light";
        SkillStat = SkillCharacteristic.AGILITY;
        SkillType = SkillCategory.COMBAT;
    }
}

public class ResilienceSkill : BaseSkill
{

    public ResilienceSkill()
    {
        SkillName = "Resilience";
        SkillStat = SkillCharacteristic.BRAWN;
        SkillType = SkillCategory.GENERAL;
    }
}

public class SkulduggerySkill : BaseSkill
{

    public SkulduggerySkill()
    {
        SkillName = "Skulduggery";
        SkillStat = SkillCharacteristic.CUNNING;
        SkillType = SkillCategory.GENERAL;
    }
}

public class StealthSkill : BaseSkill
{

    public StealthSkill()
    {
        SkillName = "Stealth";
        SkillStat = SkillCharacteristic.AGILITY;
        SkillType = SkillCategory.GENERAL;
    }
}

public class StreetwiseSkill : BaseSkill
{

    public StreetwiseSkill()
    {
        SkillName = "Streetwise";
        SkillStat = SkillCharacteristic.CUNNING;
        SkillType = SkillCategory.GENERAL;
    }
}

public class SurvivalSkill : BaseSkill
{

    public SurvivalSkill()
    {
        SkillName = "Survival";
        SkillStat = SkillCharacteristic.CUNNING;
        SkillType = SkillCategory.GENERAL;
    }
}

public class UnderworldSkill : BaseSkill
{

    public UnderworldSkill()
    {
        SkillName = "Knowledge-Underworld";
        SkillStat = SkillCharacteristic.INTELLECT;
        SkillType = SkillCategory.KNOWLEDGE;
    }
}

public class VigilanceSkill : BaseSkill
{

    public VigilanceSkill()
    {
        SkillName = "Vigilance";
        SkillStat = SkillCharacteristic.WILLPOWER;
        SkillType = SkillCategory.GENERAL;
    }
}

public class XenologySkill : BaseSkill
{

    public XenologySkill()
    {
        SkillName = "Knowledge-Xenology";
        SkillStat = SkillCharacteristic.INTELLECT;
        SkillType = SkillCategory.KNOWLEDGE;
    }
}