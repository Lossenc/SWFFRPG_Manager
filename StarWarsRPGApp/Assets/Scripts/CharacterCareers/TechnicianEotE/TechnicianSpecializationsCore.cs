using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Specialization.EotE.Technician.Core
{
    public class MechanicSpecialization : BaseSpecialization
    {

        public MechanicSpecialization()
        {
            SpecName = "Mechanic";
            SpecCareer = BaseEotECareer.EotECareers.TECHNICIAN;
            SpecSkills = new List<BaseEotECareer.EotESkills> { BaseEotECareer.EotESkills.BRAWL, BaseEotECareer.EotESkills.MECHANICS, BaseEotECareer.EotESkills.PILOTINGSPACE, BaseEotECareer.EotESkills.SKULDUGGERY };
            SpecDescription = "Making Stuff Work\n\nDepending on who is asked, Mechanics are either the glue that holds everything together or the " +
                              "grease that makes it all go. Most Mechanics would tell you they do both, and then get back to work.";

            /* Talent Tree */
            TalentA1 = new GearheadTalent(true, 5);
            TalentA2 = new ToughenedTalent(true, 5);
            TalentA3 = new FineTuningTalent(true, 5);
            TalentA4 = new SolidRepairsTalent(true, 5);
            TalentB1 = new RedundantSystemsTalent(new List<BaseEotETalent> { TalentA1, TalentB2, TalentC1 }, 10);
            TalentB2 = new SolidRepairsTalent(new List<BaseEotETalent> { TalentA2, TalentB1, TalentB3, TalentC2 }, 10);
            TalentB3 = new GearheadTalent(new List<BaseEotETalent> { TalentA3, TalentB2, TalentB4, TalentC3 }, 10);
            TalentB4 = new GritTalent(new List<BaseEotETalent> { TalentA4, TalentB3, TalentC4 }, 10);
            TalentC1 = new SolidRepairsTalent(new List<BaseEotETalent> { TalentB1, TalentC2, TalentD1 }, 15);
            TalentC2 = new EnduringTalent(new List<BaseEotETalent> { TalentB2, TalentC1, TalentC3, TalentD2 }, 15);
            TalentC3 = new BadMotivatorTalent(new List<BaseEotETalent> { TalentB3, TalentC2, TalentC4, TalentD3 }, 15);
            TalentC4 = new ToughenedTalent(new List<BaseEotETalent> { TalentB4, TalentC3, TalentD4 }, 15);
            TalentD1 = new ContraptionTalent(new List<BaseEotETalent> { TalentC1, TalentD2 }, 20);
            TalentD2 = new SolidRepairsTalent(new List<BaseEotETalent> { TalentC2, TalentD1, TalentD3 }, 20);
            TalentD3 = new FineTuningTalent(new List<BaseEotETalent> { TalentC3, TalentD2 }, 20);
            TalentD4 = new HardHeadedTalent(new List<BaseEotETalent> { TalentC4 }, 20);
            TalentE1 = new NaturalTinkererTalent(new List<BaseEotETalent> { TalentD1 }, 25);
            TalentE2 = new HoldTogetherTalent(new List<BaseEotETalent> { TalentD2 }, 25);
            TalentE3 = new DedicationTalent(new List<BaseEotETalent> { TalentD3 }, 25);
            TalentE4 = new HardHeadedImprovedTalent(new List<BaseEotETalent> { TalentD4 }, 25);

            TalentMatrix = new List<List<BaseEotETalent>> { new List<BaseEotETalent> { TalentA1, TalentA2, TalentA3, TalentA4 },
                                                            new List<BaseEotETalent> { TalentB1, TalentB2, TalentB3, TalentB4 },
                                                            new List<BaseEotETalent> { TalentC1, TalentC2, TalentC3, TalentC4 },
                                                            new List<BaseEotETalent> { TalentD1, TalentD2, TalentD3, TalentD4 },
                                                            new List<BaseEotETalent> { TalentE1, TalentE2, TalentE3, TalentE4 }
                                                          };
        }

    }

    public class OutlawTechSpecialization : BaseSpecialization
    {

        public OutlawTechSpecialization()
        {
            SpecName = "OutlawTech";
            SpecCareer = BaseEotECareer.EotECareers.TECHNICIAN;
            SpecSkills = new List<BaseEotECareer.EotESkills> { BaseEotECareer.EotESkills.EDUCATION, BaseEotECareer.EotESkills.UNDERWORLD, BaseEotECareer.EotESkills.MECHANICS, BaseEotECareer.EotESkills.STREETWISE };
            SpecDescription = "Making Things Better\n\nOutlaw Techs are the specialists others call on when they want something out of the ordinary. A " +
                              "blaster that works beyond factory tolerances? No problem. A transponder that identifies a smuggler's freighter as a religious " +
                              "pilgrimage craft? It'll cost a few credits, but sure. A protocol droid altered to carry out an assassination? Just how big is " +
                              "that credit line, anyway?";

            /* Talent Tree */
            TalentA1 = new TinkererTalent(true, 5);
            TalentA2 = new UtinniTalent(true, 5);
            TalentA3 = new SpeaksBinaryTalent(true, 5);
            TalentA4 = new TinkererTalent(true, 5);
            TalentB1 = new SolidRepairsTalent(new List<BaseEotETalent> {  }, 10);
            TalentB2 = new GritTalent(new List<BaseEotETalent> {  }, 10);
            TalentB3 = new UtinniTalent(new List<BaseEotETalent> {  }, 10);
            TalentB4 = new ToughenedTalent(new List<BaseEotETalent> {  }, 10);
            TalentC1 = new UtilityBeltTalent(new List<BaseEotETalent> {  }, 15);
            TalentC2 = new SideStepTalent(new List<BaseEotETalent> {  }, 15);
            TalentC3 = new BraceTalent(new List<BaseEotETalent> {  }, 15);
            TalentC4 = new DefensiveStanceTalent(new List<BaseEotETalent> {  }, 15);
            TalentD1 = new JuryRiggedTalent(new List<BaseEotETalent> {  }, 20);
            TalentD2 = new SpeaksBinaryTalent(new List<BaseEotETalent> {  }, 20);
            TalentD3 = new InventorTalent(new List<BaseEotETalent> {  }, 20);
            TalentD4 = new JuryRiggedTalent(new List<BaseEotETalent> {  }, 20);
            TalentE1 = new InventorTalent(new List<BaseEotETalent> {  }, 25);
            TalentE2 = new DedicationTalent(new List<BaseEotETalent> {  }, 25);
            TalentE3 = new KnownSchematicTalent(new List<BaseEotETalent> {  }, 25);
            TalentE4 = new BraceTalent(new List<BaseEotETalent> {  }, 25);

            TalentB1.ParentTalents = new List<BaseEotETalent> { TalentA1, TalentB2, TalentC1 };
            TalentB2.ParentTalents = new List<BaseEotETalent> { TalentA2, TalentB1, TalentB3, TalentC2 };
            TalentB3.ParentTalents = new List<BaseEotETalent> { TalentA3, TalentB2, TalentB4, TalentC3 };
            TalentB4.ParentTalents = new List<BaseEotETalent> { TalentA4, TalentB3, TalentC4 };
            TalentC1.ParentTalents = new List<BaseEotETalent> { TalentB1, TalentC2, TalentD1 };
            TalentC2.ParentTalents = new List<BaseEotETalent> { TalentB2, TalentC1, TalentC3, TalentD2 };
            TalentC3.ParentTalents = new List<BaseEotETalent> { TalentB3, TalentC2, TalentC4, TalentD3 };
            TalentC4.ParentTalents = new List<BaseEotETalent> { TalentB4, TalentC3, TalentD4 };
            TalentD1.ParentTalents = new List<BaseEotETalent> { TalentC1, TalentD2 };
            TalentD2.ParentTalents = new List<BaseEotETalent> { TalentC2, TalentD1, TalentD3 };
            TalentD3.ParentTalents = new List<BaseEotETalent> { TalentC3, TalentD2, TalentE3 };
            TalentD4.ParentTalents = new List<BaseEotETalent> { TalentC4, TalentE4 };
            TalentE1.ParentTalents = new List<BaseEotETalent> { TalentD1 };
            TalentE2.ParentTalents = new List<BaseEotETalent> { TalentE1 };
            TalentE3.ParentTalents = new List<BaseEotETalent> { TalentD3, TalentE4 };
            TalentE4.ParentTalents = new List<BaseEotETalent> { TalentD4, TalentE3 };

            TalentA1.ChildTalents = new List<BaseEotETalent> { TalentB1 };
            TalentA2.ChildTalents = new List<BaseEotETalent> { TalentB2 };
            TalentA3.ChildTalents = new List<BaseEotETalent> { TalentB3 };
            TalentA4.ChildTalents = new List<BaseEotETalent> { TalentB4 };
            TalentB1.ChildTalents = new List<BaseEotETalent> { TalentB2, TalentC1 };
            TalentB2.ChildTalents = new List<BaseEotETalent> { TalentB1, TalentB3, TalentC2 };
            TalentB3.ChildTalents = new List<BaseEotETalent> { TalentB2, TalentB4, TalentC3 };
            TalentB4.ChildTalents = new List<BaseEotETalent> { TalentB3, TalentC4 };
            TalentC1.ChildTalents = new List<BaseEotETalent> { TalentB1, TalentC2, TalentB1 };
            TalentC2.ChildTalents = new List<BaseEotETalent> { TalentC1, TalentC3, TalentD2 };
            TalentC3.ChildTalents = new List<BaseEotETalent> { TalentB3, TalentC2, TalentD4, TalentC4 };
            TalentC4.ChildTalents = new List<BaseEotETalent> { TalentB4, TalentC3, TalentD4 };
            TalentD1.ChildTalents = new List<BaseEotETalent> { TalentC1, TalentD2, TalentE1 };
            TalentD2.ChildTalents = new List<BaseEotETalent> { TalentC2, TalentD1, TalentD3};
            TalentD3.ChildTalents = new List<BaseEotETalent> { TalentC3, TalentD2, TalentE3};
            TalentD4.ChildTalents = new List<BaseEotETalent> { TalentE4 };
            TalentE1.ChildTalents = new List<BaseEotETalent> { TalentE2 };
            TalentE2.ChildTalents = new List<BaseEotETalent> { };
            TalentE3.ChildTalents = new List<BaseEotETalent> { TalentE4 };
            TalentE4.ChildTalents = new List<BaseEotETalent> { TalentE3 };

            TalentMatrix = new List<List<BaseEotETalent>> { new List<BaseEotETalent> { TalentA1, TalentA2, TalentA3, TalentA4 },
                                                            new List<BaseEotETalent> { TalentB1, TalentB2, TalentB3, TalentB4 },
                                                            new List<BaseEotETalent> { TalentC1, TalentC2, TalentC3, TalentC4 },
                                                            new List<BaseEotETalent> { TalentD1, TalentD2, TalentD3, TalentD4 },
                                                            new List<BaseEotETalent> { TalentE1, TalentE2, TalentE3, TalentE4 }
                                                          };
        }

    }

    public class SlicerSpecialization : BaseSpecialization
    {

        public SlicerSpecialization()
        {
            SpecName = "Slicer";
            SpecCareer = BaseEotECareer.EotECareers.TECHNICIAN;
            SpecSkills = new List<BaseEotECareer.EotESkills> { BaseEotECareer.EotESkills.COMPUTERS, BaseEotECareer.EotESkills.EDUCATION, BaseEotECareer.EotESkills.UNDERWORLD, BaseEotECareer.EotESkills.STEALTH };
            SpecDescription = "Making the Data Flow\n\nFor the Slicer, a computer or datapad is just a puzzle to sove with prizes for doing so. \"Slicing\" " +
                              "is the term used for invasive efforts to steal or alter data in a system. With practically the entire galaxy wired to " +
                              "computerized systems, Slicers are extremely valuable people to know, and dangerous to cross.";

            /* Talent Tree */
            TalentA1 = new CodebreakerTalent(true, 5);
            TalentA2 = new GritTalent(true, 5);
            TalentA3 = new TechnicalAptitudeTalent(true, 5);
            TalentA4 = new BypassSecurityTalent(true, 5);
            TalentB1 = new DefensiveSlicingTalent(new List<BaseEotETalent> { TalentA1, TalentC1 }, 10);
            TalentB2 = new TechnicalAptitudeTalent(new List<BaseEotETalent> { TalentB3, TalentC2 }, 10);
            TalentB3 = new GritTalent(new List<BaseEotETalent> { TalentB2, TalentB4, TalentC3 }, 10);
            TalentB4 = new BypassSecurityTalent(new List<BaseEotETalent> { TalentB3, TalentC4 }, 10);
            TalentC1 = new NaturalProgrammerTalent(new List<BaseEotETalent> { TalentB1, TalentD1 }, 15);
            TalentC2 = new BypassSecurityTalent(new List<BaseEotETalent> { TalentB2, TalentC3, TalentD2 }, 15);
            TalentC3 = new DefensiveSlicingTalent(new List<BaseEotETalent> { TalentB3, TalentC2, TalentC4, TalentD3 }, 15);
            TalentC4 = new GritTalent(new List<BaseEotETalent> { TalentB4, TalentC3, TalentD4 }, 15);
            TalentD1 = new DefensiveSlicingTalent(new List<BaseEotETalent> { TalentC1, TalentD2, TalentE1 }, 20);
            TalentD2 = new DefensiveSlicingImprovedTalent(new List<BaseEotETalent> { TalentC2, TalentD1, TalentD3 }, 20);
            TalentD3 = new CodebreakerTalent(new List<BaseEotETalent> { TalentC3, TalentD2, TalentD4, TalentE3 }, 20);
            TalentD4 = new ResolveTalent(new List<BaseEotETalent> { TalentC4, TalentD3, TalentE4 }, 20);
            TalentE1 = new SkilledSlicerTalent(new List<BaseEotETalent> { TalentD1, TalentE2 }, 25);
            TalentE2 = new MasterSlicerTalent(new List<BaseEotETalent> { TalentD2, TalentE1, TalentE3 }, 25);
            TalentE3 = new MentalFortressTalent(new List<BaseEotETalent> { TalentD3, TalentE2, TalentE4 }, 25);
            TalentE4 = new DedicationTalent(new List<BaseEotETalent> { TalentD4, TalentE3 }, 25);

            TalentMatrix = new List<List<BaseEotETalent>> { new List<BaseEotETalent> { TalentA1, TalentA2, TalentA3, TalentA4 },
                                                            new List<BaseEotETalent> { TalentB1, TalentB2, TalentB3, TalentB4 },
                                                            new List<BaseEotETalent> { TalentC1, TalentC2, TalentC3, TalentC4 },
                                                            new List<BaseEotETalent> { TalentD1, TalentD2, TalentD3, TalentD4 },
                                                            new List<BaseEotETalent> { TalentE1, TalentE2, TalentE3, TalentE4 }
                                                          };
        }

    }
}