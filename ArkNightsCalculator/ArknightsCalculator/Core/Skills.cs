namespace ArknightsCalculator.Core
{
    public class Skills
    {
        public string name;

        // Attacks_Per_Second
        public double[] attack_speed_modifiers;
        public double[] attack_interval_modifiers;

        // Final_Attack
        public double[] base_attack_modifiers;
        public double[] attack_multiplier_modifiers;
        public double sora_buff;

        // Physical_Damage
        public double[] flat_def_modierifers;
        public double[] scaling_def_modifiers;
        public double[] phys_taken_modifiers;
        public double[] extra_phys_damage_done;

        // Arts_Damage
        public double[] flat_res_modierifers;
        public double[] scaling_res_modifiers;
        public double[] arts_taken_modifiers;
        public double[] extra_arts_damage_done;

        // True_Damage
        public double[] extra_true_damage_done;
    }
}
