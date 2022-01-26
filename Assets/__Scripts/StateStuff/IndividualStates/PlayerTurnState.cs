using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StateStuff
{
    public class PlayerTurnState : State
    {
        public PlayerTurnState(CombatManager combatManager) : base(combatManager)
        {
        }

        public override IEnumerator Start()
        {
            GameEventsManager.Instance.PlayerTurnStarted();
            yield break;
        }
    }
}