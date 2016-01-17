using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Specialization.EotE.HiredGun.Core
{
    public class BodyguardSpecialization : BaseSpecialization
    {

        public BodyguardSpecialization()
        {
            SpecName = "Bodyguard";
            SpecCareer = BaseEotECareer.EotECareers.HIREDGUN;
            SpecSkills = new List<BaseEotECareer.EotESkills> { BaseEotECareer.EotESkills.GUNNERY, BaseEotECareer.EotESkills.PERCEPTION, BaseEotECareer.EotESkills.PILOTINGPLANETARY, BaseEotECareer.EotESkills.RANGEDHEAVY };
            SpecDescription = "Personal Defender\n\nHired Guns who choose the Bodyguard specialization are excellent choices for defending both " +
                              "people and places. They tend to be highly capable with all kinds of weaponry, extremely tough and savvy in combat, " +
                              "and exactly the right people to get behind when blaster fire starts flying.";

            /* Talent Tree */
            TalentA1 = new ToughenedTalent(true, 5);
            TalentA2 = new BarrageTalent(true, 5);
            TalentA3 = new DurableTalent(true, 5);
            TalentA4 = new GritTalent(true, 5);
            TalentB1 = new BodyGuardTalent(new List<BaseEotETalent> { TalentB2 }, 10);
            TalentB2 = new HardHeadedTalent(new List<BaseEotETalent> { TalentA2, TalentC2, TalentB3 }, 10);
            TalentB3 = new BarrageTalent(new List<BaseEotETalent> { TalentA3, TalentB2, TalentC3 }, 10);
            TalentB4 = new BraceTalent(new List<BaseEotETalent> { TalentB3 }, 10);
            TalentC1 = new BodyGuardTalent(new List<BaseEotETalent> { TalentB1 }, 15);
            TalentC2 = new SideStepTalent(new List<BaseEotETalent> { TalentB2, TalentC3, TalentD2 }, 15);
            TalentC3 = new DefensiveStanceTalent(new List<BaseEotETalent> { TalentB3, TalentC2, TalentD3 }, 15);
            TalentC4 = new BraceTalent(new List<BaseEotETalent> { TalentB4 }, 15);
            TalentD1 = new EnduringTalent(new List<BaseEotETalent> { TalentC1 }, 20);
            TalentD2 = new SideStepTalent(new List<BaseEotETalent> { TalentC2, TalentD3, TalentE2 }, 20);
            TalentD3 = new DefensiveStanceTalent(new List<BaseEotETalent> { TalentC3, TalentD2, TalentE3 }, 20);
            TalentD4 = new HardHeadedTalent(new List<BaseEotETalent> { TalentD3 }, 20);
            TalentE1 = new DedicationTalent(new List<BaseEotETalent> { TalentE2 }, 25);
            TalentE2 = new BarrageTalent(new List<BaseEotETalent> { TalentD2, TalentE3 }, 25);
            TalentE3 = new ToughenedTalent(new List<BaseEotETalent> { TalentD3, TalentE2 }, 25);
            TalentE4 = new HardHeadedImprovedTalent(new List<BaseEotETalent> { TalentD4 }, 25);

            TalentMatrix = new List<List<BaseEotETalent>> { new List<BaseEotETalent> { TalentA1, TalentA2, TalentA3, TalentA4 },
                                                            new List<BaseEotETalent> { TalentB1, TalentB2, TalentB3, TalentB4 },
                                                            new List<BaseEotETalent> { TalentC1, TalentC2, TalentC3, TalentC4 },
                                                            new List<BaseEotETalent> { TalentD1, TalentD2, TalentD3, TalentD4 },
                                                            new List<BaseEotETalent> { TalentE1, TalentE2, TalentE3, TalentE4 }
                                                          };
        }

    }

    public class MarauderSpecialization : BaseSpecialization
    {

        public MarauderSpecialization()
        {
            SpecName = "Marauder";
            SpecCareer = BaseEotECareer.EotECareers.HIREDGUN;
            SpecSkills = new List<BaseEotECareer.EotESkills> { BaseEotECareer.EotESkills.COERCION, BaseEotECareer.EotESkills.MELEE, BaseEotECareer.EotESkills.RESILIENCE, BaseEotECareer.EotESkills.SURVIVAL };
            SpecDescription = "Up Close and Personal\n\nMarauders don't necessarily mind shooting their opponents, but they would much rather " +
                              "mixed up in a melee, weapons in hand, smashing and slashing their way through. Marauders are tough--probably " +
                              "the toughest combatants in any conflict. They tend to take a great deal of punishment while dealing out far more " +
                              "to any who dare go against them.";

            /* Talent Tree */
            TalentA1 = new ToughenedTalent(true, 5);
            TalentA2 = new FrenziedAttackTalent(true, 5);
            TalentA3 = new FeralStrengthTalent(true, 5);
            TalentA4 = new LethalBlowsTalent(true, 5);
            TalentB1 = new FeralStrengthTalent(new List<BaseEotETalent> { TalentA1, TalentB2 }, 10);
            TalentB2 = new ToughenedTalent(new List<BaseEotETalent> { TalentA2, TalentB1, TalentB3 }, 10);
            TalentB3 = new HeroicFortitudeTalent(new List<BaseEotETalent> { TalentA3, TalentB2, TalentB4, TalentC3 }, 10);
            TalentB4 = new KnockdownTalent(new List<BaseEotETalent> { TalentA4, TalentB3 }, 10);
            TalentC1 = new EnduringTalent(new List<BaseEotETalent> { TalentC2, TalentD1 }, 15);
            TalentC2 = new LethalBlowsTalent(new List<BaseEotETalent> { TalentB2, TalentC1, TalentC3 }, 15);
            TalentC3 = new ToughenedTalent(new List<BaseEotETalent> { TalentB3, TalentC2, TalentC4 }, 15);
            TalentC4 = new FrenziedAttackTalent(new List<BaseEotETalent> { TalentC3, TalentD4 }, 15);
            TalentD1 = new ToughenedTalent(new List<BaseEotETalent> { TalentC1, TalentD2 }, 20);
            TalentD2 = new FeralStrengthTalent(new List<BaseEotETalent> { TalentD1, TalentD3, TalentE2 }, 20);
            TalentD3 = new NaturalBrawlerTalent(new List<BaseEotETalent> { TalentD2, TalentD4 }, 20);
            TalentD4 = new LethalBlowsTalent(new List<BaseEotETalent> { TalentC4, TalentD3 }, 20);
            TalentE1 = new FrenziedAttackTalent(new List<BaseEotETalent> { TalentE2 }, 25);
            TalentE2 = new EnduringTalent(new List<BaseEotETalent> { TalentD2, TalentE3 }, 25);
            TalentE3 = new DefensiveStanceTalent(new List<BaseEotETalent> { TalentD3, TalentE2 }, 25);
            TalentE4 = new DedicationTalent(new List<BaseEotETalent> { TalentE3 }, 25);

            TalentMatrix = new List<List<BaseEotETalent>> { new List<BaseEotETalent> { TalentA1, TalentA2, TalentA3, TalentA4 },
                                                            new List<BaseEotETalent> { TalentB1, TalentB2, TalentB3, TalentB4 },
                                                            new List<BaseEotETalent> { TalentC1, TalentC2, TalentC3, TalentC4 },
                                                            new List<BaseEotETalent> { TalentD1, TalentD2, TalentD3, TalentD4 },
                                                            new List<BaseEotETalent> { TalentE1, TalentE2, TalentE3, TalentE4 }
                                                          };
        }

    }

    public class MercenarySoldierSpecialization : BaseSpecialization
    {

        public MercenarySoldierSpecialization()
        {
            SpecName = "Mercenary Soldier";
            SpecCareer = BaseEotECareer.EotECareers.HIREDGUN;
            SpecSkills = new List<BaseEotECareer.EotESkills> { BaseEotECareer.EotESkills.DISCIPLINE, BaseEotECareer.EotESkills.GUNNERY, BaseEotECareer.EotESkills.LEADERSHIP, BaseEotECareer.EotESkills.RANGEDHEAVY };
            SpecDescription = "Master of War\n\nIf the Marauder is the melee master, and the Bodyguard is the all around weapons and gear trooper, " +
                              "the Mercenary Soldier is the warfare expert. An adept of moth ranged combat and military tactics, he is a leader of " +
                              "warriors in combat and a deadly combatant himself.";

            /* Talent Tree */
            TalentA1 = new CommandTalent(true, 5);
            TalentA2 = new SecondWindTalent(true, 5);
            TalentA3 = new PointBlankTalent(true, 5);
            TalentA4 = new SideStepTalent(true, 5);
            TalentB1 = new SecondWindTalent(new List<BaseEotETalent> { TalentA1, TalentB2, TalentC1 }, 10);
            TalentB2 = new ConfidenceTalent(new List<BaseEotETalent> { TalentA2, TalentB1, TalentC2 }, 10);
            TalentB3 = new StrongArmTalent(new List<BaseEotETalent> { TalentA3, TalentB4, TalentC3 }, 10);
            TalentB4 = new PointBlankTalent(new List<BaseEotETalent> { TalentA4, TalentB3 }, 10);
            TalentC1 = new FieldCommanderTalent(new List<BaseEotETalent> { TalentB1, TalentC2 }, 15);
            TalentC2 = new CommandTalent(new List<BaseEotETalent> { TalentB2, TalentC1, TalentC3, TalentD2 }, 15);
            TalentC3 = new NaturalMarksmanTalent(new List<BaseEotETalent> { TalentB3, TalentC2, TalentC4, TalentD3 }, 15);
            TalentC4 = new SniperShotTalent(new List<BaseEotETalent> { TalentC3, TalentD4 }, 15);
            TalentD1 = new FieldCommanderImprovedTalent(new List<BaseEotETalent> { TalentC1 }, 20);
            TalentD2 = new GritTalent(new List<BaseEotETalent> { TalentC2, TalentE2 }, 20);
            TalentD3 = new ToughenedTalent(new List<BaseEotETalent> { TalentC3, TalentD4 }, 20);
            TalentD4 = new LethalBlowsTalent(new List<BaseEotETalent> { TalentC4, TalentD3, TalentE4 }, 20);
            TalentE1 = new DeadlyAccuracyTalent(new List<BaseEotETalent> { TalentE2 }, 25);
            TalentE2 = new TrueAimTalent(new List<BaseEotETalent> { TalentD2, TalentE3 }, 25);
            TalentE3 = new DedicationTalent(new List<BaseEotETalent> { TalentE2, TalentE4 }, 25);
            TalentE4 = new TrueAimTalent(new List<BaseEotETalent> { TalentD4, TalentE3 }, 25);

            TalentMatrix = new List<List<BaseEotETalent>> { new List<BaseEotETalent> { TalentA1, TalentA2, TalentA3, TalentA4 },
                                                            new List<BaseEotETalent> { TalentB1, TalentB2, TalentB3, TalentB4 },
                                                            new List<BaseEotETalent> { TalentC1, TalentC2, TalentC3, TalentC4 },
                                                            new List<BaseEotETalent> { TalentD1, TalentD2, TalentD3, TalentD4 },
                                                            new List<BaseEotETalent> { TalentE1, TalentE2, TalentE3, TalentE4 }
                                                          };
        }

    }
}
