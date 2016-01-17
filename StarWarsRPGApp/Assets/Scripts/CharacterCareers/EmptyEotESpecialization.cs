using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EmptyEotESpecialization : BaseSpecialization
{

    public EmptyEotESpecialization()
    {
        SpecName = "???";
        SpecCareer = BaseEotECareer.EotECareers.UNIVERSAL;
        SpecSkills = new List<BaseEotECareer.EotESkills> {};
    }

}