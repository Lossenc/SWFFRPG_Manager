using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System;
using System.Linq;

public class SpeciesChoice : MonoBehaviour {

    private BaseEotESpecies speciesChoice;
    private Text characterName;
    private Text playerName;
    private Image speciesImage;
    private Text speciesDescription;
    private Text speciesAbilities;
    private Text woundThreshold;
    private Text strainThreshold;
    private Text startingExperience;
    private Text brawnScore;
    private Text agilityScore;
    private Text intellectScore;
    private Text cunningScore;
    private Text willpowerScore;
    private Text presenceScore;
    private LevelManager levelManager;
    private Dropdown speciesDropdown;

    private List<Type> speciesTypeList;

    //private EventSystem system;

    public void Start()
    {
        levelManager = GameObject.Find("LevelManager").GetComponent<LevelManager>();
        characterName = GameObject.Find("CharacterNameInputText").GetComponent<Text>();
        playerName = GameObject.Find("PlayerNameInputText").GetComponent<Text>();
        speciesImage = GameObject.Find("SpeciesImage").GetComponent<Image>();
        speciesDescription = GameObject.Find("SpeciesDescriptionContent").GetComponent<Text>();
        speciesAbilities = GameObject.Find("SpeciesSpecialAbilitiesContent").GetComponent<Text>();
        woundThreshold = GameObject.Find("WoundThresholdText").GetComponent<Text>();
        strainThreshold = GameObject.Find("StrainThresholdText").GetComponent<Text>();
        startingExperience = GameObject.Find("StartingExperienceText").GetComponent<Text>();
        brawnScore = GameObject.Find("BrawnScore").GetComponent<Text>();
        agilityScore = GameObject.Find("AgilityScore").GetComponent<Text>();
        intellectScore = GameObject.Find("IntellectScore").GetComponent<Text>();
        cunningScore = GameObject.Find("CunningScore").GetComponent<Text>();
        willpowerScore = GameObject.Find("WillpowerScore").GetComponent<Text>();
        presenceScore = GameObject.Find("PresenceScore").GetComponent<Text>();
        speciesDropdown = GameObject.Find("SpeciesDropdown").GetComponent<Dropdown>();
        
        FillSpeciesDropdown();
        //system = EventSystem.current;
    }

    public void FillSpeciesDropdown()
    {
        List<string> speciesList = new List<string> { };
        speciesTypeList = SubTypeReflector.GetSubTypes<BaseEotESpecies>();
        foreach (Type speciesType in speciesTypeList)
        {
            string speciesNamespace = "Species.EotE.Core.";
            string speciesSuffix = "Species";
            string tmpString = speciesType.ToString();
            if (tmpString.IndexOf(speciesNamespace) >= 0)
            {
                tmpString = tmpString.Remove(tmpString.IndexOf(speciesNamespace), speciesNamespace.Length);
                int j = tmpString.IndexOf(speciesSuffix);
                if (j >= 0)
                    tmpString = tmpString.Remove(j, speciesSuffix.Length);
                if (tmpString.Length > 0)
                    speciesList.Add(tmpString);
            }
            
        }

        foreach (string speciesName in speciesList)
        {
            speciesDropdown.options.Add(new Dropdown.OptionData(speciesName));
        }

    }

    public void ChooseSpecies(int speciesID)
    {
        if (speciesID != 0)
        {
            string speciesText = speciesDropdown.options[speciesID].text;
            string speciesClassName = speciesText + "Species";
            
            foreach (Type speciesType in speciesTypeList)
            {
                if (speciesType.Name.IndexOf(speciesClassName) >= 0)
                {
                    speciesChoice = (BaseEotESpecies)Activator.CreateInstance(speciesType);
                    break;
                }
            }
            
            speciesImage.sprite = Resources.Load<Sprite>("Textures/SpeciesBlock/" + speciesText);
        }
        else
        {
            speciesChoice = new EmptySpecies();
            speciesImage.sprite = Resources.Load<Sprite>("Textures/SpeciesBlock/SpeciesEmpty");
        }
            

        speciesDescription.text = speciesChoice.SpeciesDescription;
        speciesAbilities.text = speciesChoice.SpecialAbilities;
        woundThreshold.text = speciesChoice.WoundThresholdText;
        strainThreshold.text = speciesChoice.StrainThresholdText;
        startingExperience.text = speciesChoice.StartingExperienceText;
        brawnScore.text = speciesChoice.MinBrawn.ToString();
        agilityScore.text = speciesChoice.MinAgility.ToString();
        intellectScore.text = speciesChoice.MinIntellect.ToString();
        cunningScore.text = speciesChoice.MinCunning.ToString();
        willpowerScore.text = speciesChoice.MinWillpower.ToString();
        presenceScore.text = speciesChoice.MinPresence.ToString();
        
    }

    public void SaveInformation()
    {
        CharacterInformation.CharacterName = characterName.text;
        CharacterInformation.PlayerName = playerName.text;
        CharacterInformation.CharacterSpecies = speciesChoice;
        CharacterInformation.TotalXP = 0;
        CharacterInformation.CurrentAvailXP = speciesChoice.StartingExp;
        CharacterInformation.Brawn = speciesChoice.MinBrawn;
        CharacterInformation.Agility = speciesChoice.MinAgility;
        CharacterInformation.Intellect = speciesChoice.MinIntellect;
        CharacterInformation.Cunning = speciesChoice.MinCunning;
        CharacterInformation.Willpower = speciesChoice.MinWillpower;
        CharacterInformation.Presence = speciesChoice.MinPresence;
        levelManager.LoadLevel("3_Career");       
    }

    public void RemoveSpecies()
    {
        speciesChoice = null;
    }

    public void BackButton()
    {
        RemoveInformation();
        levelManager.LoadLevel("1A_NewCharacterOptions");
    }

    public void RemoveInformation()
    {
        for (int i = speciesDropdown.options.Count - 1; i > 0; i--)
        {
            speciesDropdown.options.Remove(speciesDropdown.options[i]);
        }
        CharacterInformation.CharacterName = null;
        CharacterInformation.PlayerName = null;
        CharacterInformation.CharacterSpecies = null;
        RemoveSpecies();
    }

    public void NextStep()
    {
        if (characterName.text == "" || playerName.text == "" || speciesDropdown.value == 0)
        {
            SaveInformation();
        }
        else
        {
            Debug.LogWarning("Please fill out all fields.");
        }
    }
}
