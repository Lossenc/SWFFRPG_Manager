using UnityEngine;
using System.Collections;
using System;
using System.Reflection;
using UnityEngine.UI;

public class CharacterSheet : MonoBehaviour {

    public Text brawnScore;
    public Text agilityScore;
    public Text intellectScore;
    public Text cunningScore;
    public Text willpowerScore;
    public Text presenceScore;

    public Text characterNameText;
    public Text playerNameText;
    public Text speciesText;
    public Text careerText;
    public Text specializationText;

    public GameObject skillObject;
	// Use this for initialization
	void Start () {
        characterNameText = GameObject.Find("CharacterNameText").GetComponent<Text>();
        playerNameText = GameObject.Find("PlayerNameText").GetComponent<Text>();
        speciesText = GameObject.Find("SpeciesText").GetComponent<Text>();
        careerText = GameObject.Find("CareerText").GetComponent<Text>();
        specializationText = GameObject.Find("SpecializationText").GetComponent<Text>();
        brawnScore = GameObject.Find("BrawnScore").GetComponent<Text>();
        agilityScore = GameObject.Find("AgilityScore").GetComponent<Text>();
        intellectScore = GameObject.Find("IntellectScore").GetComponent<Text>();
        cunningScore = GameObject.Find("CunningScore").GetComponent<Text>();
        willpowerScore = GameObject.Find("WillpowerScore").GetComponent<Text>();
        presenceScore = GameObject.Find("PresenceScore").GetComponent<Text>();

        careerText.text = CharacterInformation.CharacterCareer.CareerName;
        string specListText = "";
        for (int i = 0; i < CharacterInformation.characterSpecList.Count; i++)
        {
            if (i == 0)
            {
                specListText = CharacterInformation.characterSpecList[0].SpecName;
            }
            else
            {
                specListText += ", " + CharacterInformation.characterSpecList[i].SpecName;
            }
        }
        characterNameText.text = CharacterInformation.CharacterName;
        playerNameText.text = CharacterInformation.PlayerName;
        speciesText.text = CharacterInformation.CharacterSpecies.SpeciesName;
        specializationText.text = specListText;
        BaseEotESpecies charSpecies = CharacterInformation.CharacterSpecies;
        BaseEotECareer charCareer = CharacterInformation.CharacterCareer;
        brawnScore.text = CalculateStat(charSpecies, charCareer, BaseSkill.SkillCharacteristic.BRAWN).ToString();
        agilityScore.text = CalculateStat(charSpecies, charCareer, BaseSkill.SkillCharacteristic.AGILITY).ToString();
        intellectScore.text = CalculateStat(charSpecies, charCareer, BaseSkill.SkillCharacteristic.INTELLECT).ToString();
        cunningScore.text = CalculateStat(charSpecies, charCareer, BaseSkill.SkillCharacteristic.CUNNING).ToString();
        willpowerScore.text = CalculateStat(charSpecies, charCareer, BaseSkill.SkillCharacteristic.WILLPOWER).ToString();
        presenceScore.text = CalculateStat(charSpecies, charCareer, BaseSkill.SkillCharacteristic.PRESENCE).ToString();
        //foreach (BaseSkill.SkillCategory category in Enum.GetValues(typeof(BaseSkill.SkillCategory))){
        //    foreach ()
        //}
        for (int i = 0; i < CharacterInformation.characterGeneralSkills.Count; i++)
        {
            //Debug.Log(skill);
            GameObject newSkill = Instantiate(Resources.Load("SkillObject"), transform.position, Quaternion.identity) as GameObject;
            if (i < (CharacterInformation.characterGeneralSkills.Count / 2))
            {
                newSkill.transform.SetParent(GameObject.Find("GeneralSkillsA").transform);
            }
            else
            {
                newSkill.transform.SetParent(GameObject.Find("GeneralSkillsB").transform);
            }
            SkillObject skillObjectScript = newSkill.GetComponent<SkillObject>();
            skillObjectScript.SetSkill(CharacterInformation.characterGeneralSkills[i]);
        }
        for (int i = 0; i < CharacterInformation.characterCombatSkills.Count; i++)
        {
            //Debug.Log(skill);
            GameObject newSkill = Instantiate(Resources.Load("SkillObject"), transform.position, Quaternion.identity) as GameObject;
            newSkill.transform.SetParent(GameObject.Find("CombatSkills").transform);
            SkillObject skillObjectScript = newSkill.GetComponent<SkillObject>();
            skillObjectScript.SetSkill(CharacterInformation.characterCombatSkills[i]);
        }
        for (int i = 0; i < CharacterInformation.characterKnowledgeSkills.Count; i++)
        {
            //Debug.Log(skill);
            GameObject newSkill = Instantiate(Resources.Load("SkillObject"), transform.position, Quaternion.identity) as GameObject;
            newSkill.transform.SetParent(GameObject.Find("KnowledgeSkills").transform);
            SkillObject skillObjectScript = newSkill.GetComponent<SkillObject>();
            skillObjectScript.SetSkill(CharacterInformation.characterKnowledgeSkills[i]);
        }

        //foreach (BaseEotECareer.BaseEote)
	    
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public int CalculateStat(BaseEotESpecies species, BaseEotECareer carreer, BaseSkill.SkillCharacteristic characteristic)
    {
        int baseStat = 0;
        switch (characteristic)
        {
            case BaseSkill.SkillCharacteristic.BRAWN:
                baseStat = species.MinBrawn;
                break;
            case BaseSkill.SkillCharacteristic.AGILITY:
                baseStat = species.MinAgility;
                break;
            case BaseSkill.SkillCharacteristic.INTELLECT:
                baseStat = species.MinIntellect;
                break;
            case BaseSkill.SkillCharacteristic.CUNNING:
                baseStat = species.MinCunning;
                break;
            case BaseSkill.SkillCharacteristic.WILLPOWER:
                baseStat = species.MinWillpower;
                break;
            case BaseSkill.SkillCharacteristic.PRESENCE:
                baseStat = species.MinPresence;
                break;
            default:
                break;
        }
        return baseStat;
    }
}

