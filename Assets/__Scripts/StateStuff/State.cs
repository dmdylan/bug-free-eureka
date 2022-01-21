using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StateStuff
{
    public abstract class State
    {
        protected CombatManager combatManager;

        protected State(CombatManager combatManager)
        {
            this.combatManager = combatManager;
        }

        public virtual IEnumerator Start()
        {
            yield break;
        }

        protected IEnumerator SetNewTurnOrder()
        {
            combatManager.CurrentCharacterTurn = combatManager.TurnOrder.Dequeue();

            yield return new WaitForSeconds(1f);

            combatManager.TurnOrder.Enqueue(combatManager.CurrentCharacterTurn);
        }

        protected void ChangeToNewPlayerOrEnemyState()
        {
            if (combatManager.CurrentCharacterTurn.Status.Equals(PositionStatus.Friendly))
            {
                combatManager.SetState(new PlayerTurnState(combatManager));
            }
            else
            {
                combatManager.SetState(new EnemyTurnState(combatManager));
            }
        }
    }
}