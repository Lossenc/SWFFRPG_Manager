using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/*BEGINNING OF TABLE 4-1: TALENT LIST Page 1*/

public class AdversaryTalent : BaseEotETalent {

    public AdversaryTalent()
    {
        TalentName = "Adversary";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.NPCONLY };
        TalentDescription = "Upgrade the difficulty of any combat check targeting this character once per rank of Adversary";
    }
    public AdversaryTalent(bool root, int xpCost)
    {
        TalentName = "Adversary";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.NPCONLY };
        TalentDescription = "Upgrade the difficulty of any combat check targeting this character once per rank of Adversary";
        IsRoot = root;
        TalentXPCost = xpCost;
    }
    public AdversaryTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Adversary";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.NPCONLY };
        TalentDescription = "Upgrade the difficulty of any combat check targeting this character once per rank of Adversary";
        ParentTalents = parents;
        TalentXPCost = xpCost;
    }
}

public class AnatomyLessonsTalent : BaseEotETalent
{

    public AnatomyLessonsTalent()
    {
        TalentName = "Anatomy Lessons";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec>{ ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.ASSASSIN, Trees.DOCTOR };
        TalentDescription = "After a successful attack with a non-starship/vehicle weapon, the character may spend one Destiny Point to add damage equal to his Intellect to one hit of the attack";
    }
    public AnatomyLessonsTalent(bool root, int xpCost)
    {
        TalentName = "Anatomy Lessons";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.ASSASSIN, Trees.DOCTOR };
        TalentDescription = "After a successful attack with a non-starship/vehicle weapon, the character may spend one Destiny Point to add damage equal to his Intellect to one hit of the attack";
        IsRoot = root;
        TalentXPCost = xpCost;
    }
    public AnatomyLessonsTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Anatomy Lessons";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.ASSASSIN, Trees.DOCTOR };
        TalentDescription = "After a successful attack with a non-starship/vehicle weapon, the character may spend one Destiny Point to add damage equal to his Intellect to one hit of the attack";
        ParentTalents = parents;
        TalentXPCost = xpCost;
    }
}

public class ArmorMasterTalent : BaseEotETalent
{

    public ArmorMasterTalent()
    {
        TalentName = "Armor Master";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.GADGETEER };
        TalentDescription = "When wearing armor, the character increases his total soak value by one.";
    }
    public ArmorMasterTalent(bool root, int xpCost)
    {
        TalentName = "Armor Master";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.GADGETEER };
        TalentDescription = "When wearing armor, the character increases his total soak value by one.";
        IsRoot = root;
        TalentXPCost = xpCost;
    }
    public ArmorMasterTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Armor Master";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.GADGETEER };
        TalentDescription = "When wearing armor, the character increases his total soak value by one.";
        ParentTalents = parents;
        TalentXPCost = xpCost;
    }
}

public class ArmorMasterImprovedTalent : BaseEotETalent
{

    public ArmorMasterImprovedTalent()
    {
        TalentName = "Armor Master (Improved)";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.GADGETEER };
        TalentDescription = "When wearing armor with a soak value of two or higher, the character increases his defense by one.";
        
    }
    public ArmorMasterImprovedTalent(bool root, int xpCost)
    {
        TalentName = "Armor Master (Improved)";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.GADGETEER };
        TalentDescription = "When wearing armor with a soak value of two or higher, the character increases his defense by one.";
        IsRoot = root;
        TalentXPCost = xpCost;
    }
    public ArmorMasterImprovedTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Armor Master (Improved)";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.GADGETEER };
        TalentDescription = "When wearing armor with a soak value of two or higher, the character increases his defense by one.";
        ParentTalents = parents;
        TalentXPCost = xpCost;
    }
}

public class BactaSpecialistTalent : BaseEotETalent
{

    public BactaSpecialistTalent()
    {
        TalentName = "Bacta Specialist";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.DOCTOR };
        TalentDescription = "Patients under the character's supervision heal one additional wound per rank of Bacta Specialist each time they heal a wound while recovering in a Bacta tank or under supervised medical conditions or long-term care.";
    }
    public BactaSpecialistTalent(bool root, int xpCost)
    {
        TalentName = "Bacta Specialist";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.DOCTOR };
        TalentDescription = "Patients under the character's supervision heal one additional wound per rank of Bacta Specialist each time they heal a wound while recovering in a Bacta tank or under supervised medical conditions or long-term care.";
        IsRoot = root;
        TalentXPCost = xpCost;
    }
    public BactaSpecialistTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Bacta Specialist";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.DOCTOR };
        TalentDescription = "Patients under the character's supervision heal one additional wound per rank of Bacta Specialist each time they heal a wound while recovering in a Bacta tank or under supervised medical conditions or long-term care.";
        ParentTalents = parents;
        TalentXPCost = xpCost;
    }
}

public class BadMotivatorTalent : BaseEotETalent
{

    public BadMotivatorTalent()
    {
        TalentName = "Bad Motivator";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec>{ ActivationSpec.ACTION };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.MECHANIC };
        TalentDescription = "Once per game session, the character may take a Bad Motivator action to make a Hard [3 Difficulty] Mechanics check. If successful, one device (subject to the GM's approval) spontaneously fails due to the character's involvement, or because it was about to fail anyway and the character noticed it. (this is the character's decision)";
        
    }
    public BadMotivatorTalent(bool root, int xpCost)
    {
        TalentName = "Bad Motivator";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.ACTION };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.MECHANIC };
        TalentDescription = "Once per game session, the character may take a Bad Motivator action to make a Hard [3 Difficulty] Mechanics check. If successful, one device (subject to the GM's approval) spontaneously fails due to the character's involvement, or because it was about to fail anyway and the character noticed it. (this is the character's decision)";
        IsRoot = root;
        TalentXPCost = xpCost;
    }
    public BadMotivatorTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Bad Motivator";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.ACTION };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.MECHANIC };
        TalentDescription = "Once per game session, the character may take a Bad Motivator action to make a Hard [3 Difficulty] Mechanics check. If successful, one device (subject to the GM's approval) spontaneously fails due to the character's involvement, or because it was about to fail anyway and the character noticed it. (this is the character's decision)";
        ParentTalents = parents;
        TalentXPCost = xpCost;
    }
}

public class BalanceTalent : BaseEotETalent
{

    public BalanceTalent()
    {
        TalentName = "Balance";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.MANEUVER };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.FORCESENSITIVEEXILE };
        TalentDescription = "When the character recovers from strain at the end of each encounter, he may roll his Force rating in Force dice. He recovers additional strain equal to the [Light Side] rolled.";
    }
    public BalanceTalent(bool root, int xpCost)
    {
        TalentName = "Balance";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.MANEUVER };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.FORCESENSITIVEEXILE };
        TalentDescription = "When the character recovers from strain at the end of each encounter, he may roll his Force rating in Force dice. He recovers additional strain equal to the [Light Side] rolled.";
        IsRoot = root;
        TalentXPCost = xpCost;
    }
    public BalanceTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Balance";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.MANEUVER };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.FORCESENSITIVEEXILE };
        TalentDescription = "When the character recovers from strain at the end of each encounter, he may roll his Force rating in Force dice. He recovers additional strain equal to the [Light Side] rolled.";
        ParentTalents = parents;
        TalentXPCost = xpCost;
    }
}

public class BarrageTalent : BaseEotETalent
{

    public BarrageTalent()
    {
        TalentName = "Barrage";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.BODYGUARD };
        TalentDescription = "Add one damage per rank of Barrage to one hit of successful Ranged (Heavy) or Gunnery attacks with non-starship/vehicle weapons at long or extreme range.";
    }
    public BarrageTalent(bool root, int xpCost)
    {
        TalentName = "Barrage";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.BODYGUARD };
        TalentDescription = "Add one damage per rank of Barrage to one hit of successful Ranged (Heavy) or Gunnery attacks with non-starship/vehicle weapons at long or extreme range.";
        IsRoot = root;
        TalentXPCost = xpCost;
    }
    public BarrageTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Barrage";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.BODYGUARD };
        TalentDescription = "Add one damage per rank of Barrage to one hit of successful Ranged (Heavy) or Gunnery attacks with non-starship/vehicle weapons at long or extreme range.";
        ParentTalents = parents;
        TalentXPCost = xpCost;
    }
}

public class BlackMarketContactsTalent : BaseEotETalent
{

    public BlackMarketContactsTalent()
    {
        TalentName = "Black Market Contacts";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.SCOUNDREL, Trees.THIEF, Trees.TRADER };
        TalentDescription = "When looking to purchase illegal, exotic, or black market goods, the character may decrease an item's rarity by one level per rank in Black Market Contacts. For each level an item's rarity is decreased, its cost increases by 50% of its base cost.";
    }
    public BlackMarketContactsTalent(bool root, int xpCost)
    {
        TalentName = "Black Market Contacts";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.SCOUNDREL, Trees.THIEF, Trees.TRADER };
        TalentDescription = "When looking to purchase illegal, exotic, or black market goods, the character may decrease an item's rarity by one level per rank in Black Market Contacts. For each level an item's rarity is decreased, its cost increases by 50% of its base cost.";
        IsRoot = root;
        TalentXPCost = xpCost;
    }
    public BlackMarketContactsTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Black Market Contacts";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.SCOUNDREL, Trees.THIEF, Trees.TRADER };
        TalentDescription = "When looking to purchase illegal, exotic, or black market goods, the character may decrease an item's rarity by one level per rank in Black Market Contacts. For each level an item's rarity is decreased, its cost increases by 50% of its base cost.";
        ParentTalents = parents;
        TalentXPCost = xpCost;
    }
}

public class BloodedTalent : BaseEotETalent
{

    public BloodedTalent()
    {
        TalentName = "Blooded";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.SURVIVALIST };
        TalentDescription = "Add [Boost] per rank of Blooded to all checks to resist or recover from the effects of poisons, venoms, and other toxins. Reduce the duration of any related ongoing effects or damage from toxins, venoms, or poisons by one round per rank of Blooded to a minimum of one.";
    }
    public BloodedTalent(bool root, int xpCost)
    {
        TalentName = "Blooded";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.SURVIVALIST };
        TalentDescription = "Add [Boost] per rank of Blooded to all checks to resist or recover from the effects of poisons, venoms, and other toxins. Reduce the duration of any related ongoing effects or damage from toxins, venoms, or poisons by one round per rank of Blooded to a minimum of one.";
        IsRoot = root;
        TalentXPCost = xpCost;
    }
    public BloodedTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Blooded";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.SURVIVALIST };
        TalentDescription = "Add [Boost] per rank of Blooded to all checks to resist or recover from the effects of poisons, venoms, and other toxins. Reduce the duration of any related ongoing effects or damage from toxins, venoms, or poisons by one round per rank of Blooded to a minimum of one.";
        ParentTalents = parents;
        TalentXPCost = xpCost;
    }
}

public class BodyGuardTalent : BaseEotETalent
{

    public BodyGuardTalent()
    {
        TalentName = "Body Guard";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.MANEUVER };
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.BODYGUARD };
        TalentDescription = "Once per round on the character's turn, the character may perform a Body Guard maneuver to protect one ally he is engaged with. He then suffers a number of strain no greater than his ranks in Body Guard. Until the start of the character's next turn, upgrade the difficulty of all combat checks targeting the protected ally a number of times equal to the strain suffered by the character.";
    }
    public BodyGuardTalent(bool root, int xpCost)
    {
        TalentName = "Body Guard";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.MANEUVER };
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.BODYGUARD };
        TalentDescription = "Once per round on the character's turn, the character may perform a Body Guard maneuver to protect one ally he is engaged with. He then suffers a number of strain no greater than his ranks in Body Guard. Until the start of the character's next turn, upgrade the difficulty of all combat checks targeting the protected ally a number of times equal to the strain suffered by the character.";
        IsRoot = root;
        TalentXPCost = xpCost;
    }
    public BodyGuardTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Body Guard";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.MANEUVER };
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.BODYGUARD };
        TalentDescription = "Once per round on the character's turn, the character may perform a Body Guard maneuver to protect one ally he is engaged with. He then suffers a number of strain no greater than his ranks in Body Guard. Until the start of the character's next turn, upgrade the difficulty of all combat checks targeting the protected ally a number of times equal to the strain suffered by the character.";
        ParentTalents = parents;
        TalentXPCost = xpCost;
    }
}

public class BraceTalent : BaseEotETalent
{

    public BraceTalent()
    {
        TalentName = "Brace";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.MANEUVER };
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.BODYGUARD, Trees.GADGETEER, Trees.OUTLAWTECH, Trees.SCHOLAR };
        TalentDescription = "As a maneuver, the character may Brace himself. This allows a character to remove [Setback] per rank of Brace from the next skill check based on changing conditions, inclement weather, unstable surfaces, zero gravity, heavy gravity, or other disruptive physical obstacles that would make a skill check more difficult.";
    }
    public BraceTalent(bool root, int xpCost)
    {
        TalentName = "Brace";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.MANEUVER };
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.BODYGUARD, Trees.GADGETEER, Trees.OUTLAWTECH, Trees.SCHOLAR };
        TalentDescription = "As a maneuver, the character may Brace himself. This allows a character to remove [Setback] per rank of Brace from the next skill check based on changing conditions, inclement weather, unstable surfaces, zero gravity, heavy gravity, or other disruptive physical obstacles that would make a skill check more difficult.";
        IsRoot = root;
        TalentXPCost = xpCost;
    }
    public BraceTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Brace";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.MANEUVER };
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.BODYGUARD, Trees.GADGETEER, Trees.OUTLAWTECH, Trees.SCHOLAR };
        TalentDescription = "As a maneuver, the character may Brace himself. This allows a character to remove [Setback] per rank of Brace from the next skill check based on changing conditions, inclement weather, unstable surfaces, zero gravity, heavy gravity, or other disruptive physical obstacles that would make a skill check more difficult.";
        ParentTalents = parents;
        TalentXPCost = xpCost;
    }
}

public class BrilliantEvasionTalent : BaseEotETalent
{

    public BrilliantEvasionTalent()
    {
        TalentName = "BrilliantEvasion";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.ACTION };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.PILOT };
        TalentDescription = "The character may make the Brilliant Evasion action when piloting a vehicle or starship. The character selects one opponent and makes an Opposed Piloting (Planetary or Space) check. If he succeeds, the opponent's vehicle or starship cannot make any attacks against the character's vehicle for a number of rounds equal to the character's Agility. Brilliant Evasion can only be performed once per encounter.";
    }
    public BrilliantEvasionTalent(bool root, int xpCost)
    {
        TalentName = "BrilliantEvasion";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.ACTION };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.PILOT };
        TalentDescription = "The character may make the Brilliant Evasion action when piloting a vehicle or starship. The character selects one opponent and makes an Opposed Piloting (Planetary or Space) check. If he succeeds, the opponent's vehicle or starship cannot make any attacks against the character's vehicle for a number of rounds equal to the character's Agility. Brilliant Evasion can only be performed once per encounter.";
        IsRoot = root;
        TalentXPCost = xpCost;
    }
    public BrilliantEvasionTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "BrilliantEvasion";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.ACTION };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.PILOT };
        TalentDescription = "The character may make the Brilliant Evasion action when piloting a vehicle or starship. The character selects one opponent and makes an Opposed Piloting (Planetary or Space) check. If he succeeds, the opponent's vehicle or starship cannot make any attacks against the character's vehicle for a number of rounds equal to the character's Agility. Brilliant Evasion can only be performed once per encounter.";
        ParentTalents = parents;
        TalentXPCost = xpCost;
    }
}

public class BypassSecurityTalent : BaseEotETalent
{

    public BypassSecurityTalent()
    {
        TalentName = "Bypass Security";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.SLICER, Trees.THIEF };
        TalentDescription = "Remove [Setback] equal to the character's ranks in Bypass Security from Skulduggery or Computers skill checks made to disable a security device or open a locked door.";
    }
    public BypassSecurityTalent(bool root, int xpCost)
    {
        TalentName = "Bypass Security";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.SLICER, Trees.THIEF };
        TalentDescription = "Remove [Setback] equal to the character's ranks in Bypass Security from Skulduggery or Computers skill checks made to disable a security device or open a locked door.";
        IsRoot = root;
        TalentXPCost = xpCost;
    }
    public BypassSecurityTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Bypass Security";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.SLICER, Trees.THIEF };
        TalentDescription = "Remove [Setback] equal to the character's ranks in Bypass Security from Skulduggery or Computers skill checks made to disable a security device or open a locked door.";
        ParentTalents = parents;
        TalentXPCost = xpCost;
    }
}

public class CodebreakerTalent : BaseEotETalent
{

    public CodebreakerTalent()
    {
        TalentName = "Codebreaker";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.SCHOLAR, Trees.SLICER };
        TalentDescription = "The character removes [Setback] from any attempt to break codes or decrypt communications equal to his ranks in Codebreaker. In addition, the character decreases the difficulty of Computers or Intellect checks made to break codes or decrypt communications by one. This does not increase with additional ranks of Codebreaker.";
    }
    public CodebreakerTalent(bool root, int xpCost)
    {
        TalentName = "Codebreaker";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.SCHOLAR, Trees.SLICER };
        TalentDescription = "The character removes [Setback] from any attempt to break codes or decrypt communications equal to his ranks in Codebreaker. In addition, the character decreases the difficulty of Computers or Intellect checks made to break codes or decrypt communications by one. This does not increase with additional ranks of Codebreaker.";
        IsRoot = root;
        TalentXPCost = xpCost;
    }
    public CodebreakerTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Codebreaker";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.SCHOLAR, Trees.SLICER };
        TalentDescription = "The character removes [Setback] from any attempt to break codes or decrypt communications equal to his ranks in Codebreaker. In addition, the character decreases the difficulty of Computers or Intellect checks made to break codes or decrypt communications by one. This does not increase with additional ranks of Codebreaker.";
        ParentTalents = parents;
        TalentXPCost = xpCost;
    }
}

public class CommandTalent : BaseEotETalent
{

    public CommandTalent()
    {
        TalentName = "Command";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.MERCENARYSOLDIER };
        TalentDescription = "Gain [Boost] when making Leadership checks (or other checks to inspire, lead, or rally an audience) per rank of Command. Inspired targets also add [Boost] per rank to any subsequent Discipline checks they make over the next twenty-four hours. This does not increase with additional ranks of Command.";
    }
    public CommandTalent(bool root, int xpCost)
    {
        TalentName = "Command";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.MERCENARYSOLDIER };
        TalentDescription = "Gain [Boost] when making Leadership checks (or other checks to inspire, lead, or rally an audience) per rank of Command. Inspired targets also add [Boost] per rank to any subsequent Discipline checks they make over the next twenty-four hours. This does not increase with additional ranks of Command.";
        IsRoot = root;
        TalentXPCost = xpCost;
    }
    public CommandTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Command";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.MERCENARYSOLDIER };
        TalentDescription = "Gain [Boost] when making Leadership checks (or other checks to inspire, lead, or rally an audience) per rank of Command. Inspired targets also add [Boost] per rank to any subsequent Discipline checks they make over the next twenty-four hours. This does not increase with additional ranks of Command.";
        ParentTalents = parents;
        TalentXPCost = xpCost;
    }
}

public class ConfidenceTalent : BaseEotETalent
{

    public ConfidenceTalent()
    {
        TalentName = "Confidence";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.SCHOLAR, Trees.MERCENARYSOLDIER };
        TalentDescription = "The character may decrease the difficulty of any Discipline check to avoid the effects of fear by one level per rank of Confidence. If he decreases the difficulty to zero, he does not have to make a Discipline check.";
    }
    public ConfidenceTalent(bool root, int xpCost)
    {
        TalentName = "Confidence";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.SCHOLAR, Trees.MERCENARYSOLDIER };
        TalentDescription = "The character may decrease the difficulty of any Discipline check to avoid the effects of fear by one level per rank of Confidence. If he decreases the difficulty to zero, he does not have to make a Discipline check.";
        IsRoot = root;
        TalentXPCost = xpCost;
    }
    public ConfidenceTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Confidence";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.SCHOLAR, Trees.MERCENARYSOLDIER };
        TalentDescription = "The character may decrease the difficulty of any Discipline check to avoid the effects of fear by one level per rank of Confidence. If he decreases the difficulty to zero, he does not have to make a Discipline check.";
        ParentTalents = parents;
        TalentXPCost = xpCost;
    }
}

public class ContraptionTalent : BaseEotETalent
{

    public ContraptionTalent()
    {
        TalentName = "Contraption";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.ACTION };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.MECHANIC };
        TalentDescription = "Once per game session, the character can take a Contraption action. With a successful Hard (3 difficulty) Mechanics check, the character can fashion a device to solve a current problem using the tools and parts on hand. This device must be approved by the GM and functions for the duration of the current encounter only. Those tools are destrolyed in the process. [Triumph] may be spent to allow the tools to be recovered to be reused later.";
    }
    public ContraptionTalent(bool root, int xpCost)
    {
        TalentName = "Contraption";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.ACTION };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.MECHANIC };
        TalentDescription = "Once per game session, the character can take a Contraption action. With a successful Hard (3 difficulty) Mechanics check, the character can fashion a device to solve a current problem using the tools and parts on hand. This device must be approved by the GM and functions for the duration of the current encounter only. Those tools are destrolyed in the process. [Triumph] may be spent to allow the tools to be recovered to be reused later.";
        IsRoot = root;
        TalentXPCost = xpCost;
    }
    public ContraptionTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Contraption";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.ACTION };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.MECHANIC };
        TalentDescription = "Once per game session, the character can take a Contraption action. With a successful Hard (3 difficulty) Mechanics check, the character can fashion a device to solve a current problem using the tools and parts on hand. This device must be approved by the GM and functions for the duration of the current encounter only. Those tools are destrolyed in the process. [Triumph] may be spent to allow the tools to be recovered to be reused later.";
        ParentTalents = parents;
        TalentXPCost = xpCost;
    }
}

public class ConvincingDemeanorTalent : BaseEotETalent
{

    public ConvincingDemeanorTalent()
    {
        TalentName = "Convincing Demeanor";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.FORCESENSITIVEEXILE, Trees.SCOUNDREL, Trees.TRADER };
        TalentDescription = "Remove [Setback] per rank of Convincing Demeanor from any Deception or Skulduggery check.";
    }
    public ConvincingDemeanorTalent(bool root, int xpCost)
    {
        TalentName = "Convincing Demeanor";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.FORCESENSITIVEEXILE, Trees.SCOUNDREL, Trees.TRADER };
        TalentDescription = "Remove [Setback] per rank of Convincing Demeanor from any Deception or Skulduggery check.";
        IsRoot = root;
        TalentXPCost = xpCost;
    }
    public ConvincingDemeanorTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Convincing Demeanor";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.FORCESENSITIVEEXILE, Trees.SCOUNDREL, Trees.TRADER };
        TalentDescription = "Remove [Setback] per rank of Convincing Demeanor from any Deception or Skulduggery check.";
        ParentTalents = parents;
        TalentXPCost = xpCost;
    }
}

public class CripplingBlowTalent : BaseEotETalent
{

    public CripplingBlowTalent()
    {
        TalentName = "Crippling Blow";
        TalentActivation = Activation.ACTIVE;
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.GADGETEER };
        TalentDescription = "The character may voluntarily increase the difficulty of a combat check by one to deal a crippling blow. If he succeeds and deals damage to the target's wound threshold, the target suffers one strain whenever he moves for the remainder of the encounter.";
    }
    public CripplingBlowTalent(bool root, int xpCost)
    {
        TalentName = "Crippling Blow";
        TalentActivation = Activation.ACTIVE;
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.GADGETEER };
        TalentDescription = "The character may voluntarily increase the difficulty of a combat check by one to deal a crippling blow. If he succeeds and deals damage to the target's wound threshold, the target suffers one strain whenever he moves for the remainder of the encounter.";
        IsRoot = root;
        TalentXPCost = xpCost;

    }
    public CripplingBlowTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Crippling Blow";
        TalentActivation = Activation.ACTIVE;
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.GADGETEER };
        TalentDescription = "The character may voluntarily increase the difficulty of a combat check by one to deal a crippling blow. If he succeeds and deals damage to the target's wound threshold, the target suffers one strain whenever he moves for the remainder of the encounter.";
        ParentTalents = parents;
        TalentXPCost = xpCost;
    }
}

public class DeadToRightsTalent : BaseEotETalent
{

    public DeadToRightsTalent()
    {
        TalentName = "Dead to Rights";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.PILOT };
        TalentDescription = "The character may spend one Destiny Point to add additional damage equal to half his Agility rating (rounded up) to one hit of a successful attack made by a ship or vehicle-mounted weaponry.";
    }
    public DeadToRightsTalent(bool root, int xpCost)
    {
        TalentName = "Dead to Rights";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.PILOT };
        TalentDescription = "The character may spend one Destiny Point to add additional damage equal to half his Agility rating (rounded up) to one hit of a successful attack made by a ship or vehicle-mounted weaponry.";
        IsRoot = root;
        TalentXPCost = xpCost;
    }
    public DeadToRightsTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Dead to Rights";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.PILOT };
        TalentDescription = "The character may spend one Destiny Point to add additional damage equal to half his Agility rating (rounded up) to one hit of a successful attack made by a ship or vehicle-mounted weaponry.";
        ParentTalents = parents;
        TalentXPCost = xpCost;
    }
}

public class DeadToRightsImprovedTalent : BaseEotETalent
{

    public DeadToRightsImprovedTalent()
    {
        TalentName = "Dead to Rights (Improved)";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.PILOT };
        TalentDescription = "The character may spend one Destiny Point to add additional damage equal to his Agility rating to one hit of a successful attack made by ship or vehicle-mounted weaponry. This replaces Dead to Rights.";
    }
    public DeadToRightsImprovedTalent(bool root, int xpCost)
    {
        TalentName = "Dead to Rights (Improved)";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.PILOT };
        TalentDescription = "The character may spend one Destiny Point to add additional damage equal to his Agility rating to one hit of a successful attack made by ship or vehicle-mounted weaponry. This replaces Dead to Rights.";
        IsRoot = root;
        TalentXPCost = xpCost;
    }
    public DeadToRightsImprovedTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Dead to Rights (Improved)";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.PILOT };
        TalentDescription = "The character may spend one Destiny Point to add additional damage equal to his Agility rating to one hit of a successful attack made by ship or vehicle-mounted weaponry. This replaces Dead to Rights.";
        ParentTalents = parents;
        TalentXPCost = xpCost;
    }
}

public class DeadlyAccuracyTalent : BaseEotETalent
{

    public DeadlyAccuracyTalent()
    {
        TalentName = "Deadly Accuracy";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.ASSASSIN, Trees.GADGETEER, Trees.MERCENARYSOLDIER };
        TalentDescription = "Each time the character gains a rank of Deadly Accuracy, he must choose one combat skill. The character may add his basic training ranks in that combat skill as additional damage to one hit of a successful attack made with that skill with non-starship/vehicle weapons. He cannot choose the same combat skill twice.";
    }
    public DeadlyAccuracyTalent(bool root, int xpCost)
    {
        TalentName = "Deadly Accuracy";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.ASSASSIN, Trees.GADGETEER, Trees.MERCENARYSOLDIER };
        TalentDescription = "Each time the character gains a rank of Deadly Accuracy, he must choose one combat skill. The character may add his basic training ranks in that combat skill as additional damage to one hit of a successful attack made with that skill with non-starship/vehicle weapons. He cannot choose the same combat skill twice.";
        IsRoot = root;
        TalentXPCost = xpCost;
    }
    public DeadlyAccuracyTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Deadly Accuracy";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.ASSASSIN, Trees.GADGETEER, Trees.MERCENARYSOLDIER };
        TalentDescription = "Each time the character gains a rank of Deadly Accuracy, he must choose one combat skill. The character may add his basic training ranks in that combat skill as additional damage to one hit of a successful attack made with that skill with non-starship/vehicle weapons. He cannot choose the same combat skill twice.";
        ParentTalents = parents;
        TalentXPCost = xpCost;
    }
}

public class DedicationTalent : BaseEotETalent
{

    public DedicationTalent()
    {
        TalentName = "Dedication";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.ASSASSIN, Trees.BODYGUARD, Trees.DOCTOR, Trees.FORCESENSITIVEEXILE, Trees.FRINGER, Trees.GADGETEER, Trees.MARAUDER, Trees.MECHANIC, Trees.MERCENARYSOLDIER, Trees.OUTLAWTECH, Trees.PILOT, Trees.POLITICO, Trees.SCHOLAR, Trees.SCOUNDREL, Trees.SCOUT, Trees.SLICER, Trees.SURVIVALIST, Trees.THIEF, Trees.TRADER};
        TalentDescription = "Each rank permanently increases a single characteristic of the player's choice by one point. This cannot bring a characteristic above six.";
    }
    public DedicationTalent(bool root, int xpCost)
    {
        TalentName = "Dedication";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.ASSASSIN, Trees.BODYGUARD, Trees.DOCTOR, Trees.FORCESENSITIVEEXILE, Trees.FRINGER, Trees.GADGETEER, Trees.MARAUDER, Trees.MECHANIC, Trees.MERCENARYSOLDIER, Trees.OUTLAWTECH, Trees.PILOT, Trees.POLITICO, Trees.SCHOLAR, Trees.SCOUNDREL, Trees.SCOUT, Trees.SLICER, Trees.SURVIVALIST, Trees.THIEF, Trees.TRADER };
        TalentDescription = "Each rank permanently increases a single characteristic of the player's choice by one point. This cannot bring a characteristic above six.";
        IsRoot = root;
        TalentXPCost = xpCost;
    }
    public DedicationTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Dedication";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.ASSASSIN, Trees.BODYGUARD, Trees.DOCTOR, Trees.FORCESENSITIVEEXILE, Trees.FRINGER, Trees.GADGETEER, Trees.MARAUDER, Trees.MECHANIC, Trees.MERCENARYSOLDIER, Trees.OUTLAWTECH, Trees.PILOT, Trees.POLITICO, Trees.SCHOLAR, Trees.SCOUNDREL, Trees.SCOUT, Trees.SLICER, Trees.SURVIVALIST, Trees.THIEF, Trees.TRADER };
        TalentDescription = "Each rank permanently increases a single characteristic of the player's choice by one point. This cannot bring a characteristic above six.";
        ParentTalents = parents;
        TalentXPCost = xpCost;
    }
}

public class DefensiveDrivingTalent : BaseEotETalent
{

    public DefensiveDrivingTalent()
    {
        TalentName = "Defensive Driving";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.FRINGER, Trees.PILOT };
        TalentDescription = "Any vehicle the character pilots has its defense rating on all zones increased by one per rank of Defensive Driving";
    }
    public DefensiveDrivingTalent(bool root, int xpCost)
    {
        TalentName = "Defensive Driving";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.FRINGER, Trees.PILOT };
        TalentDescription = "Any vehicle the character pilots has its defense rating on all zones increased by one per rank of Defensive Driving";
        IsRoot = root;
        TalentXPCost = xpCost;
    }
    public DefensiveDrivingTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Defensive Driving";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.FRINGER, Trees.PILOT };
        TalentDescription = "Any vehicle the character pilots has its defense rating on all zones increased by one per rank of Defensive Driving";
        ParentTalents = parents;
        TalentXPCost = xpCost;
    }
}

public class DefensiveSlicingTalent : BaseEotETalent
{

    public DefensiveSlicingTalent()
    {
        TalentName = "Defensive Slicing";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.SLICER };
        TalentDescription = "When attempting to defend a computer system against intrusion (or when an opponent attempts to slice a computer owned or programmed by the character), the character adds [Setback] equal to his rank of Defensive Slicing to his opponent's checks.";
    }
    public DefensiveSlicingTalent(bool root, int xpCost)
    {
        TalentName = "Defensive Slicing";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.SLICER };
        TalentDescription = "When attempting to defend a computer system against intrusion (or when an opponent attempts to slice a computer owned or programmed by the character), the character adds [Setback] equal to his rank of Defensive Slicing to his opponent's checks.";
        IsRoot = root;
        TalentXPCost = xpCost;
    }
    public DefensiveSlicingTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Defensive Slicing";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.SLICER };
        TalentDescription = "When attempting to defend a computer system against intrusion (or when an opponent attempts to slice a computer owned or programmed by the character), the character adds [Setback] equal to his rank of Defensive Slicing to his opponent's checks.";
        ParentTalents = parents;
        TalentXPCost = xpCost;
    }
}

public class DefensiveSlicingImprovedTalent : BaseEotETalent
{

    public DefensiveSlicingImprovedTalent()
    {
        TalentName = "Defensive Slicing (Improved)";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.SLICER };
        TalentDescription = "When attempting to defend a computer system against intrusion, the character upgrades the difficulty of an opponent's dice pool a number of times equal to his rank of Defensive Slicing. This replaces the usual benefits from Defensive Slicing.";
    }
    public DefensiveSlicingImprovedTalent(bool root, int xpCost)
    {
        TalentName = "Defensive Slicing (Improved)";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.SLICER };
        TalentDescription = "When attempting to defend a computer system against intrusion, the character upgrades the difficulty of an opponent's dice pool a number of times equal to his rank of Defensive Slicing. This replaces the usual benefits from Defensive Slicing.";
        IsRoot = root;
        TalentXPCost = xpCost;
    }
    public DefensiveSlicingImprovedTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Defensive Slicing (Improved)";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.SLICER };
        TalentDescription = "When attempting to defend a computer system against intrusion, the character upgrades the difficulty of an opponent's dice pool a number of times equal to his rank of Defensive Slicing. This replaces the usual benefits from Defensive Slicing.";
        ParentTalents = parents;
        TalentXPCost = xpCost;
    }
}

public class DefensiveStanceTalent : BaseEotETalent
{

    public DefensiveStanceTalent()
    {
        TalentName = "Defensive Stance";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.MANEUVER };
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.BODYGUARD, Trees.GADGETEER, Trees.MARAUDER, Trees.OUTLAWTECH };
        TalentDescription = "Once per round on the character's turn, the character may perform a Defensive Stance maneuver to assume a defensive stance against incoming melee attacks. He then suffers a number of strain no greater than his ranks in Defensive Stance. Until the start of the character's next turn, upgrade the difficulty of all melee combat checks targeting the character a number of times equal to the strain suffered by the character in this way.";
    }
    public DefensiveStanceTalent(bool root, int xpCost)
    {
        TalentName = "Defensive Stance";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.MANEUVER };
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.BODYGUARD, Trees.GADGETEER, Trees.MARAUDER, Trees.OUTLAWTECH };
        TalentDescription = "Once per round on the character's turn, the character may perform a Defensive Stance maneuver to assume a defensive stance against incoming melee attacks. He then suffers a number of strain no greater than his ranks in Defensive Stance. Until the start of the character's next turn, upgrade the difficulty of all melee combat checks targeting the character a number of times equal to the strain suffered by the character in this way.";
        IsRoot = root;
        TalentXPCost = xpCost;
    }
    public DefensiveStanceTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Defensive Stance";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.MANEUVER };
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.BODYGUARD, Trees.GADGETEER, Trees.MARAUDER, Trees.OUTLAWTECH };
        TalentDescription = "Once per round on the character's turn, the character may perform a Defensive Stance maneuver to assume a defensive stance against incoming melee attacks. He then suffers a number of strain no greater than his ranks in Defensive Stance. Until the start of the character's next turn, upgrade the difficulty of all melee combat checks targeting the character a number of times equal to the strain suffered by the character in this way.";
        ParentTalents = parents;
        TalentXPCost = xpCost;
    }
}

public class DisorientTalent : BaseEotETalent
{

    public DisorientTalent()
    {
        TalentName = "Disorient";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.GADGETEER, Trees.SCOUT };
        TalentDescription = "After hitting with a combat check, the character may spend [2 Advantage] to TalentB4 his foe. Disoriented targets add [Setback] to all skill checks. The target is disoriented for a number of rounds equal to the attacker's ranks in Disorient.";
    }
    public DisorientTalent(bool root, int xpCost)
    {
        TalentName = "Disorient";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.GADGETEER, Trees.SCOUT };
        TalentDescription = "After hitting with a combat check, the character may spend [2 Advantage] to TalentB4 his foe. Disoriented targets add [Setback] to all skill checks. The target is disoriented for a number of rounds equal to the attacker's ranks in Disorient.";
        IsRoot = root;
        TalentXPCost = xpCost;
    }
    public DisorientTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Disorient";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.GADGETEER, Trees.SCOUT };
        TalentDescription = "After hitting with a combat check, the character may spend [2 Advantage] to TalentB4 his foe. Disoriented targets add [Setback] to all skill checks. The target is disoriented for a number of rounds equal to the attacker's ranks in Disorient.";
        ParentTalents = parents;
        TalentXPCost = xpCost;
    }
}

public class DodgeTalent : BaseEotETalent
{

    public DodgeTalent()
    {
        TalentName = "Dodge";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL, ActivationSpec.OUTOFTURN };
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.ASSASSIN, Trees.DOCTOR, Trees.FRINGER, Trees.POLITICO, Trees.THIEF };
        TalentDescription = "When targeted by a combat check (ranged or melee) the character may choose to immediately perform a Dodge incidental to suffer a number of strain, then upgrade the difficulty of the combat check by that number. The number of strain suffered cannot exceed his ranks in Dodge.";
    }
    public DodgeTalent(bool root, int xpCost)
    {
        TalentName = "Dodge";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL, ActivationSpec.OUTOFTURN };
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.ASSASSIN, Trees.DOCTOR, Trees.FRINGER, Trees.POLITICO, Trees.THIEF };
        TalentDescription = "When targeted by a combat check (ranged or melee) the character may choose to immediately perform a Dodge incidental to suffer a number of strain, then upgrade the difficulty of the combat check by that number. The number of strain suffered cannot exceed his ranks in Dodge.";
        IsRoot = root;
        TalentXPCost = xpCost;
    }
    public DodgeTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Dodge";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL, ActivationSpec.OUTOFTURN };
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.ASSASSIN, Trees.DOCTOR, Trees.FRINGER, Trees.POLITICO, Trees.THIEF };
        TalentDescription = "When targeted by a combat check (ranged or melee) the character may choose to immediately perform a Dodge incidental to suffer a number of strain, then upgrade the difficulty of the combat check by that number. The number of strain suffered cannot exceed his ranks in Dodge.";
        ParentTalents = parents;
        TalentXPCost = xpCost;
    }
}

public class DurableTalent : BaseEotETalent
{

    public DurableTalent()
    {
        TalentName = "Durable";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.BODYGUARD, Trees.FRINGER };
        TalentDescription = "The character may reduce a Critical Injury result he suffers by 10 per rank of Durable, to a minimum of one.";
    }
    public DurableTalent(bool root, int xpCost)
    {
        TalentName = "Durable";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.BODYGUARD, Trees.FRINGER };
        TalentDescription = "The character may reduce a Critical Injury result he suffers by 10 per rank of Durable, to a minimum of one.";
        IsRoot = root;
        TalentXPCost = xpCost;
    }
    public DurableTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Durable";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.BODYGUARD, Trees.FRINGER };
        TalentDescription = "The character may reduce a Critical Injury result he suffers by 10 per rank of Durable, to a minimum of one.";
        ParentTalents = parents;
        TalentXPCost = xpCost;
    }
}

public class EnduringTalent : BaseEotETalent
{

    public EnduringTalent()
    {
        TalentName = "Enduring";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.BODYGUARD, Trees.MARAUDER, Trees.MECHANIC, Trees.SURVIVALIST };
        TalentDescription = "Character gains +1 soak value per rank of Enduring";
    }
    public EnduringTalent(bool root, int xpCost)
    {
        TalentName = "Enduring";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.BODYGUARD, Trees.MARAUDER, Trees.MECHANIC, Trees.SURVIVALIST };
        TalentDescription = "Character gains +1 soak value per rank of Enduring";
        IsRoot = root;
        TalentXPCost = xpCost;
    }
    public EnduringTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Enduring";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.BODYGUARD, Trees.MARAUDER, Trees.MECHANIC, Trees.SURVIVALIST };
        TalentDescription = "Character gains +1 soak value per rank of Enduring";
        ParentTalents = parents;
        TalentXPCost = xpCost;
    }
}

public class ExpertTrackerTalent : BaseEotETalent
{

    public ExpertTrackerTalent()
    {
        TalentName = "Expert Tracker";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.SURVIVALIST };
        TalentDescription = "Remove [Setback] per rank of Expert Tracker from checks to find or follow tracks. Survival checks made to track targets take 50% less time than normal. This does not decrease with additional ranks of Expert Tracker.";
    }
    public ExpertTrackerTalent(bool root, int xpCost)
    {
        TalentName = "Expert Tracker";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.SURVIVALIST };
        TalentDescription = "Remove [Setback] per rank of Expert Tracker from checks to find or follow tracks. Survival checks made to track targets take 50% less time than normal. This does not decrease with additional ranks of Expert Tracker.";
        IsRoot = root;
        TalentXPCost = xpCost;
    }
    public ExpertTrackerTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Expert Tracker";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.SURVIVALIST };
        TalentDescription = "Remove [Setback] per rank of Expert Tracker from checks to find or follow tracks. Survival checks made to track targets take 50% less time than normal. This does not decrease with additional ranks of Expert Tracker.";
        ParentTalents = parents;
        TalentXPCost = xpCost;
    }
}

public class FamiliarSunsTalent : BaseEotETalent
{

    public FamiliarSunsTalent()
    {
        TalentName = "Familiar Suns";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.MANEUVER };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.SCOUT };
        TalentDescription = "Once per game session the character may spend a maneuver to make a Hard (3 Difficulty) Knowledge (Outer Rim) or Knowledge (Core Worlds) check. If successful, the character is familiar with the type of planetary environment he finds himself in. He knows whether the planet is likely to be inhabited and, if so, where habitation could be found. He also knows about unusual environmental effects, hostile predators, or sources of potential profit.";
    }
    public FamiliarSunsTalent(bool root, int xpCost)
    {
        TalentName = "Familiar Suns";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.MANEUVER };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.SCOUT };
        TalentDescription = "Once per game session the character may spend a maneuver to make a Hard (3 Difficulty) Knowledge (Outer Rim) or Knowledge (Core Worlds) check. If successful, the character is familiar with the type of planetary environment he finds himself in. He knows whether the planet is likely to be inhabited and, if so, where habitation could be found. He also knows about unusual environmental effects, hostile predators, or sources of potential profit.";
        IsRoot = root;
        TalentXPCost = xpCost;
    }
    public FamiliarSunsTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Familiar Suns";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.MANEUVER };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.SCOUT };
        TalentDescription = "Once per game session the character may spend a maneuver to make a Hard (3 Difficulty) Knowledge (Outer Rim) or Knowledge (Core Worlds) check. If successful, the character is familiar with the type of planetary environment he finds himself in. He knows whether the planet is likely to be inhabited and, if so, where habitation could be found. He also knows about unusual environmental effects, hostile predators, or sources of potential profit.";
        ParentTalents = parents;
        TalentXPCost = xpCost;
    }
}

public class FeralStrengthTalent : BaseEotETalent
{

    public FeralStrengthTalent()
    {
        TalentName = "Feral Strength";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.MARAUDER };
        TalentDescription = "The character deals +1 damage to one hit on all successful Brawl and Melee checks per rank of Feral Strength";
    }
    public FeralStrengthTalent(bool root, int xpCost)
    {
        TalentName = "Feral Strength";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.MARAUDER };
        TalentDescription = "The character deals +1 damage to one hit on all successful Brawl and Melee checks per rank of Feral Strength";
        IsRoot = root;
        TalentXPCost = xpCost;
    }
    public FeralStrengthTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Feral Strength";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.MARAUDER };
        TalentDescription = "The character deals +1 damage to one hit on all successful Brawl and Melee checks per rank of Feral Strength";
        ParentTalents = parents;
        TalentXPCost = xpCost;
    }
}

public class FieldCommanderTalent : BaseEotETalent
{

    public FieldCommanderTalent()
    {
        TalentName = "Field Commander";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.ACTION };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.MERCENARYSOLDIER };
        TalentDescription = "The character may take a Field Commander action. By successfully passing an Average (2 Difficulty) Leadership check, a number of allies equal to his Presence may immediately suffer one strain to perform one maneuver. This does not count against the number of maneuvers they may perform in their turn. If there are any questions as to the order in which allies act, the character using Field Commander is the final arbitrator.";
    }
    public FieldCommanderTalent(bool root, int xpCost)
    {
        TalentName = "Field Commander";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.ACTION };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.MERCENARYSOLDIER };
        TalentDescription = "The character may take a Field Commander action. By successfully passing an Average (2 Difficulty) Leadership check, a number of allies equal to his Presence may immediately suffer one strain to perform one maneuver. This does not count against the number of maneuvers they may perform in their turn. If there are any questions as to the order in which allies act, the character using Field Commander is the final arbitrator.";
        IsRoot = root;
        TalentXPCost = xpCost;
    }
    public FieldCommanderTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Field Commander";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.ACTION };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.MERCENARYSOLDIER };
        TalentDescription = "The character may take a Field Commander action. By successfully passing an Average (2 Difficulty) Leadership check, a number of allies equal to his Presence may immediately suffer one strain to perform one maneuver. This does not count against the number of maneuvers they may perform in their turn. If there are any questions as to the order in which allies act, the character using Field Commander is the final arbitrator.";
        ParentTalents = parents;
        TalentXPCost = xpCost;
    }
}

public class FieldCommanderImprovedTalent : BaseEotETalent
{

    public FieldCommanderImprovedTalent()
    {
        TalentName = "Field Commander (Improved)";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.MERCENARYSOLDIER };
        TalentDescription = "When taking a Field Commander action, the character may affect allies equal to twice his Presence. In addition, he may spend [Triumph] generated on his Leadership checks to allow one ally to suffer one strain to perform an action, rather than a maneuver.";
    }
    public FieldCommanderImprovedTalent(bool root, int xpCost)
    {
        TalentName = "Field Commander (Improved)";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.MERCENARYSOLDIER };
        TalentDescription = "When taking a Field Commander action, the character may affect allies equal to twice his Presence. In addition, he may spend [Triumph] generated on his Leadership checks to allow one ally to suffer one strain to perform an action, rather than a maneuver.";
        IsRoot = root;
        TalentXPCost = xpCost;
    }
    public FieldCommanderImprovedTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Field Commander (Improved)";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.MERCENARYSOLDIER };
        TalentDescription = "When taking a Field Commander action, the character may affect allies equal to twice his Presence. In addition, he may spend [Triumph] generated on his Leadership checks to allow one ally to suffer one strain to perform an action, rather than a maneuver.";
        ParentTalents = parents;
        TalentXPCost = xpCost;
    }
}

public class FineTuningTalent : BaseEotETalent
{

    public FineTuningTalent()
    {
        TalentName = "Fine Tuning";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.MECHANIC };
        TalentDescription = "Whenever a character reduces the amount of strain a starship or vehicle suffers, he reduces one additional strain per rank of Fine Tuning.";
    }
    public FineTuningTalent(bool root, int xpCost)
    {
        TalentName = "Fine Tuning";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.MECHANIC };
        TalentDescription = "Whenever a character reduces the amount of strain a starship or vehicle suffers, he reduces one additional strain per rank of Fine Tuning.";
        IsRoot = root;
        TalentXPCost = xpCost;
    }
    public FineTuningTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Fine Tuning";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.MECHANIC };
        TalentDescription = "Whenever a character reduces the amount of strain a starship or vehicle suffers, he reduces one additional strain per rank of Fine Tuning.";
        ParentTalents = parents;
        TalentXPCost = xpCost;
    }
}

public class ForagerTalent : BaseEotETalent
{

    public ForagerTalent()
    {
        TalentName = "Forager";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.FORCESENSITIVEEXILE, Trees.SCOUT, Trees.SURVIVALIST };
        TalentDescription = "Remove up to [2 Setback] from skill checks to find food, water, or shelter. Survival checks to forage take half the time.";
    }
    public ForagerTalent(bool root, int xpCost)
    {
        TalentName = "Forager";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.FORCESENSITIVEEXILE, Trees.SCOUT, Trees.SURVIVALIST };
        TalentDescription = "Remove up to [2 Setback] from skill checks to find food, water, or shelter. Survival checks to forage take half the time.";
        IsRoot = root;
        TalentXPCost = xpCost;
    }
    public ForagerTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Forager";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.FORCESENSITIVEEXILE, Trees.SCOUT, Trees.SURVIVALIST };
        TalentDescription = "Remove up to [2 Setback] from skill checks to find food, water, or shelter. Survival checks to forage take half the time.";
        ParentTalents = parents;
        TalentXPCost = xpCost;
    }
}

public class ForceRatingTalent : BaseEotETalent
{

    public ForceRatingTalent()
    {
        TalentName = "Force Rating";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.FORCESENSITIVEEXILE };
        TalentDescription = "Each rank permanently increases Force Rating by one.";
    }
    public ForceRatingTalent(bool root, int xpCost)
    {
        TalentName = "Force Rating";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.FORCESENSITIVEEXILE };
        TalentDescription = "Each rank permanently increases Force Rating by one.";
        IsRoot = root;
        TalentXPCost = xpCost;
    }
    public ForceRatingTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Force Rating";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.FORCESENSITIVEEXILE };
        TalentDescription = "Each rank permanently increases Force Rating by one.";
        ParentTalents = parents;
        TalentXPCost = xpCost;
    }
}

public class FrenziedAttackTalent : BaseEotETalent
{

    public FrenziedAttackTalent()
    {
        TalentName = "Frenzied Attack";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.MARAUDER };
        TalentDescription = "When making a Melee or Brawl combat check, the character may suffer a number of strain, then upgrade the ability of his combat check by that number. The number cannot exceed his ranks in Frenzied Attack.";
    }
    public FrenziedAttackTalent(bool root, int xpCost)
    {
        TalentName = "Frenzied Attack";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.MARAUDER };
        TalentDescription = "When making a Melee or Brawl combat check, the character may suffer a number of strain, then upgrade the ability of his combat check by that number. The number cannot exceed his ranks in Frenzied Attack.";
        IsRoot = root;
        TalentXPCost = xpCost;
    }
    public FrenziedAttackTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Frenzied Attack";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.MARAUDER };
        TalentDescription = "When making a Melee or Brawl combat check, the character may suffer a number of strain, then upgrade the ability of his combat check by that number. The number cannot exceed his ranks in Frenzied Attack.";
        ParentTalents = parents;
        TalentXPCost = xpCost;
    }
}

public class FullThrottleTalent : BaseEotETalent
{

    public FullThrottleTalent()
    {
        TalentName = "Full Throttle";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.ACTION };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.PILOT };
        TalentDescription = "The character may push a ship or vehicle past its limits of speed. He may perform the Full Throttle action, attempting a Hard (3 Difficulty) Piloting check. With success, the ship's top speed increases by one for a number of rounds equal to Cunning. The ship still cannot perform actions or maneuvers it could not perform normally. (i.e. actions that have a minimum speed requirement)";
    }
    public FullThrottleTalent(bool root, int xpCost)
    {
        TalentName = "Full Throttle";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.ACTION };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.PILOT };
        TalentDescription = "The character may push a ship or vehicle past its limits of speed. He may perform the Full Throttle action, attempting a Hard (3 Difficulty) Piloting check. With success, the ship's top speed increases by one for a number of rounds equal to Cunning. The ship still cannot perform actions or maneuvers it could not perform normally. (i.e. actions that have a minimum speed requirement)";
        IsRoot = root;
        TalentXPCost = xpCost;
    }
    public FullThrottleTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Full Throttle";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.ACTION };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.PILOT };
        TalentDescription = "The character may push a ship or vehicle past its limits of speed. He may perform the Full Throttle action, attempting a Hard (3 Difficulty) Piloting check. With success, the ship's top speed increases by one for a number of rounds equal to Cunning. The ship still cannot perform actions or maneuvers it could not perform normally. (i.e. actions that have a minimum speed requirement)";
        ParentTalents = parents;
        TalentXPCost = xpCost;
    }
}

public class FullThrottleImprovedTalent : BaseEotETalent
{

    public FullThrottleImprovedTalent()
    {
        TalentName = "Full Throttle (Improved)";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.MANEUVER };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.PILOT };
        TalentDescription = "The character may voluntarily suffer one strain to attempt Full Throttle as a maneuver. In addition, the difficulty of Full Throttle is reduced to Average (2 Difficulty).";
    }
    public FullThrottleImprovedTalent(bool root, int xpCost)
    {
        TalentName = "Full Throttle (Improved)";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.MANEUVER };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.PILOT };
        TalentDescription = "The character may voluntarily suffer one strain to attempt Full Throttle as a maneuver. In addition, the difficulty of Full Throttle is reduced to Average (2 Difficulty).";
        IsRoot = root;
        TalentXPCost = xpCost;
    }
    public FullThrottleImprovedTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Full Throttle (Improved)";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.MANEUVER };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.PILOT };
        TalentDescription = "The character may voluntarily suffer one strain to attempt Full Throttle as a maneuver. In addition, the difficulty of Full Throttle is reduced to Average (2 Difficulty).";
        ParentTalents = parents;
        TalentXPCost = xpCost;
    }
}

public class FullThrottleSupremeTalent : BaseEotETalent
{

    public FullThrottleSupremeTalent()
    {
        TalentName = "Full Throttle (Supreme)";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.PILOT };
        TalentDescription = "When the character successfully performs Full Throttle, the ship's top speed increases by two for a number of rounds equal to his Cunning instead of one.";
    }
    public FullThrottleSupremeTalent(bool root, int xpCost)
    {
        TalentName = "Full Throttle (Supreme)";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.PILOT };
        TalentDescription = "When the character successfully performs Full Throttle, the ship's top speed increases by two for a number of rounds equal to his Cunning instead of one.";
        IsRoot = root;
        TalentXPCost = xpCost;
    }
    public FullThrottleSupremeTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Full Throttle (Supreme)";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.PILOT };
        TalentDescription = "When the character successfully performs Full Throttle, the ship's top speed increases by two for a number of rounds equal to his Cunning instead of one.";
        ParentTalents = parents;
        TalentXPCost = xpCost;
    }
}

public class GalaxyMapperTalent : BaseEotETalent
{

    public GalaxyMapperTalent()
    {
        TalentName = "Galaxy Mapper";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.FRINGER, Trees.PILOT };
        TalentDescription = "Remove [Setback] per rank of Galaxy Mapper from all Astrogation checks. In addition, Astrogation checks take 50% less time. This does not increase with multiple ranks of Galaxy Mapper.";
    }
    public GalaxyMapperTalent(bool root, int xpCost)
    {
        TalentName = "Galaxy Mapper";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.FRINGER, Trees.PILOT };
        TalentDescription = "Remove [Setback] per rank of Galaxy Mapper from all Astrogation checks. In addition, Astrogation checks take 50% less time. This does not increase with multiple ranks of Galaxy Mapper.";
        IsRoot = root;
        TalentXPCost = xpCost;
    }
    public GalaxyMapperTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Galaxy Mapper";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.FRINGER, Trees.PILOT };
        TalentDescription = "Remove [Setback] per rank of Galaxy Mapper from all Astrogation checks. In addition, Astrogation checks take 50% less time. This does not increase with multiple ranks of Galaxy Mapper.";
        ParentTalents = parents;
        TalentXPCost = xpCost;
    }
}

public class GearheadTalent : BaseEotETalent
{

    public GearheadTalent()
    {
        TalentName = "Gearhead";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.MECHANIC };
        TalentDescription = "Remove [Setback] per rank of Gearhead from all Mechanics checks. In addition, the credit cost to add mods to attachments decreases by 50%. This does not increase with multiple ranks of Gearhead.";
    }
    public GearheadTalent(bool root, int xpCost)
    {
        TalentName = "Gearhead";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.MECHANIC };
        TalentDescription = "Remove [Setback] per rank of Gearhead from all Mechanics checks. In addition, the credit cost to add mods to attachments decreases by 50%. This does not increase with multiple ranks of Gearhead.";
        IsRoot = root;
        TalentXPCost = xpCost;
    }
    public GearheadTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Gearhead";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.MECHANIC };
        TalentDescription = "Remove [Setback] per rank of Gearhead from all Mechanics checks. In addition, the credit cost to add mods to attachments decreases by 50%. This does not increase with multiple ranks of Gearhead.";
        ParentTalents = parents;
        TalentXPCost = xpCost;
    }
}

public class GritTalent : BaseEotETalent
{

    public GritTalent()
    {
        TalentName = "Grit";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.ASSASSIN, Trees.BODYGUARD, Trees.DOCTOR, Trees.FRINGER, Trees.MECHANIC, Trees.MERCENARYSOLDIER, Trees.OUTLAWTECH, Trees.PILOT, Trees.POLITICO, Trees.SCHOLAR, Trees.SCOUT, Trees.SLICER, Trees.SURVIVALIST, Trees.THIEF, Trees.TRADER };
        TalentDescription = "Each rank of Grit increasess a character's strain threshold by one.";
    }

    public GritTalent(bool root, int xpCost)
    {
        TalentName = "Grit";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.ASSASSIN, Trees.BODYGUARD, Trees.DOCTOR, Trees.FRINGER, Trees.MECHANIC, Trees.MERCENARYSOLDIER, Trees.OUTLAWTECH, Trees.PILOT, Trees.POLITICO, Trees.SCHOLAR, Trees.SCOUT, Trees.SLICER, Trees.SURVIVALIST, Trees.THIEF, Trees.TRADER };
        TalentDescription = "Each rank of Grit increasess a character's strain threshold by one.";
        IsRoot = root;
        TalentXPCost = xpCost;
    }

    public GritTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Grit";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.ASSASSIN, Trees.BODYGUARD, Trees.DOCTOR, Trees.FRINGER, Trees.MECHANIC, Trees.MERCENARYSOLDIER, Trees.OUTLAWTECH, Trees.PILOT, Trees.POLITICO, Trees.SCHOLAR, Trees.SCOUT, Trees.SLICER, Trees.SURVIVALIST, Trees.THIEF, Trees.TRADER };
        TalentDescription = "Each rank of Grit increasess a character's strain threshold by one.";
        ParentTalents = parents;
        TalentXPCost = xpCost;
    }
}

public class HardHeadedTalent : BaseEotETalent
{

    public HardHeadedTalent()
    {
        TalentName = "Hard Headed";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.ACTION };
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.BODYGUARD, Trees.MECHANIC };
        TalentDescription = "The character may perform the Hard Headed action. On any turn in which the character is staggered or disoriented, he may perform the Hard Headed action (this action may be specifically performed even though he is normally barred from performing actions when staggered). He makes a Daunting (4 Difficulty) Discipline check. If he succeeds, he is no longer staggered or disoriented. The difficulty of this check decreases by one per additional rank of Hard Headed to a minimum of Easy (1 Difficulty).";
    }
    public HardHeadedTalent(bool root, int xpCost)
    {
        TalentName = "Hard Headed";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.ACTION };
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.BODYGUARD, Trees.MECHANIC };
        TalentDescription = "The character may perform the Hard Headed action. On any turn in which the character is staggered or disoriented, he may perform the Hard Headed action (this action may be specifically performed even though he is normally barred from performing actions when staggered). He makes a Daunting (4 Difficulty) Discipline check. If he succeeds, he is no longer staggered or disoriented. The difficulty of this check decreases by one per additional rank of Hard Headed to a minimum of Easy (1 Difficulty).";
        IsRoot = root;
        TalentXPCost = xpCost;
    }
    public HardHeadedTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Hard Headed";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.ACTION };
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.BODYGUARD, Trees.MECHANIC };
        TalentDescription = "The character may perform the Hard Headed action. On any turn in which the character is staggered or disoriented, he may perform the Hard Headed action (this action may be specifically performed even though he is normally barred from performing actions when staggered). He makes a Daunting (4 Difficulty) Discipline check. If he succeeds, he is no longer staggered or disoriented. The difficulty of this check decreases by one per additional rank of Hard Headed to a minimum of Easy (1 Difficulty).";
        ParentTalents = parents;
        TalentXPCost = xpCost;
    }
}

public class HardHeadedImprovedTalent : BaseEotETalent
{

    public HardHeadedImprovedTalent()
    {
        TalentName = "Hard Headed (Improved)";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.ACTION };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.BODYGUARD };
        TalentDescription = "The character may use his Hard Headed action to recover from being incapacitated due to exceeding his strain threshold. On his next turn after being incapacitated, he may make a Formidable (5 Difficulty) Discipline check as his Hard Headed action (this action can specifically be performed even though he is normally barred from performing actions). If he succeeds, decrease his strain to one below his strain threshold. The difficulty of this check decreases by one per rank of Hard Headed to a minimum of Easy (1 Difficulty).";
    }
    public HardHeadedImprovedTalent(bool root, int xpCost)
    {
        TalentName = "Hard Headed (Improved)";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.ACTION };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.BODYGUARD };
        TalentDescription = "The character may use his Hard Headed action to recover from being incapacitated due to exceeding his strain threshold. On his next turn after being incapacitated, he may make a Formidable (5 Difficulty) Discipline check as his Hard Headed action (this action can specifically be performed even though he is normally barred from performing actions). If he succeeds, decrease his strain to one below his strain threshold. The difficulty of this check decreases by one per rank of Hard Headed to a minimum of Easy (1 Difficulty).";
        IsRoot = root;
        TalentXPCost = xpCost;
    }
    public HardHeadedImprovedTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Hard Headed (Improved)";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.ACTION };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.BODYGUARD };
        TalentDescription = "The character may use his Hard Headed action to recover from being incapacitated due to exceeding his strain threshold. On his next turn after being incapacitated, he may make a Formidable (5 Difficulty) Discipline check as his Hard Headed action (this action can specifically be performed even though he is normally barred from performing actions). If he succeeds, decrease his strain to one below his strain threshold. The difficulty of this check decreases by one per rank of Hard Headed to a minimum of Easy (1 Difficulty).";
        ParentTalents = parents;
        TalentXPCost = xpCost;
    }
}

public class HeightenedAwarenessTalent : BaseEotETalent
{

    public HeightenedAwarenessTalent()
    {
        TalentName = "Heightened Awareness";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.SCOUT };
        TalentDescription = "Allies within close range of the character add [Boost] to their Perception and Vigilance checks. Allies engaged with him add [2 Boost] instead.";
    }
    public HeightenedAwarenessTalent(bool root, int xpCost)
    {
        TalentName = "Heightened Awareness";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.SCOUT };
        TalentDescription = "Allies within close range of the character add [Boost] to their Perception and Vigilance checks. Allies engaged with him add [2 Boost] instead.";
        IsRoot = root;
        TalentXPCost = xpCost;
    }
    public HeightenedAwarenessTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Heightened Awareness";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.SCOUT };
        TalentDescription = "Allies within close range of the character add [Boost] to their Perception and Vigilance checks. Allies engaged with him add [2 Boost] instead.";
        ParentTalents = parents;
        TalentXPCost = xpCost;
    }
}

/*END OF TABLE 4-1: TALENT LIST Page 1*/

/*BEGINNING OF TABLE 4-1: TALENT LIST Page 2*/
public class HeroicFortitudeTalent : BaseEotETalent
{
    public HeroicFortitudeTalent()
    {
        TalentName = "Heroic Fortitude";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.MARAUDER, Trees.SURVIVALIST };
        TalentDescription = "The character may spend one Destiny Point to ignore the effects of ongoing Critical Injuries on any Brawn or Agility related checks until the end of the encounter. He still suffers from the injury itself.";
    }
    public HeroicFortitudeTalent(bool root, int xpCost)
    {
        TalentName = "Heroic Fortitude";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.MARAUDER, Trees.SURVIVALIST };
        TalentDescription = "The character may spend one Destiny Point to ignore the effects of ongoing Critical Injuries on any Brawn or Agility related checks until the end of the encounter. He still suffers from the injury itself.";
        IsRoot = root;
        TalentXPCost = xpCost;
    }
    public HeroicFortitudeTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Heroic Fortitude";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.MARAUDER, Trees.SURVIVALIST };
        TalentDescription = "The character may spend one Destiny Point to ignore the effects of ongoing Critical Injuries on any Brawn or Agility related checks until the end of the encounter. He still suffers from the injury itself.";
        ParentTalents = parents;
        TalentXPCost = xpCost;
    }
}

public class HiddenStorageTalent : BaseEotETalent
{
    public HiddenStorageTalent()
    {
        TalentName = "Hidden Storage";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.SCOUNDREL, Trees.THIEF };
        TalentDescription = "Any large equipment, vehicle or droid that the character owns has one or more hidden compartments for smuggling appropriately sized gear. The number of compartments is up to the player, but cannot be enought to hold a total encumbrance value of items more than the character's ranks in Hidden Storage. The size of the compartments are proportional to the size of the vehicle or droid in question. Most humanoid droids can only hold items equivalent in size to a one-handed weapon, whereas a silhouette 4 starship could conceal humanoids within its compartments. Any checks to detect these compartments have a Formidable (5 Difficulty) difficulty.";
    }
    public HiddenStorageTalent(bool root, int xpCost)
    {
        TalentName = "Hidden Storage";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.SCOUNDREL, Trees.THIEF };
        TalentDescription = "Any large equipment, vehicle or droid that the character owns has one or more hidden compartments for smuggling appropriately sized gear. The number of compartments is up to the player, but cannot be enought to hold a total encumbrance value of items more than the character's ranks in Hidden Storage. The size of the compartments are proportional to the size of the vehicle or droid in question. Most humanoid droids can only hold items equivalent in size to a one-handed weapon, whereas a silhouette 4 starship could conceal humanoids within its compartments. Any checks to detect these compartments have a Formidable (5 Difficulty) difficulty.";
        IsRoot = root;
        TalentXPCost = xpCost;
    }
    public HiddenStorageTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Hidden Storage";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.SCOUNDREL, Trees.THIEF };
        TalentDescription = "Any large equipment, vehicle or droid that the character owns has one or more hidden compartments for smuggling appropriately sized gear. The number of compartments is up to the player, but cannot be enought to hold a total encumbrance value of items more than the character's ranks in Hidden Storage. The size of the compartments are proportional to the size of the vehicle or droid in question. Most humanoid droids can only hold items equivalent in size to a one-handed weapon, whereas a silhouette 4 starship could conceal humanoids within its compartments. Any checks to detect these compartments have a Formidable (5 Difficulty) difficulty.";
        ParentTalents = parents;
        TalentXPCost = xpCost;
    }
}

public class HoldTogetherTalent : BaseEotETalent
{
    public HoldTogetherTalent()
    {
        TalentName = "Hold Together";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL, ActivationSpec.OUTOFTURN };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.MECHANIC };
        TalentDescription = "The character may spend one Destiny Point to make a Hold Together Incidental immediately after a vehicle or starship he has repaired this encounter takes damage. The character explains why the apparently serious damage was in fact superficial, and the damage from the attack becomes system strain instead.";
    }
    public HoldTogetherTalent(bool root, int xpCost)
    {
        TalentName = "Hold Together";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL, ActivationSpec.OUTOFTURN };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.MECHANIC };
        TalentDescription = "The character may spend one Destiny Point to make a Hold Together Incidental immediately after a vehicle or starship he has repaired this encounter takes damage. The character explains why the apparently serious damage was in fact superficial, and the damage from the attack becomes system strain instead.";
        IsRoot = root;
        TalentXPCost = xpCost;
    }
    public HoldTogetherTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Hold Together";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL, ActivationSpec.OUTOFTURN };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.MECHANIC };
        TalentDescription = "The character may spend one Destiny Point to make a Hold Together Incidental immediately after a vehicle or starship he has repaired this encounter takes damage. The character explains why the apparently serious damage was in fact superficial, and the damage from the attack becomes system strain instead.";
        ParentTalents = parents;
        TalentXPCost = xpCost;
    }
}

public class HunterTalent : BaseEotETalent
{
    public HunterTalent()
    {
        TalentName = "Hunter";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.SURVIVALIST };
        TalentDescription = "The character adds [Boost] per rank of Hunter to all skill checks when interacting with wild beasts and animals, including combat checks. Add +10 per rank to all Critical Injury rolls against animals per rank of Hunter.";
    }
    public HunterTalent(bool root, int xpCost)
    {
        TalentName = "Hunter";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.SURVIVALIST };
        TalentDescription = "The character adds [Boost] per rank of Hunter to all skill checks when interacting with wild beasts and animals, including combat checks. Add +10 per rank to all Critical Injury rolls against animals per rank of Hunter.";
        IsRoot = root;
        TalentXPCost = xpCost;
    }
    public HunterTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Hunter";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.SURVIVALIST };
        TalentDescription = "The character adds [Boost] per rank of Hunter to all skill checks when interacting with wild beasts and animals, including combat checks. Add +10 per rank to all Critical Injury rolls against animals per rank of Hunter.";
        ParentTalents = parents;
        TalentXPCost = xpCost;
    }
}

public class IndistinguishableTalent : BaseEotETalent
{
    public IndistinguishableTalent()
    {
        TalentName = "Indistinguishable";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.THIEF };
        TalentDescription = "The character's appearance is so common that people have a hard time identifying distinguishing traits. Opposing characters upgrade the difficulty of any checks made to identify him once per rank of Indistinguishable.";
    }
    public IndistinguishableTalent(bool root, int xpCost)
    {
        TalentName = "Indistinguishable";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.THIEF };
        TalentDescription = "The character's appearance is so common that people have a hard time identifying distinguishing traits. Opposing characters upgrade the difficulty of any checks made to identify him once per rank of Indistinguishable.";
        IsRoot = root;
        TalentXPCost = xpCost;
    }
    public IndistinguishableTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Indistinguishable";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.THIEF };
        TalentDescription = "The character's appearance is so common that people have a hard time identifying distinguishing traits. Opposing characters upgrade the difficulty of any checks made to identify him once per rank of Indistinguishable.";
        ParentTalents = parents;
        TalentXPCost = xpCost;
    }
}

public class InsightTalent : BaseEotETalent
{
    public InsightTalent()
    {
        TalentName = "Insight";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.FORCESENSITIVEEXILE };
        TalentDescription = "Perception and Discipline become career skills if they are not already.";
    }
    public InsightTalent(bool root, int xpCost)
    {
        TalentName = "Insight";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.FORCESENSITIVEEXILE };
        TalentDescription = "Perception and Discipline become career skills if they are not already.";
        IsRoot = root;
        TalentXPCost = xpCost;
    }
    public InsightTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Insight";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.FORCESENSITIVEEXILE };
        TalentDescription = "Perception and Discipline become career skills if they are not already.";
        ParentTalents = parents;
        TalentXPCost = xpCost;
    }
}

public class InspiringRhetoricTalent : BaseEotETalent
{
    public InspiringRhetoricTalent()
    {
        TalentName = "Inspiring Rhetoric";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.ACTION };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.POLITICO };
        TalentDescription = "The character may take the Inspiring Rhetoric action; making an Average (2 Difficulty) Leadership check. For each [Success], one ally within close range recovers one strain. For each [Advantage], one ally benefitting from Inspiring Rhetoric recovers one additional strain.";
    }
    public InspiringRhetoricTalent(bool root, int xpCost)
    {
        TalentName = "Inspiring Rhetoric";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.ACTION };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.POLITICO };
        TalentDescription = "The character may take the Inspiring Rhetoric action; making an Average (2 Difficulty) Leadership check. For each [Success], one ally within close range recovers one strain. For each [Advantage], one ally benefitting from Inspiring Rhetoric recovers one additional strain.";
        IsRoot = root;
        TalentXPCost = xpCost;
    }
    public InspiringRhetoricTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Inspiring Rhetoric";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.ACTION };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.POLITICO };
        TalentDescription = "The character may take the Inspiring Rhetoric action; making an Average (2 Difficulty) Leadership check. For each [Success], one ally within close range recovers one strain. For each [Advantage], one ally benefitting from Inspiring Rhetoric recovers one additional strain.";
        ParentTalents = parents;
        TalentXPCost = xpCost;
    }
}

public class InspiringRhetoricImprovedTalent : BaseEotETalent
{
    public InspiringRhetoricImprovedTalent()
    {
        TalentName = "Inspiring Rhetoric (Improved)";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.POLITICO };
        TalentDescription = "Each ally affected by Inspiring Rhetoric gains [Boost] on all skill checks for a number of rounds equal to the character's ranks in Leadership; this does not stack with itself.";
    }
    public InspiringRhetoricImprovedTalent(bool root, int xpCost)
    {
        TalentName = "Inspiring Rhetoric (Improved)";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.POLITICO };
        TalentDescription = "Each ally affected by Inspiring Rhetoric gains [Boost] on all skill checks for a number of rounds equal to the character's ranks in Leadership; this does not stack with itself.";
        IsRoot = root;
        TalentXPCost = xpCost;
    }
    public InspiringRhetoricImprovedTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Inspiring Rhetoric (Improved)";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.POLITICO };
        TalentDescription = "Each ally affected by Inspiring Rhetoric gains [Boost] on all skill checks for a number of rounds equal to the character's ranks in Leadership; this does not stack with itself.";
        ParentTalents = parents;
        TalentXPCost = xpCost;
    }
}

public class InspiringRhetoricSupremeTalent : BaseEotETalent
{
    public InspiringRhetoricSupremeTalent()
    {
        TalentName = "Inspiring Rhetoric (Supreme)";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.POLITICO };
        TalentDescription = "The character may voluntarily suffer 1 strain to perform Inspiring Rhetoric as a maneuver instead of an action.";
    }
    public InspiringRhetoricSupremeTalent(bool root, int xpCost)
    {
        TalentName = "Inspiring Rhetoric (Supreme)";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.POLITICO };
        TalentDescription = "The character may voluntarily suffer 1 strain to perform Inspiring Rhetoric as a maneuver instead of an action.";
        IsRoot = root;
        TalentXPCost = xpCost;
    }
    public InspiringRhetoricSupremeTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Inspiring Rhetoric (Supreme)";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.POLITICO };
        TalentDescription = "The character may voluntarily suffer 1 strain to perform Inspiring Rhetoric as a maneuver instead of an action.";
        ParentTalents = parents;
        TalentXPCost = xpCost;
    }
}

public class IntenseFocusTalent : BaseEotETalent
{
    public IntenseFocusTalent()
    {
        TalentName = "Intense Focus";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.MANEUVER };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.FORCESENSITIVEEXILE, Trees.SCHOLAR };
        TalentDescription = "Before making a skill check, the character may perform the Intense Focus maneuver. The character suffers one strain to upgrade the ability of the skill check once.";
    }
    public IntenseFocusTalent(bool root, int xpCost)
    {
        TalentName = "Intense Focus";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.MANEUVER };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.FORCESENSITIVEEXILE, Trees.SCHOLAR };
        TalentDescription = "Before making a skill check, the character may perform the Intense Focus maneuver. The character suffers one strain to upgrade the ability of the skill check once.";
        IsRoot = root;
        TalentXPCost = xpCost;
    }
    public IntenseFocusTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Intense Focus";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.MANEUVER };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.FORCESENSITIVEEXILE, Trees.SCHOLAR };
        TalentDescription = "Before making a skill check, the character may perform the Intense Focus maneuver. The character suffers one strain to upgrade the ability of the skill check once.";
        ParentTalents = parents;
        TalentXPCost = xpCost;
    }
}

public class IntensePresenceTalent : BaseEotETalent
{
    public IntensePresenceTalent()
    {
        TalentName = "Intense Presence";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL, ActivationSpec.OUTOFTURN };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.POLITICO };
        TalentDescription = "The character may spend one Destiny Point to recover strain equal to his Presence rating.";
    }
    public IntensePresenceTalent(bool root, int xpCost)
    {
        TalentName = "Intense Presence";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL, ActivationSpec.OUTOFTURN };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.POLITICO };
        TalentDescription = "The character may spend one Destiny Point to recover strain equal to his Presence rating.";
        IsRoot = root;
        TalentXPCost = xpCost;
    }
    public IntensePresenceTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Intense Presence";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL, ActivationSpec.OUTOFTURN };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.POLITICO };
        TalentDescription = "The character may spend one Destiny Point to recover strain equal to his Presence rating.";
        ParentTalents = parents;
        TalentXPCost = xpCost;
    }
}

public class IntimidatingTalent : BaseEotETalent
{
    public IntimidatingTalent()
    {
        TalentName = "Intimidating";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL, ActivationSpec.OUTOFTURN };
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.GADGETEER };
        TalentDescription = "When attempting a Coercion check, the character may suffer a number of strain to downgrade the difficulty of the check a number of times equal to the strain suffered. The number cannot exceed his ranks in Intimidating. When the character is the target of a Coercion check, the character may suffer a number of strain to upgrade the difficulty of the check a number of times equal to the strain suffered. The number cannot exceed his ranks in Intimidating.";
    }
    public IntimidatingTalent(bool root, int xpCost)
    {
        TalentName = "Intimidating";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL, ActivationSpec.OUTOFTURN };
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.GADGETEER };
        TalentDescription = "When attempting a Coercion check, the character may suffer a number of strain to downgrade the difficulty of the check a number of times equal to the strain suffered. The number cannot exceed his ranks in Intimidating. When the character is the target of a Coercion check, the character may suffer a number of strain to upgrade the difficulty of the check a number of times equal to the strain suffered. The number cannot exceed his ranks in Intimidating.";
        IsRoot = root;
        TalentXPCost = xpCost;
    }
    public IntimidatingTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Intimidating";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL, ActivationSpec.OUTOFTURN };
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.GADGETEER };
        TalentDescription = "When attempting a Coercion check, the character may suffer a number of strain to downgrade the difficulty of the check a number of times equal to the strain suffered. The number cannot exceed his ranks in Intimidating. When the character is the target of a Coercion check, the character may suffer a number of strain to upgrade the difficulty of the check a number of times equal to the strain suffered. The number cannot exceed his ranks in Intimidating.";
        ParentTalents = parents;
        TalentXPCost = xpCost;
    }
}

public class InventorTalent : BaseEotETalent
{
    public InventorTalent()
    {
        TalentName = "Inventor";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.OUTLAWTECH };
        TalentDescription = "When constructing new items or modifying existing attachments, the character may choose to add [Boost] or remove [Setback] from the check per rank of Inventor.";
    }
    public InventorTalent(bool root, int xpCost)
    {
        TalentName = "Inventor";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.OUTLAWTECH };
        TalentDescription = "When constructing new items or modifying existing attachments, the character may choose to add [Boost] or remove [Setback] from the check per rank of Inventor.";
        IsRoot = root;
        TalentXPCost = xpCost;
    }
    public InventorTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Inventor";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.OUTLAWTECH };
        TalentDescription = "When constructing new items or modifying existing attachments, the character may choose to add [Boost] or remove [Setback] from the check per rank of Inventor.";
        ParentTalents = parents;
        TalentXPCost = xpCost;
    }
}

public class JumpUpTalent : BaseEotETalent
{
    public JumpUpTalent()
    {
        TalentName = "Jump Up";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.ASSASSIN, Trees.FRINGER, Trees.THIEF };
        TalentDescription = "Once per round of a character's rurn, the character may stand up from prone or a seated position as an Incidental.";
    }
    public JumpUpTalent(bool root, int xpCost)
    {
        TalentName = "Jump Up";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.ASSASSIN, Trees.FRINGER, Trees.THIEF };
        TalentDescription = "Once per round of a character's rurn, the character may stand up from prone or a seated position as an Incidental.";
        IsRoot = root;
        TalentXPCost = xpCost;
    }
    public JumpUpTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Jump Up";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.ASSASSIN, Trees.FRINGER, Trees.THIEF };
        TalentDescription = "Once per round of a character's rurn, the character may stand up from prone or a seated position as an Incidental.";
        ParentTalents = parents;
        TalentXPCost = xpCost;
    }
}

public class JuryRiggedTalent : BaseEotETalent
{
    public JuryRiggedTalent()
    {
        TalentName = "Jury Rigged";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.GADGETEER, Trees.OUTLAWTECH };
        TalentDescription = "The character chooses one personal weapon or pieve of armor per rank of Jury Rigged. He may increase the damage of the weapon by one; decrease the Advantage cost on its Critical, or any single other effect by one to a minimum of one; or increase armor's ranged or melee defense by one. Alternatively, he can decrease the encumbrance of the item by two to a minimum of one. The bonus only applies so long as the character is using the item. If the item is ever lost or destroyed, the character may apply Jury Rigged to a new personal weapon or piece of armor.";
    }
    public JuryRiggedTalent(bool root, int xpCost)
    {
        TalentName = "Jury Rigged";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.GADGETEER, Trees.OUTLAWTECH };
        TalentDescription = "The character chooses one personal weapon or pieve of armor per rank of Jury Rigged. He may increase the damage of the weapon by one; decrease the Advantage cost on its Critical, or any single other effect by one to a minimum of one; or increase armor's ranged or melee defense by one. Alternatively, he can decrease the encumbrance of the item by two to a minimum of one. The bonus only applies so long as the character is using the item. If the item is ever lost or destroyed, the character may apply Jury Rigged to a new personal weapon or piece of armor.";
        IsRoot = root;
        TalentXPCost = xpCost;
    }
    public JuryRiggedTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Jury Rigged";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.GADGETEER, Trees.OUTLAWTECH };
        TalentDescription = "The character chooses one personal weapon or pieve of armor per rank of Jury Rigged. He may increase the damage of the weapon by one; decrease the Advantage cost on its Critical, or any single other effect by one to a minimum of one; or increase armor's ranged or melee defense by one. Alternatively, he can decrease the encumbrance of the item by two to a minimum of one. The bonus only applies so long as the character is using the item. If the item is ever lost or destroyed, the character may apply Jury Rigged to a new personal weapon or piece of armor.";
        ParentTalents = parents;
        TalentXPCost = xpCost;
    }
}

public class KillWithKindnessTalent : BaseEotETalent
{
    public KillWithKindnessTalent()
    {
        TalentName = "Kill with Kindness";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.POLITICO };
        TalentDescription = "Remove [Setback] per rank of Kill with Kindness from all Charm and Leadership checks the character attempts.";
    }
    public KillWithKindnessTalent(bool root, int xpCost)
    {
        TalentName = "Kill with Kindness";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.POLITICO };
        TalentDescription = "Remove [Setback] per rank of Kill with Kindness from all Charm and Leadership checks the character attempts.";
        IsRoot = root;
        TalentXPCost = xpCost;
    }
    public KillWithKindnessTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Kill with Kindness";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.POLITICO };
        TalentDescription = "Remove [Setback] per rank of Kill with Kindness from all Charm and Leadership checks the character attempts.";
        ParentTalents = parents;
        TalentXPCost = xpCost;
    }
}

public class KnockdownTalent : BaseEotETalent
{
    public KnockdownTalent()
    {
        TalentName = "Knockdown";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.FRINGER, Trees.MARAUDER };
        TalentDescription = "After hitting with a melee attack, the character may knock the target prone by spending a [Triumph]. If the target is larger than the acting character, it requires one additional [Triumph] for each silhouette larger.";
    }
    public KnockdownTalent(bool root, int xpCost)
    {
        TalentName = "Knockdown";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.FRINGER, Trees.MARAUDER };
        TalentDescription = "After hitting with a melee attack, the character may knock the target prone by spending a [Triumph]. If the target is larger than the acting character, it requires one additional [Triumph] for each silhouette larger.";
        IsRoot = root;
        TalentXPCost = xpCost;
    }
    public KnockdownTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Knockdown";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.FRINGER, Trees.MARAUDER };
        TalentDescription = "After hitting with a melee attack, the character may knock the target prone by spending a [Triumph]. If the target is larger than the acting character, it requires one additional [Triumph] for each silhouette larger.";
        ParentTalents = parents;
        TalentXPCost = xpCost;
    }
}

public class KnowSomebodyTalent : BaseEotETalent
{
    public KnowSomebodyTalent()
    {
        TalentName = "Know Somebody";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.TRADER };
        TalentDescription = "Once per game session, when attempting to purchase a legally available item, the character may reduce its rarity by one step per rank of Know Somebody.";
    }
    public KnowSomebodyTalent(bool root, int xpCost)
    {
        TalentName = "Know Somebody";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.TRADER };
        TalentDescription = "Once per game session, when attempting to purchase a legally available item, the character may reduce its rarity by one step per rank of Know Somebody.";
        IsRoot = root;
        TalentXPCost = xpCost;
    }
    public KnowSomebodyTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Know Somebody";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.TRADER };
        TalentDescription = "Once per game session, when attempting to purchase a legally available item, the character may reduce its rarity by one step per rank of Know Somebody.";
        ParentTalents = parents;
        TalentXPCost = xpCost;
    }
}

public class KnowledgeSpecializationTalent : BaseEotETalent
{
    public KnowledgeSpecializationTalent()
    {
        TalentName = "Knowledge Specialization";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.SCHOLAR };
        TalentDescription = "When the character first acquires this talent, he may choose one Knowledge skill. When making checks with that skill, he may spend [Triumph] to gain additional successes equal to his ranks in Knowledge Specialization.";
    }
    public KnowledgeSpecializationTalent(bool root, int xpCost)
    {
        TalentName = "Knowledge Specialization";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.SCHOLAR };
        TalentDescription = "When the character first acquires this talent, he may choose one Knowledge skill. When making checks with that skill, he may spend [Triumph] to gain additional successes equal to his ranks in Knowledge Specialization.";
        IsRoot = root;
        TalentXPCost = xpCost;
    }
    public KnowledgeSpecializationTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Knowledge Specialization";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.SCHOLAR };
        TalentDescription = "When the character first acquires this talent, he may choose one Knowledge skill. When making checks with that skill, he may spend [Triumph] to gain additional successes equal to his ranks in Knowledge Specialization.";
        ParentTalents = parents;
        TalentXPCost = xpCost;
    }
}

public class KnownSchematicTalent : BaseEotETalent
{
    public KnownSchematicTalent()
    {
        TalentName = "Known Schematic";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.MANEUVER };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.OUTLAWTECH };
        TalentDescription = "Once per game session, the character may spend a maneuver to make a Hard (3 Difficulty) Knowledge (Education) check. Success means the character is familiar with a building or capital ship's design. He now knows the location of critical components or facilities within the ship or vehicle, as well as his own location. He can also plan unconventional routes around obstacles. Additional [Success], [Advantage], or [Triumph] results can reveal other useful information at the GM's discretion";
    }
    public KnownSchematicTalent(bool root, int xpCost)
    {
        TalentName = "Known Schematic";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.MANEUVER };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.OUTLAWTECH };
        TalentDescription = "Once per game session, the character may spend a maneuver to make a Hard (3 Difficulty) Knowledge (Education) check. Success means the character is familiar with a building or capital ship's design. He now knows the location of critical components or facilities within the ship or vehicle, as well as his own location. He can also plan unconventional routes around obstacles. Additional [Success], [Advantage], or [Triumph] results can reveal other useful information at the GM's discretion";
        IsRoot = root;
        TalentXPCost = xpCost;
    }
    public KnownSchematicTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Known Schematic";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.MANEUVER };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.OUTLAWTECH };
        TalentDescription = "Once per game session, the character may spend a maneuver to make a Hard (3 Difficulty) Knowledge (Education) check. Success means the character is familiar with a building or capital ship's design. He now knows the location of critical components or facilities within the ship or vehicle, as well as his own location. He can also plan unconventional routes around obstacles. Additional [Success], [Advantage], or [Triumph] results can reveal other useful information at the GM's discretion";
        ParentTalents = parents;
        TalentXPCost = xpCost;
    }
}

public class LetsRideTalent : BaseEotETalent
{
    public LetsRideTalent()
    {
        TalentName = "Let's Ride";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.PILOT, Trees.SCOUT };
        TalentDescription = "Once per round on the character's turn, the character may mount or dismount from a vehicle or beast, or slide into the cockpit or weapon station aboard a starship, as an incidental instead of a maneuver.";
    }
    public LetsRideTalent(bool root, int xpCost)
    {
        TalentName = "Let's Ride";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.PILOT, Trees.SCOUT };
        TalentDescription = "Once per round on the character's turn, the character may mount or dismount from a vehicle or beast, or slide into the cockpit or weapon station aboard a starship, as an incidental instead of a maneuver.";
        IsRoot = root;
        TalentXPCost = xpCost;
    }
    public LetsRideTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Let's Ride";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.PILOT, Trees.SCOUT };
        TalentDescription = "Once per round on the character's turn, the character may mount or dismount from a vehicle or beast, or slide into the cockpit or weapon station aboard a starship, as an incidental instead of a maneuver.";
        ParentTalents = parents;
        TalentXPCost = xpCost;
    }
}

public class LethalBlowsTalent : BaseEotETalent
{
    public LethalBlowsTalent()
    {
        TalentName = "Lethal Blows";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.ASSASSIN, Trees.MARAUDER, Trees.MERCENARYSOLDIER };
        TalentDescription = "The character adds +10 per rank of lethal blows to any Critical Injury rolls inflicted on opponents.";
    }
    public LethalBlowsTalent(bool root, int xpCost)
    {
        TalentName = "Lethal Blows";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.ASSASSIN, Trees.MARAUDER, Trees.MERCENARYSOLDIER };
        TalentDescription = "The character adds +10 per rank of lethal blows to any Critical Injury rolls inflicted on opponents.";
        IsRoot = root;
        TalentXPCost = xpCost;
    }
    public LethalBlowsTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Lethal Blows";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.ASSASSIN, Trees.MARAUDER, Trees.MERCENARYSOLDIER };
        TalentDescription = "The character adds +10 per rank of lethal blows to any Critical Injury rolls inflicted on opponents.";
        ParentTalents = parents;
        TalentXPCost = xpCost;
    }
}

public class MasterDoctorTalent : BaseEotETalent
{
    public MasterDoctorTalent()
    {
        TalentName = "Master Doctor";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.DOCTOR };
        TalentDescription = "Once per round, the character may suffer two strain to decrease the difficulty of his next Medicine check by one to a minimum of Easy (1 Difficulty).";
    }
    public MasterDoctorTalent(bool rooted, int xpCost)
    {
        TalentName = "Master Doctor";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.DOCTOR };
        TalentDescription = "Once per round, the character may suffer two strain to decrease the difficulty of his next Medicine check by one to a minimum of Easy (1 Difficulty).";
        IsRoot = rooted;
        TalentXPCost = xpCost;
    }
    public MasterDoctorTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Master Doctor";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.DOCTOR };
        TalentDescription = "Once per round, the character may suffer two strain to decrease the difficulty of his next Medicine check by one to a minimum of Easy (1 Difficulty).";
        ParentTalents = parents;
        TalentXPCost = xpCost;
    }
}

public class MasterMerchantTalent : BaseEotETalent
{
    public MasterMerchantTalent()
    {
        TalentName = "Master Merchant";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.TRADER };
        TalentDescription = "Before making a check when buying or selling items, or undertaking or paying off Obligation, the character may choose to suffer two strain. If the check succeeds, he sells the item for 25% more than the base cost, buys it for 25% less, pays off an additional one Obligation point, or undertakes one less Obligation point.";
    }
    public MasterMerchantTalent(bool rooted, int xpCost)
    {
        TalentName = "Master Merchant";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.TRADER };
        TalentDescription = "Before making a check when buying or selling items, or undertaking or paying off Obligation, the character may choose to suffer two strain. If the check succeeds, he sells the item for 25% more than the base cost, buys it for 25% less, pays off an additional one Obligation point, or undertakes one less Obligation point.";
        IsRoot = rooted;
        TalentXPCost = xpCost;
    }
    public MasterMerchantTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Master Merchant";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.TRADER };
        TalentDescription = "Before making a check when buying or selling items, or undertaking or paying off Obligation, the character may choose to suffer two strain. If the check succeeds, he sells the item for 25% more than the base cost, buys it for 25% less, pays off an additional one Obligation point, or undertakes one less Obligation point.";
        ParentTalents = parents;
        TalentXPCost = xpCost;
    }
}

public class MasterOfShadowsTalent : BaseEotETalent
{
    public MasterOfShadowsTalent()
    {
        TalentName = "Master of Shadows";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.ASSASSIN, Trees.THIEF };
        TalentDescription = "Once per round, the character may voluntarily suffer two strain to decrease the difficulty of the next Stealth or Skulduggery check by one, to a minimum of Easy (1 Difficulty).";
    }
    public MasterOfShadowsTalent(bool rooted, int xpCost)
    {
        TalentName = "Master of Shadows";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.ASSASSIN, Trees.THIEF };
        TalentDescription = "Once per round, the character may voluntarily suffer two strain to decrease the difficulty of the next Stealth or Skulduggery check by one, to a minimum of Easy (1 Difficulty).";
        IsRoot = rooted;
        TalentXPCost = xpCost;
    }
    public MasterOfShadowsTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Master of Shadows";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.ASSASSIN, Trees.THIEF };
        TalentDescription = "Once per round, the character may voluntarily suffer two strain to decrease the difficulty of the next Stealth or Skulduggery check by one, to a minimum of Easy (1 Difficulty).";
        ParentTalents = parents;
        TalentXPCost = xpCost;
    }
}

public class MasterPilotTalent : BaseEotETalent
{
    public MasterPilotTalent()
    {
        TalentName = "Master Pilot";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.PILOT };
        TalentDescription = "Once per round, when piloting a starship (a ship piloted using the Piloting (Space) skill), the character may voluntarily suffer two strain to perform any action as a maneuver instead.";
    }
    public MasterPilotTalent(bool rooted, int xpCost)
    {
        TalentName = "Master Pilot";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.PILOT };
        TalentDescription = "Once per round, when piloting a starship (a ship piloted using the Piloting (Space) skill), the character may voluntarily suffer two strain to perform any action as a maneuver instead.";
        IsRoot = rooted;
        TalentXPCost = xpCost;
    }
    public MasterPilotTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Master Pilot";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.PILOT };
        TalentDescription = "Once per round, when piloting a starship (a ship piloted using the Piloting (Space) skill), the character may voluntarily suffer two strain to perform any action as a maneuver instead.";
        ParentTalents = parents;
        TalentXPCost = xpCost;
    }
}

public class MasterSlicerTalent : BaseEotETalent
{
    public MasterSlicerTalent()
    {
        TalentName = "Master Slicer";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.SLICER };
        TalentDescription = "Once per round, the character may perform a Master Slicer incidental to suffer two strain and decrease the difficulty of the next Computers or other slicing related check by one, to a minimum of Easy (1 Difficulty).";
    }
    public MasterSlicerTalent(bool rooted, int xpCost)
    {
        TalentName = "Master Slicer";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.SLICER };
        TalentDescription = "Once per round, the character may perform a Master Slicer incidental to suffer two strain and decrease the difficulty of the next Computers or other slicing related check by one, to a minimum of Easy (1 Difficulty).";
        IsRoot = rooted;
        TalentXPCost = xpCost;
    }
    public MasterSlicerTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Master Slicer";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.SLICER };
        TalentDescription = "Once per round, the character may perform a Master Slicer incidental to suffer two strain and decrease the difficulty of the next Computers or other slicing related check by one, to a minimum of Easy (1 Difficulty).";
        ParentTalents = parents;
        TalentXPCost = xpCost;
    }
}

public class MasterStarhopperTalent : BaseEotETalent
{
    public MasterStarhopperTalent()
    {
        TalentName = "Master Starhopper";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.FRINGER };
        TalentDescription = "Once per round, the character may suffer two strain to decrease the difficulty of his next Astrogation check by one, to a minimum of Easy (1 Difficulty).";
    }
    public MasterStarhopperTalent(bool rooted, int xpCost)
    {
        TalentName = "Master Starhopper";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.FRINGER };
        TalentDescription = "Once per round, the character may suffer two strain to decrease the difficulty of his next Astrogation check by one, to a minimum of Easy (1 Difficulty).";
        IsRoot = rooted;
        TalentXPCost = xpCost;
    }
    public MasterStarhopperTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Master Starhopper";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.FRINGER };
        TalentDescription = "Once per round, the character may suffer two strain to decrease the difficulty of his next Astrogation check by one, to a minimum of Easy (1 Difficulty).";
        ParentTalents = parents;
        TalentXPCost = xpCost;
    }
}

public class MentalFortressTalent : BaseEotETalent
{
    public MentalFortressTalent()
    {
        TalentName = "Mental Fortress";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.SCHOLAR, Trees.SLICER };
        TalentDescription = "The character may spend one Destiny Point to ignore the efects of ongoing Critical Injuries on any Intellect or Cunning related checks until the end of the encounter. He still suffers from the injury itself.";
    }
    public MentalFortressTalent(bool rooted, int xpCost)
    {
        TalentName = "Mental Fortress";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.SCHOLAR, Trees.SLICER };
        TalentDescription = "The character may spend one Destiny Point to ignore the efects of ongoing Critical Injuries on any Intellect or Cunning related checks until the end of the encounter. He still suffers from the injury itself.";
        IsRoot = rooted;
        TalentXPCost = xpCost;
    }
    public MentalFortressTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Mental Fortress";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.SCHOLAR, Trees.SLICER };
        TalentDescription = "The character may spend one Destiny Point to ignore the efects of ongoing Critical Injuries on any Intellect or Cunning related checks until the end of the encounter. He still suffers from the injury itself.";
        ParentTalents = parents;
        TalentXPCost = xpCost;
    }
}

public class NaturalBrawlerTalent : BaseEotETalent
{
    public NaturalBrawlerTalent()
    {
        TalentName = "Natural Brawler";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.MARAUDER };
        TalentDescription = "Once per game session, the character may reroll any one Brawl or Melee check.";
    }
    public NaturalBrawlerTalent(bool rooted, int xpCost)
    {
        TalentName = "Natural Brawler";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.MARAUDER };
        TalentDescription = "Once per game session, the character may reroll any one Brawl or Melee check.";
        IsRoot = rooted;
        TalentXPCost = xpCost;
    }
    public NaturalBrawlerTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Natural Brawler";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.MARAUDER };
        TalentDescription = "Once per game session, the character may reroll any one Brawl or Melee check.";
        ParentTalents = parents;
        TalentXPCost = xpCost;
    }
}

public class NaturalCharmerTalent : BaseEotETalent
{
    public NaturalCharmerTalent()
    {
        TalentName = "Natural Charmer";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.POLITICO, Trees.SCOUNDREL };
        TalentDescription = "Once per game session, the character may reroll any one Charm or Deception check.";
    }
    public NaturalCharmerTalent(bool rooted, int xpCost)
    {
        TalentName = "Natural Charmer";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.POLITICO, Trees.SCOUNDREL };
        TalentDescription = "Once per game session, the character may reroll any one Charm or Deception check.";
        IsRoot = rooted;
        TalentXPCost = xpCost;
    }
    public NaturalCharmerTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Natural Charmer";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.POLITICO, Trees.SCOUNDREL };
        TalentDescription = "Once per game session, the character may reroll any one Charm or Deception check.";
        ParentTalents = parents;
        TalentXPCost = xpCost;
    }
}

public class NaturalDoctorTalent : BaseEotETalent
{
    public NaturalDoctorTalent()
    {
        TalentName = "Natural Doctor";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.DOCTOR };
        TalentDescription = "Once per game session, the character may reroll any one Medicine check.";
    }
    public NaturalDoctorTalent(bool rooted, int xpCost)
    {
        TalentName = "Natural Doctor";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.DOCTOR };
        TalentDescription = "Once per game session, the character may reroll any one Medicine check.";
        IsRoot = rooted;
        TalentXPCost = xpCost;
    }
    public NaturalDoctorTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Natural Doctor";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.DOCTOR };
        TalentDescription = "Once per game session, the character may reroll any one Medicine check.";
        ParentTalents = parents;
        TalentXPCost = xpCost;
    }
}

public class NaturalEnforcerTalent : BaseEotETalent
{
    public NaturalEnforcerTalent()
    {
        TalentName = "Natural Enforcer";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.GADGETEER };
        TalentDescription = "Once per game session, the character may reroll any Coercion or Streetwise check.";
    }
    public NaturalEnforcerTalent(bool rooted, int xpCost)
    {
        TalentName = "Natural Enforcer";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.GADGETEER };
        TalentDescription = "Once per game session, the character may reroll any Coercion or Streetwise check.";
        IsRoot = rooted;
        TalentXPCost = xpCost;
    }
    public NaturalEnforcerTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Natural Enforcer";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.GADGETEER };
        TalentDescription = "Once per game session, the character may reroll any Coercion or Streetwise check.";
        ParentTalents = parents;
        TalentXPCost = xpCost;
    }
}

public class NaturalHunterTalent : BaseEotETalent
{
    public NaturalHunterTalent()
    {
        TalentName = "Natural Hunter";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.SCOUT };
        TalentDescription = "Once per game session, the character may reroll any one Perception or Vigilance check.";
    }
    public NaturalHunterTalent(bool rooted, int xpCost)
    {
        TalentName = "Natural Hunter";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.SCOUT };
        TalentDescription = "Once per game session, the character may reroll any one Perception or Vigilance check.";
        IsRoot = rooted;
        TalentXPCost = xpCost;
    }
    public NaturalHunterTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Natural Hunter";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.SCOUT };
        TalentDescription = "Once per game session, the character may reroll any one Perception or Vigilance check.";
        ParentTalents = parents;
        TalentXPCost = xpCost;
    }
}

public class NaturalMarksmanTalent : BaseEotETalent
{
    public NaturalMarksmanTalent()
    {
        TalentName = "Natural Marksman";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.MERCENARYSOLDIER };
        TalentDescription = "Once per game session, the character may reroll any one Ranged (Light) or Ranged (Heavy) check.";
    }
    public NaturalMarksmanTalent(bool rooted, int xpCost)
    {
        TalentName = "Natural Marksman";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.MERCENARYSOLDIER };
        TalentDescription = "Once per game session, the character may reroll any one Ranged (Light) or Ranged (Heavy) check.";
        IsRoot = rooted;
        TalentXPCost = xpCost;
    }
    public NaturalMarksmanTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Natural Marksman";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.MERCENARYSOLDIER };
        TalentDescription = "Once per game session, the character may reroll any one Ranged (Light) or Ranged (Heavy) check.";
        ParentTalents = parents;
        TalentXPCost = xpCost;
    }
}

public class NaturalNegotiatorTalent : BaseEotETalent
{
    public NaturalNegotiatorTalent()
    {
        TalentName = "NaturalNegotiator";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.TRADER };
        TalentDescription = "Once per game session, the character may reroll any one Cool or Negotiation check.";
    }
    public NaturalNegotiatorTalent(bool rooted, int xpCost)
    {
        TalentName = "NaturalNegotiator";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.TRADER };
        TalentDescription = "Once per game session, the character may reroll any one Cool or Negotiation check.";
        IsRoot = rooted;
        TalentXPCost = xpCost;
    }
    public NaturalNegotiatorTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "NaturalNegotiator";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.TRADER };
        TalentDescription = "Once per game session, the character may reroll any one Cool or Negotiation check.";
        ParentTalents = parents;
        TalentXPCost = xpCost;
    }
}

public class NaturalOutdoorsmanTalent : BaseEotETalent
{
    public NaturalOutdoorsmanTalent()
    {
        TalentName = "Natural Outdoorsman";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.SURVIVALIST };
        TalentDescription = "Once per game session, the character may reroll any one Resilience or Survival check.";
    }
    public NaturalOutdoorsmanTalent(bool rooted, int xpCost)
    {
        TalentName = "Natural Outdoorsman";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.SURVIVALIST };
        TalentDescription = "Once per game session, the character may reroll any one Resilience or Survival check.";
        IsRoot = rooted;
        TalentXPCost = xpCost;
    }
    public NaturalOutdoorsmanTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Natural Outdoorsman";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.SURVIVALIST };
        TalentDescription = "Once per game session, the character may reroll any one Resilience or Survival check.";
        ParentTalents = parents;
        TalentXPCost = xpCost;
    }
}

public class NaturalPilotTalent : BaseEotETalent
{
    public NaturalPilotTalent()
    {
        TalentName = "Natural Pilot";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.PILOT };
        TalentDescription = "Once per game session, the character may reroll any Piloting (Space) or Gunnery check.";
    }
    public NaturalPilotTalent(bool rooted, int xpCost)
    {
        TalentName = "Natural Pilot";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.PILOT };
        TalentDescription = "Once per game session, the character may reroll any Piloting (Space) or Gunnery check.";
        IsRoot = rooted;
        TalentXPCost = xpCost;
    }
    public NaturalPilotTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Natural Pilot";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.PILOT };
        TalentDescription = "Once per game session, the character may reroll any Piloting (Space) or Gunnery check.";
        ParentTalents = parents;
        TalentXPCost = xpCost;
    }
}

public class NaturalProgrammerTalent : BaseEotETalent
{
    public NaturalProgrammerTalent()
    {
        TalentName = "Natural Programmer";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.SLICER };
        TalentDescription = "Once per game session, the character may reroll any one Computers or Astrogation check.";
    }
    public NaturalProgrammerTalent(bool rooted, int xpCost)
    {
        TalentName = "Natural Programmer";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.SLICER };
        TalentDescription = "Once per game session, the character may reroll any one Computers or Astrogation check.";
        IsRoot = rooted;
        TalentXPCost = xpCost;
    }
    public NaturalProgrammerTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Natural Programmer";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.SLICER };
        TalentDescription = "Once per game session, the character may reroll any one Computers or Astrogation check.";
        ParentTalents = parents;
        TalentXPCost = xpCost;
    }
}

public class NaturalRogueTalent : BaseEotETalent
{
    public NaturalRogueTalent()
    {
        TalentName = "Natural Rogue";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.THIEF };
        TalentDescription = "Once per game session, the character may reroll any one Skulduggery, or Stealth check.";
    }
    public NaturalRogueTalent(bool rooted, int xpCost)
    {
        TalentName = "Natural Rogue";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.THIEF };
        TalentDescription = "Once per game session, the character may reroll any one Skulduggery, or Stealth check.";
        IsRoot = rooted;
        TalentXPCost = xpCost;
    }
    public NaturalRogueTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Natural Rogue";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.THIEF };
        TalentDescription = "Once per game session, the character may reroll any one Skulduggery, or Stealth check.";
        ParentTalents = parents;
        TalentXPCost = xpCost;
    }
}

public class NaturalScholarTalent : BaseEotETalent
{
    public NaturalScholarTalent()
    {
        TalentName = "Natural Scholar";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.SCHOLAR };
        TalentDescription = "Once per game session, the character may reroll any one Knowledge skill check.";
    }
    public NaturalScholarTalent(bool rooted, int xpCost)
    {
        TalentName = "Natural Scholar";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.SCHOLAR };
        TalentDescription = "Once per game session, the character may reroll any one Knowledge skill check.";
        IsRoot = rooted;
        TalentXPCost = xpCost;
    }
    public NaturalScholarTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Natural Scholar";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.SCHOLAR };
        TalentDescription = "Once per game session, the character may reroll any one Knowledge skill check.";
        ParentTalents = parents;
        TalentXPCost = xpCost;
    }
}

public class NaturalTinkererTalent : BaseEotETalent
{
    public NaturalTinkererTalent()
    {
        TalentName = "Natural Tinkerer";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.MECHANIC };
        TalentDescription = "Once per game session, the character may reroll any one Mechanics check.";
    }
    public NaturalTinkererTalent(bool rooted, int xpCost)
    {
        TalentName = "Natural Tinkerer";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.MECHANIC };
        TalentDescription = "Once per game session, the character may reroll any one Mechanics check.";
        IsRoot = rooted;
        TalentXPCost = xpCost;
    }
    public NaturalTinkererTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Natural Tinkerer";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.MECHANIC };
        TalentDescription = "Once per game session, the character may reroll any one Mechanics check.";
        ParentTalents = parents;
        TalentXPCost = xpCost;
    }
}

public class NobodysFoolTalent : BaseEotETalent
{
    public NobodysFoolTalent()
    {
        TalentName = "Nobody's Fool";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.POLITICO, Trees.TRADER };
        TalentDescription = "The difficulty of any Charm, Coercion, or Deception checks attempted against the character is upgraded once for each rank of Nobody's Fool.";
    }
    public NobodysFoolTalent(bool rooted, int xpCost)
    {
        TalentName = "Nobody's Fool";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.POLITICO, Trees.TRADER };
        TalentDescription = "The difficulty of any Charm, Coercion, or Deception checks attempted against the character is upgraded once for each rank of Nobody's Fool.";
        IsRoot = rooted;
        TalentXPCost = xpCost;
    }
    public NobodysFoolTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Nobody's Fool";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.POLITICO, Trees.TRADER };
        TalentDescription = "The difficulty of any Charm, Coercion, or Deception checks attempted against the character is upgraded once for each rank of Nobody's Fool.";
        ParentTalents = parents;
        TalentXPCost = xpCost;
    }
}

public class OutdoorsmanTalent : BaseEotETalent
{
    public OutdoorsmanTalent()
    {
        TalentName = "Outdoorsman";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.SURVIVALIST };
        TalentDescription = "The character removes [Setback] per rank of Outdoorsman from checks to move through terrain or manage terrain or environmental effects. Decrease overland travel times by 50% (this does not decrease with multiple ranks of Outdoorsman).";
    }
    public OutdoorsmanTalent(bool rooted, int xpCost)
    {
        TalentName = "Outdoorsman";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.SURVIVALIST };
        IsRoot = rooted;
        TalentXPCost = xpCost;
        TalentDescription = "The character removes [Setback] per rank of Outdoorsman from checks to move through terrain or manage terrain or environmental effects. Decrease overland travel times by 50% (this does not decrease with multiple ranks of Outdoorsman).";
    }
    public OutdoorsmanTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Outdoorsman";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.SURVIVALIST };
        ParentTalents = parents;
        TalentXPCost = xpCost;
        TalentDescription = "The character removes [Setback] per rank of Outdoorsman from checks to move through terrain or manage terrain or environmental effects. Decrease overland travel times by 50% (this does not decrease with multiple ranks of Outdoorsman).";
    }
}

public class OverwhelmEmotionsTalent : BaseEotETalent
{
    public OverwhelmEmotionsTalent()
    {
        TalentName = "Overwhelm Emotions";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.FORCESENSITIVEEXILE };
        TalentDescription = "When the character performs a Charm, Coercion, or Deception check, he may include [Force Die] equal to his Force rating. Each [Light Side] adds [Success] to Charm checks. Each [Dark Side] adds [Success] to Coercion or Deception checks. However, every [2 Light Side] add [Failure] to Coercion and Deception checks, and every [2 Dark Side] add [Failure] to Charm checks. This does not apply to targets immune to Force powers.";
    }
    public OverwhelmEmotionsTalent(bool rooted, int xpCost)
    {
        TalentName = "Overwhelm Emotions";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.FORCESENSITIVEEXILE };
        IsRoot = rooted;
        TalentXPCost = xpCost;
        TalentDescription = "When the character performs a Charm, Coercion, or Deception check, he may include [Force Die] equal to his Force rating. Each [Light Side] adds [Success] to Charm checks. Each [Dark Side] adds [Success] to Coercion or Deception checks. However, every [2 Light Side] add [Failure] to Coercion and Deception checks, and every [2 Dark Side] add [Failure] to Charm checks. This does not apply to targets immune to Force powers.";
    }
    public OverwhelmEmotionsTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Overwhelm Emotions";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.FORCESENSITIVEEXILE };
        ParentTalents = parents;
        TalentXPCost = xpCost;
        TalentDescription = "When the character performs a Charm, Coercion, or Deception check, he may include [Force Die] equal to his Force rating. Each [Light Side] adds [Success] to Charm checks. Each [Dark Side] adds [Success] to Coercion or Deception checks. However, every [2 Light Side] add [Failure] to Coercion and Deception checks, and every [2 Dark Side] add [Failure] to Charm checks. This does not apply to targets immune to Force powers.";
    }
}

public class PlausibleDeniabilityTalent : BaseEotETalent
{
    public PlausibleDeniabilityTalent()
    {
        TalentName = "Plausible Deniability";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.POLITICO };
        TalentDescription = "Remove [Setback] per rank of Plausible Deniability from all Coercion and Deception checks the character attempts.";
    }
    public PlausibleDeniabilityTalent(bool rooted, int xpCost)
    {
        TalentName = "Plausible Deniability";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.POLITICO };
        IsRoot = rooted;
        TalentXPCost = xpCost;
        TalentDescription = "Remove [Setback] per rank of Plausible Deniability from all Coercion and Deception checks the character attempts.";
    }
    public PlausibleDeniabilityTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Plausible Deniability";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.POLITICO };
        ParentTalents = parents;
        TalentXPCost = xpCost;
        TalentDescription = "Remove [Setback] per rank of Plausible Deniability from all Coercion and Deception checks the character attempts.";
    }
}

public class PointBlankTalent : BaseEotETalent
{
    public PointBlankTalent()
    {
        TalentName = "Point Blank";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.GADGETEER, Trees.MERCENARYSOLDIER };
        TalentDescription = "The character adds one damage per rank of Point Blank to one hit of successful Ranged (Heavy) or Ranged (Light) attacks made while at short range or engaged.";
    }
    public PointBlankTalent(bool rooted, int xpCost)
    {
        TalentName = "Point Blank";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.GADGETEER, Trees.MERCENARYSOLDIER };
        IsRoot = rooted;
        TalentXPCost = xpCost;
        TalentDescription = "The character adds one damage per rank of Point Blank to one hit of successful Ranged (Heavy) or Ranged (Light) attacks made while at short range or engaged.";
    }
    public PointBlankTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Point Blank";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.GADGETEER, Trees.MERCENARYSOLDIER };
        ParentTalents = parents;
        TalentXPCost = xpCost;
        TalentDescription = "The character adds one damage per rank of Point Blank to one hit of successful Ranged (Heavy) or Ranged (Light) attacks made while at short range or engaged.";
    }
}

public class PreciseAimTalent : BaseEotETalent
{
    public PreciseAimTalent()
    {
        TalentName = "Precise Aim";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.MANEUVER };
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.ASSASSIN };
        TalentDescription = "Once per round on the character's turn, the character may perform a Precise Aim maneuver before attempting a combat check and suffer a number of strain. The number of strain cannot exceed his ranks in Precise Aim. He then decreases the target's defense (ranged and melee) by one per strain suffered for that combat check.";
    }
    public PreciseAimTalent(bool rooted, int xpCost)
    {
        TalentName = "Precise Aim";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.MANEUVER };
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.ASSASSIN };
        IsRoot = rooted;
        TalentXPCost = xpCost;
        TalentDescription = "Once per round on the character's turn, the character may perform a Precise Aim maneuver before attempting a combat check and suffer a number of strain. The number of strain cannot exceed his ranks in Precise Aim. He then decreases the target's defense (ranged and melee) by one per strain suffered for that combat check.";
    }
    public PreciseAimTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Precise Aim";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.MANEUVER };
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.ASSASSIN };
        ParentTalents = parents;
        TalentXPCost = xpCost;
        TalentDescription = "Once per round on the character's turn, the character may perform a Precise Aim maneuver before attempting a combat check and suffer a number of strain. The number of strain cannot exceed his ranks in Precise Aim. He then decreases the target's defense (ranged and melee) by one per strain suffered for that combat check.";
    }
}

public class PressurePointTalent : BaseEotETalent
{
    public PressurePointTalent()
    {
        TalentName = "Pressure Point";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.DOCTOR };
        TalentDescription = "When making a Brawl check against a living opponent, the character may choose to forgo dealing damage as wounds, instead dealing the equivilant damage as strain, plus additional strain equal to his ranks in Medicine. These checks cannot be made with any weapons, but this strain damage is not reduced by soak.";
    }
    public PressurePointTalent(bool root, int xpCost)
    {
        TalentName = "Pressure Point";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.DOCTOR };
        IsRoot = root;
        TalentXPCost = xpCost;
        TalentDescription = "When making a Brawl check against a living opponent, the character may choose to forgo dealing damage as wounds, instead dealing the equivilant damage as strain, plus additional strain equal to his ranks in Medicine. These checks cannot be made with any weapons, but this strain damage is not reduced by soak.";
    }
    public PressurePointTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Pressure Point";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.DOCTOR };
        ParentTalents = parents;
        TalentXPCost = xpCost;
        TalentDescription = "When making a Brawl check against a living opponent, the character may choose to forgo dealing damage as wounds, instead dealing the equivilant damage as strain, plus additional strain equal to his ranks in Medicine. These checks cannot be made with any weapons, but this strain damage is not reduced by soak.";
    }
}

public class QuickDrawTalent : BaseEotETalent
{
    public QuickDrawTalent()
    {
        TalentName = "Quick Draw";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.ASSASSIN, Trees.FORCESENSITIVEEXILE, Trees.SCOUNDREL };
        TalentDescription = "Once per round on the character's turn, he may draw or holdter an easily accessible weapon as an incidental, not a maneuver. This talent also reduces the amount of time to draw or stow a weapon that usually requires more than one maneuver to properly prepare or stow, by one maneuver.";
    }
    public QuickDrawTalent(bool root, int xpCost)
    {
        TalentName = "Quick Draw";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.ASSASSIN, Trees.FORCESENSITIVEEXILE, Trees.SCOUNDREL };
        IsRoot = root;
        TalentXPCost = xpCost;
        TalentDescription = "Once per round on the character's turn, he may draw or holdter an easily accessible weapon as an incidental, not a maneuver. This talent also reduces the amount of time to draw or stow a weapon that usually requires more than one maneuver to properly prepare or stow, by one maneuver.";
    }
    public QuickDrawTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Quick Draw";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.ASSASSIN, Trees.FORCESENSITIVEEXILE, Trees.SCOUNDREL };
        ParentTalents = parents;
        TalentXPCost = xpCost;
        TalentDescription = "Once per round on the character's turn, he may draw or holdter an easily accessible weapon as an incidental, not a maneuver. This talent also reduces the amount of time to draw or stow a weapon that usually requires more than one maneuver to properly prepare or stow, by one maneuver.";
    }
}

/*END OF TABLE 4-1: TALENT LIST Page 2*/

/*BEGINNING OF TABLE 4-1: TALENT LIST Page 3*/

public class QuickStrikeTalent : BaseEotETalent
{
    public QuickStrikeTalent()
    {
        TalentName = "Quick Strike";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.ASSASSIN, Trees.SCOUNDREL, Trees.SCOUT };
        TalentDescription = "When performing a combat check during combat, the character adds [Boost] per rank of Quick Strike to combat checks against any target that has not yet acted in the encounter.";
    }
    public QuickStrikeTalent(bool root, int xpCost)
    {
        TalentName = "Quick Strike";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.ASSASSIN, Trees.SCOUNDREL, Trees.SCOUT };
        IsRoot = root;
        TalentXPCost = xpCost;
        TalentDescription = "When performing a combat check during combat, the character adds [Boost] per rank of Quick Strike to combat checks against any target that has not yet acted in the encounter.";
    }
    public QuickStrikeTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Quick Strike";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.ASSASSIN, Trees.SCOUNDREL, Trees.SCOUT };
        ParentTalents = parents;
        TalentXPCost = xpCost;
        TalentDescription = "When performing a combat check during combat, the character adds [Boost] per rank of Quick Strike to combat checks against any target that has not yet acted in the encounter.";
    }
}

public class RapidReactionTalent : BaseEotETalent
{
    public RapidReactionTalent()
    {
        TalentName = "Rapid Reaction";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL, ActivationSpec.OUTOFTURN };
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.SCOUNDREL, Trees.THIEF };
        TalentDescription = "The character may suffer a number of strain to add the equal number of [Success] to any Vigilance or Cool check to determine initiative order. The number may not exceed his ranks in Rapid Reaction.";
    }
    public RapidReactionTalent(bool root, int xpCost)
    {
        TalentName = "Rapid Reaction";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL, ActivationSpec.OUTOFTURN };
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.SCOUNDREL, Trees.THIEF };
        IsRoot = root;
        TalentXPCost = xpCost;
        TalentDescription = "The character may suffer a number of strain to add the equal number of [Success] to any Vigilance or Cool check to determine initiative order. The number may not exceed his ranks in Rapid Reaction.";
    }
    public RapidReactionTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Rapid Reaction";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL, ActivationSpec.OUTOFTURN };
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.SCOUNDREL, Trees.THIEF };
        ParentTalents = parents;
        TalentXPCost = xpCost;
        TalentDescription = "The character may suffer a number of strain to add the equal number of [Success] to any Vigilance or Cool check to determine initiative order. The number may not exceed his ranks in Rapid Reaction.";
    }
}

public class RapidRecoveryTalent : BaseEotETalent
{
    public RapidRecoveryTalent()
    {
        TalentName = "Rapid Recovery";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.FRINGER, Trees.PILOT, Trees.SCOUT };
        TalentDescription = "When this character heals strain after an encounter has concluded, he heals one additional strain per rank in Rapid Recovery.";
    }
    public RapidRecoveryTalent(bool root, int xpCost)
    {
        TalentName = "Rapid Recovery";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.FRINGER, Trees.PILOT, Trees.SCOUT };
        IsRoot = root;
        TalentXPCost = xpCost;
        TalentDescription = "When this character heals strain after an encounter has concluded, he heals one additional strain per rank in Rapid Recovery.";
    }
    public RapidRecoveryTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Rapid Recovery";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.FRINGER, Trees.PILOT, Trees.SCOUT };
        ParentTalents = parents;
        TalentXPCost = xpCost;
        TalentDescription = "When this character heals strain after an encounter has concluded, he heals one additional strain per rank in Rapid Recovery.";
    }
}

public class RedundantSystemsTalent : BaseEotETalent
{
    public RedundantSystemsTalent()
    {
        TalentName = "Redundant Systems";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.ACTION };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.MECHANIC };
        TalentDescription = "With an Easy [1 Difficulty] Mechanics check, the character may harvest components from a functioning device to repair a broken one, without breaking the functioning device. This allows the character to repair a broken device without having required spare parts, raw materials, or repair kits (the initial check does not suffer penalties for lacking repair kits, either). This only works, however, if the functioning device is at least the same size and technological level as the device being repaired (it is impossible to repair a starship with a blaster pistol, or a lightsaber with parts from a water wheel).";
    }
    public RedundantSystemsTalent(bool root, int xpCost)
    {
        TalentName = "Redundant Systems";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.ACTION };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.MECHANIC };
        IsRoot = root;
        TalentXPCost = xpCost;
        TalentDescription = "With an Easy [1 Difficulty] Mechanics check, the character may harvest components from a functioning device to repair a broken one, without breaking the functioning device. This allows the character to repair a broken device without having required spare parts, raw materials, or repair kits (the initial check does not suffer penalties for lacking repair kits, either). This only works, however, if the functioning device is at least the same size and technological level as the device being repaired (it is impossible to repair a starship with a blaster pistol, or a lightsaber with parts from a water wheel).";
    }
    public RedundantSystemsTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Redundant Systems";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.ACTION };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.MECHANIC };
        ParentTalents = parents;
        TalentXPCost = xpCost;
        TalentDescription = "With an Easy [1 Difficulty] Mechanics check, the character may harvest components from a functioning device to repair a broken one, without breaking the functioning device. This allows the character to repair a broken device without having required spare parts, raw materials, or repair kits (the initial check does not suffer penalties for lacking repair kits, either). This only works, however, if the functioning device is at least the same size and technological level as the device being repaired (it is impossible to repair a starship with a blaster pistol, or a lightsaber with parts from a water wheel).";
    }
}

public class ResearcherTalent : BaseEotETalent
{
    public ResearcherTalent()
    {
        TalentName = "Researcher";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.SCHOLAR };
        TalentDescription = "The character removes [Setback] per rank of Researcher from all Knowledge checks. Researching takes 50% less time (this does not increase with multiple ranks of Researcher).";
    }
    public ResearcherTalent(bool root, int xpCost)
    {
        TalentName = "Researcher";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.SCHOLAR };
        IsRoot = root;
        TalentXPCost = xpCost;
        TalentDescription = "The character removes [Setback] per rank of Researcher from all Knowledge checks. Researching takes 50% less time (this does not increase with multiple ranks of Researcher).";
    }
    public ResearcherTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Researcher";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.SCHOLAR };
        ParentTalents = parents;
        TalentXPCost = xpCost;
        TalentDescription = "The character removes [Setback] per rank of Researcher from all Knowledge checks. Researching takes 50% less time (this does not increase with multiple ranks of Researcher).";
    }
}

public class ResolveTalent : BaseEotETalent
{
    public ResolveTalent()
    {
        TalentName = "Resolve";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.DOCTOR, Trees.SCHOLAR, Trees.SLICER };
        TalentDescription = "When the character suffers strain, he suffers one less strain per rank of Resolve, to a minimum of one. This does not apply to voluntary strain loss.";
    }
    public ResolveTalent(bool root, int xpCost)
    {
        TalentName = "Resolve";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.DOCTOR, Trees.SCHOLAR, Trees.SLICER };
        IsRoot = root;
        TalentXPCost = xpCost;
        TalentDescription = "When the character suffers strain, he suffers one less strain per rank of Resolve, to a minimum of one. This does not apply to voluntary strain loss.";
    }
    public ResolveTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Resolve";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.DOCTOR, Trees.SCHOLAR, Trees.SLICER };
        ParentTalents = parents;
        TalentXPCost = xpCost;
        TalentDescription = "When the character suffers strain, he suffers one less strain per rank of Resolve, to a minimum of one. This does not apply to voluntary strain loss.";
    }
}

public class RespectedScholarTalent : BaseEotETalent
{
    public RespectedScholarTalent()
    {
        TalentName = "Respected Scholar";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.SCHOLAR };
        TalentDescription = "The character downgrades the difficulty of checks to interact with institutions of learning equal to his ranks in Respected Scholar.";
    }
    public RespectedScholarTalent(bool root, int xpCost)
    {
        TalentName = "Respected Scholar";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.SCHOLAR };
        IsRoot = root;
        TalentXPCost = xpCost;
        TalentDescription = "The character downgrades the difficulty of checks to interact with institutions of learning equal to his ranks in Respected Scholar.";
    }
    public RespectedScholarTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Respected Scholar";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.SCHOLAR };
        ParentTalents = parents;
        TalentXPCost = xpCost;
        TalentDescription = "The character downgrades the difficulty of checks to interact with institutions of learning equal to his ranks in Respected Scholar.";
    }
}

public class ScathingTiradeTalent : BaseEotETalent
{
    public ScathingTiradeTalent()
    {
        TalentName = "Scathing Tirade";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.ACTION };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.POLITICO };
        TalentDescription = "The character may take the Scathing Tirade action, making an Average [2 Difficulty] Corcion check, For each [Success], one enemy within short range suffers one strain. The character can also spend [Advantage]; for every [Advantage] spent, one target already affected suffers 1 additional strain.";
    }
    public ScathingTiradeTalent(bool root, int xpCost)
    {
        TalentName = "Scathing Tirade";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.ACTION };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.POLITICO };
        IsRoot = root;
        TalentXPCost = xpCost;
        TalentDescription = "The character may take the Scathing Tirade action, making an Average [2 Difficulty] Corcion check, For each [Success], one enemy within short range suffers one strain. The character can also spend [Advantage]; for every [Advantage] spent, one target already affected suffers 1 additional strain.";
    }
    public ScathingTiradeTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Scathing Tirade";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.ACTION };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.POLITICO };
        ParentTalents = parents;
        TalentXPCost = xpCost;
        TalentDescription = "The character may take the Scathing Tirade action, making an Average [2 Difficulty] Corcion check, For each [Success], one enemy within short range suffers one strain. The character can also spend [Advantage]; for every [Advantage] spent, one target already affected suffers 1 additional strain.";
    }
}

public class ScathingTiradeImprovedTalent : BaseEotETalent
{
    public ScathingTiradeImprovedTalent()
    {
        TalentName = "Scathing Tirade (Improved)";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.POLITICO };
        TalentDescription = "Each enemy affected by Scathing Tirade suffers [Setback] on all skill checks for a number of rounds equal to the character's ranks in Coercion; this does not stack with itself.";
    }
    public ScathingTiradeImprovedTalent(bool root, int xpCost)
    {
        TalentName = "Scathing Tirade (Improved)";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.POLITICO };
        IsRoot = root;
        TalentXPCost = xpCost;
        TalentDescription = "Each enemy affected by Scathing Tirade suffers [Setback] on all skill checks for a number of rounds equal to the character's ranks in Coercion; this does not stack with itself.";
    }
    public ScathingTiradeImprovedTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Scathing Tirade (Improved)";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.POLITICO };
        ParentTalents = parents;
        TalentXPCost = xpCost;
        TalentDescription = "Each enemy affected by Scathing Tirade suffers [Setback] on all skill checks for a number of rounds equal to the character's ranks in Coercion; this does not stack with itself.";
    }
}

public class ScathingTiradeSupremeTalent : BaseEotETalent
{
    public ScathingTiradeSupremeTalent()
    {
        TalentName = "Scathing Tirade (Supreme)";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.POLITICO };
        TalentDescription = "The character may voluntarily suffer one strain to perform Scathing Tirade as a maneuver instead of an action.";
    }
    public ScathingTiradeSupremeTalent(bool root, int xpCost)
    {
        TalentName = "Scathing Tirade (Supreme)";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.POLITICO };
        IsRoot = root;
        TalentXPCost = xpCost;
        TalentDescription = "The character may voluntarily suffer one strain to perform Scathing Tirade as a maneuver instead of an action.";
    }
    public ScathingTiradeSupremeTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Scathing Tirade (Supreme)";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.POLITICO };
        ParentTalents = parents;
        TalentXPCost = xpCost;
        TalentDescription = "The character may voluntarily suffer one strain to perform Scathing Tirade as a maneuver instead of an action.";
    }
}

public class SecondWindTalent : BaseEotETalent
{
    public SecondWindTalent()
    {
        TalentName = "Second Wind";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.MERCENARYSOLDIER };
        TalentDescription = "Once per encounter, the character may use a Second Wind incidental to recover an amount of strain equal to his ranks in Second Wind.";
    }
    public SecondWindTalent(bool root, int xpCost)
    {
        TalentName = "Second Wind";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.MERCENARYSOLDIER };
        IsRoot = root;
        TalentXPCost = xpCost;
        TalentDescription = "Once per encounter, the character may use a Second Wind incidental to recover an amount of strain equal to his ranks in Second Wind.";
    }
    public SecondWindTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Second Wind";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.MERCENARYSOLDIER };
        ParentTalents = parents;
        TalentXPCost = xpCost;
        TalentDescription = "Once per encounter, the character may use a Second Wind incidental to recover an amount of strain equal to his ranks in Second Wind.";
    }
}

public class SenseDangerTalent : BaseEotETalent
{
    public SenseDangerTalent()
    {
        TalentName = "Sense Danger";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.FORCESENSITIVEEXILE };
        TalentDescription = "Once per game session, the character may remove [Setback] from any one skill check.";
    }
    public SenseDangerTalent(bool root, int xpCost)
    {
        TalentName = "Sense Danger";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.FORCESENSITIVEEXILE };
        IsRoot = root;
        TalentXPCost = xpCost;
        TalentDescription = "Once per game session, the character may remove [Setback] from any one skill check.";
    }
    public SenseDangerTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Sense Danger";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.FORCESENSITIVEEXILE };
        ParentTalents = parents;
        TalentXPCost = xpCost;
        TalentDescription = "Once per game session, the character may remove [Setback] from any one skill check.";
    }
}

public class SenseEmotionsTalent : BaseEotETalent
{
    public SenseEmotionsTalent()
    {
        TalentName = "Sense Emotions";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.FORCESENSITIVEEXILE };
        TalentDescription = "The character adds [Boost] to all Charm, Coercion, and Deception checks unless the target is immune to Force Powers.";
    }
    public SenseEmotionsTalent(bool root, int xpCost)
    {
        TalentName = "Sense Emotions";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.FORCESENSITIVEEXILE };
        IsRoot = root;
        TalentXPCost = xpCost;
        TalentDescription = "The character adds [Boost] to all Charm, Coercion, and Deception checks unless the target is immune to Force Powers.";
    }
    public SenseEmotionsTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Sense Emotions";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.FORCESENSITIVEEXILE };
        ParentTalents = parents;
        TalentXPCost = xpCost;
        TalentDescription = "The character adds [Boost] to all Charm, Coercion, and Deception checks unless the target is immune to Force Powers.";
    }
}

public class ShortcutTalent : BaseEotETalent
{
    public ShortcutTalent()
    {
        TalentName = "Shortcut";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.SCOUT, Trees.THIEF };
        TalentDescription = "During a chase, the character adds [Boost] equal to his ranks in Shortcut to any checks made to catch or escape an opponent.";
    }
    public ShortcutTalent(bool root, int xpCost)
    {
        TalentName = "Shortcut";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.SCOUT, Trees.THIEF };
        IsRoot = root;
        TalentXPCost = xpCost;
        TalentDescription = "During a chase, the character adds [Boost] equal to his ranks in Shortcut to any checks made to catch or escape an opponent.";
    }
    public ShortcutTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Shortcut";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.SCOUT, Trees.THIEF };
        ParentTalents = parents;
        TalentXPCost = xpCost;
        TalentDescription = "During a chase, the character adds [Boost] equal to his ranks in Shortcut to any checks made to catch or escape an opponent.";
    }
}

public class SideStepTalent : BaseEotETalent
{
    public SideStepTalent()
    {
        TalentName = "Side Step";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.MANEUVER };
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.BODYGUARD, Trees.MERCENARYSOLDIER, Trees.SCOUNDREL, Trees.OUTLAWTECH };
        TalentDescription = "Once per round on the character's turn, the character may perform a Side Step maneuver to side step and try to avoid incoming ranged attacks. He then suffers a number of strain no greater than his ranks in Side Step. Until the start of the character's next turn, upgrade the difficulty of all ranged combat checks targeting the character a number of times equal to the strain suffered by the character.";
    }
    public SideStepTalent(bool root, int xpCost)
    {
        TalentName = "Side Step";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.MANEUVER };
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.BODYGUARD, Trees.MERCENARYSOLDIER, Trees.SCOUNDREL, Trees.OUTLAWTECH };
        IsRoot = root;
        TalentXPCost = xpCost;
        TalentDescription = "Once per round on the character's turn, the character may perform a Side Step maneuver to side step and try to avoid incoming ranged attacks. He then suffers a number of strain no greater than his ranks in Side Step. Until the start of the character's next turn, upgrade the difficulty of all ranged combat checks targeting the character a number of times equal to the strain suffered by the character.";
    }
    public SideStepTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Side Step";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.MANEUVER };
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.BODYGUARD, Trees.MERCENARYSOLDIER, Trees.SCOUNDREL, Trees.OUTLAWTECH };
        ParentTalents = parents;
        TalentXPCost = xpCost;
        TalentDescription = "Once per round on the character's turn, the character may perform a Side Step maneuver to side step and try to avoid incoming ranged attacks. He then suffers a number of strain no greater than his ranks in Side Step. Until the start of the character's next turn, upgrade the difficulty of all ranged combat checks targeting the character a number of times equal to the strain suffered by the character.";
    }
}

public class SixthSenseTalent : BaseEotETalent
{
    public SixthSenseTalent()
    {
        TalentName = "Sixth Sense";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.FORCESENSITIVEEXILE };
        TalentDescription = "The character gains +1 ranged defense.";
    }
    public SixthSenseTalent(bool root, int xpCost)
    {
        TalentName = "Sixth Sense";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.FORCESENSITIVEEXILE };
        IsRoot = root;
        TalentXPCost = xpCost;
        TalentDescription = "The character gains +1 ranged defense.";
    }
    public SixthSenseTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Sixth Sense";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.FORCESENSITIVEEXILE };
        ParentTalents = parents;
        TalentXPCost = xpCost;
        TalentDescription = "The character gains +1 ranged defense.";
    }
}

public class SkilledJockeyTalent : BaseEotETalent
{
    public SkilledJockeyTalent()
    {
        TalentName = "Skilled Jockey";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.FRINGER, Trees.PILOT };
        TalentDescription = "The character removes [Setback] per rank of Skilled Jockey from Piloting (Planetary) and Piloting (Space) checks the character attempts.";
    }
    public SkilledJockeyTalent(bool root, int xpCost)
    {
        TalentName = "Skilled Jockey";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.FRINGER, Trees.PILOT };
        IsRoot = root;
        TalentXPCost = xpCost;
        TalentDescription = "The character removes [Setback] per rank of Skilled Jockey from Piloting (Planetary) and Piloting (Space) checks the character attempts.";
    }
    public SkilledJockeyTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Skilled Jockey";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.FRINGER, Trees.PILOT };
        ParentTalents = parents;
        TalentXPCost = xpCost;
        TalentDescription = "The character removes [Setback] per rank of Skilled Jockey from Piloting (Planetary) and Piloting (Space) checks the character attempts.";
    }
}

public class SkilledSlicerTalent : BaseEotETalent
{
    public SkilledSlicerTalent()
    {
        TalentName = "Skilled Slicer";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.SLICER };
        TalentDescription = "When making a Computers check, the character may spend [Triumph] to gain some measure of control over the target system. Any further Computers checks within this system can be made as maneuvers.";
    }
    public SkilledSlicerTalent(bool root, int xpCost)
    {
        TalentName = "Skilled Slicer";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.SLICER };
        IsRoot = root;
        TalentXPCost = xpCost;
        TalentDescription = "When making a Computers check, the character may spend [Triumph] to gain some measure of control over the target system. Any further Computers checks within this system can be made as maneuvers.";
    }
    public SkilledSlicerTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Skilled Slicer";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.SLICER };
        ParentTalents = parents;
        TalentXPCost = xpCost;
        TalentDescription = "When making a Computers check, the character may spend [Triumph] to gain some measure of control over the target system. Any further Computers checks within this system can be made as maneuvers.";
    }
}

public class SmoothTalkerTalent : BaseEotETalent
{
    public SmoothTalkerTalent()
    {
        TalentName = "Smooth Talker";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.TRADER };
        TalentDescription = "When a character acquires this talent, he chooses one skill: Charm, Coercion, Negotiation, or Deception. When making checks with that skill, he may spend [Triumph] to gain additional [Success] equal to his ranks in Smooth Talker.";
    }
    public SmoothTalkerTalent(bool root, int xpCost)
    {
        TalentName = "Smooth Talker";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.TRADER };
        IsRoot = root;
        TalentXPCost = xpCost;
        TalentDescription = "When a character acquires this talent, he chooses one skill: Charm, Coercion, Negotiation, or Deception. When making checks with that skill, he may spend [Triumph] to gain additional [Success] equal to his ranks in Smooth Talker.";
    }
    public SmoothTalkerTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Smooth Talker";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.TRADER };
        ParentTalents = parents;
        TalentXPCost = xpCost;
        TalentDescription = "When a character acquires this talent, he chooses one skill: Charm, Coercion, Negotiation, or Deception. When making checks with that skill, he may spend [Triumph] to gain additional [Success] equal to his ranks in Smooth Talker.";
    }
}

public class SniperShotTalent : BaseEotETalent
{
    public SniperShotTalent()
    {
        TalentName = "Sniper Shot";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.MANEUVER };
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.ASSASSIN, Trees.MERCENARYSOLDIER };
        TalentDescription = "Once per round before making a non-thrown ranged attack, the character may perform a maneuver to attempt a Sniper Shot. Sniper Shot increases the maximum range of his ranged weapon up to one range band per rank. For each rank beyond the normal maximum of the weapon, upgrade the difficulty of the check by one (this is in addition to the increased difficulty of the shot due to longer range).";
    }
    public SniperShotTalent(bool root, int xpCost)
    {
        TalentName = "Sniper Shot";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.MANEUVER };
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.ASSASSIN, Trees.MERCENARYSOLDIER };
        IsRoot = root;
        TalentXPCost = xpCost;
        TalentDescription = "Once per round before making a non-thrown ranged attack, the character may perform a maneuver to attempt a Sniper Shot. Sniper Shot increases the maximum range of his ranged weapon up to one range band per rank. For each rank beyond the normal maximum of the weapon, upgrade the difficulty of the check by one (this is in addition to the increased difficulty of the shot due to longer range).";
    }
    public SniperShotTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Sniper Shot";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.MANEUVER };
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.ASSASSIN, Trees.MERCENARYSOLDIER };
        ParentTalents = parents;
        TalentXPCost = xpCost;
        TalentDescription = "Once per round before making a non-thrown ranged attack, the character may perform a maneuver to attempt a Sniper Shot. Sniper Shot increases the maximum range of his ranged weapon up to one range band per rank. For each rank beyond the normal maximum of the weapon, upgrade the difficulty of the check by one (this is in addition to the increased difficulty of the shot due to longer range).";
    }
}

public class SoftSpotTalent : BaseEotETalent
{
    public SoftSpotTalent()
    {
        TalentName = "Soft Spot";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.SCOUNDREL, Trees.SURVIVALIST };
        TalentDescription = "After making a successful attack with a non-starship/vehicle weapon, the character may spend one Destiny Point to add damage equal to his Cunning to one hit of the successful attack.";
    }
    public SoftSpotTalent(bool root, int xpCost)
    {
        TalentName = "Soft Spot";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.SCOUNDREL, Trees.SURVIVALIST };
        IsRoot = root;
        TalentXPCost = xpCost;
        TalentDescription = "After making a successful attack with a non-starship/vehicle weapon, the character may spend one Destiny Point to add damage equal to his Cunning to one hit of the successful attack.";
    }
    public SoftSpotTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Soft Spot";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.SCOUNDREL, Trees.SURVIVALIST };
        ParentTalents = parents;
        TalentXPCost = xpCost;
        TalentDescription = "After making a successful attack with a non-starship/vehicle weapon, the character may spend one Destiny Point to add damage equal to his Cunning to one hit of the successful attack.";
    }
}

public class SolidRepairsTalent : BaseEotETalent
{
    public SolidRepairsTalent()
    {
        TalentName = "Solid Repairs";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.MECHANIC, Trees.OUTLAWTECH };
        TalentDescription = "The character repairs +1 hull trauma per rank of Solid Repairs whenever he repairs a vehicle or starship.";
    }
    public SolidRepairsTalent(bool root, int xpCost)
    {
        TalentName = "Solid Repairs";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.MECHANIC, Trees.OUTLAWTECH };
        IsRoot = root;
        TalentXPCost = xpCost;
        TalentDescription = "The character repairs +1 hull trauma per rank of Solid Repairs whenever he repairs a vehicle or starship.";
    }
    public SolidRepairsTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Solid Repairs";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.MECHANIC, Trees.OUTLAWTECH };
        ParentTalents = parents;
        TalentXPCost = xpCost;
        TalentDescription = "The character repairs +1 hull trauma per rank of Solid Repairs whenever he repairs a vehicle or starship.";
    }
}

public class SpareClipTalent : BaseEotETalent
{
    public SpareClipTalent()
    {
        TalentName = "Spare Clip";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.GADGETEER, Trees.TRADER };
        TalentDescription = "The character does not run out of ammo on a [Dispair]. Items with Limited Ammo quality run out of ammo as normal.";
    }
    public SpareClipTalent(bool root, int xpCost)
    {
        TalentName = "Spare Clip";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.GADGETEER, Trees.TRADER };
        IsRoot = root;
        TalentXPCost = xpCost;
        TalentDescription = "The character does not run out of ammo on a [Dispair]. Items with Limited Ammo quality run out of ammo as normal.";
    }
    public SpareClipTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Spare Clip";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.GADGETEER, Trees.TRADER };
        ParentTalents = parents;
        TalentXPCost = xpCost;
        TalentDescription = "The character does not run out of ammo on a [Dispair]. Items with Limited Ammo quality run out of ammo as normal.";
    }
}

public class SpeaksBinaryTalent : BaseEotETalent
{
    public SpeaksBinaryTalent()
    {
        TalentName = "Speaks Binary";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.OUTLAWTECH, Trees.SCHOLAR };
        TalentDescription = "The character grants [Boost] per rank of Speaks Binary to any tasks he directs a non-player droid to perform.";
    }
    public SpeaksBinaryTalent(bool root, int xpCost)
    {
        TalentName = "Speaks Binary";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.OUTLAWTECH, Trees.SCHOLAR };
        IsRoot = root;
        TalentXPCost = xpCost;
        TalentDescription = "The character grants [Boost] per rank of Speaks Binary to any tasks he directs a non-player droid to perform.";
    }
    public SpeaksBinaryTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Speaks Binary";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.OUTLAWTECH, Trees.SCHOLAR };
        ParentTalents = parents;
        TalentXPCost = xpCost;
        TalentDescription = "The character grants [Boost] per rank of Speaks Binary to any tasks he directs a non-player droid to perform.";
    }
}

public class StalkerTalent : BaseEotETalent
{
    public StalkerTalent()
    {
        TalentName = "Stalker";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.ASSASSIN, Trees.SCOUT, Trees.SURVIVALIST, Trees.THIEF };
        TalentDescription = "The character adds [Boost] per rank of Stalker to all Coordination and Stealth checks.";
    }
    public StalkerTalent(bool root, int xpCost)
    {
        TalentName = "Stalker";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.ASSASSIN, Trees.SCOUT, Trees.SURVIVALIST, Trees.THIEF };
        IsRoot = root;
        TalentXPCost = xpCost;
        TalentDescription = "The character adds [Boost] per rank of Stalker to all Coordination and Stealth checks.";
    }
    public StalkerTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Stalker";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.ASSASSIN, Trees.SCOUT, Trees.SURVIVALIST, Trees.THIEF };
        ParentTalents = parents;
        TalentXPCost = xpCost;
        TalentDescription = "The character adds [Boost] per rank of Stalker to all Coordination and Stealth checks.";
    }
}

public class SteelyNervesTalent : BaseEotETalent
{
    public SteelyNervesTalent()
    {
        TalentName = "Steely Nerves";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.POLITICO, Trees.TRADER };
        TalentDescription = "The character may spend one Destiny Point to ignore the effects of ongoing Critical Injuries on any Presence or Willpower related checks until the end of the encounter. He still suffers from the injury itself.";
    }
    public SteelyNervesTalent(bool root, int xpCost)
    {
        TalentName = "Steely Nerves";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.POLITICO, Trees.TRADER };
        IsRoot = root;
        TalentXPCost = xpCost;
        TalentDescription = "The character may spend one Destiny Point to ignore the effects of ongoing Critical Injuries on any Presence or Willpower related checks until the end of the encounter. He still suffers from the injury itself.";
    }
    public SteelyNervesTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Steely Nerves";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.POLITICO, Trees.TRADER };
        ParentTalents = parents;
        TalentXPCost = xpCost;
        TalentDescription = "The character may spend one Destiny Point to ignore the effects of ongoing Critical Injuries on any Presence or Willpower related checks until the end of the encounter. He still suffers from the injury itself.";
    }
}

public class StimApplicationTalent : BaseEotETalent
{
    public StimApplicationTalent()
    {
        TalentName = "Stim Application";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.ACTION };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.DOCTOR };
        TalentDescription = "The character may take the Stim Application action. To perform this action, he must have access to drugs, a medpac, or stimpacks. He makes an Average [2 Difficulty] Medicine check. If successful, one ally he is engaged with (including himself) increases one characteristic of the character's choice by one for the remainder of the encounter and suffers four strain. A single character's individual caracteristics may each only be increased once by Stim Application during an encounter.";
    }
    public StimApplicationTalent(bool root, int xpCost)
    {
        TalentName = "Stim Application";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.ACTION };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.DOCTOR };
        IsRoot = root;
        TalentXPCost = xpCost;
        TalentDescription = "The character may take the Stim Application action. To perform this action, he must have access to drugs, a medpac, or stimpacks. He makes an Average [2 Difficulty] Medicine check. If successful, one ally he is engaged with (including himself) increases one characteristic of the character's choice by one for the remainder of the encounter and suffers four strain. A single character's individual caracteristics may each only be increased once by Stim Application during an encounter.";
    }
    public StimApplicationTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Stim Application";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.ACTION };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.DOCTOR };
        ParentTalents = parents;
        TalentXPCost = xpCost;
        TalentDescription = "The character may take the Stim Application action. To perform this action, he must have access to drugs, a medpac, or stimpacks. He makes an Average [2 Difficulty] Medicine check. If successful, one ally he is engaged with (including himself) increases one characteristic of the character's choice by one for the remainder of the encounter and suffers four strain. A single character's individual caracteristics may each only be increased once by Stim Application during an encounter.";
    }
}

public class StimApplicationImprovedTalent : BaseEotETalent
{
    public StimApplicationImprovedTalent()
    {
        TalentName = "Stim Application (Improved)";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.DOCTOR };
        TalentDescription = "As an incidental, when performing the Stim Application action, the character may increase the difficulty of the Medicine Check to Hard [3 Difficulty]. If he does so, the target of the action suffers one strain instead of four.";
    }
    public StimApplicationImprovedTalent(bool root, int xpCost)
    {
        TalentName = "Stim Application (Improved)";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.DOCTOR };
        IsRoot = root;
        TalentXPCost = xpCost;
        TalentDescription = "As an incidental, when performing the Stim Application action, the character may increase the difficulty of the Medicine Check to Hard [3 Difficulty]. If he does so, the target of the action suffers one strain instead of four.";
    }
    public StimApplicationImprovedTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Stim Application (Improved)";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.DOCTOR };
        ParentTalents = parents;
        TalentXPCost = xpCost;
        TalentDescription = "As an incidental, when performing the Stim Application action, the character may increase the difficulty of the Medicine Check to Hard [3 Difficulty]. If he does so, the target of the action suffers one strain instead of four.";
    }
}

public class StimApplicationSupremeTalent : BaseEotETalent
{
    public StimApplicationSupremeTalent()
    {
        TalentName = "Stim Application (Supreme)";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.DOCTOR };
        TalentDescription = "When performing the Stim Application action, each [Triumph] may be spent to increase an additional characteristic by one.";
    }
    public StimApplicationSupremeTalent(bool root, int xpCost)
    {
        TalentName = "Stim Application (Supreme)";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.DOCTOR };
        IsRoot = root;
        TalentXPCost = xpCost;
        TalentDescription = "When performing the Stim Application action, each [Triumph] may be spent to increase an additional characteristic by one.";
    }
    public StimApplicationSupremeTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Stim Application (Supreme)";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.DOCTOR };
        ParentTalents = parents;
        TalentXPCost = xpCost;
        TalentDescription = "When performing the Stim Application action, each [Triumph] may be spent to increase an additional characteristic by one.";
    }
}

public class StreetSmartsTalent : BaseEotETalent
{
    public StreetSmartsTalent()
    {
        TalentName = "Street Smarts";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.FRINGER, Trees.FORCESENSITIVEEXILE, Trees.THIEF };
        TalentDescription = "Remove [Setback] per rank of Street Smarts from any Streetwise or Knowledge (Underworld) checks the character attempts.";
    }
    public StreetSmartsTalent(bool root, int xpCost)
    {
        TalentName = "Street Smarts";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.FRINGER, Trees.FORCESENSITIVEEXILE, Trees.THIEF };
        IsRoot = root;
        TalentXPCost = xpCost;
        TalentDescription = "Remove [Setback] per rank of Street Smarts from any Streetwise or Knowledge (Underworld) checks the character attempts.";
    }
    public StreetSmartsTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Street Smarts";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.FRINGER, Trees.FORCESENSITIVEEXILE, Trees.THIEF };
        ParentTalents = parents;
        TalentXPCost = xpCost;
        TalentDescription = "Remove [Setback] per rank of Street Smarts from any Streetwise or Knowledge (Underworld) checks the character attempts.";
    }
}

public class StrokeOfGeniusTalent : BaseEotETalent
{
    public StrokeOfGeniusTalent()
    {
        TalentName = "Stroke of Genius";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.SCHOLAR };
        TalentDescription = "Once per game session, the character can choose to make one skill check using Intellect, rather than the characteristic linked to that skill. When he does this, he must explain how, in this particular instance, his intelligence is helping him overcome this challenge.";
    }
    public StrokeOfGeniusTalent(bool root, int xpCost)
    {
        TalentName = "Stroke of Genius";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.SCHOLAR };
        IsRoot = root;
        TalentXPCost = xpCost;
        TalentDescription = "Once per game session, the character can choose to make one skill check using Intellect, rather than the characteristic linked to that skill. When he does this, he must explain how, in this particular instance, his intelligence is helping him overcome this challenge.";
    }
    public StrokeOfGeniusTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Stroke of Genius";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.SCHOLAR };
        ParentTalents = parents;
        TalentXPCost = xpCost;
        TalentDescription = "Once per game session, the character can choose to make one skill check using Intellect, rather than the characteristic linked to that skill. When he does this, he must explain how, in this particular instance, his intelligence is helping him overcome this challenge.";
    }
}

public class StrongArmTalent : BaseEotETalent
{
    public StrongArmTalent()
    {
        TalentName = "Strong Arm";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.MERCENARYSOLDIER };
        TalentDescription = "Characters with the Strong Arm talent treat thrown weapons as if they had one step greater range, to a maximum of medium range.";
    }
    public StrongArmTalent(bool root, int xpCost)
    {
        TalentName = "Strong Arm";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.MERCENARYSOLDIER };
        IsRoot = root;
        TalentXPCost = xpCost;
        TalentDescription = "Characters with the Strong Arm talent treat thrown weapons as if they had one step greater range, to a maximum of medium range.";
    }
    public StrongArmTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Strong Arm";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.MERCENARYSOLDIER };
        ParentTalents = parents;
        TalentXPCost = xpCost;
        TalentDescription = "Characters with the Strong Arm talent treat thrown weapons as if they had one step greater range, to a maximum of medium range.";
    }
}

public class StunningBlowTalent : BaseEotETalent
{
    public StunningBlowTalent()
    {
        TalentName = "Stunning Blow";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.GADGETEER };
        TalentDescription = "When making Melee checks, the character may choose to deal damage as strain instead of wounds. This does not ignore soak.";
    }
    public StunningBlowTalent(bool root, int xpCost)
    {
        TalentName = "Stunning Blow";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.GADGETEER };
        IsRoot = root;
        TalentXPCost = xpCost;
        TalentDescription = "When making Melee checks, the character may choose to deal damage as strain instead of wounds. This does not ignore soak.";
    }
    public StunningBlowTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Stunning Blow";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.GADGETEER };
        ParentTalents = parents;
        TalentXPCost = xpCost;
        TalentDescription = "When making Melee checks, the character may choose to deal damage as strain instead of wounds. This does not ignore soak.";
    }
}

public class StunningBlowImprovedTalent : BaseEotETalent
{
    public StunningBlowImprovedTalent()
    {
        TalentName = "Stunning Blow (Improved)";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.GADGETEER };
        TalentDescription = "When dealing strain damage with Melee or Brawl checks, the character may spend a [Triumph] result to stagger his target for one round per [Triumph] spent.";
    }
    public StunningBlowImprovedTalent(bool root, int xpCost)
    {
        TalentName = "Stunning Blow (Improved)";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.GADGETEER };
        IsRoot = root;
        TalentXPCost = xpCost;
        TalentDescription = "When dealing strain damage with Melee or Brawl checks, the character may spend a [Triumph] result to stagger his target for one round per [Triumph] spent.";
    }
    public StunningBlowImprovedTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Stunning Blow (Improved)";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.GADGETEER };
        ParentTalents = parents;
        TalentXPCost = xpCost;
        TalentDescription = "When dealing strain damage with Melee or Brawl checks, the character may spend a [Triumph] result to stagger his target for one round per [Triumph] spent.";
    }
}

public class SuperiorReflexesTalent : BaseEotETalent
{
    public SuperiorReflexesTalent()
    {
        TalentName = "Superior Reflexes";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.FORCESENSITIVEEXILE };
        TalentDescription = "The character gains +1 melee defense.";
    }
    public SuperiorReflexesTalent(bool root, int xpCost)
    {
        TalentName = "Superior Reflexes";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.FORCESENSITIVEEXILE };
        IsRoot = root;
        TalentXPCost = xpCost;
        TalentDescription = "The character gains +1 melee defense.";
    }
    public SuperiorReflexesTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Superior Reflexes";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.FORCESENSITIVEEXILE };
        ParentTalents = parents;
        TalentXPCost = xpCost;
        TalentDescription = "The character gains +1 melee defense.";
    }
}

public class SurgeonTalent : BaseEotETalent
{
    public SurgeonTalent()
    {
        TalentName = "Surgeon";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.DOCTOR };
        TalentDescription = "When this character makes a Medicine check to help a character heal wounds, the target heals one additional wound per rank of Surgeon.";
    }
    public SurgeonTalent(bool root, int xpCost)
    {
        TalentName = "Surgeon";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.DOCTOR };
        IsRoot = root;
        TalentXPCost = xpCost;
        TalentDescription = "When this character makes a Medicine check to help a character heal wounds, the target heals one additional wound per rank of Surgeon.";
    }
    public SurgeonTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Surgeon";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.DOCTOR };
        ParentTalents = parents;
        TalentXPCost = xpCost;
        TalentDescription = "When this character makes a Medicine check to help a character heal wounds, the target heals one additional wound per rank of Surgeon.";
    }
}

public class SwiftTalent : BaseEotETalent
{
    public SwiftTalent()
    {
        TalentName = "Swift";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.SURVIVALIST };
        TalentDescription = "The character does not suffer the penalties for moving through difficult terrain (he moves through it at normal speed, without spending additional maneuvers).";
    }
    public SwiftTalent(bool root, int xpCost)
    {
        TalentName = "Swift";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.SURVIVALIST };
        IsRoot = root;
        TalentXPCost = xpCost;
        TalentDescription = "The character does not suffer the penalties for moving through difficult terrain (he moves through it at normal speed, without spending additional maneuvers).";
    }
    public SwiftTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Swift";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.SURVIVALIST };
        ParentTalents = parents;
        TalentXPCost = xpCost;
        TalentDescription = "The character does not suffer the penalties for moving through difficult terrain (he moves through it at normal speed, without spending additional maneuvers).";
    }
}

public class TargetedBlowTalent : BaseEotETalent
{
    public TargetedBlowTalent()
    {
        TalentName = "Targeted Blow";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.ASSASSIN };
        TalentDescription = "On a successful attack during combat with a non-starship/vehicle weapon, the character may spend one Destiny Point to add damage equal to his Agility to one hit of the successful attack.";
    }
    public TargetedBlowTalent(bool root, int xpCost)
    {
        TalentName = "Targeted Blow";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.ASSASSIN };
        IsRoot = root;
        TalentXPCost = xpCost;
        TalentDescription = "On a successful attack during combat with a non-starship/vehicle weapon, the character may spend one Destiny Point to add damage equal to his Agility to one hit of the successful attack.";
    }
    public TargetedBlowTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Targeted Blow";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.ASSASSIN };
        ParentTalents = parents;
        TalentXPCost = xpCost;
        TalentDescription = "On a successful attack during combat with a non-starship/vehicle weapon, the character may spend one Destiny Point to add damage equal to his Agility to one hit of the successful attack.";
    }
}

public class TechnicalAptitudeTalent : BaseEotETalent
{
    public TechnicalAptitudeTalent()
    {
        TalentName = "Technical Aptitude";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.SLICER };
        TalentDescription = "For each rank, the character reduces the amount of time needed to complete Computer related tasks by 25%";
    }
    public TechnicalAptitudeTalent(bool root, int xpCost)
    {
        TalentName = "Technical Aptitude";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.SLICER };
        IsRoot = root;
        TalentXPCost = xpCost;
        TalentDescription = "For each rank, the character reduces the amount of time needed to complete Computer related tasks by 25%";
    }
    public TechnicalAptitudeTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Technical Aptitude";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.SLICER };
        ParentTalents = parents;
        TalentXPCost = xpCost;
        TalentDescription = "For each rank, the character reduces the amount of time needed to complete Computer related tasks by 25%";
    }
}

public class TinkererTalent : BaseEotETalent
{
    public TinkererTalent()
    {
        TalentName = "Tinkerer";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.GADGETEER, Trees.OUTLAWTECH };
        TalentDescription = "The character makes one piece of equipment more modifiable. He chooses one piece of equipment and increases its number of hard points by one. He can only do this once per piece of equipment, but can modify a number of pieces of equipment equal to his ranks in Tinkerer. If he loses a modified piece of equipment, he may apply Tinkerer to a new one.";
    }
    public TinkererTalent(bool root, int xpCost)
    {
        TalentName = "Tinkerer";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.GADGETEER, Trees.OUTLAWTECH };
        IsRoot = root;
        TalentXPCost = xpCost;
        TalentDescription = "The character makes one piece of equipment more modifiable. He chooses one piece of equipment and increases its number of hard points by one. He can only do this once per piece of equipment, but can modify a number of pieces of equipment equal to his ranks in Tinkerer. If he loses a modified piece of equipment, he may apply Tinkerer to a new one.";
    }
    public TinkererTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Tinkerer";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.GADGETEER, Trees.OUTLAWTECH };
        ParentTalents = parents;
        TalentXPCost = xpCost;
        TalentDescription = "The character makes one piece of equipment more modifiable. He chooses one piece of equipment and increases its number of hard points by one. He can only do this once per piece of equipment, but can modify a number of pieces of equipment equal to his ranks in Tinkerer. If he loses a modified piece of equipment, he may apply Tinkerer to a new one.";
    }
}

public class TouchOfFateTalent : BaseEotETalent
{
    public TouchOfFateTalent()
    {
        TalentName = "Touch of Fate";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.FORCESENSITIVEEXILE };
        TalentDescription = "Once per game session, the character may add [2 Boost] to any one skill check.";
    }
    public TouchOfFateTalent(bool root, int xpCost)
    {
        TalentName = "Touch of Fate";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.FORCESENSITIVEEXILE };
        IsRoot = root;
        TalentXPCost = xpCost;
        TalentDescription = "Once per game session, the character may add [2 Boost] to any one skill check.";
    }
    public TouchOfFateTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Touch of Fate";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.FORCESENSITIVEEXILE };
        ParentTalents = parents;
        TalentXPCost = xpCost;
        TalentDescription = "Once per game session, the character may add [2 Boost] to any one skill check.";
    }
}

public class ToughenedTalent : BaseEotETalent
{
    public ToughenedTalent()
    {
        TalentName = "Toughened";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.BODYGUARD, Trees.FRINGER, Trees.GADGETEER, Trees.MARAUDER, Trees.MECHANIC, Trees.MERCENARYSOLDIER, Trees.OUTLAWTECH, Trees.PILOT, Trees.POLITICO, Trees.SCHOLAR, Trees.SCOUNDREL, Trees.SCOUT, Trees.SURVIVALIST, Trees.TRADER };
        TalentDescription = "The character increases his wound threshold by two per rank of Toughened.";
    }
    public ToughenedTalent(bool root, int xpCost)
    {
        TalentName = "Toughened";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.BODYGUARD, Trees.FRINGER, Trees.GADGETEER, Trees.MARAUDER, Trees.MECHANIC, Trees.MERCENARYSOLDIER, Trees.OUTLAWTECH, Trees.PILOT, Trees.POLITICO, Trees.SCHOLAR, Trees.SCOUNDREL, Trees.SCOUT, Trees.SURVIVALIST, Trees.TRADER };
        IsRoot = root;
        TalentXPCost = xpCost;
        TalentDescription = "The character increases his wound threshold by two per rank of Toughened.";
    }
    public ToughenedTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Toughened";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.BODYGUARD, Trees.FRINGER, Trees.GADGETEER, Trees.MARAUDER, Trees.MECHANIC, Trees.MERCENARYSOLDIER, Trees.OUTLAWTECH, Trees.PILOT, Trees.POLITICO, Trees.SCHOLAR, Trees.SCOUNDREL, Trees.SCOUT, Trees.SURVIVALIST, Trees.TRADER };
        ParentTalents = parents;
        TalentXPCost = xpCost;
        TalentDescription = "The character increases his wound threshold by two per rank of Toughened.";
    }
}

public class TrickyTargetTalent : BaseEotETalent
{
    public TrickyTargetTalent()
    {
        TalentName = "Tricky Target";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.PILOT };
        TalentDescription = "Any vehicle the character pilots counts as having a silhouette one lower than normal when being attacked, to a minimum of 0.";
    }
    public TrickyTargetTalent(bool root, int xpCost)
    {
        TalentName = "Tricky Target";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.PILOT };
        IsRoot = root;
        TalentXPCost = xpCost;
        TalentDescription = "Any vehicle the character pilots counts as having a silhouette one lower than normal when being attacked, to a minimum of 0.";
    }
    public TrickyTargetTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Tricky Target";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.PILOT };
        ParentTalents = parents;
        TalentXPCost = xpCost;
        TalentDescription = "Any vehicle the character pilots counts as having a silhouette one lower than normal when being attacked, to a minimum of 0.";
    }
}

public class TrueAimTalent : BaseEotETalent
{
    public TrueAimTalent()
    {
        TalentName = "True Aim";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.MANEUVER };
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.MERCENARYSOLDIER };
        TalentDescription = "Once per round, before the character makes a ranged attack, he may perform a True Aim maneuver. By performing this maneuver, the character gains all the benefits for aiming and also upgrades his attack roll once per rank of True Aim.";
    }
    public TrueAimTalent(bool root, int xpCost)
    {
        TalentName = "True Aim";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.MANEUVER };
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.MERCENARYSOLDIER };
        IsRoot = root;
        TalentXPCost = xpCost;
        TalentDescription = "Once per round, before the character makes a ranged attack, he may perform a True Aim maneuver. By performing this maneuver, the character gains all the benefits for aiming and also upgrades his attack roll once per rank of True Aim.";
    }
    public TrueAimTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "True Aim";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.MANEUVER };
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.MERCENARYSOLDIER };
        ParentTalents = parents;
        TalentXPCost = xpCost;
        TalentDescription = "Once per round, before the character makes a ranged attack, he may perform a True Aim maneuver. By performing this maneuver, the character gains all the benefits for aiming and also upgrades his attack roll once per rank of True Aim.";
    }
}

public class UncannyReactionsTalent : BaseEotETalent
{
    public UncannyReactionsTalent()
    {
        TalentName = "Uncanny Reactions";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.FORCESENSITIVEEXILE };
        TalentDescription = "The character adds [Boost] per rank of Uncanny Reactions to all Vigilance checks.";
    }
    public UncannyReactionsTalent(bool root, int xpCost)
    {
        TalentName = "Uncanny Reactions";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.FORCESENSITIVEEXILE };
        IsRoot = root;
        TalentXPCost = xpCost;
        TalentDescription = "The character adds [Boost] per rank of Uncanny Reactions to all Vigilance checks.";
    }
    public UncannyReactionsTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Uncanny Reactions";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.FORCESENSITIVEEXILE };
        ParentTalents = parents;
        TalentXPCost = xpCost;
        TalentDescription = "The character adds [Boost] per rank of Uncanny Reactions to all Vigilance checks.";
    }
}

public class UncannySensesTalent : BaseEotETalent
{
    public UncannySensesTalent()
    {
        TalentName = "Uncanny Senses";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.FORCESENSITIVEEXILE };
        TalentDescription = "The character adds [Boost] per rank of Uncanny Senses to all Perception checks.";
    }
    public UncannySensesTalent(bool root, int xpCost)
    {
        TalentName = "Uncanny Senses";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.FORCESENSITIVEEXILE };
        IsRoot = root;
        TalentXPCost = xpCost;
        TalentDescription = "The character adds [Boost] per rank of Uncanny Senses to all Perception checks.";
    }
    public UncannySensesTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Uncanny Senses";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.FORCESENSITIVEEXILE };
        ParentTalents = parents;
        TalentXPCost = xpCost;
        TalentDescription = "The character adds [Boost] per rank of Uncanny Senses to all Perception checks.";
    }
}

public class UtilityBeltTalent : BaseEotETalent
{
    public UtilityBeltTalent()
    {
        TalentName = "Utility Belt";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.OUTLAWTECH, Trees.SCOUT };
        TalentDescription = "The character may spend one Destiny Point to perform a Utility Belt incidental to produce a previously undocumented--but essential--small tool from his utility belt, satchel, or pockets, with a rarity no greater than (4). This cannot be a weapon unless the weapon has the Limited Ammo 1 quality.";
    }
    public UtilityBeltTalent(bool root, int xpCost)
    {
        TalentName = "Utility Belt";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.OUTLAWTECH, Trees.SCOUT };
        IsRoot = root;
        TalentXPCost = xpCost;
        TalentDescription = "The character may spend one Destiny Point to perform a Utility Belt incidental to produce a previously undocumented--but essential--small tool from his utility belt, satchel, or pockets, with a rarity no greater than (4). This cannot be a weapon unless the weapon has the Limited Ammo 1 quality.";
    }
    public UtilityBeltTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Utility Belt";
        TalentActivation = Activation.ACTIVE;
        TalentActivationSpec = new List<ActivationSpec> { ActivationSpec.INCIDENTAL };
        RankedTalent = false;
        TalentTrees = new List<Trees> { Trees.OUTLAWTECH, Trees.SCOUT };
        ParentTalents = parents;
        TalentXPCost = xpCost;
        TalentDescription = "The character may spend one Destiny Point to perform a Utility Belt incidental to produce a previously undocumented--but essential--small tool from his utility belt, satchel, or pockets, with a rarity no greater than (4). This cannot be a weapon unless the weapon has the Limited Ammo 1 quality.";
    }
}

public class UtinniTalent : BaseEotETalent
{
    public UtinniTalent()
    {
        TalentName = "Utinni!";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.OUTLAWTECH };
        TalentDescription = "The character removes [Setback] equal to the character's ranks in Utinni! from checks made to find or scavenge items or gear. These checks could include Negotiation, Perception, or other checks, depending on the circumstances and the GM's discretion. Suck skill checks take half their normal time (this does not decrease with multiple ranks of Utinni!).";
    }
    public UtinniTalent(bool root, int xpCost)
    {
        TalentName = "Utinni!";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.OUTLAWTECH };
        IsRoot = root;
        TalentXPCost = xpCost;
        TalentDescription = "The character removes [Setback] equal to the character's ranks in Utinni! from checks made to find or scavenge items or gear. These checks could include Negotiation, Perception, or other checks, depending on the circumstances and the GM's discretion. Suck skill checks take half their normal time (this does not decrease with multiple ranks of Utinni!).";
    }
    public UtinniTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Utinni!";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.OUTLAWTECH };
        ParentTalents = parents;
        TalentXPCost = xpCost;
        TalentDescription = "The character removes [Setback] equal to the character's ranks in Utinni! from checks made to find or scavenge items or gear. These checks could include Negotiation, Perception, or other checks, depending on the circumstances and the GM's discretion. Suck skill checks take half their normal time (this does not decrease with multiple ranks of Utinni!).";
    }
}

public class WellRoundedTalent : BaseEotETalent
{
    public WellRoundedTalent()
    {
        TalentName = "Well Rounded";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.POLITICO, Trees.SCHOLAR };
        TalentDescription = "The character chooses two any skills. They permanently become career skills.";
    }
    public WellRoundedTalent(bool root, int xpCost)
    {
        TalentName = "Well Rounded";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.POLITICO, Trees.SCHOLAR };
        IsRoot = root;
        TalentXPCost = xpCost;
        TalentDescription = "The character chooses two any skills. They permanently become career skills.";
    }
    public WellRoundedTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Well Rounded";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.POLITICO, Trees.SCHOLAR };
        ParentTalents = parents;
        TalentXPCost = xpCost;
        TalentDescription = "The character chooses two any skills. They permanently become career skills.";
    }
}

public class WheelAndDealTalent : BaseEotETalent
{
    public WheelAndDealTalent()
    {
        TalentName = "Wheel and Deal";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.TRADER };
        TalentDescription = "When he sells legal goods to a reputable merchant or business, the character gains an additional 10% more credits per rank of Wheel and Deal (based on the original sell price of the good or item).";
    }
    public WheelAndDealTalent(bool root, int xpCost)
    {
        TalentName = "Wheel and Deal";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.TRADER };
        IsRoot = root;
        TalentXPCost = xpCost;
        TalentDescription = "When he sells legal goods to a reputable merchant or business, the character gains an additional 10% more credits per rank of Wheel and Deal (based on the original sell price of the good or item).";
    }
    public WheelAndDealTalent(List<BaseEotETalent> parents, int xpCost)
    {
        TalentName = "Wheel and Deal";
        TalentActivation = Activation.PASSIVE;
        RankedTalent = true;
        TalentTrees = new List<Trees> { Trees.TRADER };
        ParentTalents = parents;
        TalentXPCost = xpCost;
        TalentDescription = "When he sells legal goods to a reputable merchant or business, the character gains an additional 10% more credits per rank of Wheel and Deal (based on the original sell price of the good or item).";
    }
}


/*BEGINNING OF TABLE 4-1: TALENT LIST Page 3*/
