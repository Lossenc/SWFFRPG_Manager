using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SkillObject : MonoBehaviour {

    public bool isCareer = false;
    public int rank = 0;

    public Sprite careerSkillSprite;
    public Sprite careerBonusSkillSprite;
    public Sprite careerAndBonusSkillSprite;
    public Sprite notCareerSkillSprite;
    public Sprite skillRankZeroSprite;
    public Sprite skillRankOneSprite;
    public Sprite skillRankTwoSprite;
    public Sprite skillRankThreeSprite;
    public Sprite skillRankFourSprite;
    public Sprite skillRankFiveSprite;

    public Image careerSkillImage;
    public Image skillRankImage;
    public Text skillText;

    void Start()
    {
        //careerSkillImage = gameObject.transform.Find("CareerSkillImage").GetComponent<Image>();
        //skillRankImage = gameObject.transform.Find("SkillRankImage").GetComponent<Image>();
    }

	void Update()
    {
        
    }

    public void SetSkill(BaseSkill skillToSet)
    {
        if (skillToSet.IsCareerSkill)
        {
            if (skillToSet.IsCareerBonusSkill)
            {
                careerSkillImage.sprite = careerAndBonusSkillSprite;
            }
            else
            {
                careerSkillImage.sprite = careerSkillSprite;
            }
            
        }
        else if (skillToSet.IsCareerBonusSkill)
        {
            careerSkillImage.sprite = careerBonusSkillSprite;
        }
        else
        {
            careerSkillImage.sprite = notCareerSkillSprite;
        }
        switch (skillToSet.MinSkillRank)
        {
            case 1:
                skillRankImage.sprite = skillRankOneSprite;
                break;
            case 2:
                skillRankImage.sprite = skillRankTwoSprite;
                break;
            case 3:
                skillRankImage.sprite = skillRankThreeSprite;
                break;
            case 4:
                skillRankImage.sprite = skillRankFourSprite;
                break;
            case 5:
                skillRankImage.sprite = skillRankFiveSprite;
                break;
            default:
                skillRankImage.sprite = skillRankZeroSprite;
                break;
        }
        string skillStatString = "";
        switch(skillToSet.SkillStat)
        {
            case BaseSkill.SkillCharacteristic.AGILITY:
                skillStatString = "(Ag)";
                break;
            case BaseSkill.SkillCharacteristic.BRAWN:
                skillStatString = "(Br)";
                break;
            case BaseSkill.SkillCharacteristic.CUNNING:
                skillStatString = "(Cu)";
                break;
            case BaseSkill.SkillCharacteristic.INTELLECT:
                skillStatString = "(Int)";
                break;
            case BaseSkill.SkillCharacteristic.PRESENCE:
                skillStatString = "(Pr)";
                break;
            case BaseSkill.SkillCharacteristic.WILLPOWER:
                skillStatString = "(Will)";
                break;
            default:
                break;
        }
        //Debug.Log(skillToSet.SkillName);
        //Debug.Log(skillStatString);
        skillText.text = skillToSet.SkillName + " " + skillStatString;
    }

    public void AddRank()
    {

    }

    public void RemoveRank()
    {

    }
}
