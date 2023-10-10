using System.Collections.Generic;
using System.Linq;

namespace ArknightsCalculator.Core
{
    public class AllStages
    {
        // Infomation taken from gamepress.gg/arknights/database/combat-operation-list
        public List<Stage> AllMissions = new List<Stage>()
        {
            new Stage() { Name = "4-10", Enemies = new List<EnemyUnit>()
                {
                    new AllEnemyUnits().AllEnemies.Where(en => en.EnemyStats.NAME == "Soldier").First(),
                    new AllEnemyUnits().AllEnemies.Where(en => en.EnemyStats.NAME == "Caster Leader").First(),
                    new AllEnemyUnits().AllEnemies.Where(en => en.EnemyStats.NAME == "Heavy Defender Leader").First(),
                    new AllEnemyUnits().AllEnemies.Where(en => en.EnemyStats.NAME == "Shielded Soldier").First(),
                    new AllEnemyUnits().AllEnemies.Where(en => en.EnemyStats.NAME == "Bladed Fighter").First(),
                    new AllEnemyUnits().AllEnemies.Where(en => en.EnemyStats.NAME == "Butcher").First(),
                    new AllEnemyUnits().AllEnemies.Where(en => en.EnemyStats.NAME == "FrostNova").First()
                }
            }
        };
    }
}
