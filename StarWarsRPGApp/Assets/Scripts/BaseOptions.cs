using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BaseOptions : MonoBehaviour {

    private LevelManager levelManager;
    private Dropdown baseGameDropdown;
    private Toggle mainEotEToggle;
    //private Toggle mainAoRToggle;
    //private Toggle mainFaDToggle;
    private Toggle addonEotEEtUToggle;
    private Toggle addonEotESoFToggle;
    private Toggle addonEotEDCToggle;
    private Toggle addonEotEFHToggle;
    private Toggle addonEotELoNHToggle;
    private Toggle addonEotEFCToggle;
    private GameObject characterInformationObject;

    void Start()
    {
        levelManager = GameObject.Find("LevelManager").GetComponent<LevelManager>();
        baseGameDropdown = GameObject.Find("BaseGameDropdown").GetComponent<Dropdown>();
        mainEotEToggle = GameObject.Find("EdgeOfTheEmpireToggle").GetComponent<Toggle>();
        //mainAoRToggle = GameObject.Find("AgeOfRebellionToggle").GetComponent<Toggle>();
        //mainFaDToggle = GameObject.Find("ForceAndDestinyToggle").GetComponent<Toggle>();
        addonEotEEtUToggle = GameObject.Find("EnterTheUnknownToggle").GetComponent<Toggle>();
        addonEotESoFToggle = GameObject.Find("SunsOfFortuneToggle").GetComponent<Toggle>();
        addonEotEDCToggle = GameObject.Find("DangerousCovenantsToggle").GetComponent<Toggle>();
        addonEotEFHToggle = GameObject.Find("FarHorizonsToggle").GetComponent<Toggle>();
        addonEotELoNHToggle = GameObject.Find("LordsOfNalHuttaToggle").GetComponent<Toggle>();
        addonEotEFCToggle = GameObject.Find("FlyCasualToggle").GetComponent<Toggle>();
        characterInformationObject = GameObject.Find("CharacterInformation");
    }

    public bool SaveBaseOptions()
    {
        if (baseGameDropdown.value != 0)
        {
            CharacterInformation.BaseGame = baseGameDropdown.options[baseGameDropdown.value].text;

            CharacterInformation.ContentEotEMain = mainEotEToggle.isOn;
            //CharacterInformation.ContentAoRMain = mainEotEToggle.isOn;
            //CharacterInformation.ContentFaDMain = mainEotEToggle.isOn;
            CharacterInformation.ContentEotEEtU = addonEotEEtUToggle.isOn;
            CharacterInformation.ContentEotESoF = addonEotESoFToggle.isOn;
            CharacterInformation.ContentEotEDC = addonEotEDCToggle.isOn;
            CharacterInformation.ContentEotEFH = addonEotEFHToggle.isOn;
            CharacterInformation.ContentEotELoNH = addonEotELoNHToggle.isOn;
            CharacterInformation.ContentEotEFC = addonEotEFCToggle.isOn;
            return true;
        }
        else
        {
            Debug.LogWarning("Please select a Base Game before continuing.");
            return false;
        }
    }

    public void CheckBaseGame(int baseID)
    {
        switch (baseID)
        {
            case 1:
                mainEotEToggle.interactable = true;
                mainEotEToggle.isOn = true;
                mainEotEToggle.interactable = false;
                //mainAoRToggle.interactable = true;
                //mainFaDToggle.interactable = true;
                break;
            case 2:
                //mainAoRToggle.interactable = true;
                //mainAoRToggle.isOn = true;
                //mainAoRToggle.interactable = false;
                mainEotEToggle.interactable = true;
                //mainFaDToggle.interactable = true;
                break;
            case 3:
                //mainFaDToggle.interactable = true;
                //mainFaDToggle.isOn = true;
                //mainFaDToggle.interactable = false;
                mainEotEToggle.interactable = true;
                //mainAoRToggle.interactable = true;
                break;
            default:
                break;
        }

        if (!mainEotEToggle.isOn)
        {
            addonEotEEtUToggle.isOn = false;
            addonEotESoFToggle.isOn = false;
            addonEotEDCToggle.isOn = false;
            addonEotEFHToggle.isOn = false;
            addonEotELoNHToggle.isOn = false;
            addonEotEFCToggle.isOn = false;
        }
    }

    public void NextButton()
    {
        if (SaveBaseOptions())
        {
            levelManager.LoadLevel("2_NameSpecies");
        }
    }

    public void BackButton()
    {        
        if (characterInformationObject)
        {
            Destroy(characterInformationObject.gameObject);
        }
        levelManager.LoadLevel("0_StartScreen");
    }
}
