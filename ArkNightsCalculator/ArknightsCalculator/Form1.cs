using ArknightsCalculator.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ArknightsCalculator
{
    public partial class Form1 : Form
    {
        AllOperatorUnits operators;
        AllTrueDmgOpUnitShortcut opTrues;
        AllEnemyUnits enemies;
        AllStages stages;
        OperatorClassArchetype operatorClassArchetypes;
        Simulator sim;

        public Form1()
        {
            operators = new AllOperatorUnits();
            opTrues = new AllTrueDmgOpUnitShortcut();
            enemies = new AllEnemyUnits();
            stages = new AllStages();
            operatorClassArchetypes = new OperatorClassArchetype();
            sim = new Simulator();

            InitializeComponent();

            foreach (var operata in operators.AllOperators)
            {
                comboBox1.Items.Add(operata.OperatorStats.NAME);
            }

            foreach (var enemi in enemies.AllEnemies)
            {
                comboBox2.Items.Add(enemi.EnemyStats.NAME);
            }

            foreach (var clars in operatorClassArchetypes.OperatorClass)
            {
                comboBox3.Items.Add(clars);
            }

            foreach (var archetype in operatorClassArchetypes.OperatorArchetype)
            {
                comboBox4.Items.Add(archetype);
            }

            comboBox5.Items.Add("Physical");
            comboBox5.Items.Add("Arts");
            comboBox5.Items.Add("True");
            comboBox5.Items.Add("Healing");

            foreach (var stage in stages.AllMissions)
            {
                comboBox6.Items.Add(stage.Name);
            }
        }

        private void prepareDefGraph(List<SimulationData> simulations)
        {
            // var chartpop = new System.Windows.Forms.DataVisualization.Charting.Chart();

            chart1.Series.Clear();

            int count = 0;
            foreach (var sim in simulations)
            {
                chart1.Series.Add(sim.seriesName);
                foreach (var dmgTotal in sim.operatorDamageTotalData)
                {
                    chart1.Series[count].Points.AddXY(sim.enemyDefData, dmgTotal);
                }
                // chart1.Series[count].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
                count++;
            }
            // chart1.Series.OrderBy(a => a.YValueMembers);
        }

        private void prepareResGraph(List<SimulationData> simulations)
        {
            chart1.Series.Clear();

            int count = 0;
            foreach (var sim in simulations)
            {
                chart1.Series.Add(sim.seriesName);
                foreach (var dmgTotal in sim.operatorDamageTotalData)
                {
                    chart1.Series[count].Points.AddXY(sim.enemyResData, dmgTotal);
                }
                // chart1.Series[count].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
                count++;
            }
            // chart1.Series.OrderBy(a => a.YValueMembers);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var operatorUnit in operators.AllOperators)
            {
                sim.RunCombatSimulation(operatorUnit, new Stats());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var selectedOperator = operators.AllOperators.Where(op => op.OperatorStats.NAME == (string)comboBox1.SelectedItem).First();
            sim.RunCombatSimulation(selectedOperator, new Stats());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var selectedEnemy = enemies.AllEnemies.Where(en => en.EnemyStats.NAME == (string)comboBox2.SelectedItem).First();
            foreach (var operatorUnit in operators.AllOperators)
            {
                sim.RunCombatSimulation(operatorUnit, selectedEnemy.EnemyStats);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<SimulationData> simulations = new List<SimulationData>();
            var selectedOperator = operators.AllOperators.Where(op => op.OperatorStats.NAME == (string)comboBox1.SelectedItem).First();
            var selectedEnemy = enemies.AllEnemies.Where(en => en.EnemyStats.NAME == (string)comboBox2.SelectedItem).First();

            sim.RunCombatSimulation(selectedOperator, selectedEnemy.EnemyStats);
            simulations.Add(sim.ReturnCombatSimulation(selectedOperator, selectedEnemy.EnemyStats));
            prepareDefGraph(simulations);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            List<SimulationData> simulations = new List<SimulationData>();
            var selectedOperator = operators.AllOperators.Where(op => op.OperatorStats.NAME == (string)comboBox1.SelectedItem).First();
            foreach (var enemyUnit in enemies.AllEnemies)
            {
                sim.RunCombatSimulation(selectedOperator, enemyUnit.EnemyStats);
                simulations.Add(sim.ReturnCombatSimulation(selectedOperator, enemyUnit.EnemyStats));
            }

            prepareDefGraph(simulations);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            List<SimulationData> simulations = new List<SimulationData>();
            foreach (var operatorUnit in operators.AllOperators)
            {
                foreach (var enemyUnit in enemies.AllEnemies)
                {
                    sim.RunCombatSimulation(operatorUnit, enemyUnit.EnemyStats);
                    simulations.Add(sim.ReturnCombatSimulation(operatorUnit, enemyUnit.EnemyStats));
                }
            }

            prepareDefGraph(simulations);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Fix this
            // Console.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            List<SimulationData> simulations = new List<SimulationData>();
            var enemiesByDef = enemies.AllEnemies.OrderBy(o => o.EnemyStats.DEF).ToList();
            enemiesByDef = enemiesByDef
              .GroupBy(p => new { p.EnemyStats.DEF })
              .Select(g => g.FirstOrDefault())
              .ToList();
            var selectedOperator = operators.AllOperators.Where(op => op.OperatorStats.NAME == (string)comboBox1.SelectedItem).First();
            foreach (var enemyUnit in enemiesByDef)
            {
                sim.RunCombatSimulation(selectedOperator, enemyUnit.EnemyStats);
                simulations.Add(sim.ReturnCombatSimulation(selectedOperator, enemyUnit.EnemyStats));
            }

            prepareDefGraph(simulations);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            List<SimulationData> simulations = new List<SimulationData>();
            var enemiesByRes = enemies.AllEnemies.OrderBy(o => o.EnemyStats.RES).ToList();
            enemiesByRes = enemiesByRes
              .GroupBy(p => new { p.EnemyStats.RES })
              .Select(g => g.FirstOrDefault())
              .ToList();
            var selectedOperator = operators.AllOperators.Where(op => op.OperatorStats.NAME == (string)comboBox1.SelectedItem).First();
            foreach (var enemyUnit in enemiesByRes)
            {
                sim.RunCombatSimulation(selectedOperator, enemyUnit.EnemyStats);
                simulations.Add(sim.ReturnCombatSimulation(selectedOperator, enemyUnit.EnemyStats));
            }

            prepareResGraph(simulations);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var selectedClass = operatorClassArchetypes.OperatorClass.Where(op => op == (string)comboBox3.SelectedItem).First();
            var operatorsOfClass = operators.AllOperators.Where(opr => opr.OperatorStats.CLASS == selectedClass).ToList();

            foreach (var opClass in operatorsOfClass)
            {
                sim.RunCombatSimulation(opClass, new Stats());
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            var selectedArchetype = operatorClassArchetypes.OperatorArchetype.Where(op => op == (string)comboBox4.SelectedItem).First();
            var operatorsOfArchetype = operators.AllOperators.Where(opr => opr.OperatorStats.ARCHETYPE == selectedArchetype).ToList();

            foreach (var opArchetype in operatorsOfArchetype)
            {
                sim.RunCombatSimulation(opArchetype, new Stats());
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            List<SimulationData> simulations = new List<SimulationData>();
            var selectedEnemy = enemies.AllEnemies.Where(en => en.EnemyStats.NAME == (string)comboBox2.SelectedItem).First();
            var selectedClass = operatorClassArchetypes.OperatorClass.Where(op => op == (string)comboBox3.SelectedItem).First();
            var operatorsOfClass = operators.AllOperators.Where(opr => opr.OperatorStats.CLASS == selectedClass).ToList();

            foreach (var opClass in operatorsOfClass)
            {
                sim.RunCombatSimulation(opClass, selectedEnemy.EnemyStats);
                simulations.Add(sim.ReturnCombatSimulation(opClass, selectedEnemy.EnemyStats));
            }

            prepareDefGraph(simulations);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            List<SimulationData> simulations = new List<SimulationData>();
            var selectedEnemy = enemies.AllEnemies.Where(en => en.EnemyStats.NAME == (string)comboBox2.SelectedItem).First();
            var selectedArchetype = operatorClassArchetypes.OperatorArchetype.Where(op => op == (string)comboBox4.SelectedItem).First();
            var operatorsOfArchetype = operators.AllOperators.Where(opr => opr.OperatorStats.ARCHETYPE == selectedArchetype).ToList();

            foreach (var opArchetype in operatorsOfArchetype)
            {
                sim.RunCombatSimulation(opArchetype, selectedEnemy.EnemyStats);
                simulations.Add(sim.ReturnCombatSimulation(opArchetype, selectedEnemy.EnemyStats));
            }

            prepareDefGraph(simulations);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            List<SimulationData> simulations = new List<SimulationData>();
            var selectedClass = operatorClassArchetypes.OperatorClass.Where(op => op == (string)comboBox3.SelectedItem).First();
            var operatorsOfClass = operators.AllOperators.Where(opr => opr.OperatorStats.CLASS == selectedClass).ToList();

            foreach (var opClass in operatorsOfClass)
            {
                foreach (var enemyUnit in enemies.AllEnemies)
                {
                    sim.RunCombatSimulation(opClass, enemyUnit.EnemyStats);
                    simulations.Add(sim.ReturnCombatSimulation(opClass, enemyUnit.EnemyStats));
                }
            }

            prepareDefGraph(simulations);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            List<SimulationData> simulations = new List<SimulationData>();
            var selectedArchetype = operatorClassArchetypes.OperatorArchetype.Where(op => op == (string)comboBox4.SelectedItem).First();
            var operatorsOfArchetype = operators.AllOperators.Where(opr => opr.OperatorStats.ARCHETYPE == selectedArchetype).ToList();

            foreach (var opArchetype in operatorsOfArchetype)
            {
                foreach (var enemyUnit in enemies.AllEnemies)
                {
                    sim.RunCombatSimulation(opArchetype, enemyUnit.EnemyStats);
                    simulations.Add(sim.ReturnCombatSimulation(opArchetype, enemyUnit.EnemyStats));
                }
            }

            prepareDefGraph(simulations);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            var selectedAttackType = (string)comboBox5.SelectedItem;
            List<OperatorUnit> operatorsOfAttackType;
            if (selectedAttackType == "True")
            {
                operatorsOfAttackType = opTrues.AllOperators;
            }
            else
            {
                operatorsOfAttackType = operators.AllOperators.Where(opr => opr.OperatorStats.ATKTYPE.ToString() == selectedAttackType).ToList();
            }

            foreach (var opAtkType in operatorsOfAttackType)
            {
                sim.RunCombatSimulation(opAtkType, new Stats());
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            List<SimulationData> simulations = new List<SimulationData>();
            var selectedAttackType = (string)comboBox5.SelectedItem;
            List<OperatorUnit> operatorsOfAttackType;
            if (selectedAttackType == "True")
            {
                operatorsOfAttackType = opTrues.AllOperators;
            }
            else
            {
                operatorsOfAttackType = operators.AllOperators.Where(opr => opr.OperatorStats.ATKTYPE.ToString() == selectedAttackType).ToList();
            }

            foreach (var opAtkType in operatorsOfAttackType)
            {
                foreach (var enemyUnit in enemies.AllEnemies)
                {
                    sim.RunCombatSimulation(opAtkType, enemyUnit.EnemyStats);
                    simulations.Add(sim.ReturnCombatSimulation(opAtkType, enemyUnit.EnemyStats));
                }
            }

            prepareDefGraph(simulations);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            List<SimulationData> simulations = new List<SimulationData>();
            var selectedEnemy = enemies.AllEnemies.Where(en => en.EnemyStats.NAME == (string)comboBox2.SelectedItem).First();
            var selectedAttackType = (string)comboBox5.SelectedItem;
            List<OperatorUnit> operatorsOfAttackType;
            if (selectedAttackType == "True")
            {
                operatorsOfAttackType = opTrues.AllOperators;
            }
            else
            {
                operatorsOfAttackType = operators.AllOperators.Where(opr => opr.OperatorStats.ATKTYPE.ToString() == selectedAttackType).ToList();
            }

            foreach (var opAtkType in operatorsOfAttackType)
            {
                sim.RunCombatSimulation(opAtkType, selectedEnemy.EnemyStats);
                simulations.Add(sim.ReturnCombatSimulation(opAtkType, selectedEnemy.EnemyStats));
            }

            prepareDefGraph(simulations);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            List<SimulationData> simulations = new List<SimulationData>();
            var selectedStage = stages.AllMissions.Where(s => s.Name == (string)comboBox6.SelectedItem).First();
            foreach (var operatorUnit in operators.AllOperators)
            {
                foreach (var enemyUnit in selectedStage.Enemies)
                {
                    sim.RunCombatSimulation(operatorUnit, enemyUnit.EnemyStats);
                    simulations.Add(sim.ReturnCombatSimulation(operatorUnit, enemyUnit.EnemyStats));
                }
            }

            prepareDefGraph(simulations);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            List<SimulationData> simulations = new List<SimulationData>();
            var selectedStage = stages.AllMissions.Where(s => s.Name == (string)comboBox6.SelectedItem).First();
            var selectedOperator = operators.AllOperators.Where(op => op.OperatorStats.NAME == (string)comboBox1.SelectedItem).First();
            foreach (var enemyUnit in selectedStage.Enemies)
            {
                sim.RunCombatSimulation(selectedOperator, enemyUnit.EnemyStats);
                simulations.Add(sim.ReturnCombatSimulation(selectedOperator, enemyUnit.EnemyStats));
            }

            prepareDefGraph(simulations);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            List<SimulationData> simulations = new List<SimulationData>();
            var selectedStage = stages.AllMissions.Where(s => s.Name == (string)comboBox6.SelectedItem).First();
            var selectedClass = operatorClassArchetypes.OperatorClass.Where(op => op == (string)comboBox3.SelectedItem).First();
            var operatorsOfClass = operators.AllOperators.Where(opr => opr.OperatorStats.CLASS == selectedClass).ToList();

            foreach (var opClass in operatorsOfClass)
            {
                foreach (var enemyUnit in selectedStage.Enemies)
                {
                    sim.RunCombatSimulation(opClass, enemyUnit.EnemyStats);
                    simulations.Add(sim.ReturnCombatSimulation(opClass, enemyUnit.EnemyStats));
                }
            }

            prepareDefGraph(simulations);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            List<SimulationData> simulations = new List<SimulationData>();
            var selectedStage = stages.AllMissions.Where(s => s.Name == (string)comboBox6.SelectedItem).First();
            var selectedArchetype = operatorClassArchetypes.OperatorArchetype.Where(op => op == (string)comboBox4.SelectedItem).First();
            var operatorsOfArchetype = operators.AllOperators.Where(opr => opr.OperatorStats.ARCHETYPE == selectedArchetype).ToList();

            foreach (var opArchetype in operatorsOfArchetype)
            {
                foreach (var enemyUnit in selectedStage.Enemies)
                {
                    sim.RunCombatSimulation(opArchetype, enemyUnit.EnemyStats);
                    simulations.Add(sim.ReturnCombatSimulation(opArchetype, enemyUnit.EnemyStats));
                }
            }

            prepareDefGraph(simulations);
        }
    }
}
