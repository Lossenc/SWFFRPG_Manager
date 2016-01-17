using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Career.EotE.Core
{
    public class BountyHunterCareer : BaseEotECareer
    {

        public BountyHunterCareer()
        {
            CareerName = "Bounty Hunter";
            CareerDescription = "The name says it all: this is a hunter who seeks to collect bounties " +
                                "for his work. Bounty Hunters tend to be feared, reviled, looked down " +
                                "upon--and in great demand throughout the galaxy. They are expert trackers, " +
                                "brutal combatants, and effective investigators. They tend to prefer " +
                                "skulduggery, stealth, and traps over frontal assaults, but the most " +
                                "respected Bounty Hunters will do whatever it takes to catch their quarries " +
                                "and collect their fees.";

            CareerSkills = new List<EotESkills> { EotESkills.ATHLETICS, EotESkills.BRAWL, EotESkills.PERCEPTION, EotESkills.PILOTINGPLANETARY, EotESkills.PILOTINGSPACE, EotESkills.RANGEDHEAVY, EotESkills.STREETWISE, EotESkills.VIGILANCE };
            CharacterInformation.AddItem(new ImperialPeaceKeepingCertificate());
            //CareerSpecList = new List<BaseSpecialization> { new AssassinSpecialization(), new GadgeteerSpecialization(), new SurvivalistSpecialization() };
        }
    }

    public class ColonistCareer : BaseEotECareer
    {

        public ColonistCareer()
        {
            CareerName = "Colonist";
            CareerDescription = "In a way, Colonists are the most out-of-place people in the Outer Rim. " +
                                "They are most often from the Core Worlds, where they were well educated  " +
                                "and part of the cultural and professional elite. A colonist doesn't tend " +
                                "to have the training to survive in areas of high conflict, and he isn't " +
                                "particularly adept at physical exploits.";

            CareerSkills = new List<EotESkills> { EotESkills.CHARM, EotESkills.DECEPTION, EotESkills.COREWORLDS, EotESkills.EDUCATION, EotESkills.LORE, EotESkills.LEADERSHIP, EotESkills.NEGOTIATION, EotESkills.STREETWISE };
            //CareerSpecList = new List<BaseSpecialization> { new DoctorSpecialization(), new PoliticoSpecialization(), new ScholarSpecialization() };
        }
    }

    public class ExplorerCareer : BaseEotECareer
    {

        public ExplorerCareer()
        {
            CareerName = "Explorer";
            CareerDescription = "The Empire is vast, but it is a mere fraction of the galaxy, and the " +
                                "Explorer seeks to uncover the countless mysteries and oppordunities the " +
                                "universe contains. Explorers are both vitally important and insidiously " +
                                "dangerous to the New Order; on the one hand, they reveal information, " +
                                "trade routes, and resources that are deceptively coveted by the Empire, and " +
                                "on the other hand, they expand the ranges into which rebels, criminals, and " +
                                "iconoclasts can spread out and avoid Imperial might.";

            CareerSkills = new List<EotESkills> { EotESkills.ASTROGATION, EotESkills.COOL, EotESkills.LORE, EotESkills.OUTERRIM, EotESkills.XENOLOGY, EotESkills.PERCEPTION, EotESkills.PILOTINGSPACE, EotESkills.SURVIVAL };
            //CareerSpecList = new List<BaseSpecialization> { new FringerSpecialization(), new ScoutSpecialization(), new TraderSpecialization() };
        }

    }

    public class HiredGunCareer : BaseEotECareer
    {

        public HiredGunCareer()
        {
            CareerName = "Hired Gun";
            CareerDescription = "When it comes to fighting, the Hired Gun is at the forefront. He's less " +
                                "of an independent operator than the Bounty Hunter, preferring to have a " +
                                "defined mission, an objective to achieve, and some credits to spend when " +
                                "the job is done. Hired Guns are muscle and applied force, meant to defend " +
                                "or attack as the situation requires. THey deal damage or protect others " +
                                "for credits and this makes them simple and sometimes refreshingly direct.";

            CareerSkills = new List<EotESkills> { EotESkills.ATHLETICS, EotESkills.BRAWL, EotESkills.DISCIPLINE, EotESkills.MELEE, EotESkills.PILOTINGPLANETARY, EotESkills.RANGEDLIGHT, EotESkills.RESILIENCE, EotESkills.VIGILANCE };
            //CareerSpecList = new List<BaseSpecialization> { new BodyguardSpecialization(), new MarauderSpecialization(), new MercenarySoldierSpecialization() };
        }

    }

    public class SmugglerCareer : BaseEotECareer
    {

        public SmugglerCareer()
        {
            CareerName = "Smuggler";
            CareerDescription = "Though they spend most of their lives struggling to avoid Imperial entanglements, " +
                                "keeping their ships flying, dodging blaster fire, and having enough to eat, " +
                                "Smugglers are often seen as the freest beings in the galaxy. They travel the " +
                                "hyperspace lanes, system to system, planet to planet, bringing what people " +
                                "want and need (and cannot get through legitimate means).";

            CareerSkills = new List<EotESkills> { EotESkills.COORDINATION, EotESkills.DECEPTION, EotESkills.UNDERWORLD, EotESkills.PERCEPTION, EotESkills.PILOTINGSPACE, EotESkills.SKULDUGGERY, EotESkills.STREETWISE, EotESkills.VIGILANCE };
            //CareerSpecList = new List<BaseSpecialization> { new PilotSpecialization(), new ScoundrelSpecialization(), new ThiefSpecialization() };
        }

    }

    public class TechnicianCareer : BaseEotECareer
    {

        public TechnicianCareer()
        {
            CareerName = "Technician";
            CareerDescription = "Pretty much anything to do with technology or mechanical devices lies within " +
                                "the Technician's purview. He knows how to operate, maintain, repair, and upgrade " +
                                "just about anything with power and gears. Most Technicians would rather deal " +
                                "with machines and droids than people; the latter are just too unpredictable.";

            CareerSkills = new List<EotESkills> { EotESkills.ASTROGATION, EotESkills.COMPUTERS, EotESkills.COORDINATION, EotESkills.DISCIPLINE, EotESkills.OUTERRIM, EotESkills.MECHANICS, EotESkills.PERCEPTION, EotESkills.PILOTINGPLANETARY };
            //CareerSpecList = new List<BaseSpecialization> { new MechanicSpecialization(), new OutlawTechSpecialization(), new SlicerSpecialization() };
        }

    }
}