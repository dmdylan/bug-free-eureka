using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace StateStuff
{
    public class BeginState : State
    {
        public BeginState(CombatManager combatManager) : base(combatManager)
        {
        }

        public override IEnumerator End()
        {
            Debug.Log("Begin state end coroutine");
            canChangeStates = true;
            yield break;
        }

        public override IEnumerator Start()
        {
            SetTurnOrder();

            yield return null;
            
            combatManager.ChangeToNewPlayerOrEnemyState();
        }

        private void SetTurnOrder()
        {
            List<Character> sortedList = new List<Character>();

            sortedList = combatManager.AllCharacters.OrderBy(x => x.Stats.CurrentSpeed)
                        .ToList();

            //Sort by highest speed
            sortedList.Reverse();

            foreach (Character character in sortedList)
            {
                combatManager.TurnOrder.Enqueue(character);
            }

            combatManager.CurrentCharacterTurn = combatManager.TurnOrder.Peek();
        }
    }
}