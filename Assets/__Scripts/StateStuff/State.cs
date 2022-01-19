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

        public virtual IEnumerator Attack()
        {
            yield break;
        }

        public virtual IEnumerator End()
        {
            yield break;
        }
    }
}