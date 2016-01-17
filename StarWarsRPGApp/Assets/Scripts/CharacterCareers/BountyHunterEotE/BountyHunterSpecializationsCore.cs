using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Specialization.EotE.BountyHunter.Core
{
    public class AssassinSpecialization : BaseSpecialization
    {

        public AssassinSpecialization()
        {
            SpecName = "Assassin";
            SpecCareer = BaseEotECareer.EotECareers.BOUNTYHUNTER;
            SpecSkills = new List<BaseEotECareer.EotESkills> { BaseEotECareer.EotESkills.MELEE, BaseEotECareer.EotESkills.RANGEDHEAVY, BaseEotECareer.EotESkills.SKULDUGGERY, BaseEotECareer.EotESkills.STEALTH };
            SpecDescription = "Instrument of Policy\n\nWheras most Bounty Hunters focus primarily on the capture of quarry, those " +
                              "who specialize as Assassins are generally tasked with the straightforward proposition of terminating " +
                              "their targets. Assassins tend to prefer getting in quietly, taking out targets (either up close or " +
                              "sniping from afar), and leaving just as silently as they entered. Their talents are very appropriate " +
                              "for this kind of work.";

            /* Talent Tree */
            TalentA1 = new GritTalent(true, 5);
            TalentA2 = new LethalBlowsTalent(true, 5);
            TalentA3 = new StalkerTalent(true, 5);
            TalentA4 = new DodgeTalent(true, 5);
            TalentB1 = new PreciseAimTalent(new List<BaseEotETalent> { }, 10);
            TalentB2 = new JumpUpTalent(new List<BaseEotETalent> {  }, 10);
            TalentB3 = new QuickStrikeTalent(new List<BaseEotETalent> {  }, 10);
            TalentB4 = new QuickDrawTalent(new List<BaseEotETalent> {  }, 10);
            TalentC1 = new TargetedBlowTalent(new List<BaseEotETalent> {  }, 15);
            TalentC2 = new StalkerTalent(new List<BaseEotETalent> {  }, 15);
            TalentC3 = new LethalBlowsTalent(new List<BaseEotETalent> {  }, 15);
            TalentC4 = new AnatomyLessonsTalent(new List<BaseEotETalent> {  }, 15);
            TalentD1 = new StalkerTalent(new List<BaseEotETalent> {  }, 20);
            TalentD2 = new SniperShotTalent(new List<BaseEotETalent> {  }, 20);
            TalentD3 = new DodgeTalent(new List<BaseEotETalent> {  }, 20);
            TalentD4 = new LethalBlowsTalent(new List<BaseEotETalent> {  }, 20);
            TalentE1 = new PreciseAimTalent(new List<BaseEotETalent> {  }, 25);
            TalentE2 = new DeadlyAccuracyTalent(new List<BaseEotETalent> {  }, 25);
            TalentE3 = new DedicationTalent(new List<BaseEotETalent> {  }, 25);
            TalentE4 = new MasterOfShadowsTalent(new List<BaseEotETalent> {  }, 25);

            TalentB1.ParentTalents = new List<BaseEotETalent> { TalentA1, TalentB2, TalentC1 };
            TalentB2.ParentTalents = new List<BaseEotETalent> { TalentA2, TalentB1, TalentB3, TalentC2 };
            TalentB3.ParentTalents = new List<BaseEotETalent> { TalentA3, TalentB2, TalentB4, TalentC3 };
            TalentB4.ParentTalents = new List<BaseEotETalent> { TalentA4, TalentB3 };
            TalentC1.ParentTalents = new List<BaseEotETalent> { TalentB1, TalentD1 };
            TalentC2.ParentTalents = new List<BaseEotETalent> { TalentB2, TalentC3, TalentD2 };
            TalentC3.ParentTalents = new List<BaseEotETalent> { TalentB3, TalentC2 };
            TalentC4.ParentTalents = new List<BaseEotETalent> { TalentB4 };
            TalentD1.ParentTalents = new List<BaseEotETalent> { TalentC1, TalentD2 };
            TalentD2.ParentTalents = new List<BaseEotETalent> { TalentC2, TalentD1 };
            TalentD3.ParentTalents = new List<BaseEotETalent> { TalentC3 };
            TalentD4.ParentTalents = new List<BaseEotETalent> { TalentC4 };
            TalentE1.ParentTalents = new List<BaseEotETalent> { TalentD1 };
            TalentE2.ParentTalents = new List<BaseEotETalent> { TalentD2 };
            TalentE3.ParentTalents = new List<BaseEotETalent> { TalentD3 };
            TalentE4.ParentTalents = new List<BaseEotETalent> { TalentD4 };

            TalentA1.ChildTalents = new List<BaseEotETalent> { TalentB1 };
            TalentA2.ChildTalents = new List<BaseEotETalent> { TalentB2 };
            TalentA3.ChildTalents = new List<BaseEotETalent> { TalentB3 };
            TalentA4.ChildTalents = new List<BaseEotETalent> { TalentB4 };
            TalentB1.ChildTalents = new List<BaseEotETalent> { TalentB2, TalentC1 };
            TalentB2.ChildTalents = new List<BaseEotETalent> { TalentB1, TalentB3, TalentC2 };
            TalentB3.ChildTalents = new List<BaseEotETalent> { TalentB2, TalentB4, TalentC3 };
            TalentB4.ChildTalents = new List<BaseEotETalent> { TalentB3, TalentC4 };
            TalentC1.ChildTalents = new List<BaseEotETalent> { TalentD1 };
            TalentC2.ChildTalents = new List<BaseEotETalent> { TalentC3, TalentD2 };
            TalentC3.ChildTalents = new List<BaseEotETalent> { TalentC2, TalentD3 };
            TalentC4.ChildTalents = new List<BaseEotETalent> { TalentD4 };
            TalentD1.ChildTalents = new List<BaseEotETalent> { TalentD2, TalentE1 };
            TalentD2.ChildTalents = new List<BaseEotETalent> { TalentD1, TalentE2 };
            TalentD3.ChildTalents = new List<BaseEotETalent> { TalentE3 };
            TalentD4.ChildTalents = new List<BaseEotETalent> { TalentE4 };
            TalentE1.ChildTalents = new List<BaseEotETalent> { };
            TalentE2.ChildTalents = new List<BaseEotETalent> { };
            TalentE3.ChildTalents = new List<BaseEotETalent> { };
            TalentE4.ChildTalents = new List<BaseEotETalent> { };

            TalentMatrix = new List<List<BaseEotETalent>> { new List<BaseEotETalent> { TalentA1, TalentA2, TalentA3, TalentA4 },
                                                            new List<BaseEotETalent> { TalentB1, TalentB2, TalentB3, TalentB4 },
                                                            new List<BaseEotETalent> { TalentC1, TalentC2, TalentC3, TalentC4 },
                                                            new List<BaseEotETalent> { TalentD1, TalentD2, TalentD3, TalentD4 },
                                                            new List<BaseEotETalent> { TalentE1, TalentE2, TalentE3, TalentE4 }
                                                          };
        }

    }

    public class GadgeteerSpecialization : BaseSpecialization
    {

        public GadgeteerSpecialization()
        {
            SpecName = "Gadgeteer";
            SpecCareer = BaseEotECareer.EotECareers.BOUNTYHUNTER;
            SpecSkills = new List<BaseEotECareer.EotESkills> { BaseEotECareer.EotESkills.BRAWL, BaseEotECareer.EotESkills.COERCION, BaseEotECareer.EotESkills.MECHANICS, BaseEotECareer.EotESkills.RANGEDLIGHT };
            SpecDescription = "Connoisseur of Tech\n\nConsidering how often a single Bounty Hunter finds himself faced with terrible " +
                              "odds (more often than not, an acquisition has friends or employees who work hard to protect him), it's " +
                              "not surprising how many specialize in high-tech gear and weapons. The Gadgeteer excels at presenting " +
                              "himself as a one-person battle force, at least for a short time. Using both the latest tech and his own " +
                              "personally modified gear, a Bounty Hunter with this specialization can be hard to stop.";

            /* Talent Tree */
            TalentA1 = new BraceTalent(true, 5);
            TalentA2 = new ToughenedTalent(true, 5);
            TalentA3 = new IntimidatingTalent(true, 5);
            TalentA4 = new DefensiveStanceTalent(true, 5);
            TalentB1 = new SpareClipTalent(new List<BaseEotETalent> {  }, 10);
            TalentB2 = new JuryRiggedTalent(new List<BaseEotETalent> {  }, 10);
            TalentB3 = new PointBlankTalent(new List<BaseEotETalent> {  }, 10);
            TalentB4 = new DisorientTalent(new List<BaseEotETalent> {  }, 10);
            TalentC1 = new ToughenedTalent(new List<BaseEotETalent> {  }, 15);
            TalentC2 = new ArmorMasterTalent(new List<BaseEotETalent> {  }, 15);
            TalentC3 = new NaturalEnforcerTalent(new List<BaseEotETalent> {  }, 15);
            TalentC4 = new StunningBlowTalent(new List<BaseEotETalent> {  }, 15);
            TalentD1 = new JuryRiggedTalent(new List<BaseEotETalent> {  }, 20);
            TalentD2 = new TinkererTalent(new List<BaseEotETalent> {  }, 20);
            TalentD3 = new DeadlyAccuracyTalent(new List<BaseEotETalent> {  }, 20);
            TalentD4 = new StunningBlowImprovedTalent(new List<BaseEotETalent> {  }, 20);
            TalentE1 = new IntimidatingTalent(new List<BaseEotETalent> {  }, 25);
            TalentE2 = new DedicationTalent(new List<BaseEotETalent> {  }, 25);
            TalentE3 = new ArmorMasterImprovedTalent(new List<BaseEotETalent> {  }, 25);
            TalentE4 = new CripplingBlowTalent(new List<BaseEotETalent> {  }, 25);

            TalentB1.ParentTalents = new List<BaseEotETalent> { TalentB2 };
            TalentB2.ParentTalents = new List<BaseEotETalent> { TalentA2 };
            TalentB3.ParentTalents = new List<BaseEotETalent> { TalentB2 };
            TalentB4.ParentTalents = new List<BaseEotETalent> { TalentA4 };
            TalentC1.ParentTalents = new List<BaseEotETalent> { TalentC2 };
            TalentC2.ParentTalents = new List<BaseEotETalent> { TalentB2 };
            TalentC3.ParentTalents = new List<BaseEotETalent> { TalentC2 };
            TalentC4.ParentTalents = new List<BaseEotETalent> { TalentB4 };
            TalentD1.ParentTalents = new List<BaseEotETalent> { TalentD2 };
            TalentD2.ParentTalents = new List<BaseEotETalent> { TalentC2 };
            TalentD3.ParentTalents = new List<BaseEotETalent> { TalentD2 };
            TalentD4.ParentTalents = new List<BaseEotETalent> { TalentC4 };
            TalentE1.ParentTalents = new List<BaseEotETalent> { TalentE2 };
            TalentE2.ParentTalents = new List<BaseEotETalent> { TalentD2 };
            TalentE3.ParentTalents = new List<BaseEotETalent> { TalentE2 };
            TalentE4.ParentTalents = new List<BaseEotETalent> { TalentD4 };

            TalentMatrix = new List<List<BaseEotETalent>> { new List<BaseEotETalent> { TalentA1, TalentA2, TalentA3, TalentA4 },
                                                            new List<BaseEotETalent> { TalentB1, TalentB2, TalentB3, TalentB4 },
                                                            new List<BaseEotETalent> { TalentC1, TalentC2, TalentC3, TalentC4 },
                                                            new List<BaseEotETalent> { TalentD1, TalentD2, TalentD3, TalentD4 },
                                                            new List<BaseEotETalent> { TalentE1, TalentE2, TalentE3, TalentE4 }
                                                          };
        }


    }

    public class SurvivalistSpecialization : BaseSpecialization
    {

        public SurvivalistSpecialization()
        {
            SpecName = "Survivalist";
            SpecCareer = BaseEotECareer.EotECareers.BOUNTYHUNTER;
            SpecSkills = new List<BaseEotECareer.EotESkills> { BaseEotECareer.EotESkills.XENOLOGY, BaseEotECareer.EotESkills.PERCEPTION, BaseEotECareer.EotESkills.RESILIENCE, BaseEotECareer.EotESkills.SURVIVAL };
            SpecDescription = "Master of the Wild\n\nBeyond civilization, in the farthest reaches of the galaxy, there are places where " +
                              "few (if any) sentients have ever trodden the ground. Places like these are ideal hiding places for those " +
                              "fleeing the law or retribution for their actions. Places like these are where Bounty Hunters who specialize " +
                              "as Survivalists thrive. ";

            /* Talent Tree */
            TalentA1 = new ForagerTalent(true, 5);
            TalentA2 = new StalkerTalent(true, 5);
            TalentA3 = new OutdoorsmanTalent(true, 5);
            TalentA4 = new ExpertTrackerTalent(true, 5);
            TalentB1 = new OutdoorsmanTalent(new List<BaseEotETalent> {  }, 10);
            TalentB2 = new SwiftTalent(new List<BaseEotETalent> {  }, 10);
            TalentB3 = new HunterTalent(new List<BaseEotETalent> {  }, 10);
            TalentB4 = new SoftSpotTalent(new List<BaseEotETalent> {  }, 10);
            TalentC1 = new ToughenedTalent(new List<BaseEotETalent> {  }, 15);
            TalentC2 = new ExpertTrackerTalent(new List<BaseEotETalent> {  }, 15);
            TalentC3 = new StalkerTalent(new List<BaseEotETalent> {  }, 15);
            TalentC4 = new NaturalOutdoorsmanTalent(new List<BaseEotETalent> {  }, 15);
            TalentD1 = new ToughenedTalent(new List<BaseEotETalent> {  }, 20);
            TalentD2 = new HunterTalent(new List<BaseEotETalent> {  }, 20);
            TalentD3 = new ExpertTrackerTalent(new List<BaseEotETalent> {  }, 20);
            TalentD4 = new BloodedTalent(new List<BaseEotETalent> {  }, 20);
            TalentE1 = new EnduringTalent(new List<BaseEotETalent> {  }, 25);
            TalentE2 = new DedicationTalent(new List<BaseEotETalent> {  }, 25);
            TalentE3 = new GritTalent(new List<BaseEotETalent> {  }, 25);
            TalentE4 = new HeroicFortitudeTalent(new List<BaseEotETalent> {  }, 25);

            TalentB1.ParentTalents = new List<BaseEotETalent> { TalentA1, TalentB2, TalentC1 };
            TalentB2.ParentTalents = new List<BaseEotETalent> { TalentA2, TalentB1, TalentB3 };
            TalentB3.ParentTalents = new List<BaseEotETalent> { TalentA3, TalentB2, TalentB4, TalentC3 };
            TalentB4.ParentTalents = new List<BaseEotETalent> { TalentB3, TalentC4 };
            TalentC1.ParentTalents = new List<BaseEotETalent> { TalentB1 };
            TalentC2.ParentTalents = new List<BaseEotETalent> { TalentB2 };
            TalentC3.ParentTalents = new List<BaseEotETalent> { TalentB3, TalentC4 };
            TalentC4.ParentTalents = new List<BaseEotETalent> { TalentB4, TalentC3 };
            TalentD1.ParentTalents = new List<BaseEotETalent> { TalentC1, TalentE1 };
            TalentD2.ParentTalents = new List<BaseEotETalent> { TalentC2 };
            TalentD3.ParentTalents = new List<BaseEotETalent> { TalentC3, TalentE3 };
            TalentD4.ParentTalents = new List<BaseEotETalent> { TalentC4 };
            TalentE1.ParentTalents = new List<BaseEotETalent> { TalentD1, TalentE2 };
            TalentE2.ParentTalents = new List<BaseEotETalent> { TalentE1, TalentE3 };
            TalentE3.ParentTalents = new List<BaseEotETalent> { TalentE2, TalentD3 };
            TalentE4.ParentTalents = new List<BaseEotETalent> { TalentD4 };

            



            TalentMatrix = new List<List<BaseEotETalent>> { new List<BaseEotETalent> { TalentA1, TalentA2, TalentA3, TalentA4 },
                                                            new List<BaseEotETalent> { TalentB1, TalentB2, TalentB3, TalentB4 },
                                                            new List<BaseEotETalent> { TalentC1, TalentC2, TalentC3, TalentC4 },
                                                            new List<BaseEotETalent> { TalentD1, TalentD2, TalentD3, TalentD4 },
                                                            new List<BaseEotETalent> { TalentE1, TalentE2, TalentE3, TalentE4 }
                                                          };
        }

    }
}