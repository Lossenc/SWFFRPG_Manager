using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;
using System.Collections.Generic;

public class CareerChoiceManager : MonoBehaviour {

    private LevelManager levelManager;
    private BaseEotECareer careerChoice;
    private BaseSpecialization primarySpecChoice;

    private Text characterNameText;
    private Text playerNameText;
    private Text speciesText;

    private Image careerImage;
    private Image specImage;
    private Text careerDescription;
    private Text primarySpecDescription;
    private Text careerSkillsText;
    private Text bonusCareerSkillsText;
    private Dropdown careerDropdown;
    private Dropdown specDropdown;
    private Button nextButton;

    private List<Type> careerTypeList;
    private List<Type> specTypeList;

	// Use this for initialization
	void Awake () {
        levelManager = GameObject.Find("LevelManager").GetComponent<LevelManager>();
        characterNameText = GameObject.Find("CharacterNameText").GetComponent<Text>();
        playerNameText = GameObject.Find("PlayerNameText").GetComponent<Text>();
        speciesText = GameObject.Find("SpeciesText").GetComponent<Text>();
        careerDropdown = GameObject.Find("CareerDropdown").GetComponent<Dropdown>();
        specDropdown = GameObject.Find("SpecDropdown").GetComponent<Dropdown>();
        nextButton = GameObject.Find("NextStepButton").GetComponent<Button>();
        
        careerDescription = GameObject.Find("CareerDescriptionContent").GetComponent<Text>();
        primarySpecDescription = GameObject.Find("PrimarySpecDescriptionContent").GetComponent<Text>();
        careerSkillsText = GameObject.Find("CareerSkillsText").GetComponent<Text>();
        bonusCareerSkillsText = GameObject.Find("BonusCareerSkillsText").GetComponent<Text>();
        
        careerImage = GameObject.Find("CareerImage").GetComponent<Image>();
        specImage = GameObject.Find("SpecImage").GetComponent<Image>();

        characterNameText.text = CharacterInformation.CharacterName;        
        playerNameText.text = CharacterInformation.PlayerName;
        speciesText.text = CharacterInformation.CharacterSpecies.SpeciesName;
        /*if (CharacterInformation.CharacterCareer != null)
        {
            SetCareerCombo(CharacterInformation.CharacterCareer);
        }*/

        FillCareerDropdown();
        /*if (CharacterInformation.characterSpecList.Count != 0)
        {
            SetSpecCombo(CharacterInformation.characterSpecList[0]);
        }*/
        
	}

    public void FillCareerDropdown()
    {
        List<string> careerList = new List<string> { };
        careerTypeList = SubTypeReflector.GetSubTypes<BaseEotECareer>();

        foreach (Type careerType in careerTypeList)
        {
            //Debug.Log(careerType.ToString());
            string careerNamespace = "Career.EotE.Core.";
            string careerSuffix = "Career";
            string tmpString = careerType.ToString();
            if(tmpString.IndexOf(careerNamespace) >=0 )
            {
                tmpString = tmpString.Remove(tmpString.IndexOf(careerNamespace), careerNamespace.Length);
                int i = tmpString.IndexOf(careerSuffix);
                if (i >= 0)
                    tmpString = tmpString.Remove(i, careerSuffix.Length);
                if (tmpString.Length > 0)
                    careerList.Add(tmpString);
            }
        }

        foreach (string careerName in careerList)
        {
            string tmpName = careerName;
            for (int i = 0; i < careerName.Length; i++)
            {
                if (i > 0 && (char.IsUpper(careerName[i]) && char.IsLower(careerName[i - 1])))
                    tmpName = careerName.Insert(i, " ");
            }
            careerDropdown.options.Add(new Dropdown.OptionData(tmpName));
        }
        
    }

    public void FillSpecDropdown(string careerText)
    {
        if (careerText != "")
        {
            List<string> specList = new List<string> { };
            specTypeList = SubTypeReflector.GetSubTypes<BaseSpecialization>();

            foreach (Type specType in specTypeList)
            {
                string specNamespace = "Specialization.EotE." + careerText + ".Core.";
                string specSuffix = "Specialization";
                string tmpString = specType.ToString();
                if (tmpString.IndexOf(specNamespace) >= 0)
                {
                    tmpString = tmpString.Remove(tmpString.IndexOf(specNamespace), specNamespace.Length);
                    int i = tmpString.IndexOf(specSuffix);
                    if (i >= 0)
                        tmpString = tmpString.Remove(i, specSuffix.Length);
                    if (tmpString.Length > 0)
                        specList.Add(tmpString);
                }
            }

            foreach (string specName in specList)
            {
                string tmpName = specName;
                for (int i = 0; i < specName.Length; i++)
                {
                    if (i > 0 && (char.IsUpper(specName[i]) && char.IsLower(specName[i - 1])))
                        tmpName = specName.Insert(i, " ");
                }
                specDropdown.options.Add(new Dropdown.OptionData(tmpName));
            }
        }
        
    }

    public void SetCareerCombo(BaseEotECareer career)
    {
        switch(career.CareerName)
        {
            case "Bounty Hunter":
                careerDropdown.value = 1;
                break;
            case "Colonist":
                careerDropdown.value = 2;
                break;
            case "Explorer":
                careerDropdown.value = 3;
                break;
            case "Hired Gun":
                careerDropdown.value = 4;
                break;
            case "Smuggler":
                careerDropdown.value = 5;
                break;
            case "Technician":
                careerDropdown.value = 6;
                break;
            default:
                break;
        }
    }

    public void SetSpecCombo(BaseSpecialization spec)
    {
        switch(spec.SpecName)
        {
            case "Assassin":
                specDropdown.value = 1;
                break;
            case "Gadgeteer":
                specDropdown.value = 2;
                break;
            case "Survivalist":
                specDropdown.value = 3;
                break;
            case "Doctor":
                specDropdown.value = 4;
                break;
            case "Politico":
                specDropdown.value = 5;
                break;
            case "Scholar":
                specDropdown.value = 6;
                break;
            case "Fringer":
                specDropdown.value = 7;
                break;
            case "Scout":
                specDropdown.value = 8;
                break;
            case "Trader":
                specDropdown.value = 9;
                break;
            case "Bodyguard":
                specDropdown.value = 10;
                break;
            case "Marauder":
                specDropdown.value = 11;
                break;
            case "Mercenary Soldier":
                specDropdown.value = 12;
                break;
            case "Pilot":
                specDropdown.value = 13;
                break;
            case "Scoundrel":
                specDropdown.value = 14;
                break;
            case "Thief":
                specDropdown.value = 15;
                break;
            case "Mechanic":
                specDropdown.value = 16;
                break;
            case "Outlaw Tech":
                specDropdown.value = 17;
                break;
            case "Slicer":
                specDropdown.value = 18;
                break;
            default:
                break;
        }
    }

    public void ChooseCareer(int careerID)
    {
        RemoveCareerInformation();
        if (careerID != 0)
        {
            string careerText = careerDropdown.options[careerID].text;
            careerText = careerText.Replace(" ", string.Empty);
            string careerClassName = careerText + "Career";

            foreach (Type careerType in careerTypeList)
            {
                if (careerType.Name.IndexOf(careerClassName) >= 0)
                {
                    careerChoice = (BaseEotECareer)Activator.CreateInstance(careerType);
                    break;
                }
            }

            careerImage.sprite = Resources.Load<Sprite>("Textures/CareerBlock/" + careerText);
            FillSpecDropdown(careerText);
        }

        else
        {
            //Note to self: get this initializing properly without making garbage instances
            careerChoice = new EmptyEotECareer();
            careerImage.sprite = Resources.Load<Sprite>("Textures/CareerBlock/CareerEmpty");
            
        }
        careerDescription.text = careerChoice.CareerDescription;
        DisplayCareerSkills(careerChoice.CareerSkills, careerSkillsText);
    }

    public void ChooseSpec(int specID)
    {
        //RemoveSpecInformation();

        if (specID != 0)
        {
            string specText = specDropdown.options[specID].text;
            specText = specText.Replace(" ", string.Empty);
            string specClassName = specText + "Specialization";

            foreach (Type specType in specTypeList)
            {
                if (specType.Name.IndexOf(specClassName) >= 0)
                {
                    primarySpecChoice = (BaseSpecialization)Activator.CreateInstance(specType);
                    break;
                }
            }

            string careerText = careerDropdown.options[careerDropdown.value].text;
            careerText = careerText.Replace(" ", string.Empty);

            specImage.sprite = Resources.Load<Sprite>("Textures/SpecBlock/" + careerText + "_" + specText);
        }
        else
        {
            primarySpecChoice = new EmptyEotESpecialization();
            specImage.sprite = Resources.Load<Sprite>("Textures/SpecBlock/SpecializationEmpty");
        }

        primarySpecDescription.text = primarySpecChoice.SpecDescription;
        DisplayCareerSkills(primarySpecChoice.SpecSkills, bonusCareerSkillsText);
        SetBonusSkills(primarySpecChoice);
    }

    public void SetBonusSkills(BaseSpecialization primary)
    {
        foreach (var skill in primary.SpecSkills)
        {
            switch (skill)
            {
                case BaseEotECareer.EotESkills.ASTROGATION:
                    CharacterInformation.astrogation.IsCareerBonusSkill = true;
                    break;
                case BaseEotECareer.EotESkills.ATHLETICS:
                    CharacterInformation.athletics.IsCareerBonusSkill = true;
                    break;
                case BaseEotECareer.EotESkills.BRAWL:
                    CharacterInformation.brawl.IsCareerBonusSkill = true;
                    break;
                case BaseEotECareer.EotESkills.CHARM:
                    CharacterInformation.charm.IsCareerBonusSkill = true;
                    break;
                case BaseEotECareer.EotESkills.COERCION:
                    CharacterInformation.coercion.IsCareerBonusSkill = true;
                    break;
                case BaseEotECareer.EotESkills.COMPUTERS:
                    CharacterInformation.computers.IsCareerBonusSkill = true;
                    break;
                case BaseEotECareer.EotESkills.COOL:
                    CharacterInformation.cool.IsCareerBonusSkill = true;
                    break;
                case BaseEotECareer.EotESkills.COORDINATION:
                    CharacterInformation.coordination.IsCareerBonusSkill = true;
                    break;
                case BaseEotECareer.EotESkills.COREWORLDS:
                    CharacterInformation.coreWorlds.IsCareerBonusSkill = true;
                    break;
                case BaseEotECareer.EotESkills.DECEPTION:
                    CharacterInformation.deception.IsCareerBonusSkill = true;
                    break;
                case BaseEotECareer.EotESkills.DISCIPLINE:
                    CharacterInformation.discipline.IsCareerBonusSkill = true;
                    break;
                case BaseEotECareer.EotESkills.EDUCATION:
                    CharacterInformation.education.IsCareerBonusSkill = true;
                    break;
                case BaseEotECareer.EotESkills.GUNNERY:
                    CharacterInformation.gunnery.IsCareerBonusSkill = true;
                    break;
                case BaseEotECareer.EotESkills.LEADERSHIP:
                    CharacterInformation.leadership.IsCareerBonusSkill = true;
                    break;
                case BaseEotECareer.EotESkills.LORE:
                    CharacterInformation.lore.IsCareerBonusSkill = true;
                    break;
                case BaseEotECareer.EotESkills.MECHANICS:
                    CharacterInformation.mechanics.IsCareerBonusSkill = true;
                    break;
                case BaseEotECareer.EotESkills.MEDICINE:
                    CharacterInformation.medicine.IsCareerBonusSkill = true;
                    break;
                case BaseEotECareer.EotESkills.MELEE:
                    CharacterInformation.melee.IsCareerBonusSkill = true;
                    break;
                case BaseEotECareer.EotESkills.NEGOTIATION:
                    CharacterInformation.negotiation.IsCareerBonusSkill = true;
                    break;
                case BaseEotECareer.EotESkills.OUTERRIM:
                    CharacterInformation.outerRim.IsCareerBonusSkill = true;
                    break;
                case BaseEotECareer.EotESkills.PERCEPTION:
                    CharacterInformation.perception.IsCareerBonusSkill = true;
                    break;
                case BaseEotECareer.EotESkills.PILOTINGPLANETARY:
                    CharacterInformation.pilotingPlanetary.IsCareerBonusSkill = true;
                    break;
                case BaseEotECareer.EotESkills.PILOTINGSPACE:
                    CharacterInformation.pilotingSpace.IsCareerBonusSkill = true;
                    break;
                case BaseEotECareer.EotESkills.RANGEDHEAVY:
                    CharacterInformation.rangedHeavy.IsCareerBonusSkill = true;
                    break;
                case BaseEotECareer.EotESkills.RANGEDLIGHT:
                    CharacterInformation.rangedLight.IsCareerBonusSkill = true;
                    break;
                case BaseEotECareer.EotESkills.RESILIENCE:
                    CharacterInformation.resilience.IsCareerBonusSkill = true;
                    break;
                case BaseEotECareer.EotESkills.SKULDUGGERY:
                    CharacterInformation.skulduggery.IsCareerBonusSkill = true;
                    break;
                case BaseEotECareer.EotESkills.STEALTH:
                    CharacterInformation.stealth.IsCareerBonusSkill = true;
                    break;
                case BaseEotECareer.EotESkills.STREETWISE:
                    CharacterInformation.streetwise.IsCareerBonusSkill = true;
                    break;
                case BaseEotECareer.EotESkills.SURVIVAL:
                    CharacterInformation.survival.IsCareerBonusSkill = true;
                    break;
                case BaseEotECareer.EotESkills.UNDERWORLD:
                    CharacterInformation.underworld.IsCareerBonusSkill = true;
                    break;
                case BaseEotECareer.EotESkills.VIGILANCE:
                    CharacterInformation.vigilance.IsCareerBonusSkill = true;
                    break;
                case BaseEotECareer.EotESkills.XENOLOGY:
                    CharacterInformation.xenology.IsCareerBonusSkill = true;
                    break;
                default:
                    break;
            }
        }
    }

    public void ChangeSprite(Image img, Sprite sprite)
    {
        img.sprite = sprite;
    }

    public void DisplayCareerSkills(List<BaseEotECareer.EotESkills> skillList, Text textObj)
    {
        string skillListString = "";
        string skillString = "";

        for ( int i = 0; i < skillList.Count; i++ )
        {
            switch (skillList[i])
            {
                case BaseEotECareer.EotESkills.ASTROGATION:
                    skillString = "Astrogation";
                    break;
                case BaseEotECareer.EotESkills.ATHLETICS:
                    skillString = "Athletics";
                    break;
                case BaseEotECareer.EotESkills.BRAWL:
                    skillString = "Brawl";
                    break;
                case BaseEotECareer.EotESkills.CHARM:
                    skillString = "Charm";
                    break;
                case BaseEotECareer.EotESkills.COERCION:
                    skillString = "Coercion";
                    break;
                case BaseEotECareer.EotESkills.COMPUTERS:
                    skillString = "Computers";
                    break;
                case BaseEotECareer.EotESkills.COOL:
                    skillString = "Cool";
                    break;
                case BaseEotECareer.EotESkills.COORDINATION:
                    skillString = "Coordination";
                    break;
                case BaseEotECareer.EotESkills.COREWORLDS:
                    skillString = "Knowledge (Core Worlds)";
                    break;
                case BaseEotECareer.EotESkills.DECEPTION:
                    skillString = "Deception";
                    break;
                case BaseEotECareer.EotESkills.DISCIPLINE:
                    skillString = "Discipline";
                    break;
                case BaseEotECareer.EotESkills.EDUCATION:
                    skillString = "Knowledge (Education)";
                    break;
                case BaseEotECareer.EotESkills.GUNNERY:
                    skillString = "Gunnery";
                    break;
                case BaseEotECareer.EotESkills.LEADERSHIP:
                    skillString = "Leadership";
                    break;
                case BaseEotECareer.EotESkills.LORE:
                    skillString = "Knowledge (Lore)";
                    break;
                case BaseEotECareer.EotESkills.MECHANICS:
                    skillString = "Mechanics";
                    break;
                case BaseEotECareer.EotESkills.MEDICINE:
                    skillString = "Medicine";
                    break;
                case BaseEotECareer.EotESkills.MELEE:
                    skillString = "Melee";
                    break;
                case BaseEotECareer.EotESkills.NEGOTIATION:
                    skillString = "Negotiation";
                    break;
                case BaseEotECareer.EotESkills.OUTERRIM:
                    skillString = "Knowledge (Outer Rim)";
                    break;
                case BaseEotECareer.EotESkills.PERCEPTION:
                    skillString = "Perception";
                    break;
                case BaseEotECareer.EotESkills.PILOTINGPLANETARY:
                    skillString = "Piloting (Planetary)";
                    break;
                case BaseEotECareer.EotESkills.PILOTINGSPACE:
                    skillString = "Piloting (Space)";
                    break;
                case BaseEotECareer.EotESkills.RANGEDHEAVY:
                    skillString = "Ranged (Heavy)";
                    break;
                case BaseEotECareer.EotESkills.RANGEDLIGHT:
                    skillString = "Ranged (Light)";
                    break;
                case BaseEotECareer.EotESkills.RESILIENCE:
                    skillString = "Resilience";
                    break;
                case BaseEotECareer.EotESkills.SKULDUGGERY:
                    skillString = "Skulduggery";
                    break;
                case BaseEotECareer.EotESkills.STEALTH:
                    skillString = "Stealth";
                    break;
                case BaseEotECareer.EotESkills.STREETWISE:
                    skillString = "Streetwise";
                    break;
                case BaseEotECareer.EotESkills.SURVIVAL:
                    skillString = "Survival";
                    break;
                case BaseEotECareer.EotESkills.UNDERWORLD:
                    skillString = "Knowledge (Underworld)";
                    break;
                case BaseEotECareer.EotESkills.VIGILANCE:
                    skillString = "Vigilance";
                    break;
                case BaseEotECareer.EotESkills.XENOLOGY:
                    skillString = "Xenology";
                    break;
                default:
                    break;
            }
            if (i == 0)
            {
                skillListString = skillString;
            }
            else
            {
                skillListString += ", " + skillString;
            }
        }
        textObj.text = skillListString;
    }

    public void SaveInformation()
    {
        if(careerChoice != null && primarySpecChoice != null)
        {
            CharacterInformation.CharacterCareer = careerChoice;
            SetCareerSkills(careerChoice);
            CharacterInformation.characterSpecList = new List<BaseSpecialization>{ primarySpecChoice };
            levelManager.LoadLevel("4_InitialCareerSkills");
        }
        
    }

    public void EnableNextStep()
    {
        if (careerDropdown.value == 0 || specDropdown.value == 0)
        {
            //Debug.Log("Disabled Next");
            nextButton.enabled = false;
        }
        else
        {
            //Debug.Log("Enabled Next");
            nextButton.enabled = true;
        }
    }

    public void ResetCareerSkills()
    {
        CharacterInformation.astrogation.IsCareerSkill = false;
        CharacterInformation.athletics.IsCareerSkill = false;
        CharacterInformation.brawl.IsCareerSkill = false;
        CharacterInformation.charm.IsCareerSkill = false;
        CharacterInformation.coercion.IsCareerSkill = false;
        CharacterInformation.computers.IsCareerSkill = false;
        CharacterInformation.cool.IsCareerSkill = false;
        CharacterInformation.coordination.IsCareerSkill = false;
        CharacterInformation.coreWorlds.IsCareerSkill = false;
        CharacterInformation.deception.IsCareerSkill = false;
        CharacterInformation.discipline.IsCareerSkill = false;
        CharacterInformation.education.IsCareerSkill = false;
        CharacterInformation.gunnery.IsCareerSkill = false;
        CharacterInformation.leadership.IsCareerSkill = false;
        CharacterInformation.lore.IsCareerSkill = false;
        CharacterInformation.mechanics.IsCareerSkill = false;
        CharacterInformation.medicine.IsCareerSkill = false;
        CharacterInformation.melee.IsCareerSkill = false;
        CharacterInformation.negotiation.IsCareerSkill = false;
        CharacterInformation.outerRim.IsCareerSkill = false;
        CharacterInformation.perception.IsCareerSkill = false;
        CharacterInformation.pilotingPlanetary.IsCareerSkill = false;
        CharacterInformation.pilotingSpace.IsCareerSkill = false;
        CharacterInformation.rangedHeavy.IsCareerSkill = false;
        CharacterInformation.rangedLight.IsCareerSkill = false;
        CharacterInformation.resilience.IsCareerSkill = false;
        CharacterInformation.skulduggery.IsCareerSkill = false;
        CharacterInformation.stealth.IsCareerSkill = false;
        CharacterInformation.streetwise.IsCareerSkill = false;
        CharacterInformation.survival.IsCareerSkill = false;
        CharacterInformation.underworld.IsCareerSkill = false;
        CharacterInformation.vigilance.IsCareerSkill = false;
        CharacterInformation.xenology.IsCareerSkill = false;
    }

    public void ResetCareerBonusSkills()
    {
        CharacterInformation.astrogation.IsCareerBonusSkill = false;
        CharacterInformation.athletics.IsCareerBonusSkill = false;
        CharacterInformation.brawl.IsCareerBonusSkill = false;
        CharacterInformation.charm.IsCareerBonusSkill = false;
        CharacterInformation.coercion.IsCareerBonusSkill = false;
        CharacterInformation.computers.IsCareerBonusSkill = false;
        CharacterInformation.cool.IsCareerBonusSkill = false;
        CharacterInformation.coordination.IsCareerBonusSkill = false;
        CharacterInformation.coreWorlds.IsCareerBonusSkill = false;
        CharacterInformation.deception.IsCareerBonusSkill = false;
        CharacterInformation.discipline.IsCareerBonusSkill = false;
        CharacterInformation.education.IsCareerBonusSkill = false;
        CharacterInformation.gunnery.IsCareerBonusSkill = false;
        CharacterInformation.leadership.IsCareerBonusSkill = false;
        CharacterInformation.lore.IsCareerBonusSkill = false;
        CharacterInformation.mechanics.IsCareerBonusSkill = false;
        CharacterInformation.medicine.IsCareerBonusSkill = false;
        CharacterInformation.melee.IsCareerBonusSkill = false;
        CharacterInformation.negotiation.IsCareerBonusSkill = false;
        CharacterInformation.outerRim.IsCareerBonusSkill = false;
        CharacterInformation.perception.IsCareerBonusSkill = false;
        CharacterInformation.pilotingPlanetary.IsCareerBonusSkill = false;
        CharacterInformation.pilotingSpace.IsCareerBonusSkill = false;
        CharacterInformation.rangedHeavy.IsCareerBonusSkill = false;
        CharacterInformation.rangedLight.IsCareerBonusSkill = false;
        CharacterInformation.resilience.IsCareerBonusSkill = false;
        CharacterInformation.skulduggery.IsCareerBonusSkill = false;
        CharacterInformation.stealth.IsCareerBonusSkill = false;
        CharacterInformation.streetwise.IsCareerBonusSkill = false;
        CharacterInformation.survival.IsCareerBonusSkill = false;
        CharacterInformation.underworld.IsCareerBonusSkill = false;
        CharacterInformation.vigilance.IsCareerBonusSkill = false;
        CharacterInformation.xenology.IsCareerBonusSkill = false;
    }

    public void RemoveCareerInformation()
    {
        careerChoice = null;
        primarySpecChoice = null;
        CharacterInformation.CharacterCareer = null;
        specDropdown.options.Clear();
        specDropdown.options.Add(new Dropdown.OptionData("<Select a Specialization>"));
        specDropdown.value = 0;
        ResetCareerSkills();
        ResetCareerBonusSkills();
        CharacterInformation.characterSpecList = null;
    }

    public void RemoveSpecInformation()
    {
        primarySpecChoice = null;
        ResetCareerBonusSkills();
        CharacterInformation.characterSpecList = null;
    }

    public void BackButton()
    {
        RemoveCareerInformation();
        levelManager.LoadLevel("2_NameSpecies");
    }

    
    public void SetCareerSkills(BaseEotECareer careerChoice)
    {
        for (int i=0; i<careerChoice.CareerSkills.Count; i++)
        {
            switch (careerChoice.CareerSkills[i])
            {
                case BaseEotECareer.EotESkills.ASTROGATION:
                    CharacterInformation.astrogation.IsCareerSkill = true;
                    break;
                case BaseEotECareer.EotESkills.ATHLETICS:
                    CharacterInformation.athletics.IsCareerSkill = true;
                    break;
                case BaseEotECareer.EotESkills.BRAWL:
                    CharacterInformation.brawl.IsCareerSkill = true;
                    break;
                case BaseEotECareer.EotESkills.CHARM:
                    CharacterInformation.charm.IsCareerSkill = true;
                    break;
                case BaseEotECareer.EotESkills.COERCION:
                    CharacterInformation.coercion.IsCareerSkill = true;
                    break;
                case BaseEotECareer.EotESkills.COMPUTERS:
                    CharacterInformation.computers.IsCareerSkill = true;
                    break;
                case BaseEotECareer.EotESkills.COOL:
                    CharacterInformation.cool.IsCareerSkill = true;
                    break;
                case BaseEotECareer.EotESkills.COORDINATION:
                    CharacterInformation.coordination.IsCareerSkill = true;
                    break;
                case BaseEotECareer.EotESkills.COREWORLDS:
                    CharacterInformation.coreWorlds.IsCareerSkill = true;
                    break;
                case BaseEotECareer.EotESkills.DECEPTION:
                    CharacterInformation.deception.IsCareerSkill = true;
                    break;
                case BaseEotECareer.EotESkills.DISCIPLINE:
                    CharacterInformation.discipline.IsCareerSkill = true;
                    break;
                case BaseEotECareer.EotESkills.EDUCATION:
                    CharacterInformation.education.IsCareerSkill = true;
                    break;
                case BaseEotECareer.EotESkills.GUNNERY:
                    CharacterInformation.gunnery.IsCareerSkill = true;
                    break;
                case BaseEotECareer.EotESkills.LEADERSHIP:
                    CharacterInformation.leadership.IsCareerSkill = true;
                    break;
                case BaseEotECareer.EotESkills.LORE:
                    CharacterInformation.lore.IsCareerSkill = true;
                    break;
                case BaseEotECareer.EotESkills.MECHANICS:
                    CharacterInformation.mechanics.IsCareerSkill = true;
                    break;
                case BaseEotECareer.EotESkills.MEDICINE:
                    CharacterInformation.medicine.IsCareerSkill = true;
                    break;
                case BaseEotECareer.EotESkills.MELEE:
                    CharacterInformation.melee.IsCareerSkill = true;
                    break;
                case BaseEotECareer.EotESkills.NEGOTIATION:
                    CharacterInformation.negotiation.IsCareerSkill = true;
                    break;
                case BaseEotECareer.EotESkills.OUTERRIM:
                    CharacterInformation.outerRim.IsCareerSkill = true;
                    break;
                case BaseEotECareer.EotESkills.PERCEPTION:
                    CharacterInformation.perception.IsCareerSkill = true;
                    break;
                case BaseEotECareer.EotESkills.PILOTINGPLANETARY:
                    CharacterInformation.pilotingPlanetary.IsCareerSkill = true;
                    break;
                case BaseEotECareer.EotESkills.PILOTINGSPACE:
                    CharacterInformation.pilotingSpace.IsCareerSkill = true;
                    break;
                case BaseEotECareer.EotESkills.RANGEDHEAVY:
                    CharacterInformation.rangedHeavy.IsCareerSkill = true;
                    break;
                case BaseEotECareer.EotESkills.RANGEDLIGHT:
                    CharacterInformation.rangedLight.IsCareerSkill = true;
                    break;
                case BaseEotECareer.EotESkills.RESILIENCE:
                    CharacterInformation.resilience.IsCareerSkill = true;
                    break;
                case BaseEotECareer.EotESkills.SKULDUGGERY:
                    CharacterInformation.skulduggery.IsCareerSkill = true;
                    break;
                case BaseEotECareer.EotESkills.STEALTH:
                    CharacterInformation.stealth.IsCareerSkill = true;
                    break;
                case BaseEotECareer.EotESkills.STREETWISE:
                    CharacterInformation.streetwise.IsCareerSkill = true;
                    break;
                case BaseEotECareer.EotESkills.SURVIVAL:
                    CharacterInformation.survival.IsCareerSkill = true;
                    break;
                case BaseEotECareer.EotESkills.UNDERWORLD:
                    CharacterInformation.underworld.IsCareerSkill = true;
                    break;
                case BaseEotECareer.EotESkills.VIGILANCE:
                    CharacterInformation.vigilance.IsCareerSkill = true;
                    break;
                case BaseEotECareer.EotESkills.XENOLOGY:
                    CharacterInformation.xenology.IsCareerSkill = true;
                    break;
                default:
                    break;
            }
        }
    }

    
}