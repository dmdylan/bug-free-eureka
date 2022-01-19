using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StateStuff
{
    public class BeginState : State
    {
        public BeginState(CombatManager combatManager) : base(combatManager)
        {
        }
    }
}