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

        public override IEnumerator End()
        {
            GameEventsManager.Instance.EnemyTurnFinished();
            yield break;
        }

        public override IEnumerator Start()
        {
            GameEventsManager.Instance.EnemyTurnStarted();

            yield return new WaitForSeconds(.2f);

            //PickRandomCharacter().TakeDamage(combatManager.CurrentCharacterTurn.Stats.CurrentStrength);

            yield return new WaitForSeconds(.5f);

            combatManager.ChangeToNewPlayerOrEnemyState();
        }

        //private Character PickRandomCharacter()
        //{
        //    var randomCharacter = combatManager.Friendlies[Random.Range(0, combatManager.Friendlies.Count + 1)];
        //    return randomCharacter;
        //}
    }
}