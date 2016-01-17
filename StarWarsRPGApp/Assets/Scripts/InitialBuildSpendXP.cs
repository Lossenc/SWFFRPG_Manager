using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class InitialBuildSpendXP : MonoBehaviour {

    public enum BuildMode
    {
        CHARACTERISTICS,
        SKILLS,
        TALENTS
    };

    private GameObject characteristicsPanel;
    private GameObject skillPanel;
    private GameObject talentPanel;
    private GameObject generalSkillsContentPanel;
    private GameObject combatSkillsContentPanel;
    private GameObject knowledgeSkillsContentPanel;

    private Image characteristicsButtonImage;
    private Image skillsButtonImage;
    private Image talentsButtonImage;

    private Text characterNameText;
    private Text playerNameText;
    private Text speciesText;
    private Text careerText;
    private Text specText;
    private Text totalXPText;
    private Text availXPText;
    private Text brawnText;
    private Text agilityText;
    private Text intellectText;
    private Text cunningText;
    private Text willpowerText;
    private Text presenceText;

    private List<List<GameObject>> talentMatrix;

    private BuildMode currentMode;

    public GameObject skillPrefab;
    public GameObject talentNodePrefab;
    public GameObject talentPopup;

	// Use this for initialization
	void Start () {

        characteristicsPanel = GameObject.Find("CharacteristicsPanel");
        skillPanel = GameObject.Find("SkillPanels");
        talentPanel = GameObject.Find("TalentNodeTree");
        generalSkillsContentPanel = GameObject.Find("GeneralSkillContentPanel");
        combatSkillsContentPanel = GameObject.Find("CombatSkillContentPanel");
        knowledgeSkillsContentPanel = GameObject.Find("KnowledgeSkillContentPanel");
        characteristicsButtonImage = GameObject.Find("CharacteristicsButton").GetComponentInChildren<Image>();
        skillsButtonImage = GameObject.Find("SkillsButton").GetComponentInChildren<Image>();
        talentsButtonImage = GameObject.Find("TalentsButton").GetComponentInChildren<Image>();
        talentPopup = GameObject.Find("TalentPopup");

        characterNameText = GameObject.Find("CharacterNameText").GetComponent<Text>();
        playerNameText = GameObject.Find("PlayerNameText").GetComponent<Text>();
        speciesText = GameObject.Find("SpeciesText").GetComponent<Text>();
        careerText = GameObject.Find("CareerText").GetComponent<Text>();
        specText = GameObject.Find("SpecializationText").GetComponent<Text>();
        totalXPText = GameObject.Find("TotalXPValue").GetComponent<Text>();
        availXPText = GameObject.Find("AvailXPValue").GetComponent<Text>();
        brawnText = GameObject.Find("BrawnScore").GetComponent<Text>();
        agilityText = GameObject.Find("AgilityScore").GetComponent<Text>();
        intellectText = GameObject.Find("IntellectScore").GetComponent<Text>();
        cunningText = GameObject.Find("CunningScore").GetComponent<Text>();
        willpowerText = GameObject.Find("WillpowerScore").GetComponent<Text>();
        presenceText = GameObject.Find("PresenceScore").GetComponent<Text>();



        characterNameText.text = CharacterInformation.CharacterName;
        playerNameText.text = CharacterInformation.PlayerName;
        speciesText.text = CharacterInformation.CharacterSpecies.SpeciesName;
        careerText.text = CharacterInformation.CharacterCareer.CareerName;
        string specString = "";
        foreach (BaseSpecialization spec in CharacterInformation.characterSpecList)
        {
            if(specString == "")
            {
                specString = spec.SpecName;
            }
            else
            {
                specString += ", " + spec.SpecName;
            }
        }
        HideTalentPopupPanel();
        specText.text = specString;
        SetModeButton("characteristics");
        totalXPText.text = CharacterInformation.TotalXP.ToString();
        availXPText.text = CharacterInformation.CurrentAvailXP.ToString();
        SetCharacteristics();
        SetSkills();
        SetTalentTree();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void SetModeButton(string mode)
    {
        switch (mode)
        {
            case "characteristics":
                characteristicsButtonImage.sprite = Resources.Load<Sprite>("Textures/ModeButtons/CharacteristicsButtonDown");
                skillsButtonImage.sprite = Resources.Load<Sprite>("Textures/ModeButtons/SkillsButtonUp");
                talentsButtonImage.sprite = Resources.Load<Sprite>("Textures/ModeButtons/TalentsButtonUp");
                SetMode(BuildMode.CHARACTERISTICS);
                break;
            case "skills":
                characteristicsButtonImage.sprite = Resources.Load<Sprite>("Textures/ModeButtons/CharacteristicsButtonUp");
                skillsButtonImage.sprite = Resources.Load<Sprite>("Textures/ModeButtons/SkillsButtonDown");
                talentsButtonImage.sprite = Resources.Load<Sprite>("Textures/ModeButtons/TalentsButtonUp");
                SetMode(BuildMode.SKILLS);
                break;
            case "talents":
                characteristicsButtonImage.sprite = Resources.Load<Sprite>("Textures/ModeButtons/CharacteristicsButtonUp");
                skillsButtonImage.sprite = Resources.Load<Sprite>("Textures/ModeButtons/SkillsButtonUp");
                talentsButtonImage.sprite = Resources.Load<Sprite>("Textures/ModeButtons/TalentsButtonDown");
                SetMode(BuildMode.TALENTS);
                break;
            default:
                break;
        }
    }

    public void SetMode(BuildMode buildMode)
    {
        switch(buildMode)
        {
            case (BuildMode.CHARACTERISTICS):
                currentMode = BuildMode.CHARACTERISTICS;
                characteristicsPanel.SetActive(true);
                skillPanel.SetActive(false);
                talentPanel.SetActive(false);
                break;
            case (BuildMode.SKILLS):
                currentMode = BuildMode.SKILLS;
                skillPanel.SetActive(true);
                characteristicsPanel.SetActive(false);
                talentPanel.SetActive(false);
                break;
            case (BuildMode.TALENTS):
                currentMode = BuildMode.TALENTS;
                talentPanel.SetActive(true);
                characteristicsPanel.SetActive(false);
                skillPanel.SetActive(false);
                break;
            default:
                currentMode = BuildMode.CHARACTERISTICS;
                characteristicsPanel.SetActive(true);
                skillPanel.SetActive(false);
                talentPanel.SetActive(false);
                break;
        }
    }

    void SetXP()
    {
        totalXPText.text = CharacterInformation.TotalXP.ToString();
        availXPText.text = CharacterInformation.CurrentAvailXP.ToString();
    }

    void SetCharacteristics()
    {
        brawnText.text = CharacterInformation.Brawn.ToString();
        agilityText.text = CharacterInformation.Agility.ToString();
        intellectText.text = CharacterInformation.Intellect.ToString();
        cunningText.text = CharacterInformation.Cunning.ToString();
        willpowerText.text = CharacterInformation.Willpower.ToString();
        presenceText.text = CharacterInformation.Presence.ToString();
    }

    void SetSkills()
    {
        foreach (BaseSkill skill in CharacterInformation.characterGeneralSkills)
        {
            GameObject skillItem = GameObject.Instantiate(skillPrefab);
            skillItem.transform.SetParent(generalSkillsContentPanel.transform);
            Text skillText = skillItem.transform.FindChild("SkillText").GetComponent<Text>();
            Image careerSocket = skillItem.transform.FindChild("SkillCareerSocketImage").GetComponent<Image>();
            Image rankSocket = skillItem.transform.FindChild("SkillRankSocketImage").GetComponent<Image>();
            Button addRankButton = skillItem.transform.FindChild("AddSkillRankButton").GetComponent<Button>();
            Button removeRankButton = skillItem.transform.FindChild("RemoveSkillRankButton").GetComponent<Button>();

            BaseSkill capturedSkill = skill;

            addRankButton.onClick.AddListener(() => { Debug.Log("Raise " + capturedSkill.SkillName);  AddSkillRank(capturedSkill); SetSkillRank(rankSocket, capturedSkill); });
            removeRankButton.onClick.AddListener(() => { Debug.Log("Lower " + capturedSkill.SkillName); RemoveSkillRank(capturedSkill); SetSkillRank(rankSocket, capturedSkill); });
            skillText.text = skill.SkillName;
            SetSkillCareerOrBonus(careerSocket, skill);
            SetSkillRank(rankSocket, skill);
            
        }
        foreach (BaseSkill skill in CharacterInformation.characterCombatSkills)
        {
            GameObject skillItem = GameObject.Instantiate(skillPrefab);
            Text skillText = skillItem.transform.FindChild("SkillText").GetComponent<Text>();
            Image careerSocket = skillItem.transform.FindChild("SkillCareerSocketImage").GetComponent<Image>();
            Image rankSocket = skillItem.transform.FindChild("SkillRankSocketImage").GetComponent<Image>();
            Button addRankButton = skillItem.transform.FindChild("AddSkillRankButton").GetComponent<Button>();
            Button removeRankButton = skillItem.transform.FindChild("RemoveSkillRankButton").GetComponent<Button>();

            BaseSkill capturedSkill = skill;

            addRankButton.onClick.AddListener(() => { Debug.Log("Raise " + capturedSkill.SkillName); AddSkillRank(capturedSkill); SetSkillRank(rankSocket, capturedSkill); });
            removeRankButton.onClick.AddListener(() => { Debug.Log("Lower " + capturedSkill.SkillName); RemoveSkillRank(capturedSkill); SetSkillRank(rankSocket, capturedSkill); });
            skillText.text = skill.SkillName;
            SetSkillCareerOrBonus(careerSocket, skill);
            SetSkillRank(rankSocket, skill);
            skillItem.transform.SetParent(combatSkillsContentPanel.transform);
        }
        foreach (BaseSkill skill in CharacterInformation.characterKnowledgeSkills)
        {
            GameObject skillItem = GameObject.Instantiate(skillPrefab);
            Text skillText = skillItem.transform.FindChild("SkillText").GetComponent<Text>();
            Image careerSocket = skillItem.transform.FindChild("SkillCareerSocketImage").GetComponent<Image>();
            Image rankSocket = skillItem.transform.FindChild("SkillRankSocketImage").GetComponent<Image>();
            Button addRankButton = skillItem.transform.FindChild("AddSkillRankButton").GetComponent<Button>();
            Button removeRankButton = skillItem.transform.FindChild("RemoveSkillRankButton").GetComponent<Button>();

            BaseSkill capturedSkill = skill;

            addRankButton.onClick.AddListener(() => { Debug.Log("Raise " + capturedSkill.SkillName); AddSkillRank(capturedSkill); SetSkillRank(rankSocket, capturedSkill); });
            removeRankButton.onClick.AddListener(() => { Debug.Log("Lower " + capturedSkill.SkillName); RemoveSkillRank(capturedSkill); SetSkillRank(rankSocket, capturedSkill); });
            skillText.text = skill.SkillName;
            SetSkillCareerOrBonus(careerSocket, skill);
            SetSkillRank(rankSocket, skill);
            skillItem.transform.SetParent(knowledgeSkillsContentPanel.transform);
        }
    }

    void SetTalentTree()
    {
        BaseSpecialization primarySpec = CharacterInformation.characterSpecList[0];

        talentMatrix = new List<List<GameObject>> { };
        int rowID = 0;
        foreach (List<BaseEotETalent> talentRow in primarySpec.TalentMatrix)
        {
            List<GameObject> talentNodeGORow = new List<GameObject> { };
            foreach(BaseEotETalent specTalent in talentRow)
            {
                GameObject talentNode = GameObject.Instantiate(talentNodePrefab);
                Button talentButton = talentNode.GetComponent<Button>();
                Image talentNodeImage = talentNode.transform.FindChild("TalentBG").GetComponent<Image>();
                Text talentNodeLabel = talentNode.transform.FindChild("TalentLabel").GetComponent<Text>();
                
                GameObject talentNodeToggleObj = talentNode.transform.FindChild("Toggle").gameObject;
                Toggle talentNodeToggle = talentNodeToggleObj.GetComponent<Toggle>();
                Text costText = talentNodeToggleObj.transform.FindChild("CostValue").GetComponent<Text>();

                BaseEotETalent capturedTalent = specTalent;
                Image capturedtalentNodeImage = talentNodeImage;
                Text capturedTalentNodeLabel = talentNodeLabel;

                //talentButton.Click += new EventHandler(ActivatePopup);
                talentButton.onClick.AddListener(() => { Debug.Log(capturedTalent.TalentName + " Called for Popup!"); LaunchPopup(capturedTalent); });

                talentNodeToggle.onValueChanged.AddListener((bool toggled) => {
                    
                    if (toggled)
                    {
                        if (CharacterInformation.CurrentAvailXP >= capturedTalent.TalentXPCost)
                        {
                            AddTalent(capturedTalent);
                            RefreshTalents();
                        }
                        else
                        {
                            Debug.Log("Not enough XP to obtain talent");
                        }
                        
                    }
                    
                    else
                    {
                        RemoveTalent(capturedTalent);
                        RefreshTalents();
                    }
                        
                                                            });
                talentNodeLabel.text = specTalent.TalentName;
                costText.text = "Cost:\n" + specTalent.TalentXPCost.ToString();
                SetTalent(talentNodeImage, specTalent, talentNodeToggleObj, talentNodeLabel);
                talentNode.transform.SetParent(talentPanel.transform.GetChild(rowID));
                talentNodeGORow.Add(talentNode);
            }
            rowID++;
            talentMatrix.Add(talentNodeGORow);
        }
        

    }

    void LaunchPopup(BaseEotETalent talent)
    {

        talentPopup.SetActive(true);
        GameObject popUpPanel = GameObject.Find("PopupPanel");
        Text talentNameText = GameObject.Find("TalentNameText").gameObject.GetComponent<Text>();
        Text talentRankedText = GameObject.Find("TalentRankedText").gameObject.GetComponent<Text>();
        Text talentActivationText = GameObject.Find("TalentActivationText").gameObject.GetComponent<Text>();
        Text talentTreesText = GameObject.Find("TalentTreesText").gameObject.GetComponent<Text>();
        Text talentDescriptionText = GameObject.Find("TalentDescriptionText").gameObject.GetComponent<Text>();

        talentNameText.text = talent.TalentName;
        bool IsRanked = talent.RankedTalent;
        string rankedString = "";
        if (IsRanked)
            rankedString = "Yes";
        else
            rankedString = "No";
        talentRankedText.text = rankedString;
        string activationString = "";
        if (talent.TalentActivation == BaseEotETalent.Activation.ACTIVE)
            activationString = "Active";
        else
            activationString = "Passive";
        if (talent.TalentActivationSpec.Count > 0)
        {
            activationString += " (";
            foreach (BaseEotETalent.ActivationSpec activeSpec in talent.TalentActivationSpec)
            {
                switch (activeSpec)
                {
                    case BaseEotETalent.ActivationSpec.ACTION:
                        activationString += "Action";
                        break;
                    case BaseEotETalent.ActivationSpec.INCIDENTAL:
                        activationString += "Incidental";
                        break;
                    case BaseEotETalent.ActivationSpec.MANEUVER:
                        activationString += "Maneuver";
                        break;
                    case BaseEotETalent.ActivationSpec.OUTOFTURN:
                        activationString += "Out of Turn";
                        break;
                    default:
                        break;
                }
                if (talent.TalentActivationSpec.Count > 1 && activeSpec != talent.TalentActivationSpec[talent.TalentActivationSpec.Count - 1])
                {
                    activationString += ", ";
                }
            }
            activationString += ")";
        }
        talentActivationText.text = activationString;
        string talentTreesString = "";
        foreach (BaseEotETalent.Trees tree in talent.TalentTrees)
        {
            string treeName = "";
            switch (tree)
            {
                case BaseEotETalent.Trees.ASSASSIN:
                    treeName = "Assassin";
                    break;
                case BaseEotETalent.Trees.BODYGUARD:
                    treeName = "Bodyguard";
                    break;
                case BaseEotETalent.Trees.DOCTOR:
                    treeName = "Doctor";
                    break;
                case BaseEotETalent.Trees.FORCESENSITIVEEXILE:
                    treeName = "Force Sensitive Exile";
                    break;
                case BaseEotETalent.Trees.FRINGER:
                    treeName = "Fringer";
                    break;
                case BaseEotETalent.Trees.GADGETEER:
                    treeName = "Gadgeteer";
                    break;
                case BaseEotETalent.Trees.MARAUDER:
                    treeName = "Maurader";
                    break;
                case BaseEotETalent.Trees.MECHANIC:
                    treeName = "Mechanic";
                    break;
                case BaseEotETalent.Trees.MERCENARYSOLDIER:
                    treeName = "Mercenary Soldier";
                    break;
                case BaseEotETalent.Trees.NPCONLY:
                    treeName = "NPC Only";
                    break;
                case BaseEotETalent.Trees.OUTLAWTECH:
                    treeName = "Outlaw Tech";
                    break;
                case BaseEotETalent.Trees.PILOT:
                    treeName = "Pilot";
                    break;
                case BaseEotETalent.Trees.POLITICO:
                    treeName = "Politico";
                    break;
                case BaseEotETalent.Trees.SCHOLAR:
                    treeName = "Scholar";
                    break;
                case BaseEotETalent.Trees.SCOUNDREL:
                    treeName = "Scoundrel";
                    break;
                case BaseEotETalent.Trees.SCOUT:
                    treeName = "Scout";
                    break;
                case BaseEotETalent.Trees.SLICER:
                    treeName = "Slicer";
                    break;
                case BaseEotETalent.Trees.SURVIVALIST:
                    treeName = "Survivalist";
                    break;
                case BaseEotETalent.Trees.THIEF:
                    treeName = "Thief";
                    break;
                case BaseEotETalent.Trees.TRADER:
                    treeName = "Trader";
                    break;
                default:
                    break;
            }
            if (talentTreesString == "")
                talentTreesString = treeName;
            else
                talentTreesString += ", " + treeName;
        }
        talentTreesText.text = talentTreesString;
        talentDescriptionText.text = talent.TalentDescription;
        

    }

    void AddTalent(BaseEotETalent talent)
    {
        CharacterInformation.CurrentAvailXP -= talent.TalentXPCost;
        CharacterInformation.TotalXP += talent.TalentXPCost;
        SetXP();
        talent.Obtained = true;
        CharacterInformation.AddTalent(talent);
        
    }

    void RefreshTalents()
    {
        Debug.Log("REFRESHING TALENTS");
        for (int i = 0; i < talentMatrix.Count; i++ )
        {
            for (int j = 0; j < talentMatrix[i].Count; j++ )
            {
                
                Image talentImage = talentMatrix[i][j].transform.FindChild("TalentBG").GetComponent<Image>();
                Text talentName = talentMatrix[i][j].transform.FindChild("TalentLabel").GetComponent<Text>();
                Debug.Log("  Refreshing " + talentName.text);
                GameObject talentToggleGO = talentMatrix[i][j].transform.FindChild("Toggle").gameObject;
                Toggle talentToggle = talentToggleGO.GetComponent<Toggle>();
                Text talentCost = talentMatrix[i][j].transform.FindChild("TalentLabel").GetComponent<Text>();
                BaseEotETalent specTalent = CharacterInformation.characterSpecList[0].TalentMatrix[i][j];
                SetTalent(talentImage, specTalent, talentToggleGO, talentName);

            }
        }
    }

    void RemoveTalent(BaseEotETalent talent)
    {
        CharacterInformation.CurrentAvailXP += talent.TalentXPCost;
        CharacterInformation.TotalXP -= talent.TalentXPCost;
        SetXP();
        talent.Obtained = false;
        CharacterInformation.RemoveTalent(talent);
        
        //Debug.Log("Add remove talent method");
    }

    void AddSkillRank(BaseSkill skill)
    {
        int rankCost = 0;
        if (skill.IsCareerSkill || skill.IsCareerBonusSkill)
        {
            rankCost = 5 * (skill.SkillRank + 1);
        }
        else
        {
            rankCost = 10 * (skill.SkillRank + 1);
        }

        if ((skill.SkillRank + 1) < 3)
        {
            if (CharacterInformation.CurrentAvailXP >= rankCost)
            {
                CharacterInformation.CurrentAvailXP -= rankCost;
                CharacterInformation.TotalXP += rankCost;
                SetXP();
                skill.SkillRank++;
            }

            else
            {
                Debug.Log("Not enough XP to increase rank.");
            }
        }
        else
        {
            Debug.Log("Cannot exceed Skill Rank 2 in initial character build.");
        }

        
        
    }

    public void HideTalentPopupPanel()
    {
        talentPopup.SetActive(false);
    }

    void RemoveSkillRank(BaseSkill skill)
    {
        int rankCost = 0;
        if (skill.IsCareerSkill || skill.IsCareerBonusSkill)
        {
            rankCost = 5 * (skill.SkillRank);
        }
        else
        {
            rankCost = 10 * (skill.SkillRank);
        }

        if (skill.SkillRank > skill.MinSkillRank)
        {
            CharacterInformation.CurrentAvailXP += rankCost;
            CharacterInformation.TotalXP -= rankCost;
            SetXP();
            skill.SkillRank--;
        }
        else
        {
            Debug.Log("Cannot lower " + skill.SkillName + " lower than its combined species/career minimum.");
        }
    }

    void SetSkillCareerOrBonus(Image image, BaseSkill skill)
    {
        if (skill.IsCareerSkill)
        {
            image.sprite = Resources.Load<Sprite>("Textures/Skill/Career/CareerSkill");

            if(skill.IsCareerBonusSkill)
            {
                image.sprite = Resources.Load<Sprite>("Textures/Skill/Career/CareerAndBonusSkill");
            }

        }
        else if(skill.IsCareerBonusSkill)
        {
            image.sprite = Resources.Load<Sprite>("Textures/Skill/Career/BonusSkill");
        }
        else
        {
            image.sprite = Resources.Load<Sprite>("Textures/Skill/Career/NotCareer");
        }
    }

    void SetSkillRank(Image image, BaseSkill skill)
    {
        switch (skill.SkillRank)
        {
            case 1:
                image.sprite = Resources.Load<Sprite>("Textures/Skill/Rank/SkillRanks1");
                break;
            case 2:
                image.sprite = Resources.Load<Sprite>("Textures/Skill/Rank/SkillRanks2");
                break;
            case 3:
                image.sprite = Resources.Load<Sprite>("Textures/Skill/Rank/SkillRanks3");
                break;
            case 4:
                image.sprite = Resources.Load<Sprite>("Textures/Skill/Rank/SkillRanks4");
                break;
            case 5:
                image.sprite = Resources.Load<Sprite>("Textures/Skill/Rank/SkillRanks5");
                break;
            default:
                image.sprite = Resources.Load<Sprite>("Textures/Skill/Rank/SkillRanksBlank");
                break;
        }
    }

    int FindCharacteristicValue(string characteristic)
    {
        switch (characteristic)
        {
            case "brawn":
                return CharacterInformation.Brawn;
            case "agility":
                return CharacterInformation.Agility;
            case "intellect":
                return CharacterInformation.Intellect;
            case "cunning":
                return CharacterInformation.Cunning;
            case "willpower":
                return CharacterInformation.Willpower;
            case "presence":
                return CharacterInformation.Presence;
            default:
                return 0;
        }
    }

    int FindCharacteristicMinimum(string characteristic)
    {
        int speciesMin = 0;
        int charMin = 0;
        switch (characteristic)
        {
            case "brawn":
                speciesMin = CharacterInformation.CharacterSpecies.MinBrawn;
                break;
            case "agility":
                speciesMin = CharacterInformation.CharacterSpecies.MinAgility;
                break;
            case "intellect":
                speciesMin = CharacterInformation.CharacterSpecies.MinIntellect;
                break;
            case "cunning":
                speciesMin = CharacterInformation.CharacterSpecies.MinCunning;
                break;
            case "willpower":
                speciesMin = CharacterInformation.CharacterSpecies.MinWillpower;
                break;
            case "presence":
                speciesMin = CharacterInformation.CharacterSpecies.MinPresence;
                break;
            default:
                break;
        }
        charMin = speciesMin;
        return charMin;
    }

    public void AddCharacteristicValue(string characteristic)
    {
        int curCharValue = 0;
        int nextCharValue = 0;
        int charCost = 0;
        
        //BaseSkill.SkillCharacteristic charType;

        curCharValue = FindCharacteristicValue(characteristic);

        nextCharValue = curCharValue + 1;
        charCost = nextCharValue * 10;

        if (CharacterInformation.CurrentAvailXP >= charCost && nextCharValue < 6)
        {
            // Increase Characteristic
            CharacterInformation.CurrentAvailXP -= charCost;
            CharacterInformation.TotalXP += charCost;
            SetXP();
            IncreaseCharacteristic(characteristic);

            // Refresh Characteristic Sheet
            SetCharacteristics();
        }

        else
        {
            Debug.LogWarning("Not enough XP to increase characteristic.");
        }

    }

    public void RemoveCharacteristicValue(string characteristic)
    {
        int curCharValue = 0;
        int prevCharValue = 0;
        int charCost = 0;
        int minCharacteristic = 0;

        curCharValue = FindCharacteristicValue(characteristic);

        prevCharValue = curCharValue - 1;
        charCost = curCharValue * 10;

        minCharacteristic = FindCharacteristicMinimum(characteristic);

        if(curCharValue > minCharacteristic)
        {
            CharacterInformation.CurrentAvailXP += charCost;
            CharacterInformation.TotalXP -= charCost;
            SetXP();
            DecreaseCharacteristic(characteristic);

            // Refresh Characteristic Sheet
            SetCharacteristics();
        }

        else
        {
            Debug.LogWarning("Cannot lower characteristic any further for current species/career.");
        }

    }

    void IncreaseCharacteristic(string characteristic)
    {
        switch (characteristic)
        {
            case "brawn":
                CharacterInformation.Brawn++;
                break;
            case "agility":
                CharacterInformation.Agility++;
                break;
            case "intellect":
                CharacterInformation.Intellect++;
                break;
            case "cunning":
                CharacterInformation.Cunning++;
                break;
            case "willpower":
                CharacterInformation.Willpower++;
                break;
            case "presence":
                CharacterInformation.Presence++;
                break;
            default:
                break;
        }

    }

    void DecreaseCharacteristic(string characteristic)
    {
        switch (characteristic)
        {
            case "brawn":
                CharacterInformation.Brawn--;
                break;
            case "agility":
                CharacterInformation.Agility--;
                break;
            case "intellect":
                CharacterInformation.Intellect--;
                break;
            case "cunning":
                CharacterInformation.Cunning--;
                break;
            case "willpower":
                CharacterInformation.Willpower--;
                break;
            case "presence":
                CharacterInformation.Presence--;
                break;
            default:
                break;
        }
    }

    void CheckChildrenObtained(BaseEotETalent talent)
    {
        //bool obtainedChild = false;
        //bool obtainedParent = false;
        Debug.Log("Current Talent: " + talent.TalentName + ";");
        //Debug.Log("Child Talent: " + talent.ChildTalents[0].TalentName + ";");

        //talent.IsDeep = talent.Obtained;

        /*if(!talent.IsRoot)
        {
            for (int i = 0; i < talent.ParentTalents.Count; i++)
            {
                if (talent.ParentTalents[i].Obtained)
                {
                        obtainedParent = true;
                }
            }
        }*/
       
        if (talent.ChildTalents.Count == 0)
        {
            // If the talent is the last leaf on the tree, leave it interactable
            talent.IsDeep = false;
        }
        else
        {
            for (int i = 0; i < talent.ChildTalents.Count; i++)
            {
                if (!talent.ChildTalents[i].Obtained)
                {
                    talent.IsDeep = false;
                    return;
                }
                if (talent.ChildTalents.Count > 1)
                {
                    for (int j = 0; j < talent.ChildTalents[i].ParentTalents.Count; j++)
                    {
                        if (talent.ChildTalents[i].ParentTalents[j].Obtained && talent.ChildTalents[i].ParentTalents[j] != talent)
                        {
                            talent.IsDeep = false;
                            return;
                        }
                    }
                }
                
            }
            
            talent.IsDeep = talent.Obtained;
        }
        /*for (int i = 0; i < talent.ChildTalents.Count; i++)
        {
            Debug.Log("  Talent Child Being Checked: " + talent.ChildTalents[i]);
            if (!talent.ChildTalents[i].Obtained)
            {
                talent.IsDeep = false;
            }
            else
            {
                if(!talent.IsRoot)
                {
                    for (int j = 0; j < talent.ParentTalents.Count; j++)
                    {
                        if (talent.ParentTalents[j].Obtained)
                        {
                            if (talent.ParentTalents[j] != talent.ChildTalents[i])
                            {
                                obtainedParent = true;
                            }

                        }
                    }
                }
                obtainedChild = true;
                                
            }
        }
        if(obtainedChild && obtainedParent && talent.Obtained)
        {
            talent.IsDeep = true;
        }*/
    }

    bool CheckTalentUnlocked(BaseEotETalent talent, GameObject talentToggle, Text talentLabel)
    {
        Debug.Log("Checking lock status on " + talent.TalentName);

        /*if (CharacterInformation.CurrentAvailXP >= talent.TalentXPCost && !talent.Obtained)
        {
            talentToggle.GetComponent<Toggle>().interactable = false;
        }*/
        CheckChildrenObtained(talent);

        if (talent.IsDeep)
        {
            talentToggle.GetComponent<Toggle>().interactable = false;
        }
        else
        {
            talentToggle.GetComponent<Toggle>().interactable = true;
        }
        if (talent.IsRoot)
        {
            talentToggle.SetActive(true);
            return true;
        }
        else
        {
            //Debug.Log("TEST: " + talent.ParentTalents[0].Obtained);
            //Debug.Log("Parent Talents: " + talent.ParentTalents.Count);
            //int parentsObtained = 0;
            for (int i = 0; i < talent.ParentTalents.Count; i++ )
            {
                //Debug.Log(t.Obtained);
                //Debug.Log(i);
                //Debug.Log("Talent: " + talent.TalentName + " Checking Parent: " + talent.ParentTalents[0].TalentName);
                //Debug.Log(talent.ParentTalents[0].Obtained);
                //Debug.Log("WHY???? " + talent.ParentTalents[i].TalentName);
                

                if (talent.ParentTalents[i].Obtained)
                {
                    talent.Unlocked = true;
                    talentToggle.SetActive(true);
                    return true;
                }
            }

            talentToggle.SetActive(false);
            talent.Unlocked = false;
            return false;
        }
        
    }

    void SetTalent(Image image, BaseEotETalent talent, GameObject talentToggle, Text talentLabel)
    {


        if (CheckTalentUnlocked(talent, talentToggle, talentLabel))
        {
            if(talent.TalentActivation == BaseEotETalent.Activation.ACTIVE)
            {
                image.sprite = Resources.Load<Sprite>("Textures/Talent/TalentActive");
            }
            else
            {
                image.sprite = Resources.Load<Sprite>("Textures/Talent/TalentPassive");
            }
        }
        else
        {
            image.sprite = Resources.Load<Sprite>("Textures/Talent/TalentLocked");
        }
        
    }

}
