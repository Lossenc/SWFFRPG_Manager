using UnityEngine;
using System.Collections;

public class AmmoniaRespirator : BaseGear {

	public AmmoniaRespirator()
    {
        ItemName = "Ammonia Respirator";
        ItemDescription = "A respirator specifically designed for Gands who are born with lungs. Gands cannot normally survive in an " +
                          "oxygen atmosphere, so these devices enable one to breathe natually. Lunged Gands treat oxygen as a dangerous " +
                          "atmosphere with Rating 8.";
        Price = 0;
        Encumbrance = 1;
        Rarity = 1;
    }
}

public class ImperialPeaceKeepingCertificate : BaseGear
{

    public ImperialPeaceKeepingCertificate()
    {
        ItemName = "Imperial Peace Keeping Certificate";
        ItemDescription = "A license issued by the Empire, legitimizing the business of the Bounty Hunter. A Bounty Hunter retains this " +
                          "license to prevent being labeled little more than a kidnapper and, possibly, a murderer. All new Bounty Hunter " +
                          "characters start with one unless they choose to do without it for storytelling purposes.";
        Price = 0;
        Encumbrance = 0;
        Rarity = 0;
    }
}
