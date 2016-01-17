using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Specialization.EotE.Explorer.Core
{
    public class FringerSpecialization : BaseSpecialization
    {

        public FringerSpecialization()
        {
            SpecName = "Fringer";
            SpecCareer = BaseEotECareer.EotECareers.EXPLORER;
            SpecSkills = new List<BaseEotECareer.EotESkills> { BaseEotECareer.EotESkills.ASTROGATION, BaseEotECareer.EotESkills.COORDINATION, BaseEotECareer.EotESkills.NEGOTIATION, BaseEotECareer.EotESkills.STREETWISE };
            SpecDescription = "Discovering Possibilities\n\nPart negotiator, part astrogator, and savvy in the ways of the galaxy beyond the " +
                              "Core Worlds, the Fringer is a jack-of-all-trades. He focuses on knowing how to find what he needs and how to get " +
                              "where he needs to go. He's got the gift of gab when it's time to talk, and the awareness and reflexes to maneuver " +
                              "away when it's time to run.";

            /* Talent Tree */
            TalentA1 = new GalaxyMapperTalent(true, 5);
            TalentA2 = new StreetSmartsTalent(true, 5);
            TalentA3 = new RapidRecoveryTalent(true, 5);
            TalentA4 = new StreetSmartsTalent(true, 5);
            TalentB1 = new SkilledJockeyTalent(new List<BaseEotETalent> { TalentA1 }, 10);
            TalentB2 = new GalaxyMapperTalent(new List<BaseEotETalent> { TalentB1, TalentC2 }, 10);
            TalentB3 = new GritTalent(new List<BaseEotETalent> { TalentA3, TalentB4 }, 10);
            TalentB4 = new ToughenedTalent(new List<BaseEotETalent> { TalentA4, TalentB3 }, 10);
            TalentC1 = new MasterStarhopperTalent(new List<BaseEotETalent> { TalentB1, TalentC2 }, 15);
            TalentC2 = new DefensiveDrivingTalent(new List<BaseEotETalent> { TalentB2, TalentC1 }, 15);
            TalentC3 = new RapidRecoveryTalent(new List<BaseEotETalent> { TalentB3 }, 15);
            TalentC4 = new DurableTalent(new List<BaseEotETalent> { TalentB4 }, 15);
            TalentD1 = new RapidRecoveryTalent(new List<BaseEotETalent> { TalentD2, TalentE1 }, 20);
            TalentD2 = new JumpUpTalent(new List<BaseEotETalent> { TalentD3 }, 20);
            TalentD3 = new GritTalent(new List<BaseEotETalent> { TalentC3 }, 20);
            TalentD4 = new KnockdownTalent(new List<BaseEotETalent> { TalentC4 }, 20);
            TalentE1 = new DedicationTalent(new List<BaseEotETalent> { TalentD1, TalentE2 }, 25);
            TalentE2 = new ToughenedTalent(new List<BaseEotETalent> { TalentD2, TalentE1 }, 25);
            TalentE3 = new DodgeTalent(new List<BaseEotETalent> { TalentE4 }, 25);
            TalentE4 = new DodgeTalent(new List<BaseEotETalent> { TalentD4 }, 25);

            TalentMatrix = new List<List<BaseEotETalent>> { new List<BaseEotETalent> { TalentA1, TalentA2, TalentA3, TalentA4 },
                                                            new List<BaseEotETalent> { TalentB1, TalentB2, TalentB3, TalentB4 },
                                                            new List<BaseEotETalent> { TalentC1, TalentC2, TalentC3, TalentC4 },
                                                            new List<BaseEotETalent> { TalentD1, TalentD2, TalentD3, TalentD4 },
                                                            new List<BaseEotETalent> { TalentE1, TalentE2, TalentE3, TalentE4 }
                                                          };
        }

    }

    public class ScoutSpecialization : BaseSpecialization
    {

        public ScoutSpecialization()
        {
            SpecName = "Scout";
            SpecCareer = BaseEotECareer.EotECareers.EXPLORER;
            SpecSkills = new List<BaseEotECareer.EotESkills> { BaseEotECareer.EotESkills.ATHLETICS, BaseEotECareer.EotESkills.MEDICINE, BaseEotECareer.EotESkills.PILOTINGPLANETARY, BaseEotECareer.EotESkills.SURVIVAL };
            SpecDescription = "Discovering New Planets\n\nThere's finding a planet, and then there's going down to the planet and seeing what's " +
                              "what. The Scout is the professional for the task, trained to survey and survive, gathering all of the information " +
                              "he can while keeping his head attached to his body. While bravery in combat is one thing, there can be no denying " +
                              "the fearlessness of anyone willing to touch down on a completely unknown planet and trudge about with only scanners " +
                              "and his wits to discover its secrets.";

            /* Talent Tree */
            TalentA1 = new RapidRecoveryTalent(true, 5);
            TalentA2 = new StalkerTalent(true, 5);
            TalentA3 = new GritTalent(true, 5);
            TalentA4 = new ShortcutTalent(true, 5);
            TalentB1 = new ForagerTalent(new List<BaseEotETalent> { TalentA1, TalentB2, TalentC1 }, 10);
            TalentB2 = new QuickStrikeTalent(new List<BaseEotETalent> { TalentA2, TalentB1, TalentB3 }, 10);
            TalentB3 = new LetsRideTalent(new List<BaseEotETalent> { TalentA3, TalentB2, TalentB4 }, 10);
            TalentB4 = new DisorientTalent(new List<BaseEotETalent> { TalentA4, TalentB3 }, 10);
            TalentC1 = new RapidRecoveryTalent(new List<BaseEotETalent> { TalentB1, TalentD1 }, 15);
            TalentC2 = new NaturalHunterTalent(new List<BaseEotETalent> { TalentB2 }, 15);
            TalentC3 = new FamiliarSunsTalent(new List<BaseEotETalent> { TalentB3, TalentD3 }, 15);
            TalentC4 = new ShortcutTalent(new List<BaseEotETalent> { TalentB4 }, 15);
            TalentD1 = new GritTalent(new List<BaseEotETalent> { TalentC1, TalentE1 }, 20);
            TalentD2 = new HeightenedAwarenessTalent(new List<BaseEotETalent> { TalentC2 }, 20);
            TalentD3 = new ToughenedTalent(new List<BaseEotETalent> { TalentC3, TalentE3 }, 20);
            TalentD4 = new QuickStrikeTalent(new List<BaseEotETalent> { TalentC4 }, 20);
            TalentE1 = new UtilityBeltTalent(new List<BaseEotETalent> { TalentD1, TalentE2 }, 25);
            TalentE2 = new DedicationTalent(new List<BaseEotETalent> { TalentE1, TalentE3 }, 25);
            TalentE3 = new StalkerTalent(new List<BaseEotETalent> { TalentE2, TalentD3 }, 25);
            TalentE4 = new DisorientTalent(new List<BaseEotETalent> { TalentD4 }, 25);

            TalentMatrix = new List<List<BaseEotETalent>> { new List<BaseEotETalent> { TalentA1, TalentA2, TalentA3, TalentA4 },
                                                            new List<BaseEotETalent> { TalentB1, TalentB2, TalentB3, TalentB4 },
                                                            new List<BaseEotETalent> { TalentC1, TalentC2, TalentC3, TalentC4 },
                                                            new List<BaseEotETalent> { TalentD1, TalentD2, TalentD3, TalentD4 },
                                                            new List<BaseEotETalent> { TalentE1, TalentE2, TalentE3, TalentE4 }
                                                          };
        }

    }

    public class TraderSpecialization : BaseSpecialization
    {

        public TraderSpecialization()
        {
            SpecName = "Trader";
            SpecCareer = BaseEotECareer.EotECareers.EXPLORER;
            SpecSkills = new List<BaseEotECareer.EotESkills> { BaseEotECareer.EotESkills.DECEPTION, BaseEotECareer.EotESkills.COREWORLDS, BaseEotECareer.EotESkills.UNDERWORLD, BaseEotECareer.EotESkills.NEGOTIATION };
            SpecDescription = "Discovering New Markets\n\nThose seeking to take what they discover as they explore the Outer Rim and beyond (and " +
                              "turn a serious profit from it) are Traders. For a Trader, a new planet represents nigh-infinite potential for " +
                              "resource exploitation, while a new culture or hidden community is a customer base just begging for his particular talents.";

            /* Talent Tree */
            TalentA1 = new KnowSomebodyTalent(true, 5);
            TalentA2 = new ConvincingDemeanorTalent(true, 5);
            TalentA3 = new WheelAndDealTalent(true, 5);
            TalentA4 = new SmoothTalkerTalent(true, 5);
            TalentB1 = new WheelAndDealTalent(new List<BaseEotETalent> { TalentA1 }, 10);
            TalentB2 = new GritTalent(new List<BaseEotETalent> { TalentB1 }, 10);
            TalentB3 = new SpareClipTalent(new List<BaseEotETalent> { TalentB2 }, 10);
            TalentB4 = new ToughenedTalent(new List<BaseEotETalent> { TalentB3 }, 10);
            TalentC1 = new KnowSomebodyTalent(new List<BaseEotETalent> { TalentB1 }, 15);
            TalentC2 = new NobodysFoolTalent(new List<BaseEotETalent> { TalentC1 }, 15);
            TalentC3 = new SmoothTalkerTalent(new List<BaseEotETalent> { TalentC2 }, 15);
            TalentC4 = new NobodysFoolTalent(new List<BaseEotETalent> { TalentC3 }, 15);
            TalentD1 = new WheelAndDealTalent(new List<BaseEotETalent> { TalentC1 }, 20);
            TalentD2 = new SteelyNervesTalent(new List<BaseEotETalent> { TalentD1, TalentD3 }, 20);
            TalentD3 = new BlackMarketContactsTalent(new List<BaseEotETalent> { TalentD2, TalentD4 }, 20);
            TalentD4 = new BlackMarketContactsTalent(new List<BaseEotETalent> { TalentD3, TalentE4 }, 20);
            TalentE1 = new KnowSomebodyTalent(new List<BaseEotETalent> { TalentD1, TalentE2 }, 25);
            TalentE2 = new NaturalNegotiatorTalent(new List<BaseEotETalent> { TalentE1, TalentE3 }, 25);
            TalentE3 = new DedicationTalent(new List<BaseEotETalent> { TalentE2, TalentE4 }, 25);
            TalentE4 = new MasterMerchantTalent(new List<BaseEotETalent> { TalentE3, TalentD4 }, 25);

            TalentMatrix = new List<List<BaseEotETalent>> { new List<BaseEotETalent> { TalentA1, TalentA2, TalentA3, TalentA4 },
                                                            new List<BaseEotETalent> { TalentB1, TalentB2, TalentB3, TalentB4 },
                                                            new List<BaseEotETalent> { TalentC1, TalentC2, TalentC3, TalentC4 },
                                                            new List<BaseEotETalent> { TalentD1, TalentD2, TalentD3, TalentD4 },
                                                            new List<BaseEotETalent> { TalentE1, TalentE2, TalentE3, TalentE4 }
                                                          };
        }

    }
}
