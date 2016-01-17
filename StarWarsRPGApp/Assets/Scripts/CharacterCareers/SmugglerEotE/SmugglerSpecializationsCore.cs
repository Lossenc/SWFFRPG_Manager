using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Specialization.EotE.Smuggler.Core
{
    public class PilotSpecialization : BaseSpecialization
    {

        public PilotSpecialization()
        {
            SpecName = "Pilot";
            SpecCareer = BaseEotECareer.EotECareers.SMUGGLER;
            SpecSkills = new List<BaseEotECareer.EotESkills> { BaseEotECareer.EotESkills.ASTROGATION, BaseEotECareer.EotESkills.GUNNERY, BaseEotECareer.EotESkills.PILOTINGPLANETARY, BaseEotECareer.EotESkills.PILOTINGSPACE };
            SpecDescription = "A Galaxy of Destinations\n\nPlenty of folks know how to fly a starship, but a Smuggler who specializes as a Pilot " +
                              "develops a relationship with his ship, and it becomes an extension of his wit and his will. He can make a plodding " +
                              "old transport run far above its performance ratings, and given time and some modifications, he can turn it into one " +
                              "of the fleetest and most maneuverable craft ever to take to the stars.";

            /* Talent Tree */
            TalentA1 = new FullThrottleTalent(true, 5);
            TalentA2 = new SkilledJockeyTalent(true, 5);
            TalentA3 = new GalaxyMapperTalent(true, 5);
            TalentA4 = new LetsRideTalent(true, 5);
            TalentB1 = new SkilledJockeyTalent(new List<BaseEotETalent> { TalentA1, TalentB2, TalentC1 }, 10);
            TalentB2 = new DeadToRightsTalent(new List<BaseEotETalent> { TalentA2, TalentB1 }, 10);
            TalentB3 = new GalaxyMapperTalent(new List<BaseEotETalent> { TalentA3, TalentB4, TalentC3 }, 10);
            TalentB4 = new RapidRecoveryTalent(new List<BaseEotETalent> { TalentA4, TalentB3, TalentC4 }, 10);
            TalentC1 = new FullThrottleImprovedTalent(new List<BaseEotETalent> { TalentB1, TalentD1 }, 15);
            TalentC2 = new DeadToRightsImprovedTalent(new List<BaseEotETalent> { TalentB2 }, 15);
            TalentC3 = new GritTalent(new List<BaseEotETalent> { TalentB3, TalentC4, TalentD3 }, 15);
            TalentC4 = new NaturalPilotTalent(new List<BaseEotETalent> { TalentB4, TalentC3, TalentD4 }, 15);
            TalentD1 = new GritTalent(new List<BaseEotETalent> { TalentC1, TalentE1 }, 20);
            TalentD2 = new FullThrottleSupremeTalent(new List<BaseEotETalent> { TalentD1 }, 20);
            TalentD3 = new TrickyTargetTalent(new List<BaseEotETalent> { TalentC3, TalentE3 }, 20);
            TalentD4 = new DefensiveDrivingTalent(new List<BaseEotETalent> { TalentC4, TalentE4 }, 20);
            TalentE1 = new MasterPilotTalent(new List<BaseEotETalent> { TalentD1, TalentE2 }, 25);
            TalentE2 = new DedicationTalent(new List<BaseEotETalent> { TalentE1, TalentE3 }, 25);
            TalentE3 = new ToughenedTalent(new List<BaseEotETalent> { TalentE2, TalentE4 }, 25);
            TalentE4 = new BrilliantEvasionTalent(new List<BaseEotETalent> { TalentD4, TalentE3 }, 25);

            TalentMatrix = new List<List<BaseEotETalent>> { new List<BaseEotETalent> { TalentA1, TalentA2, TalentA3, TalentA4 },
                                                            new List<BaseEotETalent> { TalentB1, TalentB2, TalentB3, TalentB4 },
                                                            new List<BaseEotETalent> { TalentC1, TalentC2, TalentC3, TalentC4 },
                                                            new List<BaseEotETalent> { TalentD1, TalentD2, TalentD3, TalentD4 },
                                                            new List<BaseEotETalent> { TalentE1, TalentE2, TalentE3, TalentE4 }
                                                          };
        }

    }

    public class ScoundrelSpecialization : BaseSpecialization
    {

        public ScoundrelSpecialization()
        {
            SpecName = "Scoundrel";
            SpecCareer = BaseEotECareer.EotECareers.SMUGGLER;
            SpecSkills = new List<BaseEotECareer.EotESkills> { BaseEotECareer.EotESkills.CHARM, BaseEotECareer.EotESkills.COOL, BaseEotECareer.EotESkills.DECEPTION, BaseEotECareer.EotESkills.RANGEDLIGHT };
            SpecDescription = "A Galaxy of Marks\n\nPart con artist, part gunslinger, and part cantina brawler, the Scoundrel is quick-witted, quick " +
                              "on his feet, and quick to get himself into a great deal of trouble at the drop of a hat. He doesn't care one whit for " +
                              "rules or laws, except where he can use them to work an angle that either nets him a lot of credits or brings down an " +
                              "enemy. If he's really lucky--and he tends to have an unshakable faith in his luck--he'll manage both.";

            /* Talent Tree */
            TalentA1 = new BlackMarketContactsTalent(true, 5);
            TalentA2 = new ConvincingDemeanorTalent(true, 5);
            TalentA3 = new QuickDrawTalent(true, 5);
            TalentA4 = new RapidReactionTalent(true, 5);
            TalentB1 = new ConvincingDemeanorTalent(new List<BaseEotETalent> { TalentA1, TalentC1 }, 10);
            TalentB2 = new BlackMarketContactsTalent(new List<BaseEotETalent> { TalentB1, TalentC2 }, 10);
            TalentB3 = new ConvincingDemeanorTalent(new List<BaseEotETalent> { TalentB2, TalentC3 }, 10);
            TalentB4 = new QuickStrikeTalent(new List<BaseEotETalent> { TalentA4, TalentC4 }, 10);
            TalentC1 = new HiddenStorageTalent(new List<BaseEotETalent> { TalentB1, TalentD1 }, 15);
            TalentC2 = new ToughenedTalent(new List<BaseEotETalent> { TalentB2, TalentC3, TalentD2 }, 15);
            TalentC3 = new BlackMarketContactsTalent(new List<BaseEotETalent> { TalentB1, TalentC2, TalentD3 }, 15);
            TalentC4 = new SideStepTalent(new List<BaseEotETalent> { TalentB4, TalentD4 }, 15);
            TalentD1 = new ToughenedTalent(new List<BaseEotETalent> { TalentC1, TalentE1 }, 20);
            TalentD2 = new RapidReactionTalent(new List<BaseEotETalent> { TalentC2, TalentD3, TalentE2 }, 20);
            TalentD3 = new HiddenStorageTalent(new List<BaseEotETalent> { TalentC3, TalentD2, TalentE3 }, 20);
            TalentD4 = new SideStepTalent(new List<BaseEotETalent> { TalentC4, TalentE4 }, 20);
            TalentE1 = new DedicationTalent(new List<BaseEotETalent> { TalentD1, TalentE2 }, 25);
            TalentE2 = new NaturalCharmerTalent(new List<BaseEotETalent> { TalentE1, TalentD2, TalentE3 }, 25);
            TalentE3 = new SoftSpotTalent(new List<BaseEotETalent> { TalentD3, TalentE2, TalentE4 }, 25);
            TalentE4 = new QuickStrikeTalent(new List<BaseEotETalent> { TalentD4, TalentE3 }, 25);

            TalentMatrix = new List<List<BaseEotETalent>> { new List<BaseEotETalent> { TalentA1, TalentA2, TalentA3, TalentA4 },
                                                            new List<BaseEotETalent> { TalentB1, TalentB2, TalentB3, TalentB4 },
                                                            new List<BaseEotETalent> { TalentC1, TalentC2, TalentC3, TalentC4 },
                                                            new List<BaseEotETalent> { TalentD1, TalentD2, TalentD3, TalentD4 },
                                                            new List<BaseEotETalent> { TalentE1, TalentE2, TalentE3, TalentE4 }
                                                          };
        }

    }

    public class ThiefSpecialization : BaseSpecialization
    {

        public ThiefSpecialization()
        {
            SpecName = "Thief";
            SpecCareer = BaseEotECareer.EotECareers.SMUGGLER;
            SpecSkills = new List<BaseEotECareer.EotESkills> { BaseEotECareer.EotESkills.COMPUTERS, BaseEotECareer.EotESkills.SKULDUGGERY, BaseEotECareer.EotESkills.STEALTH, BaseEotECareer.EotESkills.VIGILANCE };
            SpecDescription = "A Galaxy of Treasures\n\nWhere the Scoundrel is a bit flashier, and the Pilot focuses on mastering his ship, the " +
                              "Thief really is a covert operative. His ideal circumstance is to get into places blocked to others, grab things he's " +
                              "not supposed to have, and get out without anyone ever knowing he was there. If he can sell what he grabbed for a tidy " +
                              "sum, that makes for a perfect day.";

            /* Talent Tree */
            TalentA1 = new StreetSmartsTalent(true, 5);
            TalentA2 = new BlackMarketContactsTalent(true, 5);
            TalentA3 = new IndistinguishableTalent(true, 5);
            TalentA4 = new BypassSecurityTalent(true, 5);
            TalentB1 = new BlackMarketContactsTalent(new List<BaseEotETalent> { TalentA1, TalentB2, TalentC1 }, 10);
            TalentB2 = new DodgeTalent(new List<BaseEotETalent> { TalentB1, TalentB3, TalentC2 }, 10);
            TalentB3 = new GritTalent(new List<BaseEotETalent> { TalentB2, TalentB4, TalentC3 }, 10);
            TalentB4 = new HiddenStorageTalent(new List<BaseEotETalent> { TalentA4, TalentB3, TalentC4 }, 10);
            TalentC1 = new StalkerTalent(new List<BaseEotETalent> { TalentB1, TalentC2, TalentD1 }, 15);
            TalentC2 = new GritTalent(new List<BaseEotETalent> { TalentB2, TalentC1, TalentC3, TalentD2 }, 15);
            TalentC3 = new RapidReactionTalent(new List<BaseEotETalent> { TalentB3, TalentC2, TalentC4, TalentD3 }, 15);
            TalentC4 = new ShortcutTalent(new List<BaseEotETalent> { TalentB4, TalentC3, TalentD4 }, 15);
            TalentD1 = new BypassSecurityTalent(new List<BaseEotETalent> { TalentC1 }, 20);
            TalentD2 = new NaturalRogueTalent(new List<BaseEotETalent> { TalentC2, TalentD3, TalentE2 }, 20);
            TalentD3 = new StreetSmartsTalent(new List<BaseEotETalent> { TalentC3, TalentD2, TalentD4, TalentE3 }, 20);
            TalentD4 = new JumpUpTalent(new List<BaseEotETalent> { TalentC4, TalentD3 }, 20);
            TalentE1 = new MasterOfShadowsTalent(new List<BaseEotETalent> { TalentD1 }, 25);
            TalentE2 = new DodgeTalent(new List<BaseEotETalent> { TalentD2, TalentE3 }, 25);
            TalentE3 = new IndistinguishableTalent(new List<BaseEotETalent> { TalentD3, TalentE2 }, 25);
            TalentE4 = new DedicationTalent(new List<BaseEotETalent> { TalentD4 }, 25);

            TalentMatrix = new List<List<BaseEotETalent>> { new List<BaseEotETalent> { TalentA1, TalentA2, TalentA3, TalentA4 },
                                                            new List<BaseEotETalent> { TalentB1, TalentB2, TalentB3, TalentB4 },
                                                            new List<BaseEotETalent> { TalentC1, TalentC2, TalentC3, TalentC4 },
                                                            new List<BaseEotETalent> { TalentD1, TalentD2, TalentD3, TalentD4 },
                                                            new List<BaseEotETalent> { TalentE1, TalentE2, TalentE3, TalentE4 }
                                                          };
        }

    }
}
