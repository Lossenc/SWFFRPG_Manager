using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BaseSpecialization {

	private string specName;
    private string specDescription;
    private BaseEotECareer.EotECareers specCareer;
    private List<BaseEotECareer.EotESkills> specSkills;
    private List<List<BaseEotETalent>> talentMatrix;
    private BaseEotETalent talentA1;
    private BaseEotETalent talentA2;
    private BaseEotETalent talentA3;
    private BaseEotETalent talentA4;
    private BaseEotETalent talentB1;
    private BaseEotETalent talentB2;
    private BaseEotETalent talentB3;
    private BaseEotETalent talentB4;
    private BaseEotETalent talentC1;
    private BaseEotETalent talentC2;
    private BaseEotETalent talentC3;
    private BaseEotETalent talentC4;
    private BaseEotETalent talentD1;
    private BaseEotETalent talentD2;
    private BaseEotETalent talentD3;
    private BaseEotETalent talentD4;
    private BaseEotETalent talentE1;
    private BaseEotETalent talentE2;
    private BaseEotETalent talentE3;
    private BaseEotETalent talentE4;

    private List<string> specializationList = new List<string> { };
    public List<string> SpecializationList
    {
        get { return specializationList; }
        set { specializationList = value; }
    }

    public string SpecName
    {
        get { return specName; }
        set { specName = value; }
    }

    public string SpecDescription
    {
        get { return specDescription; }
        set { specDescription = value; }
    }

    public List<List<BaseEotETalent>> TalentMatrix
    {
        get { return talentMatrix; }
        set { talentMatrix = value; }
    }

    public BaseEotECareer.EotECareers SpecCareer
    {
        get { return specCareer; }
        set { specCareer = value; }
    }

    public List<BaseEotECareer.EotESkills> SpecSkills
    {
        get { return specSkills; }
        set { specSkills = value; }
    }

    public BaseEotETalent TalentA1
    {
        get { return talentA1; }
        set { talentA1 = value; }
    }

    public BaseEotETalent TalentA2
    {
        get { return talentA2; }
        set { talentA2 = value; }
    }

    public BaseEotETalent TalentA3
    {
        get { return talentA3; }
        set { talentA3 = value; }
    }

    public BaseEotETalent TalentA4
    {
        get { return talentA4; }
        set { talentA4 = value; }
    }

    public BaseEotETalent TalentB1
    {
        get { return talentB1; }
        set { talentB1 = value; }
    }

    public BaseEotETalent TalentB2
    {
        get { return talentB2; }
        set { talentB2 = value; }
    }

    public BaseEotETalent TalentB3
    {
        get { return talentB3; }
        set { talentB3 = value; }
    }

    public BaseEotETalent TalentB4
    {
        get { return talentB4; }
        set { talentB4 = value; }
    }

    public BaseEotETalent TalentC1
    {
        get { return talentC1; }
        set { talentC1 = value; }
    }

    public BaseEotETalent TalentC2
    {
        get { return talentC2; }
        set { talentC2 = value; }
    }

    public BaseEotETalent TalentC3
    {
        get { return talentC3; }
        set { talentC3 = value; }
    }

    public BaseEotETalent TalentC4
    {
        get { return talentC4; }
        set { talentC4 = value; }
    }

    public BaseEotETalent TalentD1
    {
        get { return talentD1; }
        set { talentD1 = value; }
    }

    public BaseEotETalent TalentD2
    {
        get { return talentD2; }
        set { talentD2 = value; }
    }

    public BaseEotETalent TalentD3
    {
        get { return talentD3; }
        set { talentD3 = value; }
    }

    public BaseEotETalent TalentD4
    {
        get { return talentD4; }
        set { talentD4 = value; }
    }

    public BaseEotETalent TalentE1
    {
        get { return talentE1; }
        set { talentE1 = value; }
    }

    public BaseEotETalent TalentE2
    {
        get { return talentE2; }
        set { talentE2 = value; }
    }

    public BaseEotETalent TalentE3
    {
        get { return talentE3; }
        set { talentE3 = value; }
    }

    public BaseEotETalent TalentE4
    {
        get { return talentE4; }
        set { talentE4 = value; }
    }

}
