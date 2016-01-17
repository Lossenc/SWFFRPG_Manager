using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EmptyEotECareer : BaseEotECareer
{

    public EmptyEotECareer()
    {
        CareerName = "???";
        CareerDescription = "Career description goes here... ";
        CareerSkills = new List<EotESkills> {};
    }

}