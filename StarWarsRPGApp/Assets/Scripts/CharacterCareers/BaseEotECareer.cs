using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BaseEotECareer {

    private string careerName;
    private string careerDescription;

    private List<EotESkills> careerSkills;

    //private BaseEotESpecialization classSpec;

    private static List<BaseSpecialization> careerSpecList = new List<BaseSpecialization> { };
    public static List<BaseSpecialization> CareerSpecList
    {
        get { return careerSpecList; }
        set { careerSpecList = value; }
    }

    public enum EotECareers
    {
        BOUNTYHUNTER,
        COLONIST,
        EXPLORER,
        HIREDGUN,
        SMUGGLER,
        TECHNICIAN,
        UNIVERSAL
    }

    public enum EotESkills
    {
        ASTROGATION,
        ATHLETICS,
        BRAWL,
        CHARM,
        COERCION,
        COMPUTERS,
        COOL,
        COORDINATION,
        COREWORLDS,
        DECEPTION,
        DISCIPLINE,
        EDUCATION,
        GUNNERY,
        LEADERSHIP,
        LORE,
        MECHANICS,
        MEDICINE,
        MELEE,
        NEGOTIATION,
        OUTERRIM,
        PERCEPTION,
        PILOTINGPLANETARY,
        PILOTINGSPACE,
        RANGEDHEAVY,
        RANGEDLIGHT,
        RESILIENCE,
        SKULDUGGERY,
        STEALTH,
        STREETWISE,
        SURVIVAL,
        UNDERWORLD,
        VIGILANCE,
        XENOLOGY
    }

    public EotECareers primaryCareer;

    public EotECareers PrimaryCareer
    {
        get { return primaryCareer; }
        set { primaryCareer = value; }
    }

    public string CareerName
    {
        get { return careerName; }
        set { careerName = value; }
    }

    public string CareerDescription
    {
        get { return careerDescription; }
        set { careerDescription = value; }
    }

    public List<EotESkills> CareerSkills
    {
        get { return careerSkills; }
        set { careerSkills = value; }
    }

    //public void AddSkillRank(EotESkills skillToIncrease)
    //{
        
    //}
    
}
