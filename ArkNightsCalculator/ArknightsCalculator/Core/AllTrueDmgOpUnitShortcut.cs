using System.Collections.Generic;

namespace ArknightsCalculator.Core
{
    public class AllTrueDmgOpUnitShortcut
    {
        // All Operators graded at E2 M3 LVL90 and max trust (*not max potential), from gamepress.gg/arknights operator listings
        public List<OperatorUnit> AllOperators = new List<OperatorUnit>()
        {
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Amiya", ATK = 682,  INTERVAL = 1.6, ATKTYPE = AttackType.Arts, CLASS = "Caster", ARCHETYPE = "ST/Core" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"},
                new Skills() { name = "Chimera", base_attack_modifiers = new double[1] { 2.3 }, extra_true_damage_done = new double[1] { 682 } } // attack changes to true
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Amiya (Guard)", ATK = 702,  INTERVAL = 1.25, ATKTYPE = AttackType.Arts, CLASS = "Guard", ARCHETYPE = "Arts Fighter" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", base_attack_modifiers = new double[1] { 0.07 } },
                new Skills() { name = "Ying Xiao - Shadowless", base_attack_modifiers = new double[2] { 0.14, 0.4 }, attack_multiplier_modifiers = new double[1] { 2.2 }, attack_speed_modifiers = new double[1] { 900 }, extra_true_damage_done = new double[1] { 804 } } // Deals true damage on last or after 3 kills, too hard to calculate
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Cliffheart", ATK = 835,  INTERVAL = 1.8, ATKTYPE = AttackType.Physical, CLASS = "Specialist", ARCHETYPE = "Puller/Hookmaster" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", base_attack_modifiers = new double[1] { 0.12 } },
                new Skills() { name = "Chain Hook", base_attack_modifiers = new double[1] { 0.12 }, extra_arts_damage_done = new double[1] { 1503 } }, // 180% arts
                new Skills() { name = "Binding Chains", base_attack_modifiers = new double[1] { 0.12 }, extra_true_damage_done = new double[1] { 1670 } } // 200% true
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Kal'tsit", ATK = 490,  INTERVAL = 2.85, ATKTYPE = AttackType.Healing, CLASS = "Medic", ARCHETYPE = "ST" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", extra_true_damage_done = new double[1] { 1200 } }, // true damage on Mon3tr's death, Mon3tr Summon
                new Skills() { name = "Command: Meltdown", extra_true_damage_done = new double[1] { 5047.2 } } // +260% buff to Mon3tr (NOW DOES TRUE DAMAGE) WTF
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Nearl the Radiant Knight", ATK = 1149,  INTERVAL = 1.5, ATKTYPE = AttackType.Physical, CLASS = "Guard", ARCHETYPE = "Duelist/Dreadnought" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", scaling_def_modifiers = new double[1] { -0.2 }, extra_true_damage_done = new double[1] { 919.2 } }, // 80% true damage on deployment
                new Skills() { name = "Blazing Sun's Obeisance", scaling_def_modifiers = new double[1] { -0.2 }, base_attack_modifiers = new double[1] { 1.4 }, extra_true_damage_done = new double[1] { 1263.9 } } // 110% true damage from sun, rediculous skill
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Nightmare", ATK = 692,  INTERVAL = 1.6, ATKTYPE = AttackType.Arts, CLASS = "Caster", ARCHETYPE = "ST/Core" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive"},
                new Skills() { name = "Night Phantom", base_attack_modifiers = new double[1] { 0.15 }, extra_true_damage_done = new double[1] { 1200 } } // Passive if using skill 2, damage = tiles moved ; match with Weedy!
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Skadi the Corrupting Heart", ATK = 418,  INTERVAL = 1, ATKTYPE = AttackType.Healing, CLASS = "Supporter", ARCHETYPE = "Aura/Bard" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", base_attack_modifiers = new double[1] { 0.06 }, attack_multiplier_modifiers = new double[1] { -0.1 } }, // Nearby unit buff applicable to self & Bard heal trait
                new Skills() { name = "The Tide Surges, The Tide Recedes", base_attack_modifiers = new double[1] { 0.06 }, attack_multiplier_modifiers = new double[1] { -0.1 }, extra_true_damage_done = new double[1] { 310.156 } } // 70% ATK per second
                }
            },
            new OperatorUnit() { OperatorStats = new Stats() { NAME = "Weedy", ATK = 722,  INTERVAL = 1.2, ATKTYPE = AttackType.Physical, CLASS = "Specialist", ARCHETYPE = "Pusher/Push Stroker" }, OperatorSkills = new Skills[] {
                new Skills() { name = "Passive", extra_phys_damage_done = new double[1] { 585 } }, // Industrial Water Cannon Summon
                new Skills() { name = "Liquid Nitrogen Cannon", extra_arts_damage_done = new double[1] { 2166 }, extra_true_damage_done = new double[1] { 1200 } } // 300% arts + 1200 true per grid pushed
                }
            },
        };
    }
}