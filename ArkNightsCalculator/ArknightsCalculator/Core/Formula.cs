namespace ArknightsCalculator.Core
{
    public class Formula
    {
        public double Attacks_Per_Second(Stats stats, double[] attack_speed_modifiers, double[] attack_interval_modifiers)
        {
            double speed_modifier_total = 0;
            double interval_modifier_total = 0;

            if (attack_speed_modifiers != null)
            {
                foreach (var speed in attack_speed_modifiers)
                {
                    speed_modifier_total = speed_modifier_total + speed;
                }
            }

            if (attack_interval_modifiers != null)
            {
                foreach (var interval in attack_interval_modifiers)
                {
                    interval_modifier_total = interval_modifier_total + interval;
                }
            }

            double aps = (1 + (speed_modifier_total / 100)) / (stats.INTERVAL + interval_modifier_total);

            return aps;
        }

        public double Final_Attack(Stats stats, double[] base_attack_modifiers, double[] attack_multiplier_modifiers, double sora_buff)
        {
            double final_attack = 0;
            double baseAtk_total = 0;

            if (base_attack_modifiers != null)
            {
                foreach (var baseAtk in base_attack_modifiers)
                {
                    baseAtk_total = baseAtk_total + baseAtk;
                }
            }

            final_attack = (stats.ATK * (1 + baseAtk_total) + sora_buff);

            if (attack_multiplier_modifiers != null)
            {
                foreach (var mulitplier in attack_multiplier_modifiers)
                {
                    final_attack = final_attack * mulitplier;
                }
            }

            return final_attack;
        }

        public double Physical_Damage(double final_attack, Stats stats, double[] flat_def_modifiers, double[] scaling_def_modifiers, double[] phys_taken_modifiers)
        {
            double minimum_physical_damage = final_attack * 5 / 100;
            double physical_damage = minimum_physical_damage;
            double def_total = 0;
            double flat_def_total = 0;

            if (flat_def_modifiers != null)
            {
                foreach (var flatDef in flat_def_modifiers)
                {
                    flat_def_total = flat_def_total + flatDef;
                }
            }

            def_total = stats.DEF + flat_def_total;
            // physical_damage = final_attack - (stats.DEF - flat_def_total);

            if (scaling_def_modifiers != null)
            {
                foreach (var scaleDef in scaling_def_modifiers)
                {
                    def_total = def_total * (1 + scaleDef);
                }
            }

            physical_damage = final_attack - def_total;

            if (phys_taken_modifiers != null)
            {
                foreach (var taken in phys_taken_modifiers)
                {
                    physical_damage = physical_damage * (1 + taken);
                }
            }

            if (physical_damage < minimum_physical_damage)
            {
                physical_damage = minimum_physical_damage;
            }

            return physical_damage;
        }

        public double Arts_Damage(double final_attack, Stats stats, double[] flat_res_modifiers, double[] scaling_res_modifiers, double[] arts_taken_modifiers)
        {
            double arts_damage = 0;
            double resist_total = 0;
            double flat_res_total = 0;

            if (flat_res_modifiers != null)
            {
                foreach (var flatRes in flat_res_modifiers)
                {
                    flat_res_total = flat_res_total + flatRes;
                }
            }

            resist_total = stats.RES + flat_res_total;

            if (scaling_res_modifiers != null)
            {
                foreach (var scaleRes in scaling_res_modifiers)
                {
                    resist_total = resist_total * (1 + scaleRes);
                }
            }

            resist_total = 1 - (resist_total / 100);

            arts_damage = final_attack * resist_total;

            if (arts_taken_modifiers != null)
            {
                foreach (var taken in arts_taken_modifiers)
                {
                    arts_damage = arts_damage * (1 + taken);
                }
            }

            return arts_damage;
        }

        public double Damage_Per_Second(double attacks_per_second, double damage)
        {
            return attacks_per_second * damage;
        }
    }
}
