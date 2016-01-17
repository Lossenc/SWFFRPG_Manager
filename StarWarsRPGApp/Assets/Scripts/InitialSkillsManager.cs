using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class InitialSkillsManager : MonoBehaviour
{
    private LevelManager levelManager;
    private Text characterText;
    private Text playerText;
    private Text speciesText;
    private Text careerText;
    private Text specText;

    private GameObject careerSkillsLayout;
    private GameObject careerBonusSkillsLayout;
    private GameObject nonCareerSkillsLayout;

    private GameObject nonCareerSkillsToggleParent;

    private Toggle[] careerSkillToggleArray;
    private Toggle[] bonusSkillToggleArray;
    private Dictionary<string, BaseEotECareer.EotESkills> careerSkillDict = new Dictionary<string, BaseEotECareer.EotESkills> { };

    private Text initialCareerSkillLabel;
    private Text initialBonusSkillLabel;
    private Text initialNonCareerSkillLabel;

    private int numCareerSkills;
    private int numBonusSkills;
    private int numNonCareerSkills;

    public GameObject skillTogglePrefab;
    public GameObject skillDropdownPrefab;

    private Toggle[] nonCareerToggleArray;

    // Use this for initialization
    void Start()
    {
        levelManager = GameObject.Find("LevelManager").GetComponent<LevelManager>();
        characterText = GameObject.Find("CharacterNameText").GetComponent<Text>();
        playerText = GameObject.Find("PlayerNameText").GetComponent<Text>();
        speciesText = GameObject.Find("SpeciesText").GetComponent<Text>();
        careerText = GameObject.Find("CareerText").GetComponent<Text>();
        specText = GameObject.Find("SpecializationText").GetComponent<Text>();
        careerSkillsLayout = GameObject.Find("CareerSkills");
        careerBonusSkillsLayout = GameObject.Find("CareerBonusSkills");
        nonCareerSkillsLayout = GameObject.Find("NonCareerSkills");
        careerSkillToggleArray = careerSkillsLayout.GetComponentsInChildren<Toggle>();
        bonusSkillToggleArray = careerBonusSkillsLayout.GetComponentsInChildren<Toggle>();
        initialCareerSkillLabel = GameObject.Find("CareerSkillLabel").GetComponent<Text>();
        initialBonusSkillLabel = GameObject.Find("BonusSkillLabel").GetComponent<Text>();
        initialNonCareerSkillLabel = GameObject.Find("NonCareerSkillsLabel").GetComponent<Text>();

        characterText.text = CharacterInformation.CharacterName;
        playerText.text = CharacterInformation.PlayerName;
        speciesText.text = CharacterInformation.CharacterSpecies.SpeciesName;
        careerText.text = CharacterInformation.CharacterCareer.CareerName;
        List<BaseSpecialization> specTextList = CharacterInformation.characterSpecList;
        numCareerSkills = CharacterInformation.CharacterSpecies.InitialCareerSkills;
        numBonusSkills = CharacterInformation.CharacterSpecies.InitialCareerBonusSkills;
        numNonCareerSkills = CharacterInformation.CharacterSpecies.InitialNonCareerSkills;
        string specTextString = "";
        foreach (BaseSpecialization spec in specTextList)
        {
            if (specTextString == "")
            {
                specTextString = spec.SpecName;
            }
            else
            {
                specTextString += ", " + spec.SpecName;
            }
        }
        specText.text = specTextString;
        SetNumberCareerSkills(numCareerSkills);
        SetNumberBonusSkills(numBonusSkills);
        if (numNonCareerSkills > 0)
        {
            SetNumberNonCareerSkills(numNonCareerSkills);
        }
        SetCareerSkillToggles();
        SetCareerBonusSkillToggles();
        SetNonCareerBonusDropdowns();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SetCareerSkillToggles()
    {
        List<BaseSkill> careerList = FindCareerSkills();

        foreach (BaseSkill skill in careerList)
        {
            AddSkillToggle(careerSkillsLayout, skill);
        }
    }

    void SetCareerBonusSkillToggles()
    {
        List<BaseSkill> bonusList = FindBonusSkills();

        foreach (BaseSkill skill in bonusList)
        {
            AddSkillToggle(careerBonusSkillsLayout, skill);
        }

    }

    public void SetNonCareerBonusDropdowns()
    {
        if (numNonCareerSkills > 0)
        {
            List<BaseSkill> nonCareerList = FindNonCareerSkills();

            Debug.Log("Non-Career Skills to choose: " + numNonCareerSkills);
            for (int i = 0; i < numNonCareerSkills; i++)
            {
                AddSkillDropdown(nonCareerSkillsLayout, nonCareerList);
            }
        }

        else
        {
            initialNonCareerSkillLabel.gameObject.SetActive(false);
        }
    }

    public void SetNumberCareerSkills(int curNumCareerSkills)
    {
        string careerSkillText = "Initial Career Skills: Please select " + curNumCareerSkills.ToString() + " to raise by one rank for free.";
        initialCareerSkillLabel.text = careerSkillText;
    }

    public void SetNumberBonusSkills(int curNumBonusSkills)
    {
        string bonusSkillText = "Initial Bonus Skills: Please select " + curNumBonusSkills.ToString() + " to raise by one rank for free. You may select the same skill twice, (once for Career and once for Bonus) but no skill may be raised above Rank 2 in Character Creation.";
        initialBonusSkillLabel.text = bonusSkillText;
    }

    public void SetNumberNonCareerSkills(int curNumNonCareerSkills)
    {
        Debug.Log("Setting Non-Career");
        string nonCareerSkillText = "Initial Non-Career Skills: Please select " + curNumNonCareerSkills.ToString() + " to raise by one rank for free.";
        initialNonCareerSkillLabel.text = nonCareerSkillText;
    }

    public List<BaseSkill> FindCareerSkills()
    {
        List<BaseSkill> careerSkillsList = new List<BaseSkill>{};
        // Iterate through all skills.
        foreach (BaseSkill skill in CharacterInformation.characterGeneralSkills)
        {
            if (skill.IsCareerSkill)
            {
                careerSkillsList.Add(skill);
            }
        }
        foreach (BaseSkill skill in CharacterInformation.characterCombatSkills)
        {
            if (skill.IsCareerSkill)
            {
                careerSkillsList.Add(skill);
            }
        }
        foreach (BaseSkill skill in CharacterInformation.characterKnowledgeSkills)
        {
            if (skill.IsCareerSkill)
            {
                careerSkillsList.Add(skill);
            }
        }
        return careerSkillsList;
    }

    public List<BaseSkill> FindBonusSkills()
    {
        List<BaseSkill> bonusSkillsList = new List<BaseSkill> { };
        // Iterate through all skills.
        foreach (BaseSkill skill in CharacterInformation.characterGeneralSkills)
        {
            if (skill.IsCareerBonusSkill)
            {
                bonusSkillsList.Add(skill);
            }
        }
        foreach (BaseSkill skill in CharacterInformation.characterCombatSkills)
        {
            if (skill.IsCareerBonusSkill)
            {
                bonusSkillsList.Add(skill);
            }
        }
        foreach (BaseSkill skill in CharacterInformation.characterKnowledgeSkills)
        {
            if (skill.IsCareerBonusSkill)
            {
                bonusSkillsList.Add(skill);
            }
        }
        return bonusSkillsList;
    }

    public List<BaseSkill> FindNonCareerSkills()
    {
        List<BaseSkill> nonCareerSkillsList = new List<BaseSkill> { };
        // Iterate through all skills.
        foreach (BaseSkill skill in CharacterInformation.characterGeneralSkills)
        {
            if (!skill.IsCareerSkill && !skill.IsCareerBonusSkill)
            {
                nonCareerSkillsList.Add(skill);
            }
        }
        foreach (BaseSkill skill in CharacterInformation.characterCombatSkills)
        {
            if (!skill.IsCareerSkill && !skill.IsCareerBonusSkill)
            {
                nonCareerSkillsList.Add(skill);
            }
        }
        foreach (BaseSkill skill in CharacterInformation.characterKnowledgeSkills)
        {
            if (!skill.IsCareerSkill && !skill.IsCareerBonusSkill)
            {
                nonCareerSkillsList.Add(skill);
            }
        }
        return nonCareerSkillsList;
    }

    public void AddSkillToggle(GameObject parentObject, BaseSkill skill)
    {
        GameObject newToggle = (GameObject)Instantiate(skillTogglePrefab);

        newToggle.transform.SetParent(parentObject.transform);
        Text toggleText = newToggle.GetComponentInChildren<Text>();
        toggleText.text = skill.SkillName;

        Toggle toggleObj = newToggle.GetComponent<Toggle>();
        toggleObj.onValueChanged.AddListener((bool toggled) =>
            {
                if (toggled)
                {
                    if (parentObject == careerSkillsLayout)
                    {
                        skill.InitialCareerBoost = true;
                        skill.MinSkillRank++;
                        numCareerSkills--;
                        if (numCareerSkills == 0)
                        {
                            DisableRemainderToggles(parentObject);
                        }
                    }
                    else if(parentObject == careerBonusSkillsLayout)
                    {
                        skill.InitialBonusBoost = true;
                        skill.MinSkillRank++;
                        numBonusSkills--;
                        if (numBonusSkills == 0)
                        {
                            DisableRemainderToggles(parentObject);
                        }
                    }
                    skill.SkillRank++;
                    Debug.Log("Set " + skill.SkillName + " to Rank " + skill.SkillRank);
                }
                else
                {
                    if (parentObject == careerSkillsLayout)
                    {
                        skill.InitialCareerBoost = false;
                        skill.MinSkillRank--;
                        numCareerSkills++;
                        EnableToggles(parentObject);
                    }
                    else if (parentObject == careerBonusSkillsLayout)
                    {
                        skill.InitialBonusBoost = false;
                        skill.MinSkillRank--;
                        numBonusSkills++;
                        EnableToggles(parentObject);
                    }
                    skill.SkillRank--;
                    Debug.Log("Set " + skill.SkillName + " to Rank " + skill.SkillRank);
                }
                skill.SkillRank = skill.MinSkillRank;
                SetNumberCareerSkills(numCareerSkills);
                SetNumberBonusSkills(numBonusSkills);
            });
    }

    public void DisableRemainderToggles(GameObject parentObject)
    {
        foreach (Toggle t in parentObject.GetComponentsInChildren<Toggle>())
        {
            if (!t.isOn)
            {
                t.interactable = false;
            }
        }
    }

    public void EnableToggles(GameObject parentObject)
    {
        foreach (Toggle t in parentObject.GetComponentsInChildren<Toggle>())
        {
            t.interactable = true;
        }
    }

    public void AddSkillDropdown(GameObject parentObj, List<BaseSkill> skillList)
    {
        GameObject newDropdown = (GameObject)Instantiate(skillDropdownPrefab);

        newDropdown.transform.SetParent(parentObj.transform);
        Dropdown dropdownObj = newDropdown.GetComponent<Dropdown>();
        PopulateSkillDropdown(dropdownObj, skillList);
    }

    public void PopulateSkillDropdown(Dropdown dropdownObj, List<BaseSkill> skillList)
    {
        foreach (BaseSkill skill in skillList)
        {
            dropdownObj.options.Add(new Dropdown.OptionData(skill.SkillName));
        }
    }
    

    public void CareerSkillValueChanged(bool value)
    {
        int currentNumCareerSkills = numCareerSkills;
        foreach (Toggle skillToggle in careerSkillToggleArray)
        {
            if (skillToggle.isOn)
            {
                currentNumCareerSkills--;
            }
        }

        if (currentNumCareerSkills <= 0)
        {
            foreach (Toggle skillToggle in careerSkillToggleArray)
            {
                if (!skillToggle.isOn)
                    skillToggle.interactable = false;
            }
   
        }
        else
        {
            foreach (Toggle skillToggle in careerSkillToggleArray)
            {
                skillToggle.interactable = true;
            }
        }

        SetNumberCareerSkills(currentNumCareerSkills);

    }

    public void BonusSkillValueChanged(bool value)
    {
        int currentNumBonusSkills = numBonusSkills;
        foreach (Toggle skillToggle in bonusSkillToggleArray)
        {
            if (skillToggle.isOn)
            {
                currentNumBonusSkills--;
            }
        }

        if (currentNumBonusSkills <= 0)
        {
            foreach (Toggle skillToggle in bonusSkillToggleArray)
            {
                if (!skillToggle.isOn)
                    skillToggle.interactable = false;
            }

        }
        else
        {
            foreach (Toggle skillToggle in bonusSkillToggleArray)
            {
                skillToggle.interactable = true;
            }
        }

        SetNumberBonusSkills(currentNumBonusSkills);

    }

    public void NextButton()
    {
        Dropdown[] dropdownArray;
        
        if(numCareerSkills == 0 && numBonusSkills == 0)
        {
            if (numNonCareerSkills != 0)
            {
                List<BaseSkill> nonCareerSkillsList = FindNonCareerSkills();
                dropdownArray = nonCareerSkillsLayout.GetComponentsInChildren<Dropdown>();
                foreach (Dropdown skillDropdown in dropdownArray)
                {
                    if (skillDropdown.value == 0 || (dropdownArray[0].value == dropdownArray[1].value))
                    {
                        Debug.LogWarning("Please make sure both dropdown fields are filled, and are not the same.");
                        return;
                    }
                }

                foreach (BaseSkill nonCareer in nonCareerSkillsList)
                {
                    foreach (Dropdown skillDropdown in dropdownArray)
                    {
                        if (skillDropdown.options[skillDropdown.value].text == nonCareer.SkillName)
                        {
                            nonCareer.SkillRank++;
                            Debug.Log("Set " + nonCareer.SkillName + " to Rank " + nonCareer.SkillRank);
                        }
                    }

                }
            }

            levelManager.LoadLevel("5_InitialBuild");
        }
        else
        {
            Debug.LogWarning("Please ensure all initial skills have been set.");
        }
    }

    public void BackButton()
    {
        foreach (BaseSkill skill in CharacterInformation.characterGeneralSkills)
        {
            skill.InitialCareerBoost = false;
            skill.InitialBonusBoost = false;
            skill.InitialNonCareerBoost = false;
            skill.SkillRank = skill.MinSkillRank;
        }

        foreach (BaseSkill skill in CharacterInformation.characterCombatSkills)
        {
            skill.InitialCareerBoost = false;
            skill.InitialBonusBoost = false;
            skill.InitialNonCareerBoost = false;
            skill.SkillRank = skill.MinSkillRank;
        }

        foreach (BaseSkill skill in CharacterInformation.characterKnowledgeSkills)
        {
            skill.InitialCareerBoost = false;
            skill.InitialBonusBoost = false;
            skill.InitialNonCareerBoost = false;
            skill.SkillRank = skill.MinSkillRank;
        }
        
        levelManager.LoadLevel("3_Career");
        
    }
}