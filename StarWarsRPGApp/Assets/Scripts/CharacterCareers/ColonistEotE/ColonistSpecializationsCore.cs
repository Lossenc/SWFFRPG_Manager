using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Specialization.EotE.Colonist.Core
{
    public class DoctorSpecialization : BaseSpecialization
    {

        public DoctorSpecialization()
        {
            SpecName = "Doctor";
            SpecCareer = BaseEotECareer.EotECareers.COLONIST;
            SpecSkills = new List<BaseEotECareer.EotESkills> { BaseEotECareer.EotESkills.COOL, BaseEotECareer.EotESkills.EDUCATION, BaseEotECareer.EotESkills.MEDICINE, BaseEotECareer.EotESkills.RESILIENCE };
            SpecDescription = "The Gift of Healing\n\nOf all the types of Colonists who come to the Outer Rim, Doctors probably have the " +
                              "easiest time finding employment. They are in high demand almost anywhere they go. Unfortunately, most of what " +
                              "they are asked to do involves patching up the wounds of the worst kind of beings.";

            /* Talent Tree */
            TalentA1 = new SurgeonTalent(true, 5);
            TalentA2 = new BactaSpecialistTalent(true, 5);
            TalentA3 = new GritTalent(true, 5);
            TalentA4 = new ResolveTalent(true, 5);
            TalentB1 = new StimApplicationTalent(new List<BaseEotETalent> { TalentA1, TalentB2, TalentC1 }, 10);
            TalentB2 = new GritTalent(new List<BaseEotETalent> { TalentB1, TalentB3 }, 10);
            TalentB3 = new SurgeonTalent(new List<BaseEotETalent> { TalentA3, TalentB2, TalentB4, TalentC3 }, 10);
            TalentB4 = new ResolveTalent(new List<BaseEotETalent> { TalentB3, TalentC4 }, 10);
            TalentC1 = new SurgeonTalent(new List<BaseEotETalent> { TalentB1, TalentC2, TalentD1 }, 15);
            TalentC2 = new GritTalent(new List<BaseEotETalent> { TalentC1, TalentC3, TalentD2 }, 15);
            TalentC3 = new BactaSpecialistTalent(new List<BaseEotETalent> { TalentB3, TalentC2, TalentD3 }, 15);
            TalentC4 = new PressurePointTalent(new List<BaseEotETalent> { TalentB4 }, 15);
            TalentD1 = new StimApplicationImprovedTalent(new List<BaseEotETalent> { TalentC1, TalentE1 }, 20);
            TalentD2 = new NaturalDoctorTalent(new List<BaseEotETalent> { TalentC2, TalentE2 }, 20);
            TalentD3 = new ToughenedTalent(new List<BaseEotETalent> { TalentC3, TalentE3 }, 20);
            TalentD4 = new AnatomyLessonsTalent(new List<BaseEotETalent> { TalentC4 }, 20);
            TalentE1 = new StimApplicationSupremeTalent(new List<BaseEotETalent> { TalentD1, TalentE2 }, 25);
            TalentE2 = new MasterDoctorTalent(new List<BaseEotETalent> { TalentE1, TalentD2, TalentE3 }, 25);
            TalentE3 = new DedicationTalent(new List<BaseEotETalent> { TalentD3, TalentE2 }, 25);
            TalentE4 = new DodgeTalent(new List<BaseEotETalent> { TalentD4 }, 25);

            TalentMatrix = new List<List<BaseEotETalent>> { new List<BaseEotETalent> { TalentA1, TalentA2, TalentA3, TalentA4 },
                                                            new List<BaseEotETalent> { TalentB1, TalentB2, TalentB3, TalentB4 },
                                                            new List<BaseEotETalent> { TalentC1, TalentC2, TalentC3, TalentC4 },
                                                            new List<BaseEotETalent> { TalentD1, TalentD2, TalentD3, TalentD4 },
                                                            new List<BaseEotETalent> { TalentE1, TalentE2, TalentE3, TalentE4 }
                                                          };
        }

    }

    public class PoliticoSpecialization : BaseSpecialization
    {

        public PoliticoSpecialization()
        {
            SpecName = "Politico";
            SpecCareer = BaseEotECareer.EotECareers.COLONIST;
            SpecSkills = new List<BaseEotECareer.EotESkills> { BaseEotECareer.EotESkills.CHARM, BaseEotECareer.EotESkills.COERCION, BaseEotECareer.EotESkills.DECEPTION, BaseEotECareer.EotESkills.COREWORLDS };
            SpecDescription = "The Gift of Leadership\n\nIf there is one thing a Politico knows how to do better than anyone else in the  " +
                              "galaxy, it's talking. He can talk to anyone about anything in any necessary way. What others accomplish with " +
                              "might and fear, a talented Politico may well achieve with a few well-placed words and a decent plan.";

            /* Talent Tree */
            TalentA1 = new KillWithKindnessTalent(true, 5);
            TalentA2 = new GritTalent(true, 5);
            TalentA3 = new PlausibleDeniabilityTalent(true, 5);
            TalentA4 = new ToughenedTalent(true, 5);
            TalentB1 = new InspiringRhetoricTalent(new List<BaseEotETalent> { TalentA1, TalentB2, TalentC1 }, 10);
            TalentB2 = new KillWithKindnessTalent(new List<BaseEotETalent> { TalentA2, TalentB1 }, 10);
            TalentB3 = new ScathingTiradeTalent(new List<BaseEotETalent> { TalentA3, TalentB4 }, 10);
            TalentB4 = new PlausibleDeniabilityTalent(new List<BaseEotETalent> { TalentA4, TalentB3, TalentC4 }, 10);
            TalentC1 = new DodgeTalent(new List<BaseEotETalent> { TalentB1, TalentD1 }, 15);
            TalentC2 = new InspiringRhetoricImprovedTalent(new List<BaseEotETalent> { TalentC1 }, 15);
            TalentC3 = new ScathingTiradeImprovedTalent(new List<BaseEotETalent> { TalentC4 }, 15);
            TalentC4 = new WellRoundedTalent(new List<BaseEotETalent> { TalentB4, TalentD4 }, 15);
            TalentD1 = new GritTalent(new List<BaseEotETalent> { TalentC1, TalentE1 }, 20);
            TalentD2 = new InspiringRhetoricSupremeTalent(new List<BaseEotETalent> { TalentC2 }, 20);
            TalentD3 = new ScathingTiradeSupremeTalent(new List<BaseEotETalent> { TalentC3 }, 20);
            TalentD4 = new NobodysFoolTalent(new List<BaseEotETalent> { TalentD4 }, 20);
            TalentE1 = new SteelyNervesTalent(new List<BaseEotETalent> { TalentD1, TalentE2 }, 25);
            TalentE2 = new DedicationTalent(new List<BaseEotETalent> { TalentE1, TalentE3 }, 25);
            TalentE3 = new NaturalCharmerTalent(new List<BaseEotETalent> { TalentE2, TalentE4 }, 25);
            TalentE4 = new IntensePresenceTalent(new List<BaseEotETalent> { TalentE4 }, 25);

            TalentMatrix = new List<List<BaseEotETalent>> { new List<BaseEotETalent> { TalentA1, TalentA2, TalentA3, TalentA4 },
                                                            new List<BaseEotETalent> { TalentB1, TalentB2, TalentB3, TalentB4 },
                                                            new List<BaseEotETalent> { TalentC1, TalentC2, TalentC3, TalentC4 },
                                                            new List<BaseEotETalent> { TalentD1, TalentD2, TalentD3, TalentD4 },
                                                            new List<BaseEotETalent> { TalentE1, TalentE2, TalentE3, TalentE4 }
                                                          };
        }

    }

    public class ScholarSpecialization : BaseSpecialization
    {

        public ScholarSpecialization()
        {
            SpecName = "Scholar";
            SpecCareer = BaseEotECareer.EotECareers.COLONIST;
            SpecSkills = new List<BaseEotECareer.EotESkills> { BaseEotECareer.EotESkills.OUTERRIM, BaseEotECareer.EotESkills.UNDERWORLD, BaseEotECareer.EotESkills.XENOLOGY, BaseEotECareer.EotESkills.PERCEPTION };
            SpecDescription = "The Gift of Knowledge\n\nAt first, the idea of a Scholar wandering with a bunch of ne'er-do-wells in the " +
                              "Outer Rim might seem a bit odd, if not downright ridiculous. However, with all of the dangers and wonders " +
                              "of \"a thousand thousand worlds,\" having someone around who actually knows something more than how to reload " +
                              "a heavy blaster could be exceedingly useful inder any number of circumstances. This is especially true when a " +
                              "group is faced with something truly unknown or needs to find something that simple tracking alone cannot locate.";

            /* Talent Tree */
            TalentA1 = new RespectedScholarTalent(true, 5);
            TalentA2 = new SpeaksBinaryTalent(true, 5);
            TalentA3 = new GritTalent(true, 5);
            TalentA4 = new BraceTalent(true, 5);
            TalentB1 = new ResearcherTalent(new List<BaseEotETalent> { TalentA1, TalentB2, TalentC1 }, 10);
            TalentB2 = new RespectedScholarTalent(new List<BaseEotETalent> { TalentA2, TalentB1 }, 10);
            TalentB3 = new ResolveTalent(new List<BaseEotETalent> { TalentA3, TalentB4 }, 10);
            TalentB4 = new ResearcherTalent(new List<BaseEotETalent> { TalentA4, TalentC4 }, 10);
            TalentC1 = new CodebreakerTalent(new List<BaseEotETalent> { TalentB1, TalentC2 }, 15);
            TalentC2 = new KnowledgeSpecializationTalent(new List<BaseEotETalent> { TalentC1, TalentD2 }, 15);
            TalentC3 = new NaturalScholarTalent(new List<BaseEotETalent> { TalentC4, TalentD3 }, 15);
            TalentC4 = new WellRoundedTalent(new List<BaseEotETalent> { TalentB4, TalentC3 }, 15);
            TalentD1 = new KnowledgeSpecializationTalent(new List<BaseEotETalent> { TalentD2, TalentE1 }, 20);
            TalentD2 = new IntenseFocusTalent(new List<BaseEotETalent> { TalentC2, TalentD1 }, 20);
            TalentD3 = new ConfidenceTalent(new List<BaseEotETalent> { TalentC3, TalentD4 }, 20);
            TalentD4 = new ResolveTalent(new List<BaseEotETalent> { TalentD3, TalentE4 }, 20);
            TalentE1 = new StrokeOfGeniusTalent(new List<BaseEotETalent> { TalentD1, TalentE2 }, 25);
            TalentE2 = new MentalFortressTalent(new List<BaseEotETalent> { TalentE1, TalentE3 }, 25);
            TalentE3 = new DedicationTalent(new List<BaseEotETalent> { TalentE2, TalentE4 }, 25);
            TalentE4 = new ToughenedTalent(new List<BaseEotETalent> { TalentD4, TalentE3 }, 25);

            TalentMatrix = new List<List<BaseEotETalent>> { new List<BaseEotETalent> { TalentA1, TalentA2, TalentA3, TalentA4 },
                                                            new List<BaseEotETalent> { TalentB1, TalentB2, TalentB3, TalentB4 },
                                                            new List<BaseEotETalent> { TalentC1, TalentC2, TalentC3, TalentC4 },
                                                            new List<BaseEotETalent> { TalentD1, TalentD2, TalentD3, TalentD4 },
                                                            new List<BaseEotETalent> { TalentE1, TalentE2, TalentE3, TalentE4 }
                                                          };
        }

    }
}