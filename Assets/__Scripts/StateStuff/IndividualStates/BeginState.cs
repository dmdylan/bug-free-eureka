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

        public override IEnumerator Start()
        {

            SetTurnOrder();

            yield return null;
            
            ChangeToNewPlayerOrEnemyState();
        }

        private void SetTurnOrder()
        {
            List<Character> sortedList = combatManager.AllCharacters;
            sortedList.Sort((IComparer<Character>)combatManager.AllCharacters);

            foreach (Character character in sortedList)
            {
                combatManager.TurnOrder.Enqueue(character);
            }
        }
    }
}