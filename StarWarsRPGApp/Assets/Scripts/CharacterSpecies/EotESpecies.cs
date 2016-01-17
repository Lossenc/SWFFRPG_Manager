using UnityEngine;
using System.Collections;

namespace Species.EotE.Core
{
    public class BothanSpecies : BaseEotESpecies
    {

        public BothanSpecies()
        {
            SpeciesName = "Bothan";
            SpeciesDescription = "Bothans are the galaxy's information brokers. Adept at picking " +
                              "up on secrets or seeing things other species ignore, Bothans " +
                              "can be valuable assets in any endeavor--or untrustworthy partners.";
            MinBrawn = 1;
            MinAgility = 2;
            MinIntellect = 2;
            MinCunning = 3;
            MinWillpower = 2;
            MinPresence = 2;

            WoundThreshold = 10 + MinBrawn;
            StrainThreshold = 11 + MinWillpower;
            StartingExp = 100;
            WoundThresholdText = "10 + Brawn";
            StrainThresholdText = "11 + Willpower";
            StartingExperienceText = "100 XP";
            SpecialAbilities = "Bothans begin the game with one rank in Streetwise. They still may " +
                             "not train Streetwise above rank 2 during character creation. They " +
                             "also start with one rank in the Convincing Demeanor talent.";
            CharacterInformation.streetwise.MinSkillRank = 1;
            CharacterInformation.AddTalent(new ConvincingDemeanorTalent());
        }
    }

    public class DroidSpecies : BaseEotESpecies
    {
        public DroidSpecies()
        {
            SpeciesName = "Droid";
            SpeciesDescription = "A typical fringer may ridicule his droid to no end, yet without it, " +
                              "he is usually lost. Droids serve a variety of roles on the fringe, " +
                              "including security and conflict resolution, surgery and medicine, mechanical " +
                              "repairs, construction, astrogation and piloting, and mechanical labor. " +
                              "While many of these droids have only rudimentary intelligence, some are " +
                              "capable of independant thought.";

            MinBrawn = 1;
            MinAgility = 1;
            MinIntellect = 1;
            MinCunning = 1;
            MinWillpower = 1;
            MinPresence = 1;

            WoundThreshold = 10 + MinBrawn;
            StrainThreshold = 10 + MinWillpower;
            StartingExp = 175;
            WoundThresholdText = "10 + Brawn";
            StrainThresholdText = "10 + Willpower";
            StartingExperienceText = "175 XP";
            SpecialAbilities = "Droids do not need to eat, sleep, or breathe, and are unaffected by toxins or " +
                             "poisons. Droids have a cybernetic implant cap of 6 instead of their Brawn rating. " +
                             "In addition, after selecting their career, a Droid Player Character may train one " +
                             "rank in six of the eight career skills (instead of the usual four). After selecting " +
                             "their first specialization, a Droid Player Character may train one rank of three of " +
                             "the four specialization skills (instead of the usual two)." +
                             "\n\nInorganic\n\nMechanical Being";
            //Look for edge cases for other species' cybernetic implant cap.  Should be equal to brawn for non-droids
            CyberneticImplantCap = 6;
            InitialCareerSkills = 6;
            InitialCareerBonusSkills = 3;
            CharacterInformation.AddTalent(new EnduringTalent());
            CanBeForceSensitive = false;
        }
    }

    public class GandSpecies : BaseEotESpecies
    {

        private bool ammoniaBreather = false;

        public GandSpecies()
        {
            SpeciesName = "Gand";
            SpeciesDescription = "Gands are a mysterious insectoid species whose 'findsmen' treat tracking " +
                              "quarry as a religious duty. They are exeptionally good at divining the location " +
                              "of individuals through ritualistic methods that off-worlders migth consider " +
                              "backward and barbaric.";
            MinBrawn = 2;
            MinAgility = 2;
            MinIntellect = 2;
            MinCunning = 2;
            MinWillpower = 3;
            MinPresence = 1;

            WoundThreshold = 10 + MinBrawn;
            StrainThreshold = 10 + MinWillpower;
            StartingExp = 100;
            WoundThresholdText = "10 + Brawn";
            StrainThresholdText = "10 + Willpower";
            StartingExperienceText = "100 XP";
            SpecialAbilities = "Gands begin the game with one rank in Discipline. THey still may not train Discipline " +
                             "above rank 2 during character creation." +
                             "\n\nAmmonia Breathers:\n\n" +
                             "When playing a Gand, each player chooses wheter he wishes his character to have lungs " +
                             "or not. If he is playing a lungless Gand, his character is immune to suffucation (but " +
                             "not to wounds suffered from being exposed to a vacuum). If playing a Gand with lungs, " +
                             "the character starts the game with an ammonia respirator and treats oxygen as a dangerous " +
                             "atmosphere with Rating 8. However, he gains +10 starting XP.";
            Discipline.MinSkillRank = 1;

            if (ammoniaBreather)
            {
                CharacterInformation.AddItem(new AmmoniaRespirator());
                StartingExp = 110;
            }
        }
    }

    public class HumanSpecies : BaseEotESpecies
    {

        public HumanSpecies()
        {
            SpeciesName = "Human";
            SpeciesDescription = "Humans are the most populous and gregarious of the galaxy's sapient " +
                              "species. They seem to be present on almost every open planet that harbors " +
                              "life while traveling the spacelanes looking for more.";

            MinBrawn = 2;
            MinAgility = 2;
            MinIntellect = 2;
            MinCunning = 2;
            MinWillpower = 2;
            MinPresence = 2;

            WoundThreshold = 10 + MinBrawn;
            StrainThreshold = 10 + MinWillpower;
            StartingExp = 110;
            WoundThresholdText = "10 + Brawn";
            StrainThresholdText = "10 + Willpower";
            StartingExperienceText = "110 XP";
            SpecialAbilities = "Humans start the game with one rank in two different non-career skills of their " +
                             "choice. They still may not train these skills above rank 2 at character creation.";
            InitialNonCareerSkills = 2;
        }
    }

    public class RodianSpecies : BaseEotESpecies
    {

        public RodianSpecies()
        {
            SpeciesName = "Rodian";
            SpeciesDescription = "Rodians are born to hunt, coming from a hostile world that breeds killer " +
                              "instincts. For those with a price on their heads, a glimpse of a tapered " +
                              "green snout or an unmistakably putrid odor means a Rodian bounty hunter is " +
                              "on their tail.";
            MinBrawn = 2;
            MinAgility = 3;
            MinIntellect = 2;
            MinCunning = 2;
            MinWillpower = 1;
            MinPresence = 2;

            WoundThreshold = 10 + MinBrawn;
            StrainThreshold = 10 + MinWillpower;
            StartingExp = 100;
            WoundThresholdText = "10 + Brawn";
            StrainThresholdText = "10 + Willpower";
            StartingExperienceText = "100 XP";
            SpecialAbilities = "Rodians begin the game with one rank in Survival. They still may not train Survival " +
                             "above rank 2 during character creation. Rodians start with one rank in the Expert " +
                             "Tracker talent.";
            CharacterInformation.survival.MinSkillRank = 1;
            CharacterInformation.AddTalent(new ExpertTrackerTalent());
        }
    }

    public class TrandoshanSpecies : BaseEotESpecies
    {

        public TrandoshanSpecies()
        {
            SpeciesName = "Trandoshan";
            SpeciesDescription = "Trandoshans are belligerent, lizard-like humanoids who have an avowed " +
                              "hatred of Wookies. They can be found wherever a strong hand or a big gun " +
                              "is desired.";
            MinBrawn = 3;
            MinAgility = 1;
            MinIntellect = 2;
            MinCunning = 2;
            MinWillpower = 2;
            MinPresence = 2;

            WoundThreshold = 12 + MinBrawn;
            StrainThreshold = 9 + MinWillpower;
            StartingExp = 90;
            WoundThresholdText = "12 + Brawn";
            StrainThresholdText = "19 + Willpower";
            StartingExperienceText = "90 XP";
            SpecialAbilities = "Trandoshans begin the game with one rank in Perception. They still may not train " +
                             "Perception above rank 2 during character creation." +
                             "\n\nRegeneration:\n Recover one additional wound for each wound recovered from natural " +
                             "rest or recuperation in a Bacta Tank. Does not recover additional wounds from " +
                             "receiving first aid, medical treatment from others, or stimpack use.\n\nClaws:\nWhen a " +
                             "Trandoshan makes Brawl checks to deal damage to an opponent, he deals +1 damage and has " +
                             "a Critical Rating of 3.";
            CharacterInformation.perception.MinSkillRank = 1;
        }
    }

    public class TwilekSpecies : BaseEotESpecies
    {
        private bool charmChosen = true;

        public TwilekSpecies()
        {
            SpeciesName = "Twi'lek";
            SpeciesDescription = "The Twi'leks are among the most prominent non-human species in the galaxy. " +
                              "They are expert bargainers, sly at reading other species and using cunning to " +
                              "what they want.";
            MinBrawn = 1;
            MinAgility = 2;
            MinIntellect = 2;
            MinCunning = 2;
            MinWillpower = 2;
            MinPresence = 3;

            WoundThreshold = 10 + MinBrawn;
            StrainThreshold = 11 + MinWillpower;
            StartingExp = 100;
            WoundThresholdText = "10 + Brawn";
            StrainThresholdText = "11 + Willpower";
            StartingExperienceText = "100 XP";
            SpecialAbilities = "Twi'leks begin the game with one rank in either Charm or Deception. They still may " +
                             "not train Charm or Deception above rank 2 during character creation. When making " +
                             "skill checks, Twi'leks may remove [1 Setback] imposed due to arid or hot environmental " +
                             "conditions.";
            if (charmChosen)
            {
                CharacterInformation.charm.MinSkillRank = 1;
            }
            else
            {
                CharacterInformation.deception.MinSkillRank = 1;
            }
        }
    }

    public class WookieeSpecies : BaseEotESpecies
    {

        public WookieeSpecies()
        {
            SpeciesName = "Wookiee";
            SpeciesDescription = "Strong, intelligent, and fierce in battle, Wookiees make the best of " +
                              "friends for those to home they are loyal--and the worst of enemies for " +
                              "anyone to whom they are not. Unfortunately, Wookiees have virtually disappeared " +
                              "from the population at large and are becoming a faded memory of the Old Republic.";
            MinBrawn = 3;
            MinAgility = 2;
            MinIntellect = 2;
            MinCunning = 2;
            MinWillpower = 1;
            MinPresence = 2;

            WoundThreshold = 14 + MinBrawn;
            StrainThreshold = 8 + MinWillpower;
            StartingExp = 90;
            WoundThresholdText = "14 + Brawn";
            StrainThresholdText = "8 + Willpower";
            StartingExperienceText = "90 XP";
            SpecialAbilities = "Wookiees begin the game with one rank in Brawl. They still may not train Brawl above " +
                             "rank 2 during character creation." +
                             "\n\nWookiee Rage:\nWhen a Wookiee has suffered any wounds, he deals +1 damage to Brawl " +
                             "and Melee attacks. When a Wookiee is Critically Injured, he instead deals +2 damage " +
                             "to Brawl and Melee attacks.";
            CharacterInformation.brawl.MinSkillRank = 1;
        }
    }
}
