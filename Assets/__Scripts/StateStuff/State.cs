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

        public abstract IEnumerator Start();

        public abstract IEnumerator End();
    }
}