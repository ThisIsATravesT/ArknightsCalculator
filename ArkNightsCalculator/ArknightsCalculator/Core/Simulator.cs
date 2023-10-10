using System;
using System.Collections.Generic;
using System.Linq;

namespace ArknightsCalculator.Core
{
    public class Simulator
    {
        AllEnemyUnits allEnemies = new AllEnemyUnits();
        Formula calculator = new Formula();

        public void RunCombatSimulation(OperatorUnit operatorUnit, Stats enemyUnit)
        {
            Console.WriteLine("-Simulating Combat Data-");
            Console.WriteLine();
            Console.WriteLine("Operator: " + operatorUnit.OperatorStats.NAME + " | Class: " + operatorUnit.OperatorStats.CLASS + " | Archetype: " + operatorUnit.OperatorStats.ARCHETYPE);
            for (var i = 0; i < operatorUnit.OperatorSkills.Length; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("Calculating Average Combat Performance");
                }
                else
                {
                    Console.WriteLine("Skill " + i + ": " + operatorUnit.OperatorSkills[i].name + " Engaged");
                }
                Console.WriteLine("-------------------");
                var operatorAPS = calculator.Attacks_Per_Second(operatorUnit.OperatorStats, operatorUnit.OperatorSkills[i].attack_speed_modifiers, operatorUnit.OperatorSkills[i].attack_interval_modifiers);
                Console.WriteLine("Attacks per Second: " + operatorAPS);
                var operatorFinal = calculator.Final_Attack(operatorUnit.OperatorStats, operatorUnit.OperatorSkills[i].base_attack_modifiers, operatorUnit.OperatorSkills[i].attack_multiplier_modifiers, 0);
                Console.WriteLine("Final Attack Stat: " + operatorFinal);
                if (operatorUnit.OperatorStats.ATKTYPE == AttackType.Physical)
                {
                    if (enemyUnit.NAME != null)
                    {
                        var operatorPhysVEnemy = calculator.Physical_Damage(operatorFinal, enemyUnit, operatorUnit.OperatorSkills[i].flat_def_modierifers, operatorUnit.OperatorSkills[i].scaling_def_modifiers, operatorUnit.OperatorSkills[i].phys_taken_modifiers);
                        Console.WriteLine("Physical Damage (vs " + enemyUnit.NAME + " (DEF " + enemyUnit.DEF + ")): " + operatorPhysVEnemy);
                        Console.WriteLine("Physical DPS (vs " + enemyUnit.NAME + "(DEF " + enemyUnit.DEF + ")): " + calculator.Damage_Per_Second(operatorAPS, operatorPhysVEnemy));
                    }
                    else
                    {
                        Stats avgEnemyDef = new Stats() { DEF = (int)allEnemies.AllEnemies.Average(x => x.EnemyStats.DEF) };
                        var operatorPhysVAvg = calculator.Physical_Damage(operatorFinal, avgEnemyDef, operatorUnit.OperatorSkills[i].flat_def_modierifers, operatorUnit.OperatorSkills[i].scaling_def_modifiers, operatorUnit.OperatorSkills[i].phys_taken_modifiers);
                        Console.WriteLine("Physical Damage (vs Avg DEF (" + avgEnemyDef.DEF + ") Enemy): " + operatorPhysVAvg);
                        Console.WriteLine("Physical DPS (vs Avg DEF (" + avgEnemyDef.DEF + ") Enemy): " + calculator.Damage_Per_Second(operatorAPS, operatorPhysVAvg));
                        var operatorPhysVMax = calculator.Physical_Damage(operatorFinal, allEnemies.bossMaxDefStats, operatorUnit.OperatorSkills[i].flat_def_modierifers, operatorUnit.OperatorSkills[i].scaling_def_modifiers, operatorUnit.OperatorSkills[i].phys_taken_modifiers);
                        Console.WriteLine("Physical Damage (vs Max DEF (" + allEnemies.bossMaxDefStats.DEF + ") Boss): " + operatorPhysVMax);
                        Console.WriteLine("Physical DPS (vs Max DEF (" + allEnemies.bossMaxDefStats.DEF + ") Boss): " + calculator.Damage_Per_Second(operatorAPS, operatorPhysVMax));
                        var operatorPhysVElite = calculator.Physical_Damage(operatorFinal, allEnemies.eliteMobDefStats, operatorUnit.OperatorSkills[i].flat_def_modierifers, operatorUnit.OperatorSkills[i].scaling_def_modifiers, operatorUnit.OperatorSkills[i].phys_taken_modifiers);
                        Console.WriteLine("Physical Damage (vs DEF (" + allEnemies.eliteMobDefStats.DEF + ") Elite Mob): " + operatorPhysVElite);
                        Console.WriteLine("Physical DPS (vs DEF (" + allEnemies.eliteMobDefStats.DEF + ") Elite Mob): " + calculator.Damage_Per_Second(operatorAPS, operatorPhysVElite));
                        var operatorPhysVMob = calculator.Physical_Damage(operatorFinal, allEnemies.normMobDefStats, operatorUnit.OperatorSkills[i].flat_def_modierifers, operatorUnit.OperatorSkills[i].scaling_def_modifiers, operatorUnit.OperatorSkills[i].phys_taken_modifiers);
                        Console.WriteLine("Physical Damage (vs Low DEF DEF (" + allEnemies.normMobDefStats.DEF + ") Normal Mob): " + operatorPhysVMob);
                        Console.WriteLine("Physical DPS (vs Low DEF (" + allEnemies.normMobDefStats.DEF + ") Normal Mob): " + calculator.Damage_Per_Second(operatorAPS, operatorPhysVMob));
                    }
                }
                else if (operatorUnit.OperatorStats.ATKTYPE == AttackType.Arts)
                {
                    if (enemyUnit.NAME != null)
                    {
                        var operatorArtsVEnemy = calculator.Arts_Damage(operatorFinal, enemyUnit, operatorUnit.OperatorSkills[i].flat_res_modierifers, operatorUnit.OperatorSkills[i].scaling_res_modifiers, operatorUnit.OperatorSkills[i].arts_taken_modifiers);
                        Console.WriteLine("Arts Damage (vs " + enemyUnit.NAME + "(RES " + enemyUnit.RES + ")): " + operatorArtsVEnemy);
                        Console.WriteLine("Arts DPS (vs " + enemyUnit.NAME + "(RES " + enemyUnit.RES + ")): " + calculator.Damage_Per_Second(operatorAPS, operatorArtsVEnemy));
                    }
                    else
                    {
                        Stats avgEnemyRes = new Stats() { RES = (int)allEnemies.AllEnemies.Average(x => x.EnemyStats.RES) };
                        var operatorArtsVAvg = calculator.Arts_Damage(operatorFinal, avgEnemyRes, operatorUnit.OperatorSkills[i].flat_res_modierifers, operatorUnit.OperatorSkills[i].scaling_res_modifiers, operatorUnit.OperatorSkills[i].arts_taken_modifiers);
                        Console.WriteLine("Arts Damage (vs Avg RES (" + avgEnemyRes.RES + ") Enemy): " + operatorArtsVAvg);
                        Console.WriteLine("Arts DPS (vs Avg RES (" + avgEnemyRes.RES + ") Enemy): " + calculator.Damage_Per_Second(operatorAPS, operatorArtsVAvg));
                        var operatorArtsVMax = calculator.Arts_Damage(operatorFinal, allEnemies.bossMaxResStats, operatorUnit.OperatorSkills[i].flat_res_modierifers, operatorUnit.OperatorSkills[i].scaling_res_modifiers, operatorUnit.OperatorSkills[i].arts_taken_modifiers);
                        Console.WriteLine("Arts Damage (vs Max RES (" + allEnemies.bossMaxResStats.RES + ") Boss): " + operatorArtsVMax);
                        Console.WriteLine("Arts DPS (vs Max RES (" + allEnemies.bossMaxResStats.RES + ") Boss): " + calculator.Damage_Per_Second(operatorAPS, operatorArtsVMax));
                        var operatorArtsVElite = calculator.Arts_Damage(operatorFinal, allEnemies.eliteMobResStats, operatorUnit.OperatorSkills[i].flat_res_modierifers, operatorUnit.OperatorSkills[i].scaling_res_modifiers, operatorUnit.OperatorSkills[i].arts_taken_modifiers);
                        Console.WriteLine("Arts Damage (vs RES (" + allEnemies.eliteMobResStats.RES + ") Elite Mob): " + operatorArtsVElite);
                        Console.WriteLine("Arts DPS (vs RES (" + allEnemies.eliteMobResStats.RES + ") Elite Mob): " + calculator.Damage_Per_Second(operatorAPS, operatorArtsVElite));
                        var operatorArtsVMob = calculator.Arts_Damage(operatorFinal, allEnemies.normMobResStats, operatorUnit.OperatorSkills[i].flat_res_modierifers, operatorUnit.OperatorSkills[i].scaling_res_modifiers, operatorUnit.OperatorSkills[i].arts_taken_modifiers);
                        Console.WriteLine("Arts Damage (vs Low RES (" + allEnemies.normMobResStats.RES + ") Normal Mob): " + operatorArtsVMob);
                        Console.WriteLine("Arts DPS (vs Low RES (" + allEnemies.normMobResStats.RES + ") Normal Mob): " + calculator.Damage_Per_Second(operatorAPS, operatorArtsVMob));
                    }
                }
                else if (operatorUnit.OperatorStats.ATKTYPE == AttackType.Healing)
                {
                    Console.WriteLine("Healing Per Second: " + calculator.Damage_Per_Second(operatorAPS, operatorFinal));
                }
                if (operatorUnit.OperatorSkills[i].extra_phys_damage_done != null)
                {
                    if (enemyUnit.NAME != null)
                    {
                        var operatorPhysVEnemy = calculator.Physical_Damage(operatorUnit.OperatorSkills[i].extra_phys_damage_done[0], enemyUnit, operatorUnit.OperatorSkills[i].flat_def_modierifers, operatorUnit.OperatorSkills[i].scaling_def_modifiers, operatorUnit.OperatorSkills[i].phys_taken_modifiers);
                        Console.WriteLine("Extra Physical Damage (vs " + enemyUnit.NAME + " (DEF " + enemyUnit.DEF + ")): " + operatorPhysVEnemy);
                        Console.WriteLine("Extra Physical DPS (vs " + enemyUnit.NAME + "(DEF " + enemyUnit.DEF + ")): " + calculator.Damage_Per_Second(operatorAPS, operatorPhysVEnemy));
                    }
                    else
                    {
                        Stats avgEnemyDef = new Stats() { DEF = (int)allEnemies.AllEnemies.Average(x => x.EnemyStats.DEF) };
                        var operatorPhysVAvg = calculator.Physical_Damage(operatorUnit.OperatorSkills[i].extra_phys_damage_done[0], avgEnemyDef, operatorUnit.OperatorSkills[i].flat_def_modierifers, operatorUnit.OperatorSkills[i].scaling_def_modifiers, operatorUnit.OperatorSkills[i].phys_taken_modifiers);
                        Console.WriteLine("Extra Physical Damage (vs Avg DEF (" + avgEnemyDef.DEF + ") Enemy): " + operatorPhysVAvg);
                        Console.WriteLine("Extra Physical DPS (vs Avg DEF (" + avgEnemyDef.DEF + ") Enemy): " + calculator.Damage_Per_Second(operatorAPS, operatorPhysVAvg));
                        var operatorPhysVMax = calculator.Physical_Damage(operatorUnit.OperatorSkills[i].extra_phys_damage_done[0], allEnemies.bossMaxDefStats, operatorUnit.OperatorSkills[i].flat_def_modierifers, operatorUnit.OperatorSkills[i].scaling_def_modifiers, operatorUnit.OperatorSkills[i].phys_taken_modifiers);
                        Console.WriteLine("Extra Physical Damage (vs Max DEF (" + allEnemies.bossMaxDefStats.DEF + ") Boss): " + operatorPhysVMax);
                        Console.WriteLine("Extra Physical DPS (vs Max DEF (" + allEnemies.bossMaxDefStats.DEF + ") Boss): " + calculator.Damage_Per_Second(operatorAPS, operatorPhysVMax));
                        var operatorPhysVElite = calculator.Physical_Damage(operatorUnit.OperatorSkills[i].extra_phys_damage_done[0], allEnemies.eliteMobDefStats, operatorUnit.OperatorSkills[i].flat_def_modierifers, operatorUnit.OperatorSkills[i].scaling_def_modifiers, operatorUnit.OperatorSkills[i].phys_taken_modifiers);
                        Console.WriteLine("Extra Physical Damage (vs DEF (" + allEnemies.eliteMobDefStats.DEF + ") Elite Mob): " + operatorPhysVElite);
                        Console.WriteLine("Extra Physical DPS (vs DEF (" + allEnemies.eliteMobDefStats.DEF + ") Elite Mob): " + calculator.Damage_Per_Second(operatorAPS, operatorPhysVElite));
                        var operatorPhysVMob = calculator.Physical_Damage(operatorUnit.OperatorSkills[i].extra_phys_damage_done[0], allEnemies.normMobDefStats, operatorUnit.OperatorSkills[i].flat_def_modierifers, operatorUnit.OperatorSkills[i].scaling_def_modifiers, operatorUnit.OperatorSkills[i].phys_taken_modifiers);
                        Console.WriteLine("Extra Physical Damage (vs Low DEF DEF (" + allEnemies.normMobDefStats.DEF + ") Normal Mob): " + operatorPhysVMob);
                        Console.WriteLine("Extra Physical DPS (vs Low DEF (" + allEnemies.normMobDefStats.DEF + ") Normal Mob): " + calculator.Damage_Per_Second(operatorAPS, operatorPhysVMob));
                    }
                }
                else if (operatorUnit.OperatorSkills[i].extra_arts_damage_done != null)
                {
                    if (enemyUnit.NAME != null)
                    {
                        var operatorArtsVEnemy = calculator.Arts_Damage(operatorUnit.OperatorSkills[i].extra_arts_damage_done[0], enemyUnit, operatorUnit.OperatorSkills[i].flat_res_modierifers, operatorUnit.OperatorSkills[i].scaling_res_modifiers, operatorUnit.OperatorSkills[i].arts_taken_modifiers);
                        Console.WriteLine("Extra Arts Damage (vs " + enemyUnit.NAME + "(RES " + enemyUnit.RES + ")): " + operatorArtsVEnemy);
                        Console.WriteLine("Extra Arts DPS (vs " + enemyUnit.NAME + "(RES " + enemyUnit.RES + ")): " + calculator.Damage_Per_Second(operatorAPS, operatorArtsVEnemy));
                    }
                    else
                    {
                        Stats avgEnemyRes = new Stats() { RES = (int)allEnemies.AllEnemies.Average(x => x.EnemyStats.RES) };
                        var operatorArtsVAvg = calculator.Arts_Damage(operatorUnit.OperatorSkills[i].extra_arts_damage_done[0], avgEnemyRes, operatorUnit.OperatorSkills[i].flat_res_modierifers, operatorUnit.OperatorSkills[i].scaling_res_modifiers, operatorUnit.OperatorSkills[i].arts_taken_modifiers);
                        Console.WriteLine("Extra Arts Damage (vs Avg RES (" + avgEnemyRes.RES + ") Enemy): " + operatorArtsVAvg);
                        Console.WriteLine("Extra Arts DPS (vs Avg RES (" + avgEnemyRes.RES + ") Enemy): " + calculator.Damage_Per_Second(operatorAPS, operatorArtsVAvg));
                        var operatorArtsVMax = calculator.Arts_Damage(operatorUnit.OperatorSkills[i].extra_arts_damage_done[0], allEnemies.bossMaxResStats, operatorUnit.OperatorSkills[i].flat_res_modierifers, operatorUnit.OperatorSkills[i].scaling_res_modifiers, operatorUnit.OperatorSkills[i].arts_taken_modifiers);
                        Console.WriteLine("Extra Arts Damage (vs Max RES (" + allEnemies.bossMaxResStats.RES + ") Boss): " + operatorArtsVMax);
                        Console.WriteLine("Extra Arts DPS (vs Max RES (" + allEnemies.bossMaxResStats.RES + ") Boss): " + calculator.Damage_Per_Second(operatorAPS, operatorArtsVMax));
                        var operatorArtsVElite = calculator.Arts_Damage(operatorUnit.OperatorSkills[i].extra_arts_damage_done[0], allEnemies.eliteMobResStats, operatorUnit.OperatorSkills[i].flat_res_modierifers, operatorUnit.OperatorSkills[i].scaling_res_modifiers, operatorUnit.OperatorSkills[i].arts_taken_modifiers);
                        Console.WriteLine("Extra Arts Damage (vs RES (" + allEnemies.eliteMobResStats.RES + ") Elite Mob): " + operatorArtsVElite);
                        Console.WriteLine("Extra Arts DPS (vs RES (" + allEnemies.eliteMobResStats.RES + ") Elite Mob): " + calculator.Damage_Per_Second(operatorAPS, operatorArtsVElite));
                        var operatorArtsVMob = calculator.Arts_Damage(operatorUnit.OperatorSkills[i].extra_arts_damage_done[0], allEnemies.normMobResStats, operatorUnit.OperatorSkills[i].flat_res_modierifers, operatorUnit.OperatorSkills[i].scaling_res_modifiers, operatorUnit.OperatorSkills[i].arts_taken_modifiers);
                        Console.WriteLine("Extra Arts Damage (vs Low RES (" + allEnemies.normMobResStats.RES + ") Normal Mob): " + operatorArtsVMob);
                        Console.WriteLine("Extra Arts DPS (vs Low RES (" + allEnemies.normMobResStats.RES + ") Normal Mob): " + calculator.Damage_Per_Second(operatorAPS, operatorArtsVMob));
                    }
                }
                else if (operatorUnit.OperatorSkills[i].extra_true_damage_done != null)
                {
                    Console.WriteLine("Extra True Damage: " + operatorUnit.OperatorSkills[i].extra_true_damage_done[0]);
                    Console.WriteLine("Extra True DPS: " + calculator.Damage_Per_Second(operatorAPS, operatorUnit.OperatorSkills[i].extra_true_damage_done[0]));
                }
                Console.WriteLine("-------------------");
            }
        }

        public SimulationData ReturnCombatSimulation(OperatorUnit operatorUnit, Stats enemyUnit)
        {
            SimulationData simulationData = new SimulationData();
            List<double> operatorDamageTotalData = new List<double>();
            List<double> operatorDPSTotalData = new List<double>();

            for (var i = 0; i < operatorUnit.OperatorSkills.Length; i++)
            {
                double damageData = 0;
                double dpsData = 0;
                var operatorAPS = calculator.Attacks_Per_Second(operatorUnit.OperatorStats, operatorUnit.OperatorSkills[i].attack_speed_modifiers, operatorUnit.OperatorSkills[i].attack_interval_modifiers);
                var operatorFinal = calculator.Final_Attack(operatorUnit.OperatorStats, operatorUnit.OperatorSkills[i].base_attack_modifiers, operatorUnit.OperatorSkills[i].attack_multiplier_modifiers, 0);

                if (operatorUnit.OperatorStats.ATKTYPE == AttackType.Physical)
                {
                    damageData = calculator.Physical_Damage(operatorFinal, enemyUnit, operatorUnit.OperatorSkills[i].flat_def_modierifers, operatorUnit.OperatorSkills[i].scaling_def_modifiers, operatorUnit.OperatorSkills[i].phys_taken_modifiers);
                    dpsData = calculator.Damage_Per_Second(operatorAPS, damageData);
                }
                else if (operatorUnit.OperatorStats.ATKTYPE == AttackType.Arts)
                {
                    damageData = calculator.Arts_Damage(operatorFinal, enemyUnit, operatorUnit.OperatorSkills[i].flat_res_modierifers, operatorUnit.OperatorSkills[i].scaling_res_modifiers, operatorUnit.OperatorSkills[i].arts_taken_modifiers);
                    dpsData = calculator.Damage_Per_Second(operatorAPS, damageData);
                }
                else if (operatorUnit.OperatorStats.ATKTYPE == AttackType.Healing)
                {
                    damageData = operatorFinal;
                    dpsData = calculator.Damage_Per_Second(operatorAPS, operatorFinal);
                }
                if (operatorUnit.OperatorSkills[i].extra_phys_damage_done != null)
                {
                    damageData = damageData + calculator.Physical_Damage(operatorUnit.OperatorSkills[i].extra_phys_damage_done[0], enemyUnit, operatorUnit.OperatorSkills[i].flat_def_modierifers, operatorUnit.OperatorSkills[i].scaling_def_modifiers, operatorUnit.OperatorSkills[i].phys_taken_modifiers);
                    dpsData = calculator.Damage_Per_Second(operatorAPS, damageData);
                }
                else if (operatorUnit.OperatorSkills[i].extra_arts_damage_done != null)
                {
                    damageData = damageData + calculator.Arts_Damage(operatorUnit.OperatorSkills[i].extra_arts_damage_done[0], enemyUnit, operatorUnit.OperatorSkills[i].flat_res_modierifers, operatorUnit.OperatorSkills[i].scaling_res_modifiers, operatorUnit.OperatorSkills[i].arts_taken_modifiers);
                    dpsData = calculator.Damage_Per_Second(operatorAPS, damageData);
                }
                else if (operatorUnit.OperatorSkills[i].extra_true_damage_done != null)
                {
                    damageData = damageData + operatorUnit.OperatorSkills[i].extra_true_damage_done[0];
                    dpsData = calculator.Damage_Per_Second(operatorAPS, damageData);
                }

                operatorDamageTotalData.Add(damageData);
                operatorDPSTotalData.Add(dpsData);
            }

            simulationData.operatorDamageTotalData = operatorDamageTotalData;
            simulationData.operatorDPSTotalData = operatorDPSTotalData;
            simulationData.enemyDefData = enemyUnit.DEF;
            simulationData.enemyResData = enemyUnit.RES;
            simulationData.seriesName = "" + operatorUnit.OperatorStats.NAME + " vs " + enemyUnit.NAME;

            return simulationData;
        }
    }
}
