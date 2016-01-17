using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BaseEotESpecies : BaseEotECharacter {

    /*public enum ClassType
    {
        EotESpecies,
        AoRSpecies,
        FaDSpecies
    };*/

    private string speciesName = "Needs a name";
    private string speciesDescription = "Needs a description";

    private string woundThresholdText;
    private string strainThresholdText;
    private string startingExperienceText;
    private int cyberneticImplantCap = 0;
    private bool canBeForceSensitive = true;


    public string SpeciesName
    {
        get { return speciesName; }
        set { speciesName = value; }
    }

    public string SpeciesDescription
    {
        get { return speciesDescription; }
        set { speciesDescription = value; }
    }
    public string WoundThresholdText
    {
        get { return woundThresholdText; }
        set { woundThresholdText = value; }
    }
    public string StrainThresholdText
    {
        get { return strainThresholdText; }
        set { strainThresholdText = value; }
    }
    public string StartingExperienceText
    {
        get { return startingExperienceText; }
        set { startingExperienceText = value; }
    }
    public bool CanBeForceSensitive
    {
        get { return canBeForceSensitive; }
        set { canBeForceSensitive = value; }
    }
    public int CyberneticImplantCap
    {
        get { return cyberneticImplantCap; }
        set { cyberneticImplantCap = value; }
    }

}

public class EmptySpecies : BaseEotESpecies
{

    public EmptySpecies()
    {
        //var assembly = typeof(EmptySpecies).Assembly;
        //var types = assembly.GetTypes().Where
        SpeciesName = "Empty";
        SpeciesDescription = "Here would be a description of the chosen species";
        MinBrawn = 0;
        MinAgility = 0;
        MinIntellect = 0;
        MinCunning = 0;
        MinWillpower = 0;
        MinPresence = 0;

        WoundThreshold = 14 + MinBrawn;
        StrainThreshold = 8 + MinWillpower;
        StartingExp = 90;
        WoundThresholdText = "??? + Brawn";
        StrainThresholdText = "??? + Willpower";
        StartingExperienceText = "??? XP";
        SpecialAbilities = "???";
    }
}