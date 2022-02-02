using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StateStuff
{
    public abstract class State
    {
        protected CombatManager combatManager;
        protected bool canChangeStates = false;

        public bool CanChangeStates => canChangeStates;

        protected State(CombatManager combatManager)
        {
            this.combatManager = combatManager;
        }

        public virtual void UpdateState()
        {
            return;
        }

        public abstract IEnumerator Start();

        public abstract IEnumerator End();
    }
}