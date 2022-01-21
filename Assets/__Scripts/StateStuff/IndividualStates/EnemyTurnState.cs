using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StateStuff
{
    public class EnemyTurnState : State
    {
        public EnemyTurnState(CombatManager combatManager) : base(combatManager)
        {
        }
    }
}