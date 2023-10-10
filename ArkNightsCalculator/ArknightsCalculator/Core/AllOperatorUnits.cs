using System.Collections.Generic;

namespace ArknightsCalculator.Core
{
    public class AllOperatorUnits
    {
        // All Operators graded at E2 M3 LVL90 and max trust (*not max potential), from gamepress.gg/arknights operator listings
        public List<OperatorUnit> AllOperators = new List<OperatorUnit>()
        {
            // -Supporter-
            // Artificer
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Stainless", ATK = 633,  INTERVAL = 1.5, ATKTYPE = AttackType.Physical, CLASS = "Supporter", ARCHETYPE = "Artificer" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"},
                new Skills() { name = "Extreme Firepower", base_attack_modifiers = new double[1] { 0.12 }, attack_multiplier_modifiers = new double[1] { 2 } },
                new Skills() { name = "Efficient Resupply", base_attack_modifiers = new double[1] { 0.6 } },
                new Skills() { name = "Feist's Metal Crab·Prototype", base_attack_modifiers = new double[1] { 0.55 }, attack_speed_modifiers = new double[1] { 55 } }
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Windflit", ATK = 605,  INTERVAL = 1.5, ATKTYPE = AttackType.Physical, CLASS = "Supporter", ARCHETYPE = "Artificer" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", base_attack_modifiers = new double[1] { 0.15 } },
                new Skills() { name = "This Body, To Build", base_attack_modifiers = new double[1] { 0.15 }, attack_multiplier_modifiers = new double[1] { 2.5 } },
                new Skills() { name = "This Body, To Power", base_attack_modifiers = new double[1] { 0.30 }, attack_multiplier_modifiers = new double[1] { 1.6 }, attack_interval_modifiers = new double[1] { 0.5 } },
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Roberta", ATK = 570,  INTERVAL = 1.5, ATKTYPE = AttackType.Physical, CLASS = "Supporter", ARCHETYPE = "Artificer" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive" },
                new Skills() { name = "Siracusan-Style Makeup", base_attack_modifiers = new double[1] { 0.1 } }
                // new Skills() { name = "Full Auto Modeler" } // Stops attacking
                }
            },

            // Summoner
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Magallan", ATK = 509,  INTERVAL = 1.6, ATKTYPE = AttackType.Arts, CLASS = "Supporter", ARCHETYPE = "Summoner" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"},
                new Skills() { name = "High-Efficiency Freezing Module" }, // Utility i.e. No-Damage
                new Skills() { name = "Laser Mining Module", attack_speed_modifiers = new double[1] { 150 }, extra_arts_damage_done = new double[1] { 509 } }, // Soaring Dragon L Summon 
                new Skills() { name = "Armed Combat Module", base_attack_modifiers = new double[1] { 1.5 }, extra_phys_damage_done = new double[1] { 753 } } // Soaring Dragon A Summon
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Ling", ATK = 508,  INTERVAL = 1.6, ATKTYPE = AttackType.Arts, CLASS = "Supporter", ARCHETYPE = "Summoner" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", base_attack_modifiers = new double[1] { 0.03 } }, // Average 1 summon defeated/absorbed/retrieved
                new Skills() { name = "Sips of Wine", base_attack_modifiers = new double[2] { 0.03, 0.5 }, attack_speed_modifiers = new double[1] { 50 }, extra_arts_damage_done = new double[1] { 549 } }, // Tranquility Summon
                new Skills() { name = "Amidst Pleasant Melodies", base_attack_modifiers = new double[2] { 0.03, 4.5 }, extra_arts_damage_done = new double[1] { 406 } }, // Peripateticism Summon
                new Skills() { name = "To Remain Oneself", base_attack_modifiers = new double[2] { 0.03, 1 }, attack_multiplier_modifiers = new double[1] { 0.4 }, extra_phys_damage_done = new double[1] { 1481 } }, // Thunderer Advanced Summon (*since we only really care about the big boi ;D)
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Meyer", ATK = 478,  INTERVAL = 1.6, ATKTYPE = AttackType.Arts, CLASS = "Supporter", ARCHETYPE = "Summoner" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"},
                new Skills() { name = "Bionic Device", extra_phys_damage_done = new double[1] { 444 } }, // Robotter Summon, Utility Skill
                new Skills() { name = "Detonate and Recycle", attack_multiplier_modifiers = new double[1] { 6 }} // Robotter Summon destroyed by Skill
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Scene", ATK = 432,  INTERVAL = 1.6, ATKTYPE = AttackType.Arts, CLASS = "Supporter", ARCHETYPE = "Summoner" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"},
                new Skills() { name = "Protective Camouflage", base_attack_modifiers = new double[1] { 0.6 }, extra_phys_damage_done = new double[1] { 477 } }, // Mobile Buggy Cam Summon
                new Skills() { name = "Panoramic Overload", base_attack_modifiers = new double[1] { 1.3 }, extra_phys_damage_done = new double[1] { 477 } } // Mobile Buggy Cam Summon
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Deepcolor", ATK = 403,  INTERVAL = 1.6, ATKTYPE = AttackType.Arts, CLASS = "Supporter", ARCHETYPE = "Summoner" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"},
                new Skills() { name = "Shadow Tentacle", base_attack_modifiers = new double[1] { 0.6 }, extra_phys_damage_done = new double[1] { 462 } }, // Tentacle Summon
                new Skills() { name = "Visual Trap", extra_phys_damage_done = new double[1] { 462 } } // Tentacle Summon, Utility Skill
                }
            },

            // Debuffer/Hexer
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Gnosis", ATK = 535,  INTERVAL = 1.6, ATKTYPE = AttackType.Arts, CLASS = "Supporter", ARCHETYPE = "Debuffer/Hexer" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", arts_taken_modifiers = new double[1] { 0.25 } },
                new Skills() { name = "High-Speed Cogitation", arts_taken_modifiers = new double[1] { 0.25 }, attack_multiplier_modifiers = new double[1] { 1.7 }, attack_speed_modifiers = new double[1] { 200 } },
                new Skills() { name = "Zero-Point Burst", arts_taken_modifiers = new double[1] { 0.25 }, attack_multiplier_modifiers = new double[1] { 2 } },
                new Skills() { name = "Hypothermia", arts_taken_modifiers = new double[1] { 0.25 }, attack_multiplier_modifiers = new double[1] { 6 }, attack_speed_modifiers = new double[1] { 130 } } // Assume frozen status for calculation
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Pramanix", ATK = 495,  INTERVAL = 1.6, ATKTYPE = AttackType.Arts, CLASS = "Supporter", ARCHETYPE = "Debuffer/Hexer" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", arts_taken_modifiers = new double[1] { 0.3 } },
                new Skills() { name = "Echolocation", arts_taken_modifiers = new double[1] { 0.3 } }, // Utility Skill
                new Skills() { name = "Natural Deterrent", arts_taken_modifiers = new double[1] { 0.3 }, scaling_def_modifiers = new double[1] { -0.6 }, scaling_res_modifiers = new double[1] { -0.3 } }
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Shamare", ATK = 473,  INTERVAL = 1.6, ATKTYPE = AttackType.Arts, CLASS = "Supporter", ARCHETYPE = "Debuffer/Hexer" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", arts_taken_modifiers = new double[1] { 0.3 } },
                new Skills() { name = "Malediction", arts_taken_modifiers = new double[1] { 0.54 }, base_attack_modifiers = new double[1] { 0.6 } },
                new Skills() { name = "Cursed Doll", arts_taken_modifiers = new double[1] { 0.3 }, scaling_def_modifiers = new double[1] { -0.5 } }
                }
            },

            // Aura/Bard
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Skadi the Corrupting Heart", ATK = 418,  INTERVAL = 1, ATKTYPE = AttackType.Healing, CLASS = "Supporter", ARCHETYPE = "Aura/Bard" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", base_attack_modifiers = new double[1] { 0.06 }, attack_multiplier_modifiers = new double[1] { -0.1 } }, // Nearby unit buff applicable to self & Bard heal trait
                new Skills() { name = "Chant of Returning by Varied Paths", base_attack_modifiers = new double[1] { 0.06 }, attack_multiplier_modifiers = new double[1] { -0.8 } },
                new Skills() { name = "Wish of Burial Beyond the Light", base_attack_modifiers = new double[1] { 0.06 }, attack_multiplier_modifiers = new double[1] { -0.2 } }, // Utility Skill
                new Skills() { name = "The Tide Surges, The Tide Recedes", base_attack_modifiers = new double[1] { 0.06 }, attack_multiplier_modifiers = new double[1] { -0.1 }, extra_true_damage_done = new double[1] { 310.156 } } // 70% ATK per second
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Sora", ATK = 385,  INTERVAL = 1, ATKTYPE = AttackType.Healing, CLASS = "Supporter", ARCHETYPE = "Aura/Bard" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", attack_multiplier_modifiers = new double[1] { -0.1 } },
                new Skills() { name = "Hymn of Respite" }, // removes trait debuff
                new Skills() { name = "Hymn of Battle", attack_multiplier_modifiers = new double[1] { -0.1 } } // Atk buff
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Heidi", ATK = 360,  INTERVAL = 1, ATKTYPE = AttackType.Healing, CLASS = "Supporter", ARCHETYPE = "Aura/Bard" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", attack_multiplier_modifiers = new double[1] { -0.1 } },
                new Skills() { name = "Tale of Fiction: A Warrior's Anger", attack_multiplier_modifiers = new double[1] { -0.1 } }, // Atk buff
                new Skills() { name = "Tale of Fiction: Rust", attack_multiplier_modifiers = new double[1] { -0.3 } } // Slightly buffed healing
                }
            },

            // Slower/Decel Binder
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Angelina", ATK = 617,  INTERVAL = 1.9, ATKTYPE = AttackType.Arts, CLASS = "Supporter", ARCHETYPE = "Slower/Decel Binder" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", attack_speed_modifiers = new double[1] { 7 } },
                new Skills() { name = "Arcane Staff - Quick Charge Mode", attack_speed_modifiers = new double[1] { 7 }, base_attack_modifiers = new double[1] { 1.1 } },
                new Skills() { name = "Arcane Staff - Particle Mode", attack_speed_modifiers = new double[1] { 7 }, attack_interval_modifiers = new double[1] { 0.15 }, attack_multiplier_modifiers = new double[1] { -0.45 } },
                new Skills() { name = "Arcane Staff - Anti-Gravity Mode", attack_speed_modifiers = new double[1] { 7 }, base_attack_modifiers = new double[1] { 1.5 } }
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Suzuran", ATK = 596,  INTERVAL = 1.9, ATKTYPE = AttackType.Arts, CLASS = "Supporter", ARCHETYPE = "Slower/Decel Binder" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", arts_taken_modifiers = new double[1] { 0.2 } },
                new Skills() { name = "I'll Do My Best", arts_taken_modifiers = new double[1] { 0.2 }, base_attack_modifiers = new double[1] { 0.8 }, attack_speed_modifiers = new double[1] { 30 } },
                new Skills() { name = "Childhood Frolic", arts_taken_modifiers = new double[1] { 0.2 }, base_attack_modifiers = new double[1] { 0.6 } }, // Can hit more enemies
                new Skills() { name = "Foxfire Haze", arts_taken_modifiers = new double[1] { 0.4 } } // Utility Skill, heals for 20% of ATK
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Istina", ATK = 583,  INTERVAL = 1.9, ATKTYPE = AttackType.Arts, CLASS = "Supporter", ARCHETYPE = "Slower/Decel Binder" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", attack_speed_modifiers = new double[1] { 18 } },
                new Skills() { name = "Concentration", attack_speed_modifiers = new double[1] { 18 }, attack_interval_modifiers = new double[1] { -1.1 } },
                new Skills() { name = "Literature Storm", attack_speed_modifiers = new double[1] { 18 }, base_attack_modifiers = new double[1] { 0.75 } } // Attack more targets
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Proviso", ATK = 578,  INTERVAL = 1.9, ATKTYPE = AttackType.Arts, CLASS = "Supporter", ARCHETYPE = "Slower/Decel Binder" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", attack_speed_modifiers = new double[1] { 10 } },
                new Skills() { name = "Dispute Litigation", attack_speed_modifiers = new double[1] { 10 }, attack_multiplier_modifiers = new double[1] { 3 } },
                new Skills() { name = "Prevailing Argument", attack_speed_modifiers = new double[1] { 10 }, attack_multiplier_modifiers = new double[1] { 3.5 } }
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Podenco", ATK = 542,  INTERVAL = 1.9, ATKTYPE = AttackType.Arts, CLASS = "Supporter", ARCHETYPE = "Slower/Decel Binder" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", base_attack_modifiers = new double[1] { 0.09 } },
                new Skills() { name = "Aromatherapy", base_attack_modifiers = new double[2] { 0.09, 0.6 } }, // heals instead of attacking
                new Skills() { name = "Spread Spores", base_attack_modifiers = new double[1] { 0.09 }, extra_arts_damage_done = new double[1] { 433.6 } } // Dps cloud
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Glaucus", ATK = 540,  INTERVAL = 1.9, ATKTYPE = AttackType.Arts, CLASS = "Supporter", ARCHETYPE = "Slower/Decel Binder" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"}, // Huge Damage Boost vs Drones
                new Skills() { name = "Binary Reload", base_attack_modifiers = new double[1] { 0.5 } },
                new Skills() { name = "Counter EMP", base_attack_modifiers = new double[1] { 4 }}
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Earthspirit", ATK = 530,  INTERVAL = 1.9, ATKTYPE = AttackType.Arts, CLASS = "Supporter", ARCHETYPE = "Slower/Decel Binder" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"},
                new Skills() { name = "ATK Up β", base_attack_modifiers = new double[1] { 0.8 } },
                // new Skills() { name = "Quicksand Conversion", } // Utility Skill, Stops attacking
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Orchid", ATK = 418,  INTERVAL = 1.9, ATKTYPE = AttackType.Arts, CLASS = "Supporter", ARCHETYPE = "Slower/Decel Binder" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", attack_speed_modifiers = new double[1] { 9 } },
                new Skills() { name = "Swift Strike α", attack_speed_modifiers = new double[2] { 9, 25 }, base_attack_modifiers = new double[1] { 0.25 } }
                }
            },

            // Buffer/Abjurer
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Tsukinogi", ATK = 485,  INTERVAL = 1.6, ATKTYPE = AttackType.Healing, CLASS = "Supporter", ARCHETYPE = "Buffer/Abjurer" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"}, // Heals when using skill
                new Skills() { name = "Without a Trace", attack_multiplier_modifiers = new double[1] { -0.25 } }, // Utility Skill
                new Skills() { name = "Forest's Embrace", attack_multiplier_modifiers = new double[1] { -0.78 } } // Utility Skill
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Nine-Colored Deer", ATK = 478,  INTERVAL = 1.6, ATKTYPE = AttackType.Healing, CLASS = "Supporter", ARCHETYPE = "Buffer/Abjurer" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"}, // Heals when using skill
                new Skills() { name = "Fortune Bringer of the Mortal Realm", attack_multiplier_modifiers = new double[1] { -0.25 }, base_attack_modifiers = new double[1] { 0.6 } },
                new Skills() { name = "Return to the Immortal Mountain", attack_multiplier_modifiers = new double[1] { -0.25 }, attack_speed_modifiers = new double[1] { 50 } }
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Quercus", ATK = 463,  INTERVAL = 1.6, ATKTYPE = AttackType.Healing, CLASS = "Supporter", ARCHETYPE = "Buffer/Abjurer" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"}, // Heals when using skill
                new Skills() { name = "Earth's Benevolence", attack_multiplier_modifiers = new double[1] { -0.25 }, base_attack_modifiers = new double[1] { 0.4 } },
                new Skills() { name = "Echo of Life", attack_multiplier_modifiers = new double[1] { -0.25 }, attack_speed_modifiers = new double[1] { 60 } }
                }
            },

            // -Guard-
            // Liberator
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Młynar", ATK = 385,  INTERVAL = 1.2, ATKTYPE = AttackType.Physical, CLASS = "Guard", ARCHETYPE = "Liberator" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", base_attack_modifiers = new double[1] { 1.1 }},
                new Skills() { name = "Unsounded Fury", base_attack_modifiers = new double[1] { 1.1 }, attack_multiplier_modifiers = new double[1] { 2 } },
                new Skills() { name = "Unresolved Sorrow", base_attack_modifiers = new double[1] { 1.1 }, attack_multiplier_modifiers = new double[1] { 1.9 }, attack_speed_modifiers = new double[1] { 200 }, attack_interval_modifiers = new double[1] { 0.3 } },
                new Skills() { name = "Unilluminated Glory", base_attack_modifiers = new double[1] { 1.1 }, attack_multiplier_modifiers = new double[1] { 1.8 }, extra_true_damage_done = new double[1] { 50.82 } } // rediculous skill, calculating bare minimum here
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Tequila", ATK = 352,  INTERVAL = 1.2, ATKTYPE = AttackType.Physical, CLASS = "Guard", ARCHETYPE = "Liberator" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive" },
                new Skills() { name = "Decisive Action", attack_speed_modifiers = new double[1] { 50 }, attack_multiplier_modifiers = new double[1] { 1.7 } },
                new Skills() { name = "Esoteric Bladework", attack_multiplier_modifiers = new double[1] { 2.3 } }
                }
            },

            // AoE/Centurion
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Broca", ATK = 842,  INTERVAL = 1.2, ATKTYPE = AttackType.Arts, CLASS = "Guard", ARCHETYPE = "AoE/Centurion" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"}, // Normal damage may be incorrect, switched damage type for calculation convience
                new Skills() { name = "Galvanize", base_attack_modifiers = new double[1] { 0.8 } },
                new Skills() { name = "High-Voltage Current", base_attack_modifiers = new double[1] { 1.9 }, attack_interval_modifiers = new double[1] { 1.65 } }
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Blaze", ATK = 825,  INTERVAL = 1.2, ATKTYPE = AttackType.Physical, CLASS = "Guard", ARCHETYPE = "AoE/Centurion" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"},
                new Skills() { name = "Power Strike γ", attack_multiplier_modifiers = new double[1] { 2.9 } },
                new Skills() { name = "Chainsaw Extension Module", base_attack_modifiers = new double[1] { 1 } },
                new Skills() { name = "Boiling Burst", base_attack_modifiers = new double[1] { 0.8 }, extra_phys_damage_done = new double[1] { 3300 } } // 400% ATK on skill end
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Gavial the Invincible", ATK = 816,  INTERVAL = 1.2, ATKTYPE = AttackType.Physical, CLASS = "Guard", ARCHETYPE = "AoE/Centurion" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", base_attack_modifiers = new double[1] { 0.1 } },
                new Skills() { name = "Precision Strikes", base_attack_modifiers = new double[2] { 0.1, 0.8 } },
                new Skills() { name = "Chainsaw Assault", base_attack_modifiers = new double[2] { 0.1, 1.8 } },
                new Skills() { name = "Jungle Spirit", base_attack_modifiers = new double[2] { 0.1, 1.4 }, attack_speed_modifiers = new double[1] { 100 } }
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Specter", ATK = 805,  INTERVAL = 1.2, ATKTYPE = AttackType.Physical, CLASS = "Guard", ARCHETYPE = "AoE/Centurion" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive" },
                new Skills() { name = "ATK Up γ", base_attack_modifiers = new double[1] { 1 } },
                new Skills() { name = "Bone Fracture", base_attack_modifiers = new double[1] { 1.6 } }
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Savage", ATK = 705,  INTERVAL = 1.2, ATKTYPE = AttackType.Physical, CLASS = "Guard", ARCHETYPE = "AoE/Centurion" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", base_attack_modifiers = new double[1] { 0.1 } },
                new Skills() { name = "Power Strike β", base_attack_modifiers = new double[1] { 0.1 }, attack_multiplier_modifiers = new double[1] { 2.3 } },
                new Skills() { name = "Precise Blast", base_attack_modifiers = new double[1] { 0.1 }, attack_multiplier_modifiers = new double[1] { 4 } }
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Estelle", ATK = 690,  INTERVAL = 1.2, ATKTYPE = AttackType.Physical, CLASS = "Guard", ARCHETYPE = "AoE/Centurion" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"},
                new Skills() { name = "ATK Up β", base_attack_modifiers = new double[1] { 0.8 } },
                new Skills() { name = "Sacrificial Strike", base_attack_modifiers = new double[1] { 1.5 } }
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Popukar", ATK = 545,  INTERVAL = 1.2, ATKTYPE = AttackType.Physical, CLASS = "Guard", ARCHETYPE = "AoE/Centurion" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", base_attack_modifiers = new double[1] { 0.08 } },
                new Skills() { name = "ATK Up α", base_attack_modifiers = new double[2] { 0.08, 0.5 } }
                }
            },

            // Dualstrike/Swordmaster
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Irene", ATK = 701,  INTERVAL = 1.3, ATKTYPE = AttackType.Physical, CLASS = "Guard", ARCHETYPE = "Dualstrike/Swordmaster" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", scaling_def_modifiers = new double[1] { -0.5 }, attack_speed_modifiers = new double[2] { 18, 200 } },
                new Skills() { name = "Rising Wind", scaling_def_modifiers = new double[1] { -0.5 }, attack_speed_modifiers = new double[1] { 18 }, attack_multiplier_modifiers = new double[1] { 2 }, extra_phys_damage_done = new double[1] { 701 } }, // does 200% phys after hit
                new Skills() { name = "Tiderender", scaling_def_modifiers = new double[1] { -0.5 }, attack_speed_modifiers = new double[1] { 18 }, attack_multiplier_modifiers = new double[1] { 4 } },
                new Skills() { name = "Judgment", scaling_def_modifiers = new double[1] { -0.5 }, attack_speed_modifiers = new double[1] { 18 }, attack_multiplier_modifiers = new double[1] { 3 }, extra_phys_damage_done = new double[1] { 701 } } // does %250 phys, 12 times! FML, I give up trying to calculate this
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Bibeak", ATK = 682,  INTERVAL = 1.3, ATKTYPE = AttackType.Physical, CLASS = "Guard", ARCHETYPE = "Dualstrike/Swordmaster" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", attack_speed_modifiers = new double[2] { 30, 200 } },
                new Skills() { name = "Plumage Pins", attack_speed_modifiers = new double[1] { 30 }, attack_multiplier_modifiers = new double[1] { 1.8 }, extra_phys_damage_done = new double[1] { 682 } }, // does 180% phys after hit
                new Skills() { name = "Blade Swap", attack_speed_modifiers = new double[1] { 30 }, attack_multiplier_modifiers = new double[1] { 2 },  extra_arts_damage_done = new double[1] { 682 } } // does 200% arts
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Tachanka", ATK = 661,  INTERVAL = 1.3, ATKTYPE = AttackType.Physical, CLASS = "Guard", ARCHETYPE = "Dualstrike/Swordmaster" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", attack_speed_modifiers = new double[1] { 200 } }, // Lord Tachanka, praise be the dakka!
                new Skills() { name = "Incendiary Grenade", flat_def_modierifers = new double[1] { -200 }, extra_arts_damage_done = new double[1] { 462.7 } }, // 70% arts
                new Skills() { name = "Spray and Pray", attack_interval_modifiers = new double[1] { -0.85 }, attack_multiplier_modifiers = new double[1] { 2 } }
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Ch'en", ATK = 660,  INTERVAL = 1.3, ATKTYPE = AttackType.Physical, CLASS = "Guard", ARCHETYPE = "Dualstrike/Swordmaster" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", base_attack_modifiers = new double[1] { 0.05 }, attack_speed_modifiers = new double[1] { 200 } },
                new Skills() { name = "Sheathed Strike", base_attack_modifiers = new double[1] { 0.05 }, attack_multiplier_modifiers = new double[1] { 3.2 } },
                new Skills() { name = "Chi Xiao - Unsheath", base_attack_modifiers = new double[1] { 0.05 }, attack_multiplier_modifiers = new double[1] { 5 }, extra_arts_damage_done = new double[1] { 660 } },
                new Skills() { name = "Chi Xiao - Shadowless", base_attack_modifiers = new double[1] { 0.05 }, attack_speed_modifiers = new double[1] { 1000 }, attack_multiplier_modifiers = new double[1] { 3.2 } } // 10 strikes
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Cutter", ATK = 641,  INTERVAL = 1.3, ATKTYPE = AttackType.Physical, CLASS = "Guard", ARCHETYPE = "Dualstrike/Swordmaster" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", attack_speed_modifiers = new double[1] { 200 } },
                new Skills() { name = "Redshift", attack_multiplier_modifiers = new double[1] { 3.4 }, attack_speed_modifiers = new double[1] { 400 } }, // attacks 4 times
                new Skills() { name = "Crimson Crescent", attack_multiplier_modifiers = new double[1] { 4.5 }, attack_speed_modifiers = new double[1] { 600 } } // attacks 6 times
                }
            },

            // Duelist/Dreadnought
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Nearl the Radiant Knight", ATK = 1149,  INTERVAL = 1.5, ATKTYPE = AttackType.Physical, CLASS = "Guard", ARCHETYPE = "Duelist/Dreadnought" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", scaling_def_modifiers = new double[1] { -0.2 }, extra_true_damage_done = new double[1] { 919.2 } }, // 80% true damage on deployment
                new Skills() { name = "Flaming Edge", scaling_def_modifiers = new double[1] { -0.2 }, base_attack_modifiers = new double[1] { 0.7 }, attack_speed_modifiers = new double[1] { 50 } },
                new Skills() { name = "Night-Scouring Gleam", scaling_def_modifiers = new double[1] { -0.2 }, base_attack_modifiers = new double[1] { 1.6 } },
                new Skills() { name = "Blazing Sun's Obeisance", scaling_def_modifiers = new double[1] { -0.2 }, base_attack_modifiers = new double[1] { 1.4 }, extra_true_damage_done = new double[1] { 1263.9 } } // 110% true damage from sun, rediculous skill
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Skadi", ATK = 1095,  INTERVAL = 1.5, ATKTYPE = AttackType.Physical, CLASS = "Guard", ARCHETYPE = "Duelist/Dreadnought" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", base_attack_modifiers = new double[1] { 0.14 } },
                new Skills() { name = "Swift Strike γ", base_attack_modifiers = new double[2] { 0.14, 0.45 }, attack_speed_modifiers = new double[1] { 45 } },
                new Skills() { name = "Wave Strike", base_attack_modifiers = new double[2] { 0.14, 1.7 } },
                new Skills() { name = "Tidal Elegy", base_attack_modifiers = new double[2] { 0.14, 1.3 } }
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Franka", ATK = 1011,  INTERVAL = 1.5, ATKTYPE = AttackType.Physical, CLASS = "Guard", ARCHETYPE = "Duelist/Dreadnought" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", scaling_def_modifiers = new double[1] { -1 } }, // chance to ignore DEF
                new Skills() { name = "Swift Strike γ", scaling_def_modifiers = new double[1] { -1 }, base_attack_modifiers = new double[1] { 0.45 }, attack_speed_modifiers = new double[1] { 45 } },
                new Skills() { name = "Vorpal Edge", scaling_def_modifiers = new double[1] { -1 }, base_attack_modifiers = new double[1] { 1 } }
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Flamebringer", ATK = 963,  INTERVAL = 1.5, ATKTYPE = AttackType.Physical, CLASS = "Guard", ARCHETYPE = "Duelist/Dreadnought" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"},
                new Skills() { name = "Blood Pact", attack_multiplier_modifiers = new double[1] { 2.2 } },
                new Skills() { name = "Blade Demon", base_attack_modifiers = new double[1] { 0.7 }, attack_speed_modifiers = new double[1] { 45 } }
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Sharp", ATK = 957,  INTERVAL = 1.5, ATKTYPE = AttackType.Physical, CLASS = "Guard", ARCHETYPE = "Duelist/Dreadnought" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", base_attack_modifiers = new double[1] { 0.15 } },
                new Skills() { name = "Drawing Sword", base_attack_modifiers = new double[1] { 0.15 }, attack_multiplier_modifiers = new double[1] { 1.7 } }
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Conviction", ATK = 951,  INTERVAL = 1.5, ATKTYPE = AttackType.Physical, CLASS = "Guard", ARCHETYPE = "Duelist/Dreadnought" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"},
                new Skills() { name = "Judgment", attack_multiplier_modifiers = new double[1] { 2 } },
                new Skills() { name = "Genesis", attack_multiplier_modifiers = new double[1] { 3.5 } } // 50% coin flip skill, MEME's NOT WORTH IT
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Matoimaru", ATK = 916,  INTERVAL = 1.5, ATKTYPE = AttackType.Physical, CLASS = "Guard", ARCHETYPE = "Duelist/Dreadnought" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"},
                new Skills() { name = "Regeneration β" }, // Utility Skill, heals
                new Skills() { name = "Demonic Power", base_attack_modifiers = new double[1] { 1.5 } }
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Melantha", ATK = 803,  INTERVAL = 1.5, ATKTYPE = AttackType.Physical, CLASS = "Guard", ARCHETYPE = "Duelist/Dreadnought" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", base_attack_modifiers = new double[1] { 0.08 } },
                new Skills() { name = "ATK Up α", base_attack_modifiers = new double[2] { 0.08, 0.5 } }
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Castle-3", ATK = 413,  INTERVAL = 1.5, ATKTYPE = AttackType.Physical, CLASS = "Guard", ARCHETYPE = "Duelist/Dreadnought" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"}
                }
            },

            // Support/Instructor
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Pallas", ATK = 737,  INTERVAL = 1.05, ATKTYPE = AttackType.Physical, CLASS = "Guard", ARCHETYPE = "Support/Instructor" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", base_attack_modifiers = new double[2] { 1.2, 0.15 } }, // must be above 80% HP
                new Skills() { name = "Strikes of Victory", base_attack_modifiers = new double[2] { 1.2, 0.15 }, attack_multiplier_modifiers = new double[1] { 1.75 }, attack_interval_modifiers = new double[1] { 200 } },
                new Skills() { name = "Whip of Conviction", base_attack_modifiers = new double[3] { 1.2, 0.15, 0.8 } },
                new Skills() { name = "Blessing of Heroism", base_attack_modifiers = new double[3] { 1.2, 0.15, 1 } } // Utility Skill
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Swire", ATK = 696,  INTERVAL = 1.05, ATKTYPE = AttackType.Physical, CLASS = "Guard", ARCHETYPE = "Support/Instructor" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", base_attack_modifiers = new double[1] { 1.2 } },
                new Skills() { name = "Command and Dispatch", base_attack_modifiers = new double[1] { 1.2 } }, // buffs talent
                new Skills() { name = "Cooperative Combat", base_attack_modifiers = new double[2] { 1.2, 0.8 }}
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Whislash", ATK = 675,  INTERVAL = 1.05, ATKTYPE = AttackType.Physical, CLASS = "Guard", ARCHETYPE = "Support/Instructor" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", base_attack_modifiers = new double[1] { 1.2 } },
                new Skills() { name = "Motivational Skills", base_attack_modifiers = new double[1] { 1.2 } }, // buffs talent
                new Skills() { name = "Whip Sword", base_attack_modifiers = new double[2] { 1.2, 0.6 } }
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Dobermann", ATK = 632,  INTERVAL = 1.05, ATKTYPE = AttackType.Physical, CLASS = "Guard", ARCHETYPE = "Support/Instructor" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", base_attack_modifiers = new double[1] { 1.2 } },
                new Skills() { name = "Power Strike β", base_attack_modifiers = new double[1] { 1.2 }, attack_multiplier_modifiers = new double[1] { 2.3 } },
                new Skills() { name = "Spur", base_attack_modifiers = new double[2] { 1.2, 0.8 } } // buffs talent
                }
            },

            // Brawler/Fighter
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Mountain", ATK = 632,  INTERVAL = 0.78, ATKTYPE = AttackType.Physical, CLASS = "Guard", ARCHETYPE = "Brawler/Fighter" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", attack_multiplier_modifiers = new double[1] { 1.6 } },
                new Skills() { name = "Left Hook", attack_multiplier_modifiers = new double[2] { 1.6, 2.3 } },
                new Skills() { name = "Sweeping Stance", attack_multiplier_modifiers = new double[1] { 1.6 }, base_attack_modifiers = new double[1] { 0.8 } },
                new Skills() { name = "Earth-Shattering Smash", attack_interval_modifiers = new double[1] { 0.7 }, attack_multiplier_modifiers = new double[1] { 1.6 }, base_attack_modifiers = new double[1] { 1 }, attack_speed_modifiers = new double[1] { 200 } }
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Flint", ATK = 620,  INTERVAL = 0.78, ATKTYPE = AttackType.Physical, CLASS = "Guard", ARCHETYPE = "Brawler/Fighter" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", attack_multiplier_modifiers = new double[1] { 1.4 } },
                new Skills() { name = "Relentless", attack_multiplier_modifiers = new double[2] { 1.4, 2.3 } },
                new Skills() { name = "Display of Might", attack_multiplier_modifiers = new double[1] { 1.4 }, base_attack_modifiers = new double[1] { 0.55 }, attack_speed_modifiers = new double[1] { 55 } }
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Dagda", ATK = 614,  INTERVAL = 0.78, ATKTYPE = AttackType.Physical, CLASS = "Guard", ARCHETYPE = "Brawler/Fighter" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", attack_multiplier_modifiers = new double[1] { 1.5 } },
                new Skills() { name = "Counter Technique", attack_multiplier_modifiers = new double[2] { 1.5, 2.1 } },
                new Skills() { name = "Precise Hunting", attack_multiplier_modifiers = new double[1] { 1.5 }, base_attack_modifiers = new double[1] { 0.35 }, attack_speed_modifiers = new double[1] { 200 } }
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Indra", ATK = 605,  INTERVAL = 0.78, ATKTYPE = AttackType.Physical, CLASS = "Guard", ARCHETYPE = "Brawler/Fighter" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", base_attack_modifiers = new double[1] { 1 } },
                new Skills() { name = "Armorcrusher", base_attack_modifiers = new double[2] { 1, 1.4 }, scaling_def_modifiers = new double[1] { -0.6 } },
                new Skills() { name = "Sundered Soul", base_attack_modifiers = new double[2] { 1, 1.2 } } // Deals arts and heals
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Jackie", ATK = 589,  INTERVAL = 0.78, ATKTYPE = AttackType.Physical, CLASS = "Guard", ARCHETYPE = "Brawler/Fighter" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", attack_speed_modifiers = new double[1] { 12 } },
                new Skills() { name = "Grit Those Teeth!", attack_speed_modifiers = new double[1] { 12 }, attack_multiplier_modifiers = new double[1] { 2.5 } },
                new Skills() { name = "Pay Close Attention!", attack_speed_modifiers = new double[1] { 12 }, attack_multiplier_modifiers = new double[1] { 1.6 }, attack_interval_modifiers = new double[1] { 0.5 } }
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Beehunter", ATK = 573,  INTERVAL = 0.78, ATKTYPE = AttackType.Physical, CLASS = "Guard", ARCHETYPE = "Brawler/Fighter" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", attack_multiplier_modifiers = new double[1] { 0.3 } },
                new Skills() { name = "Flexibility", attack_multiplier_modifiers = new double[1] { 0.3 } }, // Grants dodge
                new Skills() { name = "Soaring Fists", attack_multiplier_modifiers = new double[1] { 0.3 }, attack_interval_modifiers = new double[1] { -0.6 } }
                }
            },

            // Arts Fighter
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Surtr", ATK = 772,  INTERVAL = 1.25, ATKTYPE = AttackType.Arts, CLASS = "Guard", ARCHETYPE = "Arts Fighter" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", flat_res_modierifers = new double[1] { -20 } },
                new Skills() { name = "Laevatain", flat_res_modierifers = new double[1] { -20 }, attack_multiplier_modifiers = new double[1] { 3.1 } },
                new Skills() { name = "Molten Giant", flat_res_modierifers = new double[1] { -20 }, base_attack_modifiers = new double[1] { 1.2 }, attack_multiplier_modifiers = new double[1] { 1.6 } },
                new Skills() { name = "Twilight", flat_res_modierifers = new double[1] { -20 }, base_attack_modifiers = new double[1] { 3.3 } } // Busted Skill
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Amiya (Guard)", ATK = 702,  INTERVAL = 1.25, ATKTYPE = AttackType.Arts, CLASS = "Guard", ARCHETYPE = "Arts Fighter" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", base_attack_modifiers = new double[1] { 0.07 } },
                new Skills() { name = "Ying Xiao - Fleeting Night", base_attack_modifiers = new double[2] { 0.14, 0.8 }, attack_speed_modifiers = new double[1] { 200 } },
                new Skills() { name = "Ying Xiao - Shadowless", base_attack_modifiers = new double[2] { 0.14, 0.4 }, attack_multiplier_modifiers = new double[1] { 2.2 }, attack_speed_modifiers = new double[1] { 900 }, extra_true_damage_done = new double[1] { 804 } } // Deals true damage on last or after 3 kills, too hard to calculate
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Astesia", ATK = 690,  INTERVAL = 1.25, ATKTYPE = AttackType.Arts, CLASS = "Guard", ARCHETYPE = "Arts Fighter" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", attack_speed_modifiers = new double[1] { 25 } }, // Stay on field to attack faster
                new Skills() { name = "Astral Protection", attack_speed_modifiers = new double[1] { 25 }, base_attack_modifiers = new double[1] { 0.5 } },
                new Skills() { name = "Astral Sword", attack_speed_modifiers = new double[1] { 25 }, base_attack_modifiers = new double[1] { 0.8 } }
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Mousse", ATK = 679,  INTERVAL = 1.25, ATKTYPE = AttackType.Arts, CLASS = "Guard", ARCHETYPE = "Arts Fighter" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", attack_speed_modifiers = new double[1] { 200 } },
                new Skills() { name = "Scratch", attack_speed_modifiers = new double[1] { 200 }, base_attack_modifiers = new double[1] { 0.75 }, scaling_def_modifiers = new double[1] { -0.4 } },
                new Skills() { name = "Fury", attack_speed_modifiers = new double[1] { 200 }, base_attack_modifiers = new double[1] { 0.75 } }
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Sideroca", ATK = 620,  INTERVAL = 1.25, ATKTYPE = AttackType.Arts, CLASS = "Guard", ARCHETYPE = "Arts Fighter" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", attack_speed_modifiers = new double[1] { 15 } }, // must defeat 7 enemies first for minor buff
                new Skills() { name = "Regeneration γ" }, // heals
                new Skills() { name = "Restorative Surge", base_attack_modifiers = new double[1] { 1.1 } }
                }
            },

            // Ranged/Lord
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "SilverAsh", ATK = 763,  INTERVAL = 1.3, ATKTYPE = AttackType.Physical, CLASS = "Guard", ARCHETYPE = "Ranged/Lord" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", base_attack_modifiers = new double[1] { 0.1 } },
                new Skills() { name = "Power Strike γ", base_attack_modifiers = new double[1] { 0.1 }, attack_multiplier_modifiers = new double[1] { 2.9 } },
                new Skills() { name = "Rules of Survival", base_attack_modifiers = new double[1] { 0.1 } }, // Defensive Skill
                new Skills() { name = "Truesilver Slash", base_attack_modifiers = new double[2] { 0.1, 2 } } // Busted Skill
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Lappland", ATK = 760,  INTERVAL = 1.3, ATKTYPE = AttackType.Physical, CLASS = "Guard", ARCHETYPE = "Ranged/Lord" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"},
                new Skills() { name = "Sundial", base_attack_modifiers =  new double[1] { 0.7 } },
                new Skills() { name = "Wolf Spirit", base_attack_modifiers =  new double[1] { 1.2 }, extra_arts_damage_done = new double[1] { 760 } } // Added as damage type changed to arts
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Ayerscarpe", ATK = 745,  INTERVAL = 1.3, ATKTYPE = AttackType.Physical, CLASS = "Guard", ARCHETYPE = "Ranged/Lord" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", attack_speed_modifiers = new double[1] { 8 } },
                new Skills() { name = "Shrapnel Burst", attack_speed_modifiers = new double[1] { 8 },  attack_multiplier_modifiers = new double[1] { 1.6 } },
                new Skills() { name = "Activate Phase Blades", attack_speed_modifiers = new double[1] { 8 }, attack_multiplier_modifiers = new double[1] { 1.7 }, extra_arts_damage_done = new double[1] { 745 } } // Added as damage type changed to arts
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Thorns", ATK = 741,  INTERVAL = 1.3, ATKTYPE = AttackType.Physical, CLASS = "Guard", ARCHETYPE = "Ranged/Lord" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", extra_arts_damage_done = new double[1] { 125 } },
                new Skills() { name = "ATK Up γ",  extra_arts_damage_done = new double[1] { 125 }, base_attack_modifiers = new double[1] { 1 } },
                new Skills() { name = "Protective Spikes", extra_arts_damage_done = new double[1] { 125 }, base_attack_modifiers = new double[1] { 0.6 } }, // Defensive skill
                new Skills() { name = "Destreza",  extra_arts_damage_done = new double[1] { 125 }, base_attack_modifiers = new double[1] { 0.6 }, attack_speed_modifiers = new double[1] { 25 } } // Busted Skill
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Luo Xiaohei", ATK = 728,  INTERVAL = 1.3, ATKTYPE = AttackType.Physical, CLASS = "Guard", ARCHETYPE = "Ranged/Lord" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"},
                new Skills() { name = "Shadow of a Tail", attack_speed_modifiers = new double[1] { 40 } },
                new Skills() { name = "Blade of Shattered Metal", base_attack_modifiers = new double[1] { 0.7 }, flat_def_modierifers = new double[1] { -200 } }
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Arene", ATK = 695,  INTERVAL = 1.3, ATKTYPE = AttackType.Physical, CLASS = "Guard", ARCHETYPE = "Ranged/Lord" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"}, // Drone killer passive
                new Skills() { name = "Just Kidding", attack_multiplier_modifiers = new double[1] { 1.5 }, attack_speed_modifiers = new double[1] { 200 } },
                new Skills() { name = "Deadly Prank", attack_multiplier_modifiers = new double[1] { 1.6 }, extra_arts_damage_done = new double[1] { 695 } }
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Frostleaf", ATK = 660,  INTERVAL = 1.3, ATKTYPE = AttackType.Physical, CLASS = "Guard", ARCHETYPE = "Ranged/Lord" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", attack_interval_modifiers = new double[1] { 0.15 } }, // More range but slower
                new Skills() { name = "Frost Tomahawk", attack_interval_modifiers = new double[1] { 0.15 }, attack_multiplier_modifiers = new double[1] { 1.5 } },
                new Skills() { name = "Ice Tomahawk", attack_interval_modifiers = new double[1] { 0.15 }, attack_speed_modifiers = new double[1] { 50 } } // Utility Skill
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Midnight", ATK = 547,  INTERVAL = 1.3, ATKTYPE = AttackType.Physical, CLASS = "Guard", ARCHETYPE = "Ranged/Lord" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", attack_multiplier_modifiers = new double[1] { 1.6 } },
                new Skills() { name = "Enchant Weapon α", attack_multiplier_modifiers = new double[1] { 1.6 }, base_attack_modifiers = new double[1] { 0.35 }, extra_arts_damage_done = new double[1] { 547 } }
                }
            },

            // Enmity/Musha
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Hellagur", ATK = 832,  INTERVAL = 1.2, ATKTYPE = AttackType.Physical, CLASS = "Guard", ARCHETYPE = "Enmity/Musha" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", attack_speed_modifiers = new double[1] { 100 } }, // speed when below 30% HP
                new Skills() { name = "Crescent Moon", attack_speed_modifiers = new double[2] { 100, 200 }, attack_multiplier_modifiers = new double[1] { 1.75 } },
                new Skills() { name = "Half Moon", attack_speed_modifiers = new double[1] { 100 }, base_attack_modifiers = new double[1] { 0.8 } },
                new Skills() { name = "Full Moon", attack_speed_modifiers = new double[1] { 100 }, base_attack_modifiers = new double[1] { 1 }  }
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Akafuyu", ATK = 758,  INTERVAL = 1.2, ATKTYPE = AttackType.Physical, CLASS = "Guard", ARCHETYPE = "Enmity/Musha" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", attack_speed_modifiers = new double[1] { 100 } },
                new Skills() { name = "Nobukage-ryu - Kaminari Gatana no Zei", attack_speed_modifiers = new double[2] { 100, 200 }, base_attack_modifiers = new double[1] { 0.8 } },
                new Skills() { name = "Nobukage-ryu - Juumonji Masaru", attack_speed_modifiers = new double[1] { 100 }, base_attack_modifiers = new double[1] { 1 } }
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Utage", ATK = 723,  INTERVAL = 1.2, ATKTYPE = AttackType.Physical, CLASS = "Guard", ARCHETYPE = "Enmity/Musha" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", attack_speed_modifiers = new double[1] { 100 } },
                // new Skills() { name = "Space Out", attack_speed_modifiers = new double[1] { 100 } }, // Stops attacking
                new Skills() { name = "Descending Strike - Earth Splitter", attack_speed_modifiers = new double[1] { 100 }, base_attack_modifiers = new double[1] { 1.1 }, extra_arts_damage_done = new double[1] { 723 } } // deals arts
                }
            },

            // Reaper
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "La Pluma", ATK = 725,  INTERVAL = 1.3, ATKTYPE = AttackType.Physical, CLASS = "Guard", ARCHETYPE = "Reaper" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", attack_speed_modifiers = new double[1] { 36 } }, // after 12 kills
                new Skills() { name = "Rapid Slashing", attack_speed_modifiers = new double[2] { 36, 200 }, attack_multiplier_modifiers = new double[1] { 1.65 } },
                new Skills() { name = "Reap", attack_speed_modifiers = new double[1] { 36 }, attack_interval_modifiers = new double[1] { -0.5 }, base_attack_modifiers = new double[2] { 0.7, 0.5 } }
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Highmore", ATK = 710,  INTERVAL = 1.3, ATKTYPE = AttackType.Physical, CLASS = "Guard", ARCHETYPE = "Reaper" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"},
                new Skills() { name = "Look Back and Cast Aside", attack_speed_modifiers = new double[1] { 200 }, attack_multiplier_modifiers = new double[1] { 1.65 } },
                new Skills() { name = "Foaming into Oblivion", base_attack_modifiers = new double[1] { 0.6 } }
                }
            },

            // -Sniper- 
            // Close Range/Heavyshooter
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Pozyomka (Позёмка)", ATK = 946,  INTERVAL = 1.6, ATKTYPE = AttackType.Physical, CLASS = "Sniper", ARCHETYPE = "Close Range/Heavyshooter" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", scaling_def_modifiers = new double[1] { -0.23 }, extra_phys_damage_done = new double[1] { 866 } }, // Typewriter summon
                new Skills() { name = "Iamb", base_attack_modifiers = new double[1] { 0.6 }, attack_multiplier_modifiers = new double[1] { 2.25 }, scaling_def_modifiers = new double[1] { -0.23 }, extra_phys_damage_done = new double[1] { 866 } },
                new Skills() { name = "Synopsis", attack_multiplier_modifiers = new double[1] { 2.3 }, scaling_def_modifiers = new double[1] { -0.23 }, extra_phys_damage_done = new double[1] { 866 } },
                new Skills() { name = "Mighty Pen", attack_multiplier_modifiers = new double[1] { 2.55 }, attack_interval_modifiers = new double[1] { -0.6 } , scaling_def_modifiers = new double[1] { -0.23 }, extra_phys_damage_done = new double[1] { 866 } }
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Schwarz", ATK = 940,  INTERVAL = 1.6, ATKTYPE = AttackType.Physical, CLASS = "Sniper", ARCHETYPE = "Close Range/Heavyshooter" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", attack_multiplier_modifiers = new double[1] { 1.6 }, scaling_def_modifiers = new double[1] { -0.2 }, base_attack_modifiers = new double[1] { 0.08 } },
                new Skills() { name = "Charged Shot", attack_multiplier_modifiers = new double[2] { 1.6, 2.2 }, scaling_def_modifiers = new double[1] { -0.2 }, base_attack_modifiers = new double[1] { 0.08 } },
                new Skills() { name = "Sharp Eye", attack_multiplier_modifiers = new double[1] { 1.6 }, scaling_def_modifiers = new double[1] { -0.2 }, base_attack_modifiers = new double[2] { 0.08, 1.3 } },
                new Skills() { name = "Final Tactics", attack_multiplier_modifiers = new double[1] { 1.6 }, scaling_def_modifiers = new double[1] { -0.2 }, base_attack_modifiers = new double[2] { 0.08, 1.8 }, attack_interval_modifiers = new double[1] { 0.4 } }
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Provence", ATK = 871,  INTERVAL = 1.6, ATKTYPE = AttackType.Physical, CLASS = "Sniper", ARCHETYPE = "Close Range/Heavyshooter" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", attack_multiplier_modifiers = new double[1] { 1.8 } },
                new Skills() { name = "Wolf's Eye", attack_multiplier_modifiers = new double[1] { 1.8 }, base_attack_modifiers = new double[1] { 0.25 } },
                new Skills() { name = "Prey Seeker", attack_multiplier_modifiers = new double[1] { 1.8 }, base_attack_modifiers = new double[1] { 2.2 } }
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Aciddrop", ATK = 815,  INTERVAL = 1.6, ATKTYPE = AttackType.Physical, CLASS = "Sniper", ARCHETYPE = "Close Range/Heavyshooter" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"}, // can always deal at least 25% of Atk in damage, instead of 5% phys.. i.e. 203.75 (Good vs high DEF bosses?)
                new Skills() { name = "Fancy Shot", attack_speed_modifiers = new double[1] { 70 } },
                new Skills() { name = "Trigger Time", base_attack_modifiers = new double[1] { 0.4 }, attack_speed_modifiers = new double[1] { 200 } }
                }
            },

            // AoE/Artilleryman
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "W", ATK = 1012,  INTERVAL = 2.8, ATKTYPE = AttackType.Physical, CLASS = "Sniper", ARCHETYPE = "AoE/Artilleryman" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", attack_multiplier_modifiers = new double[1] { 1.18 } },
                new Skills() { name = "King of Hearts", attack_multiplier_modifiers = new double[2] { 1.18, 3.5 } },
                new Skills() { name = "Jack in the Box", attack_multiplier_modifiers = new double[2] { 1.18, 2.8 } },
                new Skills() { name = "D12", attack_multiplier_modifiers = new double[2] { 1.18, 3.1 } }
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Fiammetta", ATK = 961,  INTERVAL = 2.8, ATKTYPE = AttackType.Physical, CLASS = "Sniper", ARCHETYPE = "AoE/Artilleryman" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", attack_multiplier_modifiers = new double[1] { 0.25 }, attack_speed_modifiers = new double[1] { 27 } },
                new Skills() { name = "Provocate", base_attack_modifiers = new double[1] { 1 }, attack_multiplier_modifiers = new double[1] { 0.25 } },
                new Skills() { name = "Paenitete", attack_multiplier_modifiers = new double[3] { 0.25, 4, 2 } },
                new Skills() { name = "Reponite", attack_multiplier_modifiers = new double[2] { 0.25, 2.2 } }
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Meteorite", ATK = 950,  INTERVAL = 2.8, ATKTYPE = AttackType.Physical, CLASS = "Sniper", ARCHETYPE = "AoE/Artilleryman" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", attack_multiplier_modifiers = new double[1] { 0.6 } },
                new Skills() { name = "Buckshot", attack_multiplier_modifiers = new double[2] { 0.6, 2.15 } },
                new Skills() { name = "High-Explosive Shell", attack_multiplier_modifiers = new double[2] { 0.6, 3 }, flat_def_modierifers = new double[1] { -330 } }
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Sesa", ATK = 918,  INTERVAL = 2.8, ATKTYPE = AttackType.Physical, CLASS = "Sniper", ARCHETYPE = "AoE/Artilleryman" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", base_attack_modifiers = new double[1] { 1.14 } },
                new Skills() { name = "ATK Up γ", base_attack_modifiers = new double[2] { 1.14, 1 } },
                new Skills() { name = "Delayed Concussive Parts", base_attack_modifiers = new double[1] { 1.14 }, attack_multiplier_modifiers = new double[1] { 2.4 } }
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Shirayuki", ATK = 867,  INTERVAL = 2.8, ATKTYPE = AttackType.Physical, CLASS = "Sniper", ARCHETYPE = "AoE/Artilleryman" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", base_attack_modifiers = new double[1] { 0.2 }, attack_interval_modifiers = new double[1] { 0.2 } },
                // new Skills() { name = "Shuriken", base_attack_modifiers = new double[1] { 0.2 }, attack_interval_modifiers = new double[1] { 0.2 } }, // Utility Skill
                new Skills() { name = "Fatal Shuriken", base_attack_modifiers = new double[1] { 0.2 }, attack_interval_modifiers = new double[1] { 0.2 }, extra_arts_damage_done = new double[1] { 693.6 } } // deals 80% arts
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Catapult", ATK = 672,  INTERVAL = 2.8, ATKTYPE = AttackType.Physical, CLASS = "Sniper", ARCHETYPE = "AoE/Artilleryman" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"}
                }
            },

            // Long-Range/Deadeye
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Fartooth", ATK = 1296,  INTERVAL = 2.7, ATKTYPE = AttackType.Physical, CLASS = "Sniper", ARCHETYPE = "Long-Range/Deadeye" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", base_attack_modifiers = new double[1] { 0.15 } }, // if not hit for 10 sec, damage buffed
                new Skills() { name = "Swift Strike γ", base_attack_modifiers = new double[2] { 0.15, 0.45 }, attack_speed_modifiers = new double[1] { 45 } },
                new Skills() { name = "Ally Support", base_attack_modifiers = new double[1] { 0.15 }, attack_speed_modifiers = new double[1] { 110 } },
                new Skills() { name = "Feathershine Arrows", base_attack_modifiers = new double[2] { 0.15, 1.4 }, attack_multiplier_modifiers = new double[1] { 1.4 } }
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Firewatch", ATK = 1175,  INTERVAL = 2.7, ATKTYPE = AttackType.Physical, CLASS = "Sniper", ARCHETYPE = "Long-Range/Deadeye" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"},
                new Skills() { name = "Camouflage", base_attack_modifiers = new double[1] { 0.7 } },
                new Skills() { name = "Tactical Transceiver", attack_multiplier_modifiers = new double[1] { 3 } }
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Andreana", ATK = 1110,  INTERVAL = 2.7, ATKTYPE = AttackType.Physical, CLASS = "Sniper", ARCHETYPE = "Long-Range/Deadeye" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", attack_speed_modifiers = new double[1] { 12 } },
                new Skills() { name = "ATK Up γ", attack_speed_modifiers = new double[1] { 12 }, base_attack_modifiers = new double[1] { 1 } },
                new Skills() { name = "Interdictive Sniping Tactics", attack_speed_modifiers = new double[1] { 12 }, base_attack_modifiers = new double[1] { 2.4 } }
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Ambriel", ATK = 1052,  INTERVAL = 2.7, ATKTYPE = AttackType.Physical, CLASS = "Sniper", ARCHETYPE = "Long-Range/Deadeye" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"},
                // new Skills() { name = "Snaring Shell" }, // Utility Skill
                new Skills() { name = "Radar Sweep", base_attack_modifiers = new double[1] { 1 }, attack_interval_modifiers = new double[1] { 0.9 } }
                }
            },
            //new OperatorUnit() { OperatorStats = new Stats() { NAME = "LunaCub", ATK = ,  INTERVAL = 2.7, ATKTYPE = AttackType.Physical, CLASS = "Sniper", ARCHETYPE = "Long-Range/Deadeye" }, OperatorSkills = new Skills[] {
            //    new Skills() { name = "Passive"},
            //    new Skills() { name = "" },
            //    new Skills() { name = "" }
            //    }
            //},

            // Boomstick/Spreadshooter
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Ch'en the Holungday", ATK = 853,  INTERVAL = 2.3, ATKTYPE = AttackType.Physical, CLASS = "Sniper", ARCHETYPE = "Boomstick/Spreadshooter" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", base_attack_modifiers = new double[1] { 1.5 }, attack_speed_modifiers = new double[1] { 8 } },
                new Skills() { name = "High-Pressure Splash", base_attack_modifiers = new double[2] { 1.5, 1 }, attack_speed_modifiers = new double[1] { 8 } },
                new Skills() { name = "Night of Violet", base_attack_modifiers = new double[2] { 1.5, 0.8 }, attack_speed_modifiers = new double[1] { 8 }, flat_def_modierifers = new double[1] { -170 } },
                new Skills() { name = "Holiday Storm", base_attack_modifiers = new double[2] { 1.5, 1 }, attack_speed_modifiers = new double[2] { 8, 200 }, flat_def_modierifers = new double[1] { -220 } } // attacks deal damage twice
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Executor", ATK = 785,  INTERVAL = 2.3, ATKTYPE = AttackType.Physical, CLASS = "Sniper", ARCHETYPE = "Boomstick/Spreadshooter" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", base_attack_modifiers = new double[1] { 1.5 }, flat_def_modierifers = new double[1] { -160 } },
                new Skills() { name = "Muzzle's Elegy", base_attack_modifiers = new double[2] { 1.5, 0.2 }, flat_def_modierifers = new double[1] { -160 } },
                new Skills() { name = "Final Journey", base_attack_modifiers = new double[1] { 1.5 }, flat_def_modierifers = new double[1] { -160 }, attack_interval_modifiers = new double[1] { -0.2 }, attack_speed_modifiers = new double[1] { 200 } } // attacks deal damage twice
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Aosta", ATK = 756,  INTERVAL = 2.3, ATKTYPE = AttackType.Physical, CLASS = "Sniper", ARCHETYPE = "Boomstick/Spreadshooter" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", base_attack_modifiers = new double[1] { 1.5 }, extra_arts_damage_done = new double[1] { 136.08 } }, // 18% arts damage
                new Skills() { name = "Swift Strike γ", base_attack_modifiers = new double[2] { 1.5, 0.45 }, extra_arts_damage_done = new double[1] { 136.08 }, attack_speed_modifiers = new double[1] { 45 } },
                new Skills() { name = "Shadow Nails", base_attack_modifiers = new double[2] { 1.5, 0.7 }, extra_arts_damage_done = new double[1] { 272.16 }, attack_interval_modifiers = new double[1] { 0.5 } }
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Pinecone", ATK = 722,  INTERVAL = 2.3, ATKTYPE = AttackType.Physical, CLASS = "Sniper", ARCHETYPE = "Boomstick/Spreadshooter" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", base_attack_modifiers = new double[1] { 1.5 } },
                new Skills() { name = "RMA Spikes", base_attack_modifiers = new double[1] { 1.5 }, attack_multiplier_modifiers = new double[1] { 2 }, flat_def_modierifers = new double[1] { -250 } },
                new Skills() { name = "Electrical Overcharge", base_attack_modifiers = new double[3] { 1.5, 0.6, 0.6 } } // +20% each time skill used up to 60% i.e. 3 times
                }
            },

            // Anti-Air/Marksmen
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Exusiai", ATK = 630,  INTERVAL = 1, ATKTYPE = AttackType.Physical, CLASS = "Sniper", ARCHETYPE = "Anti-Air/Marksmen" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", base_attack_modifiers = new double[1] { 0.06 } },
                new Skills() { name = "Charging Mode", base_attack_modifiers = new double[1] { 0.06 }, attack_speed_modifiers = new double[1] { 200 }, attack_multiplier_modifiers = new double[1] { 1.45 } },
                new Skills() { name = "Shooting Mode", base_attack_modifiers = new double[1] { 0.06 }, attack_speed_modifiers = new double[1] { 300 }, attack_multiplier_modifiers = new double[1] { 1.25 } },
                new Skills() { name = "Overloading Mode", base_attack_modifiers = new double[1] { 0.06 }, attack_speed_modifiers = new double[1] { 400 }, attack_interval_modifiers = new double[1] { -0.11 }, attack_multiplier_modifiers = new double[1] { 1.1 } }
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Ash", ATK = 624,  INTERVAL = 1, ATKTYPE = AttackType.Physical, CLASS = "Sniper", ARCHETYPE = "Anti-Air/Marksmen" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive" },
                new Skills() { name = "Supporting Fire", attack_speed_modifiers = new double[1] { 200 }, base_attack_modifiers = new double[1] { 0.15 } },
                new Skills() { name = "Assault Tactics", attack_interval_modifiers = new double[1] { -0.08 }, attack_multiplier_modifiers = new double[1] { 2.5 } },
                new Skills() { name = "Breaching Rounds", attack_multiplier_modifiers = new double[1] { 3.0 } }
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Archetto", ATK = 618,  INTERVAL = 1, ATKTYPE = AttackType.Physical, CLASS = "Sniper", ARCHETYPE = "Anti-Air/Marksmen" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive" },
                new Skills() { name = "Dispersing Arrows", attack_speed_modifiers = new double[1] { 300 }, attack_multiplier_modifiers = new double[1] { 1.8 } },
                new Skills() { name = "Pursuing Arrows", attack_speed_modifiers = new double[1] { 500 }, attack_multiplier_modifiers = new double[1] { 1.4 } },
                new Skills() { name = "Thundering Arrows", base_attack_modifiers = new double[1] { 0.3 }, attack_speed_modifiers = new double[1] { 300 } }
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Blue Poison", ATK = 610,  INTERVAL = 1, ATKTYPE = AttackType.Physical, CLASS = "Sniper", ARCHETYPE = "Anti-Air/Marksmen" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", extra_arts_damage_done = new double[1] { 75 } },
                new Skills() { name = "Twinshot - Auto", attack_speed_modifiers = new double[1] { 200 }, attack_multiplier_modifiers = new double[1] { 2.0 }, extra_arts_damage_done = new double[1] { 75 } },
                new Skills() { name = "Venom Spray", base_attack_modifiers = new double[1] { 0.5 }, attack_speed_modifiers = new double[1] { 200 }, extra_arts_damage_done = new double[1] { 75 } }
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "April", ATK = 603,  INTERVAL = 1, ATKTYPE = AttackType.Physical, CLASS = "Sniper", ARCHETYPE = "Anti-Air/Marksmen" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive" },
                new Skills() { name = "Precise Shooting", attack_multiplier_modifiers = new double[1] { 2.3 } },
                new Skills() { name = "Flexible Camouflage", base_attack_modifiers = new double[1] { 1 } }
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Stormeye", ATK = 595,  INTERVAL = 1, ATKTYPE = AttackType.Physical, CLASS = "Sniper", ARCHETYPE = "Anti-Air/Marksmen" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", base_attack_modifiers = new double[1] { 2 } },
                new Skills() { name = "Spiral Arm", base_attack_modifiers = new double[1] { 2 }, attack_speed_modifiers = new double[1] { 200 } }
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "GreyThroat", ATK = 588,  INTERVAL = 1, ATKTYPE = AttackType.Physical, CLASS = "Sniper", ARCHETYPE = "Anti-Air/Marksmen" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", base_attack_modifiers = new double[1] { 1.5 }, attack_speed_modifiers = new double[1] { 6 } },
                new Skills() { name = "Flying Feathers", base_attack_modifiers = new double[2] { 1.5, 1.4 }, attack_speed_modifiers = new double[2] { 6, 200 },  },
                new Skills() { name = "Counterflow", base_attack_modifiers = new double[2] { 1.5, 0.4 }, attack_speed_modifiers = new double[2] { 6, 300 } }
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Platinum", ATK = 580,  INTERVAL = 1, ATKTYPE = AttackType.Physical, CLASS = "Sniper", ARCHETYPE = "Anti-Air/Marksmen" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", base_attack_modifiers = new double[1] { 1 } },
                new Skills() { name = "ATK Up γ", base_attack_modifiers = new double[1] { 1 }, attack_multiplier_modifiers = new double[1] { 1 } },
                new Skills() { name = "Pegasian Sight", base_attack_modifiers = new double[1] { 1 }, attack_multiplier_modifiers = new double[1] { 1 }, attack_speed_modifiers = new double[1] { -20 } }
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Kroos the Keen Glint", ATK = 577,  INTERVAL = 1, ATKTYPE = AttackType.Physical, CLASS = "Sniper", ARCHETYPE = "Anti-Air/Marksmen" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", base_attack_modifiers = new double[1] { 1.6 } },
                new Skills() { name = "Traceless", base_attack_modifiers = new double[2] { 1.6, 0.4 }, attack_speed_modifiers = new double[1] { 200 } },
                new Skills() { name = "Silencer", base_attack_modifiers = new double[1] { 1.6 }, attack_speed_modifiers = new double[1] { 200 }, attack_interval_modifiers = new double[1] { -0.375 } }
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Vermeil", ATK = 550,  INTERVAL = 1, ATKTYPE = AttackType.Physical, CLASS = "Sniper", ARCHETYPE = "Anti-Air/Marksmen" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive" },
                new Skills() { name = "ATK Up β", base_attack_modifiers = new double[1] { 0.8 } },
                new Skills() { name = "Double Shot", base_attack_modifiers = new double[1] { 0.45 }, attack_speed_modifiers = new double[1] { 200 } }
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "May", ATK = 543,  INTERVAL = 1, ATKTYPE = AttackType.Physical, CLASS = "Sniper", ARCHETYPE = "Anti-Air/Marksmen" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", base_attack_modifiers = new double[1] { 0.07 }, attack_speed_modifiers = new double[1] { 7 } },
                new Skills() { name = "Paralyzing Shell", base_attack_modifiers = new double[1] { 0.07 }, attack_speed_modifiers = new double[1] { 7 }, attack_multiplier_modifiers = new double[1] { 2 } },
                new Skills() { name = "Binding Shock", base_attack_modifiers = new double[1] { 0.07 }, attack_speed_modifiers = new double[1] { 7 }, attack_multiplier_modifiers = new double[1] { 1.2 }, attack_interval_modifiers = new double[1] { 1.5 } }
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Jessica", ATK = 540,  INTERVAL = 1, ATKTYPE = AttackType.Physical, CLASS = "Sniper", ARCHETYPE = "Anti-Air/Marksmen" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", attack_speed_modifiers = new double[1] { 12 } },
                new Skills() { name = "Power Strike β", attack_speed_modifiers = new double[1] { 12 }, attack_multiplier_modifiers = new double[1] { 2.3 } },
                new Skills() { name = "Smokescreen", attack_speed_modifiers = new double[1] { 12 }, base_attack_modifiers = new double[1] { 0.8 } }
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Meteor", ATK = 530,  INTERVAL = 1, ATKTYPE = AttackType.Physical, CLASS = "Sniper", ARCHETYPE = "Anti-Air/Marksmen" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive" },
                new Skills() { name = "Armor Breaker", attack_multiplier_modifiers = new double[1] { 1.8 }, scaling_def_modifiers = new double[1] { -0.35 } },
                new Skills() { name = "Armor Breaker - Spread", attack_multiplier_modifiers = new double[1] { 2 }, scaling_def_modifiers = new double[1] { -0.4 } }
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Kroos", ATK = 425,  INTERVAL = 1, ATKTYPE = AttackType.Physical, CLASS = "Sniper", ARCHETYPE = "Anti-Air/Marksmen" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", base_attack_modifiers = new double[1] { 1.6 } },
                new Skills() { name = "Double Tap - Auto", base_attack_modifiers = new double[1] { 1.6 }, attack_multiplier_modifiers = new double[1] { 1.4 }, attack_speed_modifiers = new double[1] { 200 } }
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Adnachiel", ATK = 415,  INTERVAL = 1, ATKTYPE = AttackType.Physical, CLASS = "Sniper", ARCHETYPE = "Anti-Air/Marksmen" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", attack_speed_modifiers = new double[1] { 8 } },
                new Skills() { name = "ATK Up α", base_attack_modifiers = new double[1] { 0.5 }, attack_speed_modifiers = new double[1] { 8 } }
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Reserve Operator - Sniper", ATK = 401,  INTERVAL = 1, ATKTYPE = AttackType.Physical, CLASS = "Sniper", ARCHETYPE = "Anti-Air/Marksmen" }, OperatorSkills = new Skills[] { new Skills() { } } },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Rangers", ATK = 299,  INTERVAL = 1, ATKTYPE = AttackType.Physical, CLASS = "Sniper", ARCHETYPE = "Anti-Air/Marksmen" }, OperatorSkills = new Skills[] { new Skills() { } } },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "'Justice Knight'", ATK = 217,  INTERVAL = 1, ATKTYPE = AttackType.Physical, CLASS = "Sniper", ARCHETYPE = "Anti-Air/Marksmen" }, OperatorSkills = new Skills[] { new Skills() { } } },

            // Aftershock/Flinger
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Rosmontis", ATK = 748,  INTERVAL = 2.1, ATKTYPE = AttackType.Physical, CLASS = "Sniper", ARCHETYPE = "Aftershock/Flinger" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", extra_phys_damage_done = new double[2] { 374, 374 }, flat_def_modierifers = new double[1] { -160 }, base_attack_modifiers = new double[1] { 0.08 } },
                new Skills() { name = "Expanded Cognition", extra_phys_damage_done = new double[2] { 374, 374 }, flat_def_modierifers = new double[1] { -160 }, base_attack_modifiers = new double[1] { 0.08 }, extra_arts_damage_done = new double[1] { 1346.4 } }, // extra hit 180% arts
                new Skills() { name = "Nociceptor Inhibition", extra_phys_damage_done = new double[4] { 374, 374, 374, 374 }, flat_def_modierifers = new double[1] { -160 }, base_attack_modifiers = new double[2] { 0.08, 0.55 }, attack_interval_modifiers = new double[1] { 0.5 } }, // 2 extra shockwaves
                new Skills() { name = "As You Wish", extra_phys_damage_done = new double[2] { 374, 374 }, flat_def_modierifers = new double[1] { -160 }, base_attack_modifiers = new double[2] { 0.08, 0.75 }, attack_interval_modifiers = new double[1] { -0.5 } }
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Greyy the Lightningbearer", ATK = 688,  INTERVAL = 2.1, ATKTYPE = AttackType.Physical, CLASS = "Sniper", ARCHETYPE = "Aftershock/Flinger" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", extra_phys_damage_done = new double[2] { 344, 344 }},
                new Skills() { name = "Swift Strike γ", extra_phys_damage_done = new double[2] { 344, 344 }, base_attack_modifiers = new double[1] { 0.45 }, attack_speed_modifiers = new double[1] { 45 } },
                new Skills() { name = "Beacon of Dawn", extra_phys_damage_done = new double[2] { 344, 344 }, extra_arts_damage_done = new double[1] { 7155.2 } } // 130% arts (8 hits over 12 seconds on 1.5 interval)
                }
            },

            // Heavyweight/Besieger
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Rosa (Poca)", ATK = 1142,  INTERVAL = 2.4, ATKTYPE = AttackType.Physical, CLASS = "Sniper", ARCHETYPE = "Heavyweight/Besieger" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", scaling_def_modifiers = new double[1] { -0.6 }, base_attack_modifiers = new double[1] { 0.08 } },
                new Skills() { name = "ATK Up γ", scaling_def_modifiers = new double[1] { -0.6 }, base_attack_modifiers = new double[2] { 0.08, 1 } },
                new Skills() { name = "Split Shot", scaling_def_modifiers = new double[1] { -0.6 }, base_attack_modifiers = new double[2] { 0.08, 0.9 } }, // hits another enemy
                new Skills() { name = "Avalanche Breaker", scaling_def_modifiers = new double[1] { -0.6 }, base_attack_modifiers = new double[2] { 0.08, 0.25 }, extra_phys_damage_done = new double[1] { 1142 } } // 9136? 1 hit per sec for 8 sec
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Toddifons", ATK = 1049,  INTERVAL = 2.4, ATKTYPE = AttackType.Physical, CLASS = "Sniper", ARCHETYPE = "Heavyweight/Besieger" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"},
                new Skills() { name = "Signal Arrow", base_attack_modifiers = new double[1] { 1.8 }, scaling_def_modifiers = new double[1] { -0.3 } },
                new Skills() { name = "Portable Fortcracker Arrows", attack_interval_modifiers = new double[1] { 0.3 }, attack_multiplier_modifiers = new double[1] { 2.4 }, extra_phys_damage_done = new double[1] { 839.2 } } // 80% explosion
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Erato", ATK = 1027,  INTERVAL = 2.4, ATKTYPE = AttackType.Physical, CLASS = "Sniper", ARCHETYPE = "Heavyweight/Besieger" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"}, // inflicts sleep?
                new Skills() { name = "Soothing Lullaby", attack_multiplier_modifiers = new double[1] { 2.4 } },
                new Skills() { name = "Hero's Ballad", base_attack_modifiers = new double[1] { 0.5 }, attack_speed_modifiers = new double[1] { 50 } }
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Totter", ATK = 970,  INTERVAL = 2.4, ATKTYPE = AttackType.Physical, CLASS = "Sniper", ARCHETYPE = "Heavyweight/Besieger" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"},
                new Skills() { name = "Pierce the Sun", attack_multiplier_modifiers = new double[1] { 2.2 } },
                new Skills() { name = "Breaking Rainbow", attack_multiplier_modifiers = new double[1] { 2.25 }, attack_speed_modifiers = new double[1] { 50 } }
                }
            },

            // -Specialist-
            // Fast-Redeploy/Executor
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Phantom", ATK = 648,  INTERVAL = 0.93, ATKTYPE = AttackType.Physical, CLASS = "Specialist", ARCHETYPE = "Fast-Redeploy/Executor" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", extra_phys_damage_done = new double[1] { 548 } }, // Phantom in the Mirror Summon
                // new Skills() { name = "Phantom of the Night" }, // Utility Skill
                new Skills() { name = "Bloody Opus", extra_phys_damage_done = new double[1] { 548 }, base_attack_modifiers = new double[1] { 2 } }, // decreases by 0.2 each attack till 0
                new Skills() { name = "Night Raid", extra_phys_damage_done = new double[1] { 548 }, attack_multiplier_modifiers = new double[1] { 3 } }
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Projekt Red", ATK = 605,  INTERVAL = 0.93, ATKTYPE = AttackType.Physical, CLASS = "Specialist", ARCHETYPE = "Fast-Redeploy/Executor" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"}, // deals at least 30% attack instead of usual 5% (181.5?)
                new Skills() { name = "Execution Mode", base_attack_modifiers = new double[1] { 0.8 } },
                new Skills() { name = "Wolfpack", attack_multiplier_modifiers = new double[1] { 2.5 } }
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Waai Fu", ATK = 586,  INTERVAL = 0.93, ATKTYPE = AttackType.Physical, CLASS = "Specialist", ARCHETYPE = "Fast-Redeploy/Executor" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", base_attack_modifiers = new double[1] { 1.5 } },
                new Skills() { name = "One-inch Punch", base_attack_modifiers = new double[2] { 1.5 , 0.7 } },
                new Skills() { name = "Seven-styles Kick", base_attack_modifiers = new double[1] { 1.5 }, attack_multiplier_modifiers = new double[1] { 2.9 } }
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Kafka", ATK = 525,  INTERVAL = 0.93, ATKTYPE = AttackType.Arts, CLASS = "Specialist", ARCHETYPE = "Fast-Redeploy/Executor" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"}, // Changed to arts for convience of calculation
                new Skills() { name = "Cube of Absurdism", base_attack_modifiers = new double[1] { 0.15 }, attack_multiplier_modifiers = new double[1] { 4.5 } },
                new Skills() { name = "Shears of Surrealism", base_attack_modifiers = new double[1] { 0.15 }, attack_multiplier_modifiers = new double[1] { 4 } }
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Gravel", ATK = 452,  INTERVAL = 0.93, ATKTYPE = AttackType.Physical, CLASS = "Specialist", ARCHETYPE = "Fast-Redeploy/Executor" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"} // All DEF skills
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "THRM-EX", ATK = 350,  INTERVAL = 0.93, ATKTYPE = AttackType.Physical, CLASS = "Specialist", ARCHETYPE = "Fast-Redeploy/Executor" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", attack_multiplier_modifiers = new double[1] { 4 }, scaling_def_modifiers = new double[1] { -0.3 } } // Goes boom
                }
            },
            //new OperatorUnit() { OperatorStats = new Stats() { NAME = "Texas The Omertosa", ATK = ,  INTERVAL = 0.93, ATKTYPE = AttackType.Physical, CLASS = "Specialist", ARCHETYPE = "Fast-Redeploy/Executor" }, OperatorSkills = new Skills[] {
            //    new Skills() { name = "Passive"},
            //    new Skills() { name = "" }
            //    }
            //},

            // Trapmaster
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Dorothy", ATK = 661,  INTERVAL = 0.85, ATKTYPE = AttackType.Physical, CLASS = "Specialist", ARCHETYPE = "Trapmaster" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"},
                new Skills() { name = "Dangerous Entity Removal", attack_multiplier_modifiers = new double[1] { 4.5 }, scaling_def_modifiers = new double[1] { -0.35 } },
                new Skills() { name = "Quicksand Generation", attack_multiplier_modifiers = new double[1] { 3 } }, // Utility Skill
                new Skills() { name = "High-speed Resonating Troubleshooter", attack_multiplier_modifiers = new double[1] { 3.5 } } // Utility Skill
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Frost", ATK = 569,  INTERVAL = 0.85, ATKTYPE = AttackType.Physical, CLASS = "Specialist", ARCHETYPE = "Trapmaster" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"},
                new Skills() { name = "Trap Deployment", attack_multiplier_modifiers = new double[1] { 3.5 } },
                new Skills() { name = "Incapacitated Prey", attack_multiplier_modifiers = new double[1] { 2 }, extra_phys_damage_done = new double[1] { 3072.6 } } // attacks 3 times at 180%
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Robin", ATK = 553,  INTERVAL = 0.85, ATKTYPE = AttackType.Physical, CLASS = "Specialist", ARCHETYPE = "Trapmaster" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"},
                new Skills() { name = "Binding Clip", attack_multiplier_modifiers = new double[1] { 3.5 } },
                new Skills() { name = "Launching Clip", attack_multiplier_modifiers = new double[1] { 3.8 } }
                }
            },

            // Substitute/Dollkeeper
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Specter the Unchained", ATK = 817,  INTERVAL = 1.2, ATKTYPE = AttackType.Physical, CLASS = "Specialist", ARCHETYPE = "Substitute/Dollkeeper" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", extra_arts_damage_done = new double[1] { 326.8 } }, // Substitute deals 40% arts
                new Skills() { name = "Techniques of Survival", base_attack_modifiers = new double[1] { 1.5 } },
                new Skills() { name = "Thirst for Survival", base_attack_modifiers = new double[1] { 1.3 }, attack_speed_modifiers = new double[1] { 50 } },
                new Skills() { name = "Pressure of Survival", attack_interval_modifiers = new double[1] { 1 }, base_attack_modifiers = new double[1] { 2.6 }, extra_phys_damage_done = new double[1] { 571.9 } } // 70% extra hit
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Kazemaru", ATK = 772,  INTERVAL = 1.2, ATKTYPE = AttackType.Physical, CLASS = "Specialist", ARCHETYPE = "Substitute/Dollkeeper" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", attack_multiplier_modifiers = new double[1] { 2.7 } }, // Damages on Substitute swap
                new Skills() { name = "Origami Art - Swift Strike", attack_multiplier_modifiers = new double[1] { 3.5 }  },
                new Skills() { name = "Origami Art - Twin Shadows", base_attack_modifiers = new double[1] { 1.2 } } // Summons Substitute?
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Bena", ATK = 742,  INTERVAL = 1.2, ATKTYPE = AttackType.Physical, CLASS = "Specialist", ARCHETYPE = "Substitute/Dollkeeper" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"}, // Substitute deals arts damage
                new Skills() { name = "Fervent Trimming", base_attack_modifiers = new double[1] { 1 }, scaling_def_modifiers = new double[1] { -0.35 } },
                new Skills() { name = "Rapid Trimming", base_attack_modifiers = new double[1] { 0.9 }, attack_speed_modifiers = new double[1] { 80 } }
                }
            },

            // DP-Drain/Merchant
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Lee", ATK = 844,  INTERVAL = 1, ATKTYPE = AttackType.Physical, CLASS = "Specialist", ARCHETYPE = "DP-Drain/Merchant" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", attack_speed_modifiers = new double[1] { 14 } },
                new Skills() { name = "Stern Admonishment", attack_speed_modifiers = new double[1] { 14 }, base_attack_modifiers = new double[1] { 0.6 } },
                new Skills() { name = "Exorcise Evil", attack_speed_modifiers = new double[2] { 14, 30 }, extra_arts_damage_done = new double[1] { 2532 } }, // minimum 300% arts, +20% per hit up to 30 times (600%) for possible total of 900%
                new Skills() { name = "Honored Guest", attack_speed_modifiers = new double[1] { 14 }, base_attack_modifiers = new double[1] { 0.5 } } // Utility Skill
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Mr. Nothing", ATK = 765,  INTERVAL = 1, ATKTYPE = AttackType.Physical, CLASS = "Specialist", ARCHETYPE = "DP-Drain/Merchant" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", attack_multiplier_modifiers = new double[1] { 1.5 } }, // buff if not attack for 4 seconds
                // new Skills() { name = "Cautious Retreat" }, // Utility Skill
                new Skills() { name = "Wax and Wane", base_attack_modifiers = new double[1] { 0.6 }, attack_speed_modifiers = new double[1] { 28 } } // The Gacha Skill
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Jaye", ATK = 714,  INTERVAL = 1, ATKTYPE = AttackType.Physical, CLASS = "Specialist", ARCHETYPE = "DP-Drain/Merchant" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"},
                new Skills() { name = "Shell Splitter", base_attack_modifiers  = new double[1] { 0.7 } },
                new Skills() { name = "Sashimi Platter", base_attack_modifiers  = new double[1] { 0.6 } }
                }
            },

            // Ambusher
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Mizuki", ATK = 975,  INTERVAL = 3.5, ATKTYPE = AttackType.Physical, CLASS = "Specialist", ARCHETYPE = "Ambusher" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", base_attack_modifiers = new double[1] { 0.1 }, extra_arts_damage_done = new double[1] { 487.5 } }, // 50% arts if enemy is lowest hp on map
                new Skills() { name = "Awaken", base_attack_modifiers = new double[1] { 0.3 }, attack_multiplier_modifiers = new double[1] { 3 } }, // Buff if enemy <50HP nearby
                new Skills() { name = "Prisoner's Dilemma", base_attack_modifiers = new double[2] { 0.1, 0.3 }, attack_interval_modifiers = new double[1] { -1.5 } },
                new Skills() { name = "Moon in the Water", base_attack_modifiers = new double[2] { 0.1, 1.5 } }
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Manticore", ATK = 871,  INTERVAL = 3.5, ATKTYPE = AttackType.Physical, CLASS = "Specialist", ARCHETYPE = "Ambusher" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", base_attack_modifiers = new double[1] { 0.5 } }, // Invisible attack buff
                // new Skills() { name = "Scorpion Venom", }, // Utility Skill, great slow, her main skill
                new Skills() { name = "Toxic Overload", base_attack_modifiers = new double[2] { 0.5, 0.9 }, attack_interval_modifiers = new double[1] { 1.7 } }
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Kirara", ATK = 858,  INTERVAL = 3.5, ATKTYPE = AttackType.Arts, CLASS = "Specialist", ARCHETYPE = "Ambusher" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"}, // Changed to arts for calculation convience
                new Skills() { name = "Anchor Strike", attack_multiplier_modifiers = new double[1] { 1.5 } },
                new Skills() { name = "Anchor Point Snap", attack_multiplier_modifiers = new double[1] { 8 } } // 800% arts over 8 seconds
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Ethan", ATK = 742,  INTERVAL = 3.5, ATKTYPE = AttackType.Physical, CLASS = "Specialist", ARCHETYPE = "Ambusher" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"},
                new Skills() { name = "Fancy Maneuvers", extra_arts_damage_done = new double[1] { 100 } }, // deals 100 for 4 sec
                new Skills() { name = "Suspended Cross", base_attack_modifiers = new double[1] { 0.7 } } // Utility Skill
                }
            },

            // Puller/Hookmaster
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Gladiia", ATK = 851,  INTERVAL = 1.8, ATKTYPE = AttackType.Physical, CLASS = "Specialist", ARCHETYPE = "Puller/Hookmaster" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", base_attack_modifiers = new double[1] { 1.3 } }, // more damage vs light enemies
                new Skills() { name = "Waterless Parting of the Great Ocean", attack_multiplier_modifiers = new double[1] { 2.1 } },
                new Skills() { name = "Waterless Grasp of the Raging Seas", attack_interval_modifiers = new double[1] { 0.5 }, attack_multiplier_modifiers = new double[1] { 1.8 } },
                new Skills() { name = "Waterless Dance of the Shattered Maelstrom", extra_arts_damage_done = new double[1] { 8850.4 } } // 130% as arts for 8 seconds & pulls
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Cliffheart", ATK = 835,  INTERVAL = 1.8, ATKTYPE = AttackType.Physical, CLASS = "Specialist", ARCHETYPE = "Puller/Hookmaster" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", base_attack_modifiers = new double[1] { 0.12 } },
                new Skills() { name = "Chain Hook", base_attack_modifiers = new double[1] { 0.12 }, extra_arts_damage_done = new double[1] { 1503 } }, // 180% arts
                new Skills() { name = "Binding Chains", base_attack_modifiers = new double[1] { 0.12 }, extra_true_damage_done = new double[1] { 1670 } } // 200% true
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Snowsant", ATK = 745,  INTERVAL = 1.8, ATKTYPE = AttackType.Physical, CLASS = "Specialist", ARCHETYPE = "Puller/Hookmaster" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"},
                new Skills() { name = "Barbed Clawhook", attack_multiplier_modifiers = new double[1] { 1.7 } },
                new Skills() { name = "Telescoping Electric Net", extra_arts_damage_done = new double[1] { 1490 } } // 200% arts
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Rope", ATK = 728,  INTERVAL = 1.8, ATKTYPE = AttackType.Physical, CLASS = "Specialist", ARCHETYPE = "Puller/Hookmaster" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"},
                new Skills() { name = "Hook Shot", attack_multiplier_modifiers = new double[1] { 1.9 } },
                new Skills() { name = "Double Hook", attack_multiplier_modifiers = new double[1] { 2.25 } }
                }
            },

            // Pusher/Push Stroker
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Weedy", ATK = 722,  INTERVAL = 1.2, ATKTYPE = AttackType.Physical, CLASS = "Specialist", ARCHETYPE = "Pusher/Push Stroker" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", extra_phys_damage_done = new double[1] { 585 } }, // Industrial Water Cannon Summon
                new Skills() { name = "Barrel Burst", attack_multiplier_modifiers = new double[1] { 1.5 } },
                new Skills() { name = "Hydraulics Mode", attack_interval_modifiers = new double[1] { 2.2 }, base_attack_modifiers = new double[1] { 2 } },
                new Skills() { name = "Liquid Nitrogen Cannon", extra_arts_damage_done = new double[1] { 2166 }, extra_true_damage_done = new double[1] { 1200 } } // 300% arts + 1200 true per grid pushed
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "FEater", ATK = 685,  INTERVAL = 1.2, ATKTYPE = AttackType.Physical, CLASS = "Specialist", ARCHETYPE = "Pusher/Push Stroker" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"},
                // new Skills() { name = "Raging Iron Fist" }, // Utility Skill
                new Skills() { name = "Destructive Fist", attack_multiplier_modifiers = new double[1] { 2.5 } }
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Enforcer", ATK = 653,  INTERVAL = 1.2, ATKTYPE = AttackType.Physical, CLASS = "Specialist", ARCHETYPE = "Pusher/Push Stroker" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", flat_def_modierifers = new double[1] { -200 } }, // Bad pusher :(
                // new Skills() { name = "Deterring Shot", flat_def_modierifers = new double[1] { -200 } }, // Utility Skill
                // new Skills() { name = "Staggering Shot", flat_def_modierifers = new double[1] { -200 } } // Utility Skill
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Shaw", ATK = 615,  INTERVAL = 1.2, ATKTYPE = AttackType.Physical, CLASS = "Specialist", ARCHETYPE = "Pusher/Push Stroker" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"}, // ShawOurLawdAndSaviorBestGirlPusherOverpoweredPassiveBuff
                new Skills() { name = "Steam Pump", attack_multiplier_modifiers = new double[1] { 1.5 } },
                new Skills() { name = "High-Pressure Water Cannon", attack_multiplier_modifiers = new double[1] { 3 } }
                }
            },

            // Sacrificial
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Aak", ATK = 753,  INTERVAL = 1.3, ATKTYPE = AttackType.Physical, CLASS = "Specialist", ARCHETYPE = "Sacrificial" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", attack_multiplier_modifiers = new double[1] { 1.5 } }, // Why is Aak? Gatcha boi 2 electric boogaloo
                new Skills() { name = "Rapid Fire", attack_speed_modifiers = new double[1] { 100 } },
                new Skills() { name = "Type-γ Stimpack", }, // Literal Team Killer WTF?
                new Skills() { name = "Durian-Flavored Stimpack", attack_speed_modifiers = new double[1] { 50 }, base_attack_modifiers = new double[1] { 0.5 } } // Literal Team Killer WTF?
                }
            },

            // -Caster-
            // Charge/Mystic Caster
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Ebenholz", ATK = 1550,  INTERVAL = 3, ATKTYPE = AttackType.Arts, CLASS = "Caster", ARCHETYPE = "Charge/Mystic Caster" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", attack_multiplier_modifiers = new double[2] { 1.35, 0.15 } }, // stored shot damage, no enemies nearby buff
                new Skills() { name = "Quickening Presto", attack_interval_modifiers = new double[1] { -0.17 }, attack_multiplier_modifiers = new double[2] { 0.5, 0.15 } },
                new Skills() { name = "Desolate Echoes", attack_multiplier_modifiers = new double[1] { 2.45 } },
                new Skills() { name = "Sound of Silence", attack_speed_modifiers = new double[1] { 80 }, base_attack_modifiers = new double[1] { 0.65 }, attack_multiplier_modifiers = new double[2] { 1.89, 0.15 } }
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Iris", ATK = 1389,  INTERVAL = 3, ATKTYPE = AttackType.Arts, CLASS = "Caster", ARCHETYPE = "Charge/Mystic Caster" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", attack_multiplier_modifiers = new double[1] { 1.3 } }, // stored shot damage
                new Skills() { name = "Fairytale Guardian", attack_interval_modifiers = new double[1] { -0.2 }, attack_multiplier_modifiers = new double[1] { 0.5 } },
                new Skills() { name = "Dreamland's Cradle", attack_multiplier_modifiers = new double[1] { 3 } }
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Indigo", ATK = 1216,  INTERVAL = 3, ATKTYPE = AttackType.Arts, CLASS = "Caster", ARCHETYPE = "Charge/Mystic Caster" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"}, // Utility Skill
                new Skills() { name = "Lighthouse Guardian", attack_interval_modifiers = new double[1] { -0.8 }, attack_multiplier_modifiers = new double[1] { 0.5 } },
                new Skills() { name = "Labyrinth of Light", attack_interval_modifiers = new double[1] { -0.6 }, attack_multiplier_modifiers = new double[1] { 1.6 } }
                }
            },

            // Drone/Mech-Accord
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Goldenglow", ATK = 391,  INTERVAL = 1.3, ATKTYPE = AttackType.Arts, CLASS = "Caster", ARCHETYPE = "Drone/Mech-Accord" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", flat_res_modierifers = new double[1] { -15 }, extra_arts_damage_done = new double[1] { 508.3 } }, // Chance drone explodes during skill
                new Skills() { name = "Scattering Sparks", base_attack_modifiers = new double[1] { 0.4 }, attack_speed_modifiers = new double[1] { 50 } },
                new Skills() { name = "Surging Current", base_attack_modifiers = new double[1] { 0.6 } }, // Utility Skill
                new Skills() { name = "Crystalline Shine", base_attack_modifiers = new double[1] { 0.8 } } // 2 drones, global range, bonkers skill
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Rockrock", ATK = 380,  INTERVAL = 1.3, ATKTYPE = AttackType.Arts, CLASS = "Caster", ARCHETYPE = "Drone/Mech-Accord" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", base_attack_modifiers = new double[1] { 0.16 }, extra_arts_damage_done = new double[1] { 418 } }, // damage increase staying on field, drone explode
                new Skills() { name = "Tactical Chant γ", base_attack_modifiers = new double[1] { 0.16 }, attack_speed_modifiers = new double[1] { 90 } },
                new Skills() { name = "Willing Burden", base_attack_modifiers = new double[1] { 0.16 }, attack_speed_modifiers = new double[1] { 80 } } // releases drone
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Click", ATK = 375,  INTERVAL = 1.3, ATKTYPE = AttackType.Arts, CLASS = "Caster", ARCHETYPE = "Drone/Mech-Accord" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", attack_speed_modifiers = new double[1] { 12 }, extra_arts_damage_done = new double[1] { 412 } }, // chance drone explode
                new Skills() { name = "ATK Up β", attack_speed_modifiers = new double[1] { 12 }, base_attack_modifiers = new double[1] { 0.8 } },
                new Skills() { name = "Synchronized Attack", attack_speed_modifiers = new double[1] { 12 }, base_attack_modifiers = new double[1] { 0.7 } } // releases drone
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Minimalist", ATK = 360,  INTERVAL = 1.3, ATKTYPE = AttackType.Arts, CLASS = "Caster", ARCHETYPE = "Drone/Mech-Accord" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", attack_multiplier_modifiers = new double[1] { 1.5 }, extra_arts_damage_done = new double[1] { 396 } }, // chance drone explode
                new Skills() { name = "Swift Strike γ", attack_multiplier_modifiers = new double[1] { 1.5 }, base_attack_modifiers = new double[1] { 0.45 }, attack_speed_modifiers = new double[1] { 45 } },
                new Skills() { name = "Divine Craftsmanship", attack_multiplier_modifiers = new double[2] { 1.5, 2 }, extra_arts_damage_done = new double[1] { 360 } } // does 2 hits
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Kjera", ATK = 354,  INTERVAL = 1.3, ATKTYPE = AttackType.Arts, CLASS = "Caster", ARCHETYPE = "Drone/Mech-Accord" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", base_attack_modifiers = new double[1] { 0.16 }, extra_arts_damage_done = new double[1] { 389.4 } }, // chance drone explode
                new Skills() { name = "ATK Up γ", base_attack_modifiers = new double[2] { 0.16, 1 } },
                new Skills() { name = "Unrestrained Heart", base_attack_modifiers = new double[2] { 0.16, 0.55 } } // release drone
                }
            },

            // Modal/Phalanx
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Carnelian", ATK = 926,  INTERVAL = 2, ATKTYPE = AttackType.Arts, CLASS = "Caster", ARCHETYPE = "Modal/Phalanx" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"}, // Only attacks when skill active
                new Skills() { name = "Sandstorm Guardian", base_attack_modifiers = new double[1] { 0.6 } },
                new Skills() { name = "Sand Fetters", attack_interval_modifiers = new double[1] { -1.1 }, base_attack_modifiers = new double[1] { 0.2 } },
                new Skills() { name = "Mark of Gluttony", base_attack_modifiers = new double[1] { 2.8 }, arts_taken_modifiers = new double[1] { 1 } }
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Mint", ATK = 807,  INTERVAL = 2, ATKTYPE = AttackType.Arts, CLASS = "Caster", ARCHETYPE = "Modal/Phalanx" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"}, // Only attacks when skill active
                new Skills() { name = "Wind Whispers", attack_multiplier_modifiers = new double[1] { 1.6 } },
                new Skills() { name = "Swirling Vortex", attack_multiplier_modifiers = new double[1] { 1.3 }, extra_arts_damage_done = new double[1] { 2421 } } // 300% arts
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Beeswax", ATK = 805,  INTERVAL = 2, ATKTYPE = AttackType.Arts, CLASS = "Caster", ARCHETYPE = "Modal/Phalanx" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"}, // Only attacks when skill active
                new Skills() { name = "Growing Sandstorm", base_attack_modifiers = new double[1] { 0.6 } },
                new Skills() { name = "Guardian Obelisk", attack_multiplier_modifiers = new double[1] { 3 } }
                }
            },

            // Chain
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Passenger", ATK = 774,  INTERVAL = 2.3, ATKTYPE = AttackType.Arts, CLASS = "Caster", ARCHETYPE = "Chain" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", base_attack_modifiers = new double[2] { 0.2, 0.08 } }, // Enemy >80HP and not in 4 tiles
                new Skills() { name = "Touch of Static", base_attack_modifiers = new double[2] { 0.2, 0.08 }, attack_multiplier_modifiers = new double[1] { 2.5 } },
                new Skills() { name = "Focus Command", base_attack_modifiers = new double[3] { 0.2, 0.08, 0.3 }, attack_interval_modifiers = new double[1] { -0.5 } },
                new Skills() { name = "Glorious Shards", base_attack_modifiers = new double[2] { 0.2, 0.08 }, attack_multiplier_modifiers = new double[1] { 1.5 }, extra_arts_damage_done = new double[1] { 5418 } } // 8 attacks can hit same enemy (x7 for calc since 1 hit in calc already)
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Leizi", ATK = 710,  INTERVAL = 2.3, ATKTYPE = AttackType.Arts, CLASS = "Caster", ARCHETYPE = "Chain" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", base_attack_modifiers = new double[1] { 0.2 } }, // 20% damage if enemy not blocked
                new Skills() { name = "ATK Up γ", base_attack_modifiers = new double[2] { 0.2, 1 } },
                new Skills() { name = "Thunderclap", base_attack_modifiers = new double[2] { 0.2, 1.5 } }
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Astgenne", ATK = 705,  INTERVAL = 2.3, ATKTYPE = AttackType.Arts, CLASS = "Caster", ARCHETYPE = "Chain" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", attack_speed_modifiers = new double[1] { 20 } }, // gain speed over time
                new Skills() { name = "Double Diversion", attack_speed_modifiers = new double[1] { 20 }, attack_multiplier_modifiers = new double[1] { 1.25 } },
                new Skills() { name = "Starlight Intersection", attack_speed_modifiers = new double[1] { 20 }, base_attack_modifiers = new double[1] { 0.4 } } // Utility Skill
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Pudding", ATK = 612,  INTERVAL = 2.3, ATKTYPE = AttackType.Arts, CLASS = "Caster", ARCHETYPE = "Chain" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", base_attack_modifiers = new double[1] { 0.1 } },
                new Skills() { name = "Tactical Chant β", base_attack_modifiers = new double[1] { 0.1 }, attack_speed_modifiers = new double[1] { 75 } },
                new Skills() { name = "Diffusion Current", base_attack_modifiers = new double[2] { 0.1, 1.1 } }
                }
            },

            // AoE/Splash
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Dusk", ATK = 1028,  INTERVAL = 2.9, ATKTYPE = AttackType.Arts, CLASS = "Caster", ARCHETYPE = "AoE/Splash" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", base_attack_modifiers = new double[1] { 0.3 }, extra_arts_damage_done = new double[1] { 398 } }, // stack 15 enemy kills buff, 'Freeling' Summon
                new Skills() { name = "Transcendental Stroke", base_attack_modifiers = new double[1] { 0.3 }, attack_multiplier_modifiers = new double[1] { 2.5 } },
                new Skills() { name = "Flowing Ink", base_attack_modifiers = new double[2] { 0.3, 0.55 }, attack_multiplier_modifiers = new double[1] { 1.5 }, attack_speed_modifiers = new double[1] { 55 } },
                new Skills() { name = "Image over Form", base_attack_modifiers = new double[2] { 0.3, 1.2 }, attack_interval_modifiers = new double[1] { 0.4 }, } //  Summons on each attack?
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Mostima", ATK = 939,  INTERVAL = 2.9, ATKTYPE = AttackType.Arts, CLASS = "Caster", ARCHETYPE = "AoE/Splash" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"},
                new Skills() { name = "ATK Up γ", base_attack_modifiers = new double[1] { 1 } },
                new Skills() { name = "Lock of Shattered Time", attack_multiplier_modifiers = new double[1] { 1.4 } },
                new Skills() { name = "Key of Chronology", base_attack_modifiers = new double[1] { 1.7 } }
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Lava the Purgatory", ATK = 888,  INTERVAL = 2.9, ATKTYPE = AttackType.Arts, CLASS = "Caster", ARCHETYPE = "AoE/Splash" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"},
                new Skills() { name = "Flame Quenched Dagger", base_attack_modifiers = new double[1] { 0.2 } },
                new Skills() { name = "Ring of Hellfire", attack_multiplier_modifiers = new double[1] { 0.5 } } // 50% arts per second
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Skyfire", ATK = 874,  INTERVAL = 2.9, ATKTYPE = AttackType.Arts, CLASS = "Caster", ARCHETYPE = "AoE/Splash" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", attack_multiplier_modifiers = new double[1] { 0.15 } },
                new Skills() { name = "ATK Up γ", base_attack_modifiers = new double[1] { 1 }, attack_multiplier_modifiers = new double[1] { 0.15 } },
                new Skills() { name = "Fire of Heaven", attack_interval_modifiers = new double[1] { 1.7 }, attack_multiplier_modifiers = new double[2] { 0.15, 2.4 } }
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Leonhardt", ATK = 863,  INTERVAL = 2.9, ATKTYPE = AttackType.Arts, CLASS = "Caster", ARCHETYPE = "AoE/Splash" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", base_attack_modifiers = new double[1] { 0.2 } }, // buff if 5 enemies in range
                new Skills() { name = "ATK Up γ", base_attack_modifiers = new double[2] { 0.2, 1 } },
                new Skills() { name = "Deconstruct and Detonate", base_attack_modifiers = new double[1] { 0.2 }, attack_multiplier_modifiers = new double[1] { 2.3 }, scaling_res_modifiers = new double[1] { -0.15 } }
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Pith", ATK = 821,  INTERVAL = 2.9, ATKTYPE = AttackType.Arts, CLASS = "Caster", ARCHETYPE = "AoE/Splash" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", flat_res_modierifers = new double[1] { -20 } },
                new Skills() { name = "All For Me", attack_speed_modifiers = new double[1] { 70 }, base_attack_modifiers = new double[1] { 0.4 } } // damage buff to all casters
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Gitano", ATK = 785,  INTERVAL = 2.9, ATKTYPE = AttackType.Arts, CLASS = "Caster", ARCHETYPE = "AoE/Splash" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", base_attack_modifiers = new double[1] { 0.13 } }, // Randon buff on deploy (atk, spd, hp), used atk for calc'
                new Skills() { name = "Tactical Chant β", base_attack_modifiers = new double[1] { 0.13 }, attack_speed_modifiers = new double[1] { 75 } },
                new Skills() { name = "Destiny", base_attack_modifiers = new double[2] { 0.13, 1 } }
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Greyy", ATK = 699,  INTERVAL = 2.9, ATKTYPE = AttackType.Arts, CLASS = "Caster", ARCHETYPE = "AoE/Splash" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"},
                new Skills() { name = "Tactical Chant β", attack_speed_modifiers = new double[1] { 75 } },
                new Skills() { name = "Electrostatic Discharge", attack_speed_modifiers = new double[1] { 80 } }
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Lava", ATK = 642,  INTERVAL = 2.9, ATKTYPE = AttackType.Arts, CLASS = "Caster", ARCHETYPE = "AoE/Splash" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"},
                new Skills() { name = "Tactical Chant α", attack_speed_modifiers = new double[1] { 50 } }
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "12F", ATK = 482,  INTERVAL = 2.9, ATKTYPE = AttackType.Arts, CLASS = "Caster", ARCHETYPE = "AoE/Splash" }, OperatorSkills = new Skills[] { new Skills() { } } },
            
            // ST/Core
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Ceobe", ATK = 757,  INTERVAL = 1.6, ATKTYPE = AttackType.Arts, CLASS = "Caster", ARCHETYPE = "ST/Core" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", base_attack_modifiers = new double[1] { 0.08 }, attack_speed_modifiers = new double[1] { 8 }, extra_arts_damage_done = new double[1] { 400 } }, // Buff when alone, deals 40% DEF as Arts (assuming 1000 DEF for calc)
                new Skills() { name = "Really Cold Axe", attack_multiplier_modifiers = new double[1] { 2.1 }, base_attack_modifiers = new double[1] { 0.08 }, attack_speed_modifiers = new double[1] { 8 }, extra_arts_damage_done = new double[1] { 400 } },
                new Skills() { name = "Really Hot Knives", attack_interval_modifiers = new double[1] { -0.33 }, base_attack_modifiers = new double[1] { 0.08 }, attack_speed_modifiers = new double[1] { 8 }, extra_arts_damage_done = new double[1] { 400 } },
                new Skills() { name = "Really Heavy Spear", base_attack_modifiers = new double[2] { 0.08, 2.1 }, attack_speed_modifiers = new double[1] { 8 }, extra_arts_damage_done = new double[1] { 400 } } // deals physical
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Eyjafjalla", ATK = 735,  INTERVAL = 1.6, ATKTYPE = AttackType.Arts, CLASS = "Caster", ARCHETYPE = "ST/Core" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", base_attack_modifiers = new double[1] { 0.14 } },
                new Skills() { name = "Duetto", base_attack_modifiers = new double[2] { 0.14, 0.6 }, attack_speed_modifiers = new double[1] { 60 } }, // buff from 2nd usage
                new Skills() { name = "Ignition", base_attack_modifiers = new double[1] { 0.14 }, attack_multiplier_modifiers = new double[1] { 3.7 }, scaling_res_modifiers = new double[1] { -0.25 } },
                new Skills() { name = "Volcano", base_attack_modifiers = new double[2] { 0.14, 1.3 }, attack_interval_modifiers = new double[1] { -1.1 } }
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Absinthe", ATK = 703,  INTERVAL = 1.6, ATKTYPE = AttackType.Arts, CLASS = "Caster", ARCHETYPE = "ST/Core" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", attack_multiplier_modifiers = new double[1] { 0.24 } },
                new Skills() { name = "Enforcement Mode", attack_multiplier_modifiers = new double[1] { 0.24 }, base_attack_modifiers = new double[1] { 0.9 } },
                new Skills() { name = "Ultimatum", attack_multiplier_modifiers = new double[2] { 0.24, 0.9 } } // burst of 4 attacks?

                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Nightmare", ATK = 692,  INTERVAL = 1.6, ATKTYPE = AttackType.Arts, CLASS = "Caster", ARCHETYPE = "ST/Core" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"},
                // new Skills() { name = "Drain Soul" }, // heals
                new Skills() { name = "Night Phantom", base_attack_modifiers = new double[1] { 0.15 }, extra_true_damage_done = new double[1] { 1200 } } // Passive if using skill 2, damage = tiles moved
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Amiya", ATK = 682,  INTERVAL = 1.6, ATKTYPE = AttackType.Arts, CLASS = "Caster", ARCHETYPE = "ST/Core" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"},
                new Skills() { name = "Tactical Chant γ", attack_speed_modifiers = new double[1] { 90 } },
                new Skills() { name = "Spirit Burst", attack_multiplier_modifiers = new double[1] { 0.6 } },
                new Skills() { name = "Chimera", base_attack_modifiers = new double[1] { 2.3 }, extra_true_damage_done = new double[1] { 682 } } // attack changes to true
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Haze", ATK = 643,  INTERVAL = 1.6, ATKTYPE = AttackType.Arts, CLASS = "Caster", ARCHETYPE = "ST/Core" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", scaling_res_modifiers = new double[1] { -0.23 } },
                new Skills() { name = "ATK Up β", base_attack_modifiers = new double[1] { 0.8 }, scaling_res_modifiers = new double[1] { -0.23 } },
                new Skills() { name = "Crimson Eyes", base_attack_modifiers = new double[1] { 0.6 }, attack_speed_modifiers = new double[1] { 60 }, scaling_res_modifiers = new double[1] { -0.23 } }
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Tomimi", ATK = 635,  INTERVAL = 1.6, ATKTYPE = AttackType.Physical, CLASS = "Caster", ARCHETYPE = "ST/Core" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"}, // Changed to physical for calc
                new Skills() { name = "Tribal Techniques", base_attack_modifiers = new double[1] { 1 }, attack_speed_modifiers = new double[1] { 90 } },
                new Skills() { name = "Gavial's Protection Plan", base_attack_modifiers = new double[1] { 1 }, attack_multiplier_modifiers = new double[1] { 2.2 } } // rng effect
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Steward", ATK = 520,  INTERVAL = 1.6, ATKTYPE = AttackType.Arts, CLASS = "Caster", ARCHETYPE = "ST/Core" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", base_attack_modifiers = new double[1] { 0.06 } },
                new Skills() { name = "Power Strike α", base_attack_modifiers = new double[1] { 0.06 }, attack_multiplier_modifiers = new double[1] { 1.9 } }
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Reserve Operator - Caster", ATK = 456,  INTERVAL = 1.6, ATKTYPE = AttackType.Arts, CLASS = "Caster", ARCHETYPE = "ST/Core" }, OperatorSkills = new Skills[] { new Skills() { } } },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Durin", ATK = 370,  INTERVAL = 1.6, ATKTYPE = AttackType.Arts, CLASS = "Caster", ARCHETYPE = "ST/Core" }, OperatorSkills = new Skills[] { new Skills() { } } },
            // new OperatorUnit() { OperatorStats = new Stats() { NAME = "Qanipalaat", ATK = ,  INTERVAL = 1.6, ATKTYPE = AttackType.Arts, CLASS = "Caster", ARCHETYPE = "ST/Core" }, OperatorSkills = new Skills[] { new Skills() { } } },

            // Burninator/Blast
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Ifrit", ATK = 980,  INTERVAL = 2.9, ATKTYPE = AttackType.Arts, CLASS = "Caster", ARCHETYPE = "Burninator/Blast" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", scaling_res_modifiers = new double[1] { -0.4 } },
                new Skills() { name = "Fanaticism", base_attack_modifiers = new double[1] { 0.2 }, attack_speed_modifiers = new double[1] { 80 }, scaling_res_modifiers = new double[1] { -0.4 } },
                new Skills() { name = "Pyroclasm", scaling_res_modifiers = new double[1] { -0.4 }, attack_multiplier_modifiers = new double[1] { 2.5 }, flat_def_modierifers = new double[1] { -300 } },
                new Skills() { name = "Scorched Earth", scaling_res_modifiers = new double[1] { -0.4 }, attack_multiplier_modifiers = new double[1] { 1.4 }, flat_res_modierifers = new double[1] { -20 } }
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Corroserum", ATK = 850,  INTERVAL = 2.9, ATKTYPE = AttackType.Arts, CLASS = "Caster", ARCHETYPE = "Burninator/Blast" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"},
                new Skills() { name = "Focus Overload", base_attack_modifiers = new double[1] { 1.35 } }, // BAD, SELF STUNS
                new Skills() { name = "Conductive Corrosive Blast", base_attack_modifiers = new double[1] { 1 } } // Utility Skill
                }
            },

            // -Medic-
            // Wide-Range/Therapist
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Lumen", ATK = 585,  INTERVAL = 2.85, ATKTYPE = AttackType.Healing, CLASS = "Medic", ARCHETYPE = "Wide-Range/Therapist" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"}, // Heals on status gain
                new Skills() { name = "Rainfall", attack_multiplier_modifiers = new double[1] { 0.55 } },
                new Skills() { name = "Downpour", attack_multiplier_modifiers = new double[1] { 2.6 } },
                new Skills() { name = "Inextinguishable Light", base_attack_modifiers = new double[1] { 0.55 }, attack_speed_modifiers = new double[1] { 30 } }
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Whisperain", ATK = 532,  INTERVAL = 2.85, ATKTYPE = AttackType.Healing, CLASS = "Medic", ARCHETYPE = "Wide-Range/Therapist" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"}, // Heals those with status
                new Skills() { name = "Oriented Diagnosis", attack_multiplier_modifiers = new double[1] { 1.3 } },
                new Skills() { name = "Pain Suppression", attack_interval_modifiers = new double[1] { -0.2 } } // Increases talent
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Ceylon", ATK = 508,  INTERVAL = 2.85, ATKTYPE = AttackType.Healing, CLASS = "Medic", ARCHETYPE = "Wide-Range/Therapist" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", base_attack_modifiers = new double[1] { 0.05 } },
                new Skills() { name = "Concentrated Hydrotherapy", base_attack_modifiers = new double[1] { 0.05 }, attack_multiplier_modifiers = new double[1] { 2 } },
                new Skills() { name = "Water Blessing", base_attack_modifiers = new double[2] { 0.05 , 0.6 } }
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Purestream", ATK = 489,  INTERVAL = 2.85, ATKTYPE = AttackType.Healing, CLASS = "Medic", ARCHETYPE = "Wide-Range/Therapist" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"},
                new Skills() { name = "Healing Waves", attack_multiplier_modifiers = new double[1] { 3.5 } },
                new Skills() { name = "Lifespring", attack_interval_modifiers = new double[1] { 0.12 }, attack_multiplier_modifiers = new double[1] { 0.5 } }
                }
            },

            // ST
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Shining", ATK = 610,  INTERVAL = 2.85, ATKTYPE = AttackType.Healing, CLASS = "Medic", ARCHETYPE = "ST" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", attack_speed_modifiers = new double[1] { 10 } }, // Grants 60 DEF to allies
                new Skills() { name = "Creed", attack_speed_modifiers = new double[2] { 10, 20 }, base_attack_modifiers = new double[1] { 0.8 } },
                // new Skills() { name = "Auto Protect", attack_speed_modifiers = new double[1] { 10 } }, // Grants HUGE shield
                new Skills() { name = "Creed Field", attack_speed_modifiers = new double[1] { 10 }, base_attack_modifiers = new double[1] { 0.5 } } // grants DEF
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Touch", ATK = 595,  INTERVAL = 2.85, ATKTYPE = AttackType.Healing, CLASS = "Medic", ARCHETYPE = "ST" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"},
                new Skills() { name = "Apocalyptic Scene", base_attack_modifiers = new double[1] { 0.3 } } // grants to all medics
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Warfarin", ATK = 580,  INTERVAL = 2.85, ATKTYPE = AttackType.Healing, CLASS = "Medic", ARCHETYPE = "ST" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"},
                new Skills() { name = "Emergency Triage", base_attack_modifiers = new double[1] { 0.25 } }, // 25% targets max HP
                new Skills() { name = "Unstable Plasma", base_attack_modifiers = new double[1] { 0.9 } } // ATK boost to ally, costs hp
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Tuye", ATK = 568,  INTERVAL = 2.85, ATKTYPE = AttackType.Healing, CLASS = "Medic", ARCHETYPE = "ST" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", attack_multiplier_modifiers = new double[1] { 1.5 } }, // if not heal for 4 sec
                // new Skills() { name = "Aqua Loop" }, // grants shield
                new Skills() { name = "Cardiac Stimulant", base_attack_modifiers = new double[1] { 0.6 } } // 300% extra heal if below 20% hp, surtur pairing
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Silence", ATK = 557,  INTERVAL = 2.85, ATKTYPE = AttackType.Healing, CLASS = "Medic", ARCHETYPE = "ST" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", attack_speed_modifiers = new double[1] { 12 } },
                new Skills() { name = "Healing Up γ", attack_speed_modifiers = new double[1] { 12 }, base_attack_modifiers = new double[1] { 0.9 } },
                new Skills() { name = "Medical Drone", attack_speed_modifiers = new double[1] { 12 } } // Medical drones
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Sussurro", ATK = 548,  INTERVAL = 2.85, ATKTYPE = AttackType.Healing, CLASS = "Medic", ARCHETYPE = "ST" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"}, // 20% heal on cheap operators (diregarding as most are >10DP)
                new Skills() { name = "Healing Up β", base_attack_modifiers = new double[1] { 0.7 } },
                new Skills() { name = "Deep Healing", base_attack_modifiers = new double[1] { 1 }, attack_speed_modifiers = new double[1] { 100 } }
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Folinic", ATK = 529,  INTERVAL = 2.85, ATKTYPE = AttackType.Healing, CLASS = "Medic", ARCHETYPE = "ST" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"}, // Resists environmental damage? IS2 stages?
                new Skills() { name = "Max-Dosage Infusion", base_attack_modifiers = new double[1] { 0.8 } },
                new Skills() { name = "Compound Drug Shell", attack_multiplier_modifiers = new double[1] { 1.5 }, extra_arts_damage_done = new double[1] { 1058 } } // deals 200% arts
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Myrrh", ATK = 525,  INTERVAL = 2.85, ATKTYPE = AttackType.Healing, CLASS = "Medic", ARCHETYPE = "ST" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", attack_multiplier_modifiers = new double[1] { 1.6 } }, // heals all for 160% ATK on deploy
                new Skills() { name = "Dual Healing", attack_multiplier_modifiers = new double[1] { 1 } },
                new Skills() { name = "Medic Field", base_attack_modifiers = new double[1] { 0.05 } } // can heal +1 target
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Kal'tsit", ATK = 490,  INTERVAL = 2.85, ATKTYPE = AttackType.Healing, CLASS = "Medic", ARCHETYPE = "ST" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", extra_true_damage_done = new double[1] { 1200 } }, // true damage on Mon3tr's death, Mon3tr Summon
                new Skills() { name = "Command: Structural Fortification", extra_phys_damage_done = new double[1] { 1402 } }, // Utility Skill, calc Mon3tr here
                new Skills() { name = "Command: Tactical Coordination", attack_speed_modifiers = new double[1] { 100 }, extra_phys_damage_done = new double[1] { 2663.8 } }, // +20% buff to Mon3tr 
                new Skills() { name = "Command: Meltdown", extra_true_damage_done = new double[1] { 5047.2 } } // +260% buff to Mon3tr (NOW DOES TRUE DAMAGE) WTF
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Gavial", ATK = 480,  INTERVAL = 2.85, ATKTYPE = AttackType.Healing, CLASS = "Medic", ARCHETYPE = "ST" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", base_attack_modifiers = new double[1] { 0.12 } }, // buff on deploy
                new Skills() { name = "Vitality Restoration", attack_multiplier_modifiers = new double[1] { 0.35 } }, // 1 target
                new Skills() { name = "Vitality Restoration - Wide Range", attack_multiplier_modifiers = new double[1] { 0.3 } } // all in range
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Ansel", ATK = 407,  INTERVAL = 2.85, ATKTYPE = AttackType.Healing, CLASS = "Medic", ARCHETYPE = "ST" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"},
                new Skills() { name = "Healing Range Up", base_attack_modifiers = new double[1] { 0.4 } }
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Hibiscus", ATK = 390,  INTERVAL = 2.85, ATKTYPE = AttackType.Healing, CLASS = "Medic", ARCHETYPE = "ST" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", base_attack_modifiers = new double[1] { 0.08 } },
                new Skills() { name = "Healing Up α", base_attack_modifiers = new double[2] { 0.08, 0.5 } }
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Reserve Operator - Logistics", ATK = 338,  INTERVAL = 2.85, ATKTYPE = AttackType.Healing, CLASS = "Medic", ARCHETYPE = "ST" }, OperatorSkills = new Skills[] { new Skills() { } } },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Lancet-2", ATK = 110,  INTERVAL = 2.85, ATKTYPE = AttackType.Healing, CLASS = "Medic", ARCHETYPE = "ST" }, OperatorSkills = new Skills[] { new Skills() { } } },

            // AoE/Multi-target
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Nightingale", ATK = 420,  INTERVAL = 2.85, ATKTYPE = AttackType.Healing, CLASS = "Medic", ARCHETYPE = "AoE/Multi-target" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"}, // Phantom Summon 
                new Skills() { name = "Healing Up γ", base_attack_modifiers = new double[1] { 0.9 } },
                // new Skills() { name = "Arts Shield", }, // Utility Skill
                new Skills() { name = "Sanctuary", base_attack_modifiers = new double[1] { 0.8 }  }
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Ptilopsis", ATK = 390,  INTERVAL = 2.85, ATKTYPE = AttackType.Healing, CLASS = "Medic", ARCHETYPE = "AoE/Multi-target" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"},
                new Skills() { name = "Healing Up γ", base_attack_modifiers = new double[1] { 0.9 } },
                new Skills() { name = "Enkephalin", attack_interval_modifiers = new double[1] { -2.1 } }
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Breeze", ATK = 373,  INTERVAL = 2.85, ATKTYPE = AttackType.Healing, CLASS = "Medic", ARCHETYPE = "AoE/Multi-target" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"},
                new Skills() { name = "Cluster Therapy", base_attack_modifiers = new double[1] { 1.4 } },
                new Skills() { name = "Widespread Therapy", base_attack_modifiers = new double[1] { 2.5 }  }
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Perfumer", ATK = 345,  INTERVAL = 2.85, ATKTYPE = AttackType.Healing, CLASS = "Medic", ARCHETYPE = "AoE/Multi-target" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"}, // Passive heals 5.5% ATK
                new Skills() { name = "Healing Up β", base_attack_modifiers = new double[1] { 0.7 } },
                new Skills() { name = "Fine Blending", base_attack_modifiers = new double[1] { 2.5 }, attack_speed_modifiers = new double[1] { -50 } }
                }
            },

            // Chain
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Paprika", ATK = 489,  INTERVAL = 2.85, ATKTYPE = AttackType.Healing, CLASS = "Medic", ARCHETYPE = "Chain" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"}, // Heals extra 140 if target <40% HP
                new Skills() { name = "Protective Combat·Type γ", attack_speed_modifiers = new double[1] { 85 } },
                new Skills() { name = "Comradeship", base_attack_modifiers = new double[1] { 0.7 } } // Heals extra 140 if target <80% HP
                }
            },

            // Incantation
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Hibiscus the Purifier", ATK = 571,  INTERVAL = 1.6, ATKTYPE = AttackType.Arts, CLASS = "Medic", ARCHETYPE = "Incantation" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", arts_taken_modifiers = new double[1] { 0.12 } }, // Heals 50% arts damage dealt
                new Skills() { name = "ATK Up γ", base_attack_modifiers = new double[1] { 1 } }, // Heals 50% arts damage dealt
                new Skills() { name = "Nurturing Touch", attack_multiplier_modifiers = new double[1] { 1.7 } } // Heals 50% arts damage dealt
                }
            },

            // Wandering
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Chestnut", ATK = 424,  INTERVAL = 2.85, ATKTYPE = AttackType.Healing, CLASS = "Medic", ARCHETYPE = "Wandering" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"},
                // new Skills() { name = "Little by Little" }, // Elemental heal?
                new Skills() { name = "Rising Earth", attack_speed_modifiers = new double[1] { 130 }, attack_multiplier_modifiers = new double[1] { 1.5 } } // Increase if heals same target
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Mulberry", ATK = 423,  INTERVAL = 2.85, ATKTYPE = AttackType.Healing, CLASS = "Medic", ARCHETYPE = "Wandering" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", base_attack_modifiers = new double[1] { 0.1 } }, // medic buff if 1 other on field
                new Skills() { name = "Healing Haze", base_attack_modifiers = new double[1] { 0.1 }, attack_multiplier_modifiers = new double[1] { 1.8 } },
                new Skills() { name = "Safe Zone", base_attack_modifiers = new double[1] { 0.1 }, attack_interval_modifiers = new double[1] { -0.26 } } // Elemental Resist
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Honeyberry", ATK = 410,  INTERVAL = 2.85, ATKTYPE = AttackType.Healing, CLASS = "Medic", ARCHETYPE = "Wandering" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"}, // Gants HP
                // new Skills() { name = "Spiritual Care", }, // Utility Skill
                new Skills() { name = "Rouse", base_attack_modifiers = new double[1] { 0.5 } }
                }
            },

            // -Defender-  // Need to add DEF calculations in future
            // Enmity/Juggernaut
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Mudrock", ATK = 882,  INTERVAL = 1.6, ATKTYPE = AttackType.Physical, CLASS = "Defender", ARCHETYPE = "Enmity/Juggernaut" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"},
                // new Skills() { name = "DEF Up γ" }, // DEF Skill
                new Skills() { name = "Crag Splitter", attack_multiplier_modifiers = new double[1] { 2.7 } },
                new Skills() { name = "Bloodline of Desecrated Earth", attack_interval_modifiers = new double[1] { -0.3 }, base_attack_modifiers = new double[1] { 1.4 } }
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Vulcan", ATK = 870,  INTERVAL = 1.6, ATKTYPE = AttackType.Physical, CLASS = "Defender", ARCHETYPE = "Enmity/Juggernaut" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"},
                // new Skills() { name = "Guardian Mode" }, // DEF Skill
                new Skills() { name = "Combat Mode", attack_interval_modifiers = new double[1] { 0.4 }, base_attack_modifiers = new double[1] { 1.5 } }
                }
            },
            // new OperatorUnit() { OperatorStats = new Stats() { NAME = "Penance", ATK = ,  INTERVAL = 1.6, ATKTYPE = AttackType.Physical, CLASS = "Defender", ARCHETYPE = "Enmity/Juggernaut" }, OperatorSkills = new Skills[] {
            //    new Skills() { name = "Passive"}
            //    }
            // },

            // Fortress
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Horn", ATK = 1006,  INTERVAL = 2.8, ATKTYPE = AttackType.Physical, CLASS = "Defender", ARCHETYPE = "Fortress" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", base_attack_modifiers = new double[1] { 0.2 }, attack_speed_modifiers = new double[1] { 18 } }, // Buff Defenders ATK 20%, speed buff instead of retreat once
                new Skills() { name = "Flare Grenade", base_attack_modifiers = new double[1] { 0.2 }, attack_speed_modifiers = new double[1] { 18 }, attack_multiplier_modifiers = new double[1] { 2.8 } },
                new Skills() { name = "Tempest Command", base_attack_modifiers = new double[1] { 0.2 }, attack_speed_modifiers = new double[1] { 18 }, attack_multiplier_modifiers = new double[1] { 2.4 }, extra_arts_damage_done = new double[1] { 603.6 } }, // 60% arts Overdrive
                new Skills() { name = "Ultimate Line of Defense", base_attack_modifiers = new double[2] { 0.2, 1.4 }, attack_speed_modifiers = new double[1] { 18 }, attack_interval_modifiers = new double[1] { -1.8 } } // +70% normally, +140% Overdrive
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Ashlock", ATK = 915,  INTERVAL = 2.8, ATKTYPE = AttackType.Physical, CLASS = "Defender", ARCHETYPE = "Fortress" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", base_attack_modifiers = new double[1] { 0.16 } }, // Buff when surrounded by ground tiles
                new Skills() { name = "ATK Up γ", base_attack_modifiers = new double[2] { 0.16, 1 } },
                new Skills() { name = "Focused Bombardment", base_attack_modifiers = new double[2] { 0.16, 0.55 }, attack_interval_modifiers = new double[1] { -0.65 } }
                }
            },

            // Healing/Guardian // Changed Damage to Healing for most calculations
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Blemishine", ATK = 581,  INTERVAL = 1.2, ATKTYPE = AttackType.Physical, CLASS = "Defender", ARCHETYPE = "Healing/Guardian" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", attack_multiplier_modifiers = new double[1] { 1.4 } }, // 140% Attack vs sleeping targets
                new Skills() { name = "Surging Brilliance", attack_multiplier_modifiers = new double[1] { 2.6 } }, // Assume not sleeping
                new Skills() { name = "Deterring Radiance", attack_multiplier_modifiers = new double[1] { 1.4 }, base_attack_modifiers = new double[1] { 1.1 } }, // Assume sleeping due to Utility
                new Skills() { name = "Divine Avatar", base_attack_modifiers = new double[1] { 1.1 }, extra_arts_damage_done = new double[1] { 581 } } // 100% arts, Assume not sleeping
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Saria", ATK = 535,  INTERVAL = 1.2, ATKTYPE = AttackType.Healing, CLASS = "Defender", ARCHETYPE = "Healing/Guardian" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", base_attack_modifiers = new double[1] { 0.25 } }, // full buff after 60 seconds
                new Skills() { name = "First Aid", base_attack_modifiers = new double[1] { 0.25 }, attack_multiplier_modifiers = new double[1] { 1.8 } }, // 1 target
                new Skills() { name = "Medicine Dispensing", base_attack_modifiers = new double[1] { 0.25 }, attack_multiplier_modifiers = new double[1] { 1.4 } }, // all in range
                new Skills() { name = "Calcification", base_attack_modifiers = new double[1] { 0.25 }, attack_multiplier_modifiers = new double[1] { 0.35 }, arts_taken_modifiers = new double[1] { 0.55 } } // Utility
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Nearl", ATK = 502,  INTERVAL = 1.2, ATKTYPE = AttackType.Healing, CLASS = "Defender", ARCHETYPE = "Healing/Guardian" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"},
                new Skills() { name = "First Aid", attack_multiplier_modifiers = new double[1] { 1.8 } },
                new Skills() { name = "First Aid Mode", base_attack_modifiers = new double[1] { 0.8 } } // Utility Skill
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Hung", ATK = 442,  INTERVAL = 1.2, ATKTYPE = AttackType.Healing, CLASS = "Defender", ARCHETYPE = "Healing/Guardian" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"},
                new Skills() { name = "Treatment Countermeasure", attack_multiplier_modifiers = new double[1] { 1.7 } },
                new Skills() { name = "Medical Mode Countermeasure", base_attack_modifiers = new double[1] { 0.8 } } // Utility Skill
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Gummy", ATK = 435,  INTERVAL = 1.2, ATKTYPE = AttackType.Healing, CLASS = "Defender", ARCHETYPE = "Healing/Guardian" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"}, // Ignoring her great 200% damage + stun rng passive TwT (focusing on heals)
                new Skills() { name = "Provisions", attack_multiplier_modifiers = new double[1] { 1.6 } },
                new Skills() { name = "Cooking", base_attack_modifiers = new double[1] { 0.8 } }
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Spot", ATK = 350,  INTERVAL = 1.2, ATKTYPE = AttackType.Healing, CLASS = "Defender", ARCHETYPE = "Healing/Guardian" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"},
                new Skills() { name = "Secondary Healing Mode", base_attack_modifiers = new double[1] { 0.45 } }
                }
            },

            // Duelist
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Eunectes", ATK = 1077,  INTERVAL = 1.6, ATKTYPE = AttackType.Physical, CLASS = "Defender", ARCHETYPE = "Duelist" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", attack_multiplier_modifiers = new double[1] { 1.15 } }, // atacks deal 115% when >50% HP 
                new Skills() { name = "Tomahawk", attack_multiplier_modifiers = new double[1] { 1.15 }, base_attack_modifiers = new double[1] { 0.25 } },
                new Skills() { name = "Menacing Slash", attack_multiplier_modifiers = new double[1] { 1.15 }, attack_interval_modifiers = new double[1] { 0.4 }, base_attack_modifiers = new double[1] { 1.8 } },
                new Skills() { name = "Iron Will", attack_multiplier_modifiers = new double[1] { 1.15 }, base_attack_modifiers = new double[1] { 2.3 } } // DEF Skill
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Aurora", ATK = 956,  INTERVAL = 1.6, ATKTYPE = AttackType.Physical, CLASS = "Defender", ARCHETYPE = "Duelist" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"},
                // new Skills() { name = "Homeland Protector" }, // Utility Skill
                new Skills() { name = "Artificial Snowfall", attack_interval_modifiers = new double[1] { 0.25 }, base_attack_modifiers = new double[1] { 0.75 }, attack_multiplier_modifiers = new double[1] { 3.3 } } // 330% if frozen status on enemy
                }
            },

            // Normal/Protector
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Nian", ATK = 619,  INTERVAL = 1.2, ATKTYPE = AttackType.Physical, CLASS = "Defender", ARCHETYPE = "Normal/Protector" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"},
                new Skills() { name = "Tin Burning", base_attack_modifiers = new double[1] { 0.45 }, extra_arts_damage_done = new double[1] { 619 } }, // Changes to Arts
                new Skills() { name = "Copper Seal", extra_arts_damage_done = new double[1] { 557.1 } }, // Deals 90% arts to attackers
                new Skills() { name = "Iron Defense", base_attack_modifiers = new double[1] { 1.2 } } // DEF Skill
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Hoshiguma", ATK = 490,  INTERVAL = 1.2, ATKTYPE = AttackType.Physical, CLASS = "Defender", ARCHETYPE = "Normal/Protector" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"},
                new Skills() { name = "Warpath", base_attack_modifiers = new double[1] { 0.4 } },
                new Skills() { name = "Thorns", attack_multiplier_modifiers = new double[1] { 1 } }, // Deals 100% phys to attackers (*even global archers)
                new Skills() { name = "Saw of Strength", base_attack_modifiers = new double[1] { 1.4 } }
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Blitz", ATK = 490,  INTERVAL = 1.2, ATKTYPE = AttackType.Physical, CLASS = "Defender", ARCHETYPE = "Normal/Protector" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", attack_multiplier_modifiers = new double[1] { 1.6 } }, // Deals 160% to stunned enemeies
                new Skills() { name = "Flash Shield", attack_multiplier_modifiers = new double[1] { 1.6 } }, // Utility Skill, stuns
                new Skills() { name = "Shield Bash", attack_multiplier_modifiers = new double[2] { 2.4, 2 }, attack_speed_modifiers = new double[1] { 200 } } // Utility Skill, stuns
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Liskarm", ATK = 470,  INTERVAL = 1.2, ATKTYPE = AttackType.Arts, CLASS = "Defender", ARCHETYPE = "Normal/Protector" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"}, // Changed to arts for easy S2 Calc
                // new Skills() { name = "Charged Defense" }, // DEF Skill
                new Skills() { name = "Counter Arc", attack_interval_modifiers = new double[1] { 1.7 }, base_attack_modifiers = new double[1] { 2 } } // SELF STUNS
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Croissant", ATK = 380,  INTERVAL = 1.2, ATKTYPE = AttackType.Physical, CLASS = "Defender", ARCHETYPE = "Normal/Protector" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"},
                // new Skills() { name = "Auto Defense" }, // DEF Skill
                new Skills() { name = "Magnetic Hammer", attack_multiplier_modifiers = new double[1] { 4.8 } }
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Heavyrain", ATK = 378,  INTERVAL = 1.2, ATKTYPE = AttackType.Physical, CLASS = "Defender", ARCHETYPE = "Normal/Protector" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"},
                // new Skills() { name = "Emergency Camouflage" }, // Utility Skill
                // new Skills() { name = "Group Camouflage", } // Utility Skill
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Matterhorn", ATK = 375,  INTERVAL = 1.2, ATKTYPE = AttackType.Physical, CLASS = "Defender", ARCHETYPE = "Normal/Protector" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"},
                // new Skills() { name = "Stamina Enhancement" }, // DEF Skill
                // new Skills() { name = "Cold Resistance", } // DEF Skill
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Bison", ATK = 375,  INTERVAL = 1.2, ATKTYPE = AttackType.Physical, CLASS = "Defender", ARCHETYPE = "Normal/Protector" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"},
                // new Skills() { name = "DEF Up γ" }, // DEF Skill
                // new Skills() { name = "Intensified Defense", } // DEF Skill
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Bubble", ATK = 370,  INTERVAL = 1.2, ATKTYPE = AttackType.Physical, CLASS = "Defender", ARCHETYPE = "Normal/Protector" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"},
                // new Skills() { name = "DEF Up β" }, // DEF Skill
                new Skills() { name = "Beaten Up", extra_phys_damage_done = new double[1] { 432 } } // Deals 50% DEF as phys (DEF=720*1.2=864)
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Cuora", ATK = 365,  INTERVAL = 1.2, ATKTYPE = AttackType.Physical, CLASS = "Defender", ARCHETYPE = "Normal/Protector" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"} // DEF Skills
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Cardigan", ATK = 305,  INTERVAL = 1.2, ATKTYPE = AttackType.Physical, CLASS = "Defender", ARCHETYPE = "Normal/Protector" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"} // DEF Skill
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Beagle", ATK = 295,  INTERVAL = 1.2, ATKTYPE = AttackType.Physical, CLASS = "Defender", ARCHETYPE = "Normal/Protector" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"} // DEF Skill
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Noir Corne", ATK = 240,  INTERVAL = 1.2, ATKTYPE = AttackType.Physical, CLASS = "Defender", ARCHETYPE = "Normal/Protector" }, OperatorSkills = new Skills[] { new Skills() { } } },

            // Arts Protector
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Shalem", ATK = 729,  INTERVAL = 1.6, ATKTYPE = AttackType.Physical, CLASS = "Defender", ARCHETYPE = "Arts Protector" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", scaling_res_modifiers = new double[1] { -0.25 } },
                new Skills() { name = "Rapid Onslaught", scaling_res_modifiers = new double[1] { -0.25 }, attack_interval_modifiers = new double[1] { -0.15 } },
                new Skills() { name = "Carnival of Self-Immolation", scaling_res_modifiers = new double[1] { -0.25 }, attack_multiplier_modifiers = new double[1] { 0.55 } } // attacks 4 times?
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Asbestos", ATK = 673,  INTERVAL = 1.6, ATKTYPE = AttackType.Physical, CLASS = "Defender", ARCHETYPE = "Arts Protector" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"},
                // new Skills() { name = "Resilient Mode" }, // DEF Skill
                new Skills() { name = "Thermal Power Mode", attack_interval_modifiers = new double[1] { 0.4 }, base_attack_modifiers = new double[1] { 0.9 } }
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Czerny", ATK = 665,  INTERVAL = 1.6, ATKTYPE = AttackType.Physical, CLASS = "Defender", ARCHETYPE = "Arts Protector" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", extra_arts_damage_done = new double[1] { 532 } }, // 80% arts when attacked
                new Skills() { name = "Dancing Fingers", base_attack_modifiers = new double[1] { 0.8 } },
                new Skills() { name = "Astounding Performance", base_attack_modifiers = new double[1] { 3 }, extra_arts_damage_done = new double[1] { 1662.5 } } // if attacked 10 times, deals 250% arts
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Dur-nar", ATK = 648,  INTERVAL = 1.6, ATKTYPE = AttackType.Physical, CLASS = "Defender", ARCHETYPE = "Arts Protector" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", base_attack_modifiers = new double[1] { 0.07 } },
                new Skills() { name = "ATK Up β", base_attack_modifiers = new double[2] { 0.07, 0.8 } },
                new Skills() { name = "Shielded Counterattack", base_attack_modifiers = new double[2] { 0.07, 0.8 } } // attack more targets
                }
            },

            // -Vanguard-
            // Summoner/Tactician
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Blacknight", ATK = 502,  INTERVAL = 1, ATKTYPE = AttackType.Physical, CLASS = "Vanguard", ARCHETYPE = "Summoner/Tactician" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", attack_multiplier_modifiers = new double[1] { 1.5 }, extra_phys_damage_done = new double[1] { 474 } }, // 150% ATK when target enemy blocked by summon, Slumberfoot Summon
                new Skills() { name = "Drowsy", attack_speed_modifiers = new double[1] { 55 }, extra_phys_damage_done = new double[1] { 734.7 } }, // Slumberfoot Summon, +55% ATK and 55 speed
                new Skills() { name = "Peaceful Slumber", extra_arts_damage_done = new double[1] { 995.4 } } // Slumberfoot Summon, 210% arts
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Beanstalk", ATK = 455,  INTERVAL = 1, ATKTYPE = AttackType.Physical, CLASS = "Vanguard", ARCHETYPE = "Summoner/Tactician" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", attack_multiplier_modifiers = new double[1] { 1.5 }, extra_phys_damage_done = new double[1] { 405 } }, // 150% ATK when target enemy blocked by summon, Metal Crab Summon
                // new Skills() { name = "Sentinel Command" }, // Utility Skill
                new Skills() { name = "Everyone Together!", extra_phys_damage_done = new double[1] { 810 } } // Utility Skill, Summons multiple metal crabs, assuming 2 crabs attack same target for calc
                }
            },
            // new OperatorUnit() { OperatorStats = new Stats() { NAME = "Vigil", ATK = ,  INTERVAL = 1, ATKTYPE = AttackType.Physical, CLASS = "Vanguard", ARCHETYPE = "Summoner/Tactician" }, OperatorSkills = new Skills[] {
            //    new Skills() { name = "Passive"},
            //    }
            // },

            // Skill-DP/Pioneer
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Saga", ATK = 615,  INTERVAL = 1.05, ATKTYPE = AttackType.Physical, CLASS = "Vanguard", ARCHETYPE = "Skill-DP/Pioneer" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive" }, // Can't kill targets
                // new Skills() { name = "Charge γ" }, // Utility Skill
                new Skills() { name = "Cleansing Evil", attack_multiplier_modifiers = new double[1] { 4 } },
                new Skills() { name = "Fierce Glare", attack_interval_modifiers = new double[1] { 0.5 }, base_attack_modifiers = new double[1] { 1.3 } }
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Flametail", ATK = 611,  INTERVAL = 1.05, ATKTYPE = AttackType.Physical, CLASS = "Vanguard", ARCHETYPE = "Skill-DP/Pioneer" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"},
                // new Skills() { name = "Quick Intuition" }, // Utility Skill
                new Skills() { name = "Pinus Sylvestris", attack_multiplier_modifiers = new double[1] { 2.4 }, extra_phys_damage_done = new double[1] { 611 } }, // attacks twice
                new Skills() { name = "Flameheart", attack_interval_modifiers = new double[1] { -0.7 }, base_attack_modifiers = new double[1] { 0.9 } } // Gets Dodge
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Chiave", ATK = 592,  INTERVAL = 1.05, ATKTYPE = AttackType.Physical, CLASS = "Vanguard", ARCHETYPE = "Skill-DP/Pioneer" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"}, // Benefits from having robot on field
                // new Skills() { name = "" },
                new Skills() { name = "Blazing Wire Stripper", extra_arts_damage_done = new double[1] { 2072 }, scaling_res_modifiers = new double[1] { -0.2 } } // 350% arts
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Siege", ATK = 575,  INTERVAL = 1.05, ATKTYPE = AttackType.Physical, CLASS = "Vanguard", ARCHETYPE = "Skill-DP/Pioneer" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", base_attack_modifiers = new double[1] { 0.08 } }, // +8% ATK to all Vanguards
                // new Skills() { name = "" },
                new Skills() { name = "Aerial Hammer", attack_multiplier_modifiers = new double[1] { 3.4 } },
                new Skills() { name = "Skull Breaker", attack_interval_modifiers = new double[1] { 1 }, attack_multiplier_modifiers = new double[1] { 3.8 } } // Utility Skill
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Texas", ATK = 570,  INTERVAL = 1.05, ATKTYPE = AttackType.Physical, CLASS = "Vanguard", ARCHETYPE = "Skill-DP/Pioneer" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"},
                // new Skills() { name = "" },
                new Skills() { name = "Sword Rain", extra_arts_damage_done = new double[1] { 1938 } } // 170% arts, twice (340% for easy calc)
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Scavenger", ATK = 530,  INTERVAL = 1.05, ATKTYPE = AttackType.Physical, CLASS = "Vanguard", ARCHETYPE = "Skill-DP/Pioneer" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", base_attack_modifiers = new double[1] { 0.11 } }, // Buff when no allies near
                // new Skills() { name = "" },
                new Skills() { name = "Command - Attack", base_attack_modifiers = new double[2] { 0.11, 0.7 } }
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Zima", ATK = 470,  INTERVAL = 1.05, ATKTYPE = AttackType.Physical, CLASS = "Vanguard", ARCHETYPE = "Skill-DP/Pioneer" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"},
                // new Skills() { name = "" },
                new Skills() { name = "Ursus's Roar", base_attack_modifiers = new double[1] { 0.6 } }
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Courier", ATK = 435,  INTERVAL = 1.05, ATKTYPE = AttackType.Physical, CLASS = "Vanguard", ARCHETYPE = "Skill-DP/Pioneer" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"},
                // new Skills() { name = "" },
                // new Skills() { name = "", } // DEF Skill
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Vanilla", ATK = 405,  INTERVAL = 1.05, ATKTYPE = AttackType.Physical, CLASS = "Vanguard", ARCHETYPE = "Skill-DP/Pioneer" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", base_attack_modifiers = new double[1] { 0.08 } },
                // new Skills() { name = "" },
                new Skills() { name = "Command - Reinforcement", base_attack_modifiers = new double[2] { 0.08, 0.35 } }
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Fang", ATK = 325,  INTERVAL = 1.05, ATKTYPE = AttackType.Physical, CLASS = "Vanguard", ARCHETYPE = "Skill-DP/Pioneer" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"},
                // new Skills() { name = "" }
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Reserve Operator - Melee", ATK = 309,  INTERVAL = 1.05, ATKTYPE = AttackType.Physical, CLASS = "Vanguard", ARCHETYPE = "Skill-DP/Pioneer" }, OperatorSkills = new Skills[] { new Skills() { } } },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Yato", ATK = 262,  INTERVAL = 1.05, ATKTYPE = AttackType.Physical, CLASS = "Vanguard", ARCHETYPE = "Skill-DP/Pioneer" }, OperatorSkills = new Skills[] { new Skills() { } } },

            // Flagbearer/Standard Bearer
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Saileach", ATK = 586,  INTERVAL = 1.3, ATKTYPE = AttackType.Physical, CLASS = "Vanguard", ARCHETYPE = "Flagbearer/Standard Bearer" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", attack_speed_modifiers = new double[1] { 10 } }, // Deploys with banner, banner gives 10 speed
                // new Skills() { name = "Support γ", attack_speed_modifiers = new double[1] { 10 } }, // DP Gen
                new Skills() { name = "Inheritance of Faith", attack_speed_modifiers = new double[1] { 10 } }, // Utility Skill, heals
                new Skills() { name = "Glorious Banner", attack_speed_modifiers = new double[1] { 10 }, attack_multiplier_modifiers = new double[1] { 3 }, phys_taken_modifiers = new double[1] { 0.3 } } // 300% phys and 30% fragile
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Elysium", ATK = 533,  INTERVAL = 1.3, ATKTYPE = AttackType.Physical, CLASS = "Vanguard", ARCHETYPE = "Flagbearer/Standard Bearer" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"},
                new Skills() { name = "Support γ", attack_speed_modifiers = new double[1] { 20 } }, // buffs snipers speed
                new Skills() { name = "Monitor", attack_speed_modifiers = new double[1] { 20 }, scaling_def_modifiers = new double[1] { -0.35 } } // Utility, buffs snipers speed
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Myrtle", ATK = 520,  INTERVAL = 1.3, ATKTYPE = AttackType.Physical, CLASS = "Vanguard", ARCHETYPE = "Flagbearer/Standard Bearer" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"}, // All Vanguards heal 25 per sec
                // new Skills() { name = "Support β" }, // DP Gen
                // new Skills() { name = "Healing Wings", } // Heals 260 per sec
                }
            },

            // DP-On-Kill/Charger
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Bagpipe", ATK = 671,  INTERVAL = 1, ATKTYPE = AttackType.Physical, CLASS = "Vanguard", ARCHETYPE = "DP-On-Kill/Charger" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", attack_multiplier_modifiers = new double[1] { 1.3 } }, // Chance to deal 130% phys
                new Skills() { name = "Swift Strike γ", base_attack_modifiers = new double[1] { 0.45 }, attack_speed_modifiers = new double[1] { 45 } },
                new Skills() { name = "High-Impact Assault", attack_multiplier_modifiers = new double[2] { 1.3, 2 } },
                new Skills() { name = "Locked Breech Burst", attack_multiplier_modifiers = new double[1] { 1.3 }, attack_interval_modifiers = new double[1] { 0.7 }, base_attack_modifiers = new double[1] { 1.2 }, extra_phys_damage_done = new double[2] { 671, 671 } } // Hits 3 times?
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Reed", ATK = 632,  INTERVAL = 1, ATKTYPE = AttackType.Physical, CLASS = "Vanguard", ARCHETYPE = "DP-On-Kill/Charger" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"},
                new Skills() { name = "Swift Strike γ", base_attack_modifiers = new double[1] { 0.45 }, attack_speed_modifiers = new double[1] { 45 } },
                new Skills() { name = "Soul Spark", base_attack_modifiers = new double[1] { 0.8 }, extra_arts_damage_done = new double[1] { 221.2 } } // 35% arts
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Wild Mane", ATK = 628,  INTERVAL = 1, ATKTYPE = AttackType.Physical, CLASS = "Vanguard", ARCHETYPE = "DP-On-Kill/Charger" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"},
                new Skills() { name = "Stabbing Lance", attack_speed_modifiers = new double[1] { 135 } },
                new Skills() { name = "Lance Charge", base_attack_modifiers = new double[1] { 0.8 } }
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Vigna", ATK = 618,  INTERVAL = 1, ATKTYPE = AttackType.Physical, CLASS = "Vanguard", ARCHETYPE = "DP-On-Kill/Charger" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", attack_multiplier_modifiers = new double[1] { 1 } }, // Chance to deal 100%
                new Skills() { name = "ATK Up β", attack_multiplier_modifiers = new double[1] { 1 }, base_attack_modifiers = new double[1] { 0.8 } },
                new Skills() { name = "Hammer-On", attack_multiplier_modifiers = new double[1] { 1 }, base_attack_modifiers = new double[1] { 2 }, attack_interval_modifiers = new double[1] { 0.5 } }
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Grani", ATK = 552,  INTERVAL = 1, ATKTYPE = AttackType.Physical, CLASS = "Vanguard", ARCHETYPE = "DP-On-Kill/Charger" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"}, // Grants dodge
                // new Skills() { name = "DEF Up γ" }, // DEF Skill
                new Skills() { name = "Press the Attack!", base_attack_modifiers = new double[1] { 0.8 } }
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Plume", ATK = 495,  INTERVAL = 1, ATKTYPE = AttackType.Physical, CLASS = "Vanguard", ARCHETYPE = "DP-On-Kill/Charger" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", base_attack_modifiers = new double[1] { 0.08 } },
                new Skills() { name = "Swift Strike α", base_attack_modifiers = new double[2] { 0.08, 0.25 }, attack_speed_modifiers = new double[1] { 25 } }
                }
            },

            // Agent
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Cantabile", ATK = 590,  INTERVAL = 1, ATKTYPE = AttackType.Physical, CLASS = "Vanguard", ARCHETYPE = "Agent" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", base_attack_modifiers = new double[1] { 0.12 } }, // 12 speed when not blocking, 12% ATK when blocking
                new Skills() { name = "Bystander", base_attack_modifiers = new double[2] { 0.12, 1 }  },
                new Skills() { name = "Fleeting Light", base_attack_modifiers = new double[2] { 0.12, 0.4 }, attack_speed_modifiers = new double[1] { 50 } }
                }
            }
        };
    }
}
