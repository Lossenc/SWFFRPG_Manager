using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BaseEotETalent {

    private string talentName;
    private string talentDescription;
    private int talentXPCost;
    private bool rankedTalent;
    private int talentRank = 0;
    private bool speciesTalent;
    private bool unlocked = false;
    private bool isRoot = false;
    private bool obtained = false;
    private bool isDeep = false;
    private List<Trees> talentTrees;
    private List<BaseEotETalent> parentTalents;
    private List<BaseEotETalent> childTalents;

    public List<BaseEotETalent> ParentTalents
    {
        get { return parentTalents; }
        set { parentTalents = value; }
    }

    public List<BaseEotETalent> ChildTalents
    {
        get { return childTalents; }
        set { childTalents = value; }
    }
    
    public enum Trees
    {
        NPCONLY,
        ASSASSIN,
        BODYGUARD,
        DOCTOR,
        FORCESENSITIVEEXILE,
        FRINGER,
        GADGETEER,
        MARAUDER,
        MECHANIC,
        MERCENARYSOLDIER,
        OUTLAWTECH,
        PILOT,
        POLITICO,
        SCHOLAR,
        SCOUNDREL,
        SCOUT,
        SLICER,
        SURVIVALIST,
        THIEF,
        TRADER
    }

    public List<Trees> TalentTrees
    {
        get { return talentTrees; }
        set { talentTrees = value; }
    }

    public enum Activation
    {
        PASSIVE,
        ACTIVE
    }

    private Activation talentActivation;

    public Activation TalentActivation
    {
        get { return talentActivation; }
        set { talentActivation = value; }
    }

    public enum ActivationSpec
    {
        ACTION,
        MANEUVER,
        INCIDENTAL,
        OUTOFTURN
    }

    private List<ActivationSpec> talentActivationSpec = new List<ActivationSpec> { };

    public List<ActivationSpec> TalentActivationSpec
    {
        get { return talentActivationSpec; }
        set { talentActivationSpec = value; }
    }

    public bool RankedTalent
    {
        get { return rankedTalent; }
        set { rankedTalent = value; }
    }

    public bool Unlocked
    {
        get { return unlocked; }
        set { unlocked = value; }
    }

    public bool IsRoot
    {
        get { return isRoot; }
        set { isRoot = value; }
    }

    public bool Obtained
    {
        get { return obtained; }
        set { obtained = value; }
    }

    public bool IsDeep
    {
        get { return isDeep; }
        set { isDeep = value; }
    }

    public string TalentName
    {
        get { return talentName; }
        set { talentName = value; }
    }

    public string TalentDescription
    {
        get { return talentDescription; }
        set { talentDescription = value; }
    }

    public int TalentXPCost
    {
        get { return talentXPCost; }
        set { talentXPCost = value; }
    }

    public int TalentRank
    {
        get { return talentRank; }
        set { talentRank = value; }
    }

    public bool SpeciesTalent
    {
        get { return speciesTalent; }
        set { speciesTalent = value; }
    }
}
