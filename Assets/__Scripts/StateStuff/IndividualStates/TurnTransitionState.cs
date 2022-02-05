using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StateStuff
{
    public class TurnTransitionState : State
    {
        public TurnTransitionState(CombatManager combatManager) : base(combatManager)
        {
        }

        public override IEnumerator End()
        {
            yield return null;
        }

        public override IEnumerator Start()
        {
            combatManager.SetNewTurnOrder();

            yield return new WaitForSeconds(1f);

            combatManager.ChangeToNewPlayerOrEnemyState();

            canChangeStates = true;
        }
    }
}